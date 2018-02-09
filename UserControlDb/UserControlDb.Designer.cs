namespace UserControlDbLib
{
    partial class UserControlDb
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkLoveSports = new System.Windows.Forms.CheckBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkLoveSports
            // 
            this.chkLoveSports.AutoSize = true;
            this.chkLoveSports.Location = new System.Drawing.Point(443, 20);
            this.chkLoveSports.Name = "chkLoveSports";
            this.chkLoveSports.Size = new System.Drawing.Size(82, 17);
            this.chkLoveSports.TabIndex = 0;
            this.chkLoveSports.Text = "loveSports?";
            this.chkLoveSports.UseVisualStyleBackColor = true;
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(336, 20);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(54, 17);
            this.chkMale.TabIndex = 1;
            this.chkMale.Text = "male?";
            this.chkMale.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(51, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "firstName";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(115, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(51, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "lastName";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(247, 20);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(25, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "age";
            // 
            // UserControlDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.chkLoveSports);
            this.Name = "UserControlDb";
            this.Size = new System.Drawing.Size(538, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLoveSports;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
    }
}
