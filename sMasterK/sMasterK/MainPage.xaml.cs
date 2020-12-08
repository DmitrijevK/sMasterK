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
                ImageP = "pilt.png",
                TarPage = typeof(funkt.heroess)
            });

            herolist.Add(new klas()
            {
                Text = "Поля сражений",
                ImageP = "icon.png",
                TarPage = typeof(funkt.opisanie)
            });

            herolist.Add(new klas()
            {
                Text = "Карты",
                ImageP = "msika.png",
                TarPage = typeof(funkt.opisanie)
            });
            return herolist; 

        }

        private void heroes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selecte = (klas)e.SelectedItem;
            Type selectedpage = selecte.TarPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedpage));
            IsPresented = false;
        }
    }
    }

