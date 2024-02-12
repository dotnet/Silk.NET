// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrVirtualKeyboardLocationTypeMETA")]
    public enum VirtualKeyboardLocationTypeMETA : int
    {
        [Obsolete("Deprecated in favour of \"CustomMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_LOCATION_TYPE_CUSTOM_META")]
        VirtualKeyboardLocationTypeCustomMeta = 0,
        [Obsolete("Deprecated in favour of \"FarMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_LOCATION_TYPE_FAR_META")]
        VirtualKeyboardLocationTypeFarMeta = 1,
        [Obsolete("Deprecated in favour of \"DirectMeta\"")]
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_LOCATION_TYPE_DIRECT_META")]
        VirtualKeyboardLocationTypeDirectMeta = 2,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_LOCATION_TYPE_CUSTOM_META")]
        CustomMeta = 0,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_LOCATION_TYPE_FAR_META")]
        FarMeta = 1,
        [NativeName("Name", "XR_VIRTUAL_KEYBOARD_LOCATION_TYPE_DIRECT_META")]
        DirectMeta = 2,
    }
}
