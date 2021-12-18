using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KursBar.EF;

namespace KursBar
{
    public partial class FormAdmin : Form
    {
        public static FormAdmin FRAdmin { get; set; }
        Model1 db = new Model1();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

            roleBindingSource.DataSource = db.Role.ToList();
            officeBindingSource.DataSource = db.Office.ToList();   
            userBindingSource.DataSource = db.User.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration frmReg = new Registration();
            FRAdmin = this;
            this.Hide();
            frmReg.Show();

        }

        private void butListReq_Click(object sender, EventArgs e)
        {
            ListRequest lsReq = new ListRequest();
            this.Hide();
            lsReq.Show();
        }
    }
}
