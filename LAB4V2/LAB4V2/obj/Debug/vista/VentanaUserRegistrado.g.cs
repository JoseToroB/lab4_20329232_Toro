﻿#pragma checksum "..\..\..\vista\VentanaUserRegistrado.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F17DC0C0CC3E2DFF67A692F9DB26B4629B6ECAF0C0752B9B2174519985A6B131"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using LAB4V2.vista;
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


namespace LAB4V2.vista {
    
    
    /// <summary>
    /// VentanaUserRegistrado
    /// </summary>
    public partial class VentanaUserRegistrado : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\vista\VentanaUserRegistrado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nombrePibeOnline;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\vista\VentanaUserRegistrado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fechaHoy;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\vista\VentanaUserRegistrado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Publicar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\vista\VentanaUserRegistrado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button seguirUser;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\vista\VentanaUserRegistrado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button comentar;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\vista\VentanaUserRegistrado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\vista\VentanaUserRegistrado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button verPublisUser;
        
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
            System.Uri resourceLocater = new System.Uri("/LAB4V2;component/vista/ventanauserregistrado.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\vista\VentanaUserRegistrado.xaml"
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
            this.nombrePibeOnline = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.fechaHoy = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Publicar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\vista\VentanaUserRegistrado.xaml"
            this.Publicar.Click += new System.Windows.RoutedEventHandler(this.Publicar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.seguirUser = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\vista\VentanaUserRegistrado.xaml"
            this.seguirUser.Click += new System.Windows.RoutedEventHandler(this.seguirUser_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.comentar = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\vista\VentanaUserRegistrado.xaml"
            this.comentar.Click += new System.Windows.RoutedEventHandler(this.comentar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.logout = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\vista\VentanaUserRegistrado.xaml"
            this.logout.Click += new System.Windows.RoutedEventHandler(this.logout_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.verPublisUser = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\vista\VentanaUserRegistrado.xaml"
            this.verPublisUser.Click += new System.Windows.RoutedEventHandler(this.verPublisUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

