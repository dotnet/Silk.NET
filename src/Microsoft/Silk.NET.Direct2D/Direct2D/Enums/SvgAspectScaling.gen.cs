// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SVG_ASPECT_SCALING")]
    public enum SvgAspectScaling : int
    {
        [NativeName("Name", "D2D1_SVG_ASPECT_SCALING_MEET")]
        Meet = 0x0,
        [NativeName("Name", "D2D1_SVG_ASPECT_SCALING_SLICE")]
        Slice = 0x1,
        [NativeName("Name", "D2D1_SVG_ASPECT_SCALING_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
