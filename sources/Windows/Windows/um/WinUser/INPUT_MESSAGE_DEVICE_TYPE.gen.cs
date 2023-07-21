// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='INPUT_MESSAGE_DEVICE_TYPE.xml' path='doc/member[@name="INPUT_MESSAGE_DEVICE_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum INPUT_MESSAGE_DEVICE_TYPE
{
    /// <include file='INPUT_MESSAGE_DEVICE_TYPE.xml' path='doc/member[@name="INPUT_MESSAGE_DEVICE_TYPE.IMDT_UNAVAILABLE"]/*' />
    IMDT_UNAVAILABLE = 0x00000000,

    /// <include file='INPUT_MESSAGE_DEVICE_TYPE.xml' path='doc/member[@name="INPUT_MESSAGE_DEVICE_TYPE.IMDT_KEYBOARD"]/*' />
    IMDT_KEYBOARD = 0x00000001,

    /// <include file='INPUT_MESSAGE_DEVICE_TYPE.xml' path='doc/member[@name="INPUT_MESSAGE_DEVICE_TYPE.IMDT_MOUSE"]/*' />
    IMDT_MOUSE = 0x00000002,

    /// <include file='INPUT_MESSAGE_DEVICE_TYPE.xml' path='doc/member[@name="INPUT_MESSAGE_DEVICE_TYPE.IMDT_TOUCH"]/*' />
    IMDT_TOUCH = 0x00000004,

    /// <include file='INPUT_MESSAGE_DEVICE_TYPE.xml' path='doc/member[@name="INPUT_MESSAGE_DEVICE_TYPE.IMDT_PEN"]/*' />
    IMDT_PEN = 0x00000008,

    /// <include file='INPUT_MESSAGE_DEVICE_TYPE.xml' path='doc/member[@name="INPUT_MESSAGE_DEVICE_TYPE.IMDT_TOUCHPAD"]/*' />
    IMDT_TOUCHPAD = 0x00000010,
}
