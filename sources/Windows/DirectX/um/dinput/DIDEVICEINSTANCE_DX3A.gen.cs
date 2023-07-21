// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A"]/*' />
public unsafe partial struct DIDEVICEINSTANCE_DX3A
{
    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.guidInstance"]/*' />
    public Guid guidInstance;

    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.guidProduct"]/*' />
    public Guid guidProduct;

    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.dwDevType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDevType;

    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.tszInstanceName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte tszInstanceName[260];

    /// <include file='DIDEVICEINSTANCE_DX3A.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3A.tszProductName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte tszProductName[260];
}
