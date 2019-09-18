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
    public partial class FrmPage2 : Form
    {
        FrmMain main;
        public FrmPage2(FrmMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void FrmPage2_Load(object sender, EventArgs e)
        {
            TreeNode topNode = new TreeNode();
            topNode.Tag = ADHelper.Instance.DomainRootEntry;
            topNode.Text = ADHelper.Instance.DomainRootEntry.Name;
            this.tvOrgUnit.Nodes.Add(topNode);
            ShowSubOrgUnits(topNode, ADHelper.Instance.DomainRootEntry);
        }
        private void ShowSubOrgUnits(TreeNode node,DirectoryEntry entry)
        {
            foreach (DirectoryEntry subEntry in entry.Children)
            {
                if (subEntry.SchemaClassName== "organizationalUnit")
                {
                    TreeNode newNode = new TreeNode();
                    newNode.Text = subEntry.Name;
                    newNode.Tag = subEntry;
                    node.Nodes.Add(newNode);
                    ShowSubOrgUnits(newNode, subEntry);
                }
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DirectoryEntry orgUnitEntry = (DirectoryEntry)this.tvOrgUnit.SelectedNode.Tag;
            foreach (DirectoryEntry userEntry in main.UserEntries)
            {
                try
                {
                    userEntry.MoveTo(orgUnitEntry);
                    Console.WriteLine("成功移动{0}到{1}.",userEntry.Name,orgUnitEntry.Name);
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
