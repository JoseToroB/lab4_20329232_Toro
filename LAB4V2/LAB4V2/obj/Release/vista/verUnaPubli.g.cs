﻿#pragma checksum "..\..\..\vista\verUnaPubli.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "94A572D0CF4AC6DD613E7C08CBB7119E7BC893BA17BC209811FE24E3C96C8CB5"
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
    /// verUnaPubli
    /// </summary>
    public partial class verUnaPubli : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\vista\verUnaPubli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Autor;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\vista\verUnaPubli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ID;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\vista\verUnaPubli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock contenido;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\vista\verUnaPubli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock likes;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\vista\verUnaPubli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Volver;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\vista\verUnaPubli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CajaComentarios;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\vista\verUnaPubli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button compartir;
        
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
            System.Uri resourceLocater = new System.Uri("/LAB4V2;component/vista/verunapubli.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\vista\verUnaPubli.xaml"
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
            this.Autor = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.contenido = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.likes = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Volver = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\vista\verUnaPubli.xaml"
            this.Volver.Click += new System.Windows.RoutedEventHandler(this.Volver_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CajaComentarios = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.compartir = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\vista\verUnaPubli.xaml"
            this.compartir.Click += new System.Windows.RoutedEventHandler(this.compartir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

