// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='GROUP_FILTER.xml' path='doc/member[@name="GROUP_FILTER"]/*'/>
public partial struct GROUP_FILTER
{
    /// <include file='GROUP_FILTER.xml' path='doc/member[@name="GROUP_FILTER.gf_interface"]/*'/>
    [NativeTypeName("ULONG")]
    public uint gf_interface;
    /// <include file='GROUP_FILTER.xml' path='doc/member[@name="GROUP_FILTER.gf_group"]/*'/>
    public SOCKADDR_STORAGE gf_group;
    /// <include file='GROUP_FILTER.xml' path='doc/member[@name="GROUP_FILTER.gf_fmode"]/*'/>
    public MULTICAST_MODE_TYPE gf_fmode;
    /// <include file='GROUP_FILTER.xml' path='doc/member[@name="GROUP_FILTER.gf_numsrc"]/*'/>
    [NativeTypeName("ULONG")]
    public uint gf_numsrc;
    /// <include file='GROUP_FILTER.xml' path='doc/member[@name="GROUP_FILTER.gf_slist"]/*'/>
    [NativeTypeName("SOCKADDR_STORAGE[1]")]
    public _gf_slist_e__FixedBuffer gf_slist;
    /// <include file='_gf_slist_e__FixedBuffer.xml' path='doc/member[@name="_gf_slist_e__FixedBuffer"]/*'/>
    public partial struct _gf_slist_e__FixedBuffer
    {
        public SOCKADDR_STORAGE e0;
        [UnscopedRef]
        public ref SOCKADDR_STORAGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SOCKADDR_STORAGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}