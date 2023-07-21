// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY"]/*' />
public unsafe partial struct SD_ENUM_SDS_ENTRY
{
    /// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY.Hash"]/*' />
    [NativeTypeName("DWORD")]
    public uint Hash;

    /// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY.SecurityId"]/*' />
    [NativeTypeName("DWORD")]
    public uint SecurityId;

    /// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY.Offset"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Offset;

    /// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY.Length"]/*' />
    [NativeTypeName("DWORD")]
    public uint Length;

    /// <include file='SD_ENUM_SDS_ENTRY.xml' path='doc/member[@name="SD_ENUM_SDS_ENTRY.Descriptor"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte Descriptor[1];
}
