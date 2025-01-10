// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum WS_SECURE_PROTOCOL
{
    WS_SECURE_PROTOCOL_SSL2 = 0x1,
    WS_SECURE_PROTOCOL_SSL3 = 0x2,
    WS_SECURE_PROTOCOL_TLS1_0 = 0x4,
    WS_SECURE_PROTOCOL_TLS1_1 = 0x8,
    WS_SECURE_PROTOCOL_TLS1_2 = 0x10,
}
