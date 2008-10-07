//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1378
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.ServiceFactory.Description.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.ServiceFactory.Description.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Invalid URI: The URI scheme is not valid. Valid scheme is: xsd.
        /// </summary>
        internal static string BadXmlSchemaElementMonikerSchema {
            get {
                return ResourceManager.GetString("BadXmlSchemaElementMonikerSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The behavior {0} was not found..
        /// </summary>
        internal static string BehaviorNotFoundException {
            get {
                return ResourceManager.GetString("BehaviorNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The binding {0} was not found..
        /// </summary>
        internal static string BindingNotFoundException {
            get {
                return ResourceManager.GetString("BindingNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WCF Configuration section not found..
        /// </summary>
        internal static string ConfigurationSectionNotFoundException {
            get {
                return ResourceManager.GetString("ConfigurationSectionNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The custom policy importer was not found. Select the location of the missing file described below:
        ///{0}.
        /// </summary>
        internal static string CustomImporterNotFoundException {
            get {
                return ResourceManager.GetString("CustomImporterNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error reading the metadata from one of the loaded documents..
        /// </summary>
        internal static string ErrUnableToLoadMetadataDocument {
            get {
                return ResourceManager.GetString("ErrUnableToLoadMetadataDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error loading a Referenced Type {0}..
        /// </summary>
        internal static string ErrUnableToLoadReferenceType {
            get {
                return ResourceManager.GetString("ErrUnableToLoadReferenceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument {0} value should reference an existing file..
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one namespace is not allowed for this operation. Call GenerateCodeCompileUnit operation to return more than one namespace..
        /// </summary>
        internal static string MultipleNamespacesError {
            get {
                return ResourceManager.GetString("MultipleNamespacesError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema you are attempting to import is not Data Contract Serializer compatible. You will be able to add it to the model but code generation will use the Xml Serializer. Are you sure you want to import?.
        /// </summary>
        internal static string SchemaImporterChangingEvent {
            get {
                return ResourceManager.GetString("SchemaImporterChangingEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service {0} was not found..
        /// </summary>
        internal static string ServiceNotFoundException {
            get {
                return ResourceManager.GetString("ServiceNotFoundException", resourceCulture);
            }
        }
    }
}
