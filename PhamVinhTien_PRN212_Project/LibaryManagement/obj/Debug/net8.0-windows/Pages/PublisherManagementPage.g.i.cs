﻿#pragma checksum "..\..\..\..\Pages\PublisherManagementPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A173AB41705C83BBB0660FB11E05CA79DCB0C13A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibaryManagement.Pages;
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


namespace LibaryManagement.Pages {
    
    
    /// <summary>
    /// PublisherManagementPage
    /// </summary>
    public partial class PublisherManagementPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Pages\PublisherManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPublisherId;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\PublisherManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPublisherName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Pages\PublisherManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPublisherId;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\PublisherManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPublisherName;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\PublisherManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvPublishers;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibaryManagement;component/pages/publishermanagementpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\PublisherManagementPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbPublisherId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbPublisherName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 34 "..\..\..\..\Pages\PublisherManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Add_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 35 "..\..\..\..\Pages\PublisherManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Edit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 36 "..\..\..\..\Pages\PublisherManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 37 "..\..\..\..\Pages\PublisherManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtPublisherId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtPublisherName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.lvPublishers = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

