// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrKeyboardTrackingQueryFlagsFB")]
    public enum KeyboardTrackingQueryFlagsFB : long
    {
        [NativeName("Name", "XR_KEYBOARD_TRACKING_QUERY_LOCAL_BIT_FB")]
        KeyboardTrackingQueryLocalBitFB = 2,
        [NativeName("Name", "XR_KEYBOARD_TRACKING_QUERY_REMOTE_BIT_FB")]
        KeyboardTrackingQueryRemoteBitFB = 4,
    }
}
