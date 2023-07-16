// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NET_ADDRESS_FORMAT.xml' path='doc/member[@name="NET_ADDRESS_FORMAT"]/*'/>
public enum NET_ADDRESS_FORMAT
{
    /// <include file='NET_ADDRESS_FORMAT.xml' path='doc/member[@name="NET_ADDRESS_FORMAT.NET_ADDRESS_FORMAT_UNSPECIFIED"]/*'/>
    NET_ADDRESS_FORMAT_UNSPECIFIED = 0,
    /// <include file='NET_ADDRESS_FORMAT.xml' path='doc/member[@name="NET_ADDRESS_FORMAT.NET_ADDRESS_DNS_NAME"]/*'/>
    NET_ADDRESS_DNS_NAME,
    /// <include file='NET_ADDRESS_FORMAT.xml' path='doc/member[@name="NET_ADDRESS_FORMAT.NET_ADDRESS_IPV4"]/*'/>
    NET_ADDRESS_IPV4,
    /// <include file='NET_ADDRESS_FORMAT.xml' path='doc/member[@name="NET_ADDRESS_FORMAT.NET_ADDRESS_IPV6"]/*'/>
    NET_ADDRESS_IPV6,
}