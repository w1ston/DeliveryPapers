﻿#pragma checksum "..\..\..\Group\SearchGroupPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D55B2C1A4311E467D8B6309DA2BCF2BEACC037A878408ECCCBD6FE118D235D89"
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
using WpfApp7.Group;


namespace WpfApp7.Group {
    
    
    /// <summary>
    /// SearchGroupPage
    /// </summary>
    public partial class SearchGroupPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Group\SearchGroupPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Group\SearchGroupPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboSpec;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Group\SearchGroupPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewTheme;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Group\SearchGroupPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WpfApp7;component/group/searchgrouppage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Group\SearchGroupPage.xaml"
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
            this.GBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Group\SearchGroupPage.xaml"
            this.GBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.GBoxSearch_TextChanded);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\Group\SearchGroupPage.xaml"
            this.GBoxSearch.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.GBoxSearch_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboSpec = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\Group\SearchGroupPage.xaml"
            this.ComboSpec.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboSpec_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LViewTheme = ((System.Windows.Controls.ListView)(target));
            
            #line 29 "..\..\..\Group\SearchGroupPage.xaml"
            this.LViewTheme.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.GViewTheme_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Group\SearchGroupPage.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

