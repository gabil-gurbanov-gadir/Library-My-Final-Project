﻿#pragma checksum "..\..\..\..\Windows\ClientsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DE22E15A667B70D77036B138E0ACF53ABE278820"
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
    /// ClientsWindow
    /// </summary>
    public partial class ClientsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Windows\ClientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblName;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Windows\ClientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtName;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Windows\ClientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblSurname;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Windows\ClientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSurname;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Windows\ClientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblPhone;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Windows\ClientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPhone;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Windows\ClientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreate;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Windows\ClientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdate;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Windows\ClientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Windows\ClientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgvClients;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library-Final Project;component/windows/clientswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\ClientsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LblName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.TxtName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LblSurname = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TxtSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LblPhone = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.TxtPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BtnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Windows\ClientsWindow.xaml"
            this.BtnCreate.Click += new System.Windows.RoutedEventHandler(this.BtnCreate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Windows\ClientsWindow.xaml"
            this.BtnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Windows\ClientsWindow.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DgvClients = ((System.Windows.Controls.DataGrid)(target));
            
            #line 22 "..\..\..\..\Windows\ClientsWindow.xaml"
            this.DgvClients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgvClients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

