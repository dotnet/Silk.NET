// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT"]/*' />
public partial struct EMRBITBLT
{
    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.emr"]/*' />
    public EMR emr;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.xDest"]/*' />
    [NativeTypeName("LONG")]
    public int xDest;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.yDest"]/*' />
    [NativeTypeName("LONG")]
    public int yDest;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.cxDest"]/*' />
    [NativeTypeName("LONG")]
    public int cxDest;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.cyDest"]/*' />
    [NativeTypeName("LONG")]
    public int cyDest;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.dwRop"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRop;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.xSrc"]/*' />
    [NativeTypeName("LONG")]
    public int xSrc;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.ySrc"]/*' />
    [NativeTypeName("LONG")]
    public int ySrc;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.xformSrc"]/*' />
    public XFORM xformSrc;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.crBkColorSrc"]/*' />
    public COLORREF crBkColorSrc;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.iUsageSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint iUsageSrc;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.offBmiSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint offBmiSrc;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.cbBmiSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbBmiSrc;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.offBitsSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint offBitsSrc;

    /// <include file='EMRBITBLT.xml' path='doc/member[@name="EMRBITBLT.cbBitsSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbBitsSrc;
}
