// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='NRESARRAY.xml' path='doc/member[@name="NRESARRAY"]/*' />
public partial struct NRESARRAY
{
    /// <include file='NRESARRAY.xml' path='doc/member[@name="NRESARRAY.cItems"]/*' />
    public uint cItems;

    /// <include file='NRESARRAY.xml' path='doc/member[@name="NRESARRAY.nr"]/*' />
    [NativeTypeName("NETRESOURCE[1]")]
    public _nr_e__FixedBuffer nr;

    /// <include file='_nr_e__FixedBuffer.xml' path='doc/member[@name="_nr_e__FixedBuffer"]/*' />
    public partial struct _nr_e__FixedBuffer
    {
        public NETRESOURCEW e0;

        [UnscopedRef]
        public ref NETRESOURCEW this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<NETRESOURCEW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
