namespace LoteriaUI
{
    partial class FrmConfiguration
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPgEuromillones = new System.Windows.Forms.TabPage();
            this.tabPgPrimitiva = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 468);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPgEuromillones);
            this.tabControl1.Controls.Add(this.tabPgPrimitiva);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPgEuromillones
            // 
            this.tabPgEuromillones.Location = new System.Drawing.Point(4, 22);
            this.tabPgEuromillones.Name = "tabPgEuromillones";
            this.tabPgEuromillones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgEuromillones.Size = new System.Drawing.Size(806, 442);
            this.tabPgEuromillones.TabIndex = 0;
            this.tabPgEuromillones.Text = "Euromillones";
            this.tabPgEuromillones.UseVisualStyleBackColor = true;
            // 
            // tabPgPrimitiva
            // 
            this.tabPgPrimitiva.Location = new System.Drawing.Point(4, 22);
            this.tabPgPrimitiva.Name = "tabPgPrimitiva";
            this.tabPgPrimitiva.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgPrimitiva.Size = new System.Drawing.Size(806, 442);
            this.tabPgPrimitiva.TabIndex = 1;
            this.tabPgPrimitiva.Text = "Primitiva";
            this.tabPgPrimitiva.UseVisualStyleBackColor = true;
            // 
            // FrmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 468);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPgEuromillones;
        private System.Windows.Forms.TabPage tabPgPrimitiva;
    }
}