using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity_test
{
    public partial class SendPasForm : Form
    {
        public SendPasForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("didsqq@yandex.ru", "Adel");
            MailAddress to = new MailAddress(textBoxEmail.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Восстановление пароля";
            using (UserContext db = new UserContext())
            {
                foreach (User user in db.users)
                {
                    if (textBoxEmail.Text == user.Email)
                    {
                        m.Body = "<h1>Пароль: " + user.Password + "</h1>";
                    }
                }
            }
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.Credentials = new NetworkCredential("didsqq@yandex.ru", "lhybtwljdlunlgjk");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
        static string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(password);
        }
    }
}
