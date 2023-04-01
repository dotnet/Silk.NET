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
