// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetHotKey"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmGetHotKey([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPUINT")] uint* lpuModifiers, [NativeTypeName("LPUINT")] uint* lpuVKey, [NativeTypeName("LPHKL")] HKL* phKL);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmSetHotKey"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmSetHotKey([NativeTypeName("DWORD")] uint param0, uint param1, uint param2, HKL param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGenerateMessage"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmGenerateMessage(HIMC param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmRequestMessageA"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern LRESULT ImmRequestMessageA(HIMC param0, WPARAM param1, LPARAM param2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmRequestMessageW"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern LRESULT ImmRequestMessageW(HIMC param0, WPARAM param1, LPARAM param2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmCreateSoftKeyboard"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern HWND ImmCreateSoftKeyboard(uint param0, HWND param1, int param2, int param3);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmDestroySoftKeyboard"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmDestroySoftKeyboard(HWND param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmShowSoftKeyboard"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmShowSoftKeyboard(HWND param0, int param1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmLockIMC"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("LPINPUTCONTEXT")]
    public static extern INPUTCONTEXT* ImmLockIMC(HIMC param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmUnlockIMC"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmUnlockIMC(HIMC param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetIMCLockCount"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetIMCLockCount(HIMC param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmCreateIMCC"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern HIMCC ImmCreateIMCC([NativeTypeName("DWORD")] uint param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmDestroyIMCC"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern HIMCC ImmDestroyIMCC(HIMCC param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmLockIMCC"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* ImmLockIMCC(HIMCC param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmUnlockIMCC"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern BOOL ImmUnlockIMCC(HIMCC param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetIMCCLockCount"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetIMCCLockCount(HIMCC param0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmReSizeIMCC"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    public static extern HIMCC ImmReSizeIMCC(HIMCC param0, [NativeTypeName("DWORD")] uint param1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImmGetIMCCSize"]/*' />
    [DllImport("imm32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ImmGetIMCCSize(HIMCC param0);

    [NativeTypeName("#define ImmRequestMessage ImmRequestMessageW")]
    public static delegate*<HIMC, WPARAM, LPARAM, LRESULT> ImmRequestMessage => &ImmRequestMessageW;

    [NativeTypeName("#define IMMGWL_IMC 0")]
    public const int IMMGWL_IMC = 0;

    [NativeTypeName("#define IMMGWL_PRIVATE (sizeof(LONG))")]
    public const uint IMMGWL_PRIVATE = (4);

    [NativeTypeName("#define IMMGWLP_IMC 0")]
    public const int IMMGWLP_IMC = 0;

    [NativeTypeName("#define IMMGWLP_PRIVATE (sizeof(LONG_PTR))")]
    public static uint IMMGWLP_PRIVATE => unchecked((uint)((uint)(sizeof(nint))));
}
