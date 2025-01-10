// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_URL_SCHEME_TYPE
{
    WS_URL_HTTP_SCHEME_TYPE = 0,
    WS_URL_HTTPS_SCHEME_TYPE = 1,
    WS_URL_NETTCP_SCHEME_TYPE = 2,
    WS_URL_SOAPUDP_SCHEME_TYPE = 3,
    WS_URL_NETPIPE_SCHEME_TYPE = 4,
}
