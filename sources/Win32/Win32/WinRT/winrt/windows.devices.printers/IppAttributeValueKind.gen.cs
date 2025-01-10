// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum IppAttributeValueKind
{
    IppAttributeValueKind_Unsupported = 0,
    IppAttributeValueKind_Unknown = 1,
    IppAttributeValueKind_NoValue = 2,
    IppAttributeValueKind_Integer = 3,
    IppAttributeValueKind_Boolean = 4,
    IppAttributeValueKind_Enum = 5,
    IppAttributeValueKind_OctetString = 6,
    IppAttributeValueKind_DateTime = 7,
    IppAttributeValueKind_Resolution = 8,
    IppAttributeValueKind_RangeOfInteger = 9,
    IppAttributeValueKind_Collection = 10,
    IppAttributeValueKind_TextWithLanguage = 11,
    IppAttributeValueKind_NameWithLanguage = 12,
    IppAttributeValueKind_TextWithoutLanguage = 13,
    IppAttributeValueKind_NameWithoutLanguage = 14,
    IppAttributeValueKind_Keyword = 15,
    IppAttributeValueKind_Uri = 16,
    IppAttributeValueKind_UriSchema = 17,
    IppAttributeValueKind_Charset = 18,
    IppAttributeValueKind_NaturalLanguage = 19,
    IppAttributeValueKind_MimeMediaType = 20,
}
