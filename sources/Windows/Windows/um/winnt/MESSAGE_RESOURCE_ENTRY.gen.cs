// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MESSAGE_RESOURCE_ENTRY.xml' path='doc/member[@name="MESSAGE_RESOURCE_ENTRY"]/*' />
public unsafe partial struct MESSAGE_RESOURCE_ENTRY
{
    /// <include file='MESSAGE_RESOURCE_ENTRY.xml' path='doc/member[@name="MESSAGE_RESOURCE_ENTRY.Length"]/*' />
    [NativeTypeName("WORD")]
    public ushort Length;

    /// <include file='MESSAGE_RESOURCE_ENTRY.xml' path='doc/member[@name="MESSAGE_RESOURCE_ENTRY.Flags"]/*' />
    [NativeTypeName("WORD")]
    public ushort Flags;

    /// <include file='MESSAGE_RESOURCE_ENTRY.xml' path='doc/member[@name="MESSAGE_RESOURCE_ENTRY.Text"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte Text[1];
}
