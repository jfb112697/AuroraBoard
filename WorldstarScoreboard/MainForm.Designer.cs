namespace S3
{
    partial class MainForm
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
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.P1Sponsor = new System.Windows.Forms.TextBox();
            this.P1Char = new System.Windows.Forms.TextBox();
            this.FlagsCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.P2Sponsor = new System.Windows.Forms.TextBox();
            this.P2Char = new System.Windows.Forms.TextBox();
            this.FlagsComboP2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.SendUpdateButton = new System.Windows.Forms.Button();
            this.Round = new System.Windows.Forms.TextBox();
            this.tournamentNameTextbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Comm2Twitter = new System.Windows.Forms.TextBox();
            this.Comm1Twitter = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Comm2Name = new System.Windows.Forms.TextBox();
            this.Comm1Name = new System.Windows.Forms.TextBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.StartServer = new System.Windows.Forms.Button();
            this.UrlLinkLabel = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnToggleRecording = new System.Windows.Forms.Button();
            this.showSets = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.twitchClip = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.NamesButton = new System.Windows.Forms.Button();
            this.smashggCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Score)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Score)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player1Name
            // 
            this.Player1Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Player1Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Player1Name.Location = new System.Drawing.Point(6, 32);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(100, 20);
            this.Player1Name.TabIndex = 1;
            this.Player1Name.TextChanged += new System.EventHandler(this.Player1Name_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.P1Sponsor);
            this.groupBox1.Controls.Add(this.P1Char);
            this.groupBox1.Controls.Add(this.FlagsCombo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Player1Score);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Player1Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // P1Sponsor
            // 
            this.P1Sponsor.AllowDrop = true;
            this.P1Sponsor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.P1Sponsor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.P1Sponsor.Location = new System.Drawing.Point(112, 32);
            this.P1Sponsor.Name = "P1Sponsor";
            this.P1Sponsor.Size = new System.Drawing.Size(100, 20);
            this.P1Sponsor.TabIndex = 2;
            this.P1Sponsor.TextChanged += new System.EventHandler(this.P1Sponsor_TextChanged);
            // 
            // P1Char
            // 
            this.P1Char.AllowDrop = true;
            this.P1Char.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.P1Char.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.P1Char.Location = new System.Drawing.Point(6, 72);
            this.P1Char.Name = "P1Char";
            this.P1Char.Size = new System.Drawing.Size(100, 20);
            this.P1Char.TabIndex = 3;
            this.P1Char.TextChanged += new System.EventHandler(this.P1Char_TextChanged);
            // 
            // FlagsCombo
            // 
            this.FlagsCombo.FormattingEnabled = true;
            this.FlagsCombo.Location = new System.Drawing.Point(6, 98);
            this.FlagsCombo.Name = "FlagsCombo";
            this.FlagsCombo.Size = new System.Drawing.Size(0, 21);
            this.FlagsCombo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Score";
            // 
            // Player1Score
            // 
            this.Player1Score.Location = new System.Drawing.Point(133, 71);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(43, 20);
            this.Player1Score.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sponsor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.P2Sponsor);
            this.groupBox2.Controls.Add(this.P2Char);
            this.groupBox2.Controls.Add(this.FlagsComboP2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Player2Score);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Player2Name);
            this.groupBox2.Location = new System.Drawing.Point(388, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // P2Sponsor
            // 
            this.P2Sponsor.AllowDrop = true;
            this.P2Sponsor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.P2Sponsor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.P2Sponsor.Location = new System.Drawing.Point(112, 32);
            this.P2Sponsor.Name = "P2Sponsor";
            this.P2Sponsor.Size = new System.Drawing.Size(100, 20);
            this.P2Sponsor.TabIndex = 2;
            // 
            // P2Char
            // 
            this.P2Char.AutoCompleteCustomSource.AddRange(new string[] {
            "Mario",
            "Luigi",
            "Yoshi",
            "DK",
            "Link",
            "Samus",
            "Kirby",
            "Fox",
            "Pikachu",
            "Jigglypuff",
            "Captain Falcon",
            "Ness",
            "Peach",
            "Bowser",
            "Doc",
            "Zelda",
            "Sheik",
            "Ganondorf",
            "Young Link",
            "Falco",
            "Mewtwo",
            "Pichu",
            "ICs",
            "Marth",
            "Roy",
            "G&W"});
            this.P2Char.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.P2Char.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.P2Char.Location = new System.Drawing.Point(6, 71);
            this.P2Char.Name = "P2Char";
            this.P2Char.Size = new System.Drawing.Size(100, 20);
            this.P2Char.TabIndex = 3;
            // 
            // FlagsComboP2
            // 
            this.FlagsComboP2.FormattingEnabled = true;
            this.FlagsComboP2.Location = new System.Drawing.Point(6, 98);
            this.FlagsComboP2.Name = "FlagsComboP2";
            this.FlagsComboP2.Size = new System.Drawing.Size(0, 21);
            this.FlagsComboP2.TabIndex = 8;
            this.FlagsComboP2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Score";
            // 
            // Player2Score
            // 
            this.Player2Score.Location = new System.Drawing.Point(133, 71);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(43, 20);
            this.Player2Score.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Character";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sponsor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // Player2Name
            // 
            this.Player2Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Player2Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Player2Name.Location = new System.Drawing.Point(6, 32);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(100, 20);
            this.Player2Name.TabIndex = 1;
            this.Player2Name.TextChanged += new System.EventHandler(this.Player2Name_TextChanged);
            // 
            // SendUpdateButton
            // 
            this.SendUpdateButton.Location = new System.Drawing.Point(534, 289);
            this.SendUpdateButton.Name = "SendUpdateButton";
            this.SendUpdateButton.Size = new System.Drawing.Size(106, 23);
            this.SendUpdateButton.TabIndex = 4;
            this.SendUpdateButton.Text = "Send Update";
            this.SendUpdateButton.UseVisualStyleBackColor = true;
            this.SendUpdateButton.Click += new System.EventHandler(this.SendUpdateButton_Click);
            // 
            // Round
            // 
            this.Round.Location = new System.Drawing.Point(6, 35);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(100, 20);
            this.Round.TabIndex = 1;
            // 
            // tournamentNameTextbox
            // 
            this.tournamentNameTextbox.Location = new System.Drawing.Point(6, 74);
            this.tournamentNameTextbox.Name = "tournamentNameTextbox";
            this.tournamentNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.tournamentNameTextbox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tournamentNameTextbox);
            this.groupBox3.Controls.Add(this.Round);
            this.groupBox3.Location = new System.Drawing.Point(12, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tournament";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Round";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tournament";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.Comm2Twitter);
            this.groupBox4.Controls.Add(this.Comm1Twitter);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.Comm2Name);
            this.groupBox4.Controls.Add(this.Comm1Name);
            this.groupBox4.Location = new System.Drawing.Point(388, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 100);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Commentary";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Commentator 1 Twitter";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(121, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Commentator 2 Twitter";
            // 
            // Comm2Twitter
            // 
            this.Comm2Twitter.Location = new System.Drawing.Point(124, 74);
            this.Comm2Twitter.Name = "Comm2Twitter";
            this.Comm2Twitter.Size = new System.Drawing.Size(100, 20);
            this.Comm2Twitter.TabIndex = 14;
            // 
            // Comm1Twitter
            // 
            this.Comm1Twitter.Location = new System.Drawing.Point(6, 74);
            this.Comm1Twitter.Name = "Comm1Twitter";
            this.Comm1Twitter.Size = new System.Drawing.Size(97, 20);
            this.Comm1Twitter.TabIndex = 13;
            this.Comm1Twitter.TextChanged += new System.EventHandler(this.Comm1Twitter_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Commentator 1";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Commentator 2";
            // 
            // Comm2Name
            // 
            this.Comm2Name.Location = new System.Drawing.Point(124, 32);
            this.Comm2Name.Name = "Comm2Name";
            this.Comm2Name.Size = new System.Drawing.Size(100, 20);
            this.Comm2Name.TabIndex = 0;
            // 
            // Comm1Name
            // 
            this.Comm1Name.Location = new System.Drawing.Point(6, 35);
            this.Comm1Name.Name = "Comm1Name";
            this.Comm1Name.Size = new System.Drawing.Size(97, 20);
            this.Comm1Name.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(453, 289);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 14;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // StartServer
            // 
            this.StartServer.Location = new System.Drawing.Point(372, 289);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(75, 23);
            this.StartServer.TabIndex = 16;
            this.StartServer.Text = "Start Server";
            this.StartServer.UseVisualStyleBackColor = true;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // UrlLinkLabel
            // 
            this.UrlLinkLabel.AutoSize = true;
            this.UrlLinkLabel.Location = new System.Drawing.Point(327, 358);
            this.UrlLinkLabel.Name = "UrlLinkLabel";
            this.UrlLinkLabel.Size = new System.Drawing.Size(0, 13);
            this.UrlLinkLabel.TabIndex = 17;
            this.UrlLinkLabel.Click += new System.EventHandler(this.UrlLinkLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Switch Ports";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "P1 Win";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(403, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "P2 Win";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(291, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Show OBS Controls";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnToggleRecording
            // 
            this.btnToggleRecording.Location = new System.Drawing.Point(191, 289);
            this.btnToggleRecording.Name = "btnToggleRecording";
            this.btnToggleRecording.Size = new System.Drawing.Size(94, 23);
            this.btnToggleRecording.TabIndex = 23;
            this.btnToggleRecording.Text = "Start Recording";
            this.btnToggleRecording.UseVisualStyleBackColor = true;
            this.btnToggleRecording.Click += new System.EventHandler(this.btnToggleRecording_Click);
            // 
            // showSets
            // 
            this.showSets.Location = new System.Drawing.Point(281, 229);
            this.showSets.Name = "showSets";
            this.showSets.Size = new System.Drawing.Size(82, 23);
            this.showSets.TabIndex = 24;
            this.showSets.Text = "Show Sets";
            this.showSets.UseVisualStyleBackColor = true;
            this.showSets.Click += new System.EventHandler(this.showSets_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(327, 336);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Twitch Clip Name";
            // 
            // twitchClip
            // 
            this.twitchClip.Location = new System.Drawing.Point(430, 333);
            this.twitchClip.Name = "twitchClip";
            this.twitchClip.Size = new System.Drawing.Size(84, 20);
            this.twitchClip.TabIndex = 26;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(534, 331);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Get Replay";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // NamesButton
            // 
            this.NamesButton.Location = new System.Drawing.Point(12, 289);
            this.NamesButton.Name = "NamesButton";
            this.NamesButton.Size = new System.Drawing.Size(94, 23);
            this.NamesButton.TabIndex = 28;
            this.NamesButton.Text = "Get Names";
            this.NamesButton.UseVisualStyleBackColor = true;
            this.NamesButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // smashggCheck
            // 
            this.smashggCheck.AutoSize = true;
            this.smashggCheck.Location = new System.Drawing.Point(484, 149);
            this.smashggCheck.Name = "smashggCheck";
            this.smashggCheck.Size = new System.Drawing.Size(133, 17);
            this.smashggCheck.TabIndex = 29;
            this.smashggCheck.Text = "Smash GG Automation";
            this.smashggCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.smashggCheck.UseVisualStyleBackColor = true;
            this.smashggCheck.CheckedChanged += new System.EventHandler(this.smashggCheck_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 393);
            this.Controls.Add(this.smashggCheck);
            this.Controls.Add(this.NamesButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.twitchClip);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.showSets);
            this.Controls.Add(this.btnToggleRecording);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UrlLinkLabel);
            this.Controls.Add(this.StartServer);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SendUpdateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "WorldStar Scoreboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Score)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Score)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Player1Score;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Player2Score;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Player2Name;
        private System.Windows.Forms.Button SendUpdateButton;
        private System.Windows.Forms.TextBox Round;
        private System.Windows.Forms.TextBox tournamentNameTextbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Comm2Name;
        private System.Windows.Forms.TextBox Comm1Name;
        private System.Windows.Forms.ComboBox FlagsCombo;
        private System.Windows.Forms.ComboBox FlagsComboP2;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.LinkLabel UrlLinkLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnToggleRecording;
        private System.Windows.Forms.Button showSets;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox twitchClip;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Comm2Twitter;
        private System.Windows.Forms.TextBox Comm1Twitter;
        private System.Windows.Forms.Button NamesButton;
        private System.Windows.Forms.TextBox P1Char;
        private System.Windows.Forms.TextBox P2Char;
        private System.Windows.Forms.TextBox P1Sponsor;
        private System.Windows.Forms.TextBox P2Sponsor;
        private System.Windows.Forms.CheckBox smashggCheck;
    }
}

