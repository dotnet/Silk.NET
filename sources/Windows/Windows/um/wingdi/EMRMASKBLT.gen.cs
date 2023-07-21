// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT"]/*' />
public partial struct EMRMASKBLT
{
    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.emr"]/*' />
    public EMR emr;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.xDest"]/*' />
    [NativeTypeName("LONG")]
    public int xDest;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.yDest"]/*' />
    [NativeTypeName("LONG")]
    public int yDest;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cxDest"]/*' />
    [NativeTypeName("LONG")]
    public int cxDest;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cyDest"]/*' />
    [NativeTypeName("LONG")]
    public int cyDest;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.dwRop"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRop;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.xSrc"]/*' />
    [NativeTypeName("LONG")]
    public int xSrc;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.ySrc"]/*' />
    [NativeTypeName("LONG")]
    public int ySrc;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.xformSrc"]/*' />
    public XFORM xformSrc;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.crBkColorSrc"]/*' />
    public COLORREF crBkColorSrc;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.iUsageSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint iUsageSrc;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.offBmiSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint offBmiSrc;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cbBmiSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbBmiSrc;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.offBitsSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint offBitsSrc;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cbBitsSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbBitsSrc;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.xMask"]/*' />
    [NativeTypeName("LONG")]
    public int xMask;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.yMask"]/*' />
    [NativeTypeName("LONG")]
    public int yMask;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.iUsageMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint iUsageMask;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.offBmiMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint offBmiMask;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cbBmiMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbBmiMask;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.offBitsMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint offBitsMask;

    /// <include file='EMRMASKBLT.xml' path='doc/member[@name="EMRMASKBLT.cbBitsMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbBitsMask;
}
