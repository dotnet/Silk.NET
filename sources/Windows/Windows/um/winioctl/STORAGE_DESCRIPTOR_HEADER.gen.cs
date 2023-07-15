// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_DESCRIPTOR_HEADER.xml' path='doc/member[@name="STORAGE_DESCRIPTOR_HEADER"]/*'/>
public partial struct STORAGE_DESCRIPTOR_HEADER
{
    /// <include file='STORAGE_DESCRIPTOR_HEADER.xml' path='doc/member[@name="STORAGE_DESCRIPTOR_HEADER.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DESCRIPTOR_HEADER.xml' path='doc/member[@name="STORAGE_DESCRIPTOR_HEADER.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
}