﻿#pragma checksum "..\..\..\Converter.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F887C87D8F704747A79692C8344F8AB03DFA00E"
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
using n7_ConvertorAndElectricity;


namespace n7_ConvertorAndElectricity {
    
    
    /// <summary>
    /// Converter
    /// </summary>
    public partial class Converter : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrice;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPrice;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRate;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRate;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRecalc;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDescription;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAnswerField;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAnswer;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Converter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/n7_ConvertorAndElectricity;component/converter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Converter.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\Converter.xaml"
            ((n7_ConvertorAndElectricity.Converter)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\Converter.xaml"
            this.txtPrice.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txtPrice_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\Converter.xaml"
            this.txtPrice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtPrice_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblRate = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtRate = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\Converter.xaml"
            this.txtRate.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txtRate_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\Converter.xaml"
            this.txtRate.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtRate_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRecalc = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Converter.xaml"
            this.btnRecalc.Click += new System.Windows.RoutedEventHandler(this.btnRecalc_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblDescription = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblAnswerField = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblAnswer = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btnQuit = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\Converter.xaml"
            this.btnQuit.Click += new System.Windows.RoutedEventHandler(this.btnQuit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
