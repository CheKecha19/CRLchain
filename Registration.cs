using System;
using System.Windows.Forms;

namespace CRLchain
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox1.Text.Length <= 5 || textBox2.Text.Length <= 5)
            {
                ErrorMessage error = new ErrorMessage();
                Show(error);
            }
            else
            {
                Authorisation authorisation = new Authorisation();
                Show(authorisation);
                /*
                 * сюда надо воткнуть кусок с отправкой данных в блокчейн/бд
                 */
                Close();
            }
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton2.Checked == true)
        //    {
        //        radioButton2.Checked = false;
        //        radioButton1.Checked = true;
        //    }
        //    else
        //    {
        //        radioButton1.Checked = true;
        //    }
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton1.Checked == true)
        //    {
        //        radioButton1.Checked = false;
        //        radioButton2.Checked = true;
        //    }
        //    else
        //    {
        //        radioButton2.Checked = true;
        //    }
        //}

        private void textBox3_VisibleChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox3.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
            }
        }
    }
}
