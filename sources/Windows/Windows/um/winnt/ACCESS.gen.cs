// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

public static partial class ACCESS
{
    [NativeTypeName("#define ACCESS_SYSTEM_SECURITY (0x01000000L)")]
    public const int ACCESS_SYSTEM_SECURITY = (0x01000000);

    [NativeTypeName("#define ACCESS_MIN_MS_ACE_TYPE (0x0)")]
    public const int ACCESS_MIN_MS_ACE_TYPE = (0x0);

    [NativeTypeName("#define ACCESS_ALLOWED_ACE_TYPE (0x0)")]
    public const int ACCESS_ALLOWED_ACE_TYPE = (0x0);

    [NativeTypeName("#define ACCESS_DENIED_ACE_TYPE (0x1)")]
    public const int ACCESS_DENIED_ACE_TYPE = (0x1);

    [NativeTypeName("#define ACCESS_MAX_MS_V2_ACE_TYPE (0x3)")]
    public const int ACCESS_MAX_MS_V2_ACE_TYPE = (0x3);

    [NativeTypeName("#define ACCESS_ALLOWED_COMPOUND_ACE_TYPE (0x4)")]
    public const int ACCESS_ALLOWED_COMPOUND_ACE_TYPE = (0x4);

    [NativeTypeName("#define ACCESS_MAX_MS_V3_ACE_TYPE (0x4)")]
    public const int ACCESS_MAX_MS_V3_ACE_TYPE = (0x4);

    [NativeTypeName("#define ACCESS_MIN_MS_OBJECT_ACE_TYPE (0x5)")]
    public const int ACCESS_MIN_MS_OBJECT_ACE_TYPE = (0x5);

    [NativeTypeName("#define ACCESS_ALLOWED_OBJECT_ACE_TYPE (0x5)")]
    public const int ACCESS_ALLOWED_OBJECT_ACE_TYPE = (0x5);

    [NativeTypeName("#define ACCESS_DENIED_OBJECT_ACE_TYPE (0x6)")]
    public const int ACCESS_DENIED_OBJECT_ACE_TYPE = (0x6);

    [NativeTypeName("#define ACCESS_MAX_MS_OBJECT_ACE_TYPE (0x8)")]
    public const int ACCESS_MAX_MS_OBJECT_ACE_TYPE = (0x8);

    [NativeTypeName("#define ACCESS_MAX_MS_V4_ACE_TYPE (0x8)")]
    public const int ACCESS_MAX_MS_V4_ACE_TYPE = (0x8);

    [NativeTypeName("#define ACCESS_MAX_MS_ACE_TYPE (0x8)")]
    public const int ACCESS_MAX_MS_ACE_TYPE = (0x8);

    [NativeTypeName("#define ACCESS_ALLOWED_CALLBACK_ACE_TYPE (0x9)")]
    public const int ACCESS_ALLOWED_CALLBACK_ACE_TYPE = (0x9);

    [NativeTypeName("#define ACCESS_DENIED_CALLBACK_ACE_TYPE (0xA)")]
    public const int ACCESS_DENIED_CALLBACK_ACE_TYPE = (0xA);

    [NativeTypeName("#define ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE (0xB)")]
    public const int ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE = (0xB);

    [NativeTypeName("#define ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE (0xC)")]
    public const int ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE = (0xC);

    [NativeTypeName("#define ACCESS_MAX_MS_V5_ACE_TYPE (0x15)")]
    public const int ACCESS_MAX_MS_V5_ACE_TYPE = (0x15);

    [NativeTypeName("#define ACCESS_OBJECT_GUID 0")]
    public const int ACCESS_OBJECT_GUID = 0;

    [NativeTypeName("#define ACCESS_PROPERTY_SET_GUID 1")]
    public const int ACCESS_PROPERTY_SET_GUID = 1;

    [NativeTypeName("#define ACCESS_PROPERTY_GUID 2")]
    public const int ACCESS_PROPERTY_GUID = 2;

    [NativeTypeName("#define ACCESS_MAX_LEVEL 4")]
    public const int ACCESS_MAX_LEVEL = 4;

    [NativeTypeName("#define ACCESS_DS_SOURCE_A \"DS\"")]
    public static ReadOnlySpan<byte> ACCESS_DS_SOURCE_A => "DS"u8;

    [NativeTypeName("#define ACCESS_DS_SOURCE_W L\"DS\"")]
    public const string ACCESS_DS_SOURCE_W = "DS";

    [NativeTypeName("#define ACCESS_DS_OBJECT_TYPE_NAME_A \"Directory Service Object\"")]
    public static ReadOnlySpan<byte> ACCESS_DS_OBJECT_TYPE_NAME_A => "Directory Service Object"u8;

    [NativeTypeName("#define ACCESS_DS_OBJECT_TYPE_NAME_W L\"Directory Service Object\"")]
    public const string ACCESS_DS_OBJECT_TYPE_NAME_W = "Directory Service Object";

    [NativeTypeName("#define ACCESS_REASON_TYPE_MASK 0x00ff0000")]
    public const int ACCESS_REASON_TYPE_MASK = 0x00ff0000;

    [NativeTypeName("#define ACCESS_REASON_DATA_MASK 0x0000ffff")]
    public const int ACCESS_REASON_DATA_MASK = 0x0000ffff;

    [NativeTypeName("#define ACCESS_REASON_STAGING_MASK 0x80000000")]
    public const uint ACCESS_REASON_STAGING_MASK = 0x80000000;

    [NativeTypeName("#define ACCESS_REASON_EXDATA_MASK 0x7f000000")]
    public const int ACCESS_REASON_EXDATA_MASK = 0x7f000000;

    [NativeTypeName("#define ACCESS_FILTER_SECURITY_INFORMATION (0x00000100L)")]
    public const int ACCESS_FILTER_SECURITY_INFORMATION = (0x00000100);
}
