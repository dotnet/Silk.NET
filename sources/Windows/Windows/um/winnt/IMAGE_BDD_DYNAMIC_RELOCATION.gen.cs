// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_BDD_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_BDD_DYNAMIC_RELOCATION"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_BDD_DYNAMIC_RELOCATION
{
    /// <include file='IMAGE_BDD_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_BDD_DYNAMIC_RELOCATION.Left"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Left;
    /// <include file='IMAGE_BDD_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_BDD_DYNAMIC_RELOCATION.Right"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Right;
    /// <include file='IMAGE_BDD_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_BDD_DYNAMIC_RELOCATION.Value"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Value;
}