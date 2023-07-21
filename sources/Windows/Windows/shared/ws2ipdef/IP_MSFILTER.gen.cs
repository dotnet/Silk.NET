// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='IP_MSFILTER.xml' path='doc/member[@name="IP_MSFILTER"]/*' />
public partial struct IP_MSFILTER
{
    /// <include file='IP_MSFILTER.xml' path='doc/member[@name="IP_MSFILTER.imsf_multiaddr"]/*' />
    public IN_ADDR imsf_multiaddr;

    /// <include file='IP_MSFILTER.xml' path='doc/member[@name="IP_MSFILTER.imsf_interface"]/*' />
    public IN_ADDR imsf_interface;

    /// <include file='IP_MSFILTER.xml' path='doc/member[@name="IP_MSFILTER.imsf_fmode"]/*' />
    public MULTICAST_MODE_TYPE imsf_fmode;

    /// <include file='IP_MSFILTER.xml' path='doc/member[@name="IP_MSFILTER.imsf_numsrc"]/*' />
    [NativeTypeName("ULONG")]
    public uint imsf_numsrc;

    /// <include file='IP_MSFILTER.xml' path='doc/member[@name="IP_MSFILTER.imsf_slist"]/*' />
    [NativeTypeName("IN_ADDR[1]")]
    public _imsf_slist_e__FixedBuffer imsf_slist;

    /// <include file='_imsf_slist_e__FixedBuffer.xml' path='doc/member[@name="_imsf_slist_e__FixedBuffer"]/*' />
    public partial struct _imsf_slist_e__FixedBuffer
    {
        public IN_ADDR e0;

        [UnscopedRef]
        public ref IN_ADDR this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<IN_ADDR> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
