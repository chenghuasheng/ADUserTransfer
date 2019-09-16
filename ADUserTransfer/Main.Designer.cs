namespace ADUserTransfer
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.CommonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrgUnits = new System.Windows.Forms.ComboBox();
            this.btnMoveToOrgUnit = new System.Windows.Forms.Button();
            this.btnRemoveGroup = new System.Windows.Forms.Button();
            this.cmbGroups1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.cmbGroups2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运行日志";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 20);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(871, 149);
            this.txtOutput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "转移用户列表";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(324, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(324, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMoveToOrgUnit);
            this.groupBox2.Controls.Add(this.cmbOrgUnits);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(418, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "组织单位";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddGroup);
            this.groupBox3.Controls.Add(this.cmbGroups2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnRemoveGroup);
            this.groupBox3.Controls.Add(this.cmbGroups1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(418, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 157);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "群组";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(324, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommonName,
            this.ResultDetail});
            this.dgvUsers.Location = new System.Drawing.Point(18, 40);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 23;
            this.dgvUsers.Size = new System.Drawing.Size(290, 358);
            this.dgvUsers.TabIndex = 9;
            // 
            // CommonName
            // 
            this.CommonName.DataPropertyName = "CommonName";
            this.CommonName.HeaderText = "公共名称";
            this.CommonName.Name = "CommonName";
            this.CommonName.ReadOnly = true;
            // 
            // ResultDetail
            // 
            this.ResultDetail.DataPropertyName = "ResultDetail";
            this.ResultDetail.HeaderText = "详细结果";
            this.ResultDetail.Name = "ResultDetail";
            this.ResultDetail.ReadOnly = true;
            this.ResultDetail.Width = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "移动到：";
            // 
            // cmbOrgUnits
            // 
            this.cmbOrgUnits.FormattingEnabled = true;
            this.cmbOrgUnits.Location = new System.Drawing.Point(68, 41);
            this.cmbOrgUnits.Name = "cmbOrgUnits";
            this.cmbOrgUnits.Size = new System.Drawing.Size(301, 20);
            this.cmbOrgUnits.TabIndex = 1;
            // 
            // btnMoveToOrgUnit
            // 
            this.btnMoveToOrgUnit.Location = new System.Drawing.Point(387, 40);
            this.btnMoveToOrgUnit.Name = "btnMoveToOrgUnit";
            this.btnMoveToOrgUnit.Size = new System.Drawing.Size(75, 23);
            this.btnMoveToOrgUnit.TabIndex = 2;
            this.btnMoveToOrgUnit.Text = "确定";
            this.btnMoveToOrgUnit.UseVisualStyleBackColor = true;
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.Location = new System.Drawing.Point(386, 52);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveGroup.TabIndex = 5;
            this.btnRemoveGroup.Text = "确定";
            this.btnRemoveGroup.UseVisualStyleBackColor = true;
            // 
            // cmbGroups1
            // 
            this.cmbGroups1.FormattingEnabled = true;
            this.cmbGroups1.Location = new System.Drawing.Point(67, 53);
            this.cmbGroups1.Name = "cmbGroups1";
            this.cmbGroups1.Size = new System.Drawing.Size(301, 20);
            this.cmbGroups1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "删除组：";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(386, 97);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 8;
            this.btnAddGroup.Text = "确定";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            // 
            // cmbGroups2
            // 
            this.cmbGroups2.FormattingEnabled = true;
            this.cmbGroups2.Location = new System.Drawing.Point(67, 98);
            this.cmbGroups2.Name = "cmbGroups2";
            this.cmbGroups2.Size = new System.Drawing.Size(301, 20);
            this.cmbGroups2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "添加组：";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 627);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActiveDirectory用户批量转移";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultDetail;
        private System.Windows.Forms.Button btnMoveToOrgUnit;
        private System.Windows.Forms.ComboBox cmbOrgUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.ComboBox cmbGroups2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.ComboBox cmbGroups1;
        private System.Windows.Forms.Label label3;
    }
}

