// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HTTP_FEATURE_ID
{
    HttpFeatureUnknown = 0,
    HttpFeatureResponseTrailers = 1,
    HttpFeatureApiTimings = 2,
    HttpFeatureDelegateEx = 3,
    HttpFeatureHttp3 = 4,
    HttpFeatureTlsSessionTickets = 5,
    HttpFeatureDisableTlsSessionId = 6,
    HttpFeatureTlsDualCerts = 7,
    HttpFeatureAutomaticChunkedEncoding = 8,
    HttpFeatureDedicatedReqQueueDelegationType = 9,
    HttpFeatureFastForwardResponse = 10,
    HttpFeatureCacheTlsClientHello = 11,
    HttpFeatureLast = 12,
    HttpFeaturemax = unchecked((int)(0xFFFFFFFF)),
}
