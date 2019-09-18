namespace ADUserTransfer
{
    partial class FrmPage3
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
            this.ckbRemove = new System.Windows.Forms.CheckBox();
            this.cmbGroupToRemove = new System.Windows.Forms.ComboBox();
            this.cmbGroupToAdd = new System.Windows.Forms.ComboBox();
            this.ckbAdd = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbRemove
            // 
            this.ckbRemove.AutoSize = true;
            this.ckbRemove.Checked = true;
            this.ckbRemove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbRemove.Location = new System.Drawing.Point(116, 80);
            this.ckbRemove.Name = "ckbRemove";
            this.ckbRemove.Size = new System.Drawing.Size(72, 16);
            this.ckbRemove.TabIndex = 0;
            this.ckbRemove.Text = "删除组：";
            this.ckbRemove.UseVisualStyleBackColor = true;
            // 
            // cmbGroupToRemove
            // 
            this.cmbGroupToRemove.FormattingEnabled = true;
            this.cmbGroupToRemove.Location = new System.Drawing.Point(194, 78);
            this.cmbGroupToRemove.Name = "cmbGroupToRemove";
            this.cmbGroupToRemove.Size = new System.Drawing.Size(295, 20);
            this.cmbGroupToRemove.TabIndex = 1;
            // 
            // cmbGroupToAdd
            // 
            this.cmbGroupToAdd.FormattingEnabled = true;
            this.cmbGroupToAdd.Location = new System.Drawing.Point(194, 154);
            this.cmbGroupToAdd.Name = "cmbGroupToAdd";
            this.cmbGroupToAdd.Size = new System.Drawing.Size(295, 20);
            this.cmbGroupToAdd.TabIndex = 3;
            // 
            // ckbAdd
            // 
            this.ckbAdd.AutoSize = true;
            this.ckbAdd.Checked = true;
            this.ckbAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAdd.Location = new System.Drawing.Point(116, 156);
            this.ckbAdd.Name = "ckbAdd";
            this.ckbAdd.Size = new System.Drawing.Size(72, 16);
            this.ckbAdd.TabIndex = 2;
            this.ckbAdd.Text = "添加组：";
            this.ckbAdd.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(272, 232);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FrmPage3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 320);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbGroupToAdd);
            this.Controls.Add(this.ckbAdd);
            this.Controls.Add(this.cmbGroupToRemove);
            this.Controls.Add(this.ckbRemove);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPage3";
            this.Load += new System.EventHandler(this.FrmPage3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbRemove;
        private System.Windows.Forms.ComboBox cmbGroupToRemove;
        private System.Windows.Forms.ComboBox cmbGroupToAdd;
        private System.Windows.Forms.CheckBox ckbAdd;
        private System.Windows.Forms.Button btnOk;
    }
}