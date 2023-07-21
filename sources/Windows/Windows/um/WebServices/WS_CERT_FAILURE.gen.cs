// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WS_CERT_FAILURE
{
    public const int WS_CERT_FAILURE_CN_MISMATCH = 0x1;
    public const int WS_CERT_FAILURE_INVALID_DATE = 0x2;
    public const int WS_CERT_FAILURE_UNTRUSTED_ROOT = 0x4;
    public const int WS_CERT_FAILURE_WRONG_USAGE = 0x8;
    public const int WS_CERT_FAILURE_REVOCATION_OFFLINE = 0x10;
}
