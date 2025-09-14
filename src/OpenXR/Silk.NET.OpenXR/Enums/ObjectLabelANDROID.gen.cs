// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrObjectLabelANDROID")]
    public enum ObjectLabelANDROID : int
    {
        [Obsolete("Deprecated in favour of \"UnknownAndroid\"")]
        [NativeName("Name", "XR_OBJECT_LABEL_UNKNOWN_ANDROID")]
        ObjectLabelUnknownAndroid = 0,
        [Obsolete("Deprecated in favour of \"KeyboardAndroid\"")]
        [NativeName("Name", "XR_OBJECT_LABEL_KEYBOARD_ANDROID")]
        ObjectLabelKeyboardAndroid = 1,
        [Obsolete("Deprecated in favour of \"MouseAndroid\"")]
        [NativeName("Name", "XR_OBJECT_LABEL_MOUSE_ANDROID")]
        ObjectLabelMouseAndroid = 2,
        [Obsolete("Deprecated in favour of \"LaptopAndroid\"")]
        [NativeName("Name", "XR_OBJECT_LABEL_LAPTOP_ANDROID")]
        ObjectLabelLaptopAndroid = 3,
        [NativeName("Name", "XR_OBJECT_LABEL_UNKNOWN_ANDROID")]
        UnknownAndroid = 0,
        [NativeName("Name", "XR_OBJECT_LABEL_KEYBOARD_ANDROID")]
        KeyboardAndroid = 1,
        [NativeName("Name", "XR_OBJECT_LABEL_MOUSE_ANDROID")]
        MouseAndroid = 2,
        [NativeName("Name", "XR_OBJECT_LABEL_LAPTOP_ANDROID")]
        LaptopAndroid = 3,
    }
}
