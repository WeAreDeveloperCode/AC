﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Views.Main.App_LocalResources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Index_cshtml {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Index_cshtml() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Web.Views.Main.App_LocalResources.Index.cshtml", typeof(Index_cshtml).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Draw 的本地化字符串。
        /// </summary>
        public static string Draw {
            get {
                return ResourceManager.GetString("Draw", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ChemicalAI 的本地化字符串。
        /// </summary>
        public static string IndexPageTitle {
            get {
                return ResourceManager.GetString("IndexPageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 AI Technology Meets Chemistry 的本地化字符串。
        /// </summary>
        public static string IndexTitle_1 {
            get {
                return ResourceManager.GetString("IndexTitle_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Find possible synthesis routes of any molecules 的本地化字符串。
        /// </summary>
        public static string IndexTitle_2 {
            get {
                return ResourceManager.GetString("IndexTitle_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Please input CAS No. or chemical name 的本地化字符串。
        /// </summary>
        public static string InputRemind {
            get {
                return ResourceManager.GetString("InputRemind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Match 的本地化字符串。
        /// </summary>
        public static string Match {
            get {
                return ResourceManager.GetString("Match", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Please input CAS No. or chemical name 的本地化字符串。
        /// </summary>
        public static string MatchNullMsg {
            get {
                return ResourceManager.GetString("MatchNullMsg", resourceCulture);
            }
        }
    }
}