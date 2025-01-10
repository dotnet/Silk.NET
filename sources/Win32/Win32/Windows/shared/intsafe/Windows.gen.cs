// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/intsafe.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define _ARM64_MULT_INTRINS_SUPPORTED 0")]
    public const int _ARM64_MULT_INTRINS_SUPPORTED = 0;

    [NativeTypeName("#define INTSAFE_E_ARITHMETIC_OVERFLOW ((HRESULT)0x80070216L)")]
    public const int INTSAFE_E_ARITHMETIC_OVERFLOW = unchecked((int)(0x80070216));

    [NativeTypeName("#define INT8_MIN (-127i8 - 1)")]
    public const int INT8_MIN = (-127 - 1);

    [NativeTypeName("#define SHORT_MIN (-32768)")]
    public const int SHORT_MIN = (-32768);

    [NativeTypeName("#define INT16_MIN (-32767i16 - 1)")]
    public const int INT16_MIN = (-32767 - 1);

    [NativeTypeName("#define INT32_MIN (-2147483647i32 - 1)")]
    public const int INT32_MIN = (-2147483647 - 1);

    [NativeTypeName("#define LONGLONG_MIN (-9223372036854775807i64 - 1)")]
    public const long LONGLONG_MIN = (-9223372036854775807L - 1);

    [NativeTypeName("#define LONG64_MIN (-9223372036854775807i64 - 1)")]
    public const long LONG64_MIN = (-9223372036854775807L - 1);

    [NativeTypeName("#define INT64_MIN (-9223372036854775807i64 - 1)")]
    public const long INT64_MIN = (-9223372036854775807L - 1);

    [NativeTypeName("#define INT8_MAX 127i8")]
    public const sbyte INT8_MAX = 127;

    [NativeTypeName("#define UINT8_MAX 0xffui8")]
    public const byte UINT8_MAX = unchecked(0xff);

    [NativeTypeName("#define BYTE_MAX 0xff")]
    public const int BYTE_MAX = 0xff;

    [NativeTypeName("#define SHORT_MAX 32767")]
    public const int SHORT_MAX = 32767;

    [NativeTypeName("#define INT16_MAX 32767i16")]
    public const short INT16_MAX = 32767;

    [NativeTypeName("#define USHORT_MAX 0xffff")]
    public const int USHORT_MAX = 0xffff;

    [NativeTypeName("#define UINT16_MAX 0xffffui16")]
    public const ushort UINT16_MAX = unchecked(0xffff);

    [NativeTypeName("#define WORD_MAX 0xffff")]
    public const int WORD_MAX = 0xffff;

    [NativeTypeName("#define INT32_MAX 2147483647i32")]
    public const int INT32_MAX = 2147483647;

    [NativeTypeName("#define UINT32_MAX 0xffffffffui32")]
    public const uint UINT32_MAX = 0xffffffffU;

    [NativeTypeName("#define DWORD_MAX 0xffffffffUL")]
    public const uint DWORD_MAX = 0xffffffffU;

    [NativeTypeName("#define LONGLONG_MAX 9223372036854775807i64")]
    public const long LONGLONG_MAX = 9223372036854775807L;

    [NativeTypeName("#define LONG64_MAX 9223372036854775807i64")]
    public const long LONG64_MAX = 9223372036854775807L;

    [NativeTypeName("#define INT64_MAX 9223372036854775807i64")]
    public const long INT64_MAX = 9223372036854775807L;

    [NativeTypeName("#define ULONGLONG_MAX 0xffffffffffffffffui64")]
    public const ulong ULONGLONG_MAX = 0xffffffffffffffffUL;

    [NativeTypeName("#define DWORDLONG_MAX 0xffffffffffffffffui64")]
    public const ulong DWORDLONG_MAX = 0xffffffffffffffffUL;

    [NativeTypeName("#define ULONG64_MAX 0xffffffffffffffffui64")]
    public const ulong ULONG64_MAX = 0xffffffffffffffffUL;

    [NativeTypeName("#define DWORD64_MAX 0xffffffffffffffffui64")]
    public const ulong DWORD64_MAX = 0xffffffffffffffffUL;

    [NativeTypeName("#define UINT64_MAX 0xffffffffffffffffui64")]
    public const ulong UINT64_MAX = 0xffffffffffffffffUL;

    [NativeTypeName("#define INT8_ERROR (-1i8)")]
    public const int INT8_ERROR = (-1);

    [NativeTypeName("#define UINT8_ERROR 0xffui8")]
    public const byte UINT8_ERROR = unchecked(0xff);

    [NativeTypeName("#define BYTE_ERROR 0xff")]
    public const int BYTE_ERROR = 0xff;

    [NativeTypeName("#define SHORT_ERROR (-1)")]
    public const int SHORT_ERROR = (-1);

    [NativeTypeName("#define INT16_ERROR (-1i16)")]
    public const int INT16_ERROR = (-1);

    [NativeTypeName("#define USHORT_ERROR 0xffff")]
    public const int USHORT_ERROR = 0xffff;

    [NativeTypeName("#define UINT16_ERROR 0xffffui16")]
    public const ushort UINT16_ERROR = unchecked(0xffff);

    [NativeTypeName("#define WORD_ERROR 0xffff")]
    public const int WORD_ERROR = 0xffff;

    [NativeTypeName("#define INT_ERROR (-1)")]
    public const int INT_ERROR = (-1);

    [NativeTypeName("#define INT32_ERROR (-1i32)")]
    public const int INT32_ERROR = (-1);

    [NativeTypeName("#define UINT_ERROR 0xffffffff")]
    public const uint UINT_ERROR = 0xffffffff;

    [NativeTypeName("#define UINT32_ERROR 0xffffffffui32")]
    public const uint UINT32_ERROR = 0xffffffffU;

    [NativeTypeName("#define LONG_ERROR (-1L)")]
    public const int LONG_ERROR = (-1);

    [NativeTypeName("#define ULONG_ERROR 0xffffffffUL")]
    public const uint ULONG_ERROR = 0xffffffffU;

    [NativeTypeName("#define DWORD_ERROR 0xffffffffUL")]
    public const uint DWORD_ERROR = 0xffffffffU;

    [NativeTypeName("#define LONGLONG_ERROR (-1i64)")]
    public const long LONGLONG_ERROR = (-1L);

    [NativeTypeName("#define LONG64_ERROR (-1i64)")]
    public const long LONG64_ERROR = (-1L);

    [NativeTypeName("#define INT64_ERROR (-1i64)")]
    public const long INT64_ERROR = (-1L);

    [NativeTypeName("#define ULONGLONG_ERROR 0xffffffffffffffffui64")]
    public const ulong ULONGLONG_ERROR = 0xffffffffffffffffUL;

    [NativeTypeName("#define DWORDLONG_ERROR 0xffffffffffffffffui64")]
    public const ulong DWORDLONG_ERROR = 0xffffffffffffffffUL;

    [NativeTypeName("#define ULONG64_ERROR 0xffffffffffffffffui64")]
    public const ulong ULONG64_ERROR = 0xffffffffffffffffUL;

    [NativeTypeName("#define UINT64_ERROR 0xffffffffffffffffui64")]
    public const ulong UINT64_ERROR = 0xffffffffffffffffUL;
}
