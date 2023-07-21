// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD"]/*' />
public unsafe partial struct SCM_PD_FIRMWARE_DOWNLOAD
{
    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Slot"]/*' />
    public byte Slot;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Reserved"]/*' />
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved[3];

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.Offset"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Offset;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.FirmwareImageSizeInBytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint FirmwareImageSizeInBytes;

    /// <include file='SCM_PD_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="SCM_PD_FIRMWARE_DOWNLOAD.FirmwareImage"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte FirmwareImage[1];
}
