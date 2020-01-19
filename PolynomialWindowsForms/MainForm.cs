using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolynomialClassLibrary;

namespace PolynomialWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Polynomial a = new Polynomial(new int[] { 1, 1, 2, 0, 1, 1, 2 });
            Polynomial b = new Polynomial(new int[] { 1, 1, 2 });

            Polynomial c = a / b;

            MessageBox.Show(a.ToString() + "\n" + b.ToString() + "\n" + c.ToString());

        }
    }
}
