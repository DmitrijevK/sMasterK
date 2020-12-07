using sMasterK.pesi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sMasterK.funkt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class heroess : ContentPage
    {
        public heroess()
        {
            Title = "Персонажи";
            StackLayout vtornikv = new StackLayout();
            string[] taska = new string[] { "Afka", "Söön ", "Tegelen spordiga", "Söön", "Läks koolis", "Söön" };

            ListView lista = new ListView();
            // определяем источник данных
            lista.ItemsSource = taska;

            lista.ItemSelected += Lista_ItemSelected;
            Content = new StackLayout { Children = { lista} };
        }

        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string text = e.SelectedItem.ToString();
            if (e.SelectedItemIndex == 0)
            {
                await Navigation.PushAsync(new afka());
            }

        }
    }
    }
}