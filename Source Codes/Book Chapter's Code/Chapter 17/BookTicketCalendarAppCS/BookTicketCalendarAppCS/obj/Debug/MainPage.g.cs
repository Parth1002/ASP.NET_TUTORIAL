﻿#pragma checksum "D:\Books\Black Book\ASP.NET 4.0_BB\Applications_Chapter 20\CS\BookTicketCalendarAppCS\BookTicketCalendarAppCS\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A1481E9DA7B091FC6FE834A7E4970DE2"
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


namespace BookTicketCalendarAppCS {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle backImage;
        
        internal System.Windows.Controls.TextBlock text1;
        
        internal System.Windows.Controls.TextBlock text2;
        
        internal System.Windows.Controls.TextBlock text3;
        
        internal System.Windows.Controls.TextBlock text4;
        
        internal System.Windows.Controls.TextBox fromDateBox;
        
        internal System.Windows.Controls.Button fromIconButton;
        
        internal System.Windows.Controls.Image fromIcon;
        
        internal System.Windows.Controls.Calendar fromCal;
        
        internal System.Windows.Controls.TextBlock text5;
        
        internal System.Windows.Controls.TextBox toDateBox;
        
        internal System.Windows.Controls.Button toIconButton;
        
        internal System.Windows.Controls.Image toIcon;
        
        internal System.Windows.Controls.Calendar toCal;
        
        internal System.Windows.Controls.Button checkAvailibility;
        
        internal System.Windows.Controls.TextBlock text6;
        
        internal System.Windows.Controls.TextBox selectDateBox;
        
        internal System.Windows.Controls.Button selectIconButton;
        
        internal System.Windows.Controls.Image selectDateIcon;
        
        internal System.Windows.Controls.Calendar selectCal;
        
        internal System.Windows.Controls.Button confirmButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/BookTicketCalendarAppCS;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.backImage = ((System.Windows.Shapes.Rectangle)(this.FindName("backImage")));
            this.text1 = ((System.Windows.Controls.TextBlock)(this.FindName("text1")));
            this.text2 = ((System.Windows.Controls.TextBlock)(this.FindName("text2")));
            this.text3 = ((System.Windows.Controls.TextBlock)(this.FindName("text3")));
            this.text4 = ((System.Windows.Controls.TextBlock)(this.FindName("text4")));
            this.fromDateBox = ((System.Windows.Controls.TextBox)(this.FindName("fromDateBox")));
            this.fromIconButton = ((System.Windows.Controls.Button)(this.FindName("fromIconButton")));
            this.fromIcon = ((System.Windows.Controls.Image)(this.FindName("fromIcon")));
            this.fromCal = ((System.Windows.Controls.Calendar)(this.FindName("fromCal")));
            this.text5 = ((System.Windows.Controls.TextBlock)(this.FindName("text5")));
            this.toDateBox = ((System.Windows.Controls.TextBox)(this.FindName("toDateBox")));
            this.toIconButton = ((System.Windows.Controls.Button)(this.FindName("toIconButton")));
            this.toIcon = ((System.Windows.Controls.Image)(this.FindName("toIcon")));
            this.toCal = ((System.Windows.Controls.Calendar)(this.FindName("toCal")));
            this.checkAvailibility = ((System.Windows.Controls.Button)(this.FindName("checkAvailibility")));
            this.text6 = ((System.Windows.Controls.TextBlock)(this.FindName("text6")));
            this.selectDateBox = ((System.Windows.Controls.TextBox)(this.FindName("selectDateBox")));
            this.selectIconButton = ((System.Windows.Controls.Button)(this.FindName("selectIconButton")));
            this.selectDateIcon = ((System.Windows.Controls.Image)(this.FindName("selectDateIcon")));
            this.selectCal = ((System.Windows.Controls.Calendar)(this.FindName("selectCal")));
            this.confirmButton = ((System.Windows.Controls.Button)(this.FindName("confirmButton")));
        }
    }
}