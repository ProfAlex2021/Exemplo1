using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exemplo1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Exemplo1());
        }

        private void btnListaImovel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaImovelPage() { BindingContext = new { Exemplo = "Exemplo2" } });
        }

        private void btnListaSimples_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaSimples());
        }
    }
}
