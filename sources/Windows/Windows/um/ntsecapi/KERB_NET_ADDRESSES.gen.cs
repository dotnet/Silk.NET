// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='KERB_NET_ADDRESSES.xml' path='doc/member[@name="KERB_NET_ADDRESSES"]/*' />
public partial struct KERB_NET_ADDRESSES
{
    /// <include file='KERB_NET_ADDRESSES.xml' path='doc/member[@name="KERB_NET_ADDRESSES.Number"]/*' />
    [NativeTypeName("ULONG")]
    public uint Number;

    /// <include file='KERB_NET_ADDRESSES.xml' path='doc/member[@name="KERB_NET_ADDRESSES.Addresses"]/*' />
    [NativeTypeName("KERB_NET_ADDRESS[1]")]
    public _Addresses_e__FixedBuffer Addresses;

    /// <include file='_Addresses_e__FixedBuffer.xml' path='doc/member[@name="_Addresses_e__FixedBuffer"]/*' />
    public partial struct _Addresses_e__FixedBuffer
    {
        public KERB_NET_ADDRESS e0;

        [UnscopedRef]
        public ref KERB_NET_ADDRESS this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<KERB_NET_ADDRESS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
