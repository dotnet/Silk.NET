// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='POINTER_DEVICE_CURSOR_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_CURSOR_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum POINTER_DEVICE_CURSOR_TYPE
{
    /// <include file='POINTER_DEVICE_CURSOR_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_CURSOR_TYPE.POINTER_DEVICE_CURSOR_TYPE_UNKNOWN"]/*' />
    POINTER_DEVICE_CURSOR_TYPE_UNKNOWN = 0x00000000,

    /// <include file='POINTER_DEVICE_CURSOR_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_CURSOR_TYPE.POINTER_DEVICE_CURSOR_TYPE_TIP"]/*' />
    POINTER_DEVICE_CURSOR_TYPE_TIP = 0x00000001,

    /// <include file='POINTER_DEVICE_CURSOR_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_CURSOR_TYPE.POINTER_DEVICE_CURSOR_TYPE_ERASER"]/*' />
    POINTER_DEVICE_CURSOR_TYPE_ERASER = 0x00000002,

    /// <include file='POINTER_DEVICE_CURSOR_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_CURSOR_TYPE.POINTER_DEVICE_CURSOR_TYPE_MAX"]/*' />
    POINTER_DEVICE_CURSOR_TYPE_MAX = unchecked((int)(0xFFFFFFFF)),
}
