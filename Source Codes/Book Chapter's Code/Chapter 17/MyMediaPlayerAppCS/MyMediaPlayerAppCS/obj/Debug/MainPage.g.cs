﻿#pragma checksum "D:\Books\Black Book\ASP.NET 4.0_BB\Applications_Chapter 20\CS\MyMediaPlayerAppCS\MyMediaPlayerAppCS\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FE42BCCAB6D9A408F30F5E5B9F7E42E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace MyMediaPlayerAppCS {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button play;
        
        internal System.Windows.Controls.Button pause;
        
        internal System.Windows.Controls.Button stop;
        
        internal System.Windows.Controls.MediaElement mediaEle;
        
        internal System.Windows.Controls.TextBlock errorText;
        
        internal System.Windows.Controls.TextBlock mediaFile;
        
        internal System.Windows.Controls.TextBlock duration;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MyMediaPlayerAppCS;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.play = ((System.Windows.Controls.Button)(this.FindName("play")));
            this.pause = ((System.Windows.Controls.Button)(this.FindName("pause")));
            this.stop = ((System.Windows.Controls.Button)(this.FindName("stop")));
            this.mediaEle = ((System.Windows.Controls.MediaElement)(this.FindName("mediaEle")));
            this.errorText = ((System.Windows.Controls.TextBlock)(this.FindName("errorText")));
            this.mediaFile = ((System.Windows.Controls.TextBlock)(this.FindName("mediaFile")));
            this.duration = ((System.Windows.Controls.TextBlock)(this.FindName("duration")));
        }
    }
}
