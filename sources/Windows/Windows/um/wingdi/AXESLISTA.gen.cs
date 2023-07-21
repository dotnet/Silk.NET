// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA"]/*' />
public partial struct AXESLISTA
{
    /// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA.axlReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint axlReserved;

    /// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA.axlNumAxes"]/*' />
    [NativeTypeName("DWORD")]
    public uint axlNumAxes;

    /// <include file='AXESLISTA.xml' path='doc/member[@name="AXESLISTA.axlAxisInfo"]/*' />
    [NativeTypeName("AXISINFOA[16]")]
    public _axlAxisInfo_e__FixedBuffer axlAxisInfo;

    /// <include file='_axlAxisInfo_e__FixedBuffer.xml' path='doc/member[@name="_axlAxisInfo_e__FixedBuffer"]/*' />
    public partial struct _axlAxisInfo_e__FixedBuffer
    {
        public AXISINFOA e0;
        public AXISINFOA e1;
        public AXISINFOA e2;
        public AXISINFOA e3;
        public AXISINFOA e4;
        public AXISINFOA e5;
        public AXISINFOA e6;
        public AXISINFOA e7;
        public AXISINFOA e8;
        public AXISINFOA e9;
        public AXISINFOA e10;
        public AXISINFOA e11;
        public AXISINFOA e12;
        public AXISINFOA e13;
        public AXISINFOA e14;
        public AXISINFOA e15;

        [UnscopedRef]
        public ref AXISINFOA this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<AXISINFOA> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}
