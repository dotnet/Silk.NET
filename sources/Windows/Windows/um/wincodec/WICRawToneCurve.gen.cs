// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='WICRawToneCurve.xml' path='doc/member[@name="WICRawToneCurve"]/*'/>
public partial struct WICRawToneCurve
{
    /// <include file='WICRawToneCurve.xml' path='doc/member[@name="WICRawToneCurve.cPoints"]/*'/>
    public uint cPoints;
    /// <include file='WICRawToneCurve.xml' path='doc/member[@name="WICRawToneCurve.aPoints"]/*'/>
    [NativeTypeName("WICRawToneCurvePoint[1]")]
    public _aPoints_e__FixedBuffer aPoints;
    /// <include file='_aPoints_e__FixedBuffer.xml' path='doc/member[@name="_aPoints_e__FixedBuffer"]/*'/>
    public partial struct _aPoints_e__FixedBuffer
    {
        public WICRawToneCurvePoint e0;
        [UnscopedRef]
        public ref WICRawToneCurvePoint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<WICRawToneCurvePoint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}