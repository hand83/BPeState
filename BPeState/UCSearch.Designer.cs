namespace BPeState
{
    partial class UCSearch
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
            this.components = new System.ComponentModel.Container();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelArea = new System.Windows.Forms.Label();
            this.LabelRooms = new System.Windows.Forms.Label();
            this.LabelDistrict = new System.Windows.Forms.Label();
            this.TBPriceMin = new System.Windows.Forms.TextBox();
            this.TBPriceMax = new System.Windows.Forms.TextBox();
            this.TBAreaMin = new System.Windows.Forms.TextBox();
            this.TBAreaMax = new System.Windows.Forms.TextBox();
            this.TBRoomsMin = new System.Windows.Forms.TextBox();
            this.TBRoomsMax = new System.Windows.Forms.TextBox();
            this.CBDistrict = new System.Windows.Forms.ComboBox();
            this.PanelData = new System.Windows.Forms.Panel();
            this.DGVInv = new System.Windows.Forms.DataGridView();
            this.investmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IS_Inv_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IS_Inv_minPrice = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IS_Inv_maxPrice = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IS_Inv_minArea = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IS_Inv_maxArea = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IS_Inv_minRooms = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IS_Inv_maxRooms = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IS_Inv_nHomes = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IS_Str_Dist = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iSSKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investmentsFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetsFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.investmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(5, 6);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(126, 13);
            this.LabelPrice.TabIndex = 0;
            this.LabelPrice.Text = "Price range (million HUF):";
            // 
            // LabelArea
            // 
            this.LabelArea.AutoSize = true;
            this.LabelArea.Location = new System.Drawing.Point(5, 106);
            this.LabelArea.Name = "LabelArea";
            this.LabelArea.Size = new System.Drawing.Size(111, 13);
            this.LabelArea.TabIndex = 1;
            this.LabelArea.Text = "Area range (sq meter):";
            // 
            // LabelRooms
            // 
            this.LabelRooms.AutoSize = true;
            this.LabelRooms.Location = new System.Drawing.Point(5, 197);
            this.LabelRooms.Name = "LabelRooms";
            this.LabelRooms.Size = new System.Drawing.Size(114, 13);
            this.LabelRooms.TabIndex = 2;
            this.LabelRooms.Text = "No. of rooms (from, to):";
            // 
            // LabelDistrict
            // 
            this.LabelDistrict.AutoSize = true;
            this.LabelDistrict.Location = new System.Drawing.Point(5, 297);
            this.LabelDistrict.Name = "LabelDistrict";
            this.LabelDistrict.Size = new System.Drawing.Size(42, 13);
            this.LabelDistrict.TabIndex = 3;
            this.LabelDistrict.Text = "District:";
            // 
            // TBPriceMin
            // 
            this.TBPriceMin.Location = new System.Drawing.Point(8, 22);
            this.TBPriceMin.Name = "TBPriceMin";
            this.TBPriceMin.Size = new System.Drawing.Size(121, 20);
            this.TBPriceMin.TabIndex = 4;
            this.TBPriceMin.TextChanged += new System.EventHandler(this.TBFloatValidate);
            // 
            // TBPriceMax
            // 
            this.TBPriceMax.Location = new System.Drawing.Point(8, 48);
            this.TBPriceMax.Name = "TBPriceMax";
            this.TBPriceMax.Size = new System.Drawing.Size(121, 20);
            this.TBPriceMax.TabIndex = 5;
            this.TBPriceMax.TextChanged += new System.EventHandler(this.TBFloatValidate);
            // 
            // TBAreaMin
            // 
            this.TBAreaMin.Location = new System.Drawing.Point(8, 122);
            this.TBAreaMin.Name = "TBAreaMin";
            this.TBAreaMin.Size = new System.Drawing.Size(121, 20);
            this.TBAreaMin.TabIndex = 6;
            this.TBAreaMin.TextChanged += new System.EventHandler(this.TBIntValidate);
            // 
            // TBAreaMax
            // 
            this.TBAreaMax.Location = new System.Drawing.Point(8, 148);
            this.TBAreaMax.Name = "TBAreaMax";
            this.TBAreaMax.Size = new System.Drawing.Size(121, 20);
            this.TBAreaMax.TabIndex = 7;
            this.TBAreaMax.TextChanged += new System.EventHandler(this.TBIntValidate);
            // 
            // TBRoomsMin
            // 
            this.TBRoomsMin.Location = new System.Drawing.Point(8, 213);
            this.TBRoomsMin.Name = "TBRoomsMin";
            this.TBRoomsMin.Size = new System.Drawing.Size(121, 20);
            this.TBRoomsMin.TabIndex = 8;
            this.TBRoomsMin.TextChanged += new System.EventHandler(this.TBIntValidate);
            // 
            // TBRoomsMax
            // 
            this.TBRoomsMax.Location = new System.Drawing.Point(8, 239);
            this.TBRoomsMax.Name = "TBRoomsMax";
            this.TBRoomsMax.Size = new System.Drawing.Size(121, 20);
            this.TBRoomsMax.TabIndex = 9;
            this.TBRoomsMax.TextChanged += new System.EventHandler(this.TBIntValidate);
            // 
            // CBDistrict
            // 
            this.CBDistrict.FormattingEnabled = true;
            this.CBDistrict.Location = new System.Drawing.Point(8, 313);
            this.CBDistrict.Name = "CBDistrict";
            this.CBDistrict.Size = new System.Drawing.Size(121, 21);
            this.CBDistrict.TabIndex = 10;
            this.CBDistrict.SelectedIndexChanged += new System.EventHandler(this.CBDistrict_SelectedIndexChanged);
            // 
            // PanelData
            // 
            this.PanelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelData.Controls.Add(this.DGVInv);
            this.PanelData.Location = new System.Drawing.Point(135, 3);
            this.PanelData.Name = "PanelData";
            this.PanelData.Size = new System.Drawing.Size(611, 405);
            this.PanelData.TabIndex = 11;
            // 
            // DGVInv
            // 
            this.DGVInv.AllowUserToAddRows = false;
            this.DGVInv.AllowUserToDeleteRows = false;
            this.DGVInv.AllowUserToOrderColumns = true;
            this.DGVInv.AutoGenerateColumns = false;
            this.DGVInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IS_Inv_Name,
            this.IS_Inv_minPrice,
            this.IS_Inv_maxPrice,
            this.IS_Inv_minArea,
            this.IS_Inv_maxArea,
            this.IS_Inv_minRooms,
            this.IS_Inv_maxRooms,
            this.IS_Inv_nHomes,
            this.IS_Str_Dist,
            this.iSSKDataGridViewTextBoxColumn,
            this.investmentsFKDataGridViewTextBoxColumn,
            this.streetsFKDataGridViewTextBoxColumn,
            this.investmentDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn});
            this.DGVInv.DataSource = this.iSBindingSource;
            this.DGVInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVInv.Location = new System.Drawing.Point(0, 0);
            this.DGVInv.Name = "DGVInv";
            this.DGVInv.ReadOnly = true;
            this.DGVInv.RowHeadersWidth = 20;
            this.DGVInv.Size = new System.Drawing.Size(607, 401);
            this.DGVInv.TabIndex = 0;
            // 
            // investmentBindingSource
            // 
            this.investmentBindingSource.DataSource = typeof(BPeState.Investment);
            // 
            // streetBindingSource
            // 
            this.streetBindingSource.DataSource = typeof(BPeState.Street);
            // 
            // iSBindingSource
            // 
            this.iSBindingSource.DataSource = typeof(BPeState.IS);
            // 
            // IS_Inv_Name
            // 
            this.IS_Inv_Name.DataPropertyName = "Investments_FK";
            this.IS_Inv_Name.DataSource = this.investmentBindingSource;
            this.IS_Inv_Name.DisplayMember = "Name";
            this.IS_Inv_Name.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IS_Inv_Name.HeaderText = "Name";
            this.IS_Inv_Name.Name = "IS_Inv_Name";
            this.IS_Inv_Name.ReadOnly = true;
            this.IS_Inv_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IS_Inv_Name.ValueMember = "Investments_SK";
            this.IS_Inv_Name.Width = 130;
            // 
            // IS_Inv_minPrice
            // 
            this.IS_Inv_minPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IS_Inv_minPrice.DataPropertyName = "Investments_FK";
            this.IS_Inv_minPrice.DataSource = this.investmentBindingSource;
            this.IS_Inv_minPrice.DisplayMember = "Price_min";
            this.IS_Inv_minPrice.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IS_Inv_minPrice.HeaderText = "Min Price";
            this.IS_Inv_minPrice.Name = "IS_Inv_minPrice";
            this.IS_Inv_minPrice.ReadOnly = true;
            this.IS_Inv_minPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IS_Inv_minPrice.ValueMember = "Investments_SK";
            this.IS_Inv_minPrice.Width = 57;
            // 
            // IS_Inv_maxPrice
            // 
            this.IS_Inv_maxPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IS_Inv_maxPrice.DataPropertyName = "Investments_FK";
            this.IS_Inv_maxPrice.DataSource = this.investmentBindingSource;
            this.IS_Inv_maxPrice.DisplayMember = "Price_max";
            this.IS_Inv_maxPrice.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IS_Inv_maxPrice.HeaderText = "Max Price";
            this.IS_Inv_maxPrice.Name = "IS_Inv_maxPrice";
            this.IS_Inv_maxPrice.ReadOnly = true;
            this.IS_Inv_maxPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IS_Inv_maxPrice.ValueMember = "Investments_SK";
            this.IS_Inv_maxPrice.Width = 60;
            // 
            // IS_Inv_minArea
            // 
            this.IS_Inv_minArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IS_Inv_minArea.DataPropertyName = "Investments_FK";
            this.IS_Inv_minArea.DataSource = this.investmentBindingSource;
            this.IS_Inv_minArea.DisplayMember = "Area_min";
            this.IS_Inv_minArea.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IS_Inv_minArea.HeaderText = "Min Area";
            this.IS_Inv_minArea.Name = "IS_Inv_minArea";
            this.IS_Inv_minArea.ReadOnly = true;
            this.IS_Inv_minArea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IS_Inv_minArea.ValueMember = "Investments_SK";
            this.IS_Inv_minArea.Width = 55;
            // 
            // IS_Inv_maxArea
            // 
            this.IS_Inv_maxArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IS_Inv_maxArea.DataPropertyName = "Investments_FK";
            this.IS_Inv_maxArea.DataSource = this.investmentBindingSource;
            this.IS_Inv_maxArea.DisplayMember = "Area_max";
            this.IS_Inv_maxArea.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IS_Inv_maxArea.HeaderText = "Max Area";
            this.IS_Inv_maxArea.Name = "IS_Inv_maxArea";
            this.IS_Inv_maxArea.ReadOnly = true;
            this.IS_Inv_maxArea.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IS_Inv_maxArea.ValueMember = "Investments_SK";
            this.IS_Inv_maxArea.Width = 58;
            // 
            // IS_Inv_minRooms
            // 
            this.IS_Inv_minRooms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IS_Inv_minRooms.DataPropertyName = "Investments_FK";
            this.IS_Inv_minRooms.DataSource = this.investmentBindingSource;
            this.IS_Inv_minRooms.DisplayMember = "Rooms_min";
            this.IS_Inv_minRooms.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IS_Inv_minRooms.HeaderText = "Min Rooms";
            this.IS_Inv_minRooms.Name = "IS_Inv_minRooms";
            this.IS_Inv_minRooms.ReadOnly = true;
            this.IS_Inv_minRooms.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IS_Inv_minRooms.ValueMember = "Investments_SK";
            this.IS_Inv_minRooms.Width = 66;
            // 
            // IS_Inv_maxRooms
            // 
            this.IS_Inv_maxRooms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IS_Inv_maxRooms.DataPropertyName = "Investments_FK";
            this.IS_Inv_maxRooms.DataSource = this.investmentBindingSource;
            this.IS_Inv_maxRooms.DisplayMember = "Rooms_max";
            this.IS_Inv_maxRooms.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IS_Inv_maxRooms.HeaderText = "Max Rooms";
            this.IS_Inv_maxRooms.Name = "IS_Inv_maxRooms";
            this.IS_Inv_maxRooms.ReadOnly = true;
            this.IS_Inv_maxRooms.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IS_Inv_maxRooms.ValueMember = "Investments_SK";
            this.IS_Inv_maxRooms.Width = 69;
            // 
            // IS_Inv_nHomes
            // 
            this.IS_Inv_nHomes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IS_Inv_nHomes.DataPropertyName = "Investments_FK";
            this.IS_Inv_nHomes.DataSource = this.investmentBindingSource;
            this.IS_Inv_nHomes.DisplayMember = "No_of_homes";
            this.IS_Inv_nHomes.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IS_Inv_nHomes.HeaderText = "Number of Homes";
            this.IS_Inv_nHomes.Name = "IS_Inv_nHomes";
            this.IS_Inv_nHomes.ReadOnly = true;
            this.IS_Inv_nHomes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IS_Inv_nHomes.ValueMember = "Investments_SK";
            this.IS_Inv_nHomes.Width = 59;
            // 
            // IS_Str_Dist
            // 
            this.IS_Str_Dist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IS_Str_Dist.DataPropertyName = "Streets_FK";
            this.IS_Str_Dist.DataSource = this.streetBindingSource;
            this.IS_Str_Dist.DisplayMember = "District";
            this.IS_Str_Dist.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IS_Str_Dist.HeaderText = "District";
            this.IS_Str_Dist.Name = "IS_Str_Dist";
            this.IS_Str_Dist.ReadOnly = true;
            this.IS_Str_Dist.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IS_Str_Dist.ValueMember = "Streets_SK";
            this.IS_Str_Dist.Width = 45;
            // 
            // iSSKDataGridViewTextBoxColumn
            // 
            this.iSSKDataGridViewTextBoxColumn.DataPropertyName = "IS_SK";
            this.iSSKDataGridViewTextBoxColumn.HeaderText = "IS_SK";
            this.iSSKDataGridViewTextBoxColumn.Name = "iSSKDataGridViewTextBoxColumn";
            this.iSSKDataGridViewTextBoxColumn.ReadOnly = true;
            this.iSSKDataGridViewTextBoxColumn.Visible = false;
            // 
            // investmentsFKDataGridViewTextBoxColumn
            // 
            this.investmentsFKDataGridViewTextBoxColumn.DataPropertyName = "Investments_FK";
            this.investmentsFKDataGridViewTextBoxColumn.HeaderText = "Investments_FK";
            this.investmentsFKDataGridViewTextBoxColumn.Name = "investmentsFKDataGridViewTextBoxColumn";
            this.investmentsFKDataGridViewTextBoxColumn.ReadOnly = true;
            this.investmentsFKDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetsFKDataGridViewTextBoxColumn
            // 
            this.streetsFKDataGridViewTextBoxColumn.DataPropertyName = "Streets_FK";
            this.streetsFKDataGridViewTextBoxColumn.HeaderText = "Streets_FK";
            this.streetsFKDataGridViewTextBoxColumn.Name = "streetsFKDataGridViewTextBoxColumn";
            this.streetsFKDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetsFKDataGridViewTextBoxColumn.Visible = false;
            // 
            // investmentDataGridViewTextBoxColumn
            // 
            this.investmentDataGridViewTextBoxColumn.DataPropertyName = "Investment";
            this.investmentDataGridViewTextBoxColumn.HeaderText = "Investment";
            this.investmentDataGridViewTextBoxColumn.Name = "investmentDataGridViewTextBoxColumn";
            this.investmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.investmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Visible = false;
            // 
            // UCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelData);
            this.Controls.Add(this.CBDistrict);
            this.Controls.Add(this.TBRoomsMax);
            this.Controls.Add(this.TBRoomsMin);
            this.Controls.Add(this.TBAreaMax);
            this.Controls.Add(this.TBAreaMin);
            this.Controls.Add(this.TBPriceMax);
            this.Controls.Add(this.TBPriceMin);
            this.Controls.Add(this.LabelDistrict);
            this.Controls.Add(this.LabelRooms);
            this.Controls.Add(this.LabelArea);
            this.Controls.Add(this.LabelPrice);
            this.Name = "UCSearch";
            this.Size = new System.Drawing.Size(750, 411);
            this.PanelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.investmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelArea;
        private System.Windows.Forms.Label LabelRooms;
        private System.Windows.Forms.Label LabelDistrict;
        private System.Windows.Forms.TextBox TBPriceMin;
        private System.Windows.Forms.TextBox TBPriceMax;
        private System.Windows.Forms.TextBox TBAreaMin;
        private System.Windows.Forms.TextBox TBAreaMax;
        private System.Windows.Forms.TextBox TBRoomsMin;
        private System.Windows.Forms.TextBox TBRoomsMax;
        private System.Windows.Forms.ComboBox CBDistrict;
        private System.Windows.Forms.Panel PanelData;
        private System.Windows.Forms.DataGridView DGVInv;
        private System.Windows.Forms.BindingSource investmentBindingSource;
        private System.Windows.Forms.BindingSource streetBindingSource;
        private System.Windows.Forms.BindingSource iSBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn IS_Inv_Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn IS_Inv_minPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn IS_Inv_maxPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn IS_Inv_minArea;
        private System.Windows.Forms.DataGridViewComboBoxColumn IS_Inv_maxArea;
        private System.Windows.Forms.DataGridViewComboBoxColumn IS_Inv_minRooms;
        private System.Windows.Forms.DataGridViewComboBoxColumn IS_Inv_maxRooms;
        private System.Windows.Forms.DataGridViewComboBoxColumn IS_Inv_nHomes;
        private System.Windows.Forms.DataGridViewComboBoxColumn IS_Str_Dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSSKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn investmentsFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetsFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn investmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
    }
}
