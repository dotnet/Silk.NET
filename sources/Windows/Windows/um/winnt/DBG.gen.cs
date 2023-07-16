// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class DBG
{
    [NativeTypeName("#define DBG_EXCEPTION_HANDLED ((DWORD   )0x00010001L)")]
    public const uint DBG_EXCEPTION_HANDLED = ((uint)(0x00010001));
    [NativeTypeName("#define DBG_CONTINUE ((DWORD   )0x00010002L)")]
    public const uint DBG_CONTINUE = ((uint)(0x00010002));
    [NativeTypeName("#define DBG_REPLY_LATER ((DWORD   )0x40010001L)")]
    public const uint DBG_REPLY_LATER = ((uint)(0x40010001));
    [NativeTypeName("#define DBG_TERMINATE_THREAD ((DWORD   )0x40010003L)")]
    public const uint DBG_TERMINATE_THREAD = ((uint)(0x40010003));
    [NativeTypeName("#define DBG_TERMINATE_PROCESS ((DWORD   )0x40010004L)")]
    public const uint DBG_TERMINATE_PROCESS = ((uint)(0x40010004));
    [NativeTypeName("#define DBG_CONTROL_C ((DWORD   )0x40010005L)")]
    public const uint DBG_CONTROL_C = ((uint)(0x40010005));
    [NativeTypeName("#define DBG_PRINTEXCEPTION_C ((DWORD   )0x40010006L)")]
    public const uint DBG_PRINTEXCEPTION_C = ((uint)(0x40010006));
    [NativeTypeName("#define DBG_RIPEXCEPTION ((DWORD   )0x40010007L)")]
    public const uint DBG_RIPEXCEPTION = ((uint)(0x40010007));
    [NativeTypeName("#define DBG_CONTROL_BREAK ((DWORD   )0x40010008L)")]
    public const uint DBG_CONTROL_BREAK = ((uint)(0x40010008));
    [NativeTypeName("#define DBG_COMMAND_EXCEPTION ((DWORD   )0x40010009L)")]
    public const uint DBG_COMMAND_EXCEPTION = ((uint)(0x40010009));
    [NativeTypeName("#define DBG_PRINTEXCEPTION_WIDE_C ((DWORD   )0x4001000AL)")]
    public const uint DBG_PRINTEXCEPTION_WIDE_C = ((uint)(0x4001000A));
    [NativeTypeName("#define DBG_EXCEPTION_NOT_HANDLED ((DWORD   )0x80010001L)")]
    public const uint DBG_EXCEPTION_NOT_HANDLED = ((uint)(0x80010001));
}