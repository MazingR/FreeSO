﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TSOClient {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class GlobalSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static GlobalSettings defaultInstance = ((GlobalSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new GlobalSettings())));
        
        public static GlobalSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowHints {
            get {
                return ((bool)(this["ShowHints"]));
            }
            set {
                this["ShowHints"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("English")]
        public string CurrentLang {
            get {
                return ((string)(this["CurrentLang"]));
            }
            set {
                this["CurrentLang"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800")]
        public int GraphicsWidth {
            get {
                return ((int)(this["GraphicsWidth"]));
            }
            set {
                this["GraphicsWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("600")]
        public int GraphicsHeight {
            get {
                return ((int)(this["GraphicsHeight"]));
            }
            set {
                this["GraphicsHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string LoginServerIP {
            get {
                return ((string)(this["LoginServerIP"]));
            }
            set {
                this["LoginServerIP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2106")]
        public int LoginServerPort {
            get {
                return ((int)(this["LoginServerPort"]));
            }
            set {
                this["LoginServerPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\Maxis\\The Sims Online\\TSOClient\\")]
        public string StartupPath {
            get {
                return ((string)(this["StartupPath"]));
            }
            set {
                this["StartupPath"] = value;
            }
        }
    }
}
