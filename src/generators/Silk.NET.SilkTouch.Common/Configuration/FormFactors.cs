// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.SilkTouch.Configuration
{
    /// <summary>
    /// A bitmask enum containing the different kind of "form factors" that SilkTouch supports. That is, the different
    /// ways you can invoke SilkTouch.
    /// </summary>
    [Flags]
    public enum FormFactors
    {
        /// <summary>
        /// Represents an empty bitmask.
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Represents SilkTouch running in a Roslyn Source Generator (the "Roslyn" form factor)
        /// </summary>
        Roslyn = 1 << 0,
        
        /// <summary>
        /// Represents SilkTouch running via a standalone command line interface (the "CLI" form factor)
        /// </summary>
        CLI = 1 << 1
     }
}
