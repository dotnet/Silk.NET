// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRGLSBOUNDEDRECORD.xml' path='doc/member[@name="EMRGLSBOUNDEDRECORD"]/*'/>
public unsafe partial struct EMRGLSBOUNDEDRECORD
{
    /// <include file='EMRGLSBOUNDEDRECORD.xml' path='doc/member[@name="EMRGLSBOUNDEDRECORD.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRGLSBOUNDEDRECORD.xml' path='doc/member[@name="EMRGLSBOUNDEDRECORD.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='EMRGLSBOUNDEDRECORD.xml' path='doc/member[@name="EMRGLSBOUNDEDRECORD.cbData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbData;
    /// <include file='EMRGLSBOUNDEDRECORD.xml' path='doc/member[@name="EMRGLSBOUNDEDRECORD.Data"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Data[1];
}