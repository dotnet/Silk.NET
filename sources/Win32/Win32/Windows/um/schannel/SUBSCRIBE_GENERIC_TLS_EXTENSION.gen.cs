// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SUBSCRIBE_GENERIC_TLS_EXTENSION
{
    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint SubscriptionsCount;

    [NativeTypeName("TLS_EXTENSION_SUBSCRIPTION[1]")]
    public _Subscriptions_e__FixedBuffer Subscriptions;

    public partial struct _Subscriptions_e__FixedBuffer
    {
        public TLS_EXTENSION_SUBSCRIPTION e0;

        [UnscopedRef]
        public ref TLS_EXTENSION_SUBSCRIPTION this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<TLS_EXTENSION_SUBSCRIPTION> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
