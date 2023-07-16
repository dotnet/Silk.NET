// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NET_IF_RCV_ADDRESS_TYPE.xml' path='doc/member[@name="NET_IF_RCV_ADDRESS_TYPE"]/*'/>
public enum NET_IF_RCV_ADDRESS_TYPE
{
    /// <include file='NET_IF_RCV_ADDRESS_TYPE.xml' path='doc/member[@name="NET_IF_RCV_ADDRESS_TYPE.NET_IF_RCV_ADDRESS_TYPE_OTHER"]/*'/>
    NET_IF_RCV_ADDRESS_TYPE_OTHER = 1,
    /// <include file='NET_IF_RCV_ADDRESS_TYPE.xml' path='doc/member[@name="NET_IF_RCV_ADDRESS_TYPE.NET_IF_RCV_ADDRESS_TYPE_VOLATILE"]/*'/>
    NET_IF_RCV_ADDRESS_TYPE_VOLATILE = 2,
    /// <include file='NET_IF_RCV_ADDRESS_TYPE.xml' path='doc/member[@name="NET_IF_RCV_ADDRESS_TYPE.NET_IF_RCV_ADDRESS_TYPE_NON_VOLATILE"]/*'/>
    NET_IF_RCV_ADDRESS_TYPE_NON_VOLATILE = 3,
}