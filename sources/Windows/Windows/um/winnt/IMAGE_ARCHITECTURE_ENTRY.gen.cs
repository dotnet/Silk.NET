// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_ARCHITECTURE_ENTRY.xml' path='doc/member[@name="IMAGE_ARCHITECTURE_ENTRY"]/*'/>
public partial struct IMAGE_ARCHITECTURE_ENTRY
{
    /// <include file='IMAGE_ARCHITECTURE_ENTRY.xml' path='doc/member[@name="IMAGE_ARCHITECTURE_ENTRY.FixupInstRVA"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FixupInstRVA;
    /// <include file='IMAGE_ARCHITECTURE_ENTRY.xml' path='doc/member[@name="IMAGE_ARCHITECTURE_ENTRY.NewInst"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NewInst;
}