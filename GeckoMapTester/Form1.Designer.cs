namespace GeckoMapTester
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IPBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.NameCBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisconnButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShootingRangeCheckBox = new System.Windows.Forms.CheckBox();
            this.VerCBox = new System.Windows.Forms.ComboBox();
            this.DojoCheckBox = new System.Windows.Forms.CheckBox();
            this.OnlineCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seCBox = new System.Windows.Forms.ComboBox();
            this.PokeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(6, 19);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(100, 20);
            this.IPBox.TabIndex = 0;
            this.IPBox.Text = "192.168.1.1";
            this.IPBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPBox_KeyDown);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(112, 17);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(112, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect to Gecko";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // NameCBox
            // 
            this.NameCBox.FormattingEnabled = true;
            this.NameCBox.Items.AddRange(new object[] {
            "Fld_Crank00_Vss",
            "Fld_Warehouse00_Vss",
            "Fld_SeaPlant00_Vss",
            "Fld_UpDown00_Vss",
            "Fld_SkatePark00_Vss",
            "Fld_Athletic00_Vss",
            "Fld_Amida00_Vss",
            "Fld_Maze00_Vss",
            "Fld_Tuzura00_Vss",
            "Fld_Ruins00_Vss",
            "Fld_ShootingRange_Shr",
            "Fld_Office00_Vss",
            "Fld_Quarry00_Vss",
            "Fld_Jyoheki00_Vss",
            "Fld_Pivot00_Vss",
            "Fld_Hiagari00_Vss",
            "Fld_Kaisou00_Vss",
            "Fld_Crank00_Dul",
            "Fld_Warehouse00_Dul",
            "Fld_SeaPlant00_Dul",
            "Fld_UpDown00_Dul",
            "Fld_SkatePark00_Dul",
            "Fld_Tutorial00_Ttr",
            "Fld_TutorialShow00_Ttr",
            "Fld_MatchRoom_Mch",
            "Fld_EasyHide00_Msn",
            "Fld_EasyClimb00_Msn",
            "Fld_EasyJump00_Msn",
            "Fld_Geyser00_Msn",
            "Fld_Sponge00_Msn",
            "Fld_Propeller00_Msn",
            "Fld_PaintingLift00_Msn",
            "Fld_RvlMaze00_Msn",
            "Fld_OctZero00_Msn",
            "Fld_InkRail00_Msn",
            "Fld_Invisible00_Msn",
            "Fld_Dozer00_Msn",
            "Fld_SlideLift00_Msn",
            "Fld_RvlSkatePark00_Msn",
            "Fld_OctRuins00_Msn",
            "Fld_Propeller01_Msn",
            "Fld_Charge00_Msn",
            "Fld_PaintingLift01_Msn",
            "Fld_TurnLift00_Msn",
            "Fld_RvlRuins00_Msn",
            "Fld_OctCrank00_Msn",
            "Fld_Trance00_Msn",
            "Fld_Sponge01_Msn",
            "Fld_Fusya00_Msn",
            "Fld_Dozer01_Msn",
            "Fld_RvlSeaPlant00_Msn",
            "Fld_OctSkatePark00_Msn",
            "Fld_BossStampKing_Bos_Msn",
            "Fld_BossCylinderKing_Bos_Msn",
            "Fld_BossBallKing_Bos_Msn",
            "Fld_BossMouthKing_Bos_Msn",
            "Fld_BossRailKing_Bos_Msn"});
            this.NameCBox.Location = new System.Drawing.Point(6, 40);
            this.NameCBox.Name = "NameCBox";
            this.NameCBox.Size = new System.Drawing.Size(257, 21);
            this.NameCBox.TabIndex = 2;
            this.NameCBox.Text = "Fld_BossMouthKing_Bos_Msn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisconnButton);
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Controls.Add(this.IPBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCPGecko Connection";
            // 
            // DisconnButton
            // 
            this.DisconnButton.Enabled = false;
            this.DisconnButton.Location = new System.Drawing.Point(230, 17);
            this.DisconnButton.Name = "DisconnButton";
            this.DisconnButton.Size = new System.Drawing.Size(112, 23);
            this.DisconnButton.TabIndex = 2;
            this.DisconnButton.Text = "Disconnect";
            this.DisconnButton.UseVisualStyleBackColor = true;
            this.DisconnButton.Click += new System.EventHandler(this.DisconnButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShootingRangeCheckBox);
            this.groupBox2.Controls.Add(this.VerCBox);
            this.groupBox2.Controls.Add(this.DojoCheckBox);
            this.groupBox2.Controls.Add(this.OnlineCheckBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.seCBox);
            this.groupBox2.Controls.Add(this.PokeButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.NameCBox);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 152);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // ShootingRangeCheckBox
            // 
            this.ShootingRangeCheckBox.AutoSize = true;
            this.ShootingRangeCheckBox.Location = new System.Drawing.Point(268, 67);
            this.ShootingRangeCheckBox.Name = "ShootingRangeCheckBox";
            this.ShootingRangeCheckBox.Size = new System.Drawing.Size(103, 17);
            this.ShootingRangeCheckBox.TabIndex = 17;
            this.ShootingRangeCheckBox.Text = "Shooting Range";
            this.ShootingRangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // VerCBox
            // 
            this.VerCBox.FormattingEnabled = true;
            this.VerCBox.Items.AddRange(new object[] {
            "2.12.0",
            "2.8.0",
            "2.7.0"});
            this.VerCBox.Location = new System.Drawing.Point(268, 91);
            this.VerCBox.Name = "VerCBox";
            this.VerCBox.Size = new System.Drawing.Size(73, 21);
            this.VerCBox.TabIndex = 16;
            this.VerCBox.Text = "2.12.0";
            // 
            // DojoCheckBox
            // 
            this.DojoCheckBox.AutoSize = true;
            this.DojoCheckBox.Location = new System.Drawing.Point(268, 45);
            this.DojoCheckBox.Name = "DojoCheckBox";
            this.DojoCheckBox.Size = new System.Drawing.Size(78, 17);
            this.DojoCheckBox.TabIndex = 15;
            this.DojoCheckBox.Text = "Battle Dojo";
            this.DojoCheckBox.UseVisualStyleBackColor = true;
            // 
            // OnlineCheckBox
            // 
            this.OnlineCheckBox.AutoSize = true;
            this.OnlineCheckBox.Checked = true;
            this.OnlineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OnlineCheckBox.Location = new System.Drawing.Point(268, 22);
            this.OnlineCheckBox.Name = "OnlineCheckBox";
            this.OnlineCheckBox.Size = new System.Drawing.Size(56, 17);
            this.OnlineCheckBox.TabIndex = 14;
            this.OnlineCheckBox.Text = "Online";
            this.OnlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "SceneEnvSet";
            // 
            // seCBox
            // 
            this.seCBox.FormattingEnabled = true;
            this.seCBox.Items.AddRange(new object[] {
            "<no change>",
            "MisSkyDay01",
            "MisSkyTwilight",
            "MisSkyDay",
            "MisSkyGreen",
            "MisSkySunset",
            "MisSkyNight",
            "MisSkyGray",
            "MisSkyNight",
            "MisSkyGalaxy",
            "MisTwilight",
            "MisDozer",
            "MisBattle",
            "MisMonitorBroken",
            "Mis",
            "Stampking",
            "CylinderKing",
            "BallKing",
            "Mouthking",
            "RailKing"});
            this.seCBox.Location = new System.Drawing.Point(6, 91);
            this.seCBox.Name = "seCBox";
            this.seCBox.Size = new System.Drawing.Size(257, 21);
            this.seCBox.TabIndex = 12;
            this.seCBox.Text = "<no change>";
            // 
            // PokeButton
            // 
            this.PokeButton.Location = new System.Drawing.Point(267, 118);
            this.PokeButton.Name = "PokeButton";
            this.PokeButton.Size = new System.Drawing.Size(75, 23);
            this.PokeButton.TabIndex = 11;
            this.PokeButton.Text = "Poke";
            this.PokeButton.UseVisualStyleBackColor = true;
            this.PokeButton.Click += new System.EventHandler(this.PokeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Credits to Amibu, NWPlayer, CFLean, and Sheldon       Forked ver. by Yahya14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "GeckoMapTester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ComboBox NameCBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PokeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DisconnButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox seCBox;
        private System.Windows.Forms.CheckBox DojoCheckBox;
        private System.Windows.Forms.CheckBox OnlineCheckBox;
        private System.Windows.Forms.CheckBox ShootingRangeCheckBox;
        private System.Windows.Forms.ComboBox VerCBox;
    }
}

