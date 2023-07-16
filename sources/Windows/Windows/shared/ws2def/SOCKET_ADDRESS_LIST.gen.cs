// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SOCKET_ADDRESS_LIST.xml' path='doc/member[@name="SOCKET_ADDRESS_LIST"]/*'/>
public partial struct SOCKET_ADDRESS_LIST
{
    /// <include file='SOCKET_ADDRESS_LIST.xml' path='doc/member[@name="SOCKET_ADDRESS_LIST.iAddressCount"]/*'/>
    public int iAddressCount;
    /// <include file='SOCKET_ADDRESS_LIST.xml' path='doc/member[@name="SOCKET_ADDRESS_LIST.Address"]/*'/>
    [NativeTypeName("SOCKET_ADDRESS[1]")]
    public _Address_e__FixedBuffer Address;
    /// <include file='_Address_e__FixedBuffer.xml' path='doc/member[@name="_Address_e__FixedBuffer"]/*'/>
    public partial struct _Address_e__FixedBuffer
    {
        public SOCKET_ADDRESS e0;
        [UnscopedRef]
        public ref SOCKET_ADDRESS this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SOCKET_ADDRESS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}