﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WordUnscrambler.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WordUnscrambler.Properties.strings", typeof(strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you wish to continue Y/N?.
        /// </summary>
        internal static string ContPrompt {
            get {
                return ResourceManager.GetString("ContPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String is empty.
        /// </summary>
        internal static string Empty {
            get {
                return ResourceManager.GetString("Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter scrambled word(s) manually or as a file: F - file / M - manually.
        /// </summary>
        internal static string FMPrompt {
            get {
                return ResourceManager.GetString("FMPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to scrambled word :  {0}  matched with the word : {1}  .
        /// </summary>
        internal static string Matches {
            get {
                return ResourceManager.GetString("Matches", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no matches.
        /// </summary>
        internal static string NoMatches {
            get {
                return ResourceManager.GetString("NoMatches", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter full path including the file name:.
        /// </summary>
        internal static string PathPrompt {
            get {
                return ResourceManager.GetString("PathPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter scrambled word(s) manually(separated by commas if multiple):.
        /// </summary>
        internal static string ScrambledWordPrompt {
            get {
                return ResourceManager.GetString("ScrambledWordPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The program will be terminated..
        /// </summary>
        internal static string Term {
            get {
                return ResourceManager.GetString("Term", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The entered option was not recognized..
        /// </summary>
        internal static string Unrecognized {
            get {
                return ResourceManager.GetString("Unrecognized", resourceCulture);
            }
        }
    }
}
