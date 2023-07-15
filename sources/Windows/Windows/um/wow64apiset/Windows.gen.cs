// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wow64apiset.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Wow64EnableWow64FsRedirection"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte Wow64EnableWow64FsRedirection([NativeTypeName("BOOLEAN")] byte Wow64FsEnableRedirection);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Wow64DisableWow64FsRedirection"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Wow64DisableWow64FsRedirection([NativeTypeName("PVOID *")] void** OldValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Wow64RevertWow64FsRedirection"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Wow64RevertWow64FsRedirection([NativeTypeName("PVOID")] void* OlValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsWow64Process"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsWow64Process(HANDLE hProcess, [NativeTypeName("PBOOL")] BOOL* Wow64Process);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemWow64DirectoryA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetSystemWow64DirectoryA([NativeTypeName("LPSTR")] sbyte* lpBuffer, uint uSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemWow64DirectoryW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetSystemWow64DirectoryW([NativeTypeName("LPWSTR")] ushort* lpBuffer, uint uSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsWow64Process2"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.10586.0")]
    public static extern BOOL IsWow64Process2(HANDLE hProcess, ushort* pProcessMachine, ushort* pNativeMachine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemWow64Directory2A"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.10586.0")]
    public static extern uint GetSystemWow64Directory2A([NativeTypeName("LPSTR")] sbyte* lpBuffer, uint uSize, [NativeTypeName("WORD")] ushort ImageFileMachineType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSystemWow64Directory2W"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.10586.0")]
    public static extern uint GetSystemWow64Directory2W([NativeTypeName("LPWSTR")] ushort* lpBuffer, uint uSize, [NativeTypeName("WORD")] ushort ImageFileMachineType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsWow64GuestMachineSupported"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.16299.0")]
    public static extern HRESULT IsWow64GuestMachineSupported(ushort WowGuestMachine, BOOL* MachineIsSupported);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Wow64GetThreadContext"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL Wow64GetThreadContext(HANDLE hThread, [NativeTypeName("PWOW64_CONTEXT")] WOW64_CONTEXT* lpContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Wow64SetThreadContext"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL Wow64SetThreadContext(HANDLE hThread, [NativeTypeName("const WOW64_CONTEXT *")] WOW64_CONTEXT* lpContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Wow64SuspendThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint Wow64SuspendThread(HANDLE hThread);
    [NativeTypeName("#define GetSystemWow64Directory GetSystemWow64DirectoryW")]
    public static delegate*<ushort*, uint, uint> GetSystemWow64Directory => &GetSystemWow64DirectoryW;

    [NativeTypeName("#define GetSystemWow64Directory2 GetSystemWow64Directory2W")]
    [SupportedOSPlatform("windows10.0.10586.0")]
    public static delegate*<ushort*, uint, ushort, uint> GetSystemWow64Directory2 => &GetSystemWow64Directory2W;
}