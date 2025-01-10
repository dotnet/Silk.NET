// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HTTP_REQUEST_TIMING_TYPE
{
    HttpRequestTimingTypeConnectionStart,
    HttpRequestTimingTypeDataStart,
    HttpRequestTimingTypeTlsCertificateLoadStart,
    HttpRequestTimingTypeTlsCertificateLoadEnd,
    HttpRequestTimingTypeTlsHandshakeLeg1Start,
    HttpRequestTimingTypeTlsHandshakeLeg1End,
    HttpRequestTimingTypeTlsHandshakeLeg2Start,
    HttpRequestTimingTypeTlsHandshakeLeg2End,
    HttpRequestTimingTypeTlsAttributesQueryStart,
    HttpRequestTimingTypeTlsAttributesQueryEnd,
    HttpRequestTimingTypeTlsClientCertQueryStart,
    HttpRequestTimingTypeTlsClientCertQueryEnd,
    HttpRequestTimingTypeHttp2StreamStart,
    HttpRequestTimingTypeHttp2HeaderDecodeStart,
    HttpRequestTimingTypeHttp2HeaderDecodeEnd,
    HttpRequestTimingTypeRequestHeaderParseStart,
    HttpRequestTimingTypeRequestHeaderParseEnd,
    HttpRequestTimingTypeRequestRoutingStart,
    HttpRequestTimingTypeRequestRoutingEnd,
    HttpRequestTimingTypeRequestQueuedForInspection,
    HttpRequestTimingTypeRequestDeliveredForInspection,
    HttpRequestTimingTypeRequestReturnedAfterInspection,
    HttpRequestTimingTypeRequestQueuedForDelegation,
    HttpRequestTimingTypeRequestDeliveredForDelegation,
    HttpRequestTimingTypeRequestReturnedAfterDelegation,
    HttpRequestTimingTypeRequestQueuedForIO,
    HttpRequestTimingTypeRequestDeliveredForIO,
    HttpRequestTimingTypeHttp3StreamStart,
    HttpRequestTimingTypeHttp3HeaderDecodeStart,
    HttpRequestTimingTypeHttp3HeaderDecodeEnd,
    HttpRequestTimingTypeMax,
}
