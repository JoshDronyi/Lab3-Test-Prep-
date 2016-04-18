namespace Risk
{
    partial class frmMain
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
            this.btnEurope = new System.Windows.Forms.Button();
            this.btnNAmerica = new System.Windows.Forms.Button();
            this.btnAsia = new System.Windows.Forms.Button();
            this.btnSAmerica = new System.Windows.Forms.Button();
            this.btnAfrica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEurope
            // 
            this.btnEurope.Location = new System.Drawing.Point(103, 73);
            this.btnEurope.Name = "btnEurope";
            this.btnEurope.Size = new System.Drawing.Size(75, 23);
            this.btnEurope.TabIndex = 0;
            this.btnEurope.Text = "Europe";
            this.btnEurope.UseVisualStyleBackColor = true;
            // 
            // btnNAmerica
            // 
            this.btnNAmerica.Location = new System.Drawing.Point(12, 73);
            this.btnNAmerica.Name = "btnNAmerica";
            this.btnNAmerica.Size = new System.Drawing.Size(75, 23);
            this.btnNAmerica.TabIndex = 1;
            this.btnNAmerica.Text = "N. America";
            this.btnNAmerica.UseVisualStyleBackColor = true;
            // 
            // btnAsia
            // 
            this.btnAsia.Location = new System.Drawing.Point(197, 73);
            this.btnAsia.Name = "btnAsia";
            this.btnAsia.Size = new System.Drawing.Size(75, 23);
            this.btnAsia.TabIndex = 2;
            this.btnAsia.Text = "Asia";
            this.btnAsia.UseVisualStyleBackColor = true;
            // 
            // btnSAmerica
            // 
            this.btnSAmerica.Location = new System.Drawing.Point(12, 102);
            this.btnSAmerica.Name = "btnSAmerica";
            this.btnSAmerica.Size = new System.Drawing.Size(75, 23);
            this.btnSAmerica.TabIndex = 3;
            this.btnSAmerica.Text = "S. America";
            this.btnSAmerica.UseVisualStyleBackColor = true;
            // 
            // btnAfrica
            // 
            this.btnAfrica.Location = new System.Drawing.Point(147, 102);
            this.btnAfrica.Name = "btnAfrica";
            this.btnAfrica.Size = new System.Drawing.Size(75, 23);
            this.btnAfrica.TabIndex = 4;
            this.btnAfrica.Text = "Africa";
            this.btnAfrica.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAfrica);
            this.Controls.Add(this.btnSAmerica);
            this.Controls.Add(this.btnAsia);
            this.Controls.Add(this.btnNAmerica);
            this.Controls.Add(this.btnEurope);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEurope;
        private System.Windows.Forms.Button btnNAmerica;
        private System.Windows.Forms.Button btnAsia;
        private System.Windows.Forms.Button btnSAmerica;
        private System.Windows.Forms.Button btnAfrica;
    }
}

