﻿#pragma checksum "..\..\..\LogIn\ChoiceStud.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "782084C73D6E310501B8048F43EB8B248A86CF3D42FD5288628C29167054380B"
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
using WpfApp7.LogIn;


namespace WpfApp7.LogIn {
    
    
    /// <summary>
    /// ChoiceStud
    /// </summary>
    public partial class ChoiceStud : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\LogIn\ChoiceStud.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ChoiceCard;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\LogIn\ChoiceStud.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CheckStud;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\LogIn\ChoiceStud.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp7;component/login/choicestud.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LogIn\ChoiceStud.xaml"
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
            this.ChoiceCard = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\LogIn\ChoiceStud.xaml"
            this.ChoiceCard.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ChoiceCard_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CheckStud = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\LogIn\ChoiceStud.xaml"
            this.CheckStud.Click += new System.Windows.RoutedEventHandler(this.CheckStud_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ExitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\LogIn\ChoiceStud.xaml"
            this.ExitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

