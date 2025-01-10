// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WS_HTTP_HEADER_AUTH_SCHEME
{
    public const int WS_HTTP_HEADER_AUTH_SCHEME_NONE = 0x1;
    public const int WS_HTTP_HEADER_AUTH_SCHEME_BASIC = 0x2;
    public const int WS_HTTP_HEADER_AUTH_SCHEME_DIGEST = 0x4;
    public const int WS_HTTP_HEADER_AUTH_SCHEME_NTLM = 0x8;
    public const int WS_HTTP_HEADER_AUTH_SCHEME_NEGOTIATE = 0x10;
    public const int WS_HTTP_HEADER_AUTH_SCHEME_PASSPORT = 0x20;
}
