// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.Uri_PROPERTY;

namespace Silk.NET.Windows;
public static partial class URI
{
    [NativeTypeName("#define Uri_HAS_ABSOLUTE_URI (1 << Uri_PROPERTY_ABSOLUTE_URI)")]
    public const int Uri_HAS_ABSOLUTE_URI = (1 << (int)(Uri_PROPERTY_ABSOLUTE_URI));
    [NativeTypeName("#define Uri_HAS_AUTHORITY (1 << Uri_PROPERTY_AUTHORITY)")]
    public const int Uri_HAS_AUTHORITY = (1 << (int)(Uri_PROPERTY_AUTHORITY));
    [NativeTypeName("#define Uri_HAS_DISPLAY_URI (1 << Uri_PROPERTY_DISPLAY_URI)")]
    public const int Uri_HAS_DISPLAY_URI = (1 << (int)(Uri_PROPERTY_DISPLAY_URI));
    [NativeTypeName("#define Uri_HAS_DOMAIN (1 << Uri_PROPERTY_DOMAIN)")]
    public const int Uri_HAS_DOMAIN = (1 << (int)(Uri_PROPERTY_DOMAIN));
    [NativeTypeName("#define Uri_HAS_EXTENSION (1 << Uri_PROPERTY_EXTENSION)")]
    public const int Uri_HAS_EXTENSION = (1 << (int)(Uri_PROPERTY_EXTENSION));
    [NativeTypeName("#define Uri_HAS_FRAGMENT (1 << Uri_PROPERTY_FRAGMENT)")]
    public const int Uri_HAS_FRAGMENT = (1 << (int)(Uri_PROPERTY_FRAGMENT));
    [NativeTypeName("#define Uri_HAS_HOST (1 << Uri_PROPERTY_HOST)")]
    public const int Uri_HAS_HOST = (1 << (int)(Uri_PROPERTY_HOST));
    [NativeTypeName("#define Uri_HAS_PASSWORD (1 << Uri_PROPERTY_PASSWORD)")]
    public const int Uri_HAS_PASSWORD = (1 << (int)(Uri_PROPERTY_PASSWORD));
    [NativeTypeName("#define Uri_HAS_PATH (1 << Uri_PROPERTY_PATH)")]
    public const int Uri_HAS_PATH = (1 << (int)(Uri_PROPERTY_PATH));
    [NativeTypeName("#define Uri_HAS_QUERY (1 << Uri_PROPERTY_QUERY)")]
    public const int Uri_HAS_QUERY = (1 << (int)(Uri_PROPERTY_QUERY));
    [NativeTypeName("#define Uri_HAS_RAW_URI (1 << Uri_PROPERTY_RAW_URI)")]
    public const int Uri_HAS_RAW_URI = (1 << (int)(Uri_PROPERTY_RAW_URI));
    [NativeTypeName("#define Uri_HAS_SCHEME_NAME (1 << Uri_PROPERTY_SCHEME_NAME)")]
    public const int Uri_HAS_SCHEME_NAME = (1 << (int)(Uri_PROPERTY_SCHEME_NAME));
    [NativeTypeName("#define Uri_HAS_USER_NAME (1 << Uri_PROPERTY_USER_NAME)")]
    public const int Uri_HAS_USER_NAME = (1 << (int)(Uri_PROPERTY_USER_NAME));
    [NativeTypeName("#define Uri_HAS_PATH_AND_QUERY (1 << Uri_PROPERTY_PATH_AND_QUERY)")]
    public const int Uri_HAS_PATH_AND_QUERY = (1 << (int)(Uri_PROPERTY_PATH_AND_QUERY));
    [NativeTypeName("#define Uri_HAS_USER_INFO (1 << Uri_PROPERTY_USER_INFO)")]
    public const int Uri_HAS_USER_INFO = (1 << (int)(Uri_PROPERTY_USER_INFO));
    [NativeTypeName("#define Uri_HAS_HOST_TYPE (1 << Uri_PROPERTY_HOST_TYPE)")]
    public const int Uri_HAS_HOST_TYPE = (1 << (int)(Uri_PROPERTY_HOST_TYPE));
    [NativeTypeName("#define Uri_HAS_PORT (1 << Uri_PROPERTY_PORT)")]
    public const int Uri_HAS_PORT = (1 << (int)(Uri_PROPERTY_PORT));
    [NativeTypeName("#define Uri_HAS_SCHEME (1 << Uri_PROPERTY_SCHEME)")]
    public const int Uri_HAS_SCHEME = (1 << (int)(Uri_PROPERTY_SCHEME));
    [NativeTypeName("#define Uri_HAS_ZONE (1 << Uri_PROPERTY_ZONE)")]
    public const int Uri_HAS_ZONE = (1 << (int)(Uri_PROPERTY_ZONE));
    [NativeTypeName("#define Uri_CREATE_ALLOW_RELATIVE 0x00000001")]
    public const int Uri_CREATE_ALLOW_RELATIVE = 0x00000001;
    [NativeTypeName("#define Uri_CREATE_ALLOW_IMPLICIT_WILDCARD_SCHEME 0x00000002")]
    public const int Uri_CREATE_ALLOW_IMPLICIT_WILDCARD_SCHEME = 0x00000002;
    [NativeTypeName("#define Uri_CREATE_ALLOW_IMPLICIT_FILE_SCHEME 0x00000004")]
    public const int Uri_CREATE_ALLOW_IMPLICIT_FILE_SCHEME = 0x00000004;
    [NativeTypeName("#define Uri_CREATE_NOFRAG 0x00000008")]
    public const int Uri_CREATE_NOFRAG = 0x00000008;
    [NativeTypeName("#define Uri_CREATE_NO_CANONICALIZE 0x00000010")]
    public const int Uri_CREATE_NO_CANONICALIZE = 0x00000010;
    [NativeTypeName("#define Uri_CREATE_CANONICALIZE 0x00000100")]
    public const int Uri_CREATE_CANONICALIZE = 0x00000100;
    [NativeTypeName("#define Uri_CREATE_FILE_USE_DOS_PATH 0x00000020")]
    public const int Uri_CREATE_FILE_USE_DOS_PATH = 0x00000020;
    [NativeTypeName("#define Uri_CREATE_DECODE_EXTRA_INFO 0x00000040")]
    public const int Uri_CREATE_DECODE_EXTRA_INFO = 0x00000040;
    [NativeTypeName("#define Uri_CREATE_NO_DECODE_EXTRA_INFO 0x00000080")]
    public const int Uri_CREATE_NO_DECODE_EXTRA_INFO = 0x00000080;
    [NativeTypeName("#define Uri_CREATE_CRACK_UNKNOWN_SCHEMES 0x00000200")]
    public const int Uri_CREATE_CRACK_UNKNOWN_SCHEMES = 0x00000200;
    [NativeTypeName("#define Uri_CREATE_NO_CRACK_UNKNOWN_SCHEMES 0x00000400")]
    public const int Uri_CREATE_NO_CRACK_UNKNOWN_SCHEMES = 0x00000400;
    [NativeTypeName("#define Uri_CREATE_PRE_PROCESS_HTML_URI 0x00000800")]
    public const int Uri_CREATE_PRE_PROCESS_HTML_URI = 0x00000800;
    [NativeTypeName("#define Uri_CREATE_NO_PRE_PROCESS_HTML_URI 0x00001000")]
    public const int Uri_CREATE_NO_PRE_PROCESS_HTML_URI = 0x00001000;
    [NativeTypeName("#define Uri_CREATE_IE_SETTINGS 0x00002000")]
    public const int Uri_CREATE_IE_SETTINGS = 0x00002000;
    [NativeTypeName("#define Uri_CREATE_NO_IE_SETTINGS 0x00004000")]
    public const int Uri_CREATE_NO_IE_SETTINGS = 0x00004000;
    [NativeTypeName("#define Uri_CREATE_NO_ENCODE_FORBIDDEN_CHARACTERS 0x00008000")]
    public const int Uri_CREATE_NO_ENCODE_FORBIDDEN_CHARACTERS = 0x00008000;
    [NativeTypeName("#define Uri_CREATE_NORMALIZE_INTL_CHARACTERS 0x00010000")]
    public const int Uri_CREATE_NORMALIZE_INTL_CHARACTERS = 0x00010000;
    [NativeTypeName("#define Uri_CREATE_CANONICALIZE_ABSOLUTE 0x00020000")]
    public const int Uri_CREATE_CANONICALIZE_ABSOLUTE = 0x00020000;
    [NativeTypeName("#define Uri_DISPLAY_NO_FRAGMENT 0x00000001")]
    public const int Uri_DISPLAY_NO_FRAGMENT = 0x00000001;
    [NativeTypeName("#define Uri_PUNYCODE_IDN_HOST 0x00000002")]
    public const int Uri_PUNYCODE_IDN_HOST = 0x00000002;
    [NativeTypeName("#define Uri_DISPLAY_IDN_HOST 0x00000004")]
    public const int Uri_DISPLAY_IDN_HOST = 0x00000004;
    [NativeTypeName("#define Uri_DISPLAY_NO_PUNYCODE 0x00000008")]
    public const int Uri_DISPLAY_NO_PUNYCODE = 0x00000008;
    [NativeTypeName("#define Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 0x00000001")]
    public const int Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 = 0x00000001;
    [NativeTypeName("#define Uri_ENCODING_USER_INFO_AND_PATH_IS_CP 0x00000002")]
    public const int Uri_ENCODING_USER_INFO_AND_PATH_IS_CP = 0x00000002;
    [NativeTypeName("#define Uri_ENCODING_HOST_IS_IDN 0x00000004")]
    public const int Uri_ENCODING_HOST_IS_IDN = 0x00000004;
    [NativeTypeName("#define Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 0x00000008")]
    public const int Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 = 0x00000008;
    [NativeTypeName("#define Uri_ENCODING_HOST_IS_PERCENT_ENCODED_CP 0x00000010")]
    public const int Uri_ENCODING_HOST_IS_PERCENT_ENCODED_CP = 0x00000010;
    [NativeTypeName("#define Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8 0x00000020")]
    public const int Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8 = 0x00000020;
    [NativeTypeName("#define Uri_ENCODING_QUERY_AND_FRAGMENT_IS_CP 0x00000040")]
    public const int Uri_ENCODING_QUERY_AND_FRAGMENT_IS_CP = 0x00000040;
    [NativeTypeName("#define Uri_ENCODING_RFC (Uri_ENCODING_USER_INFO_AND_PATH_IS_PERCENT_ENCODED_UTF8 | Uri_ENCODING_HOST_IS_PERCENT_ENCODED_UTF8 | Uri_ENCODING_QUERY_AND_FRAGMENT_IS_PERCENT_ENCODED_UTF8)")]
    public const int Uri_ENCODING_RFC = (0x00000001 | 0x00000008 | 0x00000020);
}