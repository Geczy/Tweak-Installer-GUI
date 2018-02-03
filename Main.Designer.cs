namespace Tweak_Installer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.install = new System.Windows.Forms.Button();
            this.Uninstall = new System.Windows.Forms.Button();
            this.host = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.iplabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.auto = new System.Windows.Forms.CheckBox();
            this.autolabel = new System.Windows.Forms.Label();
            this.portlbl = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paypalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.v13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uicacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // install
            // 
            this.install.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.install.FlatAppearance.BorderSize = 0;
            this.install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.install.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.install.ForeColor = System.Drawing.Color.Gainsboro;
            this.install.Location = new System.Drawing.Point(12, 221);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(220, 75);
            this.install.TabIndex = 5;
            this.install.Text = "Install";
            this.install.UseVisualStyleBackColor = false;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // Uninstall
            // 
            this.Uninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Uninstall.FlatAppearance.BorderSize = 0;
            this.Uninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uninstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.Uninstall.ForeColor = System.Drawing.Color.Gainsboro;
            this.Uninstall.Location = new System.Drawing.Point(238, 221);
            this.Uninstall.Name = "Uninstall";
            this.Uninstall.Size = new System.Drawing.Size(220, 75);
            this.Uninstall.TabIndex = 6;
            this.Uninstall.Text = "Uninstall";
            this.Uninstall.UseVisualStyleBackColor = false;
            this.Uninstall.Click += new System.EventHandler(this.Uninstall_Click);
            // 
            // host
            // 
            this.host.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.host.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.host.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.host.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host.ForeColor = System.Drawing.Color.White;
            this.host.Location = new System.Drawing.Point(228, 39);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(200, 27);
            this.host.TabIndex = 0;
            this.host.TextChanged += new System.EventHandler(this.host_TextChanged);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(228, 76);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(200, 27);
            this.pass.TabIndex = 1;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // iplabel
            // 
            this.iplabel.AutoSize = true;
            this.iplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.iplabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iplabel.Location = new System.Drawing.Point(96, 37);
            this.iplabel.Name = "iplabel";
            this.iplabel.Size = new System.Drawing.Size(126, 29);
            this.iplabel.TabIndex = 17;
            this.iplabel.Text = "device ip:";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.passwordlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordlabel.Location = new System.Drawing.Point(36, 76);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(186, 29);
            this.passwordlabel.TabIndex = 18;
            this.passwordlabel.Text = "root password:";
            // 
            // select
            // 
            this.select.AllowDrop = true;
            this.select.BackColor = System.Drawing.Color.LightGray;
            this.select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select.Enabled = false;
            this.select.FlatAppearance.BorderSize = 0;
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.select.ForeColor = System.Drawing.Color.Black;
            this.select.Location = new System.Drawing.Point(12, 164);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(446, 51);
            this.select.TabIndex = 4;
            this.select.Text = "Browse... (deb, ipa, zip)";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "example.deb";
            this.openFileDialog.Multiselect = true;
            // 
            // auto
            // 
            this.auto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auto.AutoSize = true;
            this.auto.Checked = true;
            this.auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.auto.FlatAppearance.BorderSize = 0;
            this.auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.auto.ForeColor = System.Drawing.Color.White;
            this.auto.Location = new System.Drawing.Point(78, 308);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(12, 11);
            this.auto.TabIndex = 9;
            this.auto.UseVisualStyleBackColor = true;
            // 
            // autolabel
            // 
            this.autolabel.AutoSize = true;
            this.autolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autolabel.ForeColor = System.Drawing.Color.DimGray;
            this.autolabel.Location = new System.Drawing.Point(96, 299);
            this.autolabel.Name = "autolabel";
            this.autolabel.Size = new System.Drawing.Size(312, 25);
            this.autolabel.TabIndex = 19;
            this.autolabel.Text = "automatic respring and uicache";
            this.autolabel.Click += new System.EventHandler(this.autolabel_Click);
            // 
            // portlbl
            // 
            this.portlbl.AutoSize = true;
            this.portlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.portlbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.portlbl.Location = new System.Drawing.Point(153, 106);
            this.portlbl.Name = "portlbl";
            this.portlbl.Size = new System.Drawing.Size(66, 29);
            this.portlbl.TabIndex = 21;
            this.portlbl.Text = "port:";
            // 
            // port
            // 
            this.port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.port.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.ForeColor = System.Drawing.Color.White;
            this.port.Location = new System.Drawing.Point(228, 109);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(200, 27);
            this.port.TabIndex = 20;
            this.port.TextChanged += new System.EventHandler(this.port_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heyToolStripMenuItem
            // 
            this.heyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heyToolStripMenuItem2,
            this.repringToolStripMenuItem,
            this.uicacheToolStripMenuItem});
            this.heyToolStripMenuItem.Name = "heyToolStripMenuItem";
            this.heyToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.heyToolStripMenuItem.Text = "File";
            this.heyToolStripMenuItem.Click += new System.EventHandler(this.heyToolStripMenuItem_Click);
            // 
            // heyToolStripMenuItem2
            // 
            this.heyToolStripMenuItem2.Name = "heyToolStripMenuItem2";
            this.heyToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.heyToolStripMenuItem2.Text = "Open terminal";
            this.heyToolStripMenuItem2.Click += new System.EventHandler(this.terminal_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heyToolStripMenuItem1,
            this.reportAnIssueToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // reportAnIssueToolStripMenuItem
            // 
            this.reportAnIssueToolStripMenuItem.Name = "reportAnIssueToolStripMenuItem";
            this.reportAnIssueToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.reportAnIssueToolStripMenuItem.Text = "Report an issue";
            this.reportAnIssueToolStripMenuItem.Click += new System.EventHandler(this.error_LinkClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitterToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.redditToolStripMenuItem,
            this.paypalToolStripMenuItem,
            this.v13ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.twitter_LinkClicked);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.github_LinkClicked);
            // 
            // redditToolStripMenuItem
            // 
            this.redditToolStripMenuItem.Name = "redditToolStripMenuItem";
            this.redditToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redditToolStripMenuItem.Text = "Reddit";
            this.redditToolStripMenuItem.Click += new System.EventHandler(this.reddit_LinkClicked);
            // 
            // paypalToolStripMenuItem
            // 
            this.paypalToolStripMenuItem.Name = "paypalToolStripMenuItem";
            this.paypalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paypalToolStripMenuItem.Text = "Paypal";
            this.paypalToolStripMenuItem.Click += new System.EventHandler(this.paypal_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // v13ToolStripMenuItem
            // 
            this.v13ToolStripMenuItem.Name = "v13ToolStripMenuItem";
            this.v13ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.v13ToolStripMenuItem.Text = "v1.3.2";
            // 
            // repringToolStripMenuItem
            // 
            this.repringToolStripMenuItem.Name = "repringToolStripMenuItem";
            this.repringToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.repringToolStripMenuItem.Text = "Respring";
            this.repringToolStripMenuItem.Click += new System.EventHandler(this.respring_Click);
            // 
            // uicacheToolStripMenuItem
            // 
            this.uicacheToolStripMenuItem.Name = "uicacheToolStripMenuItem";
            this.uicacheToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uicacheToolStripMenuItem.Text = "Uicache";
            this.uicacheToolStripMenuItem.Click += new System.EventHandler(this.uicache_Click);
            // 
            // heyToolStripMenuItem1
            // 
            this.heyToolStripMenuItem1.Name = "heyToolStripMenuItem1";
            this.heyToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.heyToolStripMenuItem1.Text = "Find debs";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 339);
            this.Controls.Add(this.portlbl);
            this.Controls.Add(this.port);
            this.Controls.Add(this.autolabel);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.select);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.iplabel);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.host);
            this.Controls.Add(this.Uninstall);
            this.Controls.Add(this.install);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Tweak Installer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button Uninstall;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label iplabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox auto;
        private System.Windows.Forms.Label autolabel;
        private System.Windows.Forms.Label portlbl;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heyToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAnIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paypalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uicacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heyToolStripMenuItem1;
    }
}

