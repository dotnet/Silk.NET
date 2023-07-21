// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS"]/*' />
public partial struct EMRSTRETCHDIBITS
{
    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.emr"]/*' />
    public EMR emr;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.xDest"]/*' />
    [NativeTypeName("LONG")]
    public int xDest;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.yDest"]/*' />
    [NativeTypeName("LONG")]
    public int yDest;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.xSrc"]/*' />
    [NativeTypeName("LONG")]
    public int xSrc;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.ySrc"]/*' />
    [NativeTypeName("LONG")]
    public int ySrc;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cxSrc"]/*' />
    [NativeTypeName("LONG")]
    public int cxSrc;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cySrc"]/*' />
    [NativeTypeName("LONG")]
    public int cySrc;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.offBmiSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint offBmiSrc;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cbBmiSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbBmiSrc;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.offBitsSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint offBitsSrc;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cbBitsSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbBitsSrc;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.iUsageSrc"]/*' />
    [NativeTypeName("DWORD")]
    public uint iUsageSrc;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.dwRop"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRop;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cxDest"]/*' />
    [NativeTypeName("LONG")]
    public int cxDest;

    /// <include file='EMRSTRETCHDIBITS.xml' path='doc/member[@name="EMRSTRETCHDIBITS.cyDest"]/*' />
    [NativeTypeName("LONG")]
    public int cyDest;
}
