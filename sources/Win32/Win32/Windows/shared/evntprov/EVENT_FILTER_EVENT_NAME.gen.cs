// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct EVENT_FILTER_EVENT_NAME
{
    [NativeTypeName("ULONGLONG")]
    public ulong MatchAnyKeyword;

    [NativeTypeName("ULONGLONG")]
    public ulong MatchAllKeyword;

    [NativeTypeName("UCHAR")]
    public byte Level;

    [NativeTypeName("BOOLEAN")]
    public byte FilterIn;
    public ushort NameCount;

    [NativeTypeName("UCHAR[1]")]
    public _Names_e__FixedBuffer Names;

    public partial struct _Names_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
