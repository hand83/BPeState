namespace BPeState
{
    partial class UCAddStreet
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
            this.TBStreet = new System.Windows.Forms.TextBox();
            this.LabelStreet = new System.Windows.Forms.Label();
            this.CBDistrict = new System.Windows.Forms.ComboBox();
            this.LabelDistrict = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBStreet
            // 
            this.TBStreet.Location = new System.Drawing.Point(49, 57);
            this.TBStreet.Name = "TBStreet";
            this.TBStreet.Size = new System.Drawing.Size(400, 22);
            this.TBStreet.TabIndex = 0;
            // 
            // LabelStreet
            // 
            this.LabelStreet.AutoSize = true;
            this.LabelStreet.Location = new System.Drawing.Point(46, 37);
            this.LabelStreet.Name = "LabelStreet";
            this.LabelStreet.Size = new System.Drawing.Size(89, 17);
            this.LabelStreet.TabIndex = 1;
            this.LabelStreet.Text = "Street name:";
            // 
            // CBDistrict
            // 
            this.CBDistrict.FormattingEnabled = true;
            this.CBDistrict.Location = new System.Drawing.Point(49, 137);
            this.CBDistrict.Name = "CBDistrict";
            this.CBDistrict.Size = new System.Drawing.Size(400, 24);
            this.CBDistrict.TabIndex = 2;
            // 
            // LabelDistrict
            // 
            this.LabelDistrict.AutoSize = true;
            this.LabelDistrict.Location = new System.Drawing.Point(46, 117);
            this.LabelDistrict.Name = "LabelDistrict";
            this.LabelDistrict.Size = new System.Drawing.Size(55, 17);
            this.LabelDistrict.TabIndex = 3;
            this.LabelDistrict.Text = "District:";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(49, 211);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 50);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // UCAddStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.LabelDistrict);
            this.Controls.Add(this.CBDistrict);
            this.Controls.Add(this.LabelStreet);
            this.Controls.Add(this.TBStreet);
            this.Name = "UCAddStreet";
            this.Size = new System.Drawing.Size(731, 453);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBStreet;
        private System.Windows.Forms.Label LabelStreet;
        private System.Windows.Forms.ComboBox CBDistrict;
        private System.Windows.Forms.Label LabelDistrict;
        private System.Windows.Forms.Button ButtonAdd;
    }
}
