// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WS_URL_FLAGS
{
    public const int WS_URL_FLAGS_ALLOW_HOST_WILDCARDS = 0x1;
    public const int WS_URL_FLAGS_NO_PATH_COLLAPSE = 0x2;
    public const int WS_URL_FLAGS_ZERO_TERMINATE = 0x4;
}
