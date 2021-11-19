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
        [NativeName("Name", "XR_WINDING_ORDER_UNKNOWN_FB")]
        WindingOrderUnknownFB = 0,
        [NativeName("Name", "XR_WINDING_ORDER_CW_FB")]
        WindingOrderCWFB = 1,
        [NativeName("Name", "XR_WINDING_ORDER_CCW_FB")]
        WindingOrderCcwFB = 2,
    }
}
