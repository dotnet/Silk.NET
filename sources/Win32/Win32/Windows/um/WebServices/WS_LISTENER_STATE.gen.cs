// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_LISTENER_STATE
{
    WS_LISTENER_STATE_CREATED = 0,
    WS_LISTENER_STATE_OPENING = 1,
    WS_LISTENER_STATE_OPEN = 2,
    WS_LISTENER_STATE_FAULTED = 3,
    WS_LISTENER_STATE_CLOSING = 4,
    WS_LISTENER_STATE_CLOSED = 5,
}
