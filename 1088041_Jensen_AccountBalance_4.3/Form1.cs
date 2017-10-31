using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1088041_Jensen_AccountBalance_4._3
{
    public partial class FormAccountBalance : Form
    {
        public FormAccountBalance()
        {
            InitializeComponent();
        }
        private bool ValidateTextInput()
        {
            if (String.IsNullOrEmpty(textBoxTransactionAmount.Text))
            {
                MessageBox.Show("Enter transaction amount. ");
                return false;
            }
            
            return true;
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if(!ValidateTextInput())
            {
                return;
            }
        }
    }
}
