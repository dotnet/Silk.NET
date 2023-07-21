// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFindDebugInfoFile"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE SymFindDebugInfoFile(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PSTR")] sbyte* DebugFilePath, [NativeTypeName("PFIND_DEBUG_FILE_CALLBACK")] delegate* unmanaged<HANDLE, sbyte*, void*, BOOL> Callback, [NativeTypeName("PVOID")] void* CallerData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFindDebugInfoFileW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE SymFindDebugInfoFileW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PWSTR")] ushort* DebugFilePath, [NativeTypeName("PFIND_DEBUG_FILE_CALLBACKW")] delegate* unmanaged<HANDLE, ushort*, void*, BOOL> Callback, [NativeTypeName("PVOID")] void* CallerData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindDebugInfoFile"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindDebugInfoFile([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* SymbolPath, [NativeTypeName("PSTR")] sbyte* DebugFilePath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindDebugInfoFileEx"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindDebugInfoFileEx([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* SymbolPath, [NativeTypeName("PSTR")] sbyte* DebugFilePath, [NativeTypeName("PFIND_DEBUG_FILE_CALLBACK")] delegate* unmanaged<HANDLE, sbyte*, void*, BOOL> Callback, [NativeTypeName("PVOID")] void* CallerData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindDebugInfoFileExW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindDebugInfoFileExW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* SymbolPath, [NativeTypeName("PWSTR")] ushort* DebugFilePath, [NativeTypeName("PFIND_DEBUG_FILE_CALLBACKW")] delegate* unmanaged<HANDLE, ushort*, void*, BOOL> Callback, [NativeTypeName("PVOID")] void* CallerData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFindFileInPath"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFindFileInPath(HANDLE hprocess, [NativeTypeName("PCSTR")] sbyte* SearchPathW, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PVOID")] void* id, [NativeTypeName("DWORD")] uint two, [NativeTypeName("DWORD")] uint three, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("PSTR")] sbyte* FoundFile, [NativeTypeName("PFINDFILEINPATHCALLBACK")] delegate* unmanaged<sbyte*, void*, BOOL> callback, [NativeTypeName("PVOID")] void* context);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFindFileInPathW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFindFileInPathW(HANDLE hprocess, [NativeTypeName("PCWSTR")] ushort* SearchPathW, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PVOID")] void* id, [NativeTypeName("DWORD")] uint two, [NativeTypeName("DWORD")] uint three, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("PWSTR")] ushort* FoundFile, [NativeTypeName("PFINDFILEINPATHCALLBACKW")] delegate* unmanaged<ushort*, void*, BOOL> callback, [NativeTypeName("PVOID")] void* context);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFindExecutableImage"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE SymFindExecutableImage(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PSTR")] sbyte* ImageFilePath, [NativeTypeName("PFIND_EXE_FILE_CALLBACK")] delegate* unmanaged<HANDLE, sbyte*, void*, BOOL> Callback, [NativeTypeName("PVOID")] void* CallerData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFindExecutableImageW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE SymFindExecutableImageW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PWSTR")] ushort* ImageFilePath, [NativeTypeName("PFIND_EXE_FILE_CALLBACKW")] delegate* unmanaged<HANDLE, ushort*, void*, BOOL> Callback, [NativeTypeName("PVOID")] void* CallerData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindExecutableImage"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindExecutableImage([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* SymbolPath, [NativeTypeName("PSTR")] sbyte* ImageFilePath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindExecutableImageEx"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindExecutableImageEx([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* SymbolPath, [NativeTypeName("PSTR")] sbyte* ImageFilePath, [NativeTypeName("PFIND_EXE_FILE_CALLBACK")] delegate* unmanaged<HANDLE, sbyte*, void*, BOOL> Callback, [NativeTypeName("PVOID")] void* CallerData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindExecutableImageExW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindExecutableImageExW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* SymbolPath, [NativeTypeName("PWSTR")] ushort* ImageFilePath, [NativeTypeName("PFIND_EXE_FILE_CALLBACKW")] delegate* unmanaged<HANDLE, ushort*, void*, BOOL> Callback, [NativeTypeName("PVOID")] void* CallerData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageNtHeader"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PIMAGE_NT_HEADERS")]
    public static extern void* ImageNtHeader([NativeTypeName("PVOID")] void* Base);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageDirectoryEntryToDataEx"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    public static extern void* ImageDirectoryEntryToDataEx([NativeTypeName("PVOID")] void* Base, [NativeTypeName("BOOLEAN")] byte MappedAsImage, ushort DirectoryEntry, [NativeTypeName("PULONG")] uint* Size, [NativeTypeName("PIMAGE_SECTION_HEADER *")] IMAGE_SECTION_HEADER** FoundHeader);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageDirectoryEntryToData"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    public static extern void* ImageDirectoryEntryToData([NativeTypeName("PVOID")] void* Base, [NativeTypeName("BOOLEAN")] byte MappedAsImage, ushort DirectoryEntry, [NativeTypeName("PULONG")] uint* Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageRvaToSection"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PIMAGE_SECTION_HEADER")]
    public static extern IMAGE_SECTION_HEADER* ImageRvaToSection([NativeTypeName("PIMAGE_NT_HEADERS")] void* NtHeaders, [NativeTypeName("PVOID")] void* Base, [NativeTypeName("ULONG")] uint Rva);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageRvaToVa"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    public static extern void* ImageRvaToVa([NativeTypeName("PIMAGE_NT_HEADERS")] void* NtHeaders, [NativeTypeName("PVOID")] void* Base, [NativeTypeName("ULONG")] uint Rva, [NativeTypeName("PIMAGE_SECTION_HEADER *")] IMAGE_SECTION_HEADER** LastRvaSection);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SearchTreeForFile"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SearchTreeForFile([NativeTypeName("PCSTR")] sbyte* RootPath, [NativeTypeName("PCSTR")] sbyte* InputPathName, [NativeTypeName("PSTR")] sbyte* OutputPathBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SearchTreeForFileW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SearchTreeForFileW([NativeTypeName("PCWSTR")] ushort* RootPath, [NativeTypeName("PCWSTR")] ushort* InputPathName, [NativeTypeName("PWSTR")] ushort* OutputPathBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDirTree"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumDirTree(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* RootPath, [NativeTypeName("PCSTR")] sbyte* InputPathName, [NativeTypeName("PSTR")] sbyte* OutputPathBuffer, [NativeTypeName("PENUMDIRTREE_CALLBACK")] delegate* unmanaged<sbyte*, void*, BOOL> cb, [NativeTypeName("PVOID")] void* data);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumDirTreeW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumDirTreeW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* RootPath, [NativeTypeName("PCWSTR")] ushort* InputPathName, [NativeTypeName("PWSTR")] ushort* OutputPathBuffer, [NativeTypeName("PENUMDIRTREE_CALLBACKW")] delegate* unmanaged<ushort*, void*, BOOL> cb, [NativeTypeName("PVOID")] void* data);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MakeSureDirectoryPathExists"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MakeSureDirectoryPathExists([NativeTypeName("PCSTR")] sbyte* DirPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnDecorateSymbolName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint UnDecorateSymbolName([NativeTypeName("PCSTR")] sbyte* name, [NativeTypeName("PSTR")] sbyte* outputString, [NativeTypeName("DWORD")] uint maxStringLength, [NativeTypeName("DWORD")] uint flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnDecorateSymbolNameW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint UnDecorateSymbolNameW([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("PWSTR")] ushort* outputString, [NativeTypeName("DWORD")] uint maxStringLength, [NativeTypeName("DWORD")] uint flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Address32To64"]/*' />
    public static void Address32To64([NativeTypeName("LPADDRESS")] ADDRESS* a32, [NativeTypeName("LPADDRESS64")] ADDRESS64* a64)
    {
        a64->Offset = unchecked((ulong)((long)((int)(a32->Offset))));
        a64->Segment = a32->Segment;
        a64->Mode = a32->Mode;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Address64To32"]/*' />
    public static void Address64To32([NativeTypeName("LPADDRESS64")] ADDRESS64* a64, [NativeTypeName("LPADDRESS")] ADDRESS* a32)
    {
        a32->Offset = (uint)(a64->Offset);
        a32->Segment = a64->Segment;
        a32->Mode = a64->Mode;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KdHelp32To64"]/*' />
    public static void KdHelp32To64([NativeTypeName("PKDHELP")] KDHELP* p32, [NativeTypeName("PKDHELP64")] KDHELP64* p64)
    {
        p64->Thread = p32->Thread;
        p64->ThCallbackStack = p32->ThCallbackStack;
        p64->NextCallback = p32->NextCallback;
        p64->FramePointer = p32->FramePointer;
        p64->KiCallUserMode = p32->KiCallUserMode;
        p64->KeUserCallbackDispatcher = p32->KeUserCallbackDispatcher;
        p64->SystemRangeStart = p32->SystemRangeStart;
        p64->KiUserExceptionDispatcher = p32->KiUserExceptionDispatcher;
        p64->StackBase = p32->StackBase;
        p64->StackLimit = p32->StackLimit;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StackWalk64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL StackWalk64([NativeTypeName("DWORD")] uint MachineType, HANDLE hProcess, HANDLE hThread, [NativeTypeName("LPSTACKFRAME64")] STACKFRAME64* StackFrame, [NativeTypeName("PVOID")] void* ContextRecord, [NativeTypeName("PREAD_PROCESS_MEMORY_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, void*, uint, uint*, BOOL> ReadMemoryRoutine, [NativeTypeName("PFUNCTION_TABLE_ACCESS_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, void*> FunctionTableAccessRoutine, [NativeTypeName("PGET_MODULE_BASE_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, ulong> GetModuleBaseRoutine, [NativeTypeName("PTRANSLATE_ADDRESS_ROUTINE64")] delegate* unmanaged<HANDLE, HANDLE, ADDRESS64*, ulong> TranslateAddress);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StackWalkEx"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL StackWalkEx([NativeTypeName("DWORD")] uint MachineType, HANDLE hProcess, HANDLE hThread, [NativeTypeName("LPSTACKFRAME_EX")] STACKFRAME_EX* StackFrame, [NativeTypeName("PVOID")] void* ContextRecord, [NativeTypeName("PREAD_PROCESS_MEMORY_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, void*, uint, uint*, BOOL> ReadMemoryRoutine, [NativeTypeName("PFUNCTION_TABLE_ACCESS_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, void*> FunctionTableAccessRoutine, [NativeTypeName("PGET_MODULE_BASE_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, ulong> GetModuleBaseRoutine, [NativeTypeName("PTRANSLATE_ADDRESS_ROUTINE64")] delegate* unmanaged<HANDLE, HANDLE, ADDRESS64*, ulong> TranslateAddress, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StackWalk2"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern BOOL StackWalk2([NativeTypeName("DWORD")] uint MachineType, HANDLE hProcess, HANDLE hThread, [NativeTypeName("LPSTACKFRAME_EX")] STACKFRAME_EX* StackFrame, [NativeTypeName("PVOID")] void* ContextRecord, [NativeTypeName("PREAD_PROCESS_MEMORY_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, void*, uint, uint*, BOOL> ReadMemoryRoutine, [NativeTypeName("PFUNCTION_TABLE_ACCESS_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, void*> FunctionTableAccessRoutine, [NativeTypeName("PGET_MODULE_BASE_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, ulong> GetModuleBaseRoutine, [NativeTypeName("PTRANSLATE_ADDRESS_ROUTINE64")] delegate* unmanaged<HANDLE, HANDLE, ADDRESS64*, ulong> TranslateAddress, [NativeTypeName("PGET_TARGET_ATTRIBUTE_VALUE64")] delegate* unmanaged<HANDLE, uint, ulong, ulong*, BOOL> GetTargetAttributeValue, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StackWalk"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL StackWalk([NativeTypeName("DWORD")] uint MachineType, HANDLE hProcess, HANDLE hThread, [NativeTypeName("LPSTACKFRAME")] STACKFRAME* StackFrame, [NativeTypeName("PVOID")] void* ContextRecord, [NativeTypeName("PREAD_PROCESS_MEMORY_ROUTINE")] delegate* unmanaged<HANDLE, uint, void*, uint, uint*, BOOL> ReadMemoryRoutine, [NativeTypeName("PFUNCTION_TABLE_ACCESS_ROUTINE")] delegate* unmanaged<HANDLE, uint, void*> FunctionTableAccessRoutine, [NativeTypeName("PGET_MODULE_BASE_ROUTINE")] delegate* unmanaged<HANDLE, uint, uint> GetModuleBaseRoutine, [NativeTypeName("PTRANSLATE_ADDRESS_ROUTINE")] delegate* unmanaged<HANDLE, HANDLE, ADDRESS*, uint> TranslateAddress);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImagehlpApiVersion"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [return: NativeTypeName("LPAPI_VERSION")]
    public static extern API_VERSION* ImagehlpApiVersion();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImagehlpApiVersionEx"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [return: NativeTypeName("LPAPI_VERSION")]
    public static extern API_VERSION* ImagehlpApiVersionEx([NativeTypeName("LPAPI_VERSION")] API_VERSION* AppVersion);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTimestampForLoadedLibrary"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTimestampForLoadedLibrary(HMODULE Module);

    public const int sevInfo = 0;
    public const int sevProblem = 1;
    public const int sevAttn = 2;
    public const int sevFatal = 3;
    public const int sevMax = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetParentWindow"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSetParentWindow(HWND hwnd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetHomeDirectory"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCHAR")]
    public static extern sbyte* SymSetHomeDirectory(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* dir);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetHomeDirectoryW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* SymSetHomeDirectoryW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* dir);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetHomeDirectory"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCHAR")]
    public static extern sbyte* SymGetHomeDirectory([NativeTypeName("DWORD")] uint type, [NativeTypeName("PSTR")] sbyte* dir, [NativeTypeName("size_t")] nuint size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetHomeDirectoryW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PWSTR")]
    public static extern ushort* SymGetHomeDirectoryW([NativeTypeName("DWORD")] uint type, [NativeTypeName("PWSTR")] ushort* dir, [NativeTypeName("size_t")] nuint size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetOmaps"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetOmaps(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong BaseOfDll, [NativeTypeName("POMAP *")] OMAP** OmapTo, [NativeTypeName("PDWORD64")] ulong* cOmapTo, [NativeTypeName("POMAP *")] OMAP** OmapFrom, [NativeTypeName("PDWORD64")] ulong* cOmapFrom);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetOptions"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SymSetOptions([NativeTypeName("DWORD")] uint SymOptions);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetOptions"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SymGetOptions();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymCleanup"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymCleanup(HANDLE hProcess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetExtendedOption"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL SymGetExtendedOption(IMAGEHLP_EXTENDED_OPTIONS option);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetExtendedOption"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL SymSetExtendedOption(IMAGEHLP_EXTENDED_OPTIONS option, BOOL value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymMatchString"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL SymMatchString([NativeTypeName("PCSTR")] sbyte* @string, [NativeTypeName("PCSTR")] sbyte* expression, BOOL fCase);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymMatchStringA"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL SymMatchStringA([NativeTypeName("PCSTR")] sbyte* @string, [NativeTypeName("PCSTR")] sbyte* expression, BOOL fCase);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymMatchStringW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymMatchStringW([NativeTypeName("PCWSTR")] ushort* @string, [NativeTypeName("PCWSTR")] ushort* expression, BOOL fCase);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSourceFiles"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSourceFiles(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong ModBase, [NativeTypeName("PCSTR")] sbyte* Mask, [NativeTypeName("PSYM_ENUMSOURCEFILES_CALLBACK")] delegate* unmanaged<SOURCEFILE*, void*, BOOL> cbSrcFiles, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSourceFilesW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSourceFilesW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong ModBase, [NativeTypeName("PCWSTR")] ushort* Mask, [NativeTypeName("PSYM_ENUMSOURCEFILES_CALLBACKW")] delegate* unmanaged<SOURCEFILEW*, void*, BOOL> cbSrcFiles, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumerateModules64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumerateModules64(HANDLE hProcess, [NativeTypeName("PSYM_ENUMMODULES_CALLBACK64")] delegate* unmanaged<sbyte*, ulong, void*, BOOL> EnumModulesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumerateModulesW64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumerateModulesW64(HANDLE hProcess, [NativeTypeName("PSYM_ENUMMODULES_CALLBACKW64")] delegate* unmanaged<ushort*, ulong, void*, BOOL> EnumModulesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumerateModules"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumerateModules(HANDLE hProcess, [NativeTypeName("PSYM_ENUMMODULES_CALLBACK")] delegate* unmanaged<sbyte*, uint, void*, BOOL> EnumModulesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumerateLoadedModulesEx"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumerateLoadedModulesEx(HANDLE hProcess, [NativeTypeName("PENUMLOADED_MODULES_CALLBACK64")] delegate* unmanaged<sbyte*, ulong, uint, void*, BOOL> EnumLoadedModulesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumerateLoadedModulesExW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumerateLoadedModulesExW(HANDLE hProcess, [NativeTypeName("PENUMLOADED_MODULES_CALLBACKW64")] delegate* unmanaged<ushort*, ulong, uint, void*, BOOL> EnumLoadedModulesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumerateLoadedModules64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumerateLoadedModules64(HANDLE hProcess, [NativeTypeName("PENUMLOADED_MODULES_CALLBACK64")] delegate* unmanaged<sbyte*, ulong, uint, void*, BOOL> EnumLoadedModulesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumerateLoadedModulesW64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumerateLoadedModulesW64(HANDLE hProcess, [NativeTypeName("PENUMLOADED_MODULES_CALLBACKW64")] delegate* unmanaged<ushort*, ulong, uint, void*, BOOL> EnumLoadedModulesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumerateLoadedModules"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumerateLoadedModules(HANDLE hProcess, [NativeTypeName("PENUMLOADED_MODULES_CALLBACK")] delegate* unmanaged<sbyte*, uint, uint, void*, BOOL> EnumLoadedModulesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFunctionTableAccess64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    public static extern void* SymFunctionTableAccess64(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong AddrBase);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFunctionTableAccess64AccessRoutines"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [return: NativeTypeName("PVOID")]
    public static extern void* SymFunctionTableAccess64AccessRoutines(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong AddrBase, [NativeTypeName("PREAD_PROCESS_MEMORY_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, void*, uint, uint*, BOOL> ReadMemoryRoutine, [NativeTypeName("PGET_MODULE_BASE_ROUTINE64")] delegate* unmanaged<HANDLE, ulong, ulong> GetModuleBaseRoutine);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFunctionTableAccess"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    public static extern void* SymFunctionTableAccess(HANDLE hProcess, [NativeTypeName("DWORD")] uint AddrBase);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetUnwindInfo"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL SymGetUnwindInfo(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("PULONG")] uint* Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetModuleInfo64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetModuleInfo64(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong qwAddr, [NativeTypeName("PIMAGEHLP_MODULE64")] IMAGEHLP_MODULE64* ModuleInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetModuleInfoW64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetModuleInfoW64(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong qwAddr, [NativeTypeName("PIMAGEHLP_MODULEW64")] IMAGEHLP_MODULEW64* ModuleInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetModuleInfo"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetModuleInfo(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwAddr, [NativeTypeName("PIMAGEHLP_MODULE")] IMAGEHLP_MODULE* ModuleInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetModuleInfoW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetModuleInfoW(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwAddr, [NativeTypeName("PIMAGEHLP_MODULEW")] IMAGEHLP_MODULEW* ModuleInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetModuleBase64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD64")]
    public static extern ulong SymGetModuleBase64(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong qwAddr);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetModuleBase"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SymGetModuleBase(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwAddr);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumLines"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumLines(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCSTR")] sbyte* Obj, [NativeTypeName("PCSTR")] sbyte* File, [NativeTypeName("PSYM_ENUMLINES_CALLBACK")] delegate* unmanaged<SRCCODEINFO*, void*, BOOL> EnumLinesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumLinesW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumLinesW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCWSTR")] ushort* Obj, [NativeTypeName("PCWSTR")] ushort* File, [NativeTypeName("PSYM_ENUMLINES_CALLBACKW")] delegate* unmanaged<SRCCODEINFOW*, void*, BOOL> EnumLinesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineFromAddr64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineFromAddr64(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong qwAddr, [NativeTypeName("PDWORD")] uint* pdwDisplacement, [NativeTypeName("PIMAGEHLP_LINE64")] IMAGEHLP_LINE64* Line64);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineFromAddrW64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineFromAddrW64(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong dwAddr, [NativeTypeName("PDWORD")] uint* pdwDisplacement, [NativeTypeName("PIMAGEHLP_LINEW64")] IMAGEHLP_LINEW64* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineFromInlineContext"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineFromInlineContext(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong qwAddr, [NativeTypeName("ULONG")] uint InlineContext, [NativeTypeName("DWORD64")] ulong qwModuleBaseAddress, [NativeTypeName("PDWORD")] uint* pdwDisplacement, [NativeTypeName("PIMAGEHLP_LINE64")] IMAGEHLP_LINE64* Line64);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineFromInlineContextW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineFromInlineContextW(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong dwAddr, [NativeTypeName("ULONG")] uint InlineContext, [NativeTypeName("DWORD64")] ulong qwModuleBaseAddress, [NativeTypeName("PDWORD")] uint* pdwDisplacement, [NativeTypeName("PIMAGEHLP_LINEW64")] IMAGEHLP_LINEW64* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSourceLines"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSourceLines(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCSTR")] sbyte* Obj, [NativeTypeName("PCSTR")] sbyte* File, [NativeTypeName("DWORD")] uint Line, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PSYM_ENUMLINES_CALLBACK")] delegate* unmanaged<SRCCODEINFO*, void*, BOOL> EnumLinesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSourceLinesW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSourceLinesW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCWSTR")] ushort* Obj, [NativeTypeName("PCWSTR")] ushort* File, [NativeTypeName("DWORD")] uint Line, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PSYM_ENUMLINES_CALLBACKW")] delegate* unmanaged<SRCCODEINFOW*, void*, BOOL> EnumLinesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymAddrIncludeInlineTrace"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SymAddrIncludeInlineTrace(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Address);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymCompareInlineTrace"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SymCompareInlineTrace(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Address1, [NativeTypeName("DWORD")] uint InlineContext1, [NativeTypeName("DWORD64")] ulong RetAddress1, [NativeTypeName("DWORD64")] ulong Address2, [NativeTypeName("DWORD64")] ulong RetAddress2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymQueryInlineTrace"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL SymQueryInlineTrace(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong StartAddress, [NativeTypeName("DWORD")] uint StartContext, [NativeTypeName("DWORD64")] ulong StartRetAddress, [NativeTypeName("DWORD64")] ulong CurAddress, [NativeTypeName("LPDWORD")] uint* CurContext, [NativeTypeName("LPDWORD")] uint* CurFrameIndex);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineFromAddr"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineFromAddr(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwAddr, [NativeTypeName("PDWORD")] uint* pdwDisplacement, [NativeTypeName("PIMAGEHLP_LINE")] IMAGEHLP_LINE* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineFromName64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineFromName64(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* ModuleName, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("DWORD")] uint dwLineNumber, [NativeTypeName("PLONG")] int* plDisplacement, [NativeTypeName("PIMAGEHLP_LINE64")] IMAGEHLP_LINE64* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineFromNameW64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineFromNameW64(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* ModuleName, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("DWORD")] uint dwLineNumber, [NativeTypeName("PLONG")] int* plDisplacement, [NativeTypeName("PIMAGEHLP_LINEW64")] IMAGEHLP_LINEW64* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineFromName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineFromName(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* ModuleName, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("DWORD")] uint dwLineNumber, [NativeTypeName("PLONG")] int* plDisplacement, [NativeTypeName("PIMAGEHLP_LINE")] IMAGEHLP_LINE* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineNext64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineNext64(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_LINE64")] IMAGEHLP_LINE64* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineNextW64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineNextW64(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_LINEW64")] IMAGEHLP_LINEW64* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLineNext"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLineNext(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_LINE")] IMAGEHLP_LINE* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLinePrev64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLinePrev64(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_LINE64")] IMAGEHLP_LINE64* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLinePrevW64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLinePrevW64(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_LINEW64")] IMAGEHLP_LINEW64* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetLinePrev"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetLinePrev(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_LINE")] IMAGEHLP_LINE* Line);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetFileLineOffsets64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ULONG")]
    public static extern uint SymGetFileLineOffsets64(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* ModuleName, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PDWORD64")] ulong* Buffer, [NativeTypeName("ULONG")] uint BufferLines);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymMatchFileName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymMatchFileName([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* Match, [NativeTypeName("PSTR *")] sbyte** FileNameStop, [NativeTypeName("PSTR *")] sbyte** MatchStop);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymMatchFileNameW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymMatchFileNameW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* Match, [NativeTypeName("PWSTR *")] ushort** FileNameStop, [NativeTypeName("PWSTR *")] ushort** MatchStop);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFile"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSourceFile(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCSTR")] sbyte* Params, [NativeTypeName("PCSTR")] sbyte* FileSpec, [NativeTypeName("PSTR")] sbyte* FilePath, [NativeTypeName("DWORD")] uint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSourceFileW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCWSTR")] ushort* Params, [NativeTypeName("PCWSTR")] ushort* FileSpec, [NativeTypeName("PWSTR")] ushort* FilePath, [NativeTypeName("DWORD")] uint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileToken"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSourceFileToken(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCSTR")] sbyte* FileSpec, [NativeTypeName("PVOID *")] void** Token, [NativeTypeName("DWORD *")] uint* Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileTokenByTokenName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL SymGetSourceFileTokenByTokenName(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCSTR")] sbyte* FileSpec, [NativeTypeName("PCSTR")] sbyte* TokenName, [NativeTypeName("PCSTR")] sbyte* TokenParameters, [NativeTypeName("PVOID *")] void** Token, [NativeTypeName("DWORD *")] uint* Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileChecksumW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSourceFileChecksumW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCWSTR")] ushort* FileSpec, [NativeTypeName("DWORD *")] uint* pCheckSumType, byte* pChecksum, [NativeTypeName("DWORD")] uint checksumSize, [NativeTypeName("DWORD *")] uint* pActualBytesWritten);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileChecksum"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSourceFileChecksum(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCSTR")] sbyte* FileSpec, [NativeTypeName("DWORD *")] uint* pCheckSumType, byte* pChecksum, [NativeTypeName("DWORD")] uint checksumSize, [NativeTypeName("DWORD *")] uint* pActualBytesWritten);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileTokenW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSourceFileTokenW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCWSTR")] ushort* FileSpec, [NativeTypeName("PVOID *")] void** Token, [NativeTypeName("DWORD *")] uint* Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileTokenByTokenNameW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL SymGetSourceFileTokenByTokenNameW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCWSTR")] ushort* FileSpec, [NativeTypeName("PCWSTR")] ushort* TokenName, [NativeTypeName("PCWSTR")] ushort* TokenParameters, [NativeTypeName("PVOID *")] void** Token, [NativeTypeName("DWORD *")] uint* Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileFromToken"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSourceFileFromToken(HANDLE hProcess, [NativeTypeName("PVOID")] void* Token, [NativeTypeName("PCSTR")] sbyte* Params, [NativeTypeName("PSTR")] sbyte* FilePath, [NativeTypeName("DWORD")] uint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileFromTokenByTokenName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL SymGetSourceFileFromTokenByTokenName(HANDLE hProcess, [NativeTypeName("PVOID")] void* Token, [NativeTypeName("PCSTR")] sbyte* TokenName, [NativeTypeName("PCSTR")] sbyte* Params, [NativeTypeName("PSTR")] sbyte* FilePath, [NativeTypeName("DWORD")] uint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileFromTokenW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSourceFileFromTokenW(HANDLE hProcess, [NativeTypeName("PVOID")] void* Token, [NativeTypeName("PCWSTR")] ushort* Params, [NativeTypeName("PWSTR")] ushort* FilePath, [NativeTypeName("DWORD")] uint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceFileFromTokenByTokenNameW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL SymGetSourceFileFromTokenByTokenNameW(HANDLE hProcess, [NativeTypeName("PVOID")] void* Token, [NativeTypeName("PCWSTR")] ushort* TokenName, [NativeTypeName("PCWSTR")] ushort* Params, [NativeTypeName("PWSTR")] ushort* FilePath, [NativeTypeName("DWORD")] uint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceVarFromToken"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSourceVarFromToken(HANDLE hProcess, [NativeTypeName("PVOID")] void* Token, [NativeTypeName("PCSTR")] sbyte* Params, [NativeTypeName("PCSTR")] sbyte* VarName, [NativeTypeName("PSTR")] sbyte* Value, [NativeTypeName("DWORD")] uint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSourceVarFromTokenW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSourceVarFromTokenW(HANDLE hProcess, [NativeTypeName("PVOID")] void* Token, [NativeTypeName("PCWSTR")] ushort* Params, [NativeTypeName("PCWSTR")] ushort* VarName, [NativeTypeName("PWSTR")] ushort* Value, [NativeTypeName("DWORD")] uint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSourceFileTokens"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSourceFileTokens(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PENUMSOURCEFILETOKENSCALLBACK")] delegate* unmanaged<void*, nuint, BOOL> Callback);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymInitialize"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymInitialize(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* UserSearchPath, BOOL fInvadeProcess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymInitializeW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymInitializeW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* UserSearchPath, BOOL fInvadeProcess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSearchPath"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSearchPath(HANDLE hProcess, [NativeTypeName("PSTR")] sbyte* SearchPathW, [NativeTypeName("DWORD")] uint SearchPathLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSearchPathW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSearchPathW(HANDLE hProcess, [NativeTypeName("PWSTR")] ushort* SearchPathW, [NativeTypeName("DWORD")] uint SearchPathLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetSearchPath"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSetSearchPath(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* SearchPathW);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetSearchPathW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSetSearchPathW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* SearchPathW);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymLoadModuleEx"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD64")]
    public static extern ulong SymLoadModuleEx(HANDLE hProcess, HANDLE hFile, [NativeTypeName("PCSTR")] sbyte* ImageName, [NativeTypeName("PCSTR")] sbyte* ModuleName, [NativeTypeName("DWORD64")] ulong BaseOfDll, [NativeTypeName("DWORD")] uint DllSize, [NativeTypeName("PMODLOAD_DATA")] MODLOAD_DATA* Data, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymLoadModuleExW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD64")]
    public static extern ulong SymLoadModuleExW(HANDLE hProcess, HANDLE hFile, [NativeTypeName("PCWSTR")] ushort* ImageName, [NativeTypeName("PCWSTR")] ushort* ModuleName, [NativeTypeName("DWORD64")] ulong BaseOfDll, [NativeTypeName("DWORD")] uint DllSize, [NativeTypeName("PMODLOAD_DATA")] MODLOAD_DATA* Data, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymUnloadModule64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymUnloadModule64(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong BaseOfDll);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymUnloadModule"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymUnloadModule(HANDLE hProcess, [NativeTypeName("DWORD")] uint BaseOfDll);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymUnDName64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymUnDName64([NativeTypeName("PIMAGEHLP_SYMBOL64")] IMAGEHLP_SYMBOL64* sym, [NativeTypeName("PSTR")] sbyte* UnDecName, [NativeTypeName("DWORD")] uint UnDecNameLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymUnDName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymUnDName([NativeTypeName("PIMAGEHLP_SYMBOL")] IMAGEHLP_SYMBOL* sym, [NativeTypeName("PSTR")] sbyte* UnDecName, [NativeTypeName("DWORD")] uint UnDecNameLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymRegisterCallback64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymRegisterCallback64(HANDLE hProcess, [NativeTypeName("PSYMBOL_REGISTERED_CALLBACK64")] delegate* unmanaged<HANDLE, uint, ulong, ulong, BOOL> CallbackFunction, [NativeTypeName("ULONG64")] ulong UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymRegisterCallbackW64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymRegisterCallbackW64(HANDLE hProcess, [NativeTypeName("PSYMBOL_REGISTERED_CALLBACK64")] delegate* unmanaged<HANDLE, uint, ulong, ulong, BOOL> CallbackFunction, [NativeTypeName("ULONG64")] ulong UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymRegisterFunctionEntryCallback64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymRegisterFunctionEntryCallback64(HANDLE hProcess, [NativeTypeName("PSYMBOL_FUNCENTRY_CALLBACK64")] delegate* unmanaged<HANDLE, ulong, ulong, void*> CallbackFunction, [NativeTypeName("ULONG64")] ulong UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymRegisterCallback"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymRegisterCallback(HANDLE hProcess, [NativeTypeName("PSYMBOL_REGISTERED_CALLBACK")] delegate* unmanaged<HANDLE, uint, void*, void*, BOOL> CallbackFunction, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymRegisterFunctionEntryCallback"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymRegisterFunctionEntryCallback(HANDLE hProcess, [NativeTypeName("PSYMBOL_FUNCENTRY_CALLBACK")] delegate* unmanaged<HANDLE, uint, void*, void*> CallbackFunction, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetContext"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSetContext(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_STACK_FRAME")] IMAGEHLP_STACK_FRAME* StackFrame, [NativeTypeName("PIMAGEHLP_CONTEXT")] void* Context);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetScopeFromAddr"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSetScopeFromAddr(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Address);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetScopeFromInlineContext"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSetScopeFromInlineContext(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Address, [NativeTypeName("ULONG")] uint InlineContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSetScopeFromIndex"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSetScopeFromIndex(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("DWORD")] uint Index);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumProcesses"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumProcesses([NativeTypeName("PSYM_ENUMPROCESSES_CALLBACK")] delegate* unmanaged<HANDLE, void*, BOOL> EnumProcessesCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFromAddr"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFromAddr(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("PDWORD64")] ulong* Displacement, [NativeTypeName("PSYMBOL_INFO")] SYMBOL_INFO* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFromAddrW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFromAddrW(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("PDWORD64")] ulong* Displacement, [NativeTypeName("PSYMBOL_INFOW")] SYMBOL_INFOW* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFromInlineContext"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFromInlineContext(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("ULONG")] uint InlineContext, [NativeTypeName("PDWORD64")] ulong* Displacement, [NativeTypeName("PSYMBOL_INFO")] SYMBOL_INFO* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFromInlineContextW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFromInlineContextW(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("ULONG")] uint InlineContext, [NativeTypeName("PDWORD64")] ulong* Displacement, [NativeTypeName("PSYMBOL_INFOW")] SYMBOL_INFOW* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFromToken"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFromToken(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Base, [NativeTypeName("DWORD")] uint Token, [NativeTypeName("PSYMBOL_INFO")] SYMBOL_INFO* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFromTokenW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFromTokenW(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Base, [NativeTypeName("DWORD")] uint Token, [NativeTypeName("PSYMBOL_INFOW")] SYMBOL_INFOW* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymNext"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymNext(HANDLE hProcess, [NativeTypeName("PSYMBOL_INFO")] SYMBOL_INFO* si);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymNextW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymNextW(HANDLE hProcess, [NativeTypeName("PSYMBOL_INFOW")] SYMBOL_INFOW* siw);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymPrev"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymPrev(HANDLE hProcess, [NativeTypeName("PSYMBOL_INFO")] SYMBOL_INFO* si);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymPrevW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymPrevW(HANDLE hProcess, [NativeTypeName("PSYMBOL_INFOW")] SYMBOL_INFOW* siw);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFromName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFromName(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* Name, [NativeTypeName("PSYMBOL_INFO")] SYMBOL_INFO* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFromNameW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFromNameW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* Name, [NativeTypeName("PSYMBOL_INFOW")] SYMBOL_INFOW* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSymbols"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSymbols(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCSTR")] sbyte* Mask, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACK")] delegate* unmanaged<SYMBOL_INFO*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSymbolsEx"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSymbolsEx(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCSTR")] sbyte* Mask, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACK")] delegate* unmanaged<SYMBOL_INFO*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext, [NativeTypeName("DWORD")] uint Options);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSymbolsW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSymbolsW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCWSTR")] ushort* Mask, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACKW")] delegate* unmanaged<SYMBOL_INFOW*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSymbolsExW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSymbolsExW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCWSTR")] ushort* Mask, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACKW")] delegate* unmanaged<SYMBOL_INFOW*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext, [NativeTypeName("DWORD")] uint Options);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSymbolsForAddr"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSymbolsForAddr(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACK")] delegate* unmanaged<SYMBOL_INFO*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSymbolsForAddrW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumSymbolsForAddrW(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACKW")] delegate* unmanaged<SYMBOL_INFOW*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSearch"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSearch(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("DWORD")] uint SymTag, [NativeTypeName("PCSTR")] sbyte* Mask, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACK")] delegate* unmanaged<SYMBOL_INFO*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext, [NativeTypeName("DWORD")] uint Options);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSearchW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSearchW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("DWORD")] uint SymTag, [NativeTypeName("PCWSTR")] ushort* Mask, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACKW")] delegate* unmanaged<SYMBOL_INFOW*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext, [NativeTypeName("DWORD")] uint Options);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetScope"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetScope(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PSYMBOL_INFO")] SYMBOL_INFO* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetScopeW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetScopeW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PSYMBOL_INFOW")] SYMBOL_INFOW* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFromIndex"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFromIndex(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PSYMBOL_INFO")] SYMBOL_INFO* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymFromIndexW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymFromIndexW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PSYMBOL_INFOW")] SYMBOL_INFOW* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetTypeInfo"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetTypeInfo(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong ModBase, [NativeTypeName("ULONG")] uint TypeId, IMAGEHLP_SYMBOL_TYPE_INFO GetType, [NativeTypeName("PVOID")] void* pInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetTypeInfoEx"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetTypeInfoEx(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong ModBase, [NativeTypeName("PIMAGEHLP_GET_TYPE_INFO_PARAMS")] IMAGEHLP_GET_TYPE_INFO_PARAMS* Params);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumTypes"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumTypes(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACK")] delegate* unmanaged<SYMBOL_INFO*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumTypesW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumTypesW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACKW")] delegate* unmanaged<SYMBOL_INFOW*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumTypesByName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumTypesByName(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCSTR")] sbyte* mask, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACK")] delegate* unmanaged<SYMBOL_INFO*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumTypesByNameW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumTypesByNameW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCWSTR")] ushort* mask, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACKW")] delegate* unmanaged<SYMBOL_INFOW*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetTypeFromName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetTypeFromName(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCSTR")] sbyte* Name, [NativeTypeName("PSYMBOL_INFO")] SYMBOL_INFO* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetTypeFromNameW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetTypeFromNameW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCWSTR")] ushort* Name, [NativeTypeName("PSYMBOL_INFOW")] SYMBOL_INFOW* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymAddSymbol"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymAddSymbol(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCSTR")] sbyte* Name, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("DWORD")] uint Size, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymAddSymbolW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymAddSymbolW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCWSTR")] ushort* Name, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("DWORD")] uint Size, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymDeleteSymbol"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymDeleteSymbol(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCSTR")] sbyte* Name, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymDeleteSymbolW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymDeleteSymbolW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PCWSTR")] ushort* Name, [NativeTypeName("DWORD64")] ulong Address, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymRefreshModuleList"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymRefreshModuleList(HANDLE hProcess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymAddSourceStream"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL SymAddSourceStream(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCSTR")] sbyte* StreamFile, [NativeTypeName("PBYTE")] byte* Buffer, [NativeTypeName("size_t")] nuint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymAddSourceStreamA"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL SymAddSourceStreamA(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCSTR")] sbyte* StreamFile, [NativeTypeName("PBYTE")] byte* Buffer, [NativeTypeName("size_t")] nuint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymAddSourceStreamW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymAddSourceStreamW(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong Base, [NativeTypeName("PCWSTR")] ushort* FileSpec, [NativeTypeName("PBYTE")] byte* Buffer, [NativeTypeName("size_t")] nuint Size);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvIsStoreW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSrvIsStoreW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* path);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvIsStore"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSrvIsStore(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* path);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvDeltaName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCSTR")]
    public static extern sbyte* SymSrvDeltaName(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* SymPath, [NativeTypeName("PCSTR")] sbyte* Type, [NativeTypeName("PCSTR")] sbyte* File1, [NativeTypeName("PCSTR")] sbyte* File2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvDeltaNameW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCWSTR")]
    public static extern ushort* SymSrvDeltaNameW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* SymPath, [NativeTypeName("PCWSTR")] ushort* Type, [NativeTypeName("PCWSTR")] ushort* File1, [NativeTypeName("PCWSTR")] ushort* File2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvGetSupplement"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCSTR")]
    public static extern sbyte* SymSrvGetSupplement(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* SymPath, [NativeTypeName("PCSTR")] sbyte* Node, [NativeTypeName("PCSTR")] sbyte* File);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvGetSupplementW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCWSTR")]
    public static extern ushort* SymSrvGetSupplementW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* SymPath, [NativeTypeName("PCWSTR")] ushort* Node, [NativeTypeName("PCWSTR")] ushort* File);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvGetFileIndexes"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSrvGetFileIndexes([NativeTypeName("PCSTR")] sbyte* File, Guid* Id, [NativeTypeName("PDWORD")] uint* Val1, [NativeTypeName("PDWORD")] uint* Val2, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvGetFileIndexesW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSrvGetFileIndexesW([NativeTypeName("PCWSTR")] ushort* File, Guid* Id, [NativeTypeName("PDWORD")] uint* Val1, [NativeTypeName("PDWORD")] uint* Val2, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvGetFileIndexStringW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSrvGetFileIndexStringW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* SrvPath, [NativeTypeName("PCWSTR")] ushort* File, [NativeTypeName("PWSTR")] ushort* Index, [NativeTypeName("size_t")] nuint Size, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvGetFileIndexString"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSrvGetFileIndexString(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* SrvPath, [NativeTypeName("PCSTR")] sbyte* File, [NativeTypeName("PSTR")] sbyte* Index, [NativeTypeName("size_t")] nuint Size, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvGetFileIndexInfo"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSrvGetFileIndexInfo([NativeTypeName("PCSTR")] sbyte* File, [NativeTypeName("PSYMSRV_INDEX_INFO")] SYMSRV_INDEX_INFO* Info, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvGetFileIndexInfoW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymSrvGetFileIndexInfoW([NativeTypeName("PCWSTR")] ushort* File, [NativeTypeName("PSYMSRV_INDEX_INFOW")] SYMSRV_INDEX_INFOW* Info, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvStoreSupplement"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCSTR")]
    public static extern sbyte* SymSrvStoreSupplement(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* SrvPath, [NativeTypeName("PCSTR")] sbyte* Node, [NativeTypeName("PCSTR")] sbyte* File, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvStoreSupplementW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCWSTR")]
    public static extern ushort* SymSrvStoreSupplementW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* SymPath, [NativeTypeName("PCWSTR")] ushort* Node, [NativeTypeName("PCWSTR")] ushort* File, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvStoreFile"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCSTR")]
    public static extern sbyte* SymSrvStoreFile(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* SrvPath, [NativeTypeName("PCSTR")] sbyte* File, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymSrvStoreFileW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PCWSTR")]
    public static extern ushort* SymSrvStoreFileW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* SrvPath, [NativeTypeName("PCWSTR")] ushort* File, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSymbolFile"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSymbolFile(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* SymPath, [NativeTypeName("PCSTR")] sbyte* ImageFile, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("PSTR")] sbyte* SymbolFile, [NativeTypeName("size_t")] nuint cSymbolFile, [NativeTypeName("PSTR")] sbyte* DbgFile, [NativeTypeName("size_t")] nuint cDbgFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSymbolFileW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSymbolFileW(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* SymPath, [NativeTypeName("PCWSTR")] ushort* ImageFile, [NativeTypeName("DWORD")] uint Type, [NativeTypeName("PWSTR")] ushort* SymbolFile, [NativeTypeName("size_t")] nuint cSymbolFile, [NativeTypeName("PWSTR")] ushort* DbgFile, [NativeTypeName("size_t")] nuint cDbgFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DbgHelpCreateUserDump"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL DbgHelpCreateUserDump([NativeTypeName("LPCSTR")] sbyte* FileName, [NativeTypeName("PDBGHELP_CREATE_USER_DUMP_CALLBACK")] delegate* unmanaged<uint, void**, uint*, void*, BOOL> Callback, [NativeTypeName("PVOID")] void* UserData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DbgHelpCreateUserDumpW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL DbgHelpCreateUserDumpW([NativeTypeName("LPCWSTR")] ushort* FileName, [NativeTypeName("PDBGHELP_CREATE_USER_DUMP_CALLBACK")] delegate* unmanaged<uint, void**, uint*, void*, BOOL> Callback, [NativeTypeName("PVOID")] void* UserData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSymFromAddr64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSymFromAddr64(HANDLE hProcess, [NativeTypeName("DWORD64")] ulong qwAddr, [NativeTypeName("PDWORD64")] ulong* pdwDisplacement, [NativeTypeName("PIMAGEHLP_SYMBOL64")] IMAGEHLP_SYMBOL64* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSymFromAddr"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSymFromAddr(HANDLE hProcess, [NativeTypeName("DWORD")] uint dwAddr, [NativeTypeName("PDWORD")] uint* pdwDisplacement, [NativeTypeName("PIMAGEHLP_SYMBOL")] IMAGEHLP_SYMBOL* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSymFromName64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSymFromName64(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* Name, [NativeTypeName("PIMAGEHLP_SYMBOL64")] IMAGEHLP_SYMBOL64* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSymFromName"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSymFromName(HANDLE hProcess, [NativeTypeName("PCSTR")] sbyte* Name, [NativeTypeName("PIMAGEHLP_SYMBOL")] IMAGEHLP_SYMBOL* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFileInPath"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL FindFileInPath(HANDLE hprocess, [NativeTypeName("PCSTR")] sbyte* SearchPathW, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PVOID")] void* id, [NativeTypeName("DWORD")] uint two, [NativeTypeName("DWORD")] uint three, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("PSTR")] sbyte* FilePath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFileInSearchPath"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL FindFileInSearchPath(HANDLE hprocess, [NativeTypeName("PCSTR")] sbyte* SearchPathW, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("DWORD")] uint one, [NativeTypeName("DWORD")] uint two, [NativeTypeName("DWORD")] uint three, [NativeTypeName("PSTR")] sbyte* FilePath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumSym"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL SymEnumSym(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PSYM_ENUMERATESYMBOLS_CALLBACK")] delegate* unmanaged<SYMBOL_INFO*, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumerateSymbols64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumerateSymbols64(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PSYM_ENUMSYMBOLS_CALLBACK64")] delegate* unmanaged<sbyte*, ulong, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumerateSymbolsW64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumerateSymbolsW64(HANDLE hProcess, [NativeTypeName("ULONG64")] ulong BaseOfDll, [NativeTypeName("PSYM_ENUMSYMBOLS_CALLBACK64W")] delegate* unmanaged<ushort*, ulong, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumerateSymbols"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumerateSymbols(HANDLE hProcess, [NativeTypeName("ULONG")] uint BaseOfDll, [NativeTypeName("PSYM_ENUMSYMBOLS_CALLBACK")] delegate* unmanaged<sbyte*, uint, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymEnumerateSymbolsW"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymEnumerateSymbolsW(HANDLE hProcess, [NativeTypeName("ULONG")] uint BaseOfDll, [NativeTypeName("PSYM_ENUMSYMBOLS_CALLBACKW")] delegate* unmanaged<ushort*, uint, uint, void*, BOOL> EnumSymbolsCallback, [NativeTypeName("PVOID")] void* UserContext);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymLoadModule64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD64")]
    public static extern ulong SymLoadModule64(HANDLE hProcess, HANDLE hFile, [NativeTypeName("PCSTR")] sbyte* ImageName, [NativeTypeName("PCSTR")] sbyte* ModuleName, [NativeTypeName("DWORD64")] ulong BaseOfDll, [NativeTypeName("DWORD")] uint SizeOfDll);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymLoadModule"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SymLoadModule(HANDLE hProcess, HANDLE hFile, [NativeTypeName("PCSTR")] sbyte* ImageName, [NativeTypeName("PCSTR")] sbyte* ModuleName, [NativeTypeName("DWORD")] uint BaseOfDll, [NativeTypeName("DWORD")] uint SizeOfDll);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSymNext64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSymNext64(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_SYMBOL64")] IMAGEHLP_SYMBOL64* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSymNext"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSymNext(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_SYMBOL")] IMAGEHLP_SYMBOL* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSymPrev64"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSymPrev64(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_SYMBOL64")] IMAGEHLP_SYMBOL64* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SymGetSymPrev"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SymGetSymPrev(HANDLE hProcess, [NativeTypeName("PIMAGEHLP_SYMBOL")] IMAGEHLP_SYMBOL* Symbol);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCheckUserInterruptShared"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern void SetCheckUserInterruptShared([NativeTypeName("LPCALL_BACK_USER_INTERRUPT_ROUTINE")] delegate* unmanaged<uint> lpStartAddress);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetSymLoadError"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetSymLoadError();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetSymLoadError"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern void SetSymLoadError([NativeTypeName("DWORD")] uint error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReportSymbolLoadSummary"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL ReportSymbolLoadSummary(HANDLE hProcess, [NativeTypeName("PCWSTR")] ushort* pLoadModule, [NativeTypeName("PDBGHELP_DATA_REPORT_STRUCT")] DBGHELP_DATA_REPORT_STRUCT* pSymbolData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveInvalidModuleList"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern void RemoveInvalidModuleList(HANDLE hProcess);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RangeMapCreate"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    [return: NativeTypeName("PVOID")]
    public static extern void* RangeMapCreate();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RangeMapFree"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern void RangeMapFree([NativeTypeName("PVOID")] void* RmapHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RangeMapAddPeImageSections"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL RangeMapAddPeImageSections([NativeTypeName("PVOID")] void* RmapHandle, [NativeTypeName("PCWSTR")] ushort* ImageName, [NativeTypeName("PVOID")] void* MappedImage, [NativeTypeName("DWORD")] uint MappingBytes, [NativeTypeName("DWORD64")] ulong ImageBase, [NativeTypeName("DWORD64")] ulong UserTag, [NativeTypeName("DWORD")] uint MappingFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RangeMapRemove"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL RangeMapRemove([NativeTypeName("PVOID")] void* RmapHandle, [NativeTypeName("DWORD64")] ulong UserTag);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RangeMapRead"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL RangeMapRead([NativeTypeName("PVOID")] void* RmapHandle, [NativeTypeName("DWORD64")] ulong Offset, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("DWORD")] uint RequestBytes, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PDWORD")] uint* DoneBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RangeMapWrite"]/*' />
    [DllImport("DbgHelp", ExactSpelling = true)]
    public static extern BOOL RangeMapWrite([NativeTypeName("PVOID")] void* RmapHandle, [NativeTypeName("DWORD64")] ulong Offset, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("DWORD")] uint RequestBytes, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PDWORD")] uint* DoneBytes);

    [NativeTypeName("#define UNDNAME_COMPLETE (0x0000)")]
    public const int UNDNAME_COMPLETE = (0x0000);

    [NativeTypeName("#define UNDNAME_NO_LEADING_UNDERSCORES (0x0001)")]
    public const int UNDNAME_NO_LEADING_UNDERSCORES = (0x0001);

    [NativeTypeName("#define UNDNAME_NO_MS_KEYWORDS (0x0002)")]
    public const int UNDNAME_NO_MS_KEYWORDS = (0x0002);

    [NativeTypeName("#define UNDNAME_NO_FUNCTION_RETURNS (0x0004)")]
    public const int UNDNAME_NO_FUNCTION_RETURNS = (0x0004);

    [NativeTypeName("#define UNDNAME_NO_ALLOCATION_MODEL (0x0008)")]
    public const int UNDNAME_NO_ALLOCATION_MODEL = (0x0008);

    [NativeTypeName("#define UNDNAME_NO_ALLOCATION_LANGUAGE (0x0010)")]
    public const int UNDNAME_NO_ALLOCATION_LANGUAGE = (0x0010);

    [NativeTypeName("#define UNDNAME_NO_MS_THISTYPE (0x0020)")]
    public const int UNDNAME_NO_MS_THISTYPE = (0x0020);

    [NativeTypeName("#define UNDNAME_NO_CV_THISTYPE (0x0040)")]
    public const int UNDNAME_NO_CV_THISTYPE = (0x0040);

    [NativeTypeName("#define UNDNAME_NO_THISTYPE (0x0060)")]
    public const int UNDNAME_NO_THISTYPE = (0x0060);

    [NativeTypeName("#define UNDNAME_NO_ACCESS_SPECIFIERS (0x0080)")]
    public const int UNDNAME_NO_ACCESS_SPECIFIERS = (0x0080);

    [NativeTypeName("#define UNDNAME_NO_THROW_SIGNATURES (0x0100)")]
    public const int UNDNAME_NO_THROW_SIGNATURES = (0x0100);

    [NativeTypeName("#define UNDNAME_NO_MEMBER_TYPE (0x0200)")]
    public const int UNDNAME_NO_MEMBER_TYPE = (0x0200);

    [NativeTypeName("#define UNDNAME_NO_RETURN_UDT_MODEL (0x0400)")]
    public const int UNDNAME_NO_RETURN_UDT_MODEL = (0x0400);

    [NativeTypeName("#define UNDNAME_32_BIT_DECODE (0x0800)")]
    public const int UNDNAME_32_BIT_DECODE = (0x0800);

    [NativeTypeName("#define UNDNAME_NAME_ONLY (0x1000)")]
    public const int UNDNAME_NAME_ONLY = (0x1000);

    [NativeTypeName("#define UNDNAME_NO_ARGUMENTS (0x2000)")]
    public const int UNDNAME_NO_ARGUMENTS = (0x2000);

    [NativeTypeName("#define UNDNAME_NO_SPECIAL_SYMS (0x4000)")]
    public const int UNDNAME_NO_SPECIAL_SYMS = (0x4000);

    [NativeTypeName("#define DBHHEADER_DEBUGDIRS 0x1")]
    public const int DBHHEADER_DEBUGDIRS = 0x1;

    [NativeTypeName("#define DBHHEADER_CVMISC 0x2")]
    public const int DBHHEADER_CVMISC = 0x2;

    [NativeTypeName("#define DBHHEADER_PDBGUID 0x3")]
    public const int DBHHEADER_PDBGUID = 0x3;

    [NativeTypeName("#define INLINE_FRAME_CONTEXT_INIT 0")]
    public const int INLINE_FRAME_CONTEXT_INIT = 0;

    [NativeTypeName("#define INLINE_FRAME_CONTEXT_IGNORE 0xFFFFFFFF")]
    public const uint INLINE_FRAME_CONTEXT_IGNORE = 0xFFFFFFFF;

    [NativeTypeName("#define TARGET_ATTRIBUTE_PACMASK 0x00000001")]
    public const int TARGET_ATTRIBUTE_PACMASK = 0x00000001;

    [NativeTypeName("#define TARGET_ATTRIBUTE_PACMASK_LIVETARGET 0xFFFFFFFFFFFFFFFFull")]
    public const ulong TARGET_ATTRIBUTE_PACMASK_LIVETARGET = 0xFFFFFFFFFFFFFFFFUL;

    [NativeTypeName("#define SYM_STKWALK_DEFAULT 0x00000000")]
    public const int SYM_STKWALK_DEFAULT = 0x00000000;

    [NativeTypeName("#define SYM_STKWALK_FORCE_FRAMEPTR 0x00000001")]
    public const int SYM_STKWALK_FORCE_FRAMEPTR = 0x00000001;

    [NativeTypeName("#define SYM_STKWALK_ZEROEXTEND_PTRS 0x00000002")]
    public const int SYM_STKWALK_ZEROEXTEND_PTRS = 0x00000002;

    [NativeTypeName("#define API_VERSION_NUMBER 12")]
    public const int API_VERSION_NUMBER = 12;

    [NativeTypeName("#define SYMFLAG_VALUEPRESENT 0x00000001")]
    public const int SYMFLAG_VALUEPRESENT = 0x00000001;

    [NativeTypeName("#define SYMFLAG_REGISTER 0x00000008")]
    public const int SYMFLAG_REGISTER = 0x00000008;

    [NativeTypeName("#define SYMFLAG_REGREL 0x00000010")]
    public const int SYMFLAG_REGREL = 0x00000010;

    [NativeTypeName("#define SYMFLAG_FRAMEREL 0x00000020")]
    public const int SYMFLAG_FRAMEREL = 0x00000020;

    [NativeTypeName("#define SYMFLAG_PARAMETER 0x00000040")]
    public const int SYMFLAG_PARAMETER = 0x00000040;

    [NativeTypeName("#define SYMFLAG_LOCAL 0x00000080")]
    public const int SYMFLAG_LOCAL = 0x00000080;

    [NativeTypeName("#define SYMFLAG_CONSTANT 0x00000100")]
    public const int SYMFLAG_CONSTANT = 0x00000100;

    [NativeTypeName("#define SYMFLAG_EXPORT 0x00000200")]
    public const int SYMFLAG_EXPORT = 0x00000200;

    [NativeTypeName("#define SYMFLAG_FORWARDER 0x00000400")]
    public const int SYMFLAG_FORWARDER = 0x00000400;

    [NativeTypeName("#define SYMFLAG_FUNCTION 0x00000800")]
    public const int SYMFLAG_FUNCTION = 0x00000800;

    [NativeTypeName("#define SYMFLAG_VIRTUAL 0x00001000")]
    public const int SYMFLAG_VIRTUAL = 0x00001000;

    [NativeTypeName("#define SYMFLAG_THUNK 0x00002000")]
    public const int SYMFLAG_THUNK = 0x00002000;

    [NativeTypeName("#define SYMFLAG_TLSREL 0x00004000")]
    public const int SYMFLAG_TLSREL = 0x00004000;

    [NativeTypeName("#define SYMFLAG_SLOT 0x00008000")]
    public const int SYMFLAG_SLOT = 0x00008000;

    [NativeTypeName("#define SYMFLAG_ILREL 0x00010000")]
    public const int SYMFLAG_ILREL = 0x00010000;

    [NativeTypeName("#define SYMFLAG_METADATA 0x00020000")]
    public const int SYMFLAG_METADATA = 0x00020000;

    [NativeTypeName("#define SYMFLAG_CLR_TOKEN 0x00040000")]
    public const int SYMFLAG_CLR_TOKEN = 0x00040000;

    [NativeTypeName("#define SYMFLAG_NULL 0x00080000")]
    public const int SYMFLAG_NULL = 0x00080000;

    [NativeTypeName("#define SYMFLAG_FUNC_NO_RETURN 0x00100000")]
    public const int SYMFLAG_FUNC_NO_RETURN = 0x00100000;

    [NativeTypeName("#define SYMFLAG_SYNTHETIC_ZEROBASE 0x00200000")]
    public const int SYMFLAG_SYNTHETIC_ZEROBASE = 0x00200000;

    [NativeTypeName("#define SYMFLAG_PUBLIC_CODE 0x00400000")]
    public const int SYMFLAG_PUBLIC_CODE = 0x00400000;

    [NativeTypeName("#define SYMFLAG_REGREL_ALIASINDIR 0x00800000")]
    public const int SYMFLAG_REGREL_ALIASINDIR = 0x00800000;

    [NativeTypeName("#define SYMFLAG_FIXUP_ARM64X 0x01000000")]
    public const int SYMFLAG_FIXUP_ARM64X = 0x01000000;

    [NativeTypeName("#define SYMFLAG_GLOBAL 0x02000000")]
    public const int SYMFLAG_GLOBAL = 0x02000000;

    [NativeTypeName("#define SYMFLAG_RESET 0x80000000")]
    public const uint SYMFLAG_RESET = 0x80000000;

    [NativeTypeName("#define IMAGEHLP_MODULE_REGION_DLLBASE 0x01")]
    public const int IMAGEHLP_MODULE_REGION_DLLBASE = 0x01;

    [NativeTypeName("#define IMAGEHLP_MODULE_REGION_DLLRANGE 0x02")]
    public const int IMAGEHLP_MODULE_REGION_DLLRANGE = 0x02;

    [NativeTypeName("#define IMAGEHLP_MODULE_REGION_ADDITIONAL 0x04")]
    public const int IMAGEHLP_MODULE_REGION_ADDITIONAL = 0x04;

    [NativeTypeName("#define IMAGEHLP_MODULE_REGION_JIT 0x08")]
    public const int IMAGEHLP_MODULE_REGION_JIT = 0x08;

    [NativeTypeName("#define IMAGEHLP_MODULE_REGION_ALL 0xFF")]
    public const int IMAGEHLP_MODULE_REGION_ALL = 0xFF;

    [NativeTypeName("#define CBA_DEFERRED_SYMBOL_LOAD_START 0x00000001")]
    public const int CBA_DEFERRED_SYMBOL_LOAD_START = 0x00000001;

    [NativeTypeName("#define CBA_DEFERRED_SYMBOL_LOAD_COMPLETE 0x00000002")]
    public const int CBA_DEFERRED_SYMBOL_LOAD_COMPLETE = 0x00000002;

    [NativeTypeName("#define CBA_DEFERRED_SYMBOL_LOAD_FAILURE 0x00000003")]
    public const int CBA_DEFERRED_SYMBOL_LOAD_FAILURE = 0x00000003;

    [NativeTypeName("#define CBA_SYMBOLS_UNLOADED 0x00000004")]
    public const int CBA_SYMBOLS_UNLOADED = 0x00000004;

    [NativeTypeName("#define CBA_DUPLICATE_SYMBOL 0x00000005")]
    public const int CBA_DUPLICATE_SYMBOL = 0x00000005;

    [NativeTypeName("#define CBA_READ_MEMORY 0x00000006")]
    public const int CBA_READ_MEMORY = 0x00000006;

    [NativeTypeName("#define CBA_DEFERRED_SYMBOL_LOAD_CANCEL 0x00000007")]
    public const int CBA_DEFERRED_SYMBOL_LOAD_CANCEL = 0x00000007;

    [NativeTypeName("#define CBA_SET_OPTIONS 0x00000008")]
    public const int CBA_SET_OPTIONS = 0x00000008;

    [NativeTypeName("#define CBA_EVENT 0x00000010")]
    public const int CBA_EVENT = 0x00000010;

    [NativeTypeName("#define CBA_DEFERRED_SYMBOL_LOAD_PARTIAL 0x00000020")]
    public const int CBA_DEFERRED_SYMBOL_LOAD_PARTIAL = 0x00000020;

    [NativeTypeName("#define CBA_DEBUG_INFO 0x10000000")]
    public const int CBA_DEBUG_INFO = 0x10000000;

    [NativeTypeName("#define CBA_SRCSRV_INFO 0x20000000")]
    public const int CBA_SRCSRV_INFO = 0x20000000;

    [NativeTypeName("#define CBA_SRCSRV_EVENT 0x40000000")]
    public const int CBA_SRCSRV_EVENT = 0x40000000;

    [NativeTypeName("#define CBA_UPDATE_STATUS_BAR 0x50000000")]
    public const int CBA_UPDATE_STATUS_BAR = 0x50000000;

    [NativeTypeName("#define CBA_ENGINE_PRESENT 0x60000000")]
    public const int CBA_ENGINE_PRESENT = 0x60000000;

    [NativeTypeName("#define CBA_CHECK_ENGOPT_DISALLOW_NETWORK_PATHS 0x70000000")]
    public const int CBA_CHECK_ENGOPT_DISALLOW_NETWORK_PATHS = 0x70000000;

    [NativeTypeName("#define CBA_CHECK_ARM_MACHINE_THUMB_TYPE_OVERRIDE 0x80000000")]
    public const uint CBA_CHECK_ARM_MACHINE_THUMB_TYPE_OVERRIDE = 0x80000000;

    [NativeTypeName("#define CBA_XML_LOG 0x90000000")]
    public const uint CBA_XML_LOG = 0x90000000;

    [NativeTypeName("#define CBA_MAP_JIT_SYMBOL 0xA0000000")]
    public const uint CBA_MAP_JIT_SYMBOL = 0xA0000000;

    [NativeTypeName("#define DSLFLAG_MISMATCHED_PDB 0x1")]
    public const int DSLFLAG_MISMATCHED_PDB = 0x1;

    [NativeTypeName("#define DSLFLAG_MISMATCHED_DBG 0x2")]
    public const int DSLFLAG_MISMATCHED_DBG = 0x2;

    [NativeTypeName("#define SYMOPT_CASE_INSENSITIVE 0x00000001")]
    public const int SYMOPT_CASE_INSENSITIVE = 0x00000001;

    [NativeTypeName("#define SYMOPT_UNDNAME 0x00000002")]
    public const int SYMOPT_UNDNAME = 0x00000002;

    [NativeTypeName("#define SYMOPT_DEFERRED_LOADS 0x00000004")]
    public const int SYMOPT_DEFERRED_LOADS = 0x00000004;

    [NativeTypeName("#define SYMOPT_NO_CPP 0x00000008")]
    public const int SYMOPT_NO_CPP = 0x00000008;

    [NativeTypeName("#define SYMOPT_LOAD_LINES 0x00000010")]
    public const int SYMOPT_LOAD_LINES = 0x00000010;

    [NativeTypeName("#define SYMOPT_OMAP_FIND_NEAREST 0x00000020")]
    public const int SYMOPT_OMAP_FIND_NEAREST = 0x00000020;

    [NativeTypeName("#define SYMOPT_LOAD_ANYTHING 0x00000040")]
    public const int SYMOPT_LOAD_ANYTHING = 0x00000040;

    [NativeTypeName("#define SYMOPT_IGNORE_CVREC 0x00000080")]
    public const int SYMOPT_IGNORE_CVREC = 0x00000080;

    [NativeTypeName("#define SYMOPT_NO_UNQUALIFIED_LOADS 0x00000100")]
    public const int SYMOPT_NO_UNQUALIFIED_LOADS = 0x00000100;

    [NativeTypeName("#define SYMOPT_FAIL_CRITICAL_ERRORS 0x00000200")]
    public const int SYMOPT_FAIL_CRITICAL_ERRORS = 0x00000200;

    [NativeTypeName("#define SYMOPT_EXACT_SYMBOLS 0x00000400")]
    public const int SYMOPT_EXACT_SYMBOLS = 0x00000400;

    [NativeTypeName("#define SYMOPT_ALLOW_ABSOLUTE_SYMBOLS 0x00000800")]
    public const int SYMOPT_ALLOW_ABSOLUTE_SYMBOLS = 0x00000800;

    [NativeTypeName("#define SYMOPT_IGNORE_NT_SYMPATH 0x00001000")]
    public const int SYMOPT_IGNORE_NT_SYMPATH = 0x00001000;

    [NativeTypeName("#define SYMOPT_INCLUDE_32BIT_MODULES 0x00002000")]
    public const int SYMOPT_INCLUDE_32BIT_MODULES = 0x00002000;

    [NativeTypeName("#define SYMOPT_PUBLICS_ONLY 0x00004000")]
    public const int SYMOPT_PUBLICS_ONLY = 0x00004000;

    [NativeTypeName("#define SYMOPT_NO_PUBLICS 0x00008000")]
    public const int SYMOPT_NO_PUBLICS = 0x00008000;

    [NativeTypeName("#define SYMOPT_AUTO_PUBLICS 0x00010000")]
    public const int SYMOPT_AUTO_PUBLICS = 0x00010000;

    [NativeTypeName("#define SYMOPT_NO_IMAGE_SEARCH 0x00020000")]
    public const int SYMOPT_NO_IMAGE_SEARCH = 0x00020000;

    [NativeTypeName("#define SYMOPT_SECURE 0x00040000")]
    public const int SYMOPT_SECURE = 0x00040000;

    [NativeTypeName("#define SYMOPT_NO_PROMPTS 0x00080000")]
    public const int SYMOPT_NO_PROMPTS = 0x00080000;

    [NativeTypeName("#define SYMOPT_OVERWRITE 0x00100000")]
    public const int SYMOPT_OVERWRITE = 0x00100000;

    [NativeTypeName("#define SYMOPT_IGNORE_IMAGEDIR 0x00200000")]
    public const int SYMOPT_IGNORE_IMAGEDIR = 0x00200000;

    [NativeTypeName("#define SYMOPT_FLAT_DIRECTORY 0x00400000")]
    public const int SYMOPT_FLAT_DIRECTORY = 0x00400000;

    [NativeTypeName("#define SYMOPT_FAVOR_COMPRESSED 0x00800000")]
    public const int SYMOPT_FAVOR_COMPRESSED = 0x00800000;

    [NativeTypeName("#define SYMOPT_ALLOW_ZERO_ADDRESS 0x01000000")]
    public const int SYMOPT_ALLOW_ZERO_ADDRESS = 0x01000000;

    [NativeTypeName("#define SYMOPT_DISABLE_SYMSRV_AUTODETECT 0x02000000")]
    public const int SYMOPT_DISABLE_SYMSRV_AUTODETECT = 0x02000000;

    [NativeTypeName("#define SYMOPT_READONLY_CACHE 0x04000000")]
    public const int SYMOPT_READONLY_CACHE = 0x04000000;

    [NativeTypeName("#define SYMOPT_SYMPATH_LAST 0x08000000")]
    public const int SYMOPT_SYMPATH_LAST = 0x08000000;

    [NativeTypeName("#define SYMOPT_DISABLE_FAST_SYMBOLS 0x10000000")]
    public const int SYMOPT_DISABLE_FAST_SYMBOLS = 0x10000000;

    [NativeTypeName("#define SYMOPT_DISABLE_SYMSRV_TIMEOUT 0x20000000")]
    public const int SYMOPT_DISABLE_SYMSRV_TIMEOUT = 0x20000000;

    [NativeTypeName("#define SYMOPT_DISABLE_SRVSTAR_ON_STARTUP 0x40000000")]
    public const int SYMOPT_DISABLE_SRVSTAR_ON_STARTUP = 0x40000000;

    [NativeTypeName("#define SYMOPT_DEBUG 0x80000000")]
    public const uint SYMOPT_DEBUG = 0x80000000;

    [NativeTypeName("#define SYM_INLINE_COMP_ERROR 0")]
    public const int SYM_INLINE_COMP_ERROR = 0;

    [NativeTypeName("#define SYM_INLINE_COMP_IDENTICAL 1")]
    public const int SYM_INLINE_COMP_IDENTICAL = 1;

    [NativeTypeName("#define SYM_INLINE_COMP_STEPIN 2")]
    public const int SYM_INLINE_COMP_STEPIN = 2;

    [NativeTypeName("#define SYM_INLINE_COMP_STEPOUT 3")]
    public const int SYM_INLINE_COMP_STEPOUT = 3;

    [NativeTypeName("#define SYM_INLINE_COMP_STEPOVER 4")]
    public const int SYM_INLINE_COMP_STEPOVER = 4;

    [NativeTypeName("#define SYM_INLINE_COMP_DIFFERENT 5")]
    public const int SYM_INLINE_COMP_DIFFERENT = 5;

    [NativeTypeName("#define ESLFLAG_FULLPATH 0x00000001")]
    public const int ESLFLAG_FULLPATH = 0x00000001;

    [NativeTypeName("#define ESLFLAG_NEAREST 0x00000002")]
    public const int ESLFLAG_NEAREST = 0x00000002;

    [NativeTypeName("#define ESLFLAG_PREV 0x00000004")]
    public const int ESLFLAG_PREV = 0x00000004;

    [NativeTypeName("#define ESLFLAG_NEXT 0x00000008")]
    public const int ESLFLAG_NEXT = 0x00000008;

    [NativeTypeName("#define ESLFLAG_INLINE_SITE 0x00000010")]
    public const int ESLFLAG_INLINE_SITE = 0x00000010;

    [NativeTypeName("#define SLMFLAG_VIRTUAL 0x1")]
    public const int SLMFLAG_VIRTUAL = 0x1;

    [NativeTypeName("#define SLMFLAG_ALT_INDEX 0x2")]
    public const int SLMFLAG_ALT_INDEX = 0x2;

    [NativeTypeName("#define SLMFLAG_NO_SYMBOLS 0x4")]
    public const int SLMFLAG_NO_SYMBOLS = 0x4;

    [NativeTypeName("#define SYMENUM_OPTIONS_DEFAULT 0x00000001")]
    public const int SYMENUM_OPTIONS_DEFAULT = 0x00000001;

    [NativeTypeName("#define SYMENUM_OPTIONS_INLINE 0x00000002")]
    public const int SYMENUM_OPTIONS_INLINE = 0x00000002;

    [NativeTypeName("#define SYMSEARCH_MASKOBJS 0x01")]
    public const int SYMSEARCH_MASKOBJS = 0x01;

    [NativeTypeName("#define SYMSEARCH_RECURSE 0X02")]
    public const int SYMSEARCH_RECURSE = 0X02;

    [NativeTypeName("#define SYMSEARCH_GLOBALSONLY 0X04")]
    public const int SYMSEARCH_GLOBALSONLY = 0X04;

    [NativeTypeName("#define SYMSEARCH_ALLITEMS 0X08")]
    public const int SYMSEARCH_ALLITEMS = 0X08;

    [NativeTypeName("#define IMAGEHLP_GET_TYPE_INFO_UNCACHED 0x00000001")]
    public const int IMAGEHLP_GET_TYPE_INFO_UNCACHED = 0x00000001;

    [NativeTypeName("#define IMAGEHLP_GET_TYPE_INFO_CHILDREN 0x00000002")]
    public const int IMAGEHLP_GET_TYPE_INFO_CHILDREN = 0x00000002;

    [NativeTypeName("#define EXT_OUTPUT_VER 1")]
    public const int EXT_OUTPUT_VER = 1;

    [NativeTypeName("#define SYMSRV_VERSION 2")]
    public const int SYMSRV_VERSION = 2;

    [NativeTypeName("#define SSRVOPT_CALLBACK 0x00000001")]
    public const int SSRVOPT_CALLBACK = 0x00000001;

    [NativeTypeName("#define SSRVOPT_DWORD 0x00000002")]
    public const int SSRVOPT_DWORD = 0x00000002;

    [NativeTypeName("#define SSRVOPT_DWORDPTR 0x00000004")]
    public const int SSRVOPT_DWORDPTR = 0x00000004;

    [NativeTypeName("#define SSRVOPT_GUIDPTR 0x00000008")]
    public const int SSRVOPT_GUIDPTR = 0x00000008;

    [NativeTypeName("#define SSRVOPT_OLDGUIDPTR 0x00000010")]
    public const int SSRVOPT_OLDGUIDPTR = 0x00000010;

    [NativeTypeName("#define SSRVOPT_UNATTENDED 0x00000020")]
    public const int SSRVOPT_UNATTENDED = 0x00000020;

    [NativeTypeName("#define SSRVOPT_NOCOPY 0x00000040")]
    public const int SSRVOPT_NOCOPY = 0x00000040;

    [NativeTypeName("#define SSRVOPT_GETPATH 0x00000040")]
    public const int SSRVOPT_GETPATH = 0x00000040;

    [NativeTypeName("#define SSRVOPT_PARENTWIN 0x00000080")]
    public const int SSRVOPT_PARENTWIN = 0x00000080;

    [NativeTypeName("#define SSRVOPT_PARAMTYPE 0x00000100")]
    public const int SSRVOPT_PARAMTYPE = 0x00000100;

    [NativeTypeName("#define SSRVOPT_SECURE 0x00000200")]
    public const int SSRVOPT_SECURE = 0x00000200;

    [NativeTypeName("#define SSRVOPT_TRACE 0x00000400")]
    public const int SSRVOPT_TRACE = 0x00000400;

    [NativeTypeName("#define SSRVOPT_SETCONTEXT 0x00000800")]
    public const int SSRVOPT_SETCONTEXT = 0x00000800;

    [NativeTypeName("#define SSRVOPT_PROXY 0x00001000")]
    public const int SSRVOPT_PROXY = 0x00001000;

    [NativeTypeName("#define SSRVOPT_DOWNSTREAM_STORE 0x00002000")]
    public const int SSRVOPT_DOWNSTREAM_STORE = 0x00002000;

    [NativeTypeName("#define SSRVOPT_OVERWRITE 0x00004000")]
    public const int SSRVOPT_OVERWRITE = 0x00004000;

    [NativeTypeName("#define SSRVOPT_RESETTOU 0x00008000")]
    public const int SSRVOPT_RESETTOU = 0x00008000;

    [NativeTypeName("#define SSRVOPT_CALLBACKW 0x00010000")]
    public const int SSRVOPT_CALLBACKW = 0x00010000;

    [NativeTypeName("#define SSRVOPT_FLAT_DEFAULT_STORE 0x00020000")]
    public const int SSRVOPT_FLAT_DEFAULT_STORE = 0x00020000;

    [NativeTypeName("#define SSRVOPT_PROXYW 0x00040000")]
    public const int SSRVOPT_PROXYW = 0x00040000;

    [NativeTypeName("#define SSRVOPT_MESSAGE 0x00080000")]
    public const int SSRVOPT_MESSAGE = 0x00080000;

    [NativeTypeName("#define SSRVOPT_SERVICE 0x00100000")]
    public const int SSRVOPT_SERVICE = 0x00100000;

    [NativeTypeName("#define SSRVOPT_FAVOR_COMPRESSED 0x00200000")]
    public const int SSRVOPT_FAVOR_COMPRESSED = 0x00200000;

    [NativeTypeName("#define SSRVOPT_STRING 0x00400000")]
    public const int SSRVOPT_STRING = 0x00400000;

    [NativeTypeName("#define SSRVOPT_WINHTTP 0x00800000")]
    public const int SSRVOPT_WINHTTP = 0x00800000;

    [NativeTypeName("#define SSRVOPT_WININET 0x01000000")]
    public const int SSRVOPT_WININET = 0x01000000;

    [NativeTypeName("#define SSRVOPT_DONT_UNCOMPRESS 0x02000000")]
    public const int SSRVOPT_DONT_UNCOMPRESS = 0x02000000;

    [NativeTypeName("#define SSRVOPT_DISABLE_PING_HOST 0x04000000")]
    public const int SSRVOPT_DISABLE_PING_HOST = 0x04000000;

    [NativeTypeName("#define SSRVOPT_DISABLE_TIMEOUT 0x08000000")]
    public const int SSRVOPT_DISABLE_TIMEOUT = 0x08000000;

    [NativeTypeName("#define SSRVOPT_ENABLE_COMM_MSG 0x10000000")]
    public const int SSRVOPT_ENABLE_COMM_MSG = 0x10000000;

    [NativeTypeName("#define SSRVOPT_URI_FILTER 0x20000000")]
    public const int SSRVOPT_URI_FILTER = 0x20000000;

    [NativeTypeName("#define SSRVOPT_URI_TIERS 0x40000000")]
    public const int SSRVOPT_URI_TIERS = 0x40000000;

    [NativeTypeName("#define SSRVOPT_RETRY_APP_HANG 0x80000000")]
    public const uint SSRVOPT_RETRY_APP_HANG = 0x80000000;

    [NativeTypeName("#define SSRVOPT_MAX 0x80000000")]
    public const uint SSRVOPT_MAX = 0x80000000;

    [NativeTypeName("#define SSRVOPT_RESET ((ULONG_PTR)-1)")]
    public static nuint SSRVOPT_RESET => unchecked((nuint)(-1));

    [NativeTypeName("#define NUM_SSRVOPTS 32")]
    public const int NUM_SSRVOPTS = 32;

    [NativeTypeName("#define SSRVURI_HTTP_NORMAL 0x01")]
    public const int SSRVURI_HTTP_NORMAL = 0x01;

    [NativeTypeName("#define SSRVURI_HTTP_COMPRESSED 0x02")]
    public const int SSRVURI_HTTP_COMPRESSED = 0x02;

    [NativeTypeName("#define SSRVURI_HTTP_FILEPTR 0x04")]
    public const int SSRVURI_HTTP_FILEPTR = 0x04;

    [NativeTypeName("#define SSRVURI_UNC_NORMAL 0x10")]
    public const int SSRVURI_UNC_NORMAL = 0x10;

    [NativeTypeName("#define SSRVURI_UNC_COMPRESSED 0x20")]
    public const int SSRVURI_UNC_COMPRESSED = 0x20;

    [NativeTypeName("#define SSRVURI_UNC_FILEPTR 0x40")]
    public const int SSRVURI_UNC_FILEPTR = 0x40;

    [NativeTypeName("#define SSRVURI_HTTP_MASK 0x0F")]
    public const int SSRVURI_HTTP_MASK = 0x0F;

    [NativeTypeName("#define SSRVURI_UNC_MASK 0xF0")]
    public const int SSRVURI_UNC_MASK = 0xF0;

    [NativeTypeName("#define SSRVURI_ALL 0xFF")]
    public const int SSRVURI_ALL = 0xFF;

    [NativeTypeName("#define SSRVURI_NORMAL SSRVURI_HTTP_NORMAL")]
    public const int SSRVURI_NORMAL = 0x01;

    [NativeTypeName("#define SSRVURI_COMPRESSED SSRVURI_HTTP_COMPRESSED")]
    public const int SSRVURI_COMPRESSED = 0x02;

    [NativeTypeName("#define SSRVURI_FILEPTR SSRVURI_HTTP_FILEPTR")]
    public const int SSRVURI_FILEPTR = 0x04;

    [NativeTypeName("#define SSRVACTION_TRACE 1")]
    public const int SSRVACTION_TRACE = 1;

    [NativeTypeName("#define SSRVACTION_QUERYCANCEL 2")]
    public const int SSRVACTION_QUERYCANCEL = 2;

    [NativeTypeName("#define SSRVACTION_EVENT 3")]
    public const int SSRVACTION_EVENT = 3;

    [NativeTypeName("#define SSRVACTION_EVENTW 4")]
    public const int SSRVACTION_EVENTW = 4;

    [NativeTypeName("#define SSRVACTION_SIZE 5")]
    public const int SSRVACTION_SIZE = 5;

    [NativeTypeName("#define SSRVACTION_HTTPSTATUS 6")]
    public const int SSRVACTION_HTTPSTATUS = 6;

    [NativeTypeName("#define SSRVACTION_XMLOUTPUT 7")]
    public const int SSRVACTION_XMLOUTPUT = 7;

    [NativeTypeName("#define SSRVACTION_CHECKSUMSTATUS 8")]
    public const int SSRVACTION_CHECKSUMSTATUS = 8;

    [NativeTypeName("#define SYMSTOREOPT_COMPRESS 0x01")]
    public const int SYMSTOREOPT_COMPRESS = 0x01;

    [NativeTypeName("#define SYMSTOREOPT_OVERWRITE 0x02")]
    public const int SYMSTOREOPT_OVERWRITE = 0x02;

    [NativeTypeName("#define SYMSTOREOPT_RETURNINDEX 0x04")]
    public const int SYMSTOREOPT_RETURNINDEX = 0x04;

    [NativeTypeName("#define SYMSTOREOPT_POINTER 0x08")]
    public const int SYMSTOREOPT_POINTER = 0x08;

    [NativeTypeName("#define SYMSTOREOPT_ALT_INDEX 0x10")]
    public const int SYMSTOREOPT_ALT_INDEX = 0x10;

    [NativeTypeName("#define SYMSTOREOPT_UNICODE 0x20")]
    public const int SYMSTOREOPT_UNICODE = 0x20;

    [NativeTypeName("#define SYMSTOREOPT_PASS_IF_EXISTS 0x40")]
    public const int SYMSTOREOPT_PASS_IF_EXISTS = 0x40;

    [NativeTypeName("#define SYMF_OMAP_GENERATED 0x00000001")]
    public const int SYMF_OMAP_GENERATED = 0x00000001;

    [NativeTypeName("#define SYMF_OMAP_MODIFIED 0x00000002")]
    public const int SYMF_OMAP_MODIFIED = 0x00000002;

    [NativeTypeName("#define SYMF_REGISTER 0x00000008")]
    public const int SYMF_REGISTER = 0x00000008;

    [NativeTypeName("#define SYMF_REGREL 0x00000010")]
    public const int SYMF_REGREL = 0x00000010;

    [NativeTypeName("#define SYMF_FRAMEREL 0x00000020")]
    public const int SYMF_FRAMEREL = 0x00000020;

    [NativeTypeName("#define SYMF_PARAMETER 0x00000040")]
    public const int SYMF_PARAMETER = 0x00000040;

    [NativeTypeName("#define SYMF_LOCAL 0x00000080")]
    public const int SYMF_LOCAL = 0x00000080;

    [NativeTypeName("#define SYMF_CONSTANT 0x00000100")]
    public const int SYMF_CONSTANT = 0x00000100;

    [NativeTypeName("#define SYMF_EXPORT 0x00000200")]
    public const int SYMF_EXPORT = 0x00000200;

    [NativeTypeName("#define SYMF_FORWARDER 0x00000400")]
    public const int SYMF_FORWARDER = 0x00000400;

    [NativeTypeName("#define SYMF_FUNCTION 0x00000800")]
    public const int SYMF_FUNCTION = 0x00000800;

    [NativeTypeName("#define SYMF_VIRTUAL 0x00001000")]
    public const int SYMF_VIRTUAL = 0x00001000;

    [NativeTypeName("#define SYMF_THUNK 0x00002000")]
    public const int SYMF_THUNK = 0x00002000;

    [NativeTypeName("#define SYMF_TLSREL 0x00004000")]
    public const int SYMF_TLSREL = 0x00004000;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_INFO_VALUEPRESENT 1")]
    public const int IMAGEHLP_SYMBOL_INFO_VALUEPRESENT = 1;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_INFO_REGISTER SYMF_REGISTER")]
    public const int IMAGEHLP_SYMBOL_INFO_REGISTER = 0x00000008;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_INFO_REGRELATIVE SYMF_REGREL")]
    public const int IMAGEHLP_SYMBOL_INFO_REGRELATIVE = 0x00000010;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_INFO_FRAMERELATIVE SYMF_FRAMEREL")]
    public const int IMAGEHLP_SYMBOL_INFO_FRAMERELATIVE = 0x00000020;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_INFO_PARAMETER SYMF_PARAMETER")]
    public const int IMAGEHLP_SYMBOL_INFO_PARAMETER = 0x00000040;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_INFO_LOCAL SYMF_LOCAL")]
    public const int IMAGEHLP_SYMBOL_INFO_LOCAL = 0x00000080;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_INFO_CONSTANT SYMF_CONSTANT")]
    public const int IMAGEHLP_SYMBOL_INFO_CONSTANT = 0x00000100;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_FUNCTION SYMF_FUNCTION")]
    public const int IMAGEHLP_SYMBOL_FUNCTION = 0x00000800;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_VIRTUAL SYMF_VIRTUAL")]
    public const int IMAGEHLP_SYMBOL_VIRTUAL = 0x00001000;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_THUNK SYMF_THUNK")]
    public const int IMAGEHLP_SYMBOL_THUNK = 0x00002000;

    [NativeTypeName("#define IMAGEHLP_SYMBOL_INFO_TLSRELATIVE SYMF_TLSREL")]
    public const int IMAGEHLP_SYMBOL_INFO_TLSRELATIVE = 0x00004000;

    [NativeTypeName("#define IMAGEHLP_RMAP_MAPPED_FLAT 0x00000001")]
    public const int IMAGEHLP_RMAP_MAPPED_FLAT = 0x00000001;

    [NativeTypeName("#define IMAGEHLP_RMAP_BIG_ENDIAN 0x00000002")]
    public const int IMAGEHLP_RMAP_BIG_ENDIAN = 0x00000002;

    [NativeTypeName("#define IMAGEHLP_RMAP_IGNORE_MISCOMPARE 0x00000004")]
    public const int IMAGEHLP_RMAP_IGNORE_MISCOMPARE = 0x00000004;

    [NativeTypeName("#define IMAGEHLP_RMAP_FIXUP_ARM64X 0x10000000")]
    public const int IMAGEHLP_RMAP_FIXUP_ARM64X = 0x10000000;

    [NativeTypeName("#define IMAGEHLP_RMAP_LOAD_RW_DATA_SECTIONS 0x20000000")]
    public const int IMAGEHLP_RMAP_LOAD_RW_DATA_SECTIONS = 0x20000000;

    [NativeTypeName("#define IMAGEHLP_RMAP_OMIT_SHARED_RW_DATA_SECTIONS 0x40000000")]
    public const int IMAGEHLP_RMAP_OMIT_SHARED_RW_DATA_SECTIONS = 0x40000000;

    [NativeTypeName("#define IMAGEHLP_RMAP_FIXUP_IMAGEBASE 0x80000000")]
    public const uint IMAGEHLP_RMAP_FIXUP_IMAGEBASE = 0x80000000;
}
