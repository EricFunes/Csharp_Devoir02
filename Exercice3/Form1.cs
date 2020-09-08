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
        
        // FIXME: Problem at resolving this method.
        private void btnValidate_Click(object sender, EventArgs e)
        {
            int[] array = nombresPairs(numTime.Value);
            txtBox.Text = string.Join(", ", array);
        }
        private int[] nombresPairs(decimal nombre)
        {
            int[] array = new int[Convert.ToInt32(nombre)];
            int index = 0;

            for (int number = 2; number <= array.Length; number++)
            {
                if (number % 2 == 0)
                {
                    array[index] = number;
                    index++;
                }
            }
            return array;
        }
    }
}
