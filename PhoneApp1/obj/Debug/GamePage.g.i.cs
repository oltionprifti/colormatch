﻿#pragma checksum "D:\Oltion\APLIKACIONE\PhoneApp1\PhoneApp1\GamePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9C7301F656BF30C67F659874C46AA82B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using SOMAWP8;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PhoneApp1 {
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard opacityStoryBoard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock scoreText;
        
        internal System.Windows.Shapes.Path textBlock;
        
        internal System.Windows.Controls.TextBlock colorName;
        
        internal System.Windows.Shapes.Path colorBlock;
        
        internal System.Windows.Controls.Image answerImage;
        
        internal SOMAWP8.SomaAdViewer SmaatoAd;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/GamePage.xaml", System.UriKind.Relative));
            this.opacityStoryBoard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("opacityStoryBoard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.scoreText = ((System.Windows.Controls.TextBlock)(this.FindName("scoreText")));
            this.textBlock = ((System.Windows.Shapes.Path)(this.FindName("textBlock")));
            this.colorName = ((System.Windows.Controls.TextBlock)(this.FindName("colorName")));
            this.colorBlock = ((System.Windows.Shapes.Path)(this.FindName("colorBlock")));
            this.answerImage = ((System.Windows.Controls.Image)(this.FindName("answerImage")));
            this.SmaatoAd = ((SOMAWP8.SomaAdViewer)(this.FindName("SmaatoAd")));
        }
    }
}

