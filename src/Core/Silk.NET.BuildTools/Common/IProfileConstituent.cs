// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// An interface applied to types that are contained somewhere in a <see cref="Profile"/>.
    /// </summary>
    public interface IProfileConstituent
    {
        /// <summary>
        /// The name of the struct.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// The name of the struct in the native library.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or sets a list of attributes.
        /// </summary>
        List<Attribute> Attributes { get; }
    }
}
