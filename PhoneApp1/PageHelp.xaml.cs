using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp1
{
    public partial class PageHelp : PhoneApplicationPage
    {
        public PageHelp()
        {
            InitializeComponent();
            this.Loaded += PageHelp_Loaded;
        }

        private void PageHelp_Loaded(object sender, RoutedEventArgs e)
        {
            SmaatoAd.Pub = 923882789;
            SmaatoAd.Adspace = 65846553;
            SmaatoAd.StartAds();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));   
        }
    }
}