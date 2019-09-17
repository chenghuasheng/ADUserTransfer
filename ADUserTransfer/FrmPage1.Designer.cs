namespace ADUserTransfer
{
    partial class FrmPage1
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
            this.lbUserCommonName = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbOrgUnitEntry = new System.Windows.Forms.ComboBox();
            this.dgvUserResult = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserCommonName
            // 
            this.lbUserCommonName.FormattingEnabled = true;
            this.lbUserCommonName.ItemHeight = 12;
            this.lbUserCommonName.Location = new System.Drawing.Point(12, 46);
            this.lbUserCommonName.Name = "lbUserCommonName";
            this.lbUserCommonName.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbUserCommonName.Size = new System.Drawing.Size(120, 268);
            this.lbUserCommonName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户公共名称列表：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(162, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(162, 171);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // cmbOrgUnitEntry
            // 
            this.cmbOrgUnitEntry.FormattingEnabled = true;
            this.cmbOrgUnitEntry.Location = new System.Drawing.Point(287, 20);
            this.cmbOrgUnitEntry.Name = "cmbOrgUnitEntry";
            this.cmbOrgUnitEntry.Size = new System.Drawing.Size(239, 20);
            this.cmbOrgUnitEntry.TabIndex = 4;
            // 
            // dgvUserResult
            // 
            this.dgvUserResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserResult.Location = new System.Drawing.Point(269, 74);
            this.dgvUserResult.Name = "dgvUserResult";
            this.dgvUserResult.RowTemplate.Height = 23;
            this.dgvUserResult.Size = new System.Drawing.Size(343, 240);
            this.dgvUserResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "在";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(537, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "用户搜索结果：";
            // 
            // FrmPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 331);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUserResult);
            this.Controls.Add(this.cmbOrgUnitEntry);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUserCommonName);
            this.Name = "FrmPage1";
            this.Text = "FrmPage1";
            this.Load += new System.EventHandler(this.FrmPage1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUserCommonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbOrgUnitEntry;
        private System.Windows.Forms.DataGridView dgvUserResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
    }
}