// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_FILTER")]
    public enum Filter : int
    {
        [Obsolete("Deprecated in favour of \"MinMagMipPoint\"")]
        [NativeName("Name", "D2D1_FILTER_MIN_MAG_MIP_POINT")]
        FilterMinMagMipPoint = 0x0,
        [Obsolete("Deprecated in favour of \"MinMagPointMipLinear\"")]
        [NativeName("Name", "D2D1_FILTER_MIN_MAG_POINT_MIP_LINEAR")]
        FilterMinMagPointMipLinear = 0x1,
        [Obsolete("Deprecated in favour of \"MinPointMagLinearMipPoint\"")]
        [NativeName("Name", "D2D1_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        FilterMinPointMagLinearMipPoint = 0x4,
        [Obsolete("Deprecated in favour of \"MinPointMagMipLinear\"")]
        [NativeName("Name", "D2D1_FILTER_MIN_POINT_MAG_MIP_LINEAR")]
        FilterMinPointMagMipLinear = 0x5,
        [Obsolete("Deprecated in favour of \"MinLinearMagMipPoint\"")]
        [NativeName("Name", "D2D1_FILTER_MIN_LINEAR_MAG_MIP_POINT")]
        FilterMinLinearMagMipPoint = 0x10,
        [Obsolete("Deprecated in favour of \"MinLinearMagPointMipLinear\"")]
        [NativeName("Name", "D2D1_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        FilterMinLinearMagPointMipLinear = 0x11,
        [Obsolete("Deprecated in favour of \"MinMagLinearMipPoint\"")]
        [NativeName("Name", "D2D1_FILTER_MIN_MAG_LINEAR_MIP_POINT")]
        FilterMinMagLinearMipPoint = 0x14,
        [Obsolete("Deprecated in favour of \"MinMagMipLinear\"")]
        [NativeName("Name", "D2D1_FILTER_MIN_MAG_MIP_LINEAR")]
        FilterMinMagMipLinear = 0x15,
        [Obsolete("Deprecated in favour of \"Anisotropic\"")]
        [NativeName("Name", "D2D1_FILTER_ANISOTROPIC")]
        FilterAnisotropic = 0x55,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_FILTER_FORCE_DWORD")]
        FilterForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_FILTER_MIN_MAG_MIP_POINT")]
        MinMagMipPoint = 0x0,
        [NativeName("Name", "D2D1_FILTER_MIN_MAG_POINT_MIP_LINEAR")]
        MinMagPointMipLinear = 0x1,
        [NativeName("Name", "D2D1_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT")]
        MinPointMagLinearMipPoint = 0x4,
        [NativeName("Name", "D2D1_FILTER_MIN_POINT_MAG_MIP_LINEAR")]
        MinPointMagMipLinear = 0x5,
        [NativeName("Name", "D2D1_FILTER_MIN_LINEAR_MAG_MIP_POINT")]
        MinLinearMagMipPoint = 0x10,
        [NativeName("Name", "D2D1_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR")]
        MinLinearMagPointMipLinear = 0x11,
        [NativeName("Name", "D2D1_FILTER_MIN_MAG_LINEAR_MIP_POINT")]
        MinMagLinearMipPoint = 0x14,
        [NativeName("Name", "D2D1_FILTER_MIN_MAG_MIP_LINEAR")]
        MinMagMipLinear = 0x15,
        [NativeName("Name", "D2D1_FILTER_ANISOTROPIC")]
        Anisotropic = 0x55,
        [NativeName("Name", "D2D1_FILTER_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
