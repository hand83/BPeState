namespace BPeState
{
    partial class UCDelStreet
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
            this.CBStreet = new System.Windows.Forms.ComboBox();
            this.CBDistrict = new System.Windows.Forms.ComboBox();
            this.LabelStreet = new System.Windows.Forms.Label();
            this.LabelDistrict = new System.Windows.Forms.Label();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBStreet
            // 
            this.CBStreet.FormattingEnabled = true;
            this.CBStreet.Location = new System.Drawing.Point(48, 123);
            this.CBStreet.Name = "CBStreet";
            this.CBStreet.Size = new System.Drawing.Size(150, 24);
            this.CBStreet.TabIndex = 0;
            // 
            // CBDistrict
            // 
            this.CBDistrict.FormattingEnabled = true;
            this.CBDistrict.Location = new System.Drawing.Point(48, 51);
            this.CBDistrict.Name = "CBDistrict";
            this.CBDistrict.Size = new System.Drawing.Size(150, 24);
            this.CBDistrict.TabIndex = 1;
            // 
            // LabelStreet
            // 
            this.LabelStreet.AutoSize = true;
            this.LabelStreet.Location = new System.Drawing.Point(45, 103);
            this.LabelStreet.Name = "LabelStreet";
            this.LabelStreet.Size = new System.Drawing.Size(91, 17);
            this.LabelStreet.TabIndex = 2;
            this.LabelStreet.Text = "Street Name:";
            // 
            // LabelDistrict
            // 
            this.LabelDistrict.AutoSize = true;
            this.LabelDistrict.Location = new System.Drawing.Point(45, 31);
            this.LabelDistrict.Name = "LabelDistrict";
            this.LabelDistrict.Size = new System.Drawing.Size(55, 17);
            this.LabelDistrict.TabIndex = 3;
            this.LabelDistrict.Text = "District:";
            // 
            // ButtonDel
            // 
            this.ButtonDel.Location = new System.Drawing.Point(48, 186);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(75, 50);
            this.ButtonDel.TabIndex = 4;
            this.ButtonDel.Text = "Delete";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // UCDelStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.LabelDistrict);
            this.Controls.Add(this.LabelStreet);
            this.Controls.Add(this.CBDistrict);
            this.Controls.Add(this.CBStreet);
            this.Name = "UCDelStreet";
            this.Size = new System.Drawing.Size(547, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBStreet;
        private System.Windows.Forms.ComboBox CBDistrict;
        private System.Windows.Forms.Label LabelStreet;
        private System.Windows.Forms.Label LabelDistrict;
        private System.Windows.Forms.Button ButtonDel;
    }
}
