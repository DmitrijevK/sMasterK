using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sMasterK
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            heroes.ItemsSource = Menulist();
            var StartPage = typeof(funkt.heroess);
            Detail = new NavigationPage((Page)Activator.CreateInstance(StartPage));
            IsPresented = false;
        }

        private List<klas> Menulist()
        {
            var herolist = new List<klas>();
            herolist.Add(new klas()
            {
                Text = "Герои",
                Detail = "герои",
                ImageP = "",
                TarPage = typeof(funkt.heroess)
            });
            return herolist; 

        }

        private void heroes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
    }

