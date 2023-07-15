// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE"]/*'/>
public unsafe partial struct DIDEVICEINSTANCE
{
    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.guidInstance"]/*'/>
    public Guid guidInstance;
    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.guidProduct"]/*'/>
    public Guid guidProduct;
    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.dwDevType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDevType;
    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.tszInstanceName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort tszInstanceName[260];
    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.tszProductName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort tszProductName[260];
    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.guidFFDriver"]/*'/>
    public Guid guidFFDriver;
    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.wUsagePage"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wUsagePage;
    /// <include file='DIDEVICEINSTANCE.xml' path='doc/member[@name="DIDEVICEINSTANCE.wUsage"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wUsage;
}