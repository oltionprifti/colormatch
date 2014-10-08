using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace PhoneApp1
{
    public partial class ScorePage : PhoneApplicationPage
    {
        public ScorePage()
        {
            InitializeComponent();
            this.Loaded += ScorePage_Loaded;
        }

        private void ScorePage_Loaded(object sender, RoutedEventArgs e)
        {
            SmaatoAd.Pub = 923882789;
            SmaatoAd.Adspace = 65846553;
            SmaatoAd.StartAds();
        }

        private void onGoToMenu(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            IDictionary<string, string> parameters = this.NavigationContext.QueryString;         
            String scoreStr = parameters["score"];
            int highScore = getHighScore();
            int score = Convert.ToInt32(scoreStr);
            if (score > highScore)
            {
                greetingText.Text = "Congratulations!!";
                firstLine.Text = String.Format("New High score : {0}", score);
                secondLine.Text = String.Format("Previous High score : {0}", highScore);
                savaHighScore(score);
            }
            else if (score < highScore && score <= 50)
            {
                greetingText.Text = "Bad! :(";
                firstLine.Text = String.Format("Your score : {0}", score);
                secondLine.Text = String.Format("Current High score : {0}", highScore);
            }
            else if (score < highScore && score <= 80 && score > 50)
            {
                greetingText.Text = "Fair!";
                firstLine.Text = String.Format("Your score : {0}", score);
                secondLine.Text = String.Format("Current High score : {0}", highScore);
            }
            else
            {
                greetingText.Text = "Good Job!";
                firstLine.Text = String.Format("Your score : {0}", score);
                secondLine.Text = String.Format("Current High score : {0}", highScore);
            }
        }

        private void savaHighScore(int score)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            settings["highScore"] = score;
            settings.Save();
        }

        private int getHighScore()
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            int score;
            if (settings.TryGetValue<int>("highScore", out score))
            {
                return score;
            }
            return 0;
        }
    }
}