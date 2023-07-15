// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='EMRPOLYPOLYLINE.xml' path='doc/member[@name="EMRPOLYPOLYLINE"]/*'/>
public unsafe partial struct EMRPOLYPOLYLINE
{
    /// <include file='EMRPOLYPOLYLINE.xml' path='doc/member[@name="EMRPOLYPOLYLINE.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRPOLYPOLYLINE.xml' path='doc/member[@name="EMRPOLYPOLYLINE.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='EMRPOLYPOLYLINE.xml' path='doc/member[@name="EMRPOLYPOLYLINE.nPolys"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nPolys;
    /// <include file='EMRPOLYPOLYLINE.xml' path='doc/member[@name="EMRPOLYPOLYLINE.cptl"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cptl;
    /// <include file='EMRPOLYPOLYLINE.xml' path='doc/member[@name="EMRPOLYPOLYLINE.aPolyCounts"]/*'/>
    [NativeTypeName("DWORD[1]")]
    public fixed uint aPolyCounts[1];
    /// <include file='EMRPOLYPOLYLINE.xml' path='doc/member[@name="EMRPOLYPOLYLINE.aptl"]/*'/>
    [NativeTypeName("POINTL[1]")]
    public _aptl_e__FixedBuffer aptl;
    /// <include file='_aptl_e__FixedBuffer.xml' path='doc/member[@name="_aptl_e__FixedBuffer"]/*'/>
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