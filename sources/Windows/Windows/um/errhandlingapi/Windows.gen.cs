// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/errhandlingapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RaiseException"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void RaiseException([NativeTypeName("DWORD")] uint dwExceptionCode, [NativeTypeName("DWORD")] uint dwExceptionFlags, [NativeTypeName("DWORD")] uint nNumberOfArguments, [NativeTypeName("const ULONG_PTR *")] nuint* lpArguments);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnhandledExceptionFilter"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int UnhandledExceptionFilter([NativeTypeName("struct _EXCEPTION_POINTERS *")] EXCEPTION_POINTERS* ExceptionInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetUnhandledExceptionFilter"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPTOP_LEVEL_EXCEPTION_FILTER")]
    public static extern delegate* unmanaged<EXCEPTION_POINTERS*, int> SetUnhandledExceptionFilter([NativeTypeName("LPTOP_LEVEL_EXCEPTION_FILTER")] delegate* unmanaged<EXCEPTION_POINTERS*, int> lpTopLevelExceptionFilter);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLastError"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SuppressGCTransition]
    public static extern uint GetLastError();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetLastError"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SuppressGCTransition]
    public static extern void SetLastError([NativeTypeName("DWORD")] uint dwErrCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetErrorMode"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetErrorMode();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetErrorMode"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint SetErrorMode(uint uMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddVectoredExceptionHandler"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("PVOID")]
    public static extern void* AddVectoredExceptionHandler([NativeTypeName("ULONG")] uint First, [NativeTypeName("PVECTORED_EXCEPTION_HANDLER")] delegate* unmanaged<EXCEPTION_POINTERS*, int> Handler);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveVectoredExceptionHandler"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint RemoveVectoredExceptionHandler([NativeTypeName("PVOID")] void* Handle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddVectoredContinueHandler"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("PVOID")]
    public static extern void* AddVectoredContinueHandler([NativeTypeName("ULONG")] uint First, [NativeTypeName("PVECTORED_EXCEPTION_HANDLER")] delegate* unmanaged<EXCEPTION_POINTERS*, int> Handler);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveVectoredContinueHandler"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint RemoveVectoredContinueHandler([NativeTypeName("PVOID")] void* Handle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RaiseFailFastException"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void RaiseFailFastException([NativeTypeName("PEXCEPTION_RECORD")] EXCEPTION_RECORD* pExceptionRecord, [NativeTypeName("PCONTEXT")] void* pContextRecord, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FatalAppExitA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void FatalAppExitA(uint uAction, [NativeTypeName("LPCSTR")] sbyte* lpMessageText);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FatalAppExitW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void FatalAppExitW(uint uAction, [NativeTypeName("LPCWSTR")] ushort* lpMessageText);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetThreadErrorMode"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetThreadErrorMode();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetThreadErrorMode"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SuppressGCTransition]
    public static extern BOOL SetThreadErrorMode([NativeTypeName("DWORD")] uint dwNewMode, [NativeTypeName("LPDWORD")] uint* lpOldMode);
    [NativeTypeName("#define FatalAppExit FatalAppExitW")]
    public static delegate*<uint, ushort*, void> FatalAppExit => &FatalAppExitW;
}