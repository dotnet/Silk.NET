// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_METADATA_PROPERTY_ID
{
    WS_METADATA_PROPERTY_STATE = 1,
    WS_METADATA_PROPERTY_HEAP_PROPERTIES = 2,
    WS_METADATA_PROPERTY_POLICY_PROPERTIES = 3,
    WS_METADATA_PROPERTY_HEAP_REQUESTED_SIZE = 4,
    WS_METADATA_PROPERTY_MAX_DOCUMENTS = 5,
    WS_METADATA_PROPERTY_HOST_NAMES = 6,
    WS_METADATA_PROPERTY_VERIFY_HOST_NAMES = 7,
}
