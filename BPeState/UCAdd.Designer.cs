namespace BPeState
{
    partial class UCAdd
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
            this.SubPanel = new System.Windows.Forms.Panel();
            this.TBAddPanel = new System.Windows.Forms.Label();
            this.CBTable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SubPanel
            // 
            this.SubPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubPanel.Location = new System.Drawing.Point(185, 3);
            this.SubPanel.Name = "SubPanel";
            this.SubPanel.Size = new System.Drawing.Size(812, 500);
            this.SubPanel.TabIndex = 0;
            // 
            // TBAddPanel
            // 
            this.TBAddPanel.Location = new System.Drawing.Point(3, 16);
            this.TBAddPanel.Name = "TBAddPanel";
            this.TBAddPanel.Size = new System.Drawing.Size(160, 40);
            this.TBAddPanel.TabIndex = 0;
            this.TBAddPanel.Text = "Select the table you want to add records to:";
            // 
            // CBTable
            // 
            this.CBTable.FormattingEnabled = true;
            this.CBTable.Location = new System.Drawing.Point(6, 60);
            this.CBTable.Name = "CBTable";
            this.CBTable.Size = new System.Drawing.Size(157, 24);
            this.CBTable.TabIndex = 1;
            this.CBTable.SelectedIndexChanged += new System.EventHandler(this.CBTable_SelectedIndexChanged);
            // 
            // UCAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBTable);
            this.Controls.Add(this.TBAddPanel);
            this.Controls.Add(this.SubPanel);
            this.Name = "UCAdd";
            this.Size = new System.Drawing.Size(1000, 506);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SubPanel;
        private System.Windows.Forms.Label TBAddPanel;
        private System.Windows.Forms.ComboBox CBTable;
    }
}
