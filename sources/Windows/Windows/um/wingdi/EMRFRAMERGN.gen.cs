// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN"]/*'/>
public unsafe partial struct EMRFRAMERGN
{
    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.cbRgnData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbRgnData;
    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.ihBrush"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ihBrush;
    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.szlStroke"]/*'/>
    [NativeTypeName("SIZEL")]
    public SIZE szlStroke;
    /// <include file='EMRFRAMERGN.xml' path='doc/member[@name="EMRFRAMERGN.RgnData"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte RgnData[1];
}