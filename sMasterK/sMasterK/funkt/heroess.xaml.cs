using sMasterK.pesi;
using System;
using System.Collections;
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
            InitializeComponent();
            listik.ItemsSource = Menulist();
        }

        private List<classs> Menulist()
        {
            var herolisti = new List<classs>();
            herolisti.Add(new classs()
            {
                Ltext = "Afka",
                Limage = "pilt.png",
                TarPage = typeof(pesi.afka)
            });

            herolisti.Add(new classs()
            {
                Ltext = "Поля сражений",
                Limage = "icon.png",
                TarPage = typeof(pesi.alakir)
            });

            herolisti.Add(new classs()
            {
                Ltext = "Карты",
                Limage = "msika.png",
                TarPage = typeof(pesi.alekstraza)
            });
            return herolisti;
        }

        private void listik_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selecte = (classs)e.SelectedItem;
            Type selectedpage = selecte.TarPage;
        }
    }
    }