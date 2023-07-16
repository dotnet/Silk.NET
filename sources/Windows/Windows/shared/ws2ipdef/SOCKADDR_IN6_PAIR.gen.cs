// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SOCKADDR_IN6_PAIR.xml' path='doc/member[@name="SOCKADDR_IN6_PAIR"]/*'/>
public unsafe partial struct SOCKADDR_IN6_PAIR
{
    /// <include file='SOCKADDR_IN6_PAIR.xml' path='doc/member[@name="SOCKADDR_IN6_PAIR.SourceAddress"]/*'/>
    [NativeTypeName("PSOCKADDR_IN6")]
    public SOCKADDR_IN6* SourceAddress;
    /// <include file='SOCKADDR_IN6_PAIR.xml' path='doc/member[@name="SOCKADDR_IN6_PAIR.DestinationAddress"]/*'/>
    [NativeTypeName("PSOCKADDR_IN6")]
    public SOCKADDR_IN6* DestinationAddress;
}