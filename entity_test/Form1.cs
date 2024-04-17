using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace entity_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                User user = new User(textBoxLog.Text, GetHashString(textBoxPass.Text), textBoxEmail.Text, "User");
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        private void buttonSign_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                foreach(User user in db.Users)
                {
                    if(textBoxLogin.Text == user.Login && GetHashString(textBoxPassword.Text) == user.Password)
                    {
                        MessageBox.Show("Вход успешен!");
                        UserForm userform = new UserForm();
                        userform.label1.Text = user.Login;
                        userform.Show();
                        //userform.Form1 = this;
                        this.Visible = false;
                        return;
                    }
                }
                MessageBox.Show("Логин или пароль указан неверно! ");
            }
        }

        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach(byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        private void buttonSendPassword_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("server.christaw@gmail.com", "Adel");
            MailAddress to = new MailAddress(textBoxEmail.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Тест";
            using (UserContext db = new UserContext())
            {
                foreach (User user in db.Users)
                {
                    if (textBoxEmail.Text == user.Email)
                    {
                        m.Body = "<h1>Пароль: " + user.Password + "</h1>";
                    }
                }
            }
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com.", 587);
            smtp.Credentials = new NetworkCredential("server.christaw@gmail.com", "kira1007");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public User() { }
        public User(string Login, string Password, string Email, string Role)
        {
            this.Login = Login;
            this.Password = Password;
            this.Email = Email;
            this.Role = Role;
        }
    }
    public class UserContext : DbContext
    {
        public UserContext() : base("DbConnection") { }
        public DbSet<User> Users { get; set; }
    }
}
