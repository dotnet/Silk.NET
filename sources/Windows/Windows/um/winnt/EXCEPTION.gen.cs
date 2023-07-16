// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class EXCEPTION
{
    [NativeTypeName("#define EXCEPTION_READ_FAULT 0")]
    public const int EXCEPTION_READ_FAULT = 0;
    [NativeTypeName("#define EXCEPTION_WRITE_FAULT 1")]
    public const int EXCEPTION_WRITE_FAULT = 1;
    [NativeTypeName("#define EXCEPTION_EXECUTE_FAULT 8")]
    public const int EXCEPTION_EXECUTE_FAULT = 8;
    [NativeTypeName("#define EXCEPTION_NONCONTINUABLE 0x1")]
    public const int EXCEPTION_NONCONTINUABLE = 0x1;
    [NativeTypeName("#define EXCEPTION_UNWINDING 0x2")]
    public const int EXCEPTION_UNWINDING = 0x2;
    [NativeTypeName("#define EXCEPTION_EXIT_UNWIND 0x4")]
    public const int EXCEPTION_EXIT_UNWIND = 0x4;
    [NativeTypeName("#define EXCEPTION_STACK_INVALID 0x8")]
    public const int EXCEPTION_STACK_INVALID = 0x8;
    [NativeTypeName("#define EXCEPTION_NESTED_CALL 0x10")]
    public const int EXCEPTION_NESTED_CALL = 0x10;
    [NativeTypeName("#define EXCEPTION_TARGET_UNWIND 0x20")]
    public const int EXCEPTION_TARGET_UNWIND = 0x20;
    [NativeTypeName("#define EXCEPTION_COLLIDED_UNWIND 0x40")]
    public const int EXCEPTION_COLLIDED_UNWIND = 0x40;
    [NativeTypeName("#define EXCEPTION_SOFTWARE_ORIGINATE 0x80")]
    public const int EXCEPTION_SOFTWARE_ORIGINATE = 0x80;
    [NativeTypeName("#define EXCEPTION_UNWIND (EXCEPTION_UNWINDING | EXCEPTION_EXIT_UNWIND | \\\r\n                          EXCEPTION_TARGET_UNWIND | EXCEPTION_COLLIDED_UNWIND)")]
    public const int EXCEPTION_UNWIND = (0x2 | 0x4 | 0x20 | 0x40);
    [NativeTypeName("#define EXCEPTION_MAXIMUM_PARAMETERS 15")]
    public const int EXCEPTION_MAXIMUM_PARAMETERS = 15;
}