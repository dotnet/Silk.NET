// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HTTP_SERVER_PROPERTY
{
    HttpServerAuthenticationProperty = 0,
    HttpServerLoggingProperty = 1,
    HttpServerQosProperty = 2,
    HttpServerTimeoutsProperty = 3,
    HttpServerQueueLengthProperty = 4,
    HttpServerStateProperty = 5,
    HttpServer503VerbosityProperty = 6,
    HttpServerBindingProperty = 7,
    HttpServerExtendedAuthenticationProperty = 8,
    HttpServerListenEndpointProperty = 9,
    HttpServerChannelBindProperty = 10,
    HttpServerProtectionLevelProperty = 11,
    HttpServerDelegationProperty = 16,
    HttpServerFastForwardingProperty = 18,
}
