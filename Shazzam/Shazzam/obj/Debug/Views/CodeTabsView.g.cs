﻿#pragma checksum "..\..\..\Views\CodeTabsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1CAB8D604964A8097A83163C2273FDAC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Magic.Controls;
using Microsoft.Windows.Themes;
using Shazzam.Commands;
using Shazzam.Converters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Shazzam.Views {
    
    
    /// <summary>
    /// CodeTabView
    /// </summary>
    public partial class CodeTabView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Controls.TabControl codeTabControl;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Controls.TabItem codeTab;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Controls.Primitives.Popup messagePopup;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Controls.TextBlock outputTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Forms.Integration.WindowsFormsHost formsHost;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Controls.TabItem csharpTab;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Forms.Integration.WindowsFormsHost formsHostCs;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Controls.TabItem vbTab;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Forms.Integration.WindowsFormsHost formsHostVb;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Controls.TabItem InputControlsTab;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\Views\CodeTabsView.xaml"
        internal System.Windows.Controls.StackPanel inputControlPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Shazzam;component/views/codetabsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CodeTabsView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.codeTabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.codeTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 3:
            this.messagePopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 4:
            this.outputTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.formsHost = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 6:
            this.csharpTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 7:
            this.formsHostCs = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 8:
            this.vbTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 9:
            this.formsHostVb = ((System.Windows.Forms.Integration.WindowsFormsHost)(target));
            return;
            case 10:
            this.InputControlsTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 11:
            this.inputControlPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
