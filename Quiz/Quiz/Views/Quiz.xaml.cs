using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz : ContentPage
    {
        private static string[] quizObject;
        public Quiz()
        {
            InitializeComponent();
            quizObject = getRandomQuizObject();
            Heading.Text = quizObject[1];
            Antwort1Btn.Text = quizObject[2];
            Antwort2Btn.Text = quizObject[3];
            Antwort3Btn.Text = quizObject[4];
            Antwort4Btn.Text = quizObject[5];
        }

        private void Antwort1Btn_Clicked(object sender, System.EventArgs e)
        {
            if (Quiz.quizObject[2] == Quiz.quizObject[6])
            {
                Antwort1Btn.BackgroundColor = Color.Green;
                enableSendBtn();
                Statisch.punktzahl = Statisch.punktzahl + 1;
            } else
            {
                Antwort1Btn.BackgroundColor = Color.Red;
                enableSendBtn();
            }
        }
        private void Antwort2Btn_Clicked(object sender, System.EventArgs e)
        {
            if (Quiz.quizObject[3] == Quiz.quizObject[6])
            {
                Antwort2Btn.BackgroundColor = Color.Green;
                enableSendBtn();
                Statisch.punktzahl = Statisch.punktzahl + 1;
            }
            else
            {
                Antwort2Btn.BackgroundColor = Color.Red;
                enableSendBtn();
            }
        }
        private void Antwort3Btn_Clicked(object sender, System.EventArgs e)
        {
            if (Quiz.quizObject[4] == Quiz.quizObject[6])
            {
                Antwort3Btn.BackgroundColor = Color.Green;
                enableSendBtn();
                Statisch.punktzahl = Statisch.punktzahl + 1;
            }
            else
            {
                Antwort3Btn.BackgroundColor = Color.Red;
                enableSendBtn();
            }
        }
        private void Antwort4Btn_Clicked(object sender, System.EventArgs e)
        {
            if (Quiz.quizObject[5] == Quiz.quizObject[6])
            {
                Antwort4Btn.BackgroundColor = Color.Green;
                enableSendBtn();
                Statisch.punktzahl = Statisch.punktzahl + 1;
            }
            else
            {
                Antwort4Btn.BackgroundColor = Color.Red;
                enableSendBtn();
            }
        }
        private void SendBtn_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Quiz());
        }
        private void enableSendBtn()
        {
            SendBtn.Opacity = 100;
            SendBtn.IsEnabled = true;
            Antwort1Btn.IsEnabled = false;
            Antwort2Btn.IsEnabled = false;
            Antwort3Btn.IsEnabled = false;
            Antwort4Btn.IsEnabled = false;
        }
        private string[] getRandomQuizObject()
        {
            FragenViewModel.Update();
            var random = new Random();
            var RandomGenerated = random.Next(0, FragenViewModel.quizcollection.Length);
            if(Statisch.abgefragt != null)
            {
                if(Statisch.abgefragt.Count == 10)
                {
                    Navigation.PushModalAsync(new Scoreboard());
                } else
                {
                    while (Statisch.abgefragt.Contains(RandomGenerated))
                    {
                        RandomGenerated = random.Next(0, FragenViewModel.quizcollection.Length);
                    }
                }
            }
            var obj = FragenViewModel.quizcollection[RandomGenerated];
            Statisch.abgefragt.Add(RandomGenerated);
            string[] randomAnswers = randomizeAnswers(obj.Antwort1, obj.Antwort2, obj.Antwort3, obj.Antwort4);
            string[] quizObject =
            {
                obj.ID,
                obj.Frage,
                randomAnswers[0],
                randomAnswers[1],
                randomAnswers[2],
                randomAnswers[3],
                obj.Korrekt
            };
            return quizObject;
        }
        private string[] randomizeAnswers(string a1, string a2, string a3, string a4)
        {
            string[] answers =
            {
                a1, a2, a3, a4
            };

            Random random = new Random();
            string[] MyRandomArray = answers.OrderBy(x => random.Next()).ToArray();

            return MyRandomArray;
        }
    }
}