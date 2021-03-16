// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// A constant from a native library.
    /// </summary>
    public class Constant
    {
        /// <summary>
        /// The type of the constant.
        /// </summary>
        public Type Type { get; set; }
        
        /// <summary>
        /// The name of the constant.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The name of the constant in the native library.
        /// </summary>
        public string NativeName { get; set; }
        
        /// <summary>
        /// The value of the constant.
        /// </summary>
        public string Value { get; set; }
        
        /// <summary>
        /// The extension to which this constant belongs.
        /// </summary>
        public string ExtensionName { get; set; }
    }
}
