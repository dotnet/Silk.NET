// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DUPLICATE_EXTENTS_DATA_EX32.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX32"]/*'/>
public partial struct DUPLICATE_EXTENTS_DATA_EX32
{
    /// <include file='DUPLICATE_EXTENTS_DATA_EX32.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX32.Size"]/*'/>
    [NativeTypeName("DWORD32")]
    public uint Size;
    /// <include file='DUPLICATE_EXTENTS_DATA_EX32.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX32.FileHandle"]/*'/>
    [NativeTypeName("DWORD32")]
    public uint FileHandle;
    /// <include file='DUPLICATE_EXTENTS_DATA_EX32.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX32.SourceFileOffset"]/*'/>
    public LARGE_INTEGER SourceFileOffset;
    /// <include file='DUPLICATE_EXTENTS_DATA_EX32.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX32.TargetFileOffset"]/*'/>
    public LARGE_INTEGER TargetFileOffset;
    /// <include file='DUPLICATE_EXTENTS_DATA_EX32.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX32.ByteCount"]/*'/>
    public LARGE_INTEGER ByteCount;
    /// <include file='DUPLICATE_EXTENTS_DATA_EX32.xml' path='doc/member[@name="DUPLICATE_EXTENTS_DATA_EX32.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}