// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    [Flags]
    [NativeName("Name", "DCOMPOSITION_OPACITY_MODE")]
    public enum OpacityMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Layer\"")]
        [NativeName("Name", "DCOMPOSITION_OPACITY_MODE_LAYER")]
        OpacityModeLayer = 0x0,
        [Obsolete("Deprecated in favour of \"Multiply\"")]
        [NativeName("Name", "DCOMPOSITION_OPACITY_MODE_MULTIPLY")]
        OpacityModeMultiply = 0x1,
        [Obsolete("Deprecated in favour of \"Inherit\"")]
        [NativeName("Name", "DCOMPOSITION_OPACITY_MODE_INHERIT")]
        OpacityModeInherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DCOMPOSITION_OPACITY_MODE_LAYER")]
        Layer = 0x0,
        [NativeName("Name", "DCOMPOSITION_OPACITY_MODE_MULTIPLY")]
        Multiply = 0x1,
        [NativeName("Name", "DCOMPOSITION_OPACITY_MODE_INHERIT")]
        Inherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
