﻿#pragma checksum "C:\Users\yenely.REDMOND\colorify\PhotoColorify\SharePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BF17011B6207C2143D0F296DE171F0A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace Colorify {
    
    
    public partial class SharePage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Controls.ProgressBar loading;
        
        internal System.Windows.Controls.TextBox titleBar;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock textBlock6;
        
        internal System.Windows.Controls.ListBox listBox1;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal Microsoft.Phone.Controls.WebBrowser browserAuth;
        
        internal System.Windows.Controls.Grid twitterGrid;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBox frmTwitterUsername;
        
        internal System.Windows.Controls.TextBlock textBlock4;
        
        internal System.Windows.Controls.TextBlock textBlock5;
        
        internal System.Windows.Controls.PasswordBox frmTwitterPassword;
        
        internal System.Windows.Controls.CheckBox frmTwitterRemember;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Colorify;component/SharePage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.loading = ((System.Windows.Controls.ProgressBar)(this.FindName("loading")));
            this.titleBar = ((System.Windows.Controls.TextBox)(this.FindName("titleBar")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.textBlock6 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock6")));
            this.listBox1 = ((System.Windows.Controls.ListBox)(this.FindName("listBox1")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.browserAuth = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("browserAuth")));
            this.twitterGrid = ((System.Windows.Controls.Grid)(this.FindName("twitterGrid")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.frmTwitterUsername = ((System.Windows.Controls.TextBox)(this.FindName("frmTwitterUsername")));
            this.textBlock4 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock4")));
            this.textBlock5 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock5")));
            this.frmTwitterPassword = ((System.Windows.Controls.PasswordBox)(this.FindName("frmTwitterPassword")));
            this.frmTwitterRemember = ((System.Windows.Controls.CheckBox)(this.FindName("frmTwitterRemember")));
        }
    }
}

