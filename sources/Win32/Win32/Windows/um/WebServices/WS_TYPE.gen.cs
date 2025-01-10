// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_TYPE
{
    WS_BOOL_TYPE = 0,
    WS_INT8_TYPE = 1,
    WS_INT16_TYPE = 2,
    WS_INT32_TYPE = 3,
    WS_INT64_TYPE = 4,
    WS_UINT8_TYPE = 5,
    WS_UINT16_TYPE = 6,
    WS_UINT32_TYPE = 7,
    WS_UINT64_TYPE = 8,
    WS_FLOAT_TYPE = 9,
    WS_DOUBLE_TYPE = 10,
    WS_DECIMAL_TYPE = 11,
    WS_DATETIME_TYPE = 12,
    WS_TIMESPAN_TYPE = 13,
    WS_GUID_TYPE = 14,
    WS_UNIQUE_ID_TYPE = 15,
    WS_STRING_TYPE = 16,
    WS_WSZ_TYPE = 17,
    WS_BYTES_TYPE = 18,
    WS_XML_STRING_TYPE = 19,
    WS_XML_QNAME_TYPE = 20,
    WS_XML_BUFFER_TYPE = 21,
    WS_CHAR_ARRAY_TYPE = 22,
    WS_UTF8_ARRAY_TYPE = 23,
    WS_BYTE_ARRAY_TYPE = 24,
    WS_DESCRIPTION_TYPE = 25,
    WS_STRUCT_TYPE = 26,
    WS_CUSTOM_TYPE = 27,
    WS_ENDPOINT_ADDRESS_TYPE = 28,
    WS_FAULT_TYPE = 29,
    WS_VOID_TYPE = 30,
    WS_ENUM_TYPE = 31,
    WS_DURATION_TYPE = 32,
    WS_UNION_TYPE = 33,
    WS_ANY_ATTRIBUTES_TYPE = 34,
}
