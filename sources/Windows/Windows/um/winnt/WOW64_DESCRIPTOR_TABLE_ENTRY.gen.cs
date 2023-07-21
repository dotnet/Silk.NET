// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WOW64_DESCRIPTOR_TABLE_ENTRY.xml' path='doc/member[@name="WOW64_DESCRIPTOR_TABLE_ENTRY"]/*' />
public partial struct WOW64_DESCRIPTOR_TABLE_ENTRY
{
    /// <include file='WOW64_DESCRIPTOR_TABLE_ENTRY.xml' path='doc/member[@name="WOW64_DESCRIPTOR_TABLE_ENTRY.Selector"]/*' />
    [NativeTypeName("DWORD")]
    public uint Selector;

    /// <include file='WOW64_DESCRIPTOR_TABLE_ENTRY.xml' path='doc/member[@name="WOW64_DESCRIPTOR_TABLE_ENTRY.Descriptor"]/*' />
    public WOW64_LDT_ENTRY Descriptor;
}
