// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REARRANGE_FILE_DATA32.xml' path='doc/member[@name="REARRANGE_FILE_DATA32"]/*'/>
public partial struct REARRANGE_FILE_DATA32
{
    /// <include file='REARRANGE_FILE_DATA32.xml' path='doc/member[@name="REARRANGE_FILE_DATA32.SourceStartingOffset"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong SourceStartingOffset;
    /// <include file='REARRANGE_FILE_DATA32.xml' path='doc/member[@name="REARRANGE_FILE_DATA32.TargetOffset"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong TargetOffset;
    /// <include file='REARRANGE_FILE_DATA32.xml' path='doc/member[@name="REARRANGE_FILE_DATA32.SourceFileHandle"]/*'/>
    [NativeTypeName("UINT32")]
    public uint SourceFileHandle;
    /// <include file='REARRANGE_FILE_DATA32.xml' path='doc/member[@name="REARRANGE_FILE_DATA32.Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Length;
    /// <include file='REARRANGE_FILE_DATA32.xml' path='doc/member[@name="REARRANGE_FILE_DATA32.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}