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
        private List<DirectoryEntry> userEntries = new List<DirectoryEntry>();
        public List<DirectoryEntry> UserEntries
        {
            get => this.userEntries;
            set => this.userEntries = value;
        }
        private List<DirectoryEntry> orgUnitEntries = new List<DirectoryEntry>();
        public List<DirectoryEntry> OrgUnitEntries
        {
            get => this.orgUnitEntries;
            set => this.orgUnitEntries = value;
        }
        private List<Form> forms = new List<Form>();

        public Main()
        {
            InitializeComponent(); 
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Console.SetOut(new TextBoxWriter(this.txtOutput));
            FrmPage1 page1 = new FrmPage1(this);
            page1.TopLevel = false;
            page1.Parent = this.panel1;
            page1.Dock = DockStyle.Fill;
            this.forms.Add(page1);
            try
            {
                DirectoryEntry entry = ADHelper.Instance.DomainRootEntry;
                Console.WriteLine("成功连接到 {0}",entry.Properties["distinguishedName"].Value);
                this.orgUnitEntries = ADHelper.Instance.GetOrgUnits();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            page1.Show();
        }        
    }
}
