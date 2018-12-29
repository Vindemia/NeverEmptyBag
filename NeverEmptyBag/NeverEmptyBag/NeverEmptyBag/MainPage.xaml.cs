using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using NeverEmptyBag;
using NeverEmptyBag.FormulaireCreation;

namespace NeverEmptyBag
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void perso1_Tapped(object sender, EventArgs e)
        {
            
        }
        private void perso2_Tapped(object sender, EventArgs e)
        {

        }

        private async void Btn_personnage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormPersonnage());
        }

        private async void Btn_univers_Clicked(object sender, EventArgs e)
        {

        }

        private async void Btn_campagnes_Clicked(object sender, EventArgs e)
        {

        }

        private async void Btn_items_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormItems());
        }
    }
}
