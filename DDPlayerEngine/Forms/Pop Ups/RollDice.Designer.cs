
namespace PlayerEngine.Forms.Pop_Ups {
    partial class RollDice {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.RollDie = new System.Windows.Forms.Button();
            this.DiceSelector = new System.Windows.Forms.ComboBox();
            this.RollTotal = new System.Windows.Forms.Label();
            this.Advantage = new System.Windows.Forms.CheckBox();
            this.NumDice = new System.Windows.Forms.NumericUpDown();
            this.RollAnimator = new System.Timers.Timer();
            this.RollEnd = new System.Timers.Timer();
            this.RollHistory = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NumDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollAnimator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // RollDie
            // 
            this.RollDie.Location = new System.Drawing.Point(142, 10);
            this.RollDie.Name = "RollDie";
            this.RollDie.Size = new System.Drawing.Size(75, 23);
            this.RollDie.TabIndex = 0;
            this.RollDie.Text = "Roll";
            this.RollDie.UseVisualStyleBackColor = true;
            this.RollDie.Click += new System.EventHandler(this.RollDie_Click);
            // 
            // DiceSelector
            // 
            this.DiceSelector.FormattingEnabled = true;
            this.DiceSelector.Items.AddRange(new object[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20",
            "d100"});
            this.DiceSelector.Location = new System.Drawing.Point(60, 12);
            this.DiceSelector.Name = "DiceSelector";
            this.DiceSelector.Size = new System.Drawing.Size(73, 21);
            this.DiceSelector.TabIndex = 1;
            this.DiceSelector.Text = "d4";
            // 
            // RollTotal
            // 
            this.RollTotal.Location = new System.Drawing.Point(12, 66);
            this.RollTotal.Name = "RollTotal";
            this.RollTotal.Size = new System.Drawing.Size(205, 24);
            this.RollTotal.TabIndex = 2;
            this.RollTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Advantage
            // 
            this.Advantage.AutoSize = true;
            this.Advantage.Checked = true;
            this.Advantage.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Advantage.Location = new System.Drawing.Point(12, 39);
            this.Advantage.Name = "Advantage";
            this.Advantage.Size = new System.Drawing.Size(59, 17);
            this.Advantage.TabIndex = 3;
            this.Advantage.Text = "Normal";
            this.Advantage.ThreeState = true;
            this.Advantage.UseVisualStyleBackColor = true;
            this.Advantage.CheckStateChanged += new System.EventHandler(this.Advantage_CheckStateChanged);
            // 
            // NumDice
            // 
            this.NumDice.Location = new System.Drawing.Point(12, 13);
            this.NumDice.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NumDice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDice.Name = "NumDice";
            this.NumDice.Size = new System.Drawing.Size(42, 20);
            this.NumDice.TabIndex = 4;
            this.NumDice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // RollHistory
            // 
            this.RollHistory.AutoScroll = true;
            this.RollHistory.Location = new System.Drawing.Point(12, 93);
            this.RollHistory.Name = "RollHistory";
            this.RollHistory.Size = new System.Drawing.Size(205, 126);
            this.RollHistory.TabIndex = 6;
            // 
            // RollDice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(229, 231);
            this.Controls.Add(this.RollHistory);
            this.Controls.Add(this.NumDice);
            this.Controls.Add(this.Advantage);
            this.Controls.Add(this.RollTotal);
            this.Controls.Add(this.DiceSelector);
            this.Controls.Add(this.RollDie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RollDice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RollDice";
            ((System.ComponentModel.ISupportInitialize)(this.NumDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollAnimator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollDie;
        private System.Windows.Forms.ComboBox DiceSelector;
        private System.Windows.Forms.Label RollTotal;
        private System.Windows.Forms.CheckBox Advantage;
        private System.Windows.Forms.NumericUpDown NumDice;
        private System.Timers.Timer RollAnimator;
        private System.Timers.Timer RollEnd;
        private System.Windows.Forms.FlowLayoutPanel RollHistory;
    }
}