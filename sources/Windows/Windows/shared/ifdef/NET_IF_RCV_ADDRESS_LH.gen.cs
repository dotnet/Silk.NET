// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NET_IF_RCV_ADDRESS_LH.xml' path='doc/member[@name="NET_IF_RCV_ADDRESS_LH"]/*'/>
public partial struct NET_IF_RCV_ADDRESS_LH
{
    /// <include file='NET_IF_RCV_ADDRESS_LH.xml' path='doc/member[@name="NET_IF_RCV_ADDRESS_LH.ifRcvAddressType"]/*'/>
    public NET_IF_RCV_ADDRESS_TYPE ifRcvAddressType;
    /// <include file='NET_IF_RCV_ADDRESS_LH.xml' path='doc/member[@name="NET_IF_RCV_ADDRESS_LH.ifRcvAddressLength"]/*'/>
    public ushort ifRcvAddressLength;
    /// <include file='NET_IF_RCV_ADDRESS_LH.xml' path='doc/member[@name="NET_IF_RCV_ADDRESS_LH.ifRcvAddressOffset"]/*'/>
    public ushort ifRcvAddressOffset;
}