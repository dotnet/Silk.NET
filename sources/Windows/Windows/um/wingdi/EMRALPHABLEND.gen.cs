// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND"]/*'/>
public partial struct EMRALPHABLEND
{
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.xDest"]/*'/>
    [NativeTypeName("LONG")]
    public int xDest;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.yDest"]/*'/>
    [NativeTypeName("LONG")]
    public int yDest;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cxDest"]/*'/>
    [NativeTypeName("LONG")]
    public int cxDest;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cyDest"]/*'/>
    [NativeTypeName("LONG")]
    public int cyDest;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.dwRop"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRop;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.xSrc"]/*'/>
    [NativeTypeName("LONG")]
    public int xSrc;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.ySrc"]/*'/>
    [NativeTypeName("LONG")]
    public int ySrc;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.xformSrc"]/*'/>
    public XFORM xformSrc;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.crBkColorSrc"]/*'/>
    public COLORREF crBkColorSrc;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.iUsageSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iUsageSrc;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.offBmiSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBmiSrc;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cbBmiSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBmiSrc;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.offBitsSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBitsSrc;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cbBitsSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBitsSrc;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cxSrc"]/*'/>
    [NativeTypeName("LONG")]
    public int cxSrc;
    /// <include file='EMRALPHABLEND.xml' path='doc/member[@name="EMRALPHABLEND.cySrc"]/*'/>
    [NativeTypeName("LONG")]
    public int cySrc;
}