// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_DATA_DIRECTORY.xml' path='doc/member[@name="IMAGE_DATA_DIRECTORY"]/*'/>
public partial struct IMAGE_DATA_DIRECTORY
{
    /// <include file='IMAGE_DATA_DIRECTORY.xml' path='doc/member[@name="IMAGE_DATA_DIRECTORY.VirtualAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint VirtualAddress;
    /// <include file='IMAGE_DATA_DIRECTORY.xml' path='doc/member[@name="IMAGE_DATA_DIRECTORY.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
}