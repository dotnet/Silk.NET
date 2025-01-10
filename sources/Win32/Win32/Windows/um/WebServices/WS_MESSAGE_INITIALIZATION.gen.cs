// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_MESSAGE_INITIALIZATION
{
    WS_BLANK_MESSAGE = 0,
    WS_DUPLICATE_MESSAGE = 1,
    WS_REQUEST_MESSAGE = 2,
    WS_REPLY_MESSAGE = 3,
    WS_FAULT_MESSAGE = 4,
}
