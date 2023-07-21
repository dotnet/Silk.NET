// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE"]/*' />
public enum WS_VALUE_TYPE
{
    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_BOOL_VALUE_TYPE"]/*' />
    WS_BOOL_VALUE_TYPE = 0,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_INT8_VALUE_TYPE"]/*' />
    WS_INT8_VALUE_TYPE = 1,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_INT16_VALUE_TYPE"]/*' />
    WS_INT16_VALUE_TYPE = 2,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_INT32_VALUE_TYPE"]/*' />
    WS_INT32_VALUE_TYPE = 3,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_INT64_VALUE_TYPE"]/*' />
    WS_INT64_VALUE_TYPE = 4,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_UINT8_VALUE_TYPE"]/*' />
    WS_UINT8_VALUE_TYPE = 5,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_UINT16_VALUE_TYPE"]/*' />
    WS_UINT16_VALUE_TYPE = 6,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_UINT32_VALUE_TYPE"]/*' />
    WS_UINT32_VALUE_TYPE = 7,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_UINT64_VALUE_TYPE"]/*' />
    WS_UINT64_VALUE_TYPE = 8,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_FLOAT_VALUE_TYPE"]/*' />
    WS_FLOAT_VALUE_TYPE = 9,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_DOUBLE_VALUE_TYPE"]/*' />
    WS_DOUBLE_VALUE_TYPE = 10,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_DECIMAL_VALUE_TYPE"]/*' />
    WS_DECIMAL_VALUE_TYPE = 11,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_DATETIME_VALUE_TYPE"]/*' />
    WS_DATETIME_VALUE_TYPE = 12,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_TIMESPAN_VALUE_TYPE"]/*' />
    WS_TIMESPAN_VALUE_TYPE = 13,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_GUID_VALUE_TYPE"]/*' />
    WS_GUID_VALUE_TYPE = 14,

    /// <include file='WS_VALUE_TYPE.xml' path='doc/member[@name="WS_VALUE_TYPE.WS_DURATION_VALUE_TYPE"]/*' />
    WS_DURATION_VALUE_TYPE = 15,
}
