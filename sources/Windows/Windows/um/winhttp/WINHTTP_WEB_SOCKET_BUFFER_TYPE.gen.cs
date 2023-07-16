// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='WINHTTP_WEB_SOCKET_BUFFER_TYPE.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_BUFFER_TYPE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum WINHTTP_WEB_SOCKET_BUFFER_TYPE
{
    /// <include file='WINHTTP_WEB_SOCKET_BUFFER_TYPE.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_BUFFER_TYPE.WINHTTP_WEB_SOCKET_BINARY_MESSAGE_BUFFER_TYPE"]/*'/>
    WINHTTP_WEB_SOCKET_BINARY_MESSAGE_BUFFER_TYPE = 0,
    /// <include file='WINHTTP_WEB_SOCKET_BUFFER_TYPE.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_BUFFER_TYPE.WINHTTP_WEB_SOCKET_BINARY_FRAGMENT_BUFFER_TYPE"]/*'/>
    WINHTTP_WEB_SOCKET_BINARY_FRAGMENT_BUFFER_TYPE = 1,
    /// <include file='WINHTTP_WEB_SOCKET_BUFFER_TYPE.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_BUFFER_TYPE.WINHTTP_WEB_SOCKET_UTF8_MESSAGE_BUFFER_TYPE"]/*'/>
    WINHTTP_WEB_SOCKET_UTF8_MESSAGE_BUFFER_TYPE = 2,
    /// <include file='WINHTTP_WEB_SOCKET_BUFFER_TYPE.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_BUFFER_TYPE.WINHTTP_WEB_SOCKET_UTF8_FRAGMENT_BUFFER_TYPE"]/*'/>
    WINHTTP_WEB_SOCKET_UTF8_FRAGMENT_BUFFER_TYPE = 3,
    /// <include file='WINHTTP_WEB_SOCKET_BUFFER_TYPE.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_BUFFER_TYPE.WINHTTP_WEB_SOCKET_CLOSE_BUFFER_TYPE"]/*'/>
    WINHTTP_WEB_SOCKET_CLOSE_BUFFER_TYPE = 4,
}