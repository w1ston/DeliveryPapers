﻿#pragma checksum "..\..\SearchThemePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7313035F59D45139FD1B3A67D69648AFF31B7360563ED2C4C6254A115F0366A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp7;


namespace WpfApp7 {
    
    
    /// <summary>
    /// SearchThemePage
    /// </summary>
    public partial class SearchThemePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\SearchThemePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SearchThemePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboDisc;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\SearchThemePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewTheme;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\SearchThemePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp7;component/searchthemepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchThemePage.xaml"
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
            this.TBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\SearchThemePage.xaml"
            this.TBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBoxSearch_TextChanded);
            
            #line default
            #line hidden
            
            #line 21 "..\..\SearchThemePage.xaml"
            this.TBoxSearch.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TBoxSearch_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboDisc = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\SearchThemePage.xaml"
            this.ComboDisc.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboDisc_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LViewTheme = ((System.Windows.Controls.ListView)(target));
            
            #line 29 "..\..\SearchThemePage.xaml"
            this.LViewTheme.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TViewTheme_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\SearchThemePage.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
