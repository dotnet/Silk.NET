// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IP_MSFILTER
{
    public IN_ADDR imsf_multiaddr;
    public IN_ADDR imsf_interface;
    public MULTICAST_MODE_TYPE imsf_fmode;

    [NativeTypeName("ULONG")]
    public uint imsf_numsrc;

    [NativeTypeName("IN_ADDR[1]")]
    public _imsf_slist_e__FixedBuffer imsf_slist;

    public partial struct _imsf_slist_e__FixedBuffer
    {
        public IN_ADDR e0;

        [UnscopedRef]
        public ref IN_ADDR this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<IN_ADDR> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
