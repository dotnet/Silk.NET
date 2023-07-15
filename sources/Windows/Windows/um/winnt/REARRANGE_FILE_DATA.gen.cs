// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='REARRANGE_FILE_DATA.xml' path='doc/member[@name="REARRANGE_FILE_DATA"]/*'/>
public partial struct REARRANGE_FILE_DATA
{
    /// <include file='REARRANGE_FILE_DATA.xml' path='doc/member[@name="REARRANGE_FILE_DATA.SourceStartingOffset"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong SourceStartingOffset;
    /// <include file='REARRANGE_FILE_DATA.xml' path='doc/member[@name="REARRANGE_FILE_DATA.TargetOffset"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong TargetOffset;
    /// <include file='REARRANGE_FILE_DATA.xml' path='doc/member[@name="REARRANGE_FILE_DATA.SourceFileHandle"]/*'/>
    public HANDLE SourceFileHandle;
    /// <include file='REARRANGE_FILE_DATA.xml' path='doc/member[@name="REARRANGE_FILE_DATA.Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Length;
    /// <include file='REARRANGE_FILE_DATA.xml' path='doc/member[@name="REARRANGE_FILE_DATA.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}