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

            SearchBar searchBar = new SearchBar
            {
                Placeholder = "Название персонажа",
                PlaceholderColor = Color.Black,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(SearchBar)),
                FontAttributes = FontAttributes.Italic
            };


            Title = "Персонажи";
            StackLayout vtornikv = new StackLayout();
            string[] taska = new string[] { "А. Ф. Ка", "Ал'акир ", "Алекстраза", "Аранна Звездочет", "Ахалаймахалай", "Вечная Токи" };
            ListView lista = new ListView();

            lista.ItemsSource = taska;

            lista.ItemSelected += Lista_ItemSelected;
            Content = new StackLayout { Children = { searchBar, lista } };
           
        }

        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string text = e.SelectedItem.ToString();
            if (e.SelectedItemIndex == 0)
            {
                await Navigation.PushAsync(new afka());
            }

            if (e.SelectedItemIndex == 1)
            {
                await Navigation.PushAsync(new alakir());
            }

            if (e.SelectedItemIndex == 2)
            {
                await Navigation.PushAsync(new alekstraza());
            }
            if (e.SelectedItemIndex == 3)
            {
                await Navigation.PushAsync(new arana());
            }
            if (e.SelectedItemIndex == 4)
            {
                await Navigation.PushAsync(new mahalai());
            }
            if (e.SelectedItemIndex == 5)
            {
                await Navigation.PushAsync(new toki());
            }

        }
    }
    }