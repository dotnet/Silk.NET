// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='AXESLISTW.xml' path='doc/member[@name="AXESLISTW"]/*'/>
public partial struct AXESLISTW
{
    /// <include file='AXESLISTW.xml' path='doc/member[@name="AXESLISTW.axlReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint axlReserved;
    /// <include file='AXESLISTW.xml' path='doc/member[@name="AXESLISTW.axlNumAxes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint axlNumAxes;
    /// <include file='AXESLISTW.xml' path='doc/member[@name="AXESLISTW.axlAxisInfo"]/*'/>
    [NativeTypeName("AXISINFOW[16]")]
    public _axlAxisInfo_e__FixedBuffer axlAxisInfo;
    /// <include file='_axlAxisInfo_e__FixedBuffer.xml' path='doc/member[@name="_axlAxisInfo_e__FixedBuffer"]/*'/>
    public partial struct _axlAxisInfo_e__FixedBuffer
    {
        public AXISINFOW e0;
        public AXISINFOW e1;
        public AXISINFOW e2;
        public AXISINFOW e3;
        public AXISINFOW e4;
        public AXISINFOW e5;
        public AXISINFOW e6;
        public AXISINFOW e7;
        public AXISINFOW e8;
        public AXISINFOW e9;
        public AXISINFOW e10;
        public AXISINFOW e11;
        public AXISINFOW e12;
        public AXISINFOW e13;
        public AXISINFOW e14;
        public AXISINFOW e15;
        [UnscopedRef]
        public ref AXISINFOW this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<AXISINFOW> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}