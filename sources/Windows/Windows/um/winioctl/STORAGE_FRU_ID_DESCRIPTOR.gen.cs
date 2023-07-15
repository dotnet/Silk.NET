// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_FRU_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_FRU_ID_DESCRIPTOR"]/*'/>
public unsafe partial struct STORAGE_FRU_ID_DESCRIPTOR
{
    /// <include file='STORAGE_FRU_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_FRU_ID_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_FRU_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_FRU_ID_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_FRU_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_FRU_ID_DESCRIPTOR.IdentifierSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint IdentifierSize;
    /// <include file='STORAGE_FRU_ID_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_FRU_ID_DESCRIPTOR.Identifier"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Identifier[1];
}