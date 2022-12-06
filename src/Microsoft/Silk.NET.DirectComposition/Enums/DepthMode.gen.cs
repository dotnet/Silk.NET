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
