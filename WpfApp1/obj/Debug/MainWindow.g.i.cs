﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CF57C158294E6FDD5D1510F687C3328CAD13914DDB27AF623AB41B9311A2A138"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 106 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Książki;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dodajksiążkę;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Wypożyczenia;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Książki = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\MainWindow.xaml"
            this.Książki.Click += new System.Windows.RoutedEventHandler(this.Ksiazki);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 107 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Autorzy);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 108 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Gatunki);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Dodajksiążkę = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\MainWindow.xaml"
            this.Dodajksiążkę.Click += new System.Windows.RoutedEventHandler(this.DodajKsiazke);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Wypożyczenia = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\MainWindow.xaml"
            this.Wypożyczenia.Click += new System.Windows.RoutedEventHandler(this.Wypozyczenia);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 112 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

