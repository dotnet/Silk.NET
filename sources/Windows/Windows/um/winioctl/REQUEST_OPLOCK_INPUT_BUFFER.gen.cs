// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='REQUEST_OPLOCK_INPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_INPUT_BUFFER"]/*'/>
public partial struct REQUEST_OPLOCK_INPUT_BUFFER
{
    /// <include file='REQUEST_OPLOCK_INPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_INPUT_BUFFER.StructureVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort StructureVersion;
    /// <include file='REQUEST_OPLOCK_INPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_INPUT_BUFFER.StructureLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort StructureLength;
    /// <include file='REQUEST_OPLOCK_INPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_INPUT_BUFFER.RequestedOplockLevel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RequestedOplockLevel;
    /// <include file='REQUEST_OPLOCK_INPUT_BUFFER.xml' path='doc/member[@name="REQUEST_OPLOCK_INPUT_BUFFER.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}