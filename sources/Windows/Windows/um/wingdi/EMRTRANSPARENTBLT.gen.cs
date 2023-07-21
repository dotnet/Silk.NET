// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT"]/*' />
public partial struct EMRTRANSPARENTBLT
{
    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.emr"]/*' />
    public EMR emr;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.xDest"]/*' />
    [NativeTypeName("LONG")]
    public int xDest;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.yDest"]/*' />
    [NativeTypeName("LONG")]
    public int yDest;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cxDest"]/*' />
    [NativeTypeName("LONG")]
    public int cxDest;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cyDest"]/*' />
    [NativeTypeName("LONG")]
    public int cyDest;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.dwRop"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRop;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.xSrc"]/*' />
    [NativeTypeName("LONG")]
    public int xSrc;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.ySrc"]/*' />
    [NativeTypeName("LONG")]
    public int ySrc;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.xformSrc"]/*' />
    public XFORM xformSrc;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.crBkColorSrc"]/*' />
    public COLORREF crBkColorSrc;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.iUsageSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint iUsageSrc;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.offBmiSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint offBmiSrc;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cbBmiSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbBmiSrc;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.offBitsSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint offBitsSrc;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cbBitsSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbBitsSrc;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cxSrc"]/*' />
    [NativeTypeName("LONG")]
    public int cxSrc;

    /// <include file='EMRTRANSPARENTBLT.xml' path='doc/member[@name="EMRTRANSPARENTBLT.cySrc"]/*' />
    [NativeTypeName("LONG")]
    public int cySrc;
}
