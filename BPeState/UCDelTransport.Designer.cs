namespace BPeState
{
    partial class UCDelTransport
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
            this.CBTransport = new System.Windows.Forms.ComboBox();
            this.LabelTransport = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.CBNumber = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CBTransport
            // 
            this.CBTransport.FormattingEnabled = true;
            this.CBTransport.Location = new System.Drawing.Point(41, 50);
            this.CBTransport.Name = "CBTransport";
            this.CBTransport.Size = new System.Drawing.Size(200, 24);
            this.CBTransport.TabIndex = 0;
            // 
            // LabelTransport
            // 
            this.LabelTransport.AutoSize = true;
            this.LabelTransport.Location = new System.Drawing.Point(38, 30);
            this.LabelTransport.Name = "LabelTransport";
            this.LabelTransport.Size = new System.Drawing.Size(142, 17);
            this.LabelTransport.TabIndex = 1;
            this.LabelTransport.Text = "Public transport type:";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(41, 201);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 50);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(38, 113);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(62, 17);
            this.LabelNumber.TabIndex = 3;
            this.LabelNumber.Text = "Number:";
            // 
            // CBNumber
            // 
            this.CBNumber.FormattingEnabled = true;
            this.CBNumber.Location = new System.Drawing.Point(41, 133);
            this.CBNumber.Name = "CBNumber";
            this.CBNumber.Size = new System.Drawing.Size(200, 24);
            this.CBNumber.TabIndex = 4;
            // 
            // UCDelTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBNumber);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.LabelTransport);
            this.Controls.Add(this.CBTransport);
            this.Name = "UCDelTransport";
            this.Size = new System.Drawing.Size(614, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTransport;
        private System.Windows.Forms.Label LabelTransport;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.ComboBox CBNumber;
    }
}
