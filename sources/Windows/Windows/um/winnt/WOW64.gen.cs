// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WOW64
{
    [NativeTypeName("#define WOW64_CONTEXT_i386 0x00010000")]
    public const int WOW64_CONTEXT_i386 = 0x00010000;
    [NativeTypeName("#define WOW64_CONTEXT_i486 0x00010000")]
    public const int WOW64_CONTEXT_i486 = 0x00010000;
    [NativeTypeName("#define WOW64_CONTEXT_CONTROL (WOW64_CONTEXT_i386 | 0x00000001L)")]
    public const int WOW64_CONTEXT_CONTROL = (0x00010000 | 0x00000001);
    [NativeTypeName("#define WOW64_CONTEXT_INTEGER (WOW64_CONTEXT_i386 | 0x00000002L)")]
    public const int WOW64_CONTEXT_INTEGER = (0x00010000 | 0x00000002);
    [NativeTypeName("#define WOW64_CONTEXT_SEGMENTS (WOW64_CONTEXT_i386 | 0x00000004L)")]
    public const int WOW64_CONTEXT_SEGMENTS = (0x00010000 | 0x00000004);
    [NativeTypeName("#define WOW64_CONTEXT_FLOATING_POINT (WOW64_CONTEXT_i386 | 0x00000008L)")]
    public const int WOW64_CONTEXT_FLOATING_POINT = (0x00010000 | 0x00000008);
    [NativeTypeName("#define WOW64_CONTEXT_DEBUG_REGISTERS (WOW64_CONTEXT_i386 | 0x00000010L)")]
    public const int WOW64_CONTEXT_DEBUG_REGISTERS = (0x00010000 | 0x00000010);
    [NativeTypeName("#define WOW64_CONTEXT_EXTENDED_REGISTERS (WOW64_CONTEXT_i386 | 0x00000020L)")]
    public const int WOW64_CONTEXT_EXTENDED_REGISTERS = (0x00010000 | 0x00000020);
    [NativeTypeName("#define WOW64_CONTEXT_FULL (WOW64_CONTEXT_CONTROL | WOW64_CONTEXT_INTEGER | WOW64_CONTEXT_SEGMENTS)")]
    public const int WOW64_CONTEXT_FULL = ((0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004));
    [NativeTypeName("#define WOW64_CONTEXT_ALL (WOW64_CONTEXT_CONTROL | WOW64_CONTEXT_INTEGER | WOW64_CONTEXT_SEGMENTS | \\\r\n                                 WOW64_CONTEXT_FLOATING_POINT | WOW64_CONTEXT_DEBUG_REGISTERS | \\\r\n                                 WOW64_CONTEXT_EXTENDED_REGISTERS)")]
    public const int WOW64_CONTEXT_ALL = ((0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004) | (0x00010000 | 0x00000008) | (0x00010000 | 0x00000010) | (0x00010000 | 0x00000020));
    [NativeTypeName("#define WOW64_CONTEXT_XSTATE (WOW64_CONTEXT_i386 | 0x00000040L)")]
    public const int WOW64_CONTEXT_XSTATE = (0x00010000 | 0x00000040);
    [NativeTypeName("#define WOW64_CONTEXT_EXCEPTION_ACTIVE 0x08000000")]
    public const int WOW64_CONTEXT_EXCEPTION_ACTIVE = 0x08000000;
    [NativeTypeName("#define WOW64_CONTEXT_SERVICE_ACTIVE 0x10000000")]
    public const int WOW64_CONTEXT_SERVICE_ACTIVE = 0x10000000;
    [NativeTypeName("#define WOW64_CONTEXT_EXCEPTION_REQUEST 0x40000000")]
    public const int WOW64_CONTEXT_EXCEPTION_REQUEST = 0x40000000;
    [NativeTypeName("#define WOW64_CONTEXT_EXCEPTION_REPORTING 0x80000000")]
    public const uint WOW64_CONTEXT_EXCEPTION_REPORTING = 0x80000000;
    [NativeTypeName("#define WOW64_SIZE_OF_80387_REGISTERS 80")]
    public const int WOW64_SIZE_OF_80387_REGISTERS = 80;
    [NativeTypeName("#define WOW64_MAXIMUM_SUPPORTED_EXTENSION 512")]
    public const int WOW64_MAXIMUM_SUPPORTED_EXTENSION = 512;
}