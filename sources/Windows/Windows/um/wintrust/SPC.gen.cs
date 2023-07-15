// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
public static unsafe partial class SPC
{
    [NativeTypeName("#define SPC_COMMON_NAME_OBJID szOID_COMMON_NAME")]
    public static ReadOnlySpan<byte> SPC_COMMON_NAME_OBJID => "2.5.4.3"u8;

    [NativeTypeName("#define SPC_TIME_STAMP_REQUEST_OBJID \"1.3.6.1.4.1.311.3.2.1\"")]
    public static ReadOnlySpan<byte> SPC_TIME_STAMP_REQUEST_OBJID => "1.3.6.1.4.1.311.3.2.1"u8;

    [NativeTypeName("#define SPC_INDIRECT_DATA_OBJID \"1.3.6.1.4.1.311.2.1.4\"")]
    public static ReadOnlySpan<byte> SPC_INDIRECT_DATA_OBJID => "1.3.6.1.4.1.311.2.1.4"u8;

    [NativeTypeName("#define SPC_SP_AGENCY_INFO_OBJID \"1.3.6.1.4.1.311.2.1.10\"")]
    public static ReadOnlySpan<byte> SPC_SP_AGENCY_INFO_OBJID => "1.3.6.1.4.1.311.2.1.10"u8;

    [NativeTypeName("#define SPC_STATEMENT_TYPE_OBJID \"1.3.6.1.4.1.311.2.1.11\"")]
    public static ReadOnlySpan<byte> SPC_STATEMENT_TYPE_OBJID => "1.3.6.1.4.1.311.2.1.11"u8;

    [NativeTypeName("#define SPC_SP_OPUS_INFO_OBJID \"1.3.6.1.4.1.311.2.1.12\"")]
    public static ReadOnlySpan<byte> SPC_SP_OPUS_INFO_OBJID => "1.3.6.1.4.1.311.2.1.12"u8;

    [NativeTypeName("#define SPC_CERT_EXTENSIONS_OBJID \"1.3.6.1.4.1.311.2.1.14\"")]
    public static ReadOnlySpan<byte> SPC_CERT_EXTENSIONS_OBJID => "1.3.6.1.4.1.311.2.1.14"u8;

    [NativeTypeName("#define SPC_PE_IMAGE_DATA_OBJID \"1.3.6.1.4.1.311.2.1.15\"")]
    public static ReadOnlySpan<byte> SPC_PE_IMAGE_DATA_OBJID => "1.3.6.1.4.1.311.2.1.15"u8;

    [NativeTypeName("#define SPC_RAW_FILE_DATA_OBJID \"1.3.6.1.4.1.311.2.1.18\"")]
    public static ReadOnlySpan<byte> SPC_RAW_FILE_DATA_OBJID => "1.3.6.1.4.1.311.2.1.18"u8;

    [NativeTypeName("#define SPC_STRUCTURED_STORAGE_DATA_OBJID \"1.3.6.1.4.1.311.2.1.19\"")]
    public static ReadOnlySpan<byte> SPC_STRUCTURED_STORAGE_DATA_OBJID => "1.3.6.1.4.1.311.2.1.19"u8;

    [NativeTypeName("#define SPC_JAVA_CLASS_DATA_OBJID \"1.3.6.1.4.1.311.2.1.20\"")]
    public static ReadOnlySpan<byte> SPC_JAVA_CLASS_DATA_OBJID => "1.3.6.1.4.1.311.2.1.20"u8;

    [NativeTypeName("#define SPC_INDIVIDUAL_SP_KEY_PURPOSE_OBJID \"1.3.6.1.4.1.311.2.1.21\"")]
    public static ReadOnlySpan<byte> SPC_INDIVIDUAL_SP_KEY_PURPOSE_OBJID => "1.3.6.1.4.1.311.2.1.21"u8;

    [NativeTypeName("#define SPC_COMMERCIAL_SP_KEY_PURPOSE_OBJID \"1.3.6.1.4.1.311.2.1.22\"")]
    public static ReadOnlySpan<byte> SPC_COMMERCIAL_SP_KEY_PURPOSE_OBJID => "1.3.6.1.4.1.311.2.1.22"u8;

    [NativeTypeName("#define SPC_CAB_DATA_OBJID \"1.3.6.1.4.1.311.2.1.25\"")]
    public static ReadOnlySpan<byte> SPC_CAB_DATA_OBJID => "1.3.6.1.4.1.311.2.1.25"u8;

    [NativeTypeName("#define SPC_GLUE_RDN_OBJID \"1.3.6.1.4.1.311.2.1.25\"")]
    public static ReadOnlySpan<byte> SPC_GLUE_RDN_OBJID => "1.3.6.1.4.1.311.2.1.25"u8;

    [NativeTypeName("#define SPC_MINIMAL_CRITERIA_OBJID \"1.3.6.1.4.1.311.2.1.26\"")]
    public static ReadOnlySpan<byte> SPC_MINIMAL_CRITERIA_OBJID => "1.3.6.1.4.1.311.2.1.26"u8;

    [NativeTypeName("#define SPC_FINANCIAL_CRITERIA_OBJID \"1.3.6.1.4.1.311.2.1.27\"")]
    public static ReadOnlySpan<byte> SPC_FINANCIAL_CRITERIA_OBJID => "1.3.6.1.4.1.311.2.1.27"u8;

    [NativeTypeName("#define SPC_LINK_OBJID \"1.3.6.1.4.1.311.2.1.28\"")]
    public static ReadOnlySpan<byte> SPC_LINK_OBJID => "1.3.6.1.4.1.311.2.1.28"u8;

    [NativeTypeName("#define SPC_SIGINFO_OBJID \"1.3.6.1.4.1.311.2.1.30\"")]
    public static ReadOnlySpan<byte> SPC_SIGINFO_OBJID => "1.3.6.1.4.1.311.2.1.30"u8;

    [NativeTypeName("#define SPC_PE_IMAGE_PAGE_HASHES_V1_OBJID \"1.3.6.1.4.1.311.2.3.1\"")]
    public static ReadOnlySpan<byte> SPC_PE_IMAGE_PAGE_HASHES_V1_OBJID => "1.3.6.1.4.1.311.2.3.1"u8;

    [NativeTypeName("#define SPC_PE_IMAGE_PAGE_HASHES_V2_OBJID \"1.3.6.1.4.1.311.2.3.2\"")]
    public static ReadOnlySpan<byte> SPC_PE_IMAGE_PAGE_HASHES_V2_OBJID => "1.3.6.1.4.1.311.2.3.2"u8;

    [NativeTypeName("#define SPC_RELAXED_PE_MARKER_CHECK_OBJID \"1.3.6.1.4.1.311.2.6.1\"")]
    public static ReadOnlySpan<byte> SPC_RELAXED_PE_MARKER_CHECK_OBJID => "1.3.6.1.4.1.311.2.6.1"u8;

    [NativeTypeName("#define SPC_ENCRYPTED_DIGEST_RETRY_COUNT_OBJID \"1.3.6.1.4.1.311.2.6.2\"")]
    public static ReadOnlySpan<byte> SPC_ENCRYPTED_DIGEST_RETRY_COUNT_OBJID => "1.3.6.1.4.1.311.2.6.2"u8;

    [NativeTypeName("#define SPC_WINDOWS_HELLO_COMPATIBILITY_OBJID \"1.3.6.1.4.1.311.10.41.1\"")]
    public static ReadOnlySpan<byte> SPC_WINDOWS_HELLO_COMPATIBILITY_OBJID => "1.3.6.1.4.1.311.10.41.1"u8;

    [NativeTypeName("#define SPC_NATURAL_AUTH_PLUGIN_OBJID \"1.3.6.1.4.1.311.96.1.1\"")]
    public static ReadOnlySpan<byte> SPC_NATURAL_AUTH_PLUGIN_OBJID => "1.3.6.1.4.1.311.96.1.1"u8;

    [NativeTypeName("#define SPC_SP_AGENCY_INFO_STRUCT ((LPCSTR) 2000)")]
    public static sbyte* SPC_SP_AGENCY_INFO_STRUCT => ((sbyte*)(2000));

    [NativeTypeName("#define SPC_MINIMAL_CRITERIA_STRUCT ((LPCSTR) 2001)")]
    public static sbyte* SPC_MINIMAL_CRITERIA_STRUCT => ((sbyte*)(2001));

    [NativeTypeName("#define SPC_FINANCIAL_CRITERIA_STRUCT ((LPCSTR) 2002)")]
    public static sbyte* SPC_FINANCIAL_CRITERIA_STRUCT => ((sbyte*)(2002));

    [NativeTypeName("#define SPC_INDIRECT_DATA_CONTENT_STRUCT ((LPCSTR) 2003)")]
    public static sbyte* SPC_INDIRECT_DATA_CONTENT_STRUCT => ((sbyte*)(2003));

    [NativeTypeName("#define SPC_PE_IMAGE_DATA_STRUCT ((LPCSTR) 2004)")]
    public static sbyte* SPC_PE_IMAGE_DATA_STRUCT => ((sbyte*)(2004));

    [NativeTypeName("#define SPC_LINK_STRUCT ((LPCSTR) 2005)")]
    public static sbyte* SPC_LINK_STRUCT => ((sbyte*)(2005));

    [NativeTypeName("#define SPC_STATEMENT_TYPE_STRUCT ((LPCSTR) 2006)")]
    public static sbyte* SPC_STATEMENT_TYPE_STRUCT => ((sbyte*)(2006));

    [NativeTypeName("#define SPC_SP_OPUS_INFO_STRUCT ((LPCSTR) 2007)")]
    public static sbyte* SPC_SP_OPUS_INFO_STRUCT => ((sbyte*)(2007));

    [NativeTypeName("#define SPC_CAB_DATA_STRUCT ((LPCSTR) 2008)")]
    public static sbyte* SPC_CAB_DATA_STRUCT => ((sbyte*)(2008));

    [NativeTypeName("#define SPC_JAVA_CLASS_DATA_STRUCT ((LPCSTR) 2009)")]
    public static sbyte* SPC_JAVA_CLASS_DATA_STRUCT => ((sbyte*)(2009));

    [NativeTypeName("#define SPC_SIGINFO_STRUCT ((LPCSTR) 2130)")]
    public static sbyte* SPC_SIGINFO_STRUCT => ((sbyte*)(2130));

    [NativeTypeName("#define SPC_UUID_LENGTH 16")]
    public const int SPC_UUID_LENGTH = 16;
    [NativeTypeName("#define SPC_URL_LINK_CHOICE 1")]
    public const int SPC_URL_LINK_CHOICE = 1;
    [NativeTypeName("#define SPC_MONIKER_LINK_CHOICE 2")]
    public const int SPC_MONIKER_LINK_CHOICE = 2;
    [NativeTypeName("#define SPC_FILE_LINK_CHOICE 3")]
    public const int SPC_FILE_LINK_CHOICE = 3;
}