// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY"]/*'/>
[SupportedOSPlatform("windows10.0.18362.0")]
public enum WINHTTP_REQUEST_STAT_ENTRY
{
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpConnectFailureCount"]/*'/>
    WinHttpConnectFailureCount = 0,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpProxyFailureCount"]/*'/>
    WinHttpProxyFailureCount,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpTlsHandshakeClientLeg1Size"]/*'/>
    WinHttpTlsHandshakeClientLeg1Size,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpTlsHandshakeServerLeg1Size"]/*'/>
    WinHttpTlsHandshakeServerLeg1Size,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpTlsHandshakeClientLeg2Size"]/*'/>
    WinHttpTlsHandshakeClientLeg2Size,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpTlsHandshakeServerLeg2Size"]/*'/>
    WinHttpTlsHandshakeServerLeg2Size,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpRequestHeadersSize"]/*'/>
    WinHttpRequestHeadersSize,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpRequestHeadersCompressedSize"]/*'/>
    WinHttpRequestHeadersCompressedSize,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpResponseHeadersSize"]/*'/>
    WinHttpResponseHeadersSize,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpResponseHeadersCompressedSize"]/*'/>
    WinHttpResponseHeadersCompressedSize,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpResponseBodySize"]/*'/>
    WinHttpResponseBodySize,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpResponseBodyCompressedSize"]/*'/>
    WinHttpResponseBodyCompressedSize,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpProxyTlsHandshakeClientLeg1Size"]/*'/>
    WinHttpProxyTlsHandshakeClientLeg1Size,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpProxyTlsHandshakeServerLeg1Size"]/*'/>
    WinHttpProxyTlsHandshakeServerLeg1Size,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpProxyTlsHandshakeClientLeg2Size"]/*'/>
    WinHttpProxyTlsHandshakeClientLeg2Size,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpProxyTlsHandshakeServerLeg2Size"]/*'/>
    WinHttpProxyTlsHandshakeServerLeg2Size,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpRequestStatLast"]/*'/>
    WinHttpRequestStatLast,
    /// <include file='WINHTTP_REQUEST_STAT_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_STAT_ENTRY.WinHttpRequestStatMax"]/*'/>
    WinHttpRequestStatMax = 32,
}