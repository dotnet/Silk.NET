// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Silk.NET.BuildTools.Common
{
    public class Class
    {
        /// <summary>
        /// Gets or sets this profile's constants.
        /// </summary>
        
        public List<Constant> Constants { get; set; } = new List<Constant>();
        /// <summary>
        /// Gets or sets the name of the mixed-mode class.
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets a dictionary where the category names are the keys, and <see cref="NativeApiSet" />s
        /// are the values.
        /// </summary>
        public Dictionary<string, NativeApiSet> NativeApis { get; set; } = new Dictionary<string, NativeApiSet>();
        
        public List<ImplementedFunction> Functions { get; set; } = new List<ImplementedFunction>();
    }
}
