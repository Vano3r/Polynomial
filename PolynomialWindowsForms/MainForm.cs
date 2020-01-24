using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PolynomialClassLibrary;

namespace PolynomialWindowsForms
{
    public partial class MainForm : Form
    {
        Polynomial a;
        public MainForm()
        {
            InitializeComponent();

            a = new Polynomial(new int[] { 2, 3, 4, 6, 7 });

        }

        private void buttonCreatePoly_Click(object sender, EventArgs e)
        {
            textBoxPrintPoly.Clear();

            if (textBoxCreatePoly.Text == "")
                MessageBox.Show("Введите коэффициенты полинома!", "Ошибка создания полинома!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                textBoxPrintPoly.Text = CreatePolyFromText(textBoxCreatePoly).ToString();
         
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            textBoxPrintPoly2.Clear();

            switch (domainOperator.SelectedIndex)
            {
                case 0: 
                    textBoxPrintPoly2.Text = (CreatePolyFromText(textBoxA) + CreatePolyFromText(textBoxB)).ToString();
                    break;
                case 1:
                    textBoxPrintPoly2.Text = (CreatePolyFromText(textBoxA) - CreatePolyFromText(textBoxB)).ToString();
                    break;
                case 2:
                    textBoxPrintPoly2.Text = (CreatePolyFromText(textBoxA) * CreatePolyFromText(textBoxB)).ToString();
                    break;
                case 3:
                    textBoxPrintPoly2.Text = (CreatePolyFromText(textBoxA) / CreatePolyFromText(textBoxB)).ToString();
                    break;
                default:
                    MessageBox.Show("Выберите нужный оператор", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private Polynomial CreatePolyFromText(TextBox textBox)
        {
            List<int> listCoeff = new List<int>();
            Polynomial a;
            int lastСomma = 0,
                start = 0;

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (textBox.Text[i] == ',')
                    lastСomma = i;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (textBox.Text[i] == ',')
                {
                    listCoeff.Add(Convert.ToInt32(textBox.Text.Substring(start, i - start)));
                    start = i + 1;
                }
            }

            listCoeff.Add(Convert.ToInt32(textBox.Text.Substring(lastСomma + 1)));
            a = new Polynomial(listCoeff);

            return a;
        }

        private void buttonCreateGraf_Click(object sender, EventArgs e)
        {
            Polynomial a = CreatePolyFromText(textBoxCreateGraf);
            int rangefrom = 0,
                rangeTo = 0;

            try
            {
                rangefrom = Convert.ToInt32(textBoxFrom.Text);
                rangeTo = Convert.ToInt32(textBoxTo.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите правильный диапозон!", "Ошибка построения графика!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            var series = new Series(a.ToString());
            series.ChartType = SeriesChartType.Line;
            chartPoly.Series.Add(series);

            for (int item = rangefrom; item < rangeTo; item++)
            {
                series.Points.AddXY(item, a.PointCalc(item));
            }
        }

        private void buttonClearGraf_Click(object sender, EventArgs e)
        {
            chartPoly.Series.Clear();
        }

        private void buttonShowTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создайте класс Polinoms, задающий тип данных – полиномы." +
                "\nДолжны быть предусмотрены операции над полиномами – сложение, вычитание, умножение, деление, вычисление значения полинома в заданной точке." +
                "\nПостройте решение, в котором этот класс используется для работы с полиномами." + 
                "\nПредставьте графический образ используемых в решении полиномов.");
        }
    }
}
