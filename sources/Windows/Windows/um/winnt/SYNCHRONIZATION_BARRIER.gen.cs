// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SYNCHRONIZATION_BARRIER.xml' path='doc/member[@name="SYNCHRONIZATION_BARRIER"]/*' />
public partial struct SYNCHRONIZATION_BARRIER
{
    /// <include file='SYNCHRONIZATION_BARRIER.xml' path='doc/member[@name="SYNCHRONIZATION_BARRIER.Reserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved1;

    /// <include file='SYNCHRONIZATION_BARRIER.xml' path='doc/member[@name="SYNCHRONIZATION_BARRIER.Reserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved2;

    /// <include file='SYNCHRONIZATION_BARRIER.xml' path='doc/member[@name="SYNCHRONIZATION_BARRIER.Reserved3"]/*' />
    [NativeTypeName("ULONG_PTR[2]")]
    public _Reserved3_e__FixedBuffer Reserved3;

    /// <include file='SYNCHRONIZATION_BARRIER.xml' path='doc/member[@name="SYNCHRONIZATION_BARRIER.Reserved4"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved4;

    /// <include file='SYNCHRONIZATION_BARRIER.xml' path='doc/member[@name="SYNCHRONIZATION_BARRIER.Reserved5"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved5;

    /// <include file='_Reserved3_e__FixedBuffer.xml' path='doc/member[@name="_Reserved3_e__FixedBuffer"]/*' />
    public partial struct _Reserved3_e__FixedBuffer
    {
        public nuint e0;
        public nuint e1;

        [UnscopedRef]
        public ref nuint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}
