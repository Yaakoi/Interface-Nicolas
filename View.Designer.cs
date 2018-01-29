namespace Interface_Nicolas
{
    partial class MainForm
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
            this.pluginViewCtrl = new Pic.Plugin.ViewCtrl.PluginViewCtrl();
            this.listView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pluginViewCtrl)).BeginInit();
            this.pluginViewCtrl.Panel1.SuspendLayout();
            this.pluginViewCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pluginViewCtrl1
            // 
            this.pluginViewCtrl.CloseButtonVisible = false;
            this.pluginViewCtrl.Component = null;
            this.pluginViewCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluginViewCtrl.HasDependancies = false;
            this.pluginViewCtrl.Localizer = null;
            this.pluginViewCtrl.Location = new System.Drawing.Point(0, 0);
            this.pluginViewCtrl.Name = "pluginViewCtrl1";
            // 
            // pluginViewCtrl1.Panel1
            // 
            this.pluginViewCtrl.Panel1.Controls.Add(this.listView);
            // 
            // pluginViewCtrl1.Panel2
            // 
            this.pluginViewCtrl.Panel2.AutoScroll = true;
            this.pluginViewCtrl.ParamValues = null;
            this.pluginViewCtrl.ReflectionX = false;
            this.pluginViewCtrl.ReflectionY = false;
            this.pluginViewCtrl.ShowAxes = true;
            this.pluginViewCtrl.ShowCotationsAuto = true;
            this.pluginViewCtrl.ShowCotationsCode = false;
            this.pluginViewCtrl.ShowSummary = true;
            this.pluginViewCtrl.Size = new System.Drawing.Size(1300, 700);
            this.pluginViewCtrl.SplitterDistance = 1050;
            this.pluginViewCtrl.SplitterWidth = 1;
            this.pluginViewCtrl.TabIndex = 0;
            this.pluginViewCtrl.ValidateButtonVisible = false;
            // 
            // listView1
            // 
            this.listView.Location = new System.Drawing.Point(48, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(232, 229);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pluginViewCtrl);
            this.Name = "View";
            this.Text = "Interface";
            this.pluginViewCtrl.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pluginViewCtrl)).EndInit();
            this.pluginViewCtrl.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private Pic.Plugin.ViewCtrl.PluginViewCtrl pluginViewCtrl;
        private System.Windows.Forms.ListView listView;
    }
}