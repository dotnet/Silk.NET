// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRINVERTRGN.xml' path='doc/member[@name="EMRINVERTRGN"]/*'/>
public unsafe partial struct EMRINVERTRGN
{
    /// <include file='EMRINVERTRGN.xml' path='doc/member[@name="EMRINVERTRGN.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRINVERTRGN.xml' path='doc/member[@name="EMRINVERTRGN.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='EMRINVERTRGN.xml' path='doc/member[@name="EMRINVERTRGN.cbRgnData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbRgnData;
    /// <include file='EMRINVERTRGN.xml' path='doc/member[@name="EMRINVERTRGN.RgnData"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte RgnData[1];
}