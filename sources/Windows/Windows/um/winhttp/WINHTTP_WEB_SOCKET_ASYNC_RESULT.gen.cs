// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WINHTTP_WEB_SOCKET_ASYNC_RESULT.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_ASYNC_RESULT"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct WINHTTP_WEB_SOCKET_ASYNC_RESULT
{
    /// <include file='WINHTTP_WEB_SOCKET_ASYNC_RESULT.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_ASYNC_RESULT.AsyncResult"]/*' />
    public WINHTTP_ASYNC_RESULT AsyncResult;

    /// <include file='WINHTTP_WEB_SOCKET_ASYNC_RESULT.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_ASYNC_RESULT.Operation"]/*' />
    public WINHTTP_WEB_SOCKET_OPERATION Operation;
}
