using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChemEngMaps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            StartUp();
        }

        private void StartUp()
        {
            maps.Text = @"Χάρτης Σχολής";
            profs.Text = @"Γραφεία Καθηγητών";
            rooms.Text = @"Αίθουσες Διδασκαδίας - Εργαστήρια";
            creds.Text = @"Credits";
        }

        public void maps_Clicked(object Sender, EventArgs e)
        {
            Maps.MapsFloorList nPage = new Maps.MapsFloorList();
            Navigation.PushModalAsync(nPage);
        }
    }
}
