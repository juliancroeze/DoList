﻿#pragma checksum "C:\Users\Julian\source\repos\ToDoApp\ToDoApp\Views\ToDoPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "40164B4AA2D8DA7EADDD8D4B27E1500B45DFF2840B0F343B61624D286014A8C3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoApp.Views
{
    partial class ToDoPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\ToDoPage.xaml line 54
                {
                    this.taskList = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                }
                break;
            case 4: // Views\ToDoPage.xaml line 60
                {
                    global::Microsoft.UI.Xaml.Controls.CheckBox element4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CheckBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.CheckBox)element4).Click += this.CheckBox_Ticked;
                }
                break;
            case 5: // Views\ToDoPage.xaml line 37
                {
                    this.taskInput = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 6: // Views\ToDoPage.xaml line 38
                {
                    global::Microsoft.UI.Xaml.Controls.Button element6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element6).Click += this.AddTask_Click;
                }
                break;
            case 7: // Views\ToDoPage.xaml line 39
                {
                    this.priorityMenu = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.DropDownButton>(target);
                }
                break;
            case 8: // Views\ToDoPage.xaml line 42
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element8).Click += this.MenuItem_Click;
                }
                break;
            case 9: // Views\ToDoPage.xaml line 43
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element9).Click += this.MenuItem_Click;
                }
                break;
            case 10: // Views\ToDoPage.xaml line 44
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element10).Click += this.MenuItem_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

