// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SOCKET_ADDRESS.xml' path='doc/member[@name="SOCKET_ADDRESS"]/*'/>
public unsafe partial struct SOCKET_ADDRESS
{
    /// <include file='SOCKET_ADDRESS.xml' path='doc/member[@name="SOCKET_ADDRESS.lpSockaddr"]/*'/>
    [NativeTypeName("LPSOCKADDR")]
    public SOCKADDR* lpSockaddr;
    /// <include file='SOCKET_ADDRESS.xml' path='doc/member[@name="SOCKET_ADDRESS.iSockaddrLength"]/*'/>
    public int iSockaddrLength;
}