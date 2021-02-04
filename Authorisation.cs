using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //проверка на правильность


        }

        private void SendError()
        {
            ErrorMessage error = new ErrorMessage();
            Show(error);
        }
    }
}
