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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace entity_test
{
    public partial class RegistrationForm : Form
    {
        private string[] degrees = { "Кандидат наук", "Доктор наук", "Бакалавр", "Магистр", "Специалист" };
        private string[] departments = { "Кафедра вычислительной техники", "Кафедра информационных технологий", "Кафедра программной инженерии", "Кафедра системного анализа" };
        public RegistrationForm()
        {
            InitializeComponent();
            
            comboBoxKaf.Items.AddRange(departments);
            comboBoxStep.Items.AddRange(degrees);
        }
        private int Checkmail(string mail)
        {
            mail = textBoxEmail.Text;
            int flag = 0;
            foreach (char c in mail)
            {
                if (c == '@')
                    flag = 1;
            }
            if (flag == 0)
            {
                MessageBox.Show("Неверная почта");
                return 1;
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(textBoxName.Text))
                MessageBox.Show("Введите Имя");
            else if (string.IsNullOrEmpty(textBoxSurName.Text))
                MessageBox.Show("Введите Фамилию");
            else if (string.IsNullOrEmpty(textBoxEmail.Text))
                MessageBox.Show("Введите Почту");
            else if(Checkmail(textBoxEmail.Text) == 1)
                MessageBox.Show("Введите Почту корректно");
            else if (string.IsNullOrEmpty(textBoxPhone.Text))
                MessageBox.Show("Введите Телефон");
            else if(Convert.ToString(textBoxPhone.Text).Length != 11)
                MessageBox.Show("Длина номера телефона введена неверно");
            else if(Int32.TryParse(textBoxPhone.Text, out int number))
                MessageBox.Show("Номер телефона введен неверно");
            else if (Convert.ToInt32(comboBoxKaf.SelectedValue) == -1)
                MessageBox.Show("Введите Кафедру");
            else if (Convert.ToInt32(comboBoxStep.SelectedValue) == -1)
                MessageBox.Show("Введите Ученую степень");
            else if (string.IsNullOrEmpty(textBoxPass.Text))
                MessageBox.Show("Введите Пароль");
            else if((textBoxPass.Text).Length < 5)
                MessageBox.Show("Введите пароль не меньше 5 символов");
            else
            {
                using (UserContext db = new UserContext())
                {
                    foreach (User usermail in db.users)
                    {
                        if (textBoxEmail.Text == usermail.Email)
                        {
                            MessageBox.Show("Пользователь с такой почтой уже существует");
                            return;
                        }
                        if(textBoxPhone.Text == usermail.Phone)
                        {
                            MessageBox.Show("Пользователь с таким номером уже существует");
                            return;
                        }
                    }
                
                    User user = new User(textBoxName.Text, textBoxSurName.Text, dateTimePicker1.Value, textBoxEmail.Text, textBoxPhone.Text, Convert.ToString(comboBoxKaf.SelectedItem), Convert.ToString(comboBoxStep.SelectedItem), dateTimePicker2.Value, Form1.GetHashString(textBoxPass.Text));
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
