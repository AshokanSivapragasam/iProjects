﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Net35Projects {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class AppConstants : global::System.Configuration.ApplicationSettingsBase {
        
        private static AppConstants defaultInstance = ((AppConstants)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AppConstants())));
        
        public static AppConstants Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Net35Projects")]
        public string GlobalNameOfApplication {
            get {
                return ((string)(this["GlobalNameOfApplication"]));
            }
            set {
                this["GlobalNameOfApplication"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public string GlobalMaxRetryAttempts {
            get {
                return ((string)(this["GlobalMaxRetryAttempts"]));
            }
            set {
                this["GlobalMaxRetryAttempts"] = value;
            }
        }
    }
}
