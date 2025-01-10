// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class PLA
{
    [NativeTypeName("#define PLA_E_DCS_NOT_FOUND _HRESULT_TYPEDEF_(0x80300002L)")]
    public const int PLA_E_DCS_NOT_FOUND = unchecked((int)(0x80300002));

    [NativeTypeName("#define PLA_E_DCS_IN_USE _HRESULT_TYPEDEF_(0x803000AAL)")]
    public const int PLA_E_DCS_IN_USE = unchecked((int)(0x803000AA));

    [NativeTypeName("#define PLA_E_TOO_MANY_FOLDERS _HRESULT_TYPEDEF_(0x80300045L)")]
    public const int PLA_E_TOO_MANY_FOLDERS = unchecked((int)(0x80300045));

    [NativeTypeName("#define PLA_E_NO_MIN_DISK _HRESULT_TYPEDEF_(0x80300070L)")]
    public const int PLA_E_NO_MIN_DISK = unchecked((int)(0x80300070));

    [NativeTypeName("#define PLA_E_DCS_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803000B7L)")]
    public const int PLA_E_DCS_ALREADY_EXISTS = unchecked((int)(0x803000B7));

    [NativeTypeName("#define PLA_S_PROPERTY_IGNORED _HRESULT_TYPEDEF_(0x00300100L)")]
    public const int PLA_S_PROPERTY_IGNORED = ((int)(0x00300100));

    [NativeTypeName("#define PLA_E_PROPERTY_CONFLICT _HRESULT_TYPEDEF_(0x80300101L)")]
    public const int PLA_E_PROPERTY_CONFLICT = unchecked((int)(0x80300101));

    [NativeTypeName("#define PLA_E_DCS_SINGLETON_REQUIRED _HRESULT_TYPEDEF_(0x80300102L)")]
    public const int PLA_E_DCS_SINGLETON_REQUIRED = unchecked((int)(0x80300102));

    [NativeTypeName("#define PLA_E_CREDENTIALS_REQUIRED _HRESULT_TYPEDEF_(0x80300103L)")]
    public const int PLA_E_CREDENTIALS_REQUIRED = unchecked((int)(0x80300103));

    [NativeTypeName("#define PLA_E_DCS_NOT_RUNNING _HRESULT_TYPEDEF_(0x80300104L)")]
    public const int PLA_E_DCS_NOT_RUNNING = unchecked((int)(0x80300104));

    [NativeTypeName("#define PLA_E_CONFLICT_INCL_EXCL_API _HRESULT_TYPEDEF_(0x80300105L)")]
    public const int PLA_E_CONFLICT_INCL_EXCL_API = unchecked((int)(0x80300105));

    [NativeTypeName("#define PLA_E_NETWORK_EXE_NOT_VALID _HRESULT_TYPEDEF_(0x80300106L)")]
    public const int PLA_E_NETWORK_EXE_NOT_VALID = unchecked((int)(0x80300106));

    [NativeTypeName("#define PLA_E_EXE_ALREADY_CONFIGURED _HRESULT_TYPEDEF_(0x80300107L)")]
    public const int PLA_E_EXE_ALREADY_CONFIGURED = unchecked((int)(0x80300107));

    [NativeTypeName("#define PLA_E_EXE_PATH_NOT_VALID _HRESULT_TYPEDEF_(0x80300108L)")]
    public const int PLA_E_EXE_PATH_NOT_VALID = unchecked((int)(0x80300108));

    [NativeTypeName("#define PLA_E_DC_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x80300109L)")]
    public const int PLA_E_DC_ALREADY_EXISTS = unchecked((int)(0x80300109));

    [NativeTypeName("#define PLA_E_DCS_START_WAIT_TIMEOUT _HRESULT_TYPEDEF_(0x8030010AL)")]
    public const int PLA_E_DCS_START_WAIT_TIMEOUT = unchecked((int)(0x8030010A));

    [NativeTypeName("#define PLA_E_DC_START_WAIT_TIMEOUT _HRESULT_TYPEDEF_(0x8030010BL)")]
    public const int PLA_E_DC_START_WAIT_TIMEOUT = unchecked((int)(0x8030010B));

    [NativeTypeName("#define PLA_E_REPORT_WAIT_TIMEOUT _HRESULT_TYPEDEF_(0x8030010CL)")]
    public const int PLA_E_REPORT_WAIT_TIMEOUT = unchecked((int)(0x8030010C));

    [NativeTypeName("#define PLA_E_NO_DUPLICATES _HRESULT_TYPEDEF_(0x8030010DL)")]
    public const int PLA_E_NO_DUPLICATES = unchecked((int)(0x8030010D));

    [NativeTypeName("#define PLA_E_EXE_FULL_PATH_REQUIRED _HRESULT_TYPEDEF_(0x8030010EL)")]
    public const int PLA_E_EXE_FULL_PATH_REQUIRED = unchecked((int)(0x8030010E));

    [NativeTypeName("#define PLA_E_INVALID_SESSION_NAME _HRESULT_TYPEDEF_(0x8030010FL)")]
    public const int PLA_E_INVALID_SESSION_NAME = unchecked((int)(0x8030010F));

    [NativeTypeName("#define PLA_E_PLA_CHANNEL_NOT_ENABLED _HRESULT_TYPEDEF_(0x80300110L)")]
    public const int PLA_E_PLA_CHANNEL_NOT_ENABLED = unchecked((int)(0x80300110));

    [NativeTypeName("#define PLA_E_TASKSCHED_CHANNEL_NOT_ENABLED _HRESULT_TYPEDEF_(0x80300111L)")]
    public const int PLA_E_TASKSCHED_CHANNEL_NOT_ENABLED = unchecked((int)(0x80300111));

    [NativeTypeName("#define PLA_E_RULES_MANAGER_FAILED _HRESULT_TYPEDEF_(0x80300112L)")]
    public const int PLA_E_RULES_MANAGER_FAILED = unchecked((int)(0x80300112));

    [NativeTypeName("#define PLA_E_CABAPI_FAILURE _HRESULT_TYPEDEF_(0x80300113L)")]
    public const int PLA_E_CABAPI_FAILURE = unchecked((int)(0x80300113));
}
