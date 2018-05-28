namespace BPeState
{
    partial class UCDelContractor
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
            this.CBContractor = new System.Windows.Forms.ComboBox();
            this.LabelContractor = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBContractor
            // 
            this.CBContractor.FormattingEnabled = true;
            this.CBContractor.Location = new System.Drawing.Point(45, 62);
            this.CBContractor.Name = "CBContractor";
            this.CBContractor.Size = new System.Drawing.Size(200, 24);
            this.CBContractor.TabIndex = 0;
            // 
            // LabelContractor
            // 
            this.LabelContractor.AutoSize = true;
            this.LabelContractor.Location = new System.Drawing.Point(42, 42);
            this.LabelContractor.Name = "LabelContractor";
            this.LabelContractor.Size = new System.Drawing.Size(117, 17);
            this.LabelContractor.TabIndex = 1;
            this.LabelContractor.Text = "Contractor name:";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(45, 127);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 50);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // UCDelContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.LabelContractor);
            this.Controls.Add(this.CBContractor);
            this.Name = "UCDelContractor";
            this.Size = new System.Drawing.Size(718, 394);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBContractor;
        private System.Windows.Forms.Label LabelContractor;
        private System.Windows.Forms.Button ButtonDelete;
    }
}
