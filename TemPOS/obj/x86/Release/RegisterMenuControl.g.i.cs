﻿#pragma checksum "..\..\..\RegisterMenuControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1FE9F7F43E182202981A9ABDE29F4BD3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PointOfSale;
using PosControls;
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


namespace PointOfSale {
    
    
    /// <summary>
    /// RegisterMenuControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class RegisterMenuControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\RegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\RegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\RegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonStartRegister;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\RegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonNoSale;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\RegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonDeposit;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\RegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonDrop;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\RegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonPayout;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\RegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonReport;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\RegisterMenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushButton buttonCloseOut;
        
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/registermenucontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RegisterMenuControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.mainPane = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.Configuration = ((PosControls.ConfigurationManager)(target));
            return;
            case 3:
            this.buttonStartRegister = ((PosControls.PushButton)(target));
            
            #line 20 "..\..\..\RegisterMenuControl.xaml"
            this.buttonStartRegister.Selected += new System.EventHandler(this.buttonStartRegister_Selected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonNoSale = ((PosControls.PushButton)(target));
            
            #line 21 "..\..\..\RegisterMenuControl.xaml"
            this.buttonNoSale.Selected += new System.EventHandler(this.buttonNoSale_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonDeposit = ((PosControls.PushButton)(target));
            
            #line 22 "..\..\..\RegisterMenuControl.xaml"
            this.buttonDeposit.Selected += new System.EventHandler(this.buttonDeposit_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonDrop = ((PosControls.PushButton)(target));
            
            #line 23 "..\..\..\RegisterMenuControl.xaml"
            this.buttonDrop.Selected += new System.EventHandler(this.buttonDrop_Selected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonPayout = ((PosControls.PushButton)(target));
            
            #line 24 "..\..\..\RegisterMenuControl.xaml"
            this.buttonPayout.Selected += new System.EventHandler(this.buttonPayout_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonReport = ((PosControls.PushButton)(target));
            
            #line 25 "..\..\..\RegisterMenuControl.xaml"
            this.buttonReport.Selected += new System.EventHandler(this.buttonReport_Selected);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonCloseOut = ((PosControls.PushButton)(target));
            
            #line 26 "..\..\..\RegisterMenuControl.xaml"
            this.buttonCloseOut.Selected += new System.EventHandler(this.buttonCloseOut_Selected);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

