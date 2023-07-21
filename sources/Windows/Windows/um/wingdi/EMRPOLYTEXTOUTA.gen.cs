// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='EMRPOLYTEXTOUTA.xml' path='doc/member[@name="EMRPOLYTEXTOUTA"]/*' />
public partial struct EMRPOLYTEXTOUTA
{
    /// <include file='EMRPOLYTEXTOUTA.xml' path='doc/member[@name="EMRPOLYTEXTOUTA.emr"]/*' />
    public EMR emr;

    /// <include file='EMRPOLYTEXTOUTA.xml' path='doc/member[@name="EMRPOLYTEXTOUTA.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRPOLYTEXTOUTA.xml' path='doc/member[@name="EMRPOLYTEXTOUTA.iGraphicsMode"]/*' />
    [NativeTypeName("DWORD")]
    public uint iGraphicsMode;

    /// <include file='EMRPOLYTEXTOUTA.xml' path='doc/member[@name="EMRPOLYTEXTOUTA.exScale"]/*' />
    public float exScale;

    /// <include file='EMRPOLYTEXTOUTA.xml' path='doc/member[@name="EMRPOLYTEXTOUTA.eyScale"]/*' />
    public float eyScale;

    /// <include file='EMRPOLYTEXTOUTA.xml' path='doc/member[@name="EMRPOLYTEXTOUTA.cStrings"]/*' />
    [NativeTypeName("LONG")]
    public int cStrings;

    /// <include file='EMRPOLYTEXTOUTA.xml' path='doc/member[@name="EMRPOLYTEXTOUTA.aemrtext"]/*' />
    [NativeTypeName("EMRTEXT[1]")]
    public _aemrtext_e__FixedBuffer aemrtext;

    /// <include file='_aemrtext_e__FixedBuffer.xml' path='doc/member[@name="_aemrtext_e__FixedBuffer"]/*' />
    public partial struct _aemrtext_e__FixedBuffer
    {
        public EMRTEXT e0;

        [UnscopedRef]
        public ref EMRTEXT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<EMRTEXT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
