// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SCHED
{
    [NativeTypeName("#define SCHED_E_SERVICE_NOT_LOCALSYSTEM 6200L")]
    public const int SCHED_E_SERVICE_NOT_LOCALSYSTEM = 6200;

    [NativeTypeName("#define SCHED_S_TASK_READY _HRESULT_TYPEDEF_(0x00041300L)")]
    public const int SCHED_S_TASK_READY = ((int)(0x00041300));

    [NativeTypeName("#define SCHED_S_TASK_RUNNING _HRESULT_TYPEDEF_(0x00041301L)")]
    public const int SCHED_S_TASK_RUNNING = ((int)(0x00041301));

    [NativeTypeName("#define SCHED_S_TASK_DISABLED _HRESULT_TYPEDEF_(0x00041302L)")]
    public const int SCHED_S_TASK_DISABLED = ((int)(0x00041302));

    [NativeTypeName("#define SCHED_S_TASK_HAS_NOT_RUN _HRESULT_TYPEDEF_(0x00041303L)")]
    public const int SCHED_S_TASK_HAS_NOT_RUN = ((int)(0x00041303));

    [NativeTypeName("#define SCHED_S_TASK_NO_MORE_RUNS _HRESULT_TYPEDEF_(0x00041304L)")]
    public const int SCHED_S_TASK_NO_MORE_RUNS = ((int)(0x00041304));

    [NativeTypeName("#define SCHED_S_TASK_NOT_SCHEDULED _HRESULT_TYPEDEF_(0x00041305L)")]
    public const int SCHED_S_TASK_NOT_SCHEDULED = ((int)(0x00041305));

    [NativeTypeName("#define SCHED_S_TASK_TERMINATED _HRESULT_TYPEDEF_(0x00041306L)")]
    public const int SCHED_S_TASK_TERMINATED = ((int)(0x00041306));

    [NativeTypeName("#define SCHED_S_TASK_NO_VALID_TRIGGERS _HRESULT_TYPEDEF_(0x00041307L)")]
    public const int SCHED_S_TASK_NO_VALID_TRIGGERS = ((int)(0x00041307));

    [NativeTypeName("#define SCHED_S_EVENT_TRIGGER _HRESULT_TYPEDEF_(0x00041308L)")]
    public const int SCHED_S_EVENT_TRIGGER = ((int)(0x00041308));

    [NativeTypeName("#define SCHED_E_TRIGGER_NOT_FOUND _HRESULT_TYPEDEF_(0x80041309L)")]
    public const int SCHED_E_TRIGGER_NOT_FOUND = unchecked((int)(0x80041309));

    [NativeTypeName("#define SCHED_E_TASK_NOT_READY _HRESULT_TYPEDEF_(0x8004130AL)")]
    public const int SCHED_E_TASK_NOT_READY = unchecked((int)(0x8004130A));

    [NativeTypeName("#define SCHED_E_TASK_NOT_RUNNING _HRESULT_TYPEDEF_(0x8004130BL)")]
    public const int SCHED_E_TASK_NOT_RUNNING = unchecked((int)(0x8004130B));

    [NativeTypeName("#define SCHED_E_SERVICE_NOT_INSTALLED _HRESULT_TYPEDEF_(0x8004130CL)")]
    public const int SCHED_E_SERVICE_NOT_INSTALLED = unchecked((int)(0x8004130C));

    [NativeTypeName("#define SCHED_E_CANNOT_OPEN_TASK _HRESULT_TYPEDEF_(0x8004130DL)")]
    public const int SCHED_E_CANNOT_OPEN_TASK = unchecked((int)(0x8004130D));

    [NativeTypeName("#define SCHED_E_INVALID_TASK _HRESULT_TYPEDEF_(0x8004130EL)")]
    public const int SCHED_E_INVALID_TASK = unchecked((int)(0x8004130E));

    [NativeTypeName("#define SCHED_E_ACCOUNT_INFORMATION_NOT_SET _HRESULT_TYPEDEF_(0x8004130FL)")]
    public const int SCHED_E_ACCOUNT_INFORMATION_NOT_SET = unchecked((int)(0x8004130F));

    [NativeTypeName("#define SCHED_E_ACCOUNT_NAME_NOT_FOUND _HRESULT_TYPEDEF_(0x80041310L)")]
    public const int SCHED_E_ACCOUNT_NAME_NOT_FOUND = unchecked((int)(0x80041310));

    [NativeTypeName("#define SCHED_E_ACCOUNT_DBASE_CORRUPT _HRESULT_TYPEDEF_(0x80041311L)")]
    public const int SCHED_E_ACCOUNT_DBASE_CORRUPT = unchecked((int)(0x80041311));

    [NativeTypeName("#define SCHED_E_NO_SECURITY_SERVICES _HRESULT_TYPEDEF_(0x80041312L)")]
    public const int SCHED_E_NO_SECURITY_SERVICES = unchecked((int)(0x80041312));

    [NativeTypeName("#define SCHED_E_UNKNOWN_OBJECT_VERSION _HRESULT_TYPEDEF_(0x80041313L)")]
    public const int SCHED_E_UNKNOWN_OBJECT_VERSION = unchecked((int)(0x80041313));

    [NativeTypeName("#define SCHED_E_UNSUPPORTED_ACCOUNT_OPTION _HRESULT_TYPEDEF_(0x80041314L)")]
    public const int SCHED_E_UNSUPPORTED_ACCOUNT_OPTION = unchecked((int)(0x80041314));

    [NativeTypeName("#define SCHED_E_SERVICE_NOT_RUNNING _HRESULT_TYPEDEF_(0x80041315L)")]
    public const int SCHED_E_SERVICE_NOT_RUNNING = unchecked((int)(0x80041315));

    [NativeTypeName("#define SCHED_E_UNEXPECTEDNODE _HRESULT_TYPEDEF_(0x80041316L)")]
    public const int SCHED_E_UNEXPECTEDNODE = unchecked((int)(0x80041316));

    [NativeTypeName("#define SCHED_E_NAMESPACE _HRESULT_TYPEDEF_(0x80041317L)")]
    public const int SCHED_E_NAMESPACE = unchecked((int)(0x80041317));

    [NativeTypeName("#define SCHED_E_INVALIDVALUE _HRESULT_TYPEDEF_(0x80041318L)")]
    public const int SCHED_E_INVALIDVALUE = unchecked((int)(0x80041318));

    [NativeTypeName("#define SCHED_E_MISSINGNODE _HRESULT_TYPEDEF_(0x80041319L)")]
    public const int SCHED_E_MISSINGNODE = unchecked((int)(0x80041319));

    [NativeTypeName("#define SCHED_E_MALFORMEDXML _HRESULT_TYPEDEF_(0x8004131AL)")]
    public const int SCHED_E_MALFORMEDXML = unchecked((int)(0x8004131A));

    [NativeTypeName("#define SCHED_S_SOME_TRIGGERS_FAILED _HRESULT_TYPEDEF_(0x0004131BL)")]
    public const int SCHED_S_SOME_TRIGGERS_FAILED = ((int)(0x0004131B));

    [NativeTypeName("#define SCHED_S_BATCH_LOGON_PROBLEM _HRESULT_TYPEDEF_(0x0004131CL)")]
    public const int SCHED_S_BATCH_LOGON_PROBLEM = ((int)(0x0004131C));

    [NativeTypeName("#define SCHED_E_TOO_MANY_NODES _HRESULT_TYPEDEF_(0x8004131DL)")]
    public const int SCHED_E_TOO_MANY_NODES = unchecked((int)(0x8004131D));

    [NativeTypeName("#define SCHED_E_PAST_END_BOUNDARY _HRESULT_TYPEDEF_(0x8004131EL)")]
    public const int SCHED_E_PAST_END_BOUNDARY = unchecked((int)(0x8004131E));

    [NativeTypeName("#define SCHED_E_ALREADY_RUNNING _HRESULT_TYPEDEF_(0x8004131FL)")]
    public const int SCHED_E_ALREADY_RUNNING = unchecked((int)(0x8004131F));

    [NativeTypeName("#define SCHED_E_USER_NOT_LOGGED_ON _HRESULT_TYPEDEF_(0x80041320L)")]
    public const int SCHED_E_USER_NOT_LOGGED_ON = unchecked((int)(0x80041320));

    [NativeTypeName("#define SCHED_E_INVALID_TASK_HASH _HRESULT_TYPEDEF_(0x80041321L)")]
    public const int SCHED_E_INVALID_TASK_HASH = unchecked((int)(0x80041321));

    [NativeTypeName("#define SCHED_E_SERVICE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80041322L)")]
    public const int SCHED_E_SERVICE_NOT_AVAILABLE = unchecked((int)(0x80041322));

    [NativeTypeName("#define SCHED_E_SERVICE_TOO_BUSY _HRESULT_TYPEDEF_(0x80041323L)")]
    public const int SCHED_E_SERVICE_TOO_BUSY = unchecked((int)(0x80041323));

    [NativeTypeName("#define SCHED_E_TASK_ATTEMPTED _HRESULT_TYPEDEF_(0x80041324L)")]
    public const int SCHED_E_TASK_ATTEMPTED = unchecked((int)(0x80041324));

    [NativeTypeName("#define SCHED_S_TASK_QUEUED _HRESULT_TYPEDEF_(0x00041325L)")]
    public const int SCHED_S_TASK_QUEUED = ((int)(0x00041325));

    [NativeTypeName("#define SCHED_E_TASK_DISABLED _HRESULT_TYPEDEF_(0x80041326L)")]
    public const int SCHED_E_TASK_DISABLED = unchecked((int)(0x80041326));

    [NativeTypeName("#define SCHED_E_TASK_NOT_V1_COMPAT _HRESULT_TYPEDEF_(0x80041327L)")]
    public const int SCHED_E_TASK_NOT_V1_COMPAT = unchecked((int)(0x80041327));

    [NativeTypeName("#define SCHED_E_START_ON_DEMAND _HRESULT_TYPEDEF_(0x80041328L)")]
    public const int SCHED_E_START_ON_DEMAND = unchecked((int)(0x80041328));

    [NativeTypeName("#define SCHED_E_TASK_NOT_UBPM_COMPAT _HRESULT_TYPEDEF_(0x80041329L)")]
    public const int SCHED_E_TASK_NOT_UBPM_COMPAT = unchecked((int)(0x80041329));

    [NativeTypeName("#define SCHED_E_DEPRECATED_FEATURE_USED _HRESULT_TYPEDEF_(0x80041330L)")]
    public const int SCHED_E_DEPRECATED_FEATURE_USED = unchecked((int)(0x80041330));
}
