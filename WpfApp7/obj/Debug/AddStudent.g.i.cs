﻿#pragma checksum "..\..\AddStudent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B461E8A70AFE8C2EF8D15F6931D0AF62D94F811109E4CA1DAF8510F43F0550D8"
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
    /// AddStudent
    /// </summary>
    public partial class AddStudent : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdCard;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sur;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Pat;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboGroups;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddStudent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp7;component/addstudent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddStudent.xaml"
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
            this.IdCard = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\AddStudent.xaml"
            this.IdCard.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.IdCard_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Sur = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\AddStudent.xaml"
            this.Sur.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Sur_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\AddStudent.xaml"
            this.Name.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Name_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Pat = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\AddStudent.xaml"
            this.Pat.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Pat_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ComboGroups = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\AddStudent.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AddStudent.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
