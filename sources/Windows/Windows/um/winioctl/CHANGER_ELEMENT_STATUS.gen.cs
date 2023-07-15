// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CHANGER_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS"]/*'/>
public unsafe partial struct CHANGER_ELEMENT_STATUS
{
    /// <include file='CHANGER_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS.Element"]/*'/>
    public CHANGER_ELEMENT Element;
    /// <include file='CHANGER_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS.SrcElementAddress"]/*'/>
    public CHANGER_ELEMENT SrcElementAddress;
    /// <include file='CHANGER_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='CHANGER_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS.ExceptionCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExceptionCode;
    /// <include file='CHANGER_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS.TargetId"]/*'/>
    public byte TargetId;
    /// <include file='CHANGER_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS.Lun"]/*'/>
    public byte Lun;
    /// <include file='CHANGER_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS.Reserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved;
    /// <include file='CHANGER_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS.PrimaryVolumeID"]/*'/>
    [NativeTypeName("BYTE[36]")]
    public fixed byte PrimaryVolumeID[36];
    /// <include file='CHANGER_ELEMENT_STATUS.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS.AlternateVolumeID"]/*'/>
    [NativeTypeName("BYTE[36]")]
    public fixed byte AlternateVolumeID[36];
}