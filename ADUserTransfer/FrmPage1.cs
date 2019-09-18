using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using Microsoft.VisualBasic;


namespace ADUserTransfer
{
    public partial class FrmPage1 : Form
    {
        Main main;
        public FrmPage1(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string str = Interaction.InputBox("请输入用户的公共名称：", "提示", "", -1, -1);
            if (str != null && str != "")
            {
                if (this.lbUserCommonName.Items.Contains(str)) MessageBox.Show("用户公共名称重复！");
                else this.lbUserCommonName.Items.Add(str);
            }
        }

        private void FrmPage1_Load(object sender, EventArgs e)
        {
            this.cmbOrgUnitEntry.DataSource = main.OrgUnitEntries;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
