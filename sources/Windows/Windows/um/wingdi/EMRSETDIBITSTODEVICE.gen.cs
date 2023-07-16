// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE"]/*'/>
public partial struct EMRSETDIBITSTODEVICE
{
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.xDest"]/*'/>
    [NativeTypeName("LONG")]
    public int xDest;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.yDest"]/*'/>
    [NativeTypeName("LONG")]
    public int yDest;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.xSrc"]/*'/>
    [NativeTypeName("LONG")]
    public int xSrc;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.ySrc"]/*'/>
    [NativeTypeName("LONG")]
    public int ySrc;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.cxSrc"]/*'/>
    [NativeTypeName("LONG")]
    public int cxSrc;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.cySrc"]/*'/>
    [NativeTypeName("LONG")]
    public int cySrc;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.offBmiSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBmiSrc;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.cbBmiSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBmiSrc;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.offBitsSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBitsSrc;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.cbBitsSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBitsSrc;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.iUsageSrc"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iUsageSrc;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.iStartScan"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iStartScan;
    /// <include file='EMRSETDIBITSTODEVICE.xml' path='doc/member[@name="EMRSETDIBITSTODEVICE.cScans"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cScans;
}