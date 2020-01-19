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
            Polynomial a = new Polynomial(new int[] { 1, -3, 2, 7, -3, 5 });
            Polynomial b = new Polynomial(new int[] { 1, -1, 1 });

            Polynomial c = a / b;

            MessageBox.Show(b + " = " + b.PointCalc(5).ToString());

            a.PointCalc(5);

        }
    }
}
