namespace Interface_Nicolas
{
    partial class EditProfilesForm
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
            this.profileListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profileListView
            // 
            this.profileListView.Location = new System.Drawing.Point(12, 12);
            this.profileListView.Name = "profileListView";
            this.profileListView.Size = new System.Drawing.Size(177, 237);
            this.profileListView.TabIndex = 0;
            this.profileListView.UseCompatibleStateImageBehavior = false;
            // 
            // button1 : Sélectionner
            // 
            this.button1.Location = new System.Drawing.Point(197, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sélectionner";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2 : Annuler
            // 
            this.button2.Location = new System.Drawing.Point(197, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditProfilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profileListView);
            this.Name = "EditProfilesForm";
            this.Text = "EditProfilesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView profileListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}