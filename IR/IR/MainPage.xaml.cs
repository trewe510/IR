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
            double IRRF = 0;
            double INSS = 0;
            if (salario <= 1904.93)
            {
                IRRF = 0;
            }
            else if (salario >= 1903.99 && salario < 2826.65)
            {
                IRRF = (salario - INSS) * (7.5 / 100) - (142.80);
            }
            else if (salario >= 2826.66 && salario < 3751.05)
            {
                IRRF = (salario - INSS) * (15.0 / 100) - (354.80);
            }
            else if (salario >= 3751.06 && salario < 4664.68)
            {
                IRRF = salario * (22.5 / 100) - (636.13);
            }
            else if (salario >= 4664.69)
            {
                IRRF = salario * (27.5 / 100) - (869.36);
            }
            if (salario <= 1100.00 )
            {
                INSS = salario * (7.5 / 100);
            }
            else if (salario >= 1100.01 && salario < 2203.48)
            {
                INSS = salario * ( 9.0 / 100 ) ;
            }
            else if (salario >= 2203.49 && salario < 3305.22)
            {
                INSS = salario * (12.0 / 100) ;
            }
            else if (salario >= 3305.23 && salario >= 6433.57)
            {
                INSS = salario * (14.0 / 100);
            }
            
                DisplayAlert("Calculo", string.Format("Salario: {0} \n IRRF : {1} \n INSS :{2}", salario, IRRF, INSS), "OK");
        }

    }
}

