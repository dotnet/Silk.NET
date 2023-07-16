// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SUBSCRIBE_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SUBSCRIBE_GENERIC_TLS_EXTENSION"]/*'/>
public partial struct SUBSCRIBE_GENERIC_TLS_EXTENSION
{
    /// <include file='SUBSCRIBE_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SUBSCRIBE_GENERIC_TLS_EXTENSION.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='SUBSCRIBE_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SUBSCRIBE_GENERIC_TLS_EXTENSION.SubscriptionsCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SubscriptionsCount;
    /// <include file='SUBSCRIBE_GENERIC_TLS_EXTENSION.xml' path='doc/member[@name="SUBSCRIBE_GENERIC_TLS_EXTENSION.Subscriptions"]/*'/>
    [NativeTypeName("TLS_EXTENSION_SUBSCRIPTION[1]")]
    public _Subscriptions_e__FixedBuffer Subscriptions;
    /// <include file='_Subscriptions_e__FixedBuffer.xml' path='doc/member[@name="_Subscriptions_e__FixedBuffer"]/*'/>
    public partial struct _Subscriptions_e__FixedBuffer
    {
        public TLS_EXTENSION_SUBSCRIPTION e0;
        [UnscopedRef]
        public ref TLS_EXTENSION_SUBSCRIPTION this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<TLS_EXTENSION_SUBSCRIPTION> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}