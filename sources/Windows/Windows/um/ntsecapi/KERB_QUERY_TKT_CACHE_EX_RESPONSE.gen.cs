// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='KERB_QUERY_TKT_CACHE_EX_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_TKT_CACHE_EX_RESPONSE"]/*'/>
public partial struct KERB_QUERY_TKT_CACHE_EX_RESPONSE
{
    /// <include file='KERB_QUERY_TKT_CACHE_EX_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_TKT_CACHE_EX_RESPONSE.MessageType"]/*'/>
    public KERB_PROTOCOL_MESSAGE_TYPE MessageType;
    /// <include file='KERB_QUERY_TKT_CACHE_EX_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_TKT_CACHE_EX_RESPONSE.CountOfTickets"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CountOfTickets;
    /// <include file='KERB_QUERY_TKT_CACHE_EX_RESPONSE.xml' path='doc/member[@name="KERB_QUERY_TKT_CACHE_EX_RESPONSE.Tickets"]/*'/>
    [NativeTypeName("KERB_TICKET_CACHE_INFO_EX[1]")]
    public _Tickets_e__FixedBuffer Tickets;
    /// <include file='_Tickets_e__FixedBuffer.xml' path='doc/member[@name="_Tickets_e__FixedBuffer"]/*'/>
    public partial struct _Tickets_e__FixedBuffer
    {
        public KERB_TICKET_CACHE_INFO_EX e0;
        [UnscopedRef]
        public ref KERB_TICKET_CACHE_INFO_EX this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<KERB_TICKET_CACHE_INFO_EX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}