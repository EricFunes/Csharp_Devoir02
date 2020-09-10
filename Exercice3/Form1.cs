using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnValidate_Click(object sender, EventArgs e)
        {
            int[] array = nombresPairs(numTime.Value);
            txtBox.Text = string.Join(", ", array);
        }
        private int[] nombresPairs(decimal decimalNumber)
        {
            int length = Convert.ToInt32(decimalNumber);
            int[] array = new int[length];
            int num = 2;

            for (int index = 0; index < length; index++)
            {
                if( num % 2 == 0)
                {
                    array[index] = num;
                    num += 2;
                }
            }
            return array;
        }
    }
}
