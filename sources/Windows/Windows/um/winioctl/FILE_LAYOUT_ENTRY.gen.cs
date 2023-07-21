// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_LAYOUT_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_ENTRY"]/*' />
public partial struct FILE_LAYOUT_ENTRY
{
    /// <include file='FILE_LAYOUT_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_ENTRY.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='FILE_LAYOUT_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_ENTRY.NextFileOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint NextFileOffset;

    /// <include file='FILE_LAYOUT_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_ENTRY.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='FILE_LAYOUT_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_ENTRY.FileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    /// <include file='FILE_LAYOUT_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_ENTRY.FileReferenceNumber"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong FileReferenceNumber;

    /// <include file='FILE_LAYOUT_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_ENTRY.FirstNameOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint FirstNameOffset;

    /// <include file='FILE_LAYOUT_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_ENTRY.FirstStreamOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint FirstStreamOffset;

    /// <include file='FILE_LAYOUT_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_ENTRY.ExtraInfoOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExtraInfoOffset;

    /// <include file='FILE_LAYOUT_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_ENTRY.ExtraInfoLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExtraInfoLength;
}
