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
                Console.WriteLine("成功连接到 {0}",entry.Properties["distinguishedName"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        
    }
}
