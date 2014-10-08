using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;


namespace PhoneApp1
{
    public partial class Page1 : PhoneApplicationPage
    {
        Color[] colors = { Colors.Red,Colors.Blue,Colors.Green,Colors.Yellow,Colors.White,Colors.Black};
        String[] colorStr = { Colors.Red.ToString(), Colors.Blue.ToString(), Colors.Green.ToString(), Colors.Yellow.ToString(), Colors.White.ToString(), Colors.Black.ToString() };
        String[] displayColorStr = { "Red", "Blue", "Green", "Yellow", "White", "Black" };
        Random random = new Random();
        SolidColorBrush rectBrush = new SolidColorBrush();
        SolidColorBrush textBrush = new SolidColorBrush();
        int currentColor = -1;
        int currnetColorStr = -1;
        int score = 0;
        int puzzleNumber = 0;
        DateTime bonusPointTimer;

        public Page1()
        {
            InitializeComponent();            
            newPuzzle();
            this.Loaded += Page1_Loaded;
        }

        private void Page1_Loaded(object sender, RoutedEventArgs e)
        {
            SmaatoAd.Pub = 923882789;
            SmaatoAd.Adspace = 65846553;
            SmaatoAd.StartAds();
        }

        private void onMatch(object sender, RoutedEventArgs e)
        {
            checkAnswer( true );
        }

        private void onNoMatch(object sender, RoutedEventArgs e)
        {
            checkAnswer( false );
        }

        private void checkAnswer(bool isMatch )
        {
            bool isSameColor = (colors[currentColor].ToString() == colorStr[currnetColorStr]);

            if ( isSameColor == isMatch )
            {             
                //correct answer
                //add points for correct answer
                score += 10;
                //calculate time taken to anser and add bonus point for time
                TimeSpan elapsedTime = DateTime.Now - bonusPointTimer;
                double miliSecs = elapsedTime.TotalMilliseconds;
                //bonus point if if users answerd within certain seconds
                double bonus = (2000 - miliSecs)/100;
                if (bonus < 0)
                {
                    bonus = 0;
                }
                score += (int)bonus;
                //animation for correct answer
                animate(true);
            }
            else
            {
                //wrong answer
                //animation for wrong answer
                animate(false);
            }
            //reset the bonus point timer
            scoreText.Text = String.Format("{0}",score);
        }

        private void animate(bool isCorrectAnswer)
        {
            //answerImage.Source = isCorrectAnswer ? ("correct.png") : ("wrong.png");
            Uri uri = null;
            if (isCorrectAnswer)
            {
                uri = new Uri("Assets/correct.png", UriKind.Relative);
            }
            else
            {
                uri = new Uri("Assets/wrong.png", UriKind.Relative);
            }

            StreamResourceInfo resourceInfo = Application.GetResourceStream(uri); 
            BitmapImage bmp = new BitmapImage(); 
            bmp.SetSource(resourceInfo.Stream);
            answerImage.Source = bmp;
            opacityStoryBoard.Begin();
        }

        private void onAnimationComplete(object sender, EventArgs e)
        {
            answerImage.Opacity = 0;
            newPuzzle();
        }

        private void newPuzzle()
        {
            if (puzzleNumber == 20)
            {
                //game over, show points
                //save points in isolated storage
                String destination = String.Format("/ScorePage.xaml?score={0}", score);
                this.NavigationService.Navigate(new Uri(destination, UriKind.Relative));
                return;
            }

            puzzleNumber++;
            bonusPointTimer = DateTime.Now;
            int sameColorAndText = random.Next(100);
            if (sameColorAndText >= 30 && sameColorAndText <= 50)
            {
                currentColor = random.Next(colors.Length);
                currnetColorStr = currentColor;
            }
            else
            {
                currentColor = random.Next(colors.Length);
                currnetColorStr = random.Next(colors.Length);
            }

            int randTextColor = random.Next(colors.Length);

            rectBrush.Color = colors[currentColor];
            colorBlock.Fill = rectBrush;
            colorName.Text = displayColorStr[currnetColorStr];

            textBrush.Color = colors[randTextColor];
            colorName.Foreground = textBrush;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (puzzleNumber == 20)
            {
                this.NavigationService.GoBack();
            }
        }
    }
}