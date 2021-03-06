#pragma checksum "..\..\PageToPrint.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8ED96A90D895B7F96ECDBD01FB0147023E9BBCA160337DE6F660EDBD300307C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DeviceManagment;
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


namespace DeviceManagment {
    
    
    /// <summary>
    /// PageToPrint
    /// </summary>
    public partial class PageToPrint : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\PageToPrint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PrintableArea;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PageToPrint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Header;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PageToPrint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox SdkTitle;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\PageToPrint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox TextSelection;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\PageToPrint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox TextContent;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\PageToPrint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox FirstLinkedContainer;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\PageToPrint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox ContinuationPageLinkedContainer;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\PageToPrint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ScenarioImage;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\PageToPrint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Footer;
        
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
            System.Uri resourceLocater = new System.Uri("/DeviceManagment;component/pagetoprint.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageToPrint.xaml"
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
            this.PrintableArea = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Header = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.SdkTitle = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 4:
            this.TextSelection = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 5:
            this.TextContent = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 6:
            this.FirstLinkedContainer = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 7:
            this.ContinuationPageLinkedContainer = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 8:
            this.ScenarioImage = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.Footer = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

