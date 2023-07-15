// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_LOAD_CONFIG_CODE_INTEGRITY.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_CODE_INTEGRITY"]/*'/>
public partial struct IMAGE_LOAD_CONFIG_CODE_INTEGRITY
{
    /// <include file='IMAGE_LOAD_CONFIG_CODE_INTEGRITY.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_CODE_INTEGRITY.Flags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Flags;
    /// <include file='IMAGE_LOAD_CONFIG_CODE_INTEGRITY.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_CODE_INTEGRITY.Catalog"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Catalog;
    /// <include file='IMAGE_LOAD_CONFIG_CODE_INTEGRITY.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_CODE_INTEGRITY.CatalogOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CatalogOffset;
    /// <include file='IMAGE_LOAD_CONFIG_CODE_INTEGRITY.xml' path='doc/member[@name="IMAGE_LOAD_CONFIG_CODE_INTEGRITY.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
}