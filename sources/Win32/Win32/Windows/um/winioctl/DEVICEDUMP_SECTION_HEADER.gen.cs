// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DEVICEDUMP_SECTION_HEADER
{
    public Guid guidDeviceDataId;

    [NativeTypeName("BYTE[16]")]
    public _sOrganizationID_e__FixedBuffer sOrganizationID;

    [NativeTypeName("DWORD")]
    public uint dwFirmwareRevision;

    [NativeTypeName("BYTE[32]")]
    public _sModelNumber_e__FixedBuffer sModelNumber;

    [NativeTypeName("BYTE[32]")]
    public _szDeviceManufacturingID_e__FixedBuffer szDeviceManufacturingID;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint bRestrictedPrivateDataVersion;

    [NativeTypeName("DWORD")]
    public uint dwFirmwareIssueId;

    [NativeTypeName("BYTE[132]")]
    public _szIssueDescriptionString_e__FixedBuffer szIssueDescriptionString;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _sOrganizationID_e__FixedBuffer
    {
        public byte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _sModelNumber_e__FixedBuffer
    {
        public byte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szDeviceManufacturingID_e__FixedBuffer
    {
        public byte e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(132)]
    public partial struct _szIssueDescriptionString_e__FixedBuffer
    {
        public byte e0;
    }
}
