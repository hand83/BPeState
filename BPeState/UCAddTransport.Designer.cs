namespace BPeState
{
    partial class UCAddTransport
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
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.NTransport = new System.Windows.Forms.NumericUpDown();
            this.LabelNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // CBTransport
            // 
            this.CBTransport.FormattingEnabled = true;
            this.CBTransport.Location = new System.Drawing.Point(42, 53);
            this.CBTransport.Name = "CBTransport";
            this.CBTransport.Size = new System.Drawing.Size(200, 24);
            this.CBTransport.TabIndex = 0;
            // 
            // LabelTransport
            // 
            this.LabelTransport.AutoSize = true;
            this.LabelTransport.Location = new System.Drawing.Point(39, 33);
            this.LabelTransport.Name = "LabelTransport";
            this.LabelTransport.Size = new System.Drawing.Size(142, 17);
            this.LabelTransport.TabIndex = 1;
            this.LabelTransport.Text = "Public transport type:";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(42, 205);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 50);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // NTransport
            // 
            this.NTransport.Location = new System.Drawing.Point(42, 133);
            this.NTransport.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NTransport.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NTransport.Name = "NTransport";
            this.NTransport.Size = new System.Drawing.Size(200, 22);
            this.NTransport.TabIndex = 3;
            this.NTransport.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Location = new System.Drawing.Point(39, 113);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(62, 17);
            this.LabelNumber.TabIndex = 4;
            this.LabelNumber.Text = "Number:";
            // 
            // UCAddTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.NTransport);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.LabelTransport);
            this.Controls.Add(this.CBTransport);
            this.Name = "UCAddTransport";
            this.Size = new System.Drawing.Size(694, 461);
            ((System.ComponentModel.ISupportInitialize)(this.NTransport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTransport;
        private System.Windows.Forms.Label LabelTransport;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.NumericUpDown NTransport;
        private System.Windows.Forms.Label LabelNumber;
    }
}
