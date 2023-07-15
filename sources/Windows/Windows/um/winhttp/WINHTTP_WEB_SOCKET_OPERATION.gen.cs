// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='WINHTTP_WEB_SOCKET_OPERATION.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_OPERATION"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum WINHTTP_WEB_SOCKET_OPERATION
{
    /// <include file='WINHTTP_WEB_SOCKET_OPERATION.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_OPERATION.WINHTTP_WEB_SOCKET_SEND_OPERATION"]/*'/>
    WINHTTP_WEB_SOCKET_SEND_OPERATION = 0,
    /// <include file='WINHTTP_WEB_SOCKET_OPERATION.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_OPERATION.WINHTTP_WEB_SOCKET_RECEIVE_OPERATION"]/*'/>
    WINHTTP_WEB_SOCKET_RECEIVE_OPERATION = 1,
    /// <include file='WINHTTP_WEB_SOCKET_OPERATION.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_OPERATION.WINHTTP_WEB_SOCKET_CLOSE_OPERATION"]/*'/>
    WINHTTP_WEB_SOCKET_CLOSE_OPERATION = 2,
    /// <include file='WINHTTP_WEB_SOCKET_OPERATION.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_OPERATION.WINHTTP_WEB_SOCKET_SHUTDOWN_OPERATION"]/*'/>
    WINHTTP_WEB_SOCKET_SHUTDOWN_OPERATION = 3,
}