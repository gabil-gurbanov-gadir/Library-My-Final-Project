﻿#pragma checksum "..\..\..\..\Windows\DashboardWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "729D18EA0AC396D8B40237DE4B6502F2B348AA6F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library_Final_Project.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Library_Final_Project.Windows {
    
    
    /// <summary>
    /// DashboardWindow
    /// </summary>
    public partial class DashboardWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUsers;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBooks;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnClients;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReports;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreateRental;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReturnBook;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFollowReturnTime;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library-Final Project;component/windows/dashboardwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\DashboardWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnUsers = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnUsers.Click += new System.Windows.RoutedEventHandler(this.BtnUsers_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnBooks = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnBooks.Click += new System.Windows.RoutedEventHandler(this.BtnBooks_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnClients = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnClients.Click += new System.Windows.RoutedEventHandler(this.BtnClients_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnReports = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnReports.Click += new System.Windows.RoutedEventHandler(this.BtnReports_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnCreateRental = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnCreateRental.Click += new System.Windows.RoutedEventHandler(this.BtnCreateRental_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnReturnBook = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnReturnBook.Click += new System.Windows.RoutedEventHandler(this.BtnReturnBook_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnFollowReturnTime = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnFollowReturnTime.Click += new System.Windows.RoutedEventHandler(this.BtnFollowReturnTime_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

