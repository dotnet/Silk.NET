// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class HIDP
{
    [NativeTypeName("#define HIDP_LINK_COLLECTION_ROOT ((USHORT) -1)")]
    public const ushort HIDP_LINK_COLLECTION_ROOT = unchecked((ushort)(-1));

    [NativeTypeName("#define HIDP_LINK_COLLECTION_UNSPECIFIED ((USHORT) 0)")]
    public const ushort HIDP_LINK_COLLECTION_UNSPECIFIED = ((ushort)(0));

    [NativeTypeName("#define HIDP_STATUS_SUCCESS (HIDP_ERROR_CODES(0x0,0))")]
    public const int HIDP_STATUS_SUCCESS = (((int)(((0x0) << 28) | (0x11 << 16) | (0))));

    [NativeTypeName("#define HIDP_STATUS_NULL (HIDP_ERROR_CODES(0x8,1))")]
    public const int HIDP_STATUS_NULL = (((int)(((0x8) << 28) | (0x11 << 16) | (1))));

    [NativeTypeName("#define HIDP_STATUS_INVALID_PREPARSED_DATA (HIDP_ERROR_CODES(0xC,1))")]
    public const int HIDP_STATUS_INVALID_PREPARSED_DATA = (((int)(((0xC) << 28) | (0x11 << 16) | (1))));

    [NativeTypeName("#define HIDP_STATUS_INVALID_REPORT_TYPE (HIDP_ERROR_CODES(0xC,2))")]
    public const int HIDP_STATUS_INVALID_REPORT_TYPE = (((int)(((0xC) << 28) | (0x11 << 16) | (2))));

    [NativeTypeName("#define HIDP_STATUS_INVALID_REPORT_LENGTH (HIDP_ERROR_CODES(0xC,3))")]
    public const int HIDP_STATUS_INVALID_REPORT_LENGTH = (((int)(((0xC) << 28) | (0x11 << 16) | (3))));

    [NativeTypeName("#define HIDP_STATUS_USAGE_NOT_FOUND (HIDP_ERROR_CODES(0xC,4))")]
    public const int HIDP_STATUS_USAGE_NOT_FOUND = (((int)(((0xC) << 28) | (0x11 << 16) | (4))));

    [NativeTypeName("#define HIDP_STATUS_VALUE_OUT_OF_RANGE (HIDP_ERROR_CODES(0xC,5))")]
    public const int HIDP_STATUS_VALUE_OUT_OF_RANGE = (((int)(((0xC) << 28) | (0x11 << 16) | (5))));

    [NativeTypeName("#define HIDP_STATUS_BAD_LOG_PHY_VALUES (HIDP_ERROR_CODES(0xC,6))")]
    public const int HIDP_STATUS_BAD_LOG_PHY_VALUES = (((int)(((0xC) << 28) | (0x11 << 16) | (6))));

    [NativeTypeName("#define HIDP_STATUS_BUFFER_TOO_SMALL (HIDP_ERROR_CODES(0xC,7))")]
    public const int HIDP_STATUS_BUFFER_TOO_SMALL = (((int)(((0xC) << 28) | (0x11 << 16) | (7))));

    [NativeTypeName("#define HIDP_STATUS_INTERNAL_ERROR (HIDP_ERROR_CODES(0xC,8))")]
    public const int HIDP_STATUS_INTERNAL_ERROR = (((int)(((0xC) << 28) | (0x11 << 16) | (8))));

    [NativeTypeName("#define HIDP_STATUS_I8042_TRANS_UNKNOWN (HIDP_ERROR_CODES(0xC,9))")]
    public const int HIDP_STATUS_I8042_TRANS_UNKNOWN = (((int)(((0xC) << 28) | (0x11 << 16) | (9))));

    [NativeTypeName("#define HIDP_STATUS_INCOMPATIBLE_REPORT_ID (HIDP_ERROR_CODES(0xC,0xA))")]
    public const int HIDP_STATUS_INCOMPATIBLE_REPORT_ID = (((int)(((0xC) << 28) | (0x11 << 16) | (0xA))));

    [NativeTypeName("#define HIDP_STATUS_NOT_VALUE_ARRAY (HIDP_ERROR_CODES(0xC,0xB))")]
    public const int HIDP_STATUS_NOT_VALUE_ARRAY = (((int)(((0xC) << 28) | (0x11 << 16) | (0xB))));

    [NativeTypeName("#define HIDP_STATUS_IS_VALUE_ARRAY (HIDP_ERROR_CODES(0xC,0xC))")]
    public const int HIDP_STATUS_IS_VALUE_ARRAY = (((int)(((0xC) << 28) | (0x11 << 16) | (0xC))));

    [NativeTypeName("#define HIDP_STATUS_DATA_INDEX_NOT_FOUND (HIDP_ERROR_CODES(0xC,0xD))")]
    public const int HIDP_STATUS_DATA_INDEX_NOT_FOUND = (((int)(((0xC) << 28) | (0x11 << 16) | (0xD))));

    [NativeTypeName("#define HIDP_STATUS_DATA_INDEX_OUT_OF_RANGE (HIDP_ERROR_CODES(0xC,0xE))")]
    public const int HIDP_STATUS_DATA_INDEX_OUT_OF_RANGE = (((int)(((0xC) << 28) | (0x11 << 16) | (0xE))));

    [NativeTypeName("#define HIDP_STATUS_BUTTON_NOT_PRESSED (HIDP_ERROR_CODES(0xC,0xF))")]
    public const int HIDP_STATUS_BUTTON_NOT_PRESSED = (((int)(((0xC) << 28) | (0x11 << 16) | (0xF))));

    [NativeTypeName("#define HIDP_STATUS_REPORT_DOES_NOT_EXIST (HIDP_ERROR_CODES(0xC,0x10))")]
    public const int HIDP_STATUS_REPORT_DOES_NOT_EXIST = (((int)(((0xC) << 28) | (0x11 << 16) | (0x10))));

    [NativeTypeName("#define HIDP_STATUS_NOT_IMPLEMENTED (HIDP_ERROR_CODES(0xC,0x20))")]
    public const int HIDP_STATUS_NOT_IMPLEMENTED = (((int)(((0xC) << 28) | (0x11 << 16) | (0x20))));

    [NativeTypeName("#define HIDP_STATUS_NOT_BUTTON_ARRAY (HIDP_ERROR_CODES(0xC,0x21))")]
    public const int HIDP_STATUS_NOT_BUTTON_ARRAY = (((int)(((0xC) << 28) | (0x11 << 16) | (0x21))));

    [NativeTypeName("#define HIDP_STATUS_I8242_TRANS_UNKNOWN HIDP_STATUS_I8042_TRANS_UNKNOWN")]
    public const int HIDP_STATUS_I8242_TRANS_UNKNOWN = (((int)(((0xC) << 28) | (0x11 << 16) | (9))));
}
