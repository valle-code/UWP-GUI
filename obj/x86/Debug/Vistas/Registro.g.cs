﻿#pragma checksum "C:\Users\formu\source\repos\ProyectoUWPEV1\Vistas\Registro.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C31A866D5F17E3154A9983E3480D83C69467F55C69A0A2798178D6B9EB8E47A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoUWPEV1.Vistas
{
    partial class Registro : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Vistas\Registro.xaml line 56
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element2 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element2).SelectionChanged += this.ComboBox_SelectionChanged;
                }
                break;
            case 3: // Vistas\Registro.xaml line 15
                {
                    this.btnPerfil = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPerfil).Click += this.btnPerfil_Click;
                }
                break;
            case 4: // Vistas\Registro.xaml line 23
                {
                    this.txtNombre = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtNombre).TextChanged += this.TextBox_TextChanged;
                }
                break;
            case 5: // Vistas\Registro.xaml line 26
                {
                    this.txtNombre_Copy = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtNombre_Copy).TextChanged += this.TextBox_TextChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
