using System;
using System.Collections.Generic;

namespace PolynomialClassLibrary
{
    public class Polynomial
    {
        private List<ElementPolynomial> listElements;
        public Polynomial()
        {
            listElements = new List<ElementPolynomial>();
        }
        public Polynomial(int[] coefficients)
        {
            listElements = new List<ElementPolynomial>();
            int power = coefficients.Length - 1;

            for (int i = 0; i < coefficients.Length; i++)
                this.listElements.Add(new ElementPolynomial { Coefficient = coefficients[i], Power = power - i });
        }

        public Polynomial(Polynomial a)
        {
            listElements = new List<ElementPolynomial>();

            foreach (var item in a.listElements)
                listElements.Add(new ElementPolynomial { Coefficient = item.Coefficient, Power = item.Power });
        }

        public override string ToString()
        {
            string result = "";

            foreach (var item in listElements)
            {
                if (item.Coefficient == 0)
                    result += "";

                else
                {
                    if (item.Power == 1)
                        result += String.Format("{0}X + ", item.Coefficient);
                    else if (item.Power == 0)
                        result += String.Format("{0}", item.Coefficient);
                    else
                        result += String.Format("{0}X^{1} + ", item.Coefficient, item.Power);
                }
            }

            if (result == "")
                return "0";
            else
                return result.Replace("+ -", "- ");
        }

        public static Polynomial operator +(Polynomial a, Polynomial b)
        {
            Polynomial c = new Polynomial(a);

            foreach (var i in c.listElements)
                foreach (var j in b.listElements)
                    if (i.Power == j.Power)
                        i.Coefficient += j.Coefficient;

            return c;
        }
        public static Polynomial operator -(Polynomial a, Polynomial b)
        {
            Polynomial c = new Polynomial(a);

            foreach (var i in c.listElements)
                foreach (var j in b.listElements)
                    if (i.Power == j.Power)
                        i.Coefficient -= j.Coefficient;

            return c;
        }
        public static Polynomial operator *(Polynomial a, Polynomial b)
        {
            Polynomial c = new Polynomial();

            foreach (var i in a.listElements)
                foreach (var j in b.listElements)
                    c.listElements.Add(new ElementPolynomial { Coefficient = i.Coefficient * j.Coefficient, Power = i.Power + j.Power });

            for (int i = 0; i < c.listElements.Count; i++)
                for (int j = i + 1; j < c.listElements.Count; j++)
                {

                    if (c.listElements[i].Power == c.listElements[j].Power)
                    {
                        c.listElements[i].Coefficient += c.listElements[j].Coefficient;
                        c.listElements.RemoveAt(j);
                    }
                }

            return c;
        }
        public static Polynomial operator /(Polynomial a, Polynomial b)
        {
            Polynomial c = new Polynomial(a);

            return c;
        }
    }
}