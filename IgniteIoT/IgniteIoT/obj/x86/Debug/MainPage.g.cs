﻿#pragma checksum "C:\Users\Kartik\Documents\Visual Studio 2015\Projects\IgniteIoT\IgniteIoT\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "244C4BDCCE205C4292A93466E184C482"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IgniteIoT
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.CamPreview = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            case 2:
                {
                    this.VisualizationCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 3:
                {
                    this.imagePreview = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4:
                {
                    this.StatusPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.StatusLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.StatusBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 7:
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.CameraStreamingButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CameraStreamingButton).Click += this.CameraStreamingButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

