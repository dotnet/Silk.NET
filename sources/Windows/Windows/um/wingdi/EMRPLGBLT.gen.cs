// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT"]/*'/>
public partial struct EMRPLGBLT
{
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.aptlDest"]/*'/>
    [NativeTypeName("POINTL[3]")]
    public _aptlDest_e__FixedBuffer aptlDest;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.xSrc"]/*'/>
    [NativeTypeName("LONG")]
    public int xSrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.ySrc"]/*'/>
    [NativeTypeName("LONG")]
    public int ySrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cxSrc"]/*'/>
    [NativeTypeName("LONG")]
    public int cxSrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cySrc"]/*'/>
    [NativeTypeName("LONG")]
    public int cySrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.xformSrc"]/*'/>
    public XFORM xformSrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.crBkColorSrc"]/*'/>
    public COLORREF crBkColorSrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.iUsageSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iUsageSrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.offBmiSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBmiSrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cbBmiSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBmiSrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.offBitsSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBitsSrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cbBitsSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBitsSrc;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.xMask"]/*'/>
    [NativeTypeName("LONG")]
    public int xMask;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.yMask"]/*'/>
    [NativeTypeName("LONG")]
    public int yMask;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.iUsageMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iUsageMask;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.offBmiMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBmiMask;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cbBmiMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBmiMask;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.offBitsMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBitsMask;
    /// <include file='EMRPLGBLT.xml' path='doc/member[@name="EMRPLGBLT.cbBitsMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBitsMask;
    /// <include file='_aptlDest_e__FixedBuffer.xml' path='doc/member[@name="_aptlDest_e__FixedBuffer"]/*'/>
    public partial struct _aptlDest_e__FixedBuffer
    {
        public POINTL e0;
        public POINTL e1;
        public POINTL e2;
        [UnscopedRef]
        public ref POINTL this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<POINTL> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
    }
}