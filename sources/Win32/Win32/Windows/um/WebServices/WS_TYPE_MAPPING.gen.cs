// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_TYPE_MAPPING
{
    WS_ELEMENT_TYPE_MAPPING = 1,
    WS_ATTRIBUTE_TYPE_MAPPING = 2,
    WS_ELEMENT_CONTENT_TYPE_MAPPING = 3,
    WS_ANY_ELEMENT_TYPE_MAPPING = 4,
}
