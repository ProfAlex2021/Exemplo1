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
    public partial class ListaImovelPage : ContentPage
    {
        public ListaImovelPage()
        {
            InitializeComponent();
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Imovel;
            
            DisplayAlert("Item clicado", $"Foi clicado o {Dados.ListaImovel.IndexOf(item)+1}º da lista", "OK");
        }
    }
}