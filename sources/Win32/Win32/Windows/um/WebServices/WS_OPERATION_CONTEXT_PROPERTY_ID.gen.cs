// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_OPERATION_CONTEXT_PROPERTY_ID
{
    WS_OPERATION_CONTEXT_PROPERTY_CHANNEL = 0,
    WS_OPERATION_CONTEXT_PROPERTY_CONTRACT_DESCRIPTION = 1,
    WS_OPERATION_CONTEXT_PROPERTY_HOST_USER_STATE = 2,
    WS_OPERATION_CONTEXT_PROPERTY_CHANNEL_USER_STATE = 3,
    WS_OPERATION_CONTEXT_PROPERTY_INPUT_MESSAGE = 4,
    WS_OPERATION_CONTEXT_PROPERTY_OUTPUT_MESSAGE = 5,
    WS_OPERATION_CONTEXT_PROPERTY_HEAP = 6,
    WS_OPERATION_CONTEXT_PROPERTY_LISTENER = 7,
    WS_OPERATION_CONTEXT_PROPERTY_ENDPOINT_ADDRESS = 8,
}
