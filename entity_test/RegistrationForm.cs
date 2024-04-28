using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity_test
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxName.Text))
                MessageBox.Show("Введите Имя");
            else if (string.IsNullOrEmpty(textBoxSurName.Text))
                MessageBox.Show("Введите Фамилию");
            else if (string.IsNullOrEmpty(textBoxEmail.Text))
                MessageBox.Show("Введите Почту");
            else if (string.IsNullOrEmpty(textBoxPhone.Text))
                MessageBox.Show("Введите Телефон");
            else if (string.IsNullOrEmpty(textBoxKaf.Text))
                MessageBox.Show("Введите Кафедру");
            else if (string.IsNullOrEmpty(textBoxStep.Text))
                MessageBox.Show("Введите Степень");
            else if (string.IsNullOrEmpty(textBoxPass.Text))
                MessageBox.Show("Введите Пароль");
            else
            {
                using (UserContext db = new UserContext())
                {
                    User user = new User(textBoxName.Text, textBoxSurName.Text, dateTimePicker1.Value, textBoxEmail.Text, textBoxPhone.Text, textBoxKaf.Text, textBoxStep.Text, dateTimePicker2.Value, Form1.GetHashString(textBoxPass.Text));
                    try
                    {
                        db.users.Add(user);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    db.SaveChanges();
                }
                Close();
            }
        }
    }
}
