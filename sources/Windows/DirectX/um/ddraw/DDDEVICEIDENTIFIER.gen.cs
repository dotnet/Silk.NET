// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;

namespace Silk.NET.DirectX;
/// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER"]/*'/>
public unsafe partial struct DDDEVICEIDENTIFIER
{
    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.szDriver"]/*'/>
    [NativeTypeName("char[512]")]
    public fixed sbyte szDriver[512];
    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.szDescription"]/*'/>
    [NativeTypeName("char[512]")]
    public fixed sbyte szDescription[512];
    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.liDriverVersion"]/*'/>
    public LARGE_INTEGER liDriverVersion;
    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.dwVendorId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVendorId;
    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.dwDeviceId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDeviceId;
    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.dwSubSysId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSubSysId;
    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.dwRevision"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRevision;
    /// <include file='DDDEVICEIDENTIFIER.xml' path='doc/member[@name="DDDEVICEIDENTIFIER.guidDeviceIdentifier"]/*'/>
    public Guid guidDeviceIdentifier;
}