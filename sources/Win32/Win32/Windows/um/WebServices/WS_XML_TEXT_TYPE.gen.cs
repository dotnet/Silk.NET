// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_XML_TEXT_TYPE
{
    WS_XML_TEXT_TYPE_UTF8 = 1,
    WS_XML_TEXT_TYPE_UTF16 = 2,
    WS_XML_TEXT_TYPE_BASE64 = 3,
    WS_XML_TEXT_TYPE_BOOL = 4,
    WS_XML_TEXT_TYPE_INT32 = 5,
    WS_XML_TEXT_TYPE_INT64 = 6,
    WS_XML_TEXT_TYPE_UINT64 = 7,
    WS_XML_TEXT_TYPE_FLOAT = 8,
    WS_XML_TEXT_TYPE_DOUBLE = 9,
    WS_XML_TEXT_TYPE_DECIMAL = 10,
    WS_XML_TEXT_TYPE_GUID = 11,
    WS_XML_TEXT_TYPE_UNIQUE_ID = 12,
    WS_XML_TEXT_TYPE_DATETIME = 13,
    WS_XML_TEXT_TYPE_TIMESPAN = 14,
    WS_XML_TEXT_TYPE_QNAME = 15,
    WS_XML_TEXT_TYPE_LIST = 16,
}
