// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY"]/*'/>
public unsafe partial struct FILE_LAYOUT_NAME_ENTRY
{
    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.NextNameOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NextNameOffset;
    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.ParentFileReferenceNumber"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ParentFileReferenceNumber;
    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.FileNameLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FileNameLength;
    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
    /// <include file='FILE_LAYOUT_NAME_ENTRY.xml' path='doc/member[@name="FILE_LAYOUT_NAME_ENTRY.FileName"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort FileName[1];
}