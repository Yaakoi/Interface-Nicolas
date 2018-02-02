namespace Interface_Nicolas
{
    partial class View
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
            this.pluginViewCtrl1 = new Pic.Plugin.ViewCtrl.PluginViewCtrl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paramètresdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propriétésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pluginViewCtrl1)).BeginInit();
            this.pluginViewCtrl1.Panel1.SuspendLayout();
            this.pluginViewCtrl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pluginViewCtrl1
            // 
            this.pluginViewCtrl1.CloseButtonVisible = false;
            this.pluginViewCtrl1.Component = null;
            this.pluginViewCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluginViewCtrl1.HasDependancies = false;
            this.pluginViewCtrl1.Localizer = null;
            this.pluginViewCtrl1.Location = new System.Drawing.Point(0, 24);
            this.pluginViewCtrl1.Name = "pluginViewCtrl1";
            // 
            // pluginViewCtrl1.Panel1
            // 
            this.pluginViewCtrl1.Panel1.Controls.Add(this.listView1);
            this.pluginViewCtrl1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.pluginViewCtrl1_Panel1_Paint);
            // 
            // pluginViewCtrl1.Panel2
            // 
            this.pluginViewCtrl1.Panel2.AutoScroll = true;
            this.pluginViewCtrl1.ParamValues = null;
            this.pluginViewCtrl1.ReflectionX = false;
            this.pluginViewCtrl1.ReflectionY = false;
            this.pluginViewCtrl1.ShowAxes = true;
            this.pluginViewCtrl1.ShowCotationsAuto = true;
            this.pluginViewCtrl1.ShowCotationsCode = false;
            this.pluginViewCtrl1.ShowSummary = false;
            this.pluginViewCtrl1.Size = new System.Drawing.Size(1300, 676);
            this.pluginViewCtrl1.SplitterDistance = 1050;
            this.pluginViewCtrl1.SplitterWidth = 1;
            this.pluginViewCtrl1.TabIndex = 0;
            this.pluginViewCtrl1.ValidateButtonVisible = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(48, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(232, 229);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paramètresdToolStripMenuItem
            // 
            this.paramètresdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propriétésToolStripMenuItem});
            this.paramètresdToolStripMenuItem.Name = "paramètresdToolStripMenuItem";
            this.paramètresdToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.paramètresdToolStripMenuItem.Text = "Spécial";
            this.paramètresdToolStripMenuItem.Click += new System.EventHandler(this.paramètresdToolStripMenuItem_Click);
            // 
            // propriétésToolStripMenuItem
            // 
            this.propriétésToolStripMenuItem.Name = "propriétésToolStripMenuItem";
            this.propriétésToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propriétésToolStripMenuItem.Text = "Propriétés";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pluginViewCtrl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "View";
            this.Text = "Interface";
            this.pluginViewCtrl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pluginViewCtrl1)).EndInit();
            this.pluginViewCtrl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private Pic.Plugin.ViewCtrl.PluginViewCtrl pluginViewCtrl1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paramètresdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propriétésToolStripMenuItem;
    }
}