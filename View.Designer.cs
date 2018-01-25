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
            ((System.ComponentModel.ISupportInitialize)(this.pluginViewCtrl1)).BeginInit();
            this.pluginViewCtrl1.Panel1.SuspendLayout();
            this.pluginViewCtrl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pluginViewCtrl1
            // 
            this.pluginViewCtrl1.CloseButtonVisible = false;
            this.pluginViewCtrl1.Component = null;
            this.pluginViewCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluginViewCtrl1.HasDependancies = false;
            this.pluginViewCtrl1.Localizer = null;
            this.pluginViewCtrl1.Location = new System.Drawing.Point(0, 0);
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
            this.pluginViewCtrl1.ShowSummary = true;
            this.pluginViewCtrl1.Size = new System.Drawing.Size(1300, 700);
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
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pluginViewCtrl1);
            this.Name = "View";
            this.Text = "Interface";
            this.pluginViewCtrl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pluginViewCtrl1)).EndInit();
            this.pluginViewCtrl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private Pic.Plugin.ViewCtrl.PluginViewCtrl pluginViewCtrl1;
        private System.Windows.Forms.ListView listView1;
    }
}