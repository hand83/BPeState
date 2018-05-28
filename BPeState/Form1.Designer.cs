namespace BPeState
{
    partial class Form1
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
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.ButtonDel);
            this.MenuPanel.Controls.Add(this.ButtonAdd);
            this.MenuPanel.Controls.Add(this.ButtonSearch);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPanel.MaximumSize = new System.Drawing.Size(0, 62);
            this.MenuPanel.MinimumSize = new System.Drawing.Size(0, 62);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1000, 62);
            this.MenuPanel.TabIndex = 0;
            // 
            // ButtonDel
            // 
            this.ButtonDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonDel.Location = new System.Drawing.Point(666, 0);
            this.ButtonDel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(333, 62);
            this.ButtonDel.TabIndex = 2;
            this.ButtonDel.Text = "Delete Record";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonAdd.Location = new System.Drawing.Point(333, 0);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(333, 62);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Add Record";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.AutoSize = true;
            this.ButtonSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonSearch.Location = new System.Drawing.Point(0, 0);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(333, 62);
            this.ButtonSearch.TabIndex = 0;
            this.ButtonSearch.Text = "Search Homes";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TaskPanel
            // 
            this.TaskPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskPanel.Location = new System.Drawing.Point(0, 62);
            this.TaskPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(1000, 505);
            this.TaskPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 567);
            this.Controls.Add(this.TaskPanel);
            this.Controls.Add(this.MenuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BPeState";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonSearch;
    }
}

