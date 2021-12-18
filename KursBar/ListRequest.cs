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
    public partial class ListRequest : Form
    {
        Model1 db = new Model1();
        public ListRequest()
        {
            InitializeComponent();
        }

        private void ListRequest_Load(object sender, EventArgs e)
        {
            questBindingSource.DataSource = db.Quest.ToList();
        }
    }
}
