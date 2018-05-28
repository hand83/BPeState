namespace BPeState
{
    partial class UCAddInv
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
            this.DGVAdd = new System.Windows.Forms.DataGridView();
            this.ButtonData = new System.Windows.Forms.Button();
            this.LBSelectedContr = new System.Windows.Forms.ListBox();
            this.LBSelectedStr = new System.Windows.Forms.ListBox();
            this.LBSelectedTr = new System.Windows.Forms.ListBox();
            this.ButtonRemoveContr = new System.Windows.Forms.Button();
            this.ButtonRemoveStr = new System.Windows.Forms.Button();
            this.ButtonRemoveTr = new System.Windows.Forms.Button();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.LabelContr = new System.Windows.Forms.Label();
            this.LabelSelectedContr = new System.Windows.Forms.Label();
            this.LabelAllContr = new System.Windows.Forms.Label();
            this.LabelStr = new System.Windows.Forms.Label();
            this.LabelSelectedStr = new System.Windows.Forms.Label();
            this.LabelAllStr = new System.Windows.Forms.Label();
            this.LabelSelectedTr = new System.Windows.Forms.Label();
            this.LabelAllTr = new System.Windows.Forms.Label();
            this.LabelTr = new System.Windows.Forms.Label();
            this.CBAllContr = new System.Windows.Forms.ComboBox();
            this.CBAllStr = new System.Windows.Forms.ComboBox();
            this.CBAllTr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAdd
            // 
            this.DGVAdd.AllowUserToAddRows = false;
            this.DGVAdd.AllowUserToDeleteRows = false;
            this.DGVAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVAdd.Location = new System.Drawing.Point(0, 0);
            this.DGVAdd.Name = "DGVAdd";
            this.DGVAdd.ReadOnly = true;
            this.DGVAdd.RowTemplate.Height = 24;
            this.DGVAdd.Size = new System.Drawing.Size(809, 134);
            this.DGVAdd.TabIndex = 0;
            // 
            // ButtonData
            // 
            this.ButtonData.Location = new System.Drawing.Point(312, 140);
            this.ButtonData.Name = "ButtonData";
            this.ButtonData.Size = new System.Drawing.Size(176, 23);
            this.ButtonData.TabIndex = 1;
            this.ButtonData.Text = "Enter Data";
            this.ButtonData.UseVisualStyleBackColor = true;
            this.ButtonData.Click += new System.EventHandler(this.ButtonData_Click);
            // 
            // LBSelectedContr
            // 
            this.LBSelectedContr.FormattingEnabled = true;
            this.LBSelectedContr.ItemHeight = 16;
            this.LBSelectedContr.Location = new System.Drawing.Point(10, 248);
            this.LBSelectedContr.Name = "LBSelectedContr";
            this.LBSelectedContr.Size = new System.Drawing.Size(150, 84);
            this.LBSelectedContr.TabIndex = 2;
            // 
            // LBSelectedStr
            // 
            this.LBSelectedStr.FormattingEnabled = true;
            this.LBSelectedStr.ItemHeight = 16;
            this.LBSelectedStr.Location = new System.Drawing.Point(290, 248);
            this.LBSelectedStr.Name = "LBSelectedStr";
            this.LBSelectedStr.Size = new System.Drawing.Size(150, 84);
            this.LBSelectedStr.TabIndex = 4;
            // 
            // LBSelectedTr
            // 
            this.LBSelectedTr.FormattingEnabled = true;
            this.LBSelectedTr.ItemHeight = 16;
            this.LBSelectedTr.Location = new System.Drawing.Point(563, 248);
            this.LBSelectedTr.Name = "LBSelectedTr";
            this.LBSelectedTr.Size = new System.Drawing.Size(150, 84);
            this.LBSelectedTr.TabIndex = 6;
            // 
            // ButtonRemoveContr
            // 
            this.ButtonRemoveContr.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonRemoveContr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveContr.Location = new System.Drawing.Point(163, 303);
            this.ButtonRemoveContr.Name = "ButtonRemoveContr";
            this.ButtonRemoveContr.Size = new System.Drawing.Size(75, 30);
            this.ButtonRemoveContr.TabIndex = 9;
            this.ButtonRemoveContr.Text = "Remove";
            this.ButtonRemoveContr.UseVisualStyleBackColor = false;
            this.ButtonRemoveContr.Click += new System.EventHandler(this.ButtonRemoveContr_Click);
            // 
            // ButtonRemoveStr
            // 
            this.ButtonRemoveStr.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonRemoveStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveStr.Location = new System.Drawing.Point(443, 303);
            this.ButtonRemoveStr.Name = "ButtonRemoveStr";
            this.ButtonRemoveStr.Size = new System.Drawing.Size(75, 30);
            this.ButtonRemoveStr.TabIndex = 11;
            this.ButtonRemoveStr.Text = "Remove";
            this.ButtonRemoveStr.UseVisualStyleBackColor = false;
            this.ButtonRemoveStr.Click += new System.EventHandler(this.ButtonRemoveStr_Click);
            // 
            // ButtonRemoveTr
            // 
            this.ButtonRemoveTr.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonRemoveTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemoveTr.Location = new System.Drawing.Point(715, 303);
            this.ButtonRemoveTr.Name = "ButtonRemoveTr";
            this.ButtonRemoveTr.Size = new System.Drawing.Size(75, 30);
            this.ButtonRemoveTr.TabIndex = 13;
            this.ButtonRemoveTr.Text = "Remove";
            this.ButtonRemoveTr.UseVisualStyleBackColor = false;
            this.ButtonRemoveTr.Click += new System.EventHandler(this.ButtonRemoveTr_Click);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(312, 443);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(176, 48);
            this.ButtonSubmit.TabIndex = 14;
            this.ButtonSubmit.Text = "Submit and Save";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // LabelContr
            // 
            this.LabelContr.AutoSize = true;
            this.LabelContr.Location = new System.Drawing.Point(7, 209);
            this.LabelContr.Name = "LabelContr";
            this.LabelContr.Size = new System.Drawing.Size(81, 17);
            this.LabelContr.TabIndex = 15;
            this.LabelContr.Text = "Contractors";
            // 
            // LabelSelectedContr
            // 
            this.LabelSelectedContr.AutoSize = true;
            this.LabelSelectedContr.Location = new System.Drawing.Point(7, 226);
            this.LabelSelectedContr.Name = "LabelSelectedContr";
            this.LabelSelectedContr.Size = new System.Drawing.Size(67, 17);
            this.LabelSelectedContr.TabIndex = 16;
            this.LabelSelectedContr.Text = "Selected:";
            // 
            // LabelAllContr
            // 
            this.LabelAllContr.AutoSize = true;
            this.LabelAllContr.Location = new System.Drawing.Point(7, 335);
            this.LabelAllContr.Name = "LabelAllContr";
            this.LabelAllContr.Size = new System.Drawing.Size(105, 17);
            this.LabelAllContr.TabIndex = 17;
            this.LabelAllContr.Text = "Add contractor:";
            // 
            // LabelStr
            // 
            this.LabelStr.AutoSize = true;
            this.LabelStr.Location = new System.Drawing.Point(287, 209);
            this.LabelStr.Name = "LabelStr";
            this.LabelStr.Size = new System.Drawing.Size(53, 17);
            this.LabelStr.TabIndex = 20;
            this.LabelStr.Text = "Streets";
            // 
            // LabelSelectedStr
            // 
            this.LabelSelectedStr.AutoSize = true;
            this.LabelSelectedStr.Location = new System.Drawing.Point(287, 226);
            this.LabelSelectedStr.Name = "LabelSelectedStr";
            this.LabelSelectedStr.Size = new System.Drawing.Size(67, 17);
            this.LabelSelectedStr.TabIndex = 19;
            this.LabelSelectedStr.Text = "Selected:";
            // 
            // LabelAllStr
            // 
            this.LabelAllStr.AutoSize = true;
            this.LabelAllStr.Location = new System.Drawing.Point(287, 335);
            this.LabelAllStr.Name = "LabelAllStr";
            this.LabelAllStr.Size = new System.Drawing.Size(77, 17);
            this.LabelAllStr.TabIndex = 18;
            this.LabelAllStr.Text = "Add street:";
            // 
            // LabelSelectedTr
            // 
            this.LabelSelectedTr.AutoSize = true;
            this.LabelSelectedTr.Location = new System.Drawing.Point(560, 228);
            this.LabelSelectedTr.Name = "LabelSelectedTr";
            this.LabelSelectedTr.Size = new System.Drawing.Size(67, 17);
            this.LabelSelectedTr.TabIndex = 23;
            this.LabelSelectedTr.Text = "Selected:";
            // 
            // LabelAllTr
            // 
            this.LabelAllTr.AutoSize = true;
            this.LabelAllTr.Location = new System.Drawing.Point(560, 337);
            this.LabelAllTr.Name = "LabelAllTr";
            this.LabelAllTr.Size = new System.Drawing.Size(98, 17);
            this.LabelAllTr.TabIndex = 22;
            this.LabelAllTr.Text = "Add transport:";
            // 
            // LabelTr
            // 
            this.LabelTr.AutoSize = true;
            this.LabelTr.Location = new System.Drawing.Point(560, 211);
            this.LabelTr.Name = "LabelTr";
            this.LabelTr.Size = new System.Drawing.Size(77, 17);
            this.LabelTr.TabIndex = 21;
            this.LabelTr.Text = "Transports";
            // 
            // CBAllContr
            // 
            this.CBAllContr.FormattingEnabled = true;
            this.CBAllContr.Location = new System.Drawing.Point(10, 355);
            this.CBAllContr.Name = "CBAllContr";
            this.CBAllContr.Size = new System.Drawing.Size(150, 24);
            this.CBAllContr.TabIndex = 24;
            // 
            // CBAllStr
            // 
            this.CBAllStr.FormattingEnabled = true;
            this.CBAllStr.Location = new System.Drawing.Point(290, 356);
            this.CBAllStr.Name = "CBAllStr";
            this.CBAllStr.Size = new System.Drawing.Size(150, 24);
            this.CBAllStr.TabIndex = 25;
            // 
            // CBAllTr
            // 
            this.CBAllTr.FormattingEnabled = true;
            this.CBAllTr.Location = new System.Drawing.Point(563, 355);
            this.CBAllTr.Name = "CBAllTr";
            this.CBAllTr.Size = new System.Drawing.Size(150, 24);
            this.CBAllTr.TabIndex = 26;
            // 
            // UCAddInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBAllTr);
            this.Controls.Add(this.CBAllStr);
            this.Controls.Add(this.CBAllContr);
            this.Controls.Add(this.LabelSelectedTr);
            this.Controls.Add(this.LabelAllTr);
            this.Controls.Add(this.LabelTr);
            this.Controls.Add(this.LabelStr);
            this.Controls.Add(this.LabelSelectedStr);
            this.Controls.Add(this.LabelAllStr);
            this.Controls.Add(this.LabelAllContr);
            this.Controls.Add(this.LabelSelectedContr);
            this.Controls.Add(this.LabelContr);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonRemoveTr);
            this.Controls.Add(this.ButtonRemoveStr);
            this.Controls.Add(this.ButtonRemoveContr);
            this.Controls.Add(this.LBSelectedTr);
            this.Controls.Add(this.LBSelectedStr);
            this.Controls.Add(this.LBSelectedContr);
            this.Controls.Add(this.ButtonData);
            this.Controls.Add(this.DGVAdd);
            this.Name = "UCAddInv";
            this.Size = new System.Drawing.Size(809, 494);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAdd;
        private System.Windows.Forms.Button ButtonData;
        private System.Windows.Forms.ListBox LBSelectedContr;
        private System.Windows.Forms.ListBox LBSelectedStr;
        private System.Windows.Forms.ListBox LBSelectedTr;
        private System.Windows.Forms.Button ButtonRemoveContr;
        private System.Windows.Forms.Button ButtonRemoveStr;
        private System.Windows.Forms.Button ButtonRemoveTr;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Label LabelContr;
        private System.Windows.Forms.Label LabelSelectedContr;
        private System.Windows.Forms.Label LabelAllContr;
        private System.Windows.Forms.Label LabelStr;
        private System.Windows.Forms.Label LabelSelectedStr;
        private System.Windows.Forms.Label LabelAllStr;
        private System.Windows.Forms.Label LabelSelectedTr;
        private System.Windows.Forms.Label LabelAllTr;
        private System.Windows.Forms.Label LabelTr;
        private System.Windows.Forms.ComboBox CBAllContr;
        private System.Windows.Forms.ComboBox CBAllStr;
        private System.Windows.Forms.ComboBox CBAllTr;
    }
}
