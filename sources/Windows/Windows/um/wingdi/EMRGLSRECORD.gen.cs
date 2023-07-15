// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRGLSRECORD.xml' path='doc/member[@name="EMRGLSRECORD"]/*'/>
public unsafe partial struct EMRGLSRECORD
{
    /// <include file='EMRGLSRECORD.xml' path='doc/member[@name="EMRGLSRECORD.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRGLSRECORD.xml' path='doc/member[@name="EMRGLSRECORD.cbData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbData;
    /// <include file='EMRGLSRECORD.xml' path='doc/member[@name="EMRGLSRECORD.Data"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Data[1];
}