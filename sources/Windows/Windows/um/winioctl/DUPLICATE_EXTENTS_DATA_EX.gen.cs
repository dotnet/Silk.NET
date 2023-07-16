// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DUPLICATE_EXTENTS_DATA_EX.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX"]/*'/>
public partial struct DUPLICATE_EXTENTS_DATA_EX
{
    /// <include file='DUPLICATE_EXTENTS_DATA_EX.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX.Size"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint Size;
    /// <include file='DUPLICATE_EXTENTS_DATA_EX.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX.FileHandle"]/*'/>
    public HANDLE FileHandle;
    /// <include file='DUPLICATE_EXTENTS_DATA_EX.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX.SourceFileOffset"]/*'/>
    public LARGE_INTEGER SourceFileOffset;
    /// <include file='DUPLICATE_EXTENTS_DATA_EX.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX.TargetFileOffset"]/*'/>
    public LARGE_INTEGER TargetFileOffset;
    /// <include file='DUPLICATE_EXTENTS_DATA_EX.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX.ByteCount"]/*'/>
    public LARGE_INTEGER ByteCount;
    /// <include file='DUPLICATE_EXTENTS_DATA_EX.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}