// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WS_MATCH_URL
{
    public const int WS_MATCH_URL_DNS_HOST = 0x1;
    public const int WS_MATCH_URL_DNS_FULLY_QUALIFIED_HOST = 0x2;
    public const int WS_MATCH_URL_NETBIOS_HOST = 0x4;
    public const int WS_MATCH_URL_LOCAL_HOST = 0x8;
    public const int WS_MATCH_URL_HOST_ADDRESSES = 0x10;
    public const int WS_MATCH_URL_THIS_HOST = (WS_MATCH_URL_DNS_HOST | WS_MATCH_URL_DNS_FULLY_QUALIFIED_HOST | WS_MATCH_URL_NETBIOS_HOST | WS_MATCH_URL_LOCAL_HOST | WS_MATCH_URL_HOST_ADDRESSES);
    public const int WS_MATCH_URL_PORT = 0x20;
    public const int WS_MATCH_URL_EXACT_PATH = 0x40;
    public const int WS_MATCH_URL_PREFIX_PATH = 0x80;
    public const int WS_MATCH_URL_NO_QUERY = 0x100;
}
