// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='FILE_SEGMENT_ELEMENT.xml' path='doc/member[@name="FILE_SEGMENT_ELEMENT"]/*' />
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct FILE_SEGMENT_ELEMENT
{
    /// <include file='FILE_SEGMENT_ELEMENT.xml' path='doc/member[@name="FILE_SEGMENT_ELEMENT.Buffer"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("PVOID64")]
    public void* Buffer;

    /// <include file='FILE_SEGMENT_ELEMENT.xml' path='doc/member[@name="FILE_SEGMENT_ELEMENT.Alignment"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("ULONGLONG")]
    public ulong Alignment;
}
