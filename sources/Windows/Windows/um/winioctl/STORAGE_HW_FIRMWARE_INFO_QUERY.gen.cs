// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_HW_FIRMWARE_INFO_QUERY.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO_QUERY"]/*' />
public partial struct STORAGE_HW_FIRMWARE_INFO_QUERY
{
    /// <include file='STORAGE_HW_FIRMWARE_INFO_QUERY.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO_QUERY.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_HW_FIRMWARE_INFO_QUERY.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO_QUERY.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_HW_FIRMWARE_INFO_QUERY.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO_QUERY.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='STORAGE_HW_FIRMWARE_INFO_QUERY.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_INFO_QUERY.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;
}
