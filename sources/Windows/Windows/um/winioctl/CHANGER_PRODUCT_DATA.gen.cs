// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA"]/*'/>
public unsafe partial struct CHANGER_PRODUCT_DATA
{
    /// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA.VendorId"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte VendorId[8];
    /// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA.ProductId"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte ProductId[16];
    /// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA.Revision"]/*'/>
    [NativeTypeName("BYTE[4]")]
    public fixed byte Revision[4];
    /// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA.SerialNumber"]/*'/>
    [NativeTypeName("BYTE[32]")]
    public fixed byte SerialNumber[32];
    /// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA.DeviceType"]/*'/>
    public byte DeviceType;
}