namespace BPeState
{
    partial class UCAddContractor
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
            this.LabelContractor = new System.Windows.Forms.Label();
            this.TBContractor = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelContractor
            // 
            this.LabelContractor.AutoSize = true;
            this.LabelContractor.Location = new System.Drawing.Point(46, 38);
            this.LabelContractor.Name = "LabelContractor";
            this.LabelContractor.Size = new System.Drawing.Size(119, 17);
            this.LabelContractor.TabIndex = 0;
            this.LabelContractor.Text = "Contractor Name:";
            // 
            // TBContractor
            // 
            this.TBContractor.Location = new System.Drawing.Point(48, 58);
            this.TBContractor.Name = "TBContractor";
            this.TBContractor.Size = new System.Drawing.Size(400, 22);
            this.TBContractor.TabIndex = 1;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(49, 127);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 50);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // UCAddContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TBContractor);
            this.Controls.Add(this.LabelContractor);
            this.Name = "UCAddContractor";
            this.Size = new System.Drawing.Size(672, 432);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelContractor;
        private System.Windows.Forms.TextBox TBContractor;
        private System.Windows.Forms.Button ButtonAdd;
    }
}
