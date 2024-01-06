
namespace PlayerEngine.Custom_Elements.Play_Engine_Elements {
    partial class WeaponPreview {
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ItemType = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.RollAttack = new System.Windows.Forms.Button();
            this.RollDamage = new System.Windows.Forms.Button();
            this.ItemNotes = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ItemType);
            this.flowLayoutPanel1.Controls.Add(this.ItemName);
            this.flowLayoutPanel1.Controls.Add(this.RollAttack);
            this.flowLayoutPanel1.Controls.Add(this.RollDamage);
            this.flowLayoutPanel1.Controls.Add(this.ItemNotes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(570, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // ItemType
            // 
            this.ItemType.AutoSize = true;
            this.ItemType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemType.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemType.Location = new System.Drawing.Point(3, 0);
            this.ItemType.Name = "ItemType";
            this.ItemType.Size = new System.Drawing.Size(52, 45);
            this.ItemType.TabIndex = 3;
            this.ItemType.Text = "🏹";
            this.ItemType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemName.Location = new System.Drawing.Point(61, 0);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(42, 45);
            this.ItemName.TabIndex = 4;
            this.ItemName.Text = "Dagger";
            this.ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RollAttack
            // 
            this.RollAttack.AutoSize = true;
            this.RollAttack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RollAttack.Location = new System.Drawing.Point(109, 3);
            this.RollAttack.Name = "RollAttack";
            this.RollAttack.Size = new System.Drawing.Size(75, 39);
            this.RollAttack.TabIndex = 7;
            this.RollAttack.Text = "+1";
            this.RollAttack.UseVisualStyleBackColor = true;
            // 
            // RollDamage
            // 
            this.RollDamage.AutoSize = true;
            this.RollDamage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RollDamage.Location = new System.Drawing.Point(190, 3);
            this.RollDamage.Name = "RollDamage";
            this.RollDamage.Size = new System.Drawing.Size(127, 39);
            this.RollDamage.TabIndex = 8;
            this.RollDamage.Text = "1d4 Bludgeoning";
            this.RollDamage.UseVisualStyleBackColor = true;
            // 
            // ItemNotes
            // 
            this.ItemNotes.AutoSize = true;
            this.ItemNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemNotes.Location = new System.Drawing.Point(323, 0);
            this.ItemNotes.Name = "ItemNotes";
            this.ItemNotes.Size = new System.Drawing.Size(46, 45);
            this.ItemNotes.TabIndex = 6;
            this.ItemNotes.Text = "Thrown,";
            this.ItemNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeaponPreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "WeaponPreview";
            this.Size = new System.Drawing.Size(570, 42);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ItemType;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label ItemNotes;
        private System.Windows.Forms.Button RollAttack;
        private System.Windows.Forms.Button RollDamage;
    }
}
