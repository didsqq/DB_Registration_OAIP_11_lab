using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity_test
{
    public partial class UserForm : Form
    {

        public UserForm(User user)
        {
            InitializeComponent();

            textBoxName.Text = user.Name;
            textBoxSurName.Text = user.SurName;
            dateTimePicker1.Value = user.Date;
            textBoxEmail.Text = user.Email;
            textBoxPhone.Text = user.Phone;
            textBoxKaf.Text = user.Kaf;
            textBoxStep.Text = user.Step;
            dateTimePicker2.Value = user.DateWork;

        }
    }
}
