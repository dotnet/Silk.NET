// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY"]/*' />
[SupportedOSPlatform("windows10.0.18362.0")]
public enum WINHTTP_REQUEST_TIME_ENTRY
{
    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpProxyDetectionStart"]/*' />
    WinHttpProxyDetectionStart = 0,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpProxyDetectionEnd"]/*' />
    WinHttpProxyDetectionEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpConnectionAcquireStart"]/*' />
    WinHttpConnectionAcquireStart,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpConnectionAcquireWaitEnd"]/*' />
    WinHttpConnectionAcquireWaitEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpConnectionAcquireEnd"]/*' />
    WinHttpConnectionAcquireEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpNameResolutionStart"]/*' />
    WinHttpNameResolutionStart,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpNameResolutionEnd"]/*' />
    WinHttpNameResolutionEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpConnectionEstablishmentStart"]/*' />
    WinHttpConnectionEstablishmentStart,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpConnectionEstablishmentEnd"]/*' />
    WinHttpConnectionEstablishmentEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpTlsHandshakeClientLeg1Start"]/*' />
    WinHttpTlsHandshakeClientLeg1Start,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpTlsHandshakeClientLeg1End"]/*' />
    WinHttpTlsHandshakeClientLeg1End,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpTlsHandshakeClientLeg2Start"]/*' />
    WinHttpTlsHandshakeClientLeg2Start,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpTlsHandshakeClientLeg2End"]/*' />
    WinHttpTlsHandshakeClientLeg2End,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpTlsHandshakeClientLeg3Start"]/*' />
    WinHttpTlsHandshakeClientLeg3Start,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpTlsHandshakeClientLeg3End"]/*' />
    WinHttpTlsHandshakeClientLeg3End,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpStreamWaitStart"]/*' />
    WinHttpStreamWaitStart,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpStreamWaitEnd"]/*' />
    WinHttpStreamWaitEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpSendRequestStart"]/*' />
    WinHttpSendRequestStart,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpSendRequestHeadersCompressionStart"]/*' />
    WinHttpSendRequestHeadersCompressionStart,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpSendRequestHeadersCompressionEnd"]/*' />
    WinHttpSendRequestHeadersCompressionEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpSendRequestHeadersEnd"]/*' />
    WinHttpSendRequestHeadersEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpSendRequestEnd"]/*' />
    WinHttpSendRequestEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpReceiveResponseStart"]/*' />
    WinHttpReceiveResponseStart,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpReceiveResponseHeadersDecompressionStart"]/*' />
    WinHttpReceiveResponseHeadersDecompressionStart,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpReceiveResponseHeadersDecompressionEnd"]/*' />
    WinHttpReceiveResponseHeadersDecompressionEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpReceiveResponseHeadersEnd"]/*' />
    WinHttpReceiveResponseHeadersEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpReceiveResponseBodyDecompressionDelta"]/*' />
    WinHttpReceiveResponseBodyDecompressionDelta,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpReceiveResponseEnd"]/*' />
    WinHttpReceiveResponseEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpProxyTunnelStart"]/*' />
    WinHttpProxyTunnelStart,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpProxyTunnelEnd"]/*' />
    WinHttpProxyTunnelEnd,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpProxyTlsHandshakeClientLeg1Start"]/*' />
    WinHttpProxyTlsHandshakeClientLeg1Start,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpProxyTlsHandshakeClientLeg1End"]/*' />
    WinHttpProxyTlsHandshakeClientLeg1End,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpProxyTlsHandshakeClientLeg2Start"]/*' />
    WinHttpProxyTlsHandshakeClientLeg2Start,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpProxyTlsHandshakeClientLeg2End"]/*' />
    WinHttpProxyTlsHandshakeClientLeg2End,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpProxyTlsHandshakeClientLeg3Start"]/*' />
    WinHttpProxyTlsHandshakeClientLeg3Start,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpProxyTlsHandshakeClientLeg3End"]/*' />
    WinHttpProxyTlsHandshakeClientLeg3End,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpRequestTimeLast"]/*' />
    WinHttpRequestTimeLast,

    /// <include file='WINHTTP_REQUEST_TIME_ENTRY.xml' path='doc/member[@name="WINHTTP_REQUEST_TIME_ENTRY.WinHttpRequestTimeMax"]/*' />
    WinHttpRequestTimeMax = 64,
}
