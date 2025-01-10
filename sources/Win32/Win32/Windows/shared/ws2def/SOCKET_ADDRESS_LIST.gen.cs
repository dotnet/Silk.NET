// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SOCKET_ADDRESS_LIST
{
    public int iAddressCount;

    [NativeTypeName("SOCKET_ADDRESS[1]")]
    public _Address_e__FixedBuffer Address;

    public partial struct _Address_e__FixedBuffer
    {
        public SOCKET_ADDRESS e0;

        [UnscopedRef]
        public ref SOCKET_ADDRESS this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SOCKET_ADDRESS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
