// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    [NativeName("Name", "DCOMPOSITION_DEPTH_MODE")]
    public enum DepthMode : int
    {
        [Obsolete("Deprecated in favour of \"Tree\"")]
        [NativeName("Name", "DCOMPOSITION_DEPTH_MODE_TREE")]
        DepthModeTree = 0x0,
        [Obsolete("Deprecated in favour of \"Spatial\"")]
        [NativeName("Name", "DCOMPOSITION_DEPTH_MODE_SPATIAL")]
        DepthModeSpatial = 0x1,
        [Obsolete("Deprecated in favour of \"Sorted\"")]
        [NativeName("Name", "DCOMPOSITION_DEPTH_MODE_SORTED")]
        DepthModeSorted = 0x3,
        [Obsolete("Deprecated in favour of \"Inherit\"")]
        [NativeName("Name", "DCOMPOSITION_DEPTH_MODE_INHERIT")]
        DepthModeInherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DCOMPOSITION_DEPTH_MODE_TREE")]
        Tree = 0x0,
        [NativeName("Name", "DCOMPOSITION_DEPTH_MODE_SPATIAL")]
        Spatial = 0x1,
        [NativeName("Name", "DCOMPOSITION_DEPTH_MODE_SORTED")]
        Sorted = 0x3,
        [NativeName("Name", "DCOMPOSITION_DEPTH_MODE_INHERIT")]
        Inherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
