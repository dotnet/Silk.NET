// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='EMRPOLYLINE.xml' path='doc/member[@name="EMRPOLYLINE"]/*' />
public partial struct EMRPOLYLINE
{
    /// <include file='EMRPOLYLINE.xml' path='doc/member[@name="EMRPOLYLINE.emr"]/*' />
    public EMR emr;

    /// <include file='EMRPOLYLINE.xml' path='doc/member[@name="EMRPOLYLINE.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRPOLYLINE.xml' path='doc/member[@name="EMRPOLYLINE.cptl"]/*' />
    [NativeTypeName("DWORD")]
    public uint cptl;

    /// <include file='EMRPOLYLINE.xml' path='doc/member[@name="EMRPOLYLINE.aptl"]/*' />
    [NativeTypeName("POINTL[1]")]
    public _aptl_e__FixedBuffer aptl;

    /// <include file='_aptl_e__FixedBuffer.xml' path='doc/member[@name="_aptl_e__FixedBuffer"]/*' />
    public partial struct _aptl_e__FixedBuffer
    {
        public POINTL e0;

        [UnscopedRef]
        public ref POINTL this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<POINTL> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
