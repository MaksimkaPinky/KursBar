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
    public partial class Registration : Form
    {
        Model1 db = new Model1();
        public static Registration frmReg { get; set; }
        User USR = new User();
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            officeBindingSource.DataSource = db.Office.ToList();
            roleBindingSource.DataSource = db.Role.ToList();
        }

        private void ButRegistration_Click(object sender, EventArgs e)
        {
            if (iD_OfficeComboBox.Text == "" || полComboBox.Text == "" || рольComboBox.Text == "" || почтаTextBox.Text == "" || фИОTextBox.Text == "" || логинTextBox.Text == "" || passBox.Text == "" || парольTextBox.Text == "")
            {
                MessageBox.Show("Требуется задать значение всем полям");
                return;
            }
            if (парольTextBox.Text != passBox.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            Autorization AUT = db.Autorization.Find(логинTextBox.Text);
            if (AUT != null)
            {
                MessageBox.Show("Пользователь с таким логином уже есть");
                return;
            }
            USR = new User();
            AUT = new Autorization();
            USR.Пол = полComboBox.Text;
            USR.Почта = почтаTextBox.Text;
            USR.Роль = рольComboBox.Text;
            USR.ФИО = фИОTextBox.Text;
            USR.ID_Office = Convert.ToInt32(iD_OfficeComboBox);
            USR.Дата_Рождения = дата_РожденияDateTimePicker.Text;
            AUT.Логин = логинTextBox.Text;
            AUT.Пароль = парольTextBox.Text;
            db.User.Add(USR);
            db.Autorization.Add(AUT);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пользователь " + AUT.Логин + " зарегистрирован");
            FormAdmin.FRAdmin.Show();
            this.Close();
            return;

        }
    }
}
