// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AllocConsole"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AllocConsole();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeConsole"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FreeConsole();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AttachConsole"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AttachConsole([NativeTypeName("DWORD")] uint dwProcessId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleCP"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetConsoleCP();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleOutputCP"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetConsoleOutputCP();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleMode"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetConsoleMode(HANDLE hConsoleHandle, [NativeTypeName("LPDWORD")] uint* lpMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetConsoleMode"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetConsoleMode(HANDLE hConsoleHandle, [NativeTypeName("DWORD")] uint dwMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNumberOfConsoleInputEvents"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumberOfConsoleInputEvents(HANDLE hConsoleInput, [NativeTypeName("LPDWORD")] uint* lpNumberOfEvents);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadConsoleInputA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadConsoleInputA(HANDLE hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadConsoleInputW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadConsoleInputW(HANDLE hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PeekConsoleInputA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PeekConsoleInputA(HANDLE hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PeekConsoleInputW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PeekConsoleInputW(HANDLE hConsoleInput, [NativeTypeName("PINPUT_RECORD")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsRead);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadConsoleA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadConsoleA(HANDLE hConsoleInput, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead, [NativeTypeName("PCONSOLE_READCONSOLE_CONTROL")] CONSOLE_READCONSOLE_CONTROL* pInputControl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadConsoleW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadConsoleW(HANDLE hConsoleInput, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead, [NativeTypeName("PCONSOLE_READCONSOLE_CONTROL")] CONSOLE_READCONSOLE_CONTROL* pInputControl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteConsoleA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteConsoleA(HANDLE hConsoleOutput, [NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten, [NativeTypeName("LPVOID")] void* lpReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteConsoleW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteConsoleW(HANDLE hConsoleOutput, [NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfCharsToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten, [NativeTypeName("LPVOID")] void* lpReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetConsoleCtrlHandler"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetConsoleCtrlHandler([NativeTypeName("PHANDLER_ROUTINE")] delegate* unmanaged<uint, BOOL> HandlerRoutine, BOOL Add);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreatePseudoConsole"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT CreatePseudoConsole(COORD size, HANDLE hInput, HANDLE hOutput, [NativeTypeName("DWORD")] uint dwFlags, HPCON* phPC);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ResizePseudoConsole"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT ResizePseudoConsole(HPCON hPC, COORD size);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ClosePseudoConsole"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ClosePseudoConsole(HPCON hPC);
    [NativeTypeName("#define ATTACH_PARENT_PROCESS ((DWORD)-1)")]
    public const uint ATTACH_PARENT_PROCESS = unchecked((uint)(-1));
    [NativeTypeName("#define DISABLE_NEWLINE_AUTO_RETURN 0x0008")]
    public const int DISABLE_NEWLINE_AUTO_RETURN = 0x0008;
    [NativeTypeName("#define ReadConsoleInput ReadConsoleInputW")]
    public static delegate*<HANDLE, INPUT_RECORD*, uint, uint*, BOOL> ReadConsoleInput => &ReadConsoleInputW;

    [NativeTypeName("#define PeekConsoleInput PeekConsoleInputW")]
    public static delegate*<HANDLE, INPUT_RECORD*, uint, uint*, BOOL> PeekConsoleInput => &PeekConsoleInputW;

    [NativeTypeName("#define ReadConsole ReadConsoleW")]
    public static delegate*<HANDLE, void*, uint, uint*, CONSOLE_READCONSOLE_CONTROL*, BOOL> ReadConsole => &ReadConsoleW;

    [NativeTypeName("#define WriteConsole WriteConsoleW")]
    public static delegate*<HANDLE, void*, uint, uint*, void*, BOOL> WriteConsole => &WriteConsoleW;

    [NativeTypeName("#define CTRL_C_EVENT 0")]
    public const int CTRL_C_EVENT = 0;
    [NativeTypeName("#define CTRL_BREAK_EVENT 1")]
    public const int CTRL_BREAK_EVENT = 1;
    [NativeTypeName("#define CTRL_CLOSE_EVENT 2")]
    public const int CTRL_CLOSE_EVENT = 2;
    [NativeTypeName("#define CTRL_LOGOFF_EVENT 5")]
    public const int CTRL_LOGOFF_EVENT = 5;
    [NativeTypeName("#define CTRL_SHUTDOWN_EVENT 6")]
    public const int CTRL_SHUTDOWN_EVENT = 6;
    [NativeTypeName("#define PSEUDOCONSOLE_INHERIT_CURSOR (0x1)")]
    public const int PSEUDOCONSOLE_INHERIT_CURSOR = (0x1);
}