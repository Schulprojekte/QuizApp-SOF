using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Scoreboard : ContentPage
    {
        public Scoreboard()
        {
            InitializeComponent();
            ErgebnisLbl.Text = "Sie haben " + Statisch.punktzahl + "/" + Statisch.abgefragt.Count + " Fragen richtig beantwortet!";
        }

        private void PlayAgainBtn_Clicked(object sender, EventArgs e)
        {
            Statisch.abgefragt = new List<int>{};
            Statisch.punktzahl = 0;
            Navigation.PushModalAsync(new Quiz());
        }
    }
}