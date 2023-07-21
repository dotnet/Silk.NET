// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='POWERBROADCAST_SETTING.xml' path='doc/member[@name="POWERBROADCAST_SETTING"]/*' />
public unsafe partial struct POWERBROADCAST_SETTING
{
    /// <include file='POWERBROADCAST_SETTING.xml' path='doc/member[@name="POWERBROADCAST_SETTING.PowerSetting"]/*' />
    public Guid PowerSetting;

    /// <include file='POWERBROADCAST_SETTING.xml' path='doc/member[@name="POWERBROADCAST_SETTING.DataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataLength;

    /// <include file='POWERBROADCAST_SETTING.xml' path='doc/member[@name="POWERBROADCAST_SETTING.Data"]/*' />
    [NativeTypeName("UCHAR[1]")]
    public fixed byte Data[1];
}
