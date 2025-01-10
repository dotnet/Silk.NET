// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct GROUP_FILTER
{
    [NativeTypeName("ULONG")]
    public uint gf_interface;
    public SOCKADDR_STORAGE gf_group;
    public MULTICAST_MODE_TYPE gf_fmode;

    [NativeTypeName("ULONG")]
    public uint gf_numsrc;

    [NativeTypeName("SOCKADDR_STORAGE[1]")]
    public _gf_slist_e__FixedBuffer gf_slist;

    public partial struct _gf_slist_e__FixedBuffer
    {
        public SOCKADDR_STORAGE e0;

        [UnscopedRef]
        public ref SOCKADDR_STORAGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SOCKADDR_STORAGE> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
