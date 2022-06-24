// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrKeyboardTrackingFlagsFB")]
    public enum KeyboardTrackingFlagsFB : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ExistsBitFB\"")]
        [NativeName("Name", "XR_KEYBOARD_TRACKING_EXISTS_BIT_FB")]
        KeyboardTrackingExistsBitFB = 1,
        [Obsolete("Deprecated in favour of \"LocalBitFB\"")]
        [NativeName("Name", "XR_KEYBOARD_TRACKING_LOCAL_BIT_FB")]
        KeyboardTrackingLocalBitFB = 2,
        [Obsolete("Deprecated in favour of \"RemoteBitFB\"")]
        [NativeName("Name", "XR_KEYBOARD_TRACKING_REMOTE_BIT_FB")]
        KeyboardTrackingRemoteBitFB = 4,
        [Obsolete("Deprecated in favour of \"ConnectedBitFB\"")]
        [NativeName("Name", "XR_KEYBOARD_TRACKING_CONNECTED_BIT_FB")]
        KeyboardTrackingConnectedBitFB = 8,
        [NativeName("Name", "XR_KEYBOARD_TRACKING_EXISTS_BIT_FB")]
        ExistsBitFB = 1,
        [NativeName("Name", "XR_KEYBOARD_TRACKING_LOCAL_BIT_FB")]
        LocalBitFB = 2,
        [NativeName("Name", "XR_KEYBOARD_TRACKING_REMOTE_BIT_FB")]
        RemoteBitFB = 4,
        [NativeName("Name", "XR_KEYBOARD_TRACKING_CONNECTED_BIT_FB")]
        ConnectedBitFB = 8,
    }
}
