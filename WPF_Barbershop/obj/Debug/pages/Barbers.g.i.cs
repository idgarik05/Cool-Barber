﻿#pragma checksum "..\..\..\pages\Barbers.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "859AF11656E18D2F8D0AD3F23EC58C4A160655C3F1857444C9EE1A4528B7E533"
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
using WPF_Barbershop.pages;


namespace WPF_Barbershop.pages {
    
    
    /// <summary>
    /// Barbers
    /// </summary>
    public partial class Barbers : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 87 "..\..\..\pages\Barbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search_Barber;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\pages\Barbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBarberBtn;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\pages\Barbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBarberBtn;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\pages\Barbers.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DG_Barbers;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_Barbershop;component/pages/barbers.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\Barbers.xaml"
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
            this.Search_Barber = ((System.Windows.Controls.TextBox)(target));
            
            #line 87 "..\..\..\pages\Barbers.xaml"
            this.Search_Barber.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_Barber_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddBarberBtn = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\pages\Barbers.xaml"
            this.AddBarberBtn.Click += new System.Windows.RoutedEventHandler(this.AddBarberBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteBarberBtn = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\pages\Barbers.xaml"
            this.DeleteBarberBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBarberBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DG_Barbers = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

