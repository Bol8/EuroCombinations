namespace LoteriaUI
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.euromillonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primitivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quinielaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1678, 36);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1678, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Inicio";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.euromillonesToolStripMenuItem,
            this.primitivaToolStripMenuItem,
            this.quinielaToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem2.Text = "Loterias";
            // 
            // euromillonesToolStripMenuItem
            // 
            this.euromillonesToolStripMenuItem.Name = "euromillonesToolStripMenuItem";
            this.euromillonesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.euromillonesToolStripMenuItem.Text = "Euromillones";
            this.euromillonesToolStripMenuItem.Click += new System.EventHandler(this.euromillonesToolStripMenuItem_Click);
            // 
            // primitivaToolStripMenuItem
            // 
            this.primitivaToolStripMenuItem.Name = "primitivaToolStripMenuItem";
            this.primitivaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.primitivaToolStripMenuItem.Text = "Primitiva";
            // 
            // quinielaToolStripMenuItem
            // 
            this.quinielaToolStripMenuItem.Name = "quinielaToolStripMenuItem";
            this.quinielaToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.quinielaToolStripMenuItem.Text = "Quiniela";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 952);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Loterias Resultados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem euromillonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primitivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quinielaToolStripMenuItem;
    }
}

