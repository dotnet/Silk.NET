// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT"]/*'/>
public partial struct EMRSTRETCHBLT
{
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.xDest"]/*'/>
    [NativeTypeName("LONG")]
    public int xDest;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.yDest"]/*'/>
    [NativeTypeName("LONG")]
    public int yDest;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.cxDest"]/*'/>
    [NativeTypeName("LONG")]
    public int cxDest;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.cyDest"]/*'/>
    [NativeTypeName("LONG")]
    public int cyDest;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.dwRop"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRop;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.xSrc"]/*'/>
    [NativeTypeName("LONG")]
    public int xSrc;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.ySrc"]/*'/>
    [NativeTypeName("LONG")]
    public int ySrc;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.xformSrc"]/*'/>
    public XFORM xformSrc;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.crBkColorSrc"]/*'/>
    public COLORREF crBkColorSrc;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.iUsageSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iUsageSrc;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.offBmiSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBmiSrc;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.cbBmiSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBmiSrc;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.offBitsSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBitsSrc;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.cbBitsSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBitsSrc;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.cxSrc"]/*'/>
    [NativeTypeName("LONG")]
    public int cxSrc;
    /// <include file='EMRSTRETCHBLT.xml' path='doc/member[@name="EMRSTRETCHBLT.cySrc"]/*'/>
    [NativeTypeName("LONG")]
    public int cySrc;
}