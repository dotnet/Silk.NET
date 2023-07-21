// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='AM_PROPERTY_SPPAL.xml' path='doc/member[@name="AM_PROPERTY_SPPAL"]/*' />
public partial struct AM_PROPERTY_SPPAL
{
    /// <include file='AM_PROPERTY_SPPAL.xml' path='doc/member[@name="AM_PROPERTY_SPPAL.sppal"]/*' />
    [NativeTypeName("AM_DVD_YUV[16]")]
    public _sppal_e__FixedBuffer sppal;

    /// <include file='_sppal_e__FixedBuffer.xml' path='doc/member[@name="_sppal_e__FixedBuffer"]/*' />
    public partial struct _sppal_e__FixedBuffer
    {
        public AM_DVD_YUV e0;
        public AM_DVD_YUV e1;
        public AM_DVD_YUV e2;
        public AM_DVD_YUV e3;
        public AM_DVD_YUV e4;
        public AM_DVD_YUV e5;
        public AM_DVD_YUV e6;
        public AM_DVD_YUV e7;
        public AM_DVD_YUV e8;
        public AM_DVD_YUV e9;
        public AM_DVD_YUV e10;
        public AM_DVD_YUV e11;
        public AM_DVD_YUV e12;
        public AM_DVD_YUV e13;
        public AM_DVD_YUV e14;
        public AM_DVD_YUV e15;

        [UnscopedRef]
        public ref AM_DVD_YUV this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<AM_DVD_YUV> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}
