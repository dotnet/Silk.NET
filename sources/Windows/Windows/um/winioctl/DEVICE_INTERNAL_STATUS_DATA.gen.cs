// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA"]/*'/>
public unsafe partial struct DEVICE_INTERNAL_STATUS_DATA
{
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.T10VendorId"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong T10VendorId;
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.DataSet1Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataSet1Length;
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.DataSet2Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataSet2Length;
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.DataSet3Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataSet3Length;
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.DataSet4Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataSet4Length;
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.StatusDataVersion"]/*'/>
    public byte StatusDataVersion;
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.Reserved"]/*'/>
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved[3];
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.ReasonIdentifier"]/*'/>
    [NativeTypeName("BYTE[128]")]
    public fixed byte ReasonIdentifier[128];
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.StatusDataLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StatusDataLength;
    /// <include file='DEVICE_INTERNAL_STATUS_DATA.xml' path='doc/member[@name="DEVICE_INTERNAL_STATUS_DATA.StatusData"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte StatusData[1];
}