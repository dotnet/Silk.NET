// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_PROXY_PROPERTY_ID
{
    WS_PROXY_PROPERTY_CALL_TIMEOUT = 0,
    WS_PROXY_PROPERTY_MESSAGE_PROPERTIES = 1,
    WS_PROXY_PROPERTY_MAX_CALL_POOL_SIZE = 2,
    WS_PROXY_PROPERTY_STATE = 3,
    WS_PROXY_PROPERTY_MAX_PENDING_CALLS = 4,
    WS_PROXY_PROPERTY_MAX_CLOSE_TIMEOUT = 5,
    WS_PROXY_FAULT_LANG_ID = 6,
}
