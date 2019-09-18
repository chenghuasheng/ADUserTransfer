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
        FrmMain main;
        private List<DirectoryEntry> orgUnitEntries = new List<DirectoryEntry>();
        public FrmPage1(FrmMain main)
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
            this.orgUnitEntries.Add(ADHelper.Instance.DomainRootEntry);
            foreach (DirectoryEntry dEntry in ADHelper.Instance.GetOrgUnits())
                this.orgUnitEntries.Add(dEntry);
            List<string> orgUnitNames = new List<string>();
            foreach(DirectoryEntry entry in this.orgUnitEntries)
            {
                orgUnitNames.Add(entry.Properties["distinguishedName"].Value.ToString());
            }
            this.cmbOrgUnitEntry.DataSource = orgUnitNames;
            this.cmbOrgUnitEntry.SelectedIndex = 0;
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            while (this.lbUserCommonName.SelectedItems.Count > 0)
            {
                this.lbUserCommonName.Items.Remove(this.lbUserCommonName.SelectedItem);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            main.UserEntries.Clear();
            DirectoryEntry parentEntry = this.orgUnitEntries[this.cmbOrgUnitEntry.SelectedIndex];
            UserDataTable userTable = new UserDataTable();
            foreach(string cnName in this.lbUserCommonName.Items)
            {
                DataRow dataRow = userTable.NewRow();
                dataRow["CommonName"] = cnName;
                List<DirectoryEntry> entries = ADHelper.Instance.GetUsers(cnName, parentEntry);
                foreach (DirectoryEntry entry in entries)
                {
                    main.UserEntries.Add(entry);
                    dataRow["ResultDetail"] += entry.Properties["distinguishedName"].Value.ToString()+'\n';
                }
                if (entries.Count == 0) dataRow["ResultDetail"] = "找不到相应的用户";
                userTable.Rows.Add(dataRow);
            }
            this.dgvUserResult.DataSource = userTable;
        }
    }
}
