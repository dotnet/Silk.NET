// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_FIELD_MAPPING
{
    WS_TYPE_ATTRIBUTE_FIELD_MAPPING = 0,
    WS_ATTRIBUTE_FIELD_MAPPING = 1,
    WS_ELEMENT_FIELD_MAPPING = 2,
    WS_REPEATING_ELEMENT_FIELD_MAPPING = 3,
    WS_TEXT_FIELD_MAPPING = 4,
    WS_NO_FIELD_MAPPING = 5,
    WS_XML_ATTRIBUTE_FIELD_MAPPING = 6,
    WS_ELEMENT_CHOICE_FIELD_MAPPING = 7,
    WS_REPEATING_ELEMENT_CHOICE_FIELD_MAPPING = 8,
    WS_ANY_ELEMENT_FIELD_MAPPING = 9,
    WS_REPEATING_ANY_ELEMENT_FIELD_MAPPING = 10,
    WS_ANY_CONTENT_FIELD_MAPPING = 11,
    WS_ANY_ATTRIBUTES_FIELD_MAPPING = 12,
}
