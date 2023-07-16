// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='DIDEVICEINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3"]/*'/>
public unsafe partial struct DIDEVICEINSTANCE_DX3
{
    /// <include file='DIDEVICEINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIDEVICEINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3.guidInstance"]/*'/>
    public Guid guidInstance;
    /// <include file='DIDEVICEINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3.guidProduct"]/*'/>
    public Guid guidProduct;
    /// <include file='DIDEVICEINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3.dwDevType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDevType;
    /// <include file='DIDEVICEINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3.tszInstanceName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort tszInstanceName[260];
    /// <include file='DIDEVICEINSTANCE_DX3.xml' path='doc/member[@name="DIDEVICEINSTANCE_DX3.tszProductName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort tszProductName[260];
}