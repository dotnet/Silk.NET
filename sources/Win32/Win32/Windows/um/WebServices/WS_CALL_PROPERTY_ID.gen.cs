// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_CALL_PROPERTY_ID
{
    WS_CALL_PROPERTY_CHECK_MUST_UNDERSTAND = 0,
    WS_CALL_PROPERTY_SEND_MESSAGE_CONTEXT = 1,
    WS_CALL_PROPERTY_RECEIVE_MESSAGE_CONTEXT = 2,
    WS_CALL_PROPERTY_CALL_ID = 3,
}
