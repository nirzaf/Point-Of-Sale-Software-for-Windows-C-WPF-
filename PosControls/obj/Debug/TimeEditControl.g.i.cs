﻿#pragma checksum "..\..\TimeEditControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ED3C7FEE6DB472413F0744ED79A54D40"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PosControls;
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
using System.Windows.Shell;


namespace PosControls {
    
    
    /// <summary>
    /// TimeEditControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class TimeEditControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 7 "..\..\TimeEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TimeEditControl UserControl;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\TimeEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\TimeEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\TimeEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridControl2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\TimeEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderControl;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\TimeEditControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTime;
        
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
            System.Uri resourceLocater = new System.Uri("/PosControls;component/timeeditcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TimeEditControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserControl = ((PosControls.TimeEditControl)(target));
            
            #line 8 "..\..\TimeEditControl.xaml"
            this.UserControl.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.dockPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.mainPane = ((System.Windows.Controls.DockPanel)(target));
            
            #line 16 "..\..\TimeEditControl.xaml"
            this.mainPane.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.dockPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Configuration = ((PosControls.ConfigurationManager)(target));
            return;
            case 5:
            this.gridControl2 = ((System.Windows.Controls.Grid)(target));
            
            #line 18 "..\..\TimeEditControl.xaml"
            this.gridControl2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.dockPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.borderControl = ((System.Windows.Controls.Border)(target));
            
            #line 19 "..\..\TimeEditControl.xaml"
            this.borderControl.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.dockPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.labelTime = ((System.Windows.Controls.Label)(target));
            
            #line 23 "..\..\TimeEditControl.xaml"
            this.labelTime.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.dockPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 11 "..\..\TimeEditControl.xaml"
            ((System.Windows.Controls.Border)(target)).Initialized += new System.EventHandler(this.Border_Initialized);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
