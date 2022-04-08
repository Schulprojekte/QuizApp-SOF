using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Quiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BTNStart_Clicked(object sender, EventArgs e)
        {
            Statisch.abgefragt = new List<int> { };
            Statisch.punktzahl = 0;
            Navigation.PushModalAsync(new Quiz());
        }
    }
}
