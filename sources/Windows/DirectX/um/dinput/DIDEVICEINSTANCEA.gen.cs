// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA"]/*' />
public unsafe partial struct DIDEVICEINSTANCEA
{
    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.guidInstance"]/*' />
    public Guid guidInstance;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.guidProduct"]/*' />
    public Guid guidProduct;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.dwDevType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDevType;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.tszInstanceName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte tszInstanceName[260];

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.tszProductName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte tszProductName[260];

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.guidFFDriver"]/*' />
    public Guid guidFFDriver;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.wUsagePage"]/*' />
    [NativeTypeName("WORD")]
    public ushort wUsagePage;

    /// <include file='DIDEVICEINSTANCEA.xml' path='doc/member[@name="DIDEVICEINSTANCEA.wUsage"]/*' />
    [NativeTypeName("WORD")]
    public ushort wUsage;
}
