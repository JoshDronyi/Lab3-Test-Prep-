namespace Risk
{
    partial class frmBattle
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAttacker = new System.Windows.Forms.Label();
            this.lblDefender = new System.Windows.Forms.Label();
            this.lblAttackRoll = new System.Windows.Forms.Label();
            this.lblDefenseRoll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(104, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close!";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAttacker
            // 
            this.lblAttacker.AutoSize = true;
            this.lblAttacker.Location = new System.Drawing.Point(13, 53);
            this.lblAttacker.Name = "lblAttacker";
            this.lblAttacker.Size = new System.Drawing.Size(47, 13);
            this.lblAttacker.TabIndex = 2;
            this.lblAttacker.Text = "Attacker";
            // 
            // lblDefender
            // 
            this.lblDefender.AutoSize = true;
            this.lblDefender.Location = new System.Drawing.Point(221, 53);
            this.lblDefender.Name = "lblDefender";
            this.lblDefender.Size = new System.Drawing.Size(51, 13);
            this.lblDefender.TabIndex = 3;
            this.lblDefender.Text = "Defender";
            this.lblDefender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAttackRoll
            // 
            this.lblAttackRoll.AutoSize = true;
            this.lblAttackRoll.Location = new System.Drawing.Point(13, 70);
            this.lblAttackRoll.Name = "lblAttackRoll";
            this.lblAttackRoll.Size = new System.Drawing.Size(62, 13);
            this.lblAttackRoll.TabIndex = 4;
            this.lblAttackRoll.Text = "placeholder";
            // 
            // lblDefenseRoll
            // 
            this.lblDefenseRoll.AutoSize = true;
            this.lblDefenseRoll.Location = new System.Drawing.Point(210, 70);
            this.lblDefenseRoll.Name = "lblDefenseRoll";
            this.lblDefenseRoll.Size = new System.Drawing.Size(62, 13);
            this.lblDefenseRoll.TabIndex = 5;
            this.lblDefenseRoll.Text = "placeholder";
            this.lblDefenseRoll.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDefenseRoll);
            this.Controls.Add(this.lblAttackRoll);
            this.Controls.Add(this.lblDefender);
            this.Controls.Add(this.lblAttacker);
            this.Controls.Add(this.btnClose);
            this.Name = "frmBattle";
            this.Text = "frmBattle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAttacker;
        private System.Windows.Forms.Label lblDefender;
        private System.Windows.Forms.Label lblAttackRoll;
        private System.Windows.Forms.Label lblDefenseRoll;
    }
}