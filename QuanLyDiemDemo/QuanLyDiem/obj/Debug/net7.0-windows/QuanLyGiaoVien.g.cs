﻿#pragma checksum "..\..\..\QuanLyGiaoVien.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8C7F7EF7E0E7C3F33403B8519F7688AB61C881AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuanLyDiem;
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


namespace QuanLyDiem {
    
    
    /// <summary>
    /// QuanLyGiaoVien
    /// </summary>
    public partial class QuanLyGiaoVien : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\QuanLyGiaoVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgGiaoVien;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\QuanLyGiaoVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMa;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\QuanLyGiaoVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTen;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\QuanLyGiaoVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQueQuan;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\QuanLyGiaoVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSDT;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\QuanLyGiaoVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTrinhDoHocVan;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\QuanLyGiaoVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpNgaySinh;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuanLyDiem;component/quanlygiaovien.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\QuanLyGiaoVien.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\QuanLyGiaoVien.xaml"
            ((QuanLyDiem.QuanLyGiaoVien)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\..\QuanLyGiaoVien.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\..\QuanLyGiaoVien.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 14 "..\..\..\QuanLyGiaoVien.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dtgGiaoVien = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\..\QuanLyGiaoVien.xaml"
            this.dtgGiaoVien.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dtgGiaoVien_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtMa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtTen = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtQueQuan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtSDT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtTrinhDoHocVan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.dtpNgaySinh = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
