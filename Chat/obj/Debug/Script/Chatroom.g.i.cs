﻿#pragma checksum "..\..\..\Script\Chatroom.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF228362C3E35943303CB238317687E27FA149BB1F04DDFBE8662B4F675D8F5B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Chat.Script;
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


namespace Chat.Script {
    
    
    /// <summary>
    /// Chatroom
    /// </summary>
    public partial class Chatroom : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Script\Chatroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGUsers;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Script\Chatroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddUser;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Script\Chatroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BChangeTopic;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Script\Chatroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BLeaveChartroom;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Script\Chatroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGMessage;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Script\Chatroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSendMessage;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Script\Chatroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ISendPhoto;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Script\Chatroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSend;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Script\Chatroom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddImage;
        
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
            System.Uri resourceLocater = new System.Uri("/Chat;component/script/chatroom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Script\Chatroom.xaml"
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
            
            #line 10 "..\..\..\Script\Chatroom.xaml"
            ((Chat.Script.Chatroom)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DGUsers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.BAddUser = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Script\Chatroom.xaml"
            this.BAddUser.Click += new System.Windows.RoutedEventHandler(this.BAddUser_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BChangeTopic = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Script\Chatroom.xaml"
            this.BChangeTopic.Click += new System.Windows.RoutedEventHandler(this.BChangeTopic_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BLeaveChartroom = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Script\Chatroom.xaml"
            this.BLeaveChartroom.Click += new System.Windows.RoutedEventHandler(this.BLeaveChartroom_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DGMessage = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.TBSendMessage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ISendPhoto = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.BSend = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\Script\Chatroom.xaml"
            this.BSend.Click += new System.Windows.RoutedEventHandler(this.BSend_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BAddImage = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Script\Chatroom.xaml"
            this.BAddImage.Click += new System.Windows.RoutedEventHandler(this.BAddImage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

