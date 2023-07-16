// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE"]/*'/>
public enum WS_TYPE
{
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_BOOL_TYPE"]/*'/>
    WS_BOOL_TYPE = 0,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_INT8_TYPE"]/*'/>
    WS_INT8_TYPE = 1,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_INT16_TYPE"]/*'/>
    WS_INT16_TYPE = 2,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_INT32_TYPE"]/*'/>
    WS_INT32_TYPE = 3,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_INT64_TYPE"]/*'/>
    WS_INT64_TYPE = 4,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_UINT8_TYPE"]/*'/>
    WS_UINT8_TYPE = 5,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_UINT16_TYPE"]/*'/>
    WS_UINT16_TYPE = 6,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_UINT32_TYPE"]/*'/>
    WS_UINT32_TYPE = 7,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_UINT64_TYPE"]/*'/>
    WS_UINT64_TYPE = 8,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_FLOAT_TYPE"]/*'/>
    WS_FLOAT_TYPE = 9,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_DOUBLE_TYPE"]/*'/>
    WS_DOUBLE_TYPE = 10,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_DECIMAL_TYPE"]/*'/>
    WS_DECIMAL_TYPE = 11,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_DATETIME_TYPE"]/*'/>
    WS_DATETIME_TYPE = 12,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_TIMESPAN_TYPE"]/*'/>
    WS_TIMESPAN_TYPE = 13,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_GUID_TYPE"]/*'/>
    WS_GUID_TYPE = 14,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_UNIQUE_ID_TYPE"]/*'/>
    WS_UNIQUE_ID_TYPE = 15,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_STRING_TYPE"]/*'/>
    WS_STRING_TYPE = 16,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_WSZ_TYPE"]/*'/>
    WS_WSZ_TYPE = 17,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_BYTES_TYPE"]/*'/>
    WS_BYTES_TYPE = 18,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_XML_STRING_TYPE"]/*'/>
    WS_XML_STRING_TYPE = 19,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_XML_QNAME_TYPE"]/*'/>
    WS_XML_QNAME_TYPE = 20,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_XML_BUFFER_TYPE"]/*'/>
    WS_XML_BUFFER_TYPE = 21,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_CHAR_ARRAY_TYPE"]/*'/>
    WS_CHAR_ARRAY_TYPE = 22,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_UTF8_ARRAY_TYPE"]/*'/>
    WS_UTF8_ARRAY_TYPE = 23,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_BYTE_ARRAY_TYPE"]/*'/>
    WS_BYTE_ARRAY_TYPE = 24,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_DESCRIPTION_TYPE"]/*'/>
    WS_DESCRIPTION_TYPE = 25,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_STRUCT_TYPE"]/*'/>
    WS_STRUCT_TYPE = 26,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_CUSTOM_TYPE"]/*'/>
    WS_CUSTOM_TYPE = 27,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_ENDPOINT_ADDRESS_TYPE"]/*'/>
    WS_ENDPOINT_ADDRESS_TYPE = 28,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_FAULT_TYPE"]/*'/>
    WS_FAULT_TYPE = 29,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_VOID_TYPE"]/*'/>
    WS_VOID_TYPE = 30,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_ENUM_TYPE"]/*'/>
    WS_ENUM_TYPE = 31,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_DURATION_TYPE"]/*'/>
    WS_DURATION_TYPE = 32,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_UNION_TYPE"]/*'/>
    WS_UNION_TYPE = 33,
    /// <include file='WS_TYPE.xml' path='doc/member[@name="WS_TYPE.WS_ANY_ATTRIBUTES_TYPE"]/*'/>
    WS_ANY_ATTRIBUTES_TYPE = 34,
}