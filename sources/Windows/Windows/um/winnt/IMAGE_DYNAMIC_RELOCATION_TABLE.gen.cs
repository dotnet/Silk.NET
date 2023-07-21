// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGE_DYNAMIC_RELOCATION_TABLE.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION_TABLE"]/*' />
public partial struct IMAGE_DYNAMIC_RELOCATION_TABLE
{
    /// <include file='IMAGE_DYNAMIC_RELOCATION_TABLE.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION_TABLE.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='IMAGE_DYNAMIC_RELOCATION_TABLE.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION_TABLE.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;
}
