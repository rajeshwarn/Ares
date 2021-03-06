﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ares.Common.Position {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ares.Common.Position.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to {0}°.
        /// </summary>
        internal static string AngleDegrees {
            get {
                return ResourceManager.GetString("AngleDegrees", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}&apos;.
        /// </summary>
        internal static string AngleMinutes {
            get {
                return ResourceManager.GetString("AngleMinutes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}&quot;.
        /// </summary>
        internal static string AngleSeconds {
            get {
                return ResourceManager.GetString("AngleSeconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only values of North and South are allowed.
        /// </summary>
        internal static string LatitudeInvalidHemisphere {
            get {
                return ResourceManager.GetString("LatitudeInvalidHemisphere", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to N.
        /// </summary>
        internal static string LatitudeNorth {
            get {
                return ResourceManager.GetString("LatitudeNorth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid latitude, latitudes with a specified hemisphere must have a value between 0° and 90°.
        /// </summary>
        internal static string LatitudeOutOfRange {
            get {
                return ResourceManager.GetString("LatitudeOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid latitude, latitudes without a specified hemisphere must have a value between -90° and 90°.
        /// </summary>
        internal static string LatitudeOutOfRangeNoHemisphere {
            get {
                return ResourceManager.GetString("LatitudeOutOfRangeNoHemisphere", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to S.
        /// </summary>
        internal static string LatitudeSouth {
            get {
                return ResourceManager.GetString("LatitudeSouth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}{1}.
        /// </summary>
        internal static string LatitudeToString {
            get {
                return ResourceManager.GetString("LatitudeToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E.
        /// </summary>
        internal static string LongitudeEast {
            get {
                return ResourceManager.GetString("LongitudeEast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only values of East and West are allowed.
        /// </summary>
        internal static string LongitudeInvalidHemisphere {
            get {
                return ResourceManager.GetString("LongitudeInvalidHemisphere", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid longitude, longitudes with a specified hemisphere must have a value between 0° and 180°.
        /// </summary>
        internal static string LongitudeOutOfRange {
            get {
                return ResourceManager.GetString("LongitudeOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid longitude, longitudes without a specified hemisphere must have a value between -180° and 180°.
        /// </summary>
        internal static string LongitudeOutOfRangeNoHemisphere {
            get {
                return ResourceManager.GetString("LongitudeOutOfRangeNoHemisphere", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}{1}.
        /// </summary>
        internal static string LongitudeToString {
            get {
                return ResourceManager.GetString("LongitudeToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to W.
        /// </summary>
        internal static string LongitudeWest {
            get {
                return ResourceManager.GetString("LongitudeWest", resourceCulture);
            }
        }
    }
}
