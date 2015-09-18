namespace DrugBank
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtSearchDrug = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvDrugList = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDrugInteraction = new System.Windows.Forms.TabPage();
            this.dgvDrugInteraction = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDrugInformation = new System.Windows.Forms.TabPage();
            this.rtbDrugInfo = new System.Windows.Forms.RichTextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpDrugInteraction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugInteraction)).BeginInit();
            this.tpDrugInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel1MinSize = 22;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtSearchDrug);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.cmdSearch);
            this.splitContainer3.Size = new System.Drawing.Size(784, 25);
            this.splitContainer3.SplitterDistance = 666;
            this.splitContainer3.TabIndex = 0;
            // 
            // txtSearchDrug
            // 
            this.txtSearchDrug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchDrug.Location = new System.Drawing.Point(0, 0);
            this.txtSearchDrug.Multiline = true;
            this.txtSearchDrug.Name = "txtSearchDrug";
            this.txtSearchDrug.Size = new System.Drawing.Size(664, 23);
            this.txtSearchDrug.TabIndex = 0;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSearch.Location = new System.Drawing.Point(0, 0);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(112, 23);
            this.cmdSearch.TabIndex = 1;
            this.cmdSearch.Text = "Search Drug";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvDrugList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(784, 532);
            this.splitContainer2.SplitterDistance = 277;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvDrugList
            // 
            this.dgvDrugList.AllowUserToAddRows = false;
            this.dgvDrugList.AllowUserToDeleteRows = false;
            this.dgvDrugList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.WID,
            this.DrugName});
            this.dgvDrugList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrugList.Location = new System.Drawing.Point(0, 0);
            this.dgvDrugList.MultiSelect = false;
            this.dgvDrugList.Name = "dgvDrugList";
            this.dgvDrugList.ReadOnly = true;
            this.dgvDrugList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugList.ShowEditingIcon = false;
            this.dgvDrugList.Size = new System.Drawing.Size(277, 532);
            this.dgvDrugList.TabIndex = 0;
            this.dgvDrugList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrugList_CellClick);
            this.dgvDrugList.SelectionChanged += new System.EventHandler(this.dgvDrugList_SelectionChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDrugInteraction);
            this.tabControl1.Controls.Add(this.tpDrugInformation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // tpDrugInteraction
            // 
            this.tpDrugInteraction.Controls.Add(this.dgvDrugInteraction);
            this.tpDrugInteraction.Location = new System.Drawing.Point(4, 22);
            this.tpDrugInteraction.Name = "tpDrugInteraction";
            this.tpDrugInteraction.Padding = new System.Windows.Forms.Padding(3);
            this.tpDrugInteraction.Size = new System.Drawing.Size(495, 506);
            this.tpDrugInteraction.TabIndex = 1;
            this.tpDrugInteraction.Text = "Drug Interaction";
            this.tpDrugInteraction.UseVisualStyleBackColor = true;
            // 
            // dgvDrugInteraction
            // 
            this.dgvDrugInteraction.AllowUserToAddRows = false;
            this.dgvDrugInteraction.AllowUserToDeleteRows = false;
            this.dgvDrugInteraction.AllowUserToOrderColumns = true;
            this.dgvDrugInteraction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrugInteraction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Description});
            this.dgvDrugInteraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrugInteraction.Location = new System.Drawing.Point(3, 3);
            this.dgvDrugInteraction.MultiSelect = false;
            this.dgvDrugInteraction.Name = "dgvDrugInteraction";
            this.dgvDrugInteraction.ReadOnly = true;
            this.dgvDrugInteraction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugInteraction.ShowEditingIcon = false;
            this.dgvDrugInteraction.Size = new System.Drawing.Size(489, 500);
            this.dgvDrugInteraction.TabIndex = 0;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Names.DataPropertyName = "Names";
            this.Names.HeaderText = "Nama Obat";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 79;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Deskripsi Interaksi Obat";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 111;
            // 
            // tpDrugInformation
            // 
            this.tpDrugInformation.Controls.Add(this.rtbDrugInfo);
            this.tpDrugInformation.Location = new System.Drawing.Point(4, 22);
            this.tpDrugInformation.Name = "tpDrugInformation";
            this.tpDrugInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpDrugInformation.Size = new System.Drawing.Size(495, 506);
            this.tpDrugInformation.TabIndex = 0;
            this.tpDrugInformation.Text = "Drug Information";
            this.tpDrugInformation.UseVisualStyleBackColor = true;
            // 
            // rtbDrugInfo
            // 
            this.rtbDrugInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDrugInfo.Location = new System.Drawing.Point(3, 3);
            this.rtbDrugInfo.Name = "rtbDrugInfo";
            this.rtbDrugInfo.ReadOnly = true;
            this.rtbDrugInfo.Size = new System.Drawing.Size(489, 500);
            this.rtbDrugInfo.TabIndex = 0;
            this.rtbDrugInfo.Text = "";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id Obat";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 67;
            // 
            // WID
            // 
            this.WID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WID.DataPropertyName = "WID";
            this.WID.HeaderText = "WID Obat";
            this.WID.Name = "WID";
            this.WID.ReadOnly = true;
            this.WID.Width = 80;
            // 
            // DrugName
            // 
            this.DrugName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DrugName.DataPropertyName = "DrugName";
            this.DrugName.FillWeight = 250F;
            this.DrugName.HeaderText = "Nama Obat";
            this.DrugName.Name = "DrugName";
            this.DrugName.ReadOnly = true;
            this.DrugName.Width = 86;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drug Interaction © Gina Rivianti, S.si, Apt-2015";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpDrugInteraction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugInteraction)).EndInit();
            this.tpDrugInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtSearchDrug;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDrugInteraction;
        private System.Windows.Forms.TabPage tpDrugInformation;
        private System.Windows.Forms.DataGridView dgvDrugList;
        private System.Windows.Forms.DataGridView dgvDrugInteraction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.RichTextBox rtbDrugInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn WID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
    }
}

