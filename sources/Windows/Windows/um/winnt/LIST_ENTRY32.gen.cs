// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LIST_ENTRY32.xml' path='doc/member[@name="LIST_ENTRY32"]/*' />
public partial struct LIST_ENTRY32
{
    /// <include file='LIST_ENTRY32.xml' path='doc/member[@name="LIST_ENTRY32.Flink"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flink;

    /// <include file='LIST_ENTRY32.xml' path='doc/member[@name="LIST_ENTRY32.Blink"]/*' />
    [NativeTypeName("DWORD")]
    public uint Blink;
}
