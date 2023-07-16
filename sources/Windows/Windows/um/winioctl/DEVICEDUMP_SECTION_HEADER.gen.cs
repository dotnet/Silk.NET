// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DEVICEDUMP_SECTION_HEADER
{
    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.guidDeviceDataId"]/*'/>
    public Guid guidDeviceDataId;
    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.sOrganizationID"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte sOrganizationID[16];
    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.dwFirmwareRevision"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFirmwareRevision;
    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.sModelNumber"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte sModelNumber[32];
    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.szDeviceManufacturingID"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte szDeviceManufacturingID[32];
    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.bRestrictedPrivateDataVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bRestrictedPrivateDataVersion;
    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.dwFirmwareIssueId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFirmwareIssueId;
    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.szIssueDescriptionString"]/*'/>
    [NativeTypeName("BYTE[132]")]
    public fixed byte szIssueDescriptionString[132];
}