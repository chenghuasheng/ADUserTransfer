using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;

namespace ADUserTransfer
{
    public partial class FrmPage3 : Form
    {
        FrmMain main;
        private List<DirectoryEntry> groupEntries = new List<DirectoryEntry>();
        public FrmPage3(FrmMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (ckbRemove.Checked)
                {
                    DirectoryEntry groupEntry = this.groupEntries[this.cmbGroupToRemove.SelectedIndex];
                    foreach (DirectoryEntry userEntry in main.UserEntries)
                    {
                        ADHelper.Instance.RemoveUserFromGroup(userEntry, groupEntry);
                        Console.WriteLine("成功把{0}从{1}中移除", userEntry.Name, groupEntry.Name);
                    }
                }
                if (ckbAdd.Checked)
                {
                    DirectoryEntry groupEntry = this.groupEntries[this.cmbGroupToAdd.SelectedIndex];
                    foreach (DirectoryEntry userEntry in main.UserEntries)
                    {
                        ADHelper.Instance.AddUserToGroup(userEntry, groupEntry);
                        Console.WriteLine("成功把{0}添加到{1}", userEntry.Name, groupEntry.Name);
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void FrmPage3_Load(object sender, EventArgs e)
        {
            this.groupEntries = ADHelper.Instance.GetGroups();
            List<string> groupNames1 = new List<string>();
            List<string> groupNames2 = new List<string>();
            foreach (DirectoryEntry entry in this.groupEntries)
            {
                groupNames1.Add(entry.Properties["distinguishedName"].Value.ToString());
                groupNames2.Add(entry.Properties["distinguishedName"].Value.ToString());
            }
            this.cmbGroupToRemove.DataSource = groupNames1;
            this.cmbGroupToAdd.DataSource = groupNames2;
            this.cmbGroupToAdd.SelectedIndex = 0;
            this.cmbGroupToRemove.SelectedIndex = 0;
        }
    }
}
