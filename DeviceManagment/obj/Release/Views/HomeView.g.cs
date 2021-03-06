#pragma checksum "..\..\..\Views\HomeView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D70A34B1972FADF4F3B4972D6B1861D4B8DBFACD4822E8E1CCC6A467CC1BD15F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace DeviceManagment.Views {
    
    
    /// <summary>
    /// HomeView
    /// </summary>
    public partial class HomeView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Views\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrollViewer;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run PrinterNameRun;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClaimAndEnableButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox RetainDeviceCheckBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReleaseClaimedPrinterButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReleaseAllPrintersButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\HomeView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InvokePrintingButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DeviceManagment;component/views/homeview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\HomeView.xaml"
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
            
            #line 10 "..\..\..\Views\HomeView.xaml"
            ((DeviceManagment.Views.HomeView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Views\HomeView.xaml"
            ((DeviceManagment.Views.HomeView)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.UserControl_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.scrollViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 3:
            this.FindButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Views\HomeView.xaml"
            this.FindButton.Click += new System.Windows.RoutedEventHandler(this.FindButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PrinterNameRun = ((System.Windows.Documents.Run)(target));
            return;
            case 5:
            this.ClaimAndEnableButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Views\HomeView.xaml"
            this.ClaimAndEnableButton.Click += new System.Windows.RoutedEventHandler(this.ClaimAndEnableButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RetainDeviceCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 37 "..\..\..\Views\HomeView.xaml"
            this.RetainDeviceCheckBox.Click += new System.Windows.RoutedEventHandler(this.RetainDeviceCheckBox_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ReleaseClaimedPrinterButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Views\HomeView.xaml"
            this.ReleaseClaimedPrinterButton.Click += new System.Windows.RoutedEventHandler(this.ReleaseClaimedPrinterButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ReleaseAllPrintersButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Views\HomeView.xaml"
            this.ReleaseAllPrintersButton.Click += new System.Windows.RoutedEventHandler(this.ReleaseAllPrintersButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.InvokePrintingButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Views\HomeView.xaml"
            this.InvokePrintingButton.Click += new System.Windows.RoutedEventHandler(this.InvokePrintingButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

