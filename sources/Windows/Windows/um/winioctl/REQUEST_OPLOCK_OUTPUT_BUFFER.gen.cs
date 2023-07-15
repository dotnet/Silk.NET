// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='REQUEST_OPLOCK_OUTPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_OUTPUT_BUFFER"]/*'/>
public partial struct REQUEST_OPLOCK_OUTPUT_BUFFER
{
    /// <include file='REQUEST_OPLOCK_OUTPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_OUTPUT_BUFFER.StructureVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort StructureVersion;
    /// <include file='REQUEST_OPLOCK_OUTPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_OUTPUT_BUFFER.StructureLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort StructureLength;
    /// <include file='REQUEST_OPLOCK_OUTPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_OUTPUT_BUFFER.OriginalOplockLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OriginalOplockLevel;
    /// <include file='REQUEST_OPLOCK_OUTPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_OUTPUT_BUFFER.NewOplockLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NewOplockLevel;
    /// <include file='REQUEST_OPLOCK_OUTPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_OUTPUT_BUFFER.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='REQUEST_OPLOCK_OUTPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_OUTPUT_BUFFER.AccessMode"]/*'/>
    [NativeTypeName("ACCESS_MASK")]
    public uint AccessMode;
    /// <include file='REQUEST_OPLOCK_OUTPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_OUTPUT_BUFFER.ShareMode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ShareMode;
}