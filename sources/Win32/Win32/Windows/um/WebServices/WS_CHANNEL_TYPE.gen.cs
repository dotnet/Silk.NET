// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum WS_CHANNEL_TYPE
{
    WS_CHANNEL_TYPE_INPUT = 0x1,
    WS_CHANNEL_TYPE_OUTPUT = 0x2,
    WS_CHANNEL_TYPE_SESSION = 0x4,
    WS_CHANNEL_TYPE_INPUT_SESSION = (WS_CHANNEL_TYPE_INPUT | WS_CHANNEL_TYPE_SESSION),
    WS_CHANNEL_TYPE_OUTPUT_SESSION = (WS_CHANNEL_TYPE_OUTPUT | WS_CHANNEL_TYPE_SESSION),
    WS_CHANNEL_TYPE_DUPLEX = (WS_CHANNEL_TYPE_INPUT | WS_CHANNEL_TYPE_OUTPUT),
    WS_CHANNEL_TYPE_DUPLEX_SESSION =
        (WS_CHANNEL_TYPE_INPUT | WS_CHANNEL_TYPE_OUTPUT | WS_CHANNEL_TYPE_SESSION),
    WS_CHANNEL_TYPE_REQUEST = 0x8,
    WS_CHANNEL_TYPE_REPLY = 0x10,
}
