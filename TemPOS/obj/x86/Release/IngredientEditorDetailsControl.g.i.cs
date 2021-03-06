﻿#pragma checksum "..\..\..\IngredientEditorDetailsControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "97BC0BF02B312B1275E5793DFF01D764"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
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
    /// IngredientEditorDetailsControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class IngredientEditorDetailsControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\IngredientEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainPane;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\IngredientEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.ConfigurationManager Configuration;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\IngredientEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCostPerUnit;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\IngredientEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxFullName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\IngredientEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxShortName;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\IngredientEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxInventoryAmount;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\IngredientEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonIncreaseInventory;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\IngredientEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.TextBlockButton buttonDecreaseInventory;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\IngredientEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.PushComboBox comboBoxMeasuringUnits;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\IngredientEditorDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PosControls.CustomTextBox textBoxCostPerUnit;
        
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
            System.Uri resourceLocater = new System.Uri("/PointOfSale;component/ingredienteditordetailscontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\IngredientEditorDetailsControl.xaml"
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
            this.labelCostPerUnit = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.textBoxFullName = ((PosControls.CustomTextBox)(target));
            
            #line 32 "..\..\..\IngredientEditorDetailsControl.xaml"
            this.textBoxFullName.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxFullName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBoxShortName = ((PosControls.CustomTextBox)(target));
            
            #line 33 "..\..\..\IngredientEditorDetailsControl.xaml"
            this.textBoxShortName.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxShortName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.textBoxInventoryAmount = ((PosControls.CustomTextBox)(target));
            
            #line 35 "..\..\..\IngredientEditorDetailsControl.xaml"
            this.textBoxInventoryAmount.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxInventoryAmount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonIncreaseInventory = ((PosControls.TextBlockButton)(target));
            
            #line 36 "..\..\..\IngredientEditorDetailsControl.xaml"
            this.buttonIncreaseInventory.Click += new System.Windows.RoutedEventHandler(this.buttonIncreaseInventory_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonDecreaseInventory = ((PosControls.TextBlockButton)(target));
            
            #line 37 "..\..\..\IngredientEditorDetailsControl.xaml"
            this.buttonDecreaseInventory.Click += new System.Windows.RoutedEventHandler(this.buttonDecreaseInventory_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.comboBoxMeasuringUnits = ((PosControls.PushComboBox)(target));
            
            #line 39 "..\..\..\IngredientEditorDetailsControl.xaml"
            this.comboBoxMeasuringUnits.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeasuringUnits_SelectedIndexChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.textBoxCostPerUnit = ((PosControls.CustomTextBox)(target));
            
            #line 40 "..\..\..\IngredientEditorDetailsControl.xaml"
            this.textBoxCostPerUnit.TextChanged += new System.Windows.RoutedEventHandler(this.textBoxCostPerUnit_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

