using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double salario = float.Parse(txt_salario.Text);
            double IR = 0;
            if (salario < 1904.93)
            {
                IR = 0;
            }
            else if (salario >= 1903.99 && salario < 2826.65)
                {
                IR = salario * (7.5 / 100);
                }
                else if (salario >= 2826.66 && salario < 3751.05)
                {
                IR = salario * (15 / 100);
                }
                else if (salario >= 3751.06 && salario < 4664.68)
                {
                IR = salario * (22.5 / 100);
                }
                else if (salario >= 4664.69)
                {
                IR = salario * (27.5 / 100);
                }
                DisplayAlert("Calculo", string.Format("Salario: {0} \n IR : {1}", salario, IR), "OK");
        }

    }
}

