// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class FAST
{
    [NativeTypeName("#define FAST_FAIL_LEGACY_GS_VIOLATION 0")]
    public const int FAST_FAIL_LEGACY_GS_VIOLATION = 0;
    [NativeTypeName("#define FAST_FAIL_VTGUARD_CHECK_FAILURE 1")]
    public const int FAST_FAIL_VTGUARD_CHECK_FAILURE = 1;
    [NativeTypeName("#define FAST_FAIL_STACK_COOKIE_CHECK_FAILURE 2")]
    public const int FAST_FAIL_STACK_COOKIE_CHECK_FAILURE = 2;
    [NativeTypeName("#define FAST_FAIL_CORRUPT_LIST_ENTRY 3")]
    public const int FAST_FAIL_CORRUPT_LIST_ENTRY = 3;
    [NativeTypeName("#define FAST_FAIL_INCORRECT_STACK 4")]
    public const int FAST_FAIL_INCORRECT_STACK = 4;
    [NativeTypeName("#define FAST_FAIL_INVALID_ARG 5")]
    public const int FAST_FAIL_INVALID_ARG = 5;
    [NativeTypeName("#define FAST_FAIL_GS_COOKIE_INIT 6")]
    public const int FAST_FAIL_GS_COOKIE_INIT = 6;
    [NativeTypeName("#define FAST_FAIL_FATAL_APP_EXIT 7")]
    public const int FAST_FAIL_FATAL_APP_EXIT = 7;
    [NativeTypeName("#define FAST_FAIL_RANGE_CHECK_FAILURE 8")]
    public const int FAST_FAIL_RANGE_CHECK_FAILURE = 8;
    [NativeTypeName("#define FAST_FAIL_UNSAFE_REGISTRY_ACCESS 9")]
    public const int FAST_FAIL_UNSAFE_REGISTRY_ACCESS = 9;
    [NativeTypeName("#define FAST_FAIL_GUARD_ICALL_CHECK_FAILURE 10")]
    public const int FAST_FAIL_GUARD_ICALL_CHECK_FAILURE = 10;
    [NativeTypeName("#define FAST_FAIL_GUARD_WRITE_CHECK_FAILURE 11")]
    public const int FAST_FAIL_GUARD_WRITE_CHECK_FAILURE = 11;
    [NativeTypeName("#define FAST_FAIL_INVALID_FIBER_SWITCH 12")]
    public const int FAST_FAIL_INVALID_FIBER_SWITCH = 12;
    [NativeTypeName("#define FAST_FAIL_INVALID_SET_OF_CONTEXT 13")]
    public const int FAST_FAIL_INVALID_SET_OF_CONTEXT = 13;
    [NativeTypeName("#define FAST_FAIL_INVALID_REFERENCE_COUNT 14")]
    public const int FAST_FAIL_INVALID_REFERENCE_COUNT = 14;
    [NativeTypeName("#define FAST_FAIL_INVALID_JUMP_BUFFER 18")]
    public const int FAST_FAIL_INVALID_JUMP_BUFFER = 18;
    [NativeTypeName("#define FAST_FAIL_MRDATA_MODIFIED 19")]
    public const int FAST_FAIL_MRDATA_MODIFIED = 19;
    [NativeTypeName("#define FAST_FAIL_CERTIFICATION_FAILURE 20")]
    public const int FAST_FAIL_CERTIFICATION_FAILURE = 20;
    [NativeTypeName("#define FAST_FAIL_INVALID_EXCEPTION_CHAIN 21")]
    public const int FAST_FAIL_INVALID_EXCEPTION_CHAIN = 21;
    [NativeTypeName("#define FAST_FAIL_CRYPTO_LIBRARY 22")]
    public const int FAST_FAIL_CRYPTO_LIBRARY = 22;
    [NativeTypeName("#define FAST_FAIL_INVALID_CALL_IN_DLL_CALLOUT 23")]
    public const int FAST_FAIL_INVALID_CALL_IN_DLL_CALLOUT = 23;
    [NativeTypeName("#define FAST_FAIL_INVALID_IMAGE_BASE 24")]
    public const int FAST_FAIL_INVALID_IMAGE_BASE = 24;
    [NativeTypeName("#define FAST_FAIL_DLOAD_PROTECTION_FAILURE 25")]
    public const int FAST_FAIL_DLOAD_PROTECTION_FAILURE = 25;
    [NativeTypeName("#define FAST_FAIL_UNSAFE_EXTENSION_CALL 26")]
    public const int FAST_FAIL_UNSAFE_EXTENSION_CALL = 26;
    [NativeTypeName("#define FAST_FAIL_DEPRECATED_SERVICE_INVOKED 27")]
    public const int FAST_FAIL_DEPRECATED_SERVICE_INVOKED = 27;
    [NativeTypeName("#define FAST_FAIL_INVALID_BUFFER_ACCESS 28")]
    public const int FAST_FAIL_INVALID_BUFFER_ACCESS = 28;
    [NativeTypeName("#define FAST_FAIL_INVALID_BALANCED_TREE 29")]
    public const int FAST_FAIL_INVALID_BALANCED_TREE = 29;
    [NativeTypeName("#define FAST_FAIL_INVALID_NEXT_THREAD 30")]
    public const int FAST_FAIL_INVALID_NEXT_THREAD = 30;
    [NativeTypeName("#define FAST_FAIL_GUARD_ICALL_CHECK_SUPPRESSED 31")]
    public const int FAST_FAIL_GUARD_ICALL_CHECK_SUPPRESSED = 31;
    [NativeTypeName("#define FAST_FAIL_APCS_DISABLED 32")]
    public const int FAST_FAIL_APCS_DISABLED = 32;
    [NativeTypeName("#define FAST_FAIL_INVALID_IDLE_STATE 33")]
    public const int FAST_FAIL_INVALID_IDLE_STATE = 33;
    [NativeTypeName("#define FAST_FAIL_MRDATA_PROTECTION_FAILURE 34")]
    public const int FAST_FAIL_MRDATA_PROTECTION_FAILURE = 34;
    [NativeTypeName("#define FAST_FAIL_UNEXPECTED_HEAP_EXCEPTION 35")]
    public const int FAST_FAIL_UNEXPECTED_HEAP_EXCEPTION = 35;
    [NativeTypeName("#define FAST_FAIL_INVALID_LOCK_STATE 36")]
    public const int FAST_FAIL_INVALID_LOCK_STATE = 36;
    [NativeTypeName("#define FAST_FAIL_GUARD_JUMPTABLE 37")]
    public const int FAST_FAIL_GUARD_JUMPTABLE = 37;
    [NativeTypeName("#define FAST_FAIL_INVALID_LONGJUMP_TARGET 38")]
    public const int FAST_FAIL_INVALID_LONGJUMP_TARGET = 38;
    [NativeTypeName("#define FAST_FAIL_INVALID_DISPATCH_CONTEXT 39")]
    public const int FAST_FAIL_INVALID_DISPATCH_CONTEXT = 39;
    [NativeTypeName("#define FAST_FAIL_INVALID_THREAD 40")]
    public const int FAST_FAIL_INVALID_THREAD = 40;
    [NativeTypeName("#define FAST_FAIL_INVALID_SYSCALL_NUMBER 41")]
    public const int FAST_FAIL_INVALID_SYSCALL_NUMBER = 41;
    [NativeTypeName("#define FAST_FAIL_INVALID_FILE_OPERATION 42")]
    public const int FAST_FAIL_INVALID_FILE_OPERATION = 42;
    [NativeTypeName("#define FAST_FAIL_LPAC_ACCESS_DENIED 43")]
    public const int FAST_FAIL_LPAC_ACCESS_DENIED = 43;
    [NativeTypeName("#define FAST_FAIL_GUARD_SS_FAILURE 44")]
    public const int FAST_FAIL_GUARD_SS_FAILURE = 44;
    [NativeTypeName("#define FAST_FAIL_LOADER_CONTINUITY_FAILURE 45")]
    public const int FAST_FAIL_LOADER_CONTINUITY_FAILURE = 45;
    [NativeTypeName("#define FAST_FAIL_GUARD_EXPORT_SUPPRESSION_FAILURE 46")]
    public const int FAST_FAIL_GUARD_EXPORT_SUPPRESSION_FAILURE = 46;
    [NativeTypeName("#define FAST_FAIL_INVALID_CONTROL_STACK 47")]
    public const int FAST_FAIL_INVALID_CONTROL_STACK = 47;
    [NativeTypeName("#define FAST_FAIL_SET_CONTEXT_DENIED 48")]
    public const int FAST_FAIL_SET_CONTEXT_DENIED = 48;
    [NativeTypeName("#define FAST_FAIL_INVALID_IAT 49")]
    public const int FAST_FAIL_INVALID_IAT = 49;
    [NativeTypeName("#define FAST_FAIL_HEAP_METADATA_CORRUPTION 50")]
    public const int FAST_FAIL_HEAP_METADATA_CORRUPTION = 50;
    [NativeTypeName("#define FAST_FAIL_PAYLOAD_RESTRICTION_VIOLATION 51")]
    public const int FAST_FAIL_PAYLOAD_RESTRICTION_VIOLATION = 51;
    [NativeTypeName("#define FAST_FAIL_LOW_LABEL_ACCESS_DENIED 52")]
    public const int FAST_FAIL_LOW_LABEL_ACCESS_DENIED = 52;
    [NativeTypeName("#define FAST_FAIL_ENCLAVE_CALL_FAILURE 53")]
    public const int FAST_FAIL_ENCLAVE_CALL_FAILURE = 53;
    [NativeTypeName("#define FAST_FAIL_UNHANDLED_LSS_EXCEPTON 54")]
    public const int FAST_FAIL_UNHANDLED_LSS_EXCEPTON = 54;
    [NativeTypeName("#define FAST_FAIL_ADMINLESS_ACCESS_DENIED 55")]
    public const int FAST_FAIL_ADMINLESS_ACCESS_DENIED = 55;
    [NativeTypeName("#define FAST_FAIL_UNEXPECTED_CALL 56")]
    public const int FAST_FAIL_UNEXPECTED_CALL = 56;
    [NativeTypeName("#define FAST_FAIL_CONTROL_INVALID_RETURN_ADDRESS 57")]
    public const int FAST_FAIL_CONTROL_INVALID_RETURN_ADDRESS = 57;
    [NativeTypeName("#define FAST_FAIL_UNEXPECTED_HOST_BEHAVIOR 58")]
    public const int FAST_FAIL_UNEXPECTED_HOST_BEHAVIOR = 58;
    [NativeTypeName("#define FAST_FAIL_FLAGS_CORRUPTION 59")]
    public const int FAST_FAIL_FLAGS_CORRUPTION = 59;
    [NativeTypeName("#define FAST_FAIL_VEH_CORRUPTION 60")]
    public const int FAST_FAIL_VEH_CORRUPTION = 60;
    [NativeTypeName("#define FAST_FAIL_ETW_CORRUPTION 61")]
    public const int FAST_FAIL_ETW_CORRUPTION = 61;
    [NativeTypeName("#define FAST_FAIL_RIO_ABORT 62")]
    public const int FAST_FAIL_RIO_ABORT = 62;
    [NativeTypeName("#define FAST_FAIL_INVALID_PFN 63")]
    public const int FAST_FAIL_INVALID_PFN = 63;
    [NativeTypeName("#define FAST_FAIL_GUARD_ICALL_CHECK_FAILURE_XFG 64")]
    public const int FAST_FAIL_GUARD_ICALL_CHECK_FAILURE_XFG = 64;
    [NativeTypeName("#define FAST_FAIL_CAST_GUARD 65")]
    public const int FAST_FAIL_CAST_GUARD = 65;
    [NativeTypeName("#define FAST_FAIL_HOST_VISIBILITY_CHANGE 66")]
    public const int FAST_FAIL_HOST_VISIBILITY_CHANGE = 66;
    [NativeTypeName("#define FAST_FAIL_KERNEL_CET_SHADOW_STACK_ASSIST 67")]
    public const int FAST_FAIL_KERNEL_CET_SHADOW_STACK_ASSIST = 67;
    [NativeTypeName("#define FAST_FAIL_PATCH_CALLBACK_FAILED 68")]
    public const int FAST_FAIL_PATCH_CALLBACK_FAILED = 68;
    [NativeTypeName("#define FAST_FAIL_NTDLL_PATCH_FAILED 69")]
    public const int FAST_FAIL_NTDLL_PATCH_FAILED = 69;
    [NativeTypeName("#define FAST_FAIL_INVALID_FLS_DATA 70")]
    public const int FAST_FAIL_INVALID_FLS_DATA = 70;
    [NativeTypeName("#define FAST_FAIL_INVALID_FAST_FAIL_CODE 0xFFFFFFFF")]
    public const uint FAST_FAIL_INVALID_FAST_FAIL_CODE = 0xFFFFFFFF;
}