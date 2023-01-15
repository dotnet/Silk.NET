// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrWindingOrderFB")]
    public enum WindingOrderFB : int
    {
        [Obsolete("Deprecated in favour of \"UnknownFB\"")]
        [NativeName("Name", "XR_WINDING_ORDER_UNKNOWN_FB")]
        WindingOrderUnknownFB = 0,
        [Obsolete("Deprecated in favour of \"CWFB\"")]
        [NativeName("Name", "XR_WINDING_ORDER_CW_FB")]
        WindingOrderCWFB = 1,
        [Obsolete("Deprecated in favour of \"CcwFB\"")]
        [NativeName("Name", "XR_WINDING_ORDER_CCW_FB")]
        WindingOrderCcwFB = 2,
        [NativeName("Name", "XR_WINDING_ORDER_UNKNOWN_FB")]
        UnknownFB = 0,
        [NativeName("Name", "XR_WINDING_ORDER_CW_FB")]
        CWFB = 1,
        [NativeName("Name", "XR_WINDING_ORDER_CCW_FB")]
        CcwFB = 2,
    }
}
