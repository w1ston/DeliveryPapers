﻿#pragma checksum "..\..\..\ChoiceThemeFold\SelThemeWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9E9756001AB3AF3E14869B1B97FABAC1F779D17A91178A96086EA9673147A1BB"
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
using WpfApp7.ChoiceThemeFold;


namespace WpfApp7.ChoiceThemeFold {
    
    
    /// <summary>
    /// SelThemeWindow
    /// </summary>
    public partial class SelThemeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ChoiceThemeFold\SelThemeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NameGroupp;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ChoiceThemeFold\SelThemeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label x1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ChoiceThemeFold\SelThemeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ChoiceThemeFold\SelThemeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataInStudent;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp7;component/choicethemefold/selthemewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChoiceThemeFold\SelThemeWindow.xaml"
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
            
            #line 8 "..\..\..\ChoiceThemeFold\SelThemeWindow.xaml"
            ((WpfApp7.ChoiceThemeFold.SelThemeWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.SelThemeWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NameGroupp = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\..\ChoiceThemeFold\SelThemeWindow.xaml"
            this.NameGroupp.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.NameGroupp_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.x1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\ChoiceThemeFold\SelThemeWindow.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DataInStudent = ((System.Windows.Controls.DataGrid)(target));
            
            #line 22 "..\..\..\ChoiceThemeFold\SelThemeWindow.xaml"
            this.DataInStudent.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DataInStudent_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
