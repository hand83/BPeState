namespace BPeState
{
    partial class FormAddInv
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelMinPrice = new System.Windows.Forms.Label();
            this.LabelMaxPrice = new System.Windows.Forms.Label();
            this.LabelMinArea = new System.Windows.Forms.Label();
            this.LabelMaxArea = new System.Windows.Forms.Label();
            this.LabelMinRooms = new System.Windows.Forms.Label();
            this.LabelMaxRooms = new System.Windows.Forms.Label();
            this.LabelFinish = new System.Windows.Forms.Label();
            this.LabelNHomes = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBMinPrice = new System.Windows.Forms.TextBox();
            this.TBMaxPrice = new System.Windows.Forms.TextBox();
            this.TBMinArea = new System.Windows.Forms.TextBox();
            this.TBMaxArea = new System.Windows.Forms.TextBox();
            this.TBMinRooms = new System.Windows.Forms.TextBox();
            this.TBMaxRooms = new System.Windows.Forms.TextBox();
            this.TBNHomes = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(20, 18);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(49, 17);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name:";
            // 
            // LabelMinPrice
            // 
            this.LabelMinPrice.AutoSize = true;
            this.LabelMinPrice.Location = new System.Drawing.Point(20, 72);
            this.LabelMinPrice.Name = "LabelMinPrice";
            this.LabelMinPrice.Size = new System.Drawing.Size(154, 17);
            this.LabelMinPrice.TabIndex = 1;
            this.LabelMinPrice.Text = "Min price (million HUF):";
            // 
            // LabelMaxPrice
            // 
            this.LabelMaxPrice.AutoSize = true;
            this.LabelMaxPrice.Location = new System.Drawing.Point(221, 72);
            this.LabelMaxPrice.Name = "LabelMaxPrice";
            this.LabelMaxPrice.Size = new System.Drawing.Size(157, 17);
            this.LabelMaxPrice.TabIndex = 2;
            this.LabelMaxPrice.Text = "Max price (million HUF):";
            // 
            // LabelMinArea
            // 
            this.LabelMinArea.AutoSize = true;
            this.LabelMinArea.Location = new System.Drawing.Point(20, 129);
            this.LabelMinArea.Name = "LabelMinArea";
            this.LabelMinArea.Size = new System.Drawing.Size(111, 17);
            this.LabelMinArea.TabIndex = 3;
            this.LabelMinArea.Text = "Min area (sq m):";
            // 
            // LabelMaxArea
            // 
            this.LabelMaxArea.AutoSize = true;
            this.LabelMaxArea.Location = new System.Drawing.Point(221, 129);
            this.LabelMaxArea.Name = "LabelMaxArea";
            this.LabelMaxArea.Size = new System.Drawing.Size(114, 17);
            this.LabelMaxArea.TabIndex = 4;
            this.LabelMaxArea.Text = "Max area (sq m):";
            // 
            // LabelMinRooms
            // 
            this.LabelMinRooms.AutoSize = true;
            this.LabelMinRooms.Location = new System.Drawing.Point(20, 188);
            this.LabelMinRooms.Name = "LabelMinRooms";
            this.LabelMinRooms.Size = new System.Drawing.Size(77, 17);
            this.LabelMinRooms.TabIndex = 5;
            this.LabelMinRooms.Text = "Min rooms:";
            // 
            // LabelMaxRooms
            // 
            this.LabelMaxRooms.AutoSize = true;
            this.LabelMaxRooms.Location = new System.Drawing.Point(221, 188);
            this.LabelMaxRooms.Name = "LabelMaxRooms";
            this.LabelMaxRooms.Size = new System.Drawing.Size(80, 17);
            this.LabelMaxRooms.TabIndex = 6;
            this.LabelMaxRooms.Text = "Max rooms:";
            // 
            // LabelFinish
            // 
            this.LabelFinish.AutoSize = true;
            this.LabelFinish.Location = new System.Drawing.Point(221, 245);
            this.LabelFinish.Name = "LabelFinish";
            this.LabelFinish.Size = new System.Drawing.Size(155, 17);
            this.LabelFinish.TabIndex = 7;
            this.LabelFinish.Text = "Expected date of finish:";
            // 
            // LabelNHomes
            // 
            this.LabelNHomes.AutoSize = true;
            this.LabelNHomes.Location = new System.Drawing.Point(23, 245);
            this.LabelNHomes.Name = "LabelNHomes";
            this.LabelNHomes.Size = new System.Drawing.Size(96, 17);
            this.LabelNHomes.TabIndex = 8;
            this.LabelNHomes.Text = "No. of homes:";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(23, 38);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(350, 22);
            this.TBName.TabIndex = 9;
            this.TBName.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBName.Validating += new System.ComponentModel.CancelEventHandler(this.TBName_Validating);
            // 
            // TBMinPrice
            // 
            this.TBMinPrice.Location = new System.Drawing.Point(26, 92);
            this.TBMinPrice.Name = "TBMinPrice";
            this.TBMinPrice.Size = new System.Drawing.Size(150, 22);
            this.TBMinPrice.TabIndex = 10;
            this.TBMinPrice.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBMinPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TBPrice_Validating);
            // 
            // TBMaxPrice
            // 
            this.TBMaxPrice.Location = new System.Drawing.Point(224, 92);
            this.TBMaxPrice.Name = "TBMaxPrice";
            this.TBMaxPrice.Size = new System.Drawing.Size(150, 22);
            this.TBMaxPrice.TabIndex = 11;
            this.TBMaxPrice.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBMaxPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TBPrice_Validating);
            // 
            // TBMinArea
            // 
            this.TBMinArea.Location = new System.Drawing.Point(26, 149);
            this.TBMinArea.Name = "TBMinArea";
            this.TBMinArea.Size = new System.Drawing.Size(150, 22);
            this.TBMinArea.TabIndex = 12;
            this.TBMinArea.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBMinArea.Validating += new System.ComponentModel.CancelEventHandler(this.TBArea_Validating);
            // 
            // TBMaxArea
            // 
            this.TBMaxArea.Location = new System.Drawing.Point(224, 149);
            this.TBMaxArea.Name = "TBMaxArea";
            this.TBMaxArea.Size = new System.Drawing.Size(150, 22);
            this.TBMaxArea.TabIndex = 13;
            this.TBMaxArea.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBMaxArea.Validating += new System.ComponentModel.CancelEventHandler(this.TBArea_Validating);
            // 
            // TBMinRooms
            // 
            this.TBMinRooms.Location = new System.Drawing.Point(26, 208);
            this.TBMinRooms.Name = "TBMinRooms";
            this.TBMinRooms.Size = new System.Drawing.Size(150, 22);
            this.TBMinRooms.TabIndex = 14;
            this.TBMinRooms.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBMinRooms.Validating += new System.ComponentModel.CancelEventHandler(this.TBRooms_Validating);
            // 
            // TBMaxRooms
            // 
            this.TBMaxRooms.Location = new System.Drawing.Point(224, 208);
            this.TBMaxRooms.Name = "TBMaxRooms";
            this.TBMaxRooms.Size = new System.Drawing.Size(150, 22);
            this.TBMaxRooms.TabIndex = 15;
            this.TBMaxRooms.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBMaxRooms.Validating += new System.ComponentModel.CancelEventHandler(this.TBRooms_Validating);
            // 
            // TBNHomes
            // 
            this.TBNHomes.Location = new System.Drawing.Point(26, 265);
            this.TBNHomes.Name = "TBNHomes";
            this.TBNHomes.Size = new System.Drawing.Size(150, 22);
            this.TBNHomes.TabIndex = 16;
            this.TBNHomes.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TBNHomes.Validating += new System.ComponentModel.CancelEventHandler(this.TBNHomes_Validating);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonSubmit.Location = new System.Drawing.Point(109, 327);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(75, 50);
            this.ButtonSubmit.TabIndex = 18;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(214, 327);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 50);
            this.ButtonCancel.TabIndex = 19;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(224, 265);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(154, 22);
            this.DatePicker.TabIndex = 20;
            // 
            // FormAddInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 393);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.TBNHomes);
            this.Controls.Add(this.TBMaxRooms);
            this.Controls.Add(this.TBMinRooms);
            this.Controls.Add(this.TBMaxArea);
            this.Controls.Add(this.TBMinArea);
            this.Controls.Add(this.TBMaxPrice);
            this.Controls.Add(this.TBMinPrice);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LabelNHomes);
            this.Controls.Add(this.LabelFinish);
            this.Controls.Add(this.LabelMaxRooms);
            this.Controls.Add(this.LabelMinRooms);
            this.Controls.Add(this.LabelMaxArea);
            this.Controls.Add(this.LabelMinArea);
            this.Controls.Add(this.LabelMaxPrice);
            this.Controls.Add(this.LabelMinPrice);
            this.Controls.Add(this.LabelName);
            this.Name = "FormAddInv";
            this.Text = "Add Investment record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelMinPrice;
        private System.Windows.Forms.Label LabelMaxPrice;
        private System.Windows.Forms.Label LabelMinArea;
        private System.Windows.Forms.Label LabelMaxArea;
        private System.Windows.Forms.Label LabelMinRooms;
        private System.Windows.Forms.Label LabelMaxRooms;
        private System.Windows.Forms.Label LabelFinish;
        private System.Windows.Forms.Label LabelNHomes;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Button ButtonCancel;
        public System.Windows.Forms.TextBox TBName;
        public System.Windows.Forms.TextBox TBMinPrice;
        public System.Windows.Forms.TextBox TBMaxPrice;
        public System.Windows.Forms.TextBox TBMinArea;
        public System.Windows.Forms.TextBox TBMaxArea;
        public System.Windows.Forms.TextBox TBMinRooms;
        public System.Windows.Forms.TextBox TBMaxRooms;
        public System.Windows.Forms.TextBox TBNHomes;
        public System.Windows.Forms.DateTimePicker DatePicker;
    }
}