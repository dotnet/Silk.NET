// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2"]/*'/>
public unsafe partial struct DDDEVICEIDENTIFIER2
{
    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.szDriver"]/*'/>
    [NativeTypeName("char[512]")]
    public fixed sbyte szDriver[512];
    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.szDescription"]/*'/>
    [NativeTypeName("char[512]")]
    public fixed sbyte szDescription[512];
    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.liDriverVersion"]/*'/>
    public LARGE_INTEGER liDriverVersion;
    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.dwVendorId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVendorId;
    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.dwDeviceId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDeviceId;
    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.dwSubSysId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSubSysId;
    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.dwRevision"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRevision;
    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.guidDeviceIdentifier"]/*'/>
    public Guid guidDeviceIdentifier;
    /// <include file='DDDEVICEIDENTIFIER2.xml' path='doc/member[@name="DDDEVICEIDENTIFIER2.dwWHQLLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwWHQLLevel;
}