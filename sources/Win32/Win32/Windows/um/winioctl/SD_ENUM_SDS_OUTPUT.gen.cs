// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SD_ENUM_SDS_OUTPUT
{
    [NativeTypeName("DWORDLONG")]
    public ulong NextOffset;

    [NativeTypeName("DWORDLONG")]
    public ulong NumSDEntriesReturned;

    [NativeTypeName("DWORDLONG")]
    public ulong NumSDBytesReturned;

    [NativeTypeName("SD_ENUM_SDS_ENTRY[1]")]
    public _SDEntry_e__FixedBuffer SDEntry;

    public partial struct _SDEntry_e__FixedBuffer
    {
        public SD_ENUM_SDS_ENTRY e0;

        [UnscopedRef]
        public ref SD_ENUM_SDS_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SD_ENUM_SDS_ENTRY> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
