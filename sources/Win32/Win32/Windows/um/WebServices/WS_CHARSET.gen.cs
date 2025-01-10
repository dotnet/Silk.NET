// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_CHARSET
{
    WS_CHARSET_AUTO = 0,
    WS_CHARSET_UTF8 = 1,
    WS_CHARSET_UTF16LE = 2,
    WS_CHARSET_UTF16BE = 3,
}
