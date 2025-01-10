// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public partial struct USN_RECORD_V4
{
    public USN_RECORD_COMMON_HEADER Header;
    public FILE_ID_128 FileReferenceNumber;
    public FILE_ID_128 ParentFileReferenceNumber;

    [NativeTypeName("USN")]
    public long Usn;

    [NativeTypeName("DWORD")]
    public uint Reason;

    [NativeTypeName("DWORD")]
    public uint SourceInfo;

    [NativeTypeName("DWORD")]
    public uint RemainingExtents;

    [NativeTypeName("WORD")]
    public ushort NumberOfExtents;

    [NativeTypeName("WORD")]
    public ushort ExtentSize;

    [NativeTypeName("USN_RECORD_EXTENT[1]")]
    public _Extents_e__FixedBuffer Extents;

    public partial struct _Extents_e__FixedBuffer
    {
        public USN_RECORD_EXTENT e0;

        [UnscopedRef]
        public ref USN_RECORD_EXTENT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<USN_RECORD_EXTENT> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
