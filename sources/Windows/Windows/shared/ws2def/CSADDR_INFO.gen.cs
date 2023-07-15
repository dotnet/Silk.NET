// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CSADDR_INFO.xml' path='doc/member[@name="CSADDR_INFO"]/*'/>
public partial struct CSADDR_INFO
{
    /// <include file='CSADDR_INFO.xml' path='doc/member[@name="CSADDR_INFO.LocalAddr"]/*'/>
    public SOCKET_ADDRESS LocalAddr;
    /// <include file='CSADDR_INFO.xml' path='doc/member[@name="CSADDR_INFO.RemoteAddr"]/*'/>
    public SOCKET_ADDRESS RemoteAddr;
    /// <include file='CSADDR_INFO.xml' path='doc/member[@name="CSADDR_INFO.iSocketType"]/*'/>
    public int iSocketType;
    /// <include file='CSADDR_INFO.xml' path='doc/member[@name="CSADDR_INFO.iProtocol"]/*'/>
    public int iProtocol;
}