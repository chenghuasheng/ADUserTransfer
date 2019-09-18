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
    public partial class FrmMain : Form
    {
        private List<DirectoryEntry> userEntries = new List<DirectoryEntry>();
        public List<DirectoryEntry> UserEntries
        {
            get => this.userEntries;
            set => this.userEntries = value;
        }
        private List<Form> forms = new List<Form>();

        public FrmMain()
        {
            InitializeComponent(); 
        }
        private int formIndex = 0;
        private void Main_Load(object sender, EventArgs e)
        {
            Console.SetOut(new TextBoxWriter(this.txtOutput));
            FrmPage1 page1 = new FrmPage1(this);
            page1.TopLevel = false;
            page1.Parent = this.panel1;
            page1.Dock = DockStyle.Fill;
            this.forms.Add(page1);
            FrmPage2 page2 = new FrmPage2(this);
            page2.TopLevel = false;
            page2.Parent = this.panel1;
            page2.Dock = DockStyle.Fill;
            this.forms.Add(page2);
            FrmPage3 page3 = new FrmPage3(this);
            page3.TopLevel = false;
            page3.Parent = this.panel1;
            page3.Dock = DockStyle.Fill;
            this.forms.Add(page3);
            this.SetButtonState();
            try
            {
                DirectoryEntry entry = ADHelper.Instance.DomainRootEntry;
                Console.WriteLine("成功连接到 {0}",entry.Properties["distinguishedName"].Value);
                page1.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            this.forms[this.formIndex].Hide();
            this.formIndex--;
            if (this.formIndex >=0)
            {
                this.forms[this.formIndex].Show();
            }
            this.SetButtonState();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.forms[this.formIndex].Hide();
            this.formIndex++;
            if (this.formIndex < this.forms.Count)
            {
                this.forms[this.formIndex].Show();
            }
            this.SetButtonState();
        }

        private void SetButtonState()
        {
            if (this.formIndex <= 0) this.btnPrev.Enabled = false;
            else this.btnPrev.Enabled = true;
            if (this.formIndex >= this.forms.Count - 1) this.btnNext.Enabled = false;
            else this.btnNext.Enabled = true;
        }
    }
}
