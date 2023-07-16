// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/consoleapi3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetNumberOfConsoleMouseButtons"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumberOfConsoleMouseButtons([NativeTypeName("LPDWORD")] uint* lpNumberOfMouseButtons);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleFontSize"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern COORD GetConsoleFontSize(HANDLE hConsoleOutput, [NativeTypeName("DWORD")] uint nFont);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentConsoleFont"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCurrentConsoleFont(HANDLE hConsoleOutput, BOOL bMaximumWindow, [NativeTypeName("PCONSOLE_FONT_INFO")] CONSOLE_FONT_INFO* lpConsoleCurrentFont);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentConsoleFontEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCurrentConsoleFontEx(HANDLE hConsoleOutput, BOOL bMaximumWindow, [NativeTypeName("PCONSOLE_FONT_INFOEX")] CONSOLE_FONT_INFOEX* lpConsoleCurrentFontEx);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCurrentConsoleFontEx"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCurrentConsoleFontEx(HANDLE hConsoleOutput, BOOL bMaximumWindow, [NativeTypeName("PCONSOLE_FONT_INFOEX")] CONSOLE_FONT_INFOEX* lpConsoleCurrentFontEx);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleSelectionInfo"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetConsoleSelectionInfo([NativeTypeName("PCONSOLE_SELECTION_INFO")] CONSOLE_SELECTION_INFO* lpConsoleSelectionInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleHistoryInfo"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetConsoleHistoryInfo([NativeTypeName("PCONSOLE_HISTORY_INFO")] CONSOLE_HISTORY_INFO* lpConsoleHistoryInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetConsoleHistoryInfo"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetConsoleHistoryInfo([NativeTypeName("PCONSOLE_HISTORY_INFO")] CONSOLE_HISTORY_INFO* lpConsoleHistoryInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleDisplayMode"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetConsoleDisplayMode([NativeTypeName("LPDWORD")] uint* lpModeFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetConsoleDisplayMode"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetConsoleDisplayMode(HANDLE hConsoleOutput, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCOORD")] COORD* lpNewScreenBufferDimensions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleWindow"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HWND GetConsoleWindow();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddConsoleAliasA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddConsoleAliasA([NativeTypeName("LPSTR")] sbyte* Source, [NativeTypeName("LPSTR")] sbyte* Target, [NativeTypeName("LPSTR")] sbyte* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddConsoleAliasW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddConsoleAliasW([NativeTypeName("LPWSTR")] ushort* Source, [NativeTypeName("LPWSTR")] ushort* Target, [NativeTypeName("LPWSTR")] ushort* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleAliasA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleAliasA([NativeTypeName("LPSTR")] sbyte* Source, [NativeTypeName("LPSTR")] sbyte* TargetBuffer, [NativeTypeName("DWORD")] uint TargetBufferLength, [NativeTypeName("LPSTR")] sbyte* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleAliasW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleAliasW([NativeTypeName("LPWSTR")] ushort* Source, [NativeTypeName("LPWSTR")] ushort* TargetBuffer, [NativeTypeName("DWORD")] uint TargetBufferLength, [NativeTypeName("LPWSTR")] ushort* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleAliasesLengthA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleAliasesLengthA([NativeTypeName("LPSTR")] sbyte* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleAliasesLengthW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleAliasesLengthW([NativeTypeName("LPWSTR")] ushort* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleAliasExesLengthA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleAliasExesLengthA();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleAliasExesLengthW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleAliasExesLengthW();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleAliasesA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleAliasesA([NativeTypeName("LPSTR")] sbyte* AliasBuffer, [NativeTypeName("DWORD")] uint AliasBufferLength, [NativeTypeName("LPSTR")] sbyte* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleAliasesW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleAliasesW([NativeTypeName("LPWSTR")] ushort* AliasBuffer, [NativeTypeName("DWORD")] uint AliasBufferLength, [NativeTypeName("LPWSTR")] ushort* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleAliasExesA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleAliasExesA([NativeTypeName("LPSTR")] sbyte* ExeNameBuffer, [NativeTypeName("DWORD")] uint ExeNameBufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleAliasExesW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleAliasExesW([NativeTypeName("LPWSTR")] ushort* ExeNameBuffer, [NativeTypeName("DWORD")] uint ExeNameBufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExpungeConsoleCommandHistoryA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ExpungeConsoleCommandHistoryA([NativeTypeName("LPSTR")] sbyte* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ExpungeConsoleCommandHistoryW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ExpungeConsoleCommandHistoryW([NativeTypeName("LPWSTR")] ushort* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetConsoleNumberOfCommandsA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetConsoleNumberOfCommandsA([NativeTypeName("DWORD")] uint Number, [NativeTypeName("LPSTR")] sbyte* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetConsoleNumberOfCommandsW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetConsoleNumberOfCommandsW([NativeTypeName("DWORD")] uint Number, [NativeTypeName("LPWSTR")] ushort* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleCommandHistoryLengthA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleCommandHistoryLengthA([NativeTypeName("LPSTR")] sbyte* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleCommandHistoryLengthW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleCommandHistoryLengthW([NativeTypeName("LPWSTR")] ushort* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleCommandHistoryA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleCommandHistoryA([NativeTypeName("LPSTR")] sbyte* Commands, [NativeTypeName("DWORD")] uint CommandBufferLength, [NativeTypeName("LPSTR")] sbyte* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleCommandHistoryW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleCommandHistoryW([NativeTypeName("LPWSTR")] ushort* Commands, [NativeTypeName("DWORD")] uint CommandBufferLength, [NativeTypeName("LPWSTR")] ushort* ExeName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConsoleProcessList"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetConsoleProcessList([NativeTypeName("LPDWORD")] uint* lpdwProcessList, [NativeTypeName("DWORD")] uint dwProcessCount);
    [NativeTypeName("#define HISTORY_NO_DUP_FLAG 0x1")]
    public const int HISTORY_NO_DUP_FLAG = 0x1;
    [NativeTypeName("#define AddConsoleAlias AddConsoleAliasW")]
    public static delegate*<ushort*, ushort*, ushort*, BOOL> AddConsoleAlias => &AddConsoleAliasW;

    [NativeTypeName("#define GetConsoleAlias GetConsoleAliasW")]
    public static delegate*<ushort*, ushort*, uint, ushort*, uint> GetConsoleAlias => &GetConsoleAliasW;

    [NativeTypeName("#define GetConsoleAliasesLength GetConsoleAliasesLengthW")]
    public static delegate*<ushort*, uint> GetConsoleAliasesLength => &GetConsoleAliasesLengthW;

    [NativeTypeName("#define GetConsoleAliasExesLength GetConsoleAliasExesLengthW")]
    public static delegate*<uint> GetConsoleAliasExesLength => &GetConsoleAliasExesLengthW;

    [NativeTypeName("#define GetConsoleAliases GetConsoleAliasesW")]
    public static delegate*<ushort*, uint, ushort*, uint> GetConsoleAliases => &GetConsoleAliasesW;

    [NativeTypeName("#define GetConsoleAliasExes GetConsoleAliasExesW")]
    public static delegate*<ushort*, uint, uint> GetConsoleAliasExes => &GetConsoleAliasExesW;

    [NativeTypeName("#define ExpungeConsoleCommandHistory ExpungeConsoleCommandHistoryW")]
    public static delegate*<ushort*, void> ExpungeConsoleCommandHistory => &ExpungeConsoleCommandHistoryW;

    [NativeTypeName("#define SetConsoleNumberOfCommands SetConsoleNumberOfCommandsW")]
    public static delegate*<uint, ushort*, BOOL> SetConsoleNumberOfCommands => &SetConsoleNumberOfCommandsW;

    [NativeTypeName("#define GetConsoleCommandHistoryLength GetConsoleCommandHistoryLengthW")]
    public static delegate*<ushort*, uint> GetConsoleCommandHistoryLength => &GetConsoleCommandHistoryLengthW;

    [NativeTypeName("#define GetConsoleCommandHistory GetConsoleCommandHistoryW")]
    public static delegate*<ushort*, uint, ushort*, uint> GetConsoleCommandHistory => &GetConsoleCommandHistoryW;
}