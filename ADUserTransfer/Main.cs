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
    public partial class Main : Form
    {
        private ADHelper adHelper;
        private UserDataTable userTable;
        private List<DirectoryEntry> userEntries=new List<DirectoryEntry>();
        private List<DirectoryEntry> orgUnitEntries = new List<DirectoryEntry>();
        private List<DirectoryEntry> groupEntries = new List<DirectoryEntry>();

        public Main()
        {
            InitializeComponent(); 
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Console.SetOut(new TextBoxWriter(this.txtOutput));
            try
            {
                this.adHelper = ADHelper.Instance;
                DirectoryEntry entry = this.adHelper.DomainRootEntry;
                Console.WriteLine("成功连接到 {0}",entry.Path);
                this.userTable = new UserDataTable();
                this.dgvUsers.DataSource = this.userTable;
                this.orgUnitEntries = this.adHelper.GetOrgUnits();
                this.cmbOrgUnits.DataSource = this.orgUnitEntries;
                this.groupEntries = this.adHelper.GetGroups();
                this.cmbGroups1.DataSource = this.groupEntries;
                this.cmbGroups2.DataSource = this.groupEntries;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string str = Interaction.InputBox("请输入用户的公共名称：", "提示", "", -1, -1);
            if (str != null&&str!="")
            {
                DataRow dr = this.userTable.NewRow();
                dr["CommonName"] = str;
                this.userTable.Rows.Add(dr);
            }
        }     

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dgvr in this.dgvUsers.Rows)
            {
                if (dgvr.Selected)
                {
                    this.userTable.Rows[dgvr.Index].Delete();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.userEntries.Clear();
            foreach (DataRow dr in this.userTable.Rows)
            {
                List<DirectoryEntry> entries = this.adHelper.GetUsers(dr["CommonName"].ToString());
                if (entries.Count > 0)
                {
                    foreach(DirectoryEntry entry in entries)
                    {
                        this.userEntries.Add(entry);
                        dr["ResultDetail"] += entry.Path + "\n";
                    }
                }else
                {
                    dr["ResultDetail"] = "找不到这样的用户";
                }
            }
        }
    }
}
