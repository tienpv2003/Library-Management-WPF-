﻿#pragma checksum "..\..\..\..\Pages\BookManagementPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B58CAAEDE191110D5DFF753BAA3168B574CD6236"
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
    /// BookManagementPage
    /// </summary>
    public partial class BookManagementPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_bookName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_author;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sortName;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sortAmount;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sortAsc;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sortDes;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboCategory;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_BookId;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_BookName;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCategory;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAutor;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Amount;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPublisher;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\Pages\BookManagementPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvBooks;
        
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
            System.Uri resourceLocater = new System.Uri("/LibaryManagement;component/pages/bookmanagementpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\BookManagementPage.xaml"
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
            
            #line 9 "..\..\..\..\Pages\BookManagementPage.xaml"
            ((LibaryManagement.Pages.BookManagementPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.search_bookName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.search_author = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.sortName = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.sortAmount = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.sortAsc = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.sortDes = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.cboCategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 65 "..\..\..\..\Pages\BookManagementPage.xaml"
            this.cboCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 72 "..\..\..\..\Pages\BookManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_AddClicked);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 73 "..\..\..\..\Pages\BookManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_EditClicked);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 74 "..\..\..\..\Pages\BookManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_RefreshClicked);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 75 "..\..\..\..\Pages\BookManagementPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_SearchClicked);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Pages\BookManagementPage.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btn_DeleteClicked);
            
            #line default
            #line hidden
            return;
            case 14:
            this.tb_BookId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.tb_BookName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.tbCategory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.tbAutor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            this.tb_Amount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 19:
            this.tbPublisher = ((System.Windows.Controls.TextBox)(target));
            return;
            case 20:
            this.lvBooks = ((System.Windows.Controls.ListView)(target));
            
            #line 131 "..\..\..\..\Pages\BookManagementPage.xaml"
            this.lvBooks.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvSelectionChange);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

