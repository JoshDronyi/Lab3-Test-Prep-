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
            this.components = new System.ComponentModel.Container();
            this.gpxNAmerica = new System.Windows.Forms.GroupBox();
            this.contextMenuPlayerMoves = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.attackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpxSAmerica = new System.Windows.Forms.GroupBox();
            this.gpxEurope = new System.Windows.Forms.GroupBox();
            this.gpxAsia = new System.Windows.Forms.GroupBox();
            this.gpxAfrica = new System.Windows.Forms.GroupBox();
            this.contextMenuPlayerMoves.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxNAmerica
            // 
            this.gpxNAmerica.ContextMenuStrip = this.contextMenuPlayerMoves;
            this.gpxNAmerica.Location = new System.Drawing.Point(12, 12);
            this.gpxNAmerica.Name = "gpxNAmerica";
            this.gpxNAmerica.Size = new System.Drawing.Size(153, 100);
            this.gpxNAmerica.TabIndex = 0;
            this.gpxNAmerica.TabStop = false;
            this.gpxNAmerica.Text = "North America";
            this.gpxNAmerica.Enter += new System.EventHandler(this.gpxNAmerica_Enter);
            // 
            // contextMenuPlayerMoves
            // 
            this.contextMenuPlayerMoves.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attackToolStripMenuItem,
            this.defendToolStripMenuItem});
            this.contextMenuPlayerMoves.Name = "contextMenuPlayerMoves";
            this.contextMenuPlayerMoves.Size = new System.Drawing.Size(109, 48);
            this.contextMenuPlayerMoves.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuPlayerMoves_Opening);
            // 
            // attackToolStripMenuItem
            // 
            this.attackToolStripMenuItem.Name = "attackToolStripMenuItem";
            this.attackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.attackToolStripMenuItem.Text = "Attack";
            this.attackToolStripMenuItem.Click += new System.EventHandler(this.attackToolStripMenuItem_Click);
            // 
            // defendToolStripMenuItem
            // 
            this.defendToolStripMenuItem.Name = "defendToolStripMenuItem";
            this.defendToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.defendToolStripMenuItem.Text = "Fortify";
            // 
            // gpxSAmerica
            // 
            this.gpxSAmerica.ContextMenuStrip = this.contextMenuPlayerMoves;
            this.gpxSAmerica.Location = new System.Drawing.Point(30, 118);
            this.gpxSAmerica.Name = "gpxSAmerica";
            this.gpxSAmerica.Size = new System.Drawing.Size(109, 134);
            this.gpxSAmerica.TabIndex = 1;
            this.gpxSAmerica.TabStop = false;
            this.gpxSAmerica.Text = "South America";
            // 
            // gpxEurope
            // 
            this.gpxEurope.ContextMenuStrip = this.contextMenuPlayerMoves;
            this.gpxEurope.Location = new System.Drawing.Point(218, 12);
            this.gpxEurope.Name = "gpxEurope";
            this.gpxEurope.Size = new System.Drawing.Size(118, 100);
            this.gpxEurope.TabIndex = 2;
            this.gpxEurope.TabStop = false;
            this.gpxEurope.Text = "Europe";
            // 
            // gpxAsia
            // 
            this.gpxAsia.ContextMenuStrip = this.contextMenuPlayerMoves;
            this.gpxAsia.Location = new System.Drawing.Point(342, 12);
            this.gpxAsia.Name = "gpxAsia";
            this.gpxAsia.Size = new System.Drawing.Size(200, 100);
            this.gpxAsia.TabIndex = 3;
            this.gpxAsia.TabStop = false;
            this.gpxAsia.Text = "Asia";
            // 
            // gpxAfrica
            // 
            this.gpxAfrica.ContextMenuStrip = this.contextMenuPlayerMoves;
            this.gpxAfrica.Location = new System.Drawing.Point(255, 118);
            this.gpxAfrica.Name = "gpxAfrica";
            this.gpxAfrica.Size = new System.Drawing.Size(200, 134);
            this.gpxAfrica.TabIndex = 4;
            this.gpxAfrica.TabStop = false;
            this.gpxAfrica.Text = "Africa";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 325);
            this.Controls.Add(this.gpxAfrica);
            this.Controls.Add(this.gpxAsia);
            this.Controls.Add(this.gpxEurope);
            this.Controls.Add(this.gpxSAmerica);
            this.Controls.Add(this.gpxNAmerica);
            this.Name = "frmMain";
            this.Text = "Risk!";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuPlayerMoves.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxNAmerica;
        private System.Windows.Forms.ContextMenuStrip contextMenuPlayerMoves;
        private System.Windows.Forms.ToolStripMenuItem attackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defendToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpxSAmerica;
        private System.Windows.Forms.GroupBox gpxEurope;
        private System.Windows.Forms.GroupBox gpxAsia;
        private System.Windows.Forms.GroupBox gpxAfrica;
    }
}

