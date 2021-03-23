using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exemplo1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exemplo1 : ContentPage
    {
        public Exemplo1()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            /*if(BindingContext == null)
            {
                BindingContext = new { Exemplo = "Olá" };
            }*/
            base.OnAppearing();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
        }
    }
}