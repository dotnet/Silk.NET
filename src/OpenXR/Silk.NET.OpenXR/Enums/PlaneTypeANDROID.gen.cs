// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPlaneTypeANDROID")]
    public enum PlaneTypeANDROID : int
    {
        [Obsolete("Deprecated in favour of \"HorizontalDownwardFacingAndroid\"")]
        [NativeName("Name", "XR_PLANE_TYPE_HORIZONTAL_DOWNWARD_FACING_ANDROID")]
        PlaneTypeHorizontalDownwardFacingAndroid = 0,
        [Obsolete("Deprecated in favour of \"HorizontalUpwardFacingAndroid\"")]
        [NativeName("Name", "XR_PLANE_TYPE_HORIZONTAL_UPWARD_FACING_ANDROID")]
        PlaneTypeHorizontalUpwardFacingAndroid = 1,
        [Obsolete("Deprecated in favour of \"VerticalAndroid\"")]
        [NativeName("Name", "XR_PLANE_TYPE_VERTICAL_ANDROID")]
        PlaneTypeVerticalAndroid = 2,
        [Obsolete("Deprecated in favour of \"ArbitraryAndroid\"")]
        [NativeName("Name", "XR_PLANE_TYPE_ARBITRARY_ANDROID")]
        PlaneTypeArbitraryAndroid = 3,
        [NativeName("Name", "XR_PLANE_TYPE_HORIZONTAL_DOWNWARD_FACING_ANDROID")]
        HorizontalDownwardFacingAndroid = 0,
        [NativeName("Name", "XR_PLANE_TYPE_HORIZONTAL_UPWARD_FACING_ANDROID")]
        HorizontalUpwardFacingAndroid = 1,
        [NativeName("Name", "XR_PLANE_TYPE_VERTICAL_ANDROID")]
        VerticalAndroid = 2,
        [NativeName("Name", "XR_PLANE_TYPE_ARBITRARY_ANDROID")]
        ArbitraryAndroid = 3,
    }
}
