using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject
{
    public partial class SendSMS : Form
    {
        public SendSMS()
        {
            InitializeComponent();
        }
        public String Owners
        {
            get
            {
                return OwnertextBox1.Text;
            }
            set
            {
                OwnertextBox1.Text = value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }
    }
}
