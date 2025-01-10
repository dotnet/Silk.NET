// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_SERVICE_PROPERTY_ID
{
    WS_SERVICE_PROPERTY_HOST_USER_STATE = 0,
    WS_SERVICE_PROPERTY_FAULT_DISCLOSURE = 1,
    WS_SERVICE_PROPERTY_FAULT_LANGID = 2,
    WS_SERVICE_PROPERTY_HOST_STATE = 3,
    WS_SERVICE_PROPERTY_METADATA = 4,
    WS_SERVICE_PROPERTY_CLOSE_TIMEOUT = 5,
}
