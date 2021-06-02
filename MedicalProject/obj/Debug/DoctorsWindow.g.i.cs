﻿#pragma checksum "..\..\DoctorsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F92B70C0577C62EA89550B8C6A36D33B048BD8B219509942B53EE96E771C05D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using MedicalProject;
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


namespace MedicalProject {
    
    
    /// <summary>
    /// DoctorsWindow
    /// </summary>
    public partial class DoctorsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridDoctors;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddDoctorBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteDoctorBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\DoctorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditDoctorBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/MedicalProject;component/doctorswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DoctorsWindow.xaml"
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
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\DoctorsWindow.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DataGridDoctors = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.AddDoctorBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\DoctorsWindow.xaml"
            this.AddDoctorBtn.Click += new System.Windows.RoutedEventHandler(this.AddDoctorBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteDoctorBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\DoctorsWindow.xaml"
            this.DeleteDoctorBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteDoctorBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EditDoctorBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\DoctorsWindow.xaml"
            this.EditDoctorBtn.Click += new System.Windows.RoutedEventHandler(this.EditDoctorBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

