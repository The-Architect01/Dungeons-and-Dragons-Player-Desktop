
namespace PlayerEngine.Custom_Elements {
    partial class Stat {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CharacterName = new System.Windows.Forms.Label();
            this.CharName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Roll6Mod = new System.Windows.Forms.ComboBox();
            this.Roll5Mod = new System.Windows.Forms.ComboBox();
            this.Roll4Mod = new System.Windows.Forms.ComboBox();
            this.Roll3Mod = new System.Windows.Forms.ComboBox();
            this.Roll2Mod = new System.Windows.Forms.ComboBox();
            this.Roll1Mod = new System.Windows.Forms.ComboBox();
            this.Roll6Apply = new System.Windows.Forms.ComboBox();
            this.Roll5Apply = new System.Windows.Forms.ComboBox();
            this.Roll4Apply = new System.Windows.Forms.ComboBox();
            this.Roll3Apply = new System.Windows.Forms.ComboBox();
            this.Roll2Apply = new System.Windows.Forms.ComboBox();
            this.Roll1Apply = new System.Windows.Forms.ComboBox();
            this.Apply = new System.Windows.Forms.Button();
            this.Reroll = new System.Windows.Forms.Button();
            this.Roll6 = new System.Windows.Forms.Label();
            this.Roll5 = new System.Windows.Forms.Label();
            this.Roll4 = new System.Windows.Forms.Label();
            this.Roll3 = new System.Windows.Forms.Label();
            this.Roll2 = new System.Windows.Forms.Label();
            this.Roll1 = new System.Windows.Forms.Label();
            this.CHA = new System.Windows.Forms.Label();
            this.INT = new System.Windows.Forms.Label();
            this.WIS = new System.Windows.Forms.Label();
            this.CON = new System.Windows.Forms.Label();
            this.DEX = new System.Windows.Forms.Label();
            this.STR = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.CHAMod = new System.Windows.Forms.Label();
            this.INTMod = new System.Windows.Forms.Label();
            this.WISMod = new System.Windows.Forms.Label();
            this.CONMod = new System.Windows.Forms.Label();
            this.DEXMod = new System.Windows.Forms.Label();
            this.STRMod = new System.Windows.Forms.Label();
            this.RollAnimator = new System.Timers.Timer();
            this.RollEnd = new System.Timers.Timer();
            this.CharNouns = new System.Windows.Forms.TextBox();
            this.PronounLabel = new System.Windows.Forms.Label();
            this.AlignmentLabel = new System.Windows.Forms.Label();
            this.StatsLabel = new System.Windows.Forms.Label();
            this.CharAlign = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RollAnimator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // CharacterName
            // 
            this.CharacterName.AutoSize = true;
            this.CharacterName.Location = new System.Drawing.Point(5, 13);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(38, 13);
            this.CharacterName.TabIndex = 0;
            this.CharacterName.Text = "Name:";
            // 
            // CharName
            // 
            this.CharName.Location = new System.Drawing.Point(90, 10);
            this.CharName.Name = "CharName";
            this.CharName.Size = new System.Drawing.Size(210, 20);
            this.CharName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Roll6Mod);
            this.groupBox1.Controls.Add(this.Roll5Mod);
            this.groupBox1.Controls.Add(this.Roll4Mod);
            this.groupBox1.Controls.Add(this.Roll3Mod);
            this.groupBox1.Controls.Add(this.Roll2Mod);
            this.groupBox1.Controls.Add(this.Roll1Mod);
            this.groupBox1.Controls.Add(this.Roll6Apply);
            this.groupBox1.Controls.Add(this.Roll5Apply);
            this.groupBox1.Controls.Add(this.Roll4Apply);
            this.groupBox1.Controls.Add(this.Roll3Apply);
            this.groupBox1.Controls.Add(this.Roll2Apply);
            this.groupBox1.Controls.Add(this.Roll1Apply);
            this.groupBox1.Controls.Add(this.Apply);
            this.groupBox1.Controls.Add(this.Reroll);
            this.groupBox1.Controls.Add(this.Roll6);
            this.groupBox1.Controls.Add(this.Roll5);
            this.groupBox1.Controls.Add(this.Roll4);
            this.groupBox1.Controls.Add(this.Roll3);
            this.groupBox1.Controls.Add(this.Roll2);
            this.groupBox1.Controls.Add(this.Roll1);
            this.groupBox1.Location = new System.Drawing.Point(3, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 332);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rolls";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(218, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Roll 6";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(123, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Roll 5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(28, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Roll 4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(218, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Roll 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(123, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Roll 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Roll 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Roll6Mod
            // 
            this.Roll6Mod.Enabled = false;
            this.Roll6Mod.FormattingEnabled = true;
            this.Roll6Mod.Location = new System.Drawing.Point(218, 257);
            this.Roll6Mod.Name = "Roll6Mod";
            this.Roll6Mod.Size = new System.Drawing.Size(60, 21);
            this.Roll6Mod.TabIndex = 28;
            // 
            // Roll5Mod
            // 
            this.Roll5Mod.Enabled = false;
            this.Roll5Mod.FormattingEnabled = true;
            this.Roll5Mod.Location = new System.Drawing.Point(123, 257);
            this.Roll5Mod.Name = "Roll5Mod";
            this.Roll5Mod.Size = new System.Drawing.Size(60, 21);
            this.Roll5Mod.TabIndex = 27;
            // 
            // Roll4Mod
            // 
            this.Roll4Mod.Enabled = false;
            this.Roll4Mod.FormattingEnabled = true;
            this.Roll4Mod.Location = new System.Drawing.Point(28, 257);
            this.Roll4Mod.Name = "Roll4Mod";
            this.Roll4Mod.Size = new System.Drawing.Size(60, 21);
            this.Roll4Mod.TabIndex = 26;
            // 
            // Roll3Mod
            // 
            this.Roll3Mod.Enabled = false;
            this.Roll3Mod.FormattingEnabled = true;
            this.Roll3Mod.Location = new System.Drawing.Point(218, 122);
            this.Roll3Mod.Name = "Roll3Mod";
            this.Roll3Mod.Size = new System.Drawing.Size(60, 21);
            this.Roll3Mod.TabIndex = 25;
            // 
            // Roll2Mod
            // 
            this.Roll2Mod.Enabled = false;
            this.Roll2Mod.FormattingEnabled = true;
            this.Roll2Mod.Location = new System.Drawing.Point(123, 122);
            this.Roll2Mod.Name = "Roll2Mod";
            this.Roll2Mod.Size = new System.Drawing.Size(60, 21);
            this.Roll2Mod.TabIndex = 24;
            // 
            // Roll1Mod
            // 
            this.Roll1Mod.Enabled = false;
            this.Roll1Mod.FormattingEnabled = true;
            this.Roll1Mod.Location = new System.Drawing.Point(28, 122);
            this.Roll1Mod.Name = "Roll1Mod";
            this.Roll1Mod.Size = new System.Drawing.Size(60, 21);
            this.Roll1Mod.TabIndex = 23;
            // 
            // Roll6Apply
            // 
            this.Roll6Apply.FormattingEnabled = true;
            this.Roll6Apply.Items.AddRange(new object[] {
            "STR",
            "DEX",
            "CON",
            "WIS",
            "INT",
            "CHA"});
            this.Roll6Apply.Location = new System.Drawing.Point(218, 224);
            this.Roll6Apply.Name = "Roll6Apply";
            this.Roll6Apply.Size = new System.Drawing.Size(60, 21);
            this.Roll6Apply.TabIndex = 22;
            // 
            // Roll5Apply
            // 
            this.Roll5Apply.FormattingEnabled = true;
            this.Roll5Apply.Items.AddRange(new object[] {
            "STR",
            "DEX",
            "CON",
            "WIS",
            "INT",
            "CHA"});
            this.Roll5Apply.Location = new System.Drawing.Point(123, 224);
            this.Roll5Apply.Name = "Roll5Apply";
            this.Roll5Apply.Size = new System.Drawing.Size(60, 21);
            this.Roll5Apply.TabIndex = 21;
            // 
            // Roll4Apply
            // 
            this.Roll4Apply.FormattingEnabled = true;
            this.Roll4Apply.Items.AddRange(new object[] {
            "STR",
            "DEX",
            "CON",
            "WIS",
            "INT",
            "CHA"});
            this.Roll4Apply.Location = new System.Drawing.Point(28, 224);
            this.Roll4Apply.Name = "Roll4Apply";
            this.Roll4Apply.Size = new System.Drawing.Size(60, 21);
            this.Roll4Apply.TabIndex = 20;
            // 
            // Roll3Apply
            // 
            this.Roll3Apply.FormattingEnabled = true;
            this.Roll3Apply.Items.AddRange(new object[] {
            "STR",
            "DEX",
            "CON",
            "WIS",
            "INT",
            "CHA"});
            this.Roll3Apply.Location = new System.Drawing.Point(218, 89);
            this.Roll3Apply.Name = "Roll3Apply";
            this.Roll3Apply.Size = new System.Drawing.Size(60, 21);
            this.Roll3Apply.TabIndex = 19;
            // 
            // Roll2Apply
            // 
            this.Roll2Apply.FormattingEnabled = true;
            this.Roll2Apply.Items.AddRange(new object[] {
            "STR",
            "DEX",
            "CON",
            "WIS",
            "INT",
            "CHA"});
            this.Roll2Apply.Location = new System.Drawing.Point(123, 89);
            this.Roll2Apply.Name = "Roll2Apply";
            this.Roll2Apply.Size = new System.Drawing.Size(60, 21);
            this.Roll2Apply.TabIndex = 18;
            // 
            // Roll1Apply
            // 
            this.Roll1Apply.FormattingEnabled = true;
            this.Roll1Apply.Items.AddRange(new object[] {
            "STR",
            "DEX",
            "CON",
            "WIS",
            "INT",
            "CHA"});
            this.Roll1Apply.Location = new System.Drawing.Point(28, 89);
            this.Roll1Apply.Name = "Roll1Apply";
            this.Roll1Apply.Size = new System.Drawing.Size(60, 21);
            this.Roll1Apply.TabIndex = 17;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(229, 295);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 31);
            this.Apply.TabIndex = 16;
            this.Apply.Text = "Apply Rolls";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Reroll
            // 
            this.Reroll.Location = new System.Drawing.Point(146, 295);
            this.Reroll.Name = "Reroll";
            this.Reroll.Size = new System.Drawing.Size(75, 31);
            this.Reroll.TabIndex = 15;
            this.Reroll.Text = "Roll";
            this.Reroll.UseVisualStyleBackColor = true;
            this.Reroll.Click += new System.EventHandler(this.Reroll_Click);
            // 
            // Roll6
            // 
            this.Roll6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll6.Location = new System.Drawing.Point(218, 181);
            this.Roll6.Name = "Roll6";
            this.Roll6.Size = new System.Drawing.Size(60, 40);
            this.Roll6.TabIndex = 14;
            this.Roll6.Text = "8";
            this.Roll6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Roll5
            // 
            this.Roll5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll5.Location = new System.Drawing.Point(123, 181);
            this.Roll5.Name = "Roll5";
            this.Roll5.Size = new System.Drawing.Size(60, 40);
            this.Roll5.TabIndex = 13;
            this.Roll5.Text = "10";
            this.Roll5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Roll4
            // 
            this.Roll4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll4.Location = new System.Drawing.Point(28, 181);
            this.Roll4.Name = "Roll4";
            this.Roll4.Size = new System.Drawing.Size(60, 40);
            this.Roll4.TabIndex = 12;
            this.Roll4.Text = "12";
            this.Roll4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Roll3
            // 
            this.Roll3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll3.Location = new System.Drawing.Point(218, 46);
            this.Roll3.Name = "Roll3";
            this.Roll3.Size = new System.Drawing.Size(60, 40);
            this.Roll3.TabIndex = 11;
            this.Roll3.Text = "13";
            this.Roll3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Roll2
            // 
            this.Roll2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll2.Location = new System.Drawing.Point(123, 46);
            this.Roll2.Name = "Roll2";
            this.Roll2.Size = new System.Drawing.Size(60, 40);
            this.Roll2.TabIndex = 10;
            this.Roll2.Text = "14";
            this.Roll2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Roll1
            // 
            this.Roll1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll1.Location = new System.Drawing.Point(28, 46);
            this.Roll1.Name = "Roll1";
            this.Roll1.Size = new System.Drawing.Size(60, 40);
            this.Roll1.TabIndex = 9;
            this.Roll1.Text = "15";
            this.Roll1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHA
            // 
            this.CHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHA.Location = new System.Drawing.Point(201, 264);
            this.CHA.Name = "CHA";
            this.CHA.Size = new System.Drawing.Size(40, 40);
            this.CHA.TabIndex = 26;
            this.CHA.Text = "- -";
            this.CHA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INT
            // 
            this.INT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INT.Location = new System.Drawing.Point(147, 264);
            this.INT.Name = "INT";
            this.INT.Size = new System.Drawing.Size(40, 40);
            this.INT.TabIndex = 25;
            this.INT.Text = "- -";
            this.INT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WIS
            // 
            this.WIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WIS.Location = new System.Drawing.Point(93, 264);
            this.WIS.Name = "WIS";
            this.WIS.Size = new System.Drawing.Size(40, 40);
            this.WIS.TabIndex = 24;
            this.WIS.Text = "- -";
            this.WIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CON
            // 
            this.CON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CON.Location = new System.Drawing.Point(201, 175);
            this.CON.Name = "CON";
            this.CON.Size = new System.Drawing.Size(40, 40);
            this.CON.TabIndex = 23;
            this.CON.Text = "- -";
            this.CON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DEX
            // 
            this.DEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEX.Location = new System.Drawing.Point(147, 175);
            this.DEX.Name = "DEX";
            this.DEX.Size = new System.Drawing.Size(40, 40);
            this.DEX.TabIndex = 22;
            this.DEX.Text = "- -";
            this.DEX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STR
            // 
            this.STR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STR.Location = new System.Drawing.Point(93, 175);
            this.STR.Name = "STR";
            this.STR.Size = new System.Drawing.Size(40, 40);
            this.STR.TabIndex = 21;
            this.STR.Text = "- -";
            this.STR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(198, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 22);
            this.label14.TabIndex = 20;
            this.label14.Text = "CHA";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(144, 241);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 22);
            this.label15.TabIndex = 19;
            this.label15.Text = "INT";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(90, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 22);
            this.label16.TabIndex = 18;
            this.label16.Text = "WIS";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(198, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 22);
            this.label17.TabIndex = 17;
            this.label17.Text = "CON";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(144, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 22);
            this.label18.TabIndex = 16;
            this.label18.Text = "DEX";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(90, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 22);
            this.label19.TabIndex = 15;
            this.label19.Text = "STR";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHAMod
            // 
            this.CHAMod.Location = new System.Drawing.Point(198, 301);
            this.CHAMod.Name = "CHAMod";
            this.CHAMod.Size = new System.Drawing.Size(46, 22);
            this.CHAMod.TabIndex = 20;
            this.CHAMod.Text = "- -";
            this.CHAMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INTMod
            // 
            this.INTMod.Location = new System.Drawing.Point(144, 301);
            this.INTMod.Name = "INTMod";
            this.INTMod.Size = new System.Drawing.Size(46, 22);
            this.INTMod.TabIndex = 19;
            this.INTMod.Text = "- -";
            this.INTMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WISMod
            // 
            this.WISMod.Location = new System.Drawing.Point(90, 301);
            this.WISMod.Name = "WISMod";
            this.WISMod.Size = new System.Drawing.Size(46, 22);
            this.WISMod.TabIndex = 18;
            this.WISMod.Text = "- -";
            this.WISMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CONMod
            // 
            this.CONMod.Location = new System.Drawing.Point(198, 212);
            this.CONMod.Name = "CONMod";
            this.CONMod.Size = new System.Drawing.Size(46, 22);
            this.CONMod.TabIndex = 17;
            this.CONMod.Text = "- -";
            this.CONMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DEXMod
            // 
            this.DEXMod.Location = new System.Drawing.Point(144, 212);
            this.DEXMod.Name = "DEXMod";
            this.DEXMod.Size = new System.Drawing.Size(46, 22);
            this.DEXMod.TabIndex = 16;
            this.DEXMod.Text = "- -";
            this.DEXMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STRMod
            // 
            this.STRMod.Location = new System.Drawing.Point(90, 212);
            this.STRMod.Name = "STRMod";
            this.STRMod.Size = new System.Drawing.Size(46, 22);
            this.STRMod.TabIndex = 15;
            this.STRMod.Text = "- -";
            this.STRMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RollAnimator
            // 
            this.RollAnimator.SynchronizingObject = this;
            this.RollAnimator.Elapsed += new System.Timers.ElapsedEventHandler(this.RollAnimator_Elapsed);
            // 
            // RollEnd
            // 
            this.RollEnd.Interval = 1250D;
            this.RollEnd.SynchronizingObject = this;
            this.RollEnd.Elapsed += new System.Timers.ElapsedEventHandler(this.RollEnd_Elapsed);
            // 
            // CharNouns
            // 
            this.CharNouns.Location = new System.Drawing.Point(90, 51);
            this.CharNouns.Name = "CharNouns";
            this.CharNouns.Size = new System.Drawing.Size(210, 20);
            this.CharNouns.TabIndex = 28;
            // 
            // PronounLabel
            // 
            this.PronounLabel.AutoSize = true;
            this.PronounLabel.Location = new System.Drawing.Point(5, 54);
            this.PronounLabel.Name = "PronounLabel";
            this.PronounLabel.Size = new System.Drawing.Size(55, 13);
            this.PronounLabel.TabIndex = 27;
            this.PronounLabel.Text = "Pronouns:";
            // 
            // AlignmentLabel
            // 
            this.AlignmentLabel.AutoSize = true;
            this.AlignmentLabel.Location = new System.Drawing.Point(5, 95);
            this.AlignmentLabel.Name = "AlignmentLabel";
            this.AlignmentLabel.Size = new System.Drawing.Size(56, 13);
            this.AlignmentLabel.TabIndex = 29;
            this.AlignmentLabel.Text = "Alignment:";
            // 
            // StatsLabel
            // 
            this.StatsLabel.AutoSize = true;
            this.StatsLabel.Location = new System.Drawing.Point(5, 152);
            this.StatsLabel.Name = "StatsLabel";
            this.StatsLabel.Size = new System.Drawing.Size(34, 13);
            this.StatsLabel.TabIndex = 31;
            this.StatsLabel.Text = "Stats:";
            // 
            // CharAlign
            // 
            this.CharAlign.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CharAlign.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CharAlign.FormattingEnabled = true;
            this.CharAlign.Items.AddRange(new object[] {
            "Chaotic Good",
            "Neutral Good",
            "Lawful Good",
            "Chaotic Neutral",
            "Neutral",
            "Lawful Neutral",
            "Chaotic Evil",
            "Neutral Evil",
            "Lawful Evil"});
            this.CharAlign.Location = new System.Drawing.Point(90, 92);
            this.CharAlign.Name = "CharAlign";
            this.CharAlign.Size = new System.Drawing.Size(210, 21);
            this.CharAlign.TabIndex = 32;
            // 
            // Stat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.CharAlign);
            this.Controls.Add(this.StatsLabel);
            this.Controls.Add(this.AlignmentLabel);
            this.Controls.Add(this.CharNouns);
            this.Controls.Add(this.PronounLabel);
            this.Controls.Add(this.CHAMod);
            this.Controls.Add(this.CHA);
            this.Controls.Add(this.INTMod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WISMod);
            this.Controls.Add(this.INT);
            this.Controls.Add(this.CONMod);
            this.Controls.Add(this.CharName);
            this.Controls.Add(this.DEXMod);
            this.Controls.Add(this.STRMod);
            this.Controls.Add(this.WIS);
            this.Controls.Add(this.CharacterName);
            this.Controls.Add(this.CON);
            this.Controls.Add(this.DEX);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.STR);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Name = "Stat";
            this.Size = new System.Drawing.Size(325, 693);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RollAnimator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CharacterName;
        public System.Windows.Forms.TextBox CharName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Roll6;
        private System.Windows.Forms.Label Roll5;
        private System.Windows.Forms.Label Roll4;
        private System.Windows.Forms.Label Roll3;
        private System.Windows.Forms.Label Roll2;
        private System.Windows.Forms.Label Roll1;
        public System.Windows.Forms.Label CHA;
        public System.Windows.Forms.Label INT;
        public System.Windows.Forms.Label WIS;
        public System.Windows.Forms.Label CON;
        public System.Windows.Forms.Label DEX;
        public System.Windows.Forms.Label STR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label CHAMod;
        private System.Windows.Forms.Label INTMod;
        private System.Windows.Forms.Label WISMod;
        private System.Windows.Forms.Label CONMod;
        private System.Windows.Forms.Label DEXMod;
        private System.Windows.Forms.Label STRMod;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Reroll;
        private System.Windows.Forms.ComboBox Roll6Mod;
        private System.Windows.Forms.ComboBox Roll5Mod;
        private System.Windows.Forms.ComboBox Roll4Mod;
        private System.Windows.Forms.ComboBox Roll3Mod;
        private System.Windows.Forms.ComboBox Roll2Mod;
        private System.Windows.Forms.ComboBox Roll1Mod;
        private System.Windows.Forms.ComboBox Roll6Apply;
        private System.Windows.Forms.ComboBox Roll5Apply;
        private System.Windows.Forms.ComboBox Roll4Apply;
        private System.Windows.Forms.ComboBox Roll3Apply;
        private System.Windows.Forms.ComboBox Roll2Apply;
        private System.Windows.Forms.ComboBox Roll1Apply;
        private System.Timers.Timer RollAnimator;
        private System.Timers.Timer RollEnd;
        private System.Windows.Forms.Label AlignmentLabel;
        public System.Windows.Forms.TextBox CharNouns;
        private System.Windows.Forms.Label PronounLabel;
        private System.Windows.Forms.Label StatsLabel;
        public System.Windows.Forms.ComboBox CharAlign;
    }
}
