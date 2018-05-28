namespace BPeState
{
    partial class UCDelInvestment
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
            this.CBInvName = new System.Windows.Forms.ComboBox();
            this.LabelInvName = new System.Windows.Forms.Label();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.DGVPreview = new System.Windows.Forms.DataGridView();
            this.LabelPreview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // CBInvName
            // 
            this.CBInvName.FormattingEnabled = true;
            this.CBInvName.Location = new System.Drawing.Point(31, 47);
            this.CBInvName.Name = "CBInvName";
            this.CBInvName.Size = new System.Drawing.Size(400, 24);
            this.CBInvName.TabIndex = 0;
            // 
            // LabelInvName
            // 
            this.LabelInvName.AutoSize = true;
            this.LabelInvName.Location = new System.Drawing.Point(28, 27);
            this.LabelInvName.Name = "LabelInvName";
            this.LabelInvName.Size = new System.Drawing.Size(119, 17);
            this.LabelInvName.TabIndex = 1;
            this.LabelInvName.Text = "Investment name:";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(41, 284);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 50);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // DGVPreview
            // 
            this.DGVPreview.AllowUserToAddRows = false;
            this.DGVPreview.AllowUserToDeleteRows = false;
            this.DGVPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPreview.Location = new System.Drawing.Point(3, 111);
            this.DGVPreview.Name = "DGVPreview";
            this.DGVPreview.ReadOnly = true;
            this.DGVPreview.RowTemplate.Height = 24;
            this.DGVPreview.Size = new System.Drawing.Size(724, 150);
            this.DGVPreview.TabIndex = 3;
            // 
            // LabelPreview
            // 
            this.LabelPreview.AutoSize = true;
            this.LabelPreview.Location = new System.Drawing.Point(3, 91);
            this.LabelPreview.Name = "LabelPreview";
            this.LabelPreview.Size = new System.Drawing.Size(61, 17);
            this.LabelPreview.TabIndex = 4;
            this.LabelPreview.Text = "Preview:";
            // 
            // UCDelInvestment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelPreview);
            this.Controls.Add(this.DGVPreview);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.LabelInvName);
            this.Controls.Add(this.CBInvName);
            this.Name = "UCDelInvestment";
            this.Size = new System.Drawing.Size(730, 428);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBInvName;
        private System.Windows.Forms.Label LabelInvName;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.DataGridView DGVPreview;
        private System.Windows.Forms.Label LabelPreview;
    }
}
