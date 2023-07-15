// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_HOT_PATCH_HASHES.xml' path='doc/member[@name="IMAGE_HOT_PATCH_HASHES"]/*'/>
public unsafe partial struct IMAGE_HOT_PATCH_HASHES
{
    /// <include file='IMAGE_HOT_PATCH_HASHES.xml' path='doc/member[@name="IMAGE_HOT_PATCH_HASHES.SHA256"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte SHA256[32];
    /// <include file='IMAGE_HOT_PATCH_HASHES.xml' path='doc/member[@name="IMAGE_HOT_PATCH_HASHES.SHA1"]/*'/>
    [NativeTypeName("BYTE[20]")]
    public fixed byte SHA1[20];
}