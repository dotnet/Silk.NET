// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WER
{
    [NativeTypeName("#define WER_S_REPORT_DEBUG _HRESULT_TYPEDEF_(0x001B0000L)")]
    public const int WER_S_REPORT_DEBUG = ((int)(0x001B0000));

    [NativeTypeName("#define WER_S_REPORT_UPLOADED _HRESULT_TYPEDEF_(0x001B0001L)")]
    public const int WER_S_REPORT_UPLOADED = ((int)(0x001B0001));

    [NativeTypeName("#define WER_S_REPORT_QUEUED _HRESULT_TYPEDEF_(0x001B0002L)")]
    public const int WER_S_REPORT_QUEUED = ((int)(0x001B0002));

    [NativeTypeName("#define WER_S_DISABLED _HRESULT_TYPEDEF_(0x001B0003L)")]
    public const int WER_S_DISABLED = ((int)(0x001B0003));

    [NativeTypeName("#define WER_S_SUSPENDED_UPLOAD _HRESULT_TYPEDEF_(0x001B0004L)")]
    public const int WER_S_SUSPENDED_UPLOAD = ((int)(0x001B0004));

    [NativeTypeName("#define WER_S_DISABLED_QUEUE _HRESULT_TYPEDEF_(0x001B0005L)")]
    public const int WER_S_DISABLED_QUEUE = ((int)(0x001B0005));

    [NativeTypeName("#define WER_S_DISABLED_ARCHIVE _HRESULT_TYPEDEF_(0x001B0006L)")]
    public const int WER_S_DISABLED_ARCHIVE = ((int)(0x001B0006));

    [NativeTypeName("#define WER_S_REPORT_ASYNC _HRESULT_TYPEDEF_(0x001B0007L)")]
    public const int WER_S_REPORT_ASYNC = ((int)(0x001B0007));

    [NativeTypeName("#define WER_S_IGNORE_ASSERT_INSTANCE _HRESULT_TYPEDEF_(0x001B0008L)")]
    public const int WER_S_IGNORE_ASSERT_INSTANCE = ((int)(0x001B0008));

    [NativeTypeName("#define WER_S_IGNORE_ALL_ASSERTS _HRESULT_TYPEDEF_(0x001B0009L)")]
    public const int WER_S_IGNORE_ALL_ASSERTS = ((int)(0x001B0009));

    [NativeTypeName("#define WER_S_ASSERT_CONTINUE _HRESULT_TYPEDEF_(0x001B000AL)")]
    public const int WER_S_ASSERT_CONTINUE = ((int)(0x001B000A));

    [NativeTypeName("#define WER_S_THROTTLED _HRESULT_TYPEDEF_(0x001B000BL)")]
    public const int WER_S_THROTTLED = ((int)(0x001B000B));

    [NativeTypeName("#define WER_S_REPORT_UPLOADED_CAB _HRESULT_TYPEDEF_(0x001B000CL)")]
    public const int WER_S_REPORT_UPLOADED_CAB = ((int)(0x001B000C));

    [NativeTypeName("#define WER_E_CRASH_FAILURE _HRESULT_TYPEDEF_(0x801B8000L)")]
    public const int WER_E_CRASH_FAILURE = unchecked((int)(0x801B8000));

    [NativeTypeName("#define WER_E_CANCELED _HRESULT_TYPEDEF_(0x801B8001L)")]
    public const int WER_E_CANCELED = unchecked((int)(0x801B8001));

    [NativeTypeName("#define WER_E_NETWORK_FAILURE _HRESULT_TYPEDEF_(0x801B8002L)")]
    public const int WER_E_NETWORK_FAILURE = unchecked((int)(0x801B8002));

    [NativeTypeName("#define WER_E_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x801B8003L)")]
    public const int WER_E_NOT_INITIALIZED = unchecked((int)(0x801B8003));

    [NativeTypeName("#define WER_E_ALREADY_REPORTING _HRESULT_TYPEDEF_(0x801B8004L)")]
    public const int WER_E_ALREADY_REPORTING = unchecked((int)(0x801B8004));

    [NativeTypeName("#define WER_E_DUMP_THROTTLED _HRESULT_TYPEDEF_(0x801B8005L)")]
    public const int WER_E_DUMP_THROTTLED = unchecked((int)(0x801B8005));

    [NativeTypeName("#define WER_E_INSUFFICIENT_CONSENT _HRESULT_TYPEDEF_(0x801B8006L)")]
    public const int WER_E_INSUFFICIENT_CONSENT = unchecked((int)(0x801B8006));

    [NativeTypeName("#define WER_E_TOO_HEAVY _HRESULT_TYPEDEF_(0x801B8007L)")]
    public const int WER_E_TOO_HEAVY = unchecked((int)(0x801B8007));
}
