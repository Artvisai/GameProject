﻿#pragma checksum "..\..\ChooseLevelWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "53C2EA68CE8C2631721D9C37E8FDB068E31376B3B40FDD8A3B48E80D2C918FA3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GameFight;
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


namespace GameFight {
    
    
    /// <summary>
    /// ChooseLevelWindow
    /// </summary>
    public partial class ChooseLevelWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ChooseLevelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LevelOne;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ChooseLevelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LevelThreeButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ChooseLevelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LevelTwoButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ChooseLevelWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
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
            System.Uri resourceLocater = new System.Uri("/GameFight;component/chooselevelwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChooseLevelWindow.xaml"
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
            this.LevelOne = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\ChooseLevelWindow.xaml"
            this.LevelOne.Click += new System.Windows.RoutedEventHandler(this.LevelOne_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LevelThreeButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\ChooseLevelWindow.xaml"
            this.LevelThreeButton.Click += new System.Windows.RoutedEventHandler(this.LevelThree_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LevelTwoButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\ChooseLevelWindow.xaml"
            this.LevelTwoButton.Click += new System.Windows.RoutedEventHandler(this.LevelTwo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\ChooseLevelWindow.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
