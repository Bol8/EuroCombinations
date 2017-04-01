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
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euromillonesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.primitivaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quinielaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 29);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Inicio";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.euromillonesToolStripMenuItem,
            this.primitivaToolStripMenuItem,
            this.quinielaToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem2.Text = "Loterias";
            // 
            // euromillonesToolStripMenuItem
            // 
            this.euromillonesToolStripMenuItem.Name = "euromillonesToolStripMenuItem";
            this.euromillonesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.euromillonesToolStripMenuItem.Text = "Euromillones";
            this.euromillonesToolStripMenuItem.Click += new System.EventHandler(this.euromillonesToolStripMenuItem_Click);
            // 
            // primitivaToolStripMenuItem
            // 
            this.primitivaToolStripMenuItem.Name = "primitivaToolStripMenuItem";
            this.primitivaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.primitivaToolStripMenuItem.Text = "Primitiva";
            // 
            // quinielaToolStripMenuItem
            // 
            this.quinielaToolStripMenuItem.Name = "quinielaToolStripMenuItem";
            this.quinielaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quinielaToolStripMenuItem.Text = "Quiniela";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.euromillonesToolStripMenuItem1,
            this.primitivaToolStripMenuItem1,
            this.quinielaToolStripMenuItem1});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // euromillonesToolStripMenuItem1
            // 
            this.euromillonesToolStripMenuItem1.Name = "euromillonesToolStripMenuItem1";
            this.euromillonesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.euromillonesToolStripMenuItem1.Text = "Euromillones";
            this.euromillonesToolStripMenuItem1.Click += new System.EventHandler(this.euromillonesToolStripMenuItem1_Click);
            // 
            // primitivaToolStripMenuItem1
            // 
            this.primitivaToolStripMenuItem1.Name = "primitivaToolStripMenuItem1";
            this.primitivaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.primitivaToolStripMenuItem1.Text = "Primitiva";
            // 
            // quinielaToolStripMenuItem1
            // 
            this.quinielaToolStripMenuItem1.Name = "quinielaToolStripMenuItem1";
            this.quinielaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quinielaToolStripMenuItem1.Text = "Quiniela";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euromillonesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem primitivaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quinielaToolStripMenuItem1;
    }
}

