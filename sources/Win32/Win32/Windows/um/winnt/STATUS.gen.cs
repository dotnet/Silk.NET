// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class STATUS
{
    [NativeTypeName("#define STATUS_WAIT_0 ((DWORD   )0x00000000L)")]
    public const uint STATUS_WAIT_0 = ((uint)(0x00000000));

    [NativeTypeName("#define STATUS_ABANDONED_WAIT_0 ((DWORD   )0x00000080L)")]
    public const uint STATUS_ABANDONED_WAIT_0 = ((uint)(0x00000080));

    [NativeTypeName("#define STATUS_USER_APC ((DWORD   )0x000000C0L)")]
    public const uint STATUS_USER_APC = ((uint)(0x000000C0));

    [NativeTypeName("#define STATUS_TIMEOUT ((DWORD   )0x00000102L)")]
    public const uint STATUS_TIMEOUT = ((uint)(0x00000102));

    [NativeTypeName("#define STATUS_PENDING ((DWORD   )0x00000103L)")]
    public const uint STATUS_PENDING = ((uint)(0x00000103));

    [NativeTypeName("#define STATUS_SEGMENT_NOTIFICATION ((DWORD   )0x40000005L)")]
    public const uint STATUS_SEGMENT_NOTIFICATION = ((uint)(0x40000005));

    [NativeTypeName("#define STATUS_FATAL_APP_EXIT ((DWORD   )0x40000015L)")]
    public const uint STATUS_FATAL_APP_EXIT = ((uint)(0x40000015));

    [NativeTypeName("#define STATUS_GUARD_PAGE_VIOLATION ((DWORD   )0x80000001L)")]
    public const uint STATUS_GUARD_PAGE_VIOLATION = ((uint)(0x80000001));

    [NativeTypeName("#define STATUS_DATATYPE_MISALIGNMENT ((DWORD   )0x80000002L)")]
    public const uint STATUS_DATATYPE_MISALIGNMENT = ((uint)(0x80000002));

    [NativeTypeName("#define STATUS_BREAKPOINT ((DWORD   )0x80000003L)")]
    public const uint STATUS_BREAKPOINT = ((uint)(0x80000003));

    [NativeTypeName("#define STATUS_SINGLE_STEP ((DWORD   )0x80000004L)")]
    public const uint STATUS_SINGLE_STEP = ((uint)(0x80000004));

    [NativeTypeName("#define STATUS_LONGJUMP ((DWORD   )0x80000026L)")]
    public const uint STATUS_LONGJUMP = ((uint)(0x80000026));

    [NativeTypeName("#define STATUS_UNWIND_CONSOLIDATE ((DWORD   )0x80000029L)")]
    public const uint STATUS_UNWIND_CONSOLIDATE = ((uint)(0x80000029));

    [NativeTypeName("#define STATUS_ACCESS_VIOLATION ((DWORD   )0xC0000005L)")]
    public const uint STATUS_ACCESS_VIOLATION = ((uint)(0xC0000005));

    [NativeTypeName("#define STATUS_IN_PAGE_ERROR ((DWORD   )0xC0000006L)")]
    public const uint STATUS_IN_PAGE_ERROR = ((uint)(0xC0000006));

    [NativeTypeName("#define STATUS_INVALID_HANDLE ((DWORD   )0xC0000008L)")]
    public const uint STATUS_INVALID_HANDLE = ((uint)(0xC0000008));

    [NativeTypeName("#define STATUS_INVALID_PARAMETER ((DWORD   )0xC000000DL)")]
    public const uint STATUS_INVALID_PARAMETER = ((uint)(0xC000000D));

    [NativeTypeName("#define STATUS_NO_MEMORY ((DWORD   )0xC0000017L)")]
    public const uint STATUS_NO_MEMORY = ((uint)(0xC0000017));

    [NativeTypeName("#define STATUS_ILLEGAL_INSTRUCTION ((DWORD   )0xC000001DL)")]
    public const uint STATUS_ILLEGAL_INSTRUCTION = ((uint)(0xC000001D));

    [NativeTypeName("#define STATUS_NONCONTINUABLE_EXCEPTION ((DWORD   )0xC0000025L)")]
    public const uint STATUS_NONCONTINUABLE_EXCEPTION = ((uint)(0xC0000025));

    [NativeTypeName("#define STATUS_INVALID_DISPOSITION ((DWORD   )0xC0000026L)")]
    public const uint STATUS_INVALID_DISPOSITION = ((uint)(0xC0000026));

    [NativeTypeName("#define STATUS_ARRAY_BOUNDS_EXCEEDED ((DWORD   )0xC000008CL)")]
    public const uint STATUS_ARRAY_BOUNDS_EXCEEDED = ((uint)(0xC000008C));

    [NativeTypeName("#define STATUS_FLOAT_DENORMAL_OPERAND ((DWORD   )0xC000008DL)")]
    public const uint STATUS_FLOAT_DENORMAL_OPERAND = ((uint)(0xC000008D));

    [NativeTypeName("#define STATUS_FLOAT_DIVIDE_BY_ZERO ((DWORD   )0xC000008EL)")]
    public const uint STATUS_FLOAT_DIVIDE_BY_ZERO = ((uint)(0xC000008E));

    [NativeTypeName("#define STATUS_FLOAT_INEXACT_RESULT ((DWORD   )0xC000008FL)")]
    public const uint STATUS_FLOAT_INEXACT_RESULT = ((uint)(0xC000008F));

    [NativeTypeName("#define STATUS_FLOAT_INVALID_OPERATION ((DWORD   )0xC0000090L)")]
    public const uint STATUS_FLOAT_INVALID_OPERATION = ((uint)(0xC0000090));

    [NativeTypeName("#define STATUS_FLOAT_OVERFLOW ((DWORD   )0xC0000091L)")]
    public const uint STATUS_FLOAT_OVERFLOW = ((uint)(0xC0000091));

    [NativeTypeName("#define STATUS_FLOAT_STACK_CHECK ((DWORD   )0xC0000092L)")]
    public const uint STATUS_FLOAT_STACK_CHECK = ((uint)(0xC0000092));

    [NativeTypeName("#define STATUS_FLOAT_UNDERFLOW ((DWORD   )0xC0000093L)")]
    public const uint STATUS_FLOAT_UNDERFLOW = ((uint)(0xC0000093));

    [NativeTypeName("#define STATUS_INTEGER_DIVIDE_BY_ZERO ((DWORD   )0xC0000094L)")]
    public const uint STATUS_INTEGER_DIVIDE_BY_ZERO = ((uint)(0xC0000094));

    [NativeTypeName("#define STATUS_INTEGER_OVERFLOW ((DWORD   )0xC0000095L)")]
    public const uint STATUS_INTEGER_OVERFLOW = ((uint)(0xC0000095));

    [NativeTypeName("#define STATUS_PRIVILEGED_INSTRUCTION ((DWORD   )0xC0000096L)")]
    public const uint STATUS_PRIVILEGED_INSTRUCTION = ((uint)(0xC0000096));

    [NativeTypeName("#define STATUS_STACK_OVERFLOW ((DWORD   )0xC00000FDL)")]
    public const uint STATUS_STACK_OVERFLOW = ((uint)(0xC00000FD));

    [NativeTypeName("#define STATUS_DLL_NOT_FOUND ((DWORD   )0xC0000135L)")]
    public const uint STATUS_DLL_NOT_FOUND = ((uint)(0xC0000135));

    [NativeTypeName("#define STATUS_ORDINAL_NOT_FOUND ((DWORD   )0xC0000138L)")]
    public const uint STATUS_ORDINAL_NOT_FOUND = ((uint)(0xC0000138));

    [NativeTypeName("#define STATUS_ENTRYPOINT_NOT_FOUND ((DWORD   )0xC0000139L)")]
    public const uint STATUS_ENTRYPOINT_NOT_FOUND = ((uint)(0xC0000139));

    [NativeTypeName("#define STATUS_CONTROL_C_EXIT ((DWORD   )0xC000013AL)")]
    public const uint STATUS_CONTROL_C_EXIT = ((uint)(0xC000013A));

    [NativeTypeName("#define STATUS_DLL_INIT_FAILED ((DWORD   )0xC0000142L)")]
    public const uint STATUS_DLL_INIT_FAILED = ((uint)(0xC0000142));

    [NativeTypeName("#define STATUS_CONTROL_STACK_VIOLATION ((DWORD   )0xC00001B2L)")]
    public const uint STATUS_CONTROL_STACK_VIOLATION = ((uint)(0xC00001B2));

    [NativeTypeName("#define STATUS_FLOAT_MULTIPLE_FAULTS ((DWORD   )0xC00002B4L)")]
    public const uint STATUS_FLOAT_MULTIPLE_FAULTS = ((uint)(0xC00002B4));

    [NativeTypeName("#define STATUS_FLOAT_MULTIPLE_TRAPS ((DWORD   )0xC00002B5L)")]
    public const uint STATUS_FLOAT_MULTIPLE_TRAPS = ((uint)(0xC00002B5));

    [NativeTypeName("#define STATUS_REG_NAT_CONSUMPTION ((DWORD   )0xC00002C9L)")]
    public const uint STATUS_REG_NAT_CONSUMPTION = ((uint)(0xC00002C9));

    [NativeTypeName("#define STATUS_HEAP_CORRUPTION ((DWORD   )0xC0000374L)")]
    public const uint STATUS_HEAP_CORRUPTION = ((uint)(0xC0000374));

    [NativeTypeName("#define STATUS_STACK_BUFFER_OVERRUN ((DWORD   )0xC0000409L)")]
    public const uint STATUS_STACK_BUFFER_OVERRUN = ((uint)(0xC0000409));

    [NativeTypeName("#define STATUS_INVALID_CRUNTIME_PARAMETER ((DWORD   )0xC0000417L)")]
    public const uint STATUS_INVALID_CRUNTIME_PARAMETER = ((uint)(0xC0000417));

    [NativeTypeName("#define STATUS_ASSERTION_FAILURE ((DWORD   )0xC0000420L)")]
    public const uint STATUS_ASSERTION_FAILURE = ((uint)(0xC0000420));

    [NativeTypeName("#define STATUS_ENCLAVE_VIOLATION ((DWORD   )0xC00004A2L)")]
    public const uint STATUS_ENCLAVE_VIOLATION = ((uint)(0xC00004A2));

    [NativeTypeName("#define STATUS_INTERRUPTED ((DWORD   )0xC0000515L)")]
    public const uint STATUS_INTERRUPTED = ((uint)(0xC0000515));

    [NativeTypeName("#define STATUS_THREAD_NOT_RUNNING ((DWORD   )0xC0000516L)")]
    public const uint STATUS_THREAD_NOT_RUNNING = ((uint)(0xC0000516));

    [NativeTypeName("#define STATUS_ALREADY_REGISTERED ((DWORD   )0xC0000718L)")]
    public const uint STATUS_ALREADY_REGISTERED = ((uint)(0xC0000718));

    [NativeTypeName("#define STATUS_SXS_EARLY_DEACTIVATION ((DWORD   )0xC015000FL)")]
    public const uint STATUS_SXS_EARLY_DEACTIVATION = ((uint)(0xC015000F));

    [NativeTypeName("#define STATUS_SXS_INVALID_DEACTIVATION ((DWORD   )0xC0150010L)")]
    public const uint STATUS_SXS_INVALID_DEACTIVATION = ((uint)(0xC0150010));
}
