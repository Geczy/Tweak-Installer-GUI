//Copyright 2018 josephwalden
//Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSCP;

namespace Tweak_Installer
{
    public partial class Main : Form
    {
        static bool verbose = false;
        bool enabled = false;
        static List<string> debs = new List<string>();
        public Main()
        {
            InitializeComponent();
        }
        string join(List<string> s, string i)
        {
            string temp = "";
            foreach (string j in s)
            {
                temp += '"' + j + '"' + i;
            }
            return temp;
        }
        private void select_Click(object sender, EventArgs e)
        {
            debs.Clear();
            var f = openFileDialog.ShowDialog();
            switch (f)
            {
                case DialogResult.OK:
                    {
                        enabled = true;
                        foreach (string i in openFileDialog.FileNames)
                        {
                            debs.Add(i);
                        }
                        break;
                    }
                default:
                    enabled = false;
                    break;
            }
        }

        private void install_Click(object sender, EventArgs e)
        {
            if (!enabled)
            {
                MessageBox.Show("Please select a deb, ipa or zip first");
                return;
            }
            Process.Start("tic.exe", "dont-update " + (!auto.Checked ? "dont-respring dont-refresh " : "") + (verbose ? "verbose " : "") + " install " + join(debs, " "));
        }

        private void Uninstall_Click(object sender, EventArgs e)
        {
            if (!enabled)
            {
                MessageBox.Show("Please select a deb, ipa or zip first");
                return;
            }
            Process.Start("tic.exe", "dont-update " + (!auto.Checked ? "dont-respring dont-refresh " : "") + (verbose ? "verbose " : "") + " uninstall " + join(debs, " "));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ContextMenu installmenu = new ContextMenu();
            installmenu.MenuItems.Add("Install Filza");
            installmenu.MenuItems[0].Click += InstallFilza;

            install.ContextMenu = installmenu;

            ContextMenu uninstallmenu = new ContextMenu();
            uninstallmenu.MenuItems.Add("Uninstall Filza");
            uninstallmenu.MenuItems[0].Click += RemoveFilza;

            Uninstall.ContextMenu = uninstallmenu;
            //check for updates
            try
            {
                using (WebClient client = new WebClient())
                {
                    string version = client.DownloadString("https://raw.githubusercontent.com/josephwalden13/tweak-installer/master/bin/Debug/version.txt");
                    string current = File.ReadAllText("version.txt");
                    if (current != version)
                    {
                        var f = MessageBox.Show(caption: "Update Available!", text: ($"Version {version.Replace("\n", "")} released. Please download it from https://github.com/josephwalden13/tweak-installer/releases\nWould you like to update?"), buttons: MessageBoxButtons.YesNo);
                        if (f == DialogResult.Yes)
                        {
                            Process.Start("https://github.com/josephwalden13/tweak-installer/releases");
                        }
                    }
                }
            }
            catch { }
            if (!File.Exists("settings"))
            {
                string[] def = new string[] { "192.168.1.1", "22", "" };
                File.WriteAllLines("settings", def);
            }
            string[] data = File.ReadAllLines("settings"); //get ssh settings
            for (int i = 0; i != data.Length; i++)
            {
                data[i] = data[i].Split('#')[0];
            }
            host.Text = data[0];
            port.Text = data[1];
            pass.Text = data[2];
            if (port.Text == "" || port.Text == "root")
            {
                port.Text = "22";
            }
        }

        private void RemoveFilza(object sender, EventArgs e)
        {
            MessageBox.Show("This could take up to a minute");
            Session s = openServer();
            s.ExecuteCommand("rm -r /Applications/Filza.app");
            s.ExecuteCommand("uicache");
            s.Close();
        }

        Session openServer()
        {
            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Sftp,
                HostName = host.Text,
                UserName = "root",
                Password = pass.Text,
                PortNumber = int.Parse(port.Text),
                GiveUpSecurityAndAcceptAnySshHostKey = true
            };
            Session session = new Session();
            try
            {
                session.Open(sessionOptions);
            }
            catch (SessionRemoteException e)
            {
                if (e.ToString().Contains("refused")) MessageBox.Show("Error: SSH Connection Refused\nAre you jailbroken?\nHave you entered your devices IP and port correctly?");
                else if (e.ToString().Contains("Access denied")) MessageBox.Show("Error: SSH Connection Refused due to incorrect credentials. Are you sure you typed your password correctly?");
                else if (e.ToString().Contains("Cannot initialize SFTP protocol")) MessageBox.Show("Error: SFTP not available. Make sure you have sftp installed by default. For Yalu or Meridian, please install \"SCP and SFTP for dropbear\" by coolstar. For LibreIOS, make sure SFTP is moved to /usr/bin/.");
                else
                {
                    Clipboard.SetText(e.ToString());
                    MessageBox.Show("Unknown Error. Please use the big red bug report link and include some form of crash report. Error report copying to clipboard.");
                    throw e;
                }
                Environment.Exit(0);
            }
            return session;
        }
        private void InstallFilza(object sender, EventArgs e)
        {
            MessageBox.Show("This could take up to a minute");
            Session s = openServer();
            s.ExecuteCommand("rm Filza.tar");
            s.ExecuteCommand("wget dl.sparko.me/Filza.tar");
            s.ExecuteCommand("tar -xf Filza.tar");
            s.ExecuteCommand("rm -r /Applications/Filza.app");
            s.ExecuteCommand("mv Filza.app /Applications/Filza.app");
            s.ExecuteCommand("uicache");
            s.Close();
        }

        private void host_TextChanged(object sender, EventArgs e)
        {
            string[] data = { host.Text, port.Text, pass.Text };
            File.WriteAllLines("settings", data);
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            string[] data = { host.Text, port.Text, pass.Text };
            File.WriteAllLines("settings", data);
        }

        private void respring_Click(object sender, EventArgs e)
        {
            Process.Start("tic.exe", "dont-update no-install dont-refresh");
        }

        private void uicache_Click(object sender, EventArgs e)
        {
            Process.Start("tic.exe", "dont-update no-install dont-respring");
        }

        private void error_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/josephwalden13/tweak-installer/issues");
        }

        private void debslnk_Click(object sender, EventArgs e)
        {
            Process.Start("http://s0n1c.org/cydia/");
        }

        private void reddit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/user/josephwalden/");
        }

        private void creator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/user/josephwalden/");
        }

        private void ui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.reddit.com/user/brnnkr/");
        }

        private void twitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/jmw_2468");
        }

        private void github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/josephwalden13/");
        }

        private void paypal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://paypal.me/JosephWalden");
        }

        private void autolabel_Click(object sender, EventArgs e)
        {
            auto.Checked = !auto.Checked;
        }

        private void port_TextChanged(object sender, EventArgs e)
        {
            string[] data = { host.Text, port.Text, pass.Text };
            File.WriteAllLines("settings", data);
        }

        private void version_Click(object sender, EventArgs e)
        {
            verbose = true;
        }

        private void terminal_Click(object sender, EventArgs e)
        {
            Process.Start("putty.exe", host.Text + ":" + port.Text + " -l root -pw " + pass.Text);
        }
    }
}
