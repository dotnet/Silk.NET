// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA"]/*' />
public unsafe partial struct DISPLAY_DEVICEA
{
    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.cb"]/*' />
    [NativeTypeName("DWORD")]
    public uint cb;

    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceName"]/*' />
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte DeviceName[32];

    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceString"]/*' />
    [NativeTypeName("CHAR[128]")]
    public fixed sbyte DeviceString[128];

    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.StateFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint StateFlags;

    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceID"]/*' />
    [NativeTypeName("CHAR[128]")]
    public fixed sbyte DeviceID[128];

    /// <include file='DISPLAY_DEVICEA.xml' path='doc/member[@name="DISPLAY_DEVICEA.DeviceKey"]/*' />
    [NativeTypeName("CHAR[128]")]
    public fixed sbyte DeviceKey[128];
}
