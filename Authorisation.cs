using System;
using System.Windows.Forms;


namespace CRLchain
{
    public partial class Authorisation : Form
    {
        public Authorisation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка на заполненность
            if (textBox1.Text == null || maskedTextBox1.Text == null)
            {
                SendError();
            }
            else
            {
                try
                {
                    //отправка запроса на сервер/бд для вытягивания логина и пароля

                }
                catch
                {
                    SendError();
                }
            }
            //проверка на правильность


        }

        private void SendError()
        {
            ErrorMessage error = new ErrorMessage();
            Show(error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            Show(registration);
            Close();
        }
    }
}
