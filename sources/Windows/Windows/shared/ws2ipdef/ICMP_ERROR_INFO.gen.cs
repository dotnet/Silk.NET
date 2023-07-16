// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='ICMP_ERROR_INFO.xml' path='doc/member[@name="ICMP_ERROR_INFO"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct ICMP_ERROR_INFO
{
    /// <include file='ICMP_ERROR_INFO.xml' path='doc/member[@name="ICMP_ERROR_INFO.srcaddress"]/*'/>
    public SOCKADDR_INET srcaddress;
    /// <include file='ICMP_ERROR_INFO.xml' path='doc/member[@name="ICMP_ERROR_INFO.protocol"]/*'/>
    public IPPROTO protocol;
    /// <include file='ICMP_ERROR_INFO.xml' path='doc/member[@name="ICMP_ERROR_INFO.type"]/*'/>
    [NativeTypeName("UINT8")]
    public byte type;
    /// <include file='ICMP_ERROR_INFO.xml' path='doc/member[@name="ICMP_ERROR_INFO.code"]/*'/>
    [NativeTypeName("UINT8")]
    public byte code;
}