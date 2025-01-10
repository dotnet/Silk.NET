// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_VALUE_TYPE
{
    WS_BOOL_VALUE_TYPE = 0,
    WS_INT8_VALUE_TYPE = 1,
    WS_INT16_VALUE_TYPE = 2,
    WS_INT32_VALUE_TYPE = 3,
    WS_INT64_VALUE_TYPE = 4,
    WS_UINT8_VALUE_TYPE = 5,
    WS_UINT16_VALUE_TYPE = 6,
    WS_UINT32_VALUE_TYPE = 7,
    WS_UINT64_VALUE_TYPE = 8,
    WS_FLOAT_VALUE_TYPE = 9,
    WS_DOUBLE_VALUE_TYPE = 10,
    WS_DECIMAL_VALUE_TYPE = 11,
    WS_DATETIME_VALUE_TYPE = 12,
    WS_TIMESPAN_VALUE_TYPE = 13,
    WS_GUID_VALUE_TYPE = 14,
    WS_DURATION_VALUE_TYPE = 15,
}
