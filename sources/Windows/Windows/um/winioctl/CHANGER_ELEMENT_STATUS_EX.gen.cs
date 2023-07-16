// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX"]/*'/>
public unsafe partial struct CHANGER_ELEMENT_STATUS_EX
{
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.Element"]/*'/>
    public CHANGER_ELEMENT Element;
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.SrcElementAddress"]/*'/>
    public CHANGER_ELEMENT SrcElementAddress;
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.ExceptionCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExceptionCode;
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.TargetId"]/*'/>
    public byte TargetId;
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.Lun"]/*'/>
    public byte Lun;
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.Reserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved;
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.PrimaryVolumeID"]/*'/>
    [NativeTypeName("BYTE[36]")]
    public fixed byte PrimaryVolumeID[36];
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.AlternateVolumeID"]/*'/>
    [NativeTypeName("BYTE[36]")]
    public fixed byte AlternateVolumeID[36];
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.VendorIdentification"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte VendorIdentification[8];
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.ProductIdentification"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte ProductIdentification[16];
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.SerialNumber"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte SerialNumber[32];
}