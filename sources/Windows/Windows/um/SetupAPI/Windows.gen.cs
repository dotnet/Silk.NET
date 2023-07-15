// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetInfInformationA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetInfInformationA([NativeTypeName("LPCVOID")] void* InfSpec, [NativeTypeName("DWORD")] uint SearchControl, [NativeTypeName("PSP_INF_INFORMATION")] void* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetInfInformationW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetInfInformationW([NativeTypeName("LPCVOID")] void* InfSpec, [NativeTypeName("DWORD")] uint SearchControl, [NativeTypeName("PSP_INF_INFORMATION")] void* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueryInfFileInformationA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueryInfFileInformationA([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueryInfFileInformationW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueryInfFileInformationW([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueryInfOriginalFileInformationA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueryInfOriginalFileInformationA([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PSP_ORIGINAL_FILE_INFO_A")] void* OriginalFileInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueryInfOriginalFileInformationW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueryInfOriginalFileInformationW([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PSP_ORIGINAL_FILE_INFO_W")] void* OriginalFileInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueryInfVersionInformationA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueryInfVersionInformationA([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueryInfVersionInformationW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueryInfVersionInformationW([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetInfDriverStoreLocationA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupGetInfDriverStoreLocationA([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PCSTR")] sbyte* LocaleName, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetInfDriverStoreLocationW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupGetInfDriverStoreLocationW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PCWSTR")] ushort* LocaleName, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetInfPublishedNameA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupGetInfPublishedNameA([NativeTypeName("PCSTR")] sbyte* DriverStoreLocation, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetInfPublishedNameW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupGetInfPublishedNameW([NativeTypeName("PCWSTR")] ushort* DriverStoreLocation, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetInfFileListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetInfFileListA([NativeTypeName("PCSTR")] sbyte* DirectoryPath, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetInfFileListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetInfFileListW([NativeTypeName("PCWSTR")] ushort* DirectoryPath, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupOpenInfFileW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HINF SetupOpenInfFileW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* InfClass, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PUINT")] uint* ErrorLine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupOpenInfFileA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HINF SetupOpenInfFileA([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* InfClass, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PUINT")] uint* ErrorLine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupOpenMasterInf"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HINF SetupOpenMasterInf();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupOpenAppendInfFileW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupOpenAppendInfFileW([NativeTypeName("PCWSTR")] ushort* FileName, HINF InfHandle, [NativeTypeName("PUINT")] uint* ErrorLine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupOpenAppendInfFileA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupOpenAppendInfFileA([NativeTypeName("PCSTR")] sbyte* FileName, HINF InfHandle, [NativeTypeName("PUINT")] uint* ErrorLine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCloseInfFile"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern void SetupCloseInfFile(HINF InfHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupFindFirstLineA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupFindFirstLineA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PINFCONTEXT")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupFindFirstLineW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupFindFirstLineW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PINFCONTEXT")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupFindNextLine"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupFindNextLine([NativeTypeName("PINFCONTEXT")] void* ContextIn, [NativeTypeName("PINFCONTEXT")] void* ContextOut);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupFindNextMatchLineA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupFindNextMatchLineA([NativeTypeName("PINFCONTEXT")] void* ContextIn, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PINFCONTEXT")] void* ContextOut);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupFindNextMatchLineW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupFindNextMatchLineW([NativeTypeName("PINFCONTEXT")] void* ContextIn, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PINFCONTEXT")] void* ContextOut);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetLineByIndexA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetLineByIndexA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PINFCONTEXT")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetLineByIndexW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetLineByIndexW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PINFCONTEXT")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetLineCountA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LONG")]
    public static extern int SetupGetLineCountA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* Section);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetLineCountW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LONG")]
    public static extern int SetupGetLineCountW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* Section);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetLineTextA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetLineTextA([NativeTypeName("PINFCONTEXT")] void* Context, HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetLineTextW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetLineTextW([NativeTypeName("PINFCONTEXT")] void* Context, HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetFieldCount"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetupGetFieldCount([NativeTypeName("PINFCONTEXT")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetStringFieldA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetStringFieldA([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetStringFieldW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetStringFieldW([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetIntField"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetIntField([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PINT")] int* IntegerValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetMultiSzFieldA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetMultiSzFieldA([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetMultiSzFieldW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetMultiSzFieldW([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetBinaryField"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetBinaryField([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PBYTE")] byte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetFileCompressionInfoA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetupGetFileCompressionInfoA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PSTR *")] sbyte** ActualSourceFileName, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetFileCompressionInfoW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetupGetFileCompressionInfoW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PWSTR *")] ushort** ActualSourceFileName, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetFileCompressionInfoExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetFileCompressionInfoExA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PSTR")] sbyte* ActualSourceFileNameBuffer, [NativeTypeName("DWORD")] uint ActualSourceFileNameBufferLen, [NativeTypeName("PDWORD")] uint* RequiredBufferLen, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetFileCompressionInfoExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetFileCompressionInfoExW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PWSTR")] ushort* ActualSourceFileNameBuffer, [NativeTypeName("DWORD")] uint ActualSourceFileNameBufferLen, [NativeTypeName("PDWORD")] uint* RequiredBufferLen, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDecompressOrCopyFileA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetupDecompressOrCopyFileA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PCSTR")] sbyte* TargetFileName, [NativeTypeName("PUINT")] uint* CompressionType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDecompressOrCopyFileW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetupDecompressOrCopyFileW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PCWSTR")] ushort* TargetFileName, [NativeTypeName("PUINT")] uint* CompressionType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetSourceFileLocationA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetSourceFileLocationA(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PUINT")] uint* SourceId, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetSourceFileLocationW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetSourceFileLocationW(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PUINT")] uint* SourceId, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetSourceFileSizeA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetSourceFileSizeA(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PDWORD")] uint* FileSize, uint RoundingFactor);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetSourceFileSizeW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetSourceFileSizeW(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PDWORD")] uint* FileSize, uint RoundingFactor);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetTargetPathA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetTargetPathA(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetTargetPathW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetTargetPathW(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetSourceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR *")] sbyte** SourceList, uint SourceCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetSourceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR *")] ushort** SourceList, uint SourceCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCancelTemporarySourceList"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupCancelTemporarySourceList();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupAddToSourceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupAddToSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* Source);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupAddToSourceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupAddToSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* Source);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRemoveFromSourceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupRemoveFromSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* Source);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRemoveFromSourceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupRemoveFromSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* Source);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQuerySourceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQuerySourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR **")] sbyte*** List, [NativeTypeName("PUINT")] uint* Count);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQuerySourceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQuerySourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR **")] ushort*** List, [NativeTypeName("PUINT")] uint* Count);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupFreeSourceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupFreeSourceListA([NativeTypeName("PCSTR **")] sbyte*** List, uint Count);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupFreeSourceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupFreeSourceListW([NativeTypeName("PCWSTR **")] ushort*** List, uint Count);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupPromptForDiskA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupPromptForDiskA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* DiskName, [NativeTypeName("PCSTR")] sbyte* PathToSource, [NativeTypeName("PCSTR")] sbyte* FileSought, [NativeTypeName("PCSTR")] sbyte* TagFile, [NativeTypeName("DWORD")] uint DiskPromptStyle, [NativeTypeName("PSTR")] sbyte* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupPromptForDiskW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupPromptForDiskW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* DiskName, [NativeTypeName("PCWSTR")] ushort* PathToSource, [NativeTypeName("PCWSTR")] ushort* FileSought, [NativeTypeName("PCWSTR")] ushort* TagFile, [NativeTypeName("DWORD")] uint DiskPromptStyle, [NativeTypeName("PWSTR")] ushort* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCopyErrorA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupCopyErrorA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* DiskName, [NativeTypeName("PCSTR")] sbyte* PathToSource, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetPathFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style, [NativeTypeName("PSTR")] sbyte* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCopyErrorW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupCopyErrorW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* DiskName, [NativeTypeName("PCWSTR")] ushort* PathToSource, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetPathFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style, [NativeTypeName("PWSTR")] ushort* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRenameErrorA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupRenameErrorA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRenameErrorW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupRenameErrorW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDeleteErrorA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupDeleteErrorA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* File, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDeleteErrorW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupDeleteErrorW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* File, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupBackupErrorA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupBackupErrorA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupBackupErrorW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupBackupErrorW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetDirectoryIdA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetDirectoryIdA(HINF InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCSTR")] sbyte* Directory);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetDirectoryIdW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetDirectoryIdW(HINF InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCWSTR")] ushort* Directory);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetDirectoryIdExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetDirectoryIdExA(HINF InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCSTR")] sbyte* Directory, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetDirectoryIdExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetDirectoryIdExW(HINF InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCWSTR")] ushort* Directory, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetSourceInfoA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetSourceInfoA(HINF InfHandle, uint SourceId, uint InfoDesired, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetSourceInfoW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetSourceInfoW(HINF InfHandle, uint SourceId, uint InfoDesired, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallFileA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallFileA(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* SourcePathRoot, [NativeTypeName("PCSTR")] sbyte* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallFileW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallFileW(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* SourcePathRoot, [NativeTypeName("PCWSTR")] ushort* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallFileExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallFileExA(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* SourcePathRoot, [NativeTypeName("PCSTR")] sbyte* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PBOOL")] BOOL* FileWasInUse);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallFileExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallFileExW(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* SourcePathRoot, [NativeTypeName("PCWSTR")] ushort* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PBOOL")] BOOL* FileWasInUse);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupOpenFileQueue"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HSPFILEQ SetupOpenFileQueue();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCloseFileQueue"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupCloseFileQueue(HSPFILEQ QueueHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetFileQueueAlternatePlatformA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetFileQueueAlternatePlatformA(HSPFILEQ QueueHandle, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PCSTR")] sbyte* AlternateDefaultCatalogFile);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetFileQueueAlternatePlatformW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetFileQueueAlternatePlatformW(HSPFILEQ QueueHandle, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PCWSTR")] ushort* AlternateDefaultCatalogFile);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetPlatformPathOverrideA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetPlatformPathOverrideA([NativeTypeName("PCSTR")] sbyte* Override);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetPlatformPathOverrideW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetPlatformPathOverrideW([NativeTypeName("PCWSTR")] ushort* Override);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueCopyA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueCopyA(HSPFILEQ QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("PCSTR")] sbyte* SourcePath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* SourceDescription, [NativeTypeName("PCSTR")] sbyte* SourceTagfile, [NativeTypeName("PCSTR")] sbyte* TargetDirectory, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueCopyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueCopyW(HSPFILEQ QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("PCWSTR")] ushort* SourcePath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* SourceDescription, [NativeTypeName("PCWSTR")] ushort* SourceTagfile, [NativeTypeName("PCWSTR")] ushort* TargetDirectory, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueCopyIndirectA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueCopyIndirectA([NativeTypeName("PSP_FILE_COPY_PARAMS_A")] void* CopyParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueCopyIndirectW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueCopyIndirectW([NativeTypeName("PSP_FILE_COPY_PARAMS_W")] void* CopyParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueDefaultCopyA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueDefaultCopyA(HSPFILEQ QueueHandle, HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueDefaultCopyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueDefaultCopyW(HSPFILEQ QueueHandle, HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueCopySectionA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueCopySectionA(HSPFILEQ QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("DWORD")] uint CopyStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueCopySectionW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueCopySectionW(HSPFILEQ QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("DWORD")] uint CopyStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueDeleteA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueDeleteA(HSPFILEQ QueueHandle, [NativeTypeName("PCSTR")] sbyte* PathPart1, [NativeTypeName("PCSTR")] sbyte* PathPart2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueDeleteW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueDeleteW(HSPFILEQ QueueHandle, [NativeTypeName("PCWSTR")] ushort* PathPart1, [NativeTypeName("PCWSTR")] ushort* PathPart2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueDeleteSectionA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueDeleteSectionA(HSPFILEQ QueueHandle, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueDeleteSectionW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueDeleteSectionW(HSPFILEQ QueueHandle, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueRenameA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueRenameA(HSPFILEQ QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourcePath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetPath, [NativeTypeName("PCSTR")] sbyte* TargetFilename);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueRenameW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueRenameW(HSPFILEQ QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourcePath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetPath, [NativeTypeName("PCWSTR")] ushort* TargetFilename);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueRenameSectionA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueRenameSectionA(HSPFILEQ QueueHandle, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueueRenameSectionW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueueRenameSectionW(HSPFILEQ QueueHandle, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCommitFileQueueA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupCommitFileQueueA(HWND Owner, HSPFILEQ QueueHandle, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCommitFileQueueW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupCommitFileQueueW(HWND Owner, HSPFILEQ QueueHandle, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupScanFileQueueA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupScanFileQueueA(HSPFILEQ FileQueue, [NativeTypeName("DWORD")] uint Flags, HWND Window, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CallbackRoutine, [NativeTypeName("PVOID")] void* CallbackContext, [NativeTypeName("PDWORD")] uint* Result);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupScanFileQueueW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupScanFileQueueW(HSPFILEQ FileQueue, [NativeTypeName("DWORD")] uint Flags, HWND Window, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CallbackRoutine, [NativeTypeName("PVOID")] void* CallbackContext, [NativeTypeName("PDWORD")] uint* Result);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetFileQueueCount"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetFileQueueCount(HSPFILEQ FileQueue, uint SubQueueFileOp, [NativeTypeName("PUINT")] uint* NumOperations);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetFileQueueFlags"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupGetFileQueueFlags(HSPFILEQ FileQueue, [NativeTypeName("PDWORD")] uint* Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetFileQueueFlags"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupSetFileQueueFlags(HSPFILEQ FileQueue, [NativeTypeName("DWORD")] uint FlagMask, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCopyOEMInfA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupCopyOEMInfA([NativeTypeName("PCSTR")] sbyte* SourceInfFileName, [NativeTypeName("PCSTR")] sbyte* OEMSourceMediaLocation, [NativeTypeName("DWORD")] uint OEMSourceMediaType, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSTR")] sbyte* DestinationInfFileName, [NativeTypeName("DWORD")] uint DestinationInfFileNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** DestinationInfFileNameComponent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCopyOEMInfW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupCopyOEMInfW([NativeTypeName("PCWSTR")] ushort* SourceInfFileName, [NativeTypeName("PCWSTR")] ushort* OEMSourceMediaLocation, [NativeTypeName("DWORD")] uint OEMSourceMediaType, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PWSTR")] ushort* DestinationInfFileName, [NativeTypeName("DWORD")] uint DestinationInfFileNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** DestinationInfFileNameComponent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupUninstallOEMInfA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupUninstallOEMInfA([NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupUninstallOEMInfW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupUninstallOEMInfW([NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupUninstallNewlyCopiedInfs"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupUninstallNewlyCopiedInfs(HSPFILEQ FileQueue, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCreateDiskSpaceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDSKSPC SetupCreateDiskSpaceListA([NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCreateDiskSpaceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDSKSPC SetupCreateDiskSpaceListW([NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDuplicateDiskSpaceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDSKSPC SetupDuplicateDiskSpaceListA(HDSKSPC DiskSpace, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDuplicateDiskSpaceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDSKSPC SetupDuplicateDiskSpaceListW(HDSKSPC DiskSpace, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDestroyDiskSpaceList"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDestroyDiskSpaceList(HDSKSPC DiskSpace);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueryDrivesInDiskSpaceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueryDrivesInDiskSpaceListA(HDSKSPC DiskSpace, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueryDrivesInDiskSpaceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueryDrivesInDiskSpaceListW(HDSKSPC DiskSpace, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQuerySpaceRequiredOnDriveA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQuerySpaceRequiredOnDriveA(HDSKSPC DiskSpace, [NativeTypeName("PCSTR")] sbyte* DriveSpec, [NativeTypeName("LONGLONG *")] long* SpaceRequired, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQuerySpaceRequiredOnDriveW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQuerySpaceRequiredOnDriveW(HDSKSPC DiskSpace, [NativeTypeName("PCWSTR")] ushort* DriveSpec, [NativeTypeName("LONGLONG *")] long* SpaceRequired, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupAdjustDiskSpaceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupAdjustDiskSpaceListA(HDSKSPC DiskSpace, [NativeTypeName("LPCSTR")] sbyte* DriveRoot, [NativeTypeName("LONGLONG")] long Amount, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupAdjustDiskSpaceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupAdjustDiskSpaceListW(HDSKSPC DiskSpace, [NativeTypeName("LPCWSTR")] ushort* DriveRoot, [NativeTypeName("LONGLONG")] long Amount, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupAddToDiskSpaceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupAddToDiskSpaceListA(HDSKSPC DiskSpace, [NativeTypeName("PCSTR")] sbyte* TargetFilespec, [NativeTypeName("LONGLONG")] long FileSize, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupAddToDiskSpaceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupAddToDiskSpaceListW(HDSKSPC DiskSpace, [NativeTypeName("PCWSTR")] ushort* TargetFilespec, [NativeTypeName("LONGLONG")] long FileSize, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupAddSectionToDiskSpaceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupAddSectionToDiskSpaceListA(HDSKSPC DiskSpace, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupAddSectionToDiskSpaceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupAddSectionToDiskSpaceListW(HDSKSPC DiskSpace, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupAddInstallSectionToDiskSpaceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupAddInstallSectionToDiskSpaceListA(HDSKSPC DiskSpace, HINF InfHandle, HINF LayoutInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupAddInstallSectionToDiskSpaceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupAddInstallSectionToDiskSpaceListW(HDSKSPC DiskSpace, HINF InfHandle, HINF LayoutInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRemoveFromDiskSpaceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupRemoveFromDiskSpaceListA(HDSKSPC DiskSpace, [NativeTypeName("PCSTR")] sbyte* TargetFilespec, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRemoveFromDiskSpaceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupRemoveFromDiskSpaceListW(HDSKSPC DiskSpace, [NativeTypeName("PCWSTR")] ushort* TargetFilespec, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRemoveSectionFromDiskSpaceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupRemoveSectionFromDiskSpaceListA(HDSKSPC DiskSpace, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRemoveSectionFromDiskSpaceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupRemoveSectionFromDiskSpaceListW(HDSKSPC DiskSpace, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRemoveInstallSectionFromDiskSpaceListA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupRemoveInstallSectionFromDiskSpaceListA(HDSKSPC DiskSpace, HINF InfHandle, HINF LayoutInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRemoveInstallSectionFromDiskSpaceListW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupRemoveInstallSectionFromDiskSpaceListW(HDSKSPC DiskSpace, HINF InfHandle, HINF LayoutInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupIterateCabinetA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupIterateCabinetA([NativeTypeName("PCSTR")] sbyte* CabinetFile, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupIterateCabinetW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupIterateCabinetW([NativeTypeName("PCWSTR")] ushort* CabinetFile, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupPromptReboot"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int SetupPromptReboot(HSPFILEQ FileQueue, HWND Owner, BOOL ScanOnly);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInitDefaultQueueCallback"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PVOID")]
    public static extern void* SetupInitDefaultQueueCallback(HWND OwnerWindow);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInitDefaultQueueCallbackEx"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [return: NativeTypeName("PVOID")]
    public static extern void* SetupInitDefaultQueueCallbackEx(HWND OwnerWindow, HWND AlternateProgressWindow, uint ProgressMessage, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupTermDefaultQueueCallback"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern void SetupTermDefaultQueueCallback([NativeTypeName("PVOID")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDefaultQueueCallbackA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupDefaultQueueCallbackA([NativeTypeName("PVOID")] void* Context, uint Notification, [NativeTypeName("UINT_PTR")] nuint Param1, [NativeTypeName("UINT_PTR")] nuint Param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDefaultQueueCallbackW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint SetupDefaultQueueCallbackW([NativeTypeName("PVOID")] void* Context, uint Notification, [NativeTypeName("UINT_PTR")] nuint Param1, [NativeTypeName("UINT_PTR")] nuint Param2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallFromInfSectionA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallFromInfSectionA(HWND Owner, HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, uint Flags, HKEY RelativeKeyRoot, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, uint CopyFlags, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallFromInfSectionW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallFromInfSectionW(HWND Owner, HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, uint Flags, HKEY RelativeKeyRoot, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, uint CopyFlags, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallFilesFromInfSectionA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallFilesFromInfSectionA(HINF InfHandle, HINF LayoutInfHandle, HSPFILEQ FileQueue, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, uint CopyFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallFilesFromInfSectionW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallFilesFromInfSectionW(HINF InfHandle, HINF LayoutInfHandle, HSPFILEQ FileQueue, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, uint CopyFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallServicesFromInfSectionA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallServicesFromInfSectionA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallServicesFromInfSectionW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallServicesFromInfSectionW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallServicesFromInfSectionExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallServicesFromInfSectionExA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInstallServicesFromInfSectionExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupInstallServicesFromInfSectionExW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InstallHinfSectionA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern void InstallHinfSectionA(HWND Window, HINSTANCE ModuleHandle, [NativeTypeName("PCSTR")] sbyte* CommandLine, int ShowCommand);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InstallHinfSectionW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern void InstallHinfSectionW(HWND Window, HINSTANCE ModuleHandle, [NativeTypeName("PCWSTR")] ushort* CommandLine, int ShowCommand);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInitializeFileLogA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HSPFILELOG SetupInitializeFileLogA([NativeTypeName("PCSTR")] sbyte* LogFileName, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupInitializeFileLogW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HSPFILELOG SetupInitializeFileLogW([NativeTypeName("PCWSTR")] ushort* LogFileName, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupTerminateFileLog"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupTerminateFileLog(HSPFILELOG FileLogHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupLogFileA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupLogFileA(HSPFILELOG FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint Checksum, [NativeTypeName("PCSTR")] sbyte* DiskTagfile, [NativeTypeName("PCSTR")] sbyte* DiskDescription, [NativeTypeName("PCSTR")] sbyte* OtherInfo, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupLogFileW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupLogFileW(HSPFILELOG FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint Checksum, [NativeTypeName("PCWSTR")] ushort* DiskTagfile, [NativeTypeName("PCWSTR")] ushort* DiskDescription, [NativeTypeName("PCWSTR")] ushort* OtherInfo, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRemoveFileLogEntryA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupRemoveFileLogEntryA(HSPFILELOG FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* TargetFilename);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupRemoveFileLogEntryW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupRemoveFileLogEntryW(HSPFILELOG FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* TargetFilename);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueryFileLogA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueryFileLogA(HSPFILELOG FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* TargetFilename, SetupFileLogInfo DesiredInfo, [NativeTypeName("PSTR")] sbyte* DataOut, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupQueryFileLogW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupQueryFileLogW(HSPFILELOG FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* TargetFilename, SetupFileLogInfo DesiredInfo, [NativeTypeName("PWSTR")] ushort* DataOut, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupOpenLog"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupOpenLog(BOOL Erase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupLogErrorA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupLogErrorA([NativeTypeName("LPCSTR")] sbyte* MessageString, [NativeTypeName("DWORD")] uint Severity);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupLogErrorW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupLogErrorW([NativeTypeName("LPCWSTR")] ushort* MessageString, [NativeTypeName("DWORD")] uint Severity);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupCloseLog"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern void SetupCloseLog();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetThreadLogToken"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [return: NativeTypeName("SP_LOG_TOKEN")]
    public static extern ulong SetupGetThreadLogToken();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetThreadLogToken"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern void SetupSetThreadLogToken([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupWriteTextLog"]/*'/>
    [DllImport("setupapi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SetupWriteTextLog([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken, [NativeTypeName("DWORD")] uint Category, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* MessageStr, __arglist);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupWriteTextLogError"]/*'/>
    [DllImport("setupapi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void SetupWriteTextLogError([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken, [NativeTypeName("DWORD")] uint Category, [NativeTypeName("DWORD")] uint LogFlags, [NativeTypeName("DWORD")] uint Error, [NativeTypeName("PCSTR")] sbyte* MessageStr, __arglist);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupWriteTextLogInfLine"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern void SetupWriteTextLogInfLine([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken, [NativeTypeName("DWORD")] uint Flags, HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* Context);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetBackupInformationA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupGetBackupInformationA(HSPFILEQ QueueHandle, [NativeTypeName("PSP_BACKUP_QUEUE_PARAMS_A")] void* BackupParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetBackupInformationW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupGetBackupInformationW(HSPFILEQ QueueHandle, [NativeTypeName("PSP_BACKUP_QUEUE_PARAMS_W")] void* BackupParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupPrepareQueueForRestoreA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupPrepareQueueForRestoreA(HSPFILEQ QueueHandle, [NativeTypeName("PCSTR")] sbyte* BackupPath, [NativeTypeName("DWORD")] uint RestoreFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupPrepareQueueForRestoreW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupPrepareQueueForRestoreW(HSPFILEQ QueueHandle, [NativeTypeName("PCWSTR")] ushort* BackupPath, [NativeTypeName("DWORD")] uint RestoreFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupSetNonInteractiveMode"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupSetNonInteractiveMode(BOOL NonInteractiveFlag);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupGetNonInteractiveMode"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupGetNonInteractiveMode();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDeviceInfoList"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDEVINFO SetupDiCreateDeviceInfoList([NativeTypeName("const GUID *")] Guid* ClassGuid, HWND hwndParent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDeviceInfoListExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HDEVINFO SetupDiCreateDeviceInfoListExA([NativeTypeName("const GUID *")] Guid* ClassGuid, HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDeviceInfoListExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HDEVINFO SetupDiCreateDeviceInfoListExW([NativeTypeName("const GUID *")] Guid* ClassGuid, HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInfoListClass"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetDeviceInfoListClass(HDEVINFO DeviceInfoSet, [NativeTypeName("LPGUID")] Guid* ClassGuid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInfoListDetailA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceInfoListDetailA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_LIST_DETAIL_DATA_A")] void* DeviceInfoSetDetailData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInfoListDetailW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceInfoListDetailW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_LIST_DETAIL_DATA_W")] void* DeviceInfoSetDetailData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDeviceInfoA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiCreateDeviceInfoA(HDEVINFO DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DeviceName, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* DeviceDescription, HWND hwndParent, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDeviceInfoW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiCreateDeviceInfoW(HDEVINFO DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DeviceName, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* DeviceDescription, HWND hwndParent, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiOpenDeviceInfoA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiOpenDeviceInfoA(HDEVINFO DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DeviceInstanceId, HWND hwndParent, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiOpenDeviceInfoW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiOpenDeviceInfoW(HDEVINFO DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DeviceInstanceId, HWND hwndParent, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInstanceIdA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceInstanceIdA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSTR")] sbyte* DeviceInstanceId, [NativeTypeName("DWORD")] uint DeviceInstanceIdSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInstanceIdW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceInstanceIdW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PWSTR")] ushort* DeviceInstanceId, [NativeTypeName("DWORD")] uint DeviceInstanceIdSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiDeleteDeviceInfo"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiDeleteDeviceInfo(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiEnumDeviceInfo"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiEnumDeviceInfo(HDEVINFO DeviceInfoSet, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiDestroyDeviceInfoList"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiDestroyDeviceInfoList(HDEVINFO DeviceInfoSet);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiEnumDeviceInterfaces"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiEnumDeviceInterfaces(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDeviceInterfaceA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiCreateDeviceInterfaceA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PCSTR")] sbyte* ReferenceString, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDeviceInterfaceW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiCreateDeviceInterfaceW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PCWSTR")] ushort* ReferenceString, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiOpenDeviceInterfaceA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiOpenDeviceInterfaceA(HDEVINFO DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DevicePath, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiOpenDeviceInterfaceW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiOpenDeviceInterfaceW(HDEVINFO DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DevicePath, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInterfaceAlias"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetDeviceInterfaceAlias(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("const GUID *")] Guid* AliasInterfaceClassGuid, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* AliasDeviceInterfaceData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiDeleteDeviceInterfaceData"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiDeleteDeviceInterfaceData(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiRemoveDeviceInterface"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiRemoveDeviceInterface(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInterfaceDetailA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceInterfaceDetailA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("PSP_DEVICE_INTERFACE_DETAIL_DATA_A")] void* DeviceInterfaceDetailData, [NativeTypeName("DWORD")] uint DeviceInterfaceDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInterfaceDetailW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceInterfaceDetailW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("PSP_DEVICE_INTERFACE_DETAIL_DATA_W")] void* DeviceInterfaceDetailData, [NativeTypeName("DWORD")] uint DeviceInterfaceDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiInstallDeviceInterfaces"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiInstallDeviceInterfaces(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetDeviceInterfaceDefault"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiSetDeviceInterfaceDefault(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiRegisterDeviceInfo"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiRegisterDeviceInfo(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PSP_DETSIG_CMPPROC")] delegate* unmanaged<HDEVINFO, void*, void*, void*, uint> CompareProc, [NativeTypeName("PVOID")] void* CompareContext, [NativeTypeName("PSP_DEVINFO_DATA")] void* DupDeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiBuildDriverInfoList"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiBuildDriverInfoList(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCancelDriverInfoSearch"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiCancelDriverInfoSearch(HDEVINFO DeviceInfoSet);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiEnumDriverInfoA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiEnumDriverInfoA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiEnumDriverInfoW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiEnumDriverInfoW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetSelectedDriverA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetSelectedDriverA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetSelectedDriverW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetSelectedDriverW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetSelectedDriverA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetSelectedDriverA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetSelectedDriverW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetSelectedDriverW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDriverInfoDetailA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDriverInfoDetailA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData, [NativeTypeName("PSP_DRVINFO_DETAIL_DATA_A")] void* DriverInfoDetailData, [NativeTypeName("DWORD")] uint DriverInfoDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDriverInfoDetailW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDriverInfoDetailW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData, [NativeTypeName("PSP_DRVINFO_DETAIL_DATA_W")] void* DriverInfoDetailData, [NativeTypeName("DWORD")] uint DriverInfoDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiDestroyDriverInfoList"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiDestroyDriverInfoList(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassDevsA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDEVINFO SetupDiGetClassDevsA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* Enumerator, HWND hwndParent, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassDevsW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HDEVINFO SetupDiGetClassDevsW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* Enumerator, HWND hwndParent, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassDevsExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HDEVINFO SetupDiGetClassDevsExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* Enumerator, HWND hwndParent, [NativeTypeName("DWORD")] uint Flags, HDEVINFO DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassDevsExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HDEVINFO SetupDiGetClassDevsExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* Enumerator, HWND hwndParent, [NativeTypeName("DWORD")] uint Flags, HDEVINFO DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetINFClassA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetINFClassA([NativeTypeName("PCSTR")] sbyte* InfName, [NativeTypeName("LPGUID")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetINFClassW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetINFClassW([NativeTypeName("PCWSTR")] ushort* InfName, [NativeTypeName("LPGUID")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiBuildClassInfoList"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiBuildClassInfoList([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiBuildClassInfoListExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiBuildClassInfoListExA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiBuildClassInfoListExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiBuildClassInfoListExW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassDescriptionA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassDescriptionA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassDescriptionW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassDescriptionW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassDescriptionExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassDescriptionExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassDescriptionExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassDescriptionExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCallClassInstaller"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiCallClassInstaller([NativeTypeName("DI_FUNCTION")] uint InstallFunction, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSelectDevice"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiSelectDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSelectBestCompatDrv"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiSelectBestCompatDrv(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiInstallDevice"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiInstallDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiInstallDriverFiles"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiInstallDriverFiles(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiRegisterCoDeviceInstallers"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiRegisterCoDeviceInstallers(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiRemoveDevice"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiRemoveDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiUnremoveDevice"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiUnremoveDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiRestartDevices"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiRestartDevices(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiChangeState"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiChangeState(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiInstallClassA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiInstallClassA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, HSPFILEQ FileQueue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiInstallClassW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiInstallClassW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, HSPFILEQ FileQueue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiInstallClassExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiInstallClassExA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, HSPFILEQ FileQueue, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiInstallClassExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiInstallClassExW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, HSPFILEQ FileQueue, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiOpenClassRegKey"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HKEY SetupDiOpenClassRegKey([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiOpenClassRegKeyExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HKEY SetupDiOpenClassRegKeyExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiOpenClassRegKeyExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HKEY SetupDiOpenClassRegKeyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDeviceInterfaceRegKeyA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HKEY SetupDiCreateDeviceInterfaceRegKeyA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired, HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDeviceInterfaceRegKeyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HKEY SetupDiCreateDeviceInterfaceRegKeyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired, HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiOpenDeviceInterfaceRegKey"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HKEY SetupDiOpenDeviceInterfaceRegKey(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiDeleteDeviceInterfaceRegKey"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiDeleteDeviceInterfaceRegKey(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDevRegKeyA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HKEY SetupDiCreateDevRegKeyA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiCreateDevRegKeyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HKEY SetupDiCreateDevRegKeyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiOpenDevRegKey"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HKEY SetupDiOpenDevRegKey(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, [NativeTypeName("REGSAM")] uint samDesired);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiDeleteDevRegKey"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiDeleteDevRegKey(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetHwProfileList"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetHwProfileList([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetHwProfileListExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetHwProfileListExA([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetHwProfileListExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetHwProfileListExW([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDevicePropertyKeys"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetDevicePropertyKeys(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDevicePropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetDevicePropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetDevicePropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetDevicePropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInterfacePropertyKeys"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetDeviceInterfacePropertyKeys(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInterfacePropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceInterfacePropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetDeviceInterfacePropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetDeviceInterfacePropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassPropertyKeys"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetClassPropertyKeys([NativeTypeName("const GUID *")] Guid* ClassGuid, DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassPropertyKeysExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassPropertyKeysExW([NativeTypeName("const GUID *")] Guid* ClassGuid, DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassPropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassPropertyExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassPropertyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetClassPropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetClassPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetClassPropertyExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetClassPropertyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceRegistryPropertyA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceRegistryPropertyA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceRegistryPropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceRegistryPropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassRegistryPropertyA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassRegistryPropertyA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassRegistryPropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassRegistryPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetDeviceRegistryPropertyA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetDeviceRegistryPropertyA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetDeviceRegistryPropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetDeviceRegistryPropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetClassRegistryPropertyA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetClassRegistryPropertyA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetClassRegistryPropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetClassRegistryPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInstallParamsA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_A")] void* DeviceInstallParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDeviceInstallParamsW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDeviceInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_W")] void* DeviceInstallParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassInstallParamsA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] void* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassInstallParamsW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] void* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetDeviceInstallParamsA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetDeviceInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_A")] void* DeviceInstallParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetDeviceInstallParamsW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetDeviceInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_W")] void* DeviceInstallParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetClassInstallParamsA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetClassInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] void* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetClassInstallParamsW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetClassInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] void* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDriverInstallParamsA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDriverInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] void* DriverInstallParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetDriverInstallParamsW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetDriverInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] void* DriverInstallParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetDriverInstallParamsA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetDriverInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] void* DriverInstallParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetDriverInstallParamsW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiSetDriverInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] void* DriverInstallParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiLoadClassIcon"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiLoadClassIcon([NativeTypeName("const GUID *")] Guid* ClassGuid, HICON* LargeIcon, [NativeTypeName("PINT")] int* MiniIconIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiLoadDeviceIcon"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiLoadDeviceIcon(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, uint cxIcon, uint cyIcon, [NativeTypeName("DWORD")] uint Flags, HICON* hIcon);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiDrawMiniIcon"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern int SetupDiDrawMiniIcon(HDC hdc, RECT rc, int MiniIconIndex, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassBitmapIndex"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetClassBitmapIndex([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PINT")] int* MiniIconIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassImageList"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetClassImageList([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] void* ClassImageListData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassImageListExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassImageListExA([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] void* ClassImageListData, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassImageListExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassImageListExW([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] void* ClassImageListData, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassImageIndex"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetClassImageIndex([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] void* ClassImageListData, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PINT")] int* ImageIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiDestroyClassImageList"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiDestroyClassImageList([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] void* ClassImageListData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassDevPropertySheetsA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassDevPropertySheetsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("LPPROPSHEETHEADERA")] PROPSHEETHEADERA_V2* PropertySheetHeader, [NativeTypeName("DWORD")] uint PropertySheetHeaderPageListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint PropertySheetType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetClassDevPropertySheetsW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetClassDevPropertySheetsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("LPPROPSHEETHEADERW")] PROPSHEETHEADERW_V2* PropertySheetHeader, [NativeTypeName("DWORD")] uint PropertySheetHeaderPageListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint PropertySheetType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiAskForOEMDisk"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiAskForOEMDisk(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSelectOEMDrv"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiSelectOEMDrv(HWND hwndParent, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiClassNameFromGuidA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiClassNameFromGuidA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiClassNameFromGuidW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiClassNameFromGuidW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiClassNameFromGuidExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiClassNameFromGuidExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiClassNameFromGuidExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiClassNameFromGuidExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiClassGuidsFromNameA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiClassGuidsFromNameA([NativeTypeName("PCSTR")] sbyte* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiClassGuidsFromNameW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiClassGuidsFromNameW([NativeTypeName("PCWSTR")] ushort* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiClassGuidsFromNameExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiClassGuidsFromNameExA([NativeTypeName("PCSTR")] sbyte* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiClassGuidsFromNameExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiClassGuidsFromNameExW([NativeTypeName("PCWSTR")] ushort* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetHwProfileFriendlyNameA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetHwProfileFriendlyNameA([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PSTR")] sbyte* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetHwProfileFriendlyNameW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetHwProfileFriendlyNameW([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PWSTR")] ushort* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetHwProfileFriendlyNameExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetHwProfileFriendlyNameExA([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PSTR")] sbyte* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetHwProfileFriendlyNameExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetHwProfileFriendlyNameExW([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PWSTR")] ushort* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetWizardPage"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern HPROPSHEETPAGE SetupDiGetWizardPage(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_INSTALLWIZARD_DATA")] void* InstallWizardData, [NativeTypeName("DWORD")] uint PageType, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetSelectedDevice"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetSelectedDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiSetSelectedDevice"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiSetSelectedDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetActualModelsSectionA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetActualModelsSectionA([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetActualModelsSectionW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetActualModelsSectionW([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetActualSectionToInstallA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetActualSectionToInstallA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** Extension);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetActualSectionToInstallW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetActualSectionToInstallW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** Extension);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetActualSectionToInstallExA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetActualSectionToInstallExA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** Extension, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetActualSectionToInstallExW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupDiGetActualSectionToInstallExW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** Extension, [NativeTypeName("PVOID")] void* Reserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupEnumInfSectionsA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupEnumInfSectionsA(HINF InfHandle, uint Index, [NativeTypeName("PSTR")] sbyte* Buffer, uint Size, uint* SizeNeeded);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupEnumInfSectionsW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupEnumInfSectionsW(HINF InfHandle, uint Index, [NativeTypeName("PWSTR")] ushort* Buffer, uint Size, uint* SizeNeeded);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupVerifyInfFileA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupVerifyInfFileA([NativeTypeName("PCSTR")] sbyte* InfName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AltPlatformInfo, [NativeTypeName("PSP_INF_SIGNER_INFO_A")] void* InfSignerInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupVerifyInfFileW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupVerifyInfFileW([NativeTypeName("PCWSTR")] ushort* InfName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AltPlatformInfo, [NativeTypeName("PSP_INF_SIGNER_INFO_W")] void* InfSignerInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetCustomDevicePropertyA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetCustomDevicePropertyA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PCSTR")] sbyte* CustomPropertyName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupDiGetCustomDevicePropertyW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupDiGetCustomDevicePropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PCWSTR")] ushort* CustomPropertyName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupConfigureWmiFromInfSectionA"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupConfigureWmiFromInfSectionA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetupConfigureWmiFromInfSectionW"]/*'/>
    [DllImport("setupapi", ExactSpelling = true)]
    public static extern BOOL SetupConfigureWmiFromInfSectionW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags);
    [NativeTypeName("#define _SETUPAPI_VER _WIN32_WINNT")]
    public const int _SETUPAPI_VER = 0x0A00;
    [NativeTypeName("#define LINE_LEN 256")]
    public const int LINE_LEN = 256;
    [NativeTypeName("#define INF_STYLE_NONE 0x00000000")]
    public const int INF_STYLE_NONE = 0x00000000;
    [NativeTypeName("#define INF_STYLE_OLDNT 0x00000001")]
    public const int INF_STYLE_OLDNT = 0x00000001;
    [NativeTypeName("#define INF_STYLE_WIN4 0x00000002")]
    public const int INF_STYLE_WIN4 = 0x00000002;
    [NativeTypeName("#define INF_STYLE_CACHE_ENABLE 0x00000010")]
    public const int INF_STYLE_CACHE_ENABLE = 0x00000010;
    [NativeTypeName("#define INF_STYLE_CACHE_DISABLE 0x00000020")]
    public const int INF_STYLE_CACHE_DISABLE = 0x00000020;
    [NativeTypeName("#define INF_STYLE_CACHE_IGNORE 0x00000040")]
    public const int INF_STYLE_CACHE_IGNORE = 0x00000040;
    [NativeTypeName("#define FILEOP_COPY 0")]
    public const int FILEOP_COPY = 0;
    [NativeTypeName("#define FILEOP_RENAME 1")]
    public const int FILEOP_RENAME = 1;
    [NativeTypeName("#define FILEOP_DELETE 2")]
    public const int FILEOP_DELETE = 2;
    [NativeTypeName("#define FILEOP_BACKUP 3")]
    public const int FILEOP_BACKUP = 3;
    [NativeTypeName("#define FILEOP_ABORT 0")]
    public const int FILEOP_ABORT = 0;
    [NativeTypeName("#define FILEOP_DOIT 1")]
    public const int FILEOP_DOIT = 1;
    [NativeTypeName("#define FILEOP_SKIP 2")]
    public const int FILEOP_SKIP = 2;
    [NativeTypeName("#define FILEOP_RETRY FILEOP_DOIT")]
    public const int FILEOP_RETRY = 1;
    [NativeTypeName("#define FILEOP_NEWPATH 4")]
    public const int FILEOP_NEWPATH = 4;
    [NativeTypeName("#define DELFLG_IN_USE 0x00000001")]
    public const int DELFLG_IN_USE = 0x00000001;
    [NativeTypeName("#define DELFLG_IN_USE1 0x00010000")]
    public const int DELFLG_IN_USE1 = 0x00010000;
    [NativeTypeName("#define SPINT_ACTIVE 0x00000001")]
    public const int SPINT_ACTIVE = 0x00000001;
    [NativeTypeName("#define SPINT_DEFAULT 0x00000002")]
    public const int SPINT_DEFAULT = 0x00000002;
    [NativeTypeName("#define SPINT_REMOVED 0x00000004")]
    public const int SPINT_REMOVED = 0x00000004;
    [NativeTypeName("#define SPID_ACTIVE SPINT_ACTIVE")]
    public const int SPID_ACTIVE = 0x00000001;
    [NativeTypeName("#define SPID_DEFAULT SPINT_DEFAULT")]
    public const int SPID_DEFAULT = 0x00000002;
    [NativeTypeName("#define SPID_REMOVED SPINT_REMOVED")]
    public const int SPID_REMOVED = 0x00000004;
    [NativeTypeName("#define ENABLECLASS_QUERY 0")]
    public const int ENABLECLASS_QUERY = 0;
    [NativeTypeName("#define ENABLECLASS_SUCCESS 1")]
    public const int ENABLECLASS_SUCCESS = 1;
    [NativeTypeName("#define ENABLECLASS_FAILURE 2")]
    public const int ENABLECLASS_FAILURE = 2;
    [NativeTypeName("#define DICS_ENABLE 0x00000001")]
    public const int DICS_ENABLE = 0x00000001;
    [NativeTypeName("#define DICS_DISABLE 0x00000002")]
    public const int DICS_DISABLE = 0x00000002;
    [NativeTypeName("#define DICS_PROPCHANGE 0x00000003")]
    public const int DICS_PROPCHANGE = 0x00000003;
    [NativeTypeName("#define DICS_START 0x00000004")]
    public const int DICS_START = 0x00000004;
    [NativeTypeName("#define DICS_STOP 0x00000005")]
    public const int DICS_STOP = 0x00000005;
    [NativeTypeName("#define DICS_FLAG_GLOBAL 0x00000001")]
    public const int DICS_FLAG_GLOBAL = 0x00000001;
    [NativeTypeName("#define DICS_FLAG_CONFIGSPECIFIC 0x00000002")]
    public const int DICS_FLAG_CONFIGSPECIFIC = 0x00000002;
    [NativeTypeName("#define DICS_FLAG_CONFIGGENERAL 0x00000004")]
    public const int DICS_FLAG_CONFIGGENERAL = 0x00000004;
    [NativeTypeName("#define DYNAWIZ_FLAG_PAGESADDED 0x00000001")]
    public const int DYNAWIZ_FLAG_PAGESADDED = 0x00000001;
    [NativeTypeName("#define DYNAWIZ_FLAG_ANALYZE_HANDLECONFLICT 0x00000008")]
    public const int DYNAWIZ_FLAG_ANALYZE_HANDLECONFLICT = 0x00000008;
    [NativeTypeName("#define DYNAWIZ_FLAG_INSTALLDET_NEXT 0x00000002")]
    public const int DYNAWIZ_FLAG_INSTALLDET_NEXT = 0x00000002;
    [NativeTypeName("#define DYNAWIZ_FLAG_INSTALLDET_PREV 0x00000004")]
    public const int DYNAWIZ_FLAG_INSTALLDET_PREV = 0x00000004;
    [NativeTypeName("#define MIN_IDD_DYNAWIZ_RESOURCE_ID 10000")]
    public const int MIN_IDD_DYNAWIZ_RESOURCE_ID = 10000;
    [NativeTypeName("#define DRIVER_HARDWAREID_RANK 0x00000FFF")]
    public const int DRIVER_HARDWAREID_RANK = 0x00000FFF;
    [NativeTypeName("#define DRIVER_HARDWAREID_MASK 0x80000FFF")]
    public const uint DRIVER_HARDWAREID_MASK = 0x80000FFF;
    [NativeTypeName("#define DRIVER_UNTRUSTED_RANK 0x80000000")]
    public const uint DRIVER_UNTRUSTED_RANK = 0x80000000;
    [NativeTypeName("#define DRIVER_W9X_SUSPECT_RANK 0xC0000000")]
    public const uint DRIVER_W9X_SUSPECT_RANK = 0xC0000000;
    [NativeTypeName("#define SPPSR_SELECT_DEVICE_RESOURCES 1")]
    public const int SPPSR_SELECT_DEVICE_RESOURCES = 1;
    [NativeTypeName("#define SPPSR_ENUM_BASIC_DEVICE_PROPERTIES 2")]
    public const int SPPSR_ENUM_BASIC_DEVICE_PROPERTIES = 2;
    [NativeTypeName("#define SPPSR_ENUM_ADV_DEVICE_PROPERTIES 3")]
    public const int SPPSR_ENUM_ADV_DEVICE_PROPERTIES = 3;
    [NativeTypeName("#define INFINFO_INF_SPEC_IS_HINF 1")]
    public const int INFINFO_INF_SPEC_IS_HINF = 1;
    [NativeTypeName("#define INFINFO_INF_NAME_IS_ABSOLUTE 2")]
    public const int INFINFO_INF_NAME_IS_ABSOLUTE = 2;
    [NativeTypeName("#define INFINFO_DEFAULT_SEARCH 3")]
    public const int INFINFO_DEFAULT_SEARCH = 3;
    [NativeTypeName("#define INFINFO_REVERSE_DEFAULT_SEARCH 4")]
    public const int INFINFO_REVERSE_DEFAULT_SEARCH = 4;
    [NativeTypeName("#define INFINFO_INF_PATH_LIST_SEARCH 5")]
    public const int INFINFO_INF_PATH_LIST_SEARCH = 5;
    [NativeTypeName("#define SetupGetInfInformation SetupGetInfInformationW")]
    public static delegate*<void*, uint, void*, uint, uint*, BOOL> SetupGetInfInformation => &SetupGetInfInformationW;

    [NativeTypeName("#define SetupQueryInfFileInformation SetupQueryInfFileInformationW")]
    public static delegate*<void*, uint, ushort*, uint, uint*, BOOL> SetupQueryInfFileInformation => &SetupQueryInfFileInformationW;

    [NativeTypeName("#define SetupQueryInfOriginalFileInformation SetupQueryInfOriginalFileInformationW")]
    public static delegate*<void*, uint, void*, void*, BOOL> SetupQueryInfOriginalFileInformation => &SetupQueryInfOriginalFileInformationW;

    [NativeTypeName("#define SetupQueryInfVersionInformation SetupQueryInfVersionInformationW")]
    public static delegate*<void*, uint, ushort*, ushort*, uint, uint*, BOOL> SetupQueryInfVersionInformation => &SetupQueryInfVersionInformationW;

    [NativeTypeName("#define SetupGetInfDriverStoreLocation SetupGetInfDriverStoreLocationW")]
    public static delegate*<ushort*, void*, ushort*, ushort*, uint, uint*, BOOL> SetupGetInfDriverStoreLocation => &SetupGetInfDriverStoreLocationW;

    [NativeTypeName("#define SetupGetInfPublishedName SetupGetInfPublishedNameW")]
    public static delegate*<ushort*, ushort*, uint, uint*, BOOL> SetupGetInfPublishedName => &SetupGetInfPublishedNameW;

    [NativeTypeName("#define SetupGetInfFileList SetupGetInfFileListW")]
    public static delegate*<ushort*, uint, ushort*, uint, uint*, BOOL> SetupGetInfFileList => &SetupGetInfFileListW;

    [NativeTypeName("#define SetupOpenInfFile SetupOpenInfFileW")]
    public static delegate*<ushort*, ushort*, uint, uint*, HINF> SetupOpenInfFile => &SetupOpenInfFileW;

    [NativeTypeName("#define SetupOpenAppendInfFile SetupOpenAppendInfFileW")]
    public static delegate*<ushort*, HINF, uint*, BOOL> SetupOpenAppendInfFile => &SetupOpenAppendInfFileW;

    [NativeTypeName("#define SetupFindFirstLine SetupFindFirstLineW")]
    public static delegate*<HINF, ushort*, ushort*, void*, BOOL> SetupFindFirstLine => &SetupFindFirstLineW;

    [NativeTypeName("#define SetupFindNextMatchLine SetupFindNextMatchLineW")]
    public static delegate*<void*, ushort*, void*, BOOL> SetupFindNextMatchLine => &SetupFindNextMatchLineW;

    [NativeTypeName("#define SetupGetLineByIndex SetupGetLineByIndexW")]
    public static delegate*<HINF, ushort*, uint, void*, BOOL> SetupGetLineByIndex => &SetupGetLineByIndexW;

    [NativeTypeName("#define SetupGetLineCount SetupGetLineCountW")]
    public static delegate*<HINF, ushort*, int> SetupGetLineCount => &SetupGetLineCountW;

    [NativeTypeName("#define SetupGetLineText SetupGetLineTextW")]
    public static delegate*<void*, HINF, ushort*, ushort*, ushort*, uint, uint*, BOOL> SetupGetLineText => &SetupGetLineTextW;

    [NativeTypeName("#define SetupGetStringField SetupGetStringFieldW")]
    public static delegate*<void*, uint, ushort*, uint, uint*, BOOL> SetupGetStringField => &SetupGetStringFieldW;

    [NativeTypeName("#define SetupGetMultiSzField SetupGetMultiSzFieldW")]
    public static delegate*<void*, uint, ushort*, uint, uint*, BOOL> SetupGetMultiSzField => &SetupGetMultiSzFieldW;

    [NativeTypeName("#define SetupGetFileCompressionInfo SetupGetFileCompressionInfoW")]
    public static delegate*<ushort*, ushort**, uint*, uint*, uint*, uint> SetupGetFileCompressionInfo => &SetupGetFileCompressionInfoW;

    [NativeTypeName("#define SetupGetFileCompressionInfoEx SetupGetFileCompressionInfoExW")]
    public static delegate*<ushort*, ushort*, uint, uint*, uint*, uint*, uint*, BOOL> SetupGetFileCompressionInfoEx => &SetupGetFileCompressionInfoExW;

    [NativeTypeName("#define SetupDecompressOrCopyFile SetupDecompressOrCopyFileW")]
    public static delegate*<ushort*, ushort*, uint*, uint> SetupDecompressOrCopyFile => &SetupDecompressOrCopyFileW;

    [NativeTypeName("#define SetupGetSourceFileLocation SetupGetSourceFileLocationW")]
    public static delegate*<HINF, void*, ushort*, uint*, ushort*, uint, uint*, BOOL> SetupGetSourceFileLocation => &SetupGetSourceFileLocationW;

    [NativeTypeName("#define SetupGetSourceFileSize SetupGetSourceFileSizeW")]
    public static delegate*<HINF, void*, ushort*, ushort*, uint*, uint, BOOL> SetupGetSourceFileSize => &SetupGetSourceFileSizeW;

    [NativeTypeName("#define SetupGetTargetPath SetupGetTargetPathW")]
    public static delegate*<HINF, void*, ushort*, ushort*, uint, uint*, BOOL> SetupGetTargetPath => &SetupGetTargetPathW;

    [NativeTypeName("#define SRCLIST_TEMPORARY 0x00000001")]
    public const int SRCLIST_TEMPORARY = 0x00000001;
    [NativeTypeName("#define SRCLIST_NOBROWSE 0x00000002")]
    public const int SRCLIST_NOBROWSE = 0x00000002;
    [NativeTypeName("#define SRCLIST_SYSTEM 0x00000010")]
    public const int SRCLIST_SYSTEM = 0x00000010;
    [NativeTypeName("#define SRCLIST_USER 0x00000020")]
    public const int SRCLIST_USER = 0x00000020;
    [NativeTypeName("#define SRCLIST_SYSIFADMIN 0x00000040")]
    public const int SRCLIST_SYSIFADMIN = 0x00000040;
    [NativeTypeName("#define SRCLIST_SUBDIRS 0x00000100")]
    public const int SRCLIST_SUBDIRS = 0x00000100;
    [NativeTypeName("#define SRCLIST_APPEND 0x00000200")]
    public const int SRCLIST_APPEND = 0x00000200;
    [NativeTypeName("#define SRCLIST_NOSTRIPPLATFORM 0x00000400")]
    public const int SRCLIST_NOSTRIPPLATFORM = 0x00000400;
    [NativeTypeName("#define SetupSetSourceList SetupSetSourceListW")]
    public static delegate*<uint, ushort**, uint, BOOL> SetupSetSourceList => &SetupSetSourceListW;

    [NativeTypeName("#define SetupAddToSourceList SetupAddToSourceListW")]
    public static delegate*<uint, ushort*, BOOL> SetupAddToSourceList => &SetupAddToSourceListW;

    [NativeTypeName("#define SetupRemoveFromSourceList SetupRemoveFromSourceListW")]
    public static delegate*<uint, ushort*, BOOL> SetupRemoveFromSourceList => &SetupRemoveFromSourceListW;

    [NativeTypeName("#define SetupQuerySourceList SetupQuerySourceListW")]
    public static delegate*<uint, ushort***, uint*, BOOL> SetupQuerySourceList => &SetupQuerySourceListW;

    [NativeTypeName("#define SetupFreeSourceList SetupFreeSourceListW")]
    public static delegate*<ushort***, uint, BOOL> SetupFreeSourceList => &SetupFreeSourceListW;

    [NativeTypeName("#define SetupPromptForDisk SetupPromptForDiskW")]
    public static delegate*<HWND, ushort*, ushort*, ushort*, ushort*, ushort*, uint, ushort*, uint, uint*, uint> SetupPromptForDisk => &SetupPromptForDiskW;

    [NativeTypeName("#define SetupCopyError SetupCopyErrorW")]
    public static delegate*<HWND, ushort*, ushort*, ushort*, ushort*, ushort*, uint, uint, ushort*, uint, uint*, uint> SetupCopyError => &SetupCopyErrorW;

    [NativeTypeName("#define SetupRenameError SetupRenameErrorW")]
    public static delegate*<HWND, ushort*, ushort*, ushort*, uint, uint, uint> SetupRenameError => &SetupRenameErrorW;

    [NativeTypeName("#define SetupDeleteError SetupDeleteErrorW")]
    public static delegate*<HWND, ushort*, ushort*, uint, uint, uint> SetupDeleteError => &SetupDeleteErrorW;

    [NativeTypeName("#define SetupBackupError SetupBackupErrorW")]
    public static delegate*<HWND, ushort*, ushort*, ushort*, uint, uint, uint> SetupBackupError => &SetupBackupErrorW;

    [NativeTypeName("#define DPROMPT_SUCCESS 0")]
    public const int DPROMPT_SUCCESS = 0;
    [NativeTypeName("#define DPROMPT_CANCEL 1")]
    public const int DPROMPT_CANCEL = 1;
    [NativeTypeName("#define DPROMPT_SKIPFILE 2")]
    public const int DPROMPT_SKIPFILE = 2;
    [NativeTypeName("#define DPROMPT_BUFFERTOOSMALL 3")]
    public const int DPROMPT_BUFFERTOOSMALL = 3;
    [NativeTypeName("#define DPROMPT_OUTOFMEMORY 4")]
    public const int DPROMPT_OUTOFMEMORY = 4;
    [NativeTypeName("#define SetupSetDirectoryId SetupSetDirectoryIdW")]
    public static delegate*<HINF, uint, ushort*, BOOL> SetupSetDirectoryId => &SetupSetDirectoryIdW;

    [NativeTypeName("#define SetupSetDirectoryIdEx SetupSetDirectoryIdExW")]
    public static delegate*<HINF, uint, ushort*, uint, uint, void*, BOOL> SetupSetDirectoryIdEx => &SetupSetDirectoryIdExW;

    [NativeTypeName("#define SETDIRID_NOT_FULL_PATH 0x00000001")]
    public const int SETDIRID_NOT_FULL_PATH = 0x00000001;
    [NativeTypeName("#define SetupGetSourceInfo SetupGetSourceInfoW")]
    public static delegate*<HINF, uint, uint, ushort*, uint, uint*, BOOL> SetupGetSourceInfo => &SetupGetSourceInfoW;

    [NativeTypeName("#define SRCINFO_PATH 1")]
    public const int SRCINFO_PATH = 1;
    [NativeTypeName("#define SRCINFO_TAGFILE 2")]
    public const int SRCINFO_TAGFILE = 2;
    [NativeTypeName("#define SRCINFO_DESCRIPTION 3")]
    public const int SRCINFO_DESCRIPTION = 3;
    [NativeTypeName("#define SRCINFO_FLAGS 4")]
    public const int SRCINFO_FLAGS = 4;
    [NativeTypeName("#define SRCINFO_TAGFILE2 5")]
    public const int SRCINFO_TAGFILE2 = 5;
    [NativeTypeName("#define SRC_FLAGS_CABFILE (0x0010)")]
    public const int SRC_FLAGS_CABFILE = (0x0010);
    [NativeTypeName("#define SetupInstallFile SetupInstallFileW")]
    public static delegate*<HINF, void*, ushort*, ushort*, ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint> , void*, BOOL> SetupInstallFile => &SetupInstallFileW;

    [NativeTypeName("#define SetupInstallFileEx SetupInstallFileExW")]
    public static delegate*<HINF, void*, ushort*, ushort*, ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint> , void*, BOOL*, BOOL> SetupInstallFileEx => &SetupInstallFileExW;

    [NativeTypeName("#define SetupSetFileQueueAlternatePlatform SetupSetFileQueueAlternatePlatformW")]
    public static delegate*<HSPFILEQ, void*, ushort*, BOOL> SetupSetFileQueueAlternatePlatform => &SetupSetFileQueueAlternatePlatformW;

    [NativeTypeName("#define SetupSetPlatformPathOverride SetupSetPlatformPathOverrideW")]
    public static delegate*<ushort*, BOOL> SetupSetPlatformPathOverride => &SetupSetPlatformPathOverrideW;

    [NativeTypeName("#define SetupQueueCopy SetupQueueCopyW")]
    public static delegate*<HSPFILEQ, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, uint, BOOL> SetupQueueCopy => &SetupQueueCopyW;

    [NativeTypeName("#define SetupQueueCopyIndirect SetupQueueCopyIndirectW")]
    public static delegate*<void*, BOOL> SetupQueueCopyIndirect => &SetupQueueCopyIndirectW;

    [NativeTypeName("#define SetupQueueDefaultCopy SetupQueueDefaultCopyW")]
    public static delegate*<HSPFILEQ, HINF, ushort*, ushort*, ushort*, uint, BOOL> SetupQueueDefaultCopy => &SetupQueueDefaultCopyW;

    [NativeTypeName("#define SetupQueueCopySection SetupQueueCopySectionW")]
    public static delegate*<HSPFILEQ, ushort*, HINF, HINF, ushort*, uint, BOOL> SetupQueueCopySection => &SetupQueueCopySectionW;

    [NativeTypeName("#define SetupQueueDelete SetupQueueDeleteW")]
    public static delegate*<HSPFILEQ, ushort*, ushort*, BOOL> SetupQueueDelete => &SetupQueueDeleteW;

    [NativeTypeName("#define SetupQueueDeleteSection SetupQueueDeleteSectionW")]
    public static delegate*<HSPFILEQ, HINF, HINF, ushort*, BOOL> SetupQueueDeleteSection => &SetupQueueDeleteSectionW;

    [NativeTypeName("#define SetupQueueRename SetupQueueRenameW")]
    public static delegate*<HSPFILEQ, ushort*, ushort*, ushort*, ushort*, BOOL> SetupQueueRename => &SetupQueueRenameW;

    [NativeTypeName("#define SetupQueueRenameSection SetupQueueRenameSectionW")]
    public static delegate*<HSPFILEQ, HINF, HINF, ushort*, BOOL> SetupQueueRenameSection => &SetupQueueRenameSectionW;

    [NativeTypeName("#define SetupCommitFileQueue SetupCommitFileQueueW")]
    public static delegate*<HWND, HSPFILEQ, delegate* unmanaged<void*, uint, nuint, nuint, uint> , void*, BOOL> SetupCommitFileQueue => &SetupCommitFileQueueW;

    [NativeTypeName("#define SetupScanFileQueue SetupScanFileQueueW")]
    public static delegate*<HSPFILEQ, uint, HWND, delegate* unmanaged<void*, uint, nuint, nuint, uint> , void*, uint*, BOOL> SetupScanFileQueue => &SetupScanFileQueueW;

    [NativeTypeName("#define SPOST_NONE 0")]
    public const int SPOST_NONE = 0;
    [NativeTypeName("#define SPOST_PATH 1")]
    public const int SPOST_PATH = 1;
    [NativeTypeName("#define SPOST_URL 2")]
    public const int SPOST_URL = 2;
    [NativeTypeName("#define SPOST_MAX 3")]
    public const int SPOST_MAX = 3;
    [NativeTypeName("#define SetupCopyOEMInf SetupCopyOEMInfW")]
    public static delegate*<ushort*, ushort*, uint, uint, ushort*, uint, uint*, ushort**, BOOL> SetupCopyOEMInf => &SetupCopyOEMInfW;

    [NativeTypeName("#define SUOI_FORCEDELETE 0x00000001")]
    public const int SUOI_FORCEDELETE = 0x00000001;
    [NativeTypeName("#define SUOI_INTERNAL1 0x00000002")]
    public const int SUOI_INTERNAL1 = 0x00000002;
    [NativeTypeName("#define SetupUninstallOEMInf SetupUninstallOEMInfW")]
    public static delegate*<ushort*, uint, void*, BOOL> SetupUninstallOEMInf => &SetupUninstallOEMInfW;

    [NativeTypeName("#define SetupCreateDiskSpaceList SetupCreateDiskSpaceListW")]
    public static delegate*<void*, uint, uint, HDSKSPC> SetupCreateDiskSpaceList => &SetupCreateDiskSpaceListW;

    [NativeTypeName("#define SPDSL_IGNORE_DISK 0x00000001")]
    public const int SPDSL_IGNORE_DISK = 0x00000001;
    [NativeTypeName("#define SPDSL_DISALLOW_NEGATIVE_ADJUST 0x00000002")]
    public const int SPDSL_DISALLOW_NEGATIVE_ADJUST = 0x00000002;
    [NativeTypeName("#define SetupDuplicateDiskSpaceList SetupDuplicateDiskSpaceListW")]
    public static delegate*<HDSKSPC, void*, uint, uint, HDSKSPC> SetupDuplicateDiskSpaceList => &SetupDuplicateDiskSpaceListW;

    [NativeTypeName("#define SetupQueryDrivesInDiskSpaceList SetupQueryDrivesInDiskSpaceListW")]
    public static delegate*<HDSKSPC, ushort*, uint, uint*, BOOL> SetupQueryDrivesInDiskSpaceList => &SetupQueryDrivesInDiskSpaceListW;

    [NativeTypeName("#define SetupQuerySpaceRequiredOnDrive SetupQuerySpaceRequiredOnDriveW")]
    public static delegate*<HDSKSPC, ushort*, long*, void*, uint, BOOL> SetupQuerySpaceRequiredOnDrive => &SetupQuerySpaceRequiredOnDriveW;

    [NativeTypeName("#define SetupAdjustDiskSpaceList SetupAdjustDiskSpaceListW")]
    public static delegate*<HDSKSPC, ushort*, long, void*, uint, BOOL> SetupAdjustDiskSpaceList => &SetupAdjustDiskSpaceListW;

    [NativeTypeName("#define SetupAddToDiskSpaceList SetupAddToDiskSpaceListW")]
    public static delegate*<HDSKSPC, ushort*, long, uint, void*, uint, BOOL> SetupAddToDiskSpaceList => &SetupAddToDiskSpaceListW;

    [NativeTypeName("#define SetupAddSectionToDiskSpaceList SetupAddSectionToDiskSpaceListW")]
    public static delegate*<HDSKSPC, HINF, HINF, ushort*, uint, void*, uint, BOOL> SetupAddSectionToDiskSpaceList => &SetupAddSectionToDiskSpaceListW;

    [NativeTypeName("#define SetupAddInstallSectionToDiskSpaceList SetupAddInstallSectionToDiskSpaceListW")]
    public static delegate*<HDSKSPC, HINF, HINF, ushort*, void*, uint, BOOL> SetupAddInstallSectionToDiskSpaceList => &SetupAddInstallSectionToDiskSpaceListW;

    [NativeTypeName("#define SetupRemoveFromDiskSpaceList SetupRemoveFromDiskSpaceListW")]
    public static delegate*<HDSKSPC, ushort*, uint, void*, uint, BOOL> SetupRemoveFromDiskSpaceList => &SetupRemoveFromDiskSpaceListW;

    [NativeTypeName("#define SetupRemoveSectionFromDiskSpaceList SetupRemoveSectionFromDiskSpaceListW")]
    public static delegate*<HDSKSPC, HINF, HINF, ushort*, uint, void*, uint, BOOL> SetupRemoveSectionFromDiskSpaceList => &SetupRemoveSectionFromDiskSpaceListW;

    [NativeTypeName("#define SetupRemoveInstallSectionFromDiskSpaceList SetupRemoveInstallSectionFromDiskSpaceListW")]
    public static delegate*<HDSKSPC, HINF, HINF, ushort*, void*, uint, BOOL> SetupRemoveInstallSectionFromDiskSpaceList => &SetupRemoveInstallSectionFromDiskSpaceListW;

    [NativeTypeName("#define SetupIterateCabinet SetupIterateCabinetW")]
    public static delegate*<ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint> , void*, BOOL> SetupIterateCabinet => &SetupIterateCabinetW;

    [NativeTypeName("#define SPFILEQ_FILE_IN_USE 0x00000001")]
    public const int SPFILEQ_FILE_IN_USE = 0x00000001;
    [NativeTypeName("#define SPFILEQ_REBOOT_RECOMMENDED 0x00000002")]
    public const int SPFILEQ_REBOOT_RECOMMENDED = 0x00000002;
    [NativeTypeName("#define SPFILEQ_REBOOT_IN_PROGRESS 0x00000004")]
    public const int SPFILEQ_REBOOT_IN_PROGRESS = 0x00000004;
    [NativeTypeName("#define SetupDefaultQueueCallback SetupDefaultQueueCallbackW")]
    public static delegate*<void*, uint, nuint, nuint, uint> SetupDefaultQueueCallback => &SetupDefaultQueueCallbackW;

    [NativeTypeName("#define SetupInstallFromInfSection SetupInstallFromInfSectionW")]
    public static delegate*<HWND, HINF, ushort*, uint, HKEY, ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint> , void*, HDEVINFO, void*, BOOL> SetupInstallFromInfSection => &SetupInstallFromInfSectionW;

    [NativeTypeName("#define SetupInstallFilesFromInfSection SetupInstallFilesFromInfSectionW")]
    public static delegate*<HINF, HINF, HSPFILEQ, ushort*, ushort*, uint, BOOL> SetupInstallFilesFromInfSection => &SetupInstallFilesFromInfSectionW;

    [NativeTypeName("#define SetupInstallServicesFromInfSection SetupInstallServicesFromInfSectionW")]
    public static delegate*<HINF, ushort*, uint, BOOL> SetupInstallServicesFromInfSection => &SetupInstallServicesFromInfSectionW;

    [NativeTypeName("#define SetupInstallServicesFromInfSectionEx SetupInstallServicesFromInfSectionExW")]
    public static delegate*<HINF, ushort*, uint, HDEVINFO, void*, void*, void*, BOOL> SetupInstallServicesFromInfSectionEx => &SetupInstallServicesFromInfSectionExW;

    [NativeTypeName("#define InstallHinfSection InstallHinfSectionW")]
    public static delegate*<HWND, HINSTANCE, ushort*, int, void> InstallHinfSection => &InstallHinfSectionW;

    [NativeTypeName("#define SetupInitializeFileLog SetupInitializeFileLogW")]
    public static delegate*<ushort*, uint, HSPFILELOG> SetupInitializeFileLog => &SetupInitializeFileLogW;

    [NativeTypeName("#define SPFILELOG_SYSTEMLOG 0x00000001")]
    public const int SPFILELOG_SYSTEMLOG = 0x00000001;
    [NativeTypeName("#define SPFILELOG_FORCENEW 0x00000002")]
    public const int SPFILELOG_FORCENEW = 0x00000002;
    [NativeTypeName("#define SPFILELOG_QUERYONLY 0x00000004")]
    public const int SPFILELOG_QUERYONLY = 0x00000004;
    [NativeTypeName("#define SetupLogFile SetupLogFileW")]
    public static delegate*<HSPFILELOG, ushort*, ushort*, ushort*, uint, ushort*, ushort*, ushort*, uint, BOOL> SetupLogFile => &SetupLogFileW;

    [NativeTypeName("#define SPFILELOG_OEMFILE 0x00000001")]
    public const int SPFILELOG_OEMFILE = 0x00000001;
    [NativeTypeName("#define SetupRemoveFileLogEntry SetupRemoveFileLogEntryW")]
    public static delegate*<HSPFILELOG, ushort*, ushort*, BOOL> SetupRemoveFileLogEntry => &SetupRemoveFileLogEntryW;

    [NativeTypeName("#define SetupQueryFileLog SetupQueryFileLogW")]
    public static delegate*<HSPFILELOG, ushort*, ushort*, SetupFileLogInfo, ushort*, uint, uint*, BOOL> SetupQueryFileLog => &SetupQueryFileLogW;

    [NativeTypeName("#define LogSevInformation 0x00000000")]
    public const int LogSevInformation = 0x00000000;
    [NativeTypeName("#define LogSevWarning 0x00000001")]
    public const int LogSevWarning = 0x00000001;
    [NativeTypeName("#define LogSevError 0x00000002")]
    public const int LogSevError = 0x00000002;
    [NativeTypeName("#define LogSevFatalError 0x00000003")]
    public const int LogSevFatalError = 0x00000003;
    [NativeTypeName("#define LogSevMaximum 0x00000004")]
    public const int LogSevMaximum = 0x00000004;
    [NativeTypeName("#define SetupLogError SetupLogErrorW")]
    public static delegate*<ushort*, uint, BOOL> SetupLogError => &SetupLogErrorW;

    [NativeTypeName("#define SetupGetBackupInformation SetupGetBackupInformationW")]
    public static delegate*<HSPFILEQ, void*, BOOL> SetupGetBackupInformation => &SetupGetBackupInformationW;

    [NativeTypeName("#define SetupPrepareQueueForRestore SetupPrepareQueueForRestoreW")]
    public static delegate*<HSPFILEQ, ushort*, uint, BOOL> SetupPrepareQueueForRestore => &SetupPrepareQueueForRestoreW;

    [NativeTypeName("#define SetupDiCreateDeviceInfoListEx SetupDiCreateDeviceInfoListExW")]
    public static delegate*<Guid*, HWND, ushort*, void*, HDEVINFO> SetupDiCreateDeviceInfoListEx => &SetupDiCreateDeviceInfoListExW;

    [NativeTypeName("#define SetupDiGetDeviceInfoListDetail SetupDiGetDeviceInfoListDetailW")]
    public static delegate*<HDEVINFO, void*, BOOL> SetupDiGetDeviceInfoListDetail => &SetupDiGetDeviceInfoListDetailW;

    [NativeTypeName("#define SetupDiCreateDeviceInfo SetupDiCreateDeviceInfoW")]
    public static delegate*<HDEVINFO, ushort*, Guid*, ushort*, HWND, uint, void*, BOOL> SetupDiCreateDeviceInfo => &SetupDiCreateDeviceInfoW;

    [NativeTypeName("#define DIOD_INHERIT_CLASSDRVS 0x00000002")]
    public const int DIOD_INHERIT_CLASSDRVS = 0x00000002;
    [NativeTypeName("#define DIOD_CANCEL_REMOVE 0x00000004")]
    public const int DIOD_CANCEL_REMOVE = 0x00000004;
    [NativeTypeName("#define SetupDiOpenDeviceInfo SetupDiOpenDeviceInfoW")]
    public static delegate*<HDEVINFO, ushort*, HWND, uint, void*, BOOL> SetupDiOpenDeviceInfo => &SetupDiOpenDeviceInfoW;

    [NativeTypeName("#define SetupDiGetDeviceInstanceId SetupDiGetDeviceInstanceIdW")]
    public static delegate*<HDEVINFO, void*, ushort*, uint, uint*, BOOL> SetupDiGetDeviceInstanceId => &SetupDiGetDeviceInstanceIdW;

    [NativeTypeName("#define SetupDiEnumInterfaceDevice SetupDiEnumDeviceInterfaces")]
    public static delegate*<HDEVINFO, void*, Guid*, uint, void*, BOOL> SetupDiEnumInterfaceDevice => &SetupDiEnumDeviceInterfaces;

    [NativeTypeName("#define SetupDiCreateDeviceInterface SetupDiCreateDeviceInterfaceW")]
    public static delegate*<HDEVINFO, void*, Guid*, ushort*, uint, void*, BOOL> SetupDiCreateDeviceInterface => &SetupDiCreateDeviceInterfaceW;

    [NativeTypeName("#define SetupDiCreateInterfaceDeviceW SetupDiCreateDeviceInterfaceW")]
    public static delegate*<HDEVINFO, void*, Guid*, ushort*, uint, void*, BOOL> SetupDiCreateInterfaceDeviceW => &SetupDiCreateDeviceInterfaceW;

    [NativeTypeName("#define SetupDiCreateInterfaceDeviceA SetupDiCreateDeviceInterfaceA")]
    public static delegate*<HDEVINFO, void*, Guid*, sbyte*, uint, void*, BOOL> SetupDiCreateInterfaceDeviceA => &SetupDiCreateDeviceInterfaceA;

    [NativeTypeName("#define SetupDiCreateInterfaceDevice SetupDiCreateDeviceInterfaceW")]
    public static delegate*<HDEVINFO, void*, Guid*, ushort*, uint, void*, BOOL> SetupDiCreateInterfaceDevice => &SetupDiCreateDeviceInterfaceW;

    [NativeTypeName("#define DIODI_NO_ADD 0x00000001")]
    public const int DIODI_NO_ADD = 0x00000001;
    [NativeTypeName("#define SetupDiOpenDeviceInterface SetupDiOpenDeviceInterfaceW")]
    public static delegate*<HDEVINFO, ushort*, uint, void*, BOOL> SetupDiOpenDeviceInterface => &SetupDiOpenDeviceInterfaceW;

    [NativeTypeName("#define SetupDiOpenInterfaceDeviceW SetupDiOpenDeviceInterfaceW")]
    public static delegate*<HDEVINFO, ushort*, uint, void*, BOOL> SetupDiOpenInterfaceDeviceW => &SetupDiOpenDeviceInterfaceW;

    [NativeTypeName("#define SetupDiOpenInterfaceDeviceA SetupDiOpenDeviceInterfaceA")]
    public static delegate*<HDEVINFO, sbyte*, uint, void*, BOOL> SetupDiOpenInterfaceDeviceA => &SetupDiOpenDeviceInterfaceA;

    [NativeTypeName("#define SetupDiOpenInterfaceDevice SetupDiOpenDeviceInterfaceW")]
    public static delegate*<HDEVINFO, ushort*, uint, void*, BOOL> SetupDiOpenInterfaceDevice => &SetupDiOpenDeviceInterfaceW;

    [NativeTypeName("#define SetupDiGetInterfaceDeviceAlias SetupDiGetDeviceInterfaceAlias")]
    public static delegate*<HDEVINFO, void*, Guid*, void*, BOOL> SetupDiGetInterfaceDeviceAlias => &SetupDiGetDeviceInterfaceAlias;

    [NativeTypeName("#define SetupDiDeleteInterfaceDeviceData SetupDiDeleteDeviceInterfaceData")]
    public static delegate*<HDEVINFO, void*, BOOL> SetupDiDeleteInterfaceDeviceData => &SetupDiDeleteDeviceInterfaceData;

    [NativeTypeName("#define SetupDiRemoveInterfaceDevice SetupDiRemoveDeviceInterface")]
    public static delegate*<HDEVINFO, void*, BOOL> SetupDiRemoveInterfaceDevice => &SetupDiRemoveDeviceInterface;

    [NativeTypeName("#define SetupDiGetDeviceInterfaceDetail SetupDiGetDeviceInterfaceDetailW")]
    public static delegate*<HDEVINFO, void*, void*, uint, uint*, void*, BOOL> SetupDiGetDeviceInterfaceDetail => &SetupDiGetDeviceInterfaceDetailW;

    [NativeTypeName("#define SetupDiGetInterfaceDeviceDetailW SetupDiGetDeviceInterfaceDetailW")]
    public static delegate*<HDEVINFO, void*, void*, uint, uint*, void*, BOOL> SetupDiGetInterfaceDeviceDetailW => &SetupDiGetDeviceInterfaceDetailW;

    [NativeTypeName("#define SetupDiGetInterfaceDeviceDetailA SetupDiGetDeviceInterfaceDetailA")]
    public static delegate*<HDEVINFO, void*, void*, uint, uint*, void*, BOOL> SetupDiGetInterfaceDeviceDetailA => &SetupDiGetDeviceInterfaceDetailA;

    [NativeTypeName("#define SetupDiGetInterfaceDeviceDetail SetupDiGetDeviceInterfaceDetailW")]
    public static delegate*<HDEVINFO, void*, void*, uint, uint*, void*, BOOL> SetupDiGetInterfaceDeviceDetail => &SetupDiGetDeviceInterfaceDetailW;

    [NativeTypeName("#define SetupDiInstallInterfaceDevices SetupDiInstallDeviceInterfaces")]
    public static delegate*<HDEVINFO, void*, BOOL> SetupDiInstallInterfaceDevices => &SetupDiInstallDeviceInterfaces;

    [NativeTypeName("#define SPRDI_FIND_DUPS 0x00000001")]
    public const int SPRDI_FIND_DUPS = 0x00000001;
    [NativeTypeName("#define SPDIT_NODRIVER 0x00000000")]
    public const int SPDIT_NODRIVER = 0x00000000;
    [NativeTypeName("#define SPDIT_CLASSDRIVER 0x00000001")]
    public const int SPDIT_CLASSDRIVER = 0x00000001;
    [NativeTypeName("#define SPDIT_COMPATDRIVER 0x00000002")]
    public const int SPDIT_COMPATDRIVER = 0x00000002;
    [NativeTypeName("#define SetupDiEnumDriverInfo SetupDiEnumDriverInfoW")]
    public static delegate*<HDEVINFO, void*, uint, uint, void*, BOOL> SetupDiEnumDriverInfo => &SetupDiEnumDriverInfoW;

    [NativeTypeName("#define SetupDiGetSelectedDriver SetupDiGetSelectedDriverW")]
    public static delegate*<HDEVINFO, void*, void*, BOOL> SetupDiGetSelectedDriver => &SetupDiGetSelectedDriverW;

    [NativeTypeName("#define SetupDiSetSelectedDriver SetupDiSetSelectedDriverW")]
    public static delegate*<HDEVINFO, void*, void*, BOOL> SetupDiSetSelectedDriver => &SetupDiSetSelectedDriverW;

    [NativeTypeName("#define SetupDiGetDriverInfoDetail SetupDiGetDriverInfoDetailW")]
    public static delegate*<HDEVINFO, void*, void*, void*, uint, uint*, BOOL> SetupDiGetDriverInfoDetail => &SetupDiGetDriverInfoDetailW;

    [NativeTypeName("#define SetupDiGetClassDevs SetupDiGetClassDevsW")]
    public static delegate*<Guid*, ushort*, HWND, uint, HDEVINFO> SetupDiGetClassDevs => &SetupDiGetClassDevsW;

    [NativeTypeName("#define SetupDiGetClassDevsEx SetupDiGetClassDevsExW")]
    public static delegate*<Guid*, ushort*, HWND, uint, HDEVINFO, ushort*, void*, HDEVINFO> SetupDiGetClassDevsEx => &SetupDiGetClassDevsExW;

    [NativeTypeName("#define SetupDiGetINFClass SetupDiGetINFClassW")]
    public static delegate*<ushort*, Guid*, ushort*, uint, uint*, BOOL> SetupDiGetINFClass => &SetupDiGetINFClassW;

    [NativeTypeName("#define DIBCI_NOINSTALLCLASS 0x00000001")]
    public const int DIBCI_NOINSTALLCLASS = 0x00000001;
    [NativeTypeName("#define DIBCI_NODISPLAYCLASS 0x00000002")]
    public const int DIBCI_NODISPLAYCLASS = 0x00000002;
    [NativeTypeName("#define SetupDiBuildClassInfoListEx SetupDiBuildClassInfoListExW")]
    public static delegate*<uint, Guid*, uint, uint*, ushort*, void*, BOOL> SetupDiBuildClassInfoListEx => &SetupDiBuildClassInfoListExW;

    [NativeTypeName("#define SetupDiGetClassDescription SetupDiGetClassDescriptionW")]
    public static delegate*<Guid*, ushort*, uint, uint*, BOOL> SetupDiGetClassDescription => &SetupDiGetClassDescriptionW;

    [NativeTypeName("#define SetupDiGetClassDescriptionEx SetupDiGetClassDescriptionExW")]
    public static delegate*<Guid*, ushort*, uint, uint*, ushort*, void*, BOOL> SetupDiGetClassDescriptionEx => &SetupDiGetClassDescriptionExW;

    [NativeTypeName("#define SetupDiInstallClass SetupDiInstallClassW")]
    public static delegate*<HWND, ushort*, uint, HSPFILEQ, BOOL> SetupDiInstallClass => &SetupDiInstallClassW;

    [NativeTypeName("#define SetupDiInstallClassEx SetupDiInstallClassExW")]
    public static delegate*<HWND, ushort*, uint, HSPFILEQ, Guid*, void*, void*, BOOL> SetupDiInstallClassEx => &SetupDiInstallClassExW;

    [NativeTypeName("#define DIOCR_INSTALLER 0x00000001")]
    public const int DIOCR_INSTALLER = 0x00000001;
    [NativeTypeName("#define DIOCR_INTERFACE 0x00000002")]
    public const int DIOCR_INTERFACE = 0x00000002;
    [NativeTypeName("#define SetupDiOpenClassRegKeyEx SetupDiOpenClassRegKeyExW")]
    public static delegate*<Guid*, uint, uint, ushort*, void*, HKEY> SetupDiOpenClassRegKeyEx => &SetupDiOpenClassRegKeyExW;

    [NativeTypeName("#define SetupDiCreateDeviceInterfaceRegKey SetupDiCreateDeviceInterfaceRegKeyW")]
    public static delegate*<HDEVINFO, void*, uint, uint, HINF, ushort*, HKEY> SetupDiCreateDeviceInterfaceRegKey => &SetupDiCreateDeviceInterfaceRegKeyW;

    [NativeTypeName("#define SetupDiCreateInterfaceDeviceRegKeyW SetupDiCreateDeviceInterfaceRegKeyW")]
    public static delegate*<HDEVINFO, void*, uint, uint, HINF, ushort*, HKEY> SetupDiCreateInterfaceDeviceRegKeyW => &SetupDiCreateDeviceInterfaceRegKeyW;

    [NativeTypeName("#define SetupDiCreateInterfaceDeviceRegKeyA SetupDiCreateDeviceInterfaceRegKeyA")]
    public static delegate*<HDEVINFO, void*, uint, uint, HINF, sbyte*, HKEY> SetupDiCreateInterfaceDeviceRegKeyA => &SetupDiCreateDeviceInterfaceRegKeyA;

    [NativeTypeName("#define SetupDiCreateInterfaceDeviceRegKey SetupDiCreateDeviceInterfaceRegKeyW")]
    public static delegate*<HDEVINFO, void*, uint, uint, HINF, ushort*, HKEY> SetupDiCreateInterfaceDeviceRegKey => &SetupDiCreateDeviceInterfaceRegKeyW;

    [NativeTypeName("#define SetupDiOpenInterfaceDeviceRegKey SetupDiOpenDeviceInterfaceRegKey")]
    public static delegate*<HDEVINFO, void*, uint, uint, HKEY> SetupDiOpenInterfaceDeviceRegKey => &SetupDiOpenDeviceInterfaceRegKey;

    [NativeTypeName("#define SetupDiDeleteInterfaceDeviceRegKey SetupDiDeleteDeviceInterfaceRegKey")]
    public static delegate*<HDEVINFO, void*, uint, BOOL> SetupDiDeleteInterfaceDeviceRegKey => &SetupDiDeleteDeviceInterfaceRegKey;

    [NativeTypeName("#define DIREG_DEV 0x00000001")]
    public const int DIREG_DEV = 0x00000001;
    [NativeTypeName("#define DIREG_DRV 0x00000002")]
    public const int DIREG_DRV = 0x00000002;
    [NativeTypeName("#define DIREG_BOTH 0x00000004")]
    public const int DIREG_BOTH = 0x00000004;
    [NativeTypeName("#define SetupDiCreateDevRegKey SetupDiCreateDevRegKeyW")]
    public static delegate*<HDEVINFO, void*, uint, uint, uint, HINF, ushort*, HKEY> SetupDiCreateDevRegKey => &SetupDiCreateDevRegKeyW;

    [NativeTypeName("#define SetupDiGetHwProfileListEx SetupDiGetHwProfileListExW")]
    public static delegate*<uint*, uint, uint*, uint*, ushort*, void*, BOOL> SetupDiGetHwProfileListEx => &SetupDiGetHwProfileListExW;

    [NativeTypeName("#define SetupDiGetDeviceProperty SetupDiGetDevicePropertyW")]
    public static delegate*<HDEVINFO, void*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, BOOL> SetupDiGetDeviceProperty => &SetupDiGetDevicePropertyW;

    [NativeTypeName("#define SetupDiSetDeviceProperty SetupDiSetDevicePropertyW")]
    public static delegate*<HDEVINFO, void*, DEVPROPKEY*, uint, byte*, uint, uint, BOOL> SetupDiSetDeviceProperty => &SetupDiSetDevicePropertyW;

    [NativeTypeName("#define SetupDiGetDeviceInterfaceProperty SetupDiGetDeviceInterfacePropertyW")]
    public static delegate*<HDEVINFO, void*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, BOOL> SetupDiGetDeviceInterfaceProperty => &SetupDiGetDeviceInterfacePropertyW;

    [NativeTypeName("#define SetupDiSetDeviceInterfaceProperty SetupDiSetDeviceInterfacePropertyW")]
    public static delegate*<HDEVINFO, void*, DEVPROPKEY*, uint, byte*, uint, uint, BOOL> SetupDiSetDeviceInterfaceProperty => &SetupDiSetDeviceInterfacePropertyW;

    [NativeTypeName("#define DICLASSPROP_INSTALLER 0x00000001")]
    public const int DICLASSPROP_INSTALLER = 0x00000001;
    [NativeTypeName("#define DICLASSPROP_INTERFACE 0x00000002")]
    public const int DICLASSPROP_INTERFACE = 0x00000002;
    [NativeTypeName("#define SetupDiGetClassPropertyKeysEx SetupDiGetClassPropertyKeysExW")]
    public static delegate*<Guid*, DEVPROPKEY*, uint, uint*, uint, ushort*, void*, BOOL> SetupDiGetClassPropertyKeysEx => &SetupDiGetClassPropertyKeysExW;

    [NativeTypeName("#define SetupDiGetClassProperty SetupDiGetClassPropertyW")]
    public static delegate*<Guid*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, BOOL> SetupDiGetClassProperty => &SetupDiGetClassPropertyW;

    [NativeTypeName("#define SetupDiGetClassPropertyEx SetupDiGetClassPropertyExW")]
    public static delegate*<Guid*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, ushort*, void*, BOOL> SetupDiGetClassPropertyEx => &SetupDiGetClassPropertyExW;

    [NativeTypeName("#define SetupDiSetClassProperty SetupDiSetClassPropertyW")]
    public static delegate*<Guid*, DEVPROPKEY*, uint, byte*, uint, uint, BOOL> SetupDiSetClassProperty => &SetupDiSetClassPropertyW;

    [NativeTypeName("#define SetupDiSetClassPropertyEx SetupDiSetClassPropertyExW")]
    public static delegate*<Guid*, DEVPROPKEY*, uint, byte*, uint, uint, ushort*, void*, BOOL> SetupDiSetClassPropertyEx => &SetupDiSetClassPropertyExW;

    [NativeTypeName("#define SPCRP_UPPERFILTERS (0x00000011)")]
    public const int SPCRP_UPPERFILTERS = (0x00000011);
    [NativeTypeName("#define SPCRP_LOWERFILTERS (0x00000012)")]
    public const int SPCRP_LOWERFILTERS = (0x00000012);
    [NativeTypeName("#define SPCRP_SECURITY (0x00000017)")]
    public const int SPCRP_SECURITY = (0x00000017);
    [NativeTypeName("#define SPCRP_SECURITY_SDS (0x00000018)")]
    public const int SPCRP_SECURITY_SDS = (0x00000018);
    [NativeTypeName("#define SPCRP_DEVTYPE (0x00000019)")]
    public const int SPCRP_DEVTYPE = (0x00000019);
    [NativeTypeName("#define SPCRP_EXCLUSIVE (0x0000001A)")]
    public const int SPCRP_EXCLUSIVE = (0x0000001A);
    [NativeTypeName("#define SPCRP_CHARACTERISTICS (0x0000001B)")]
    public const int SPCRP_CHARACTERISTICS = (0x0000001B);
    [NativeTypeName("#define SPCRP_MAXIMUM_PROPERTY (0x0000001C)")]
    public const int SPCRP_MAXIMUM_PROPERTY = (0x0000001C);
    [NativeTypeName("#define SetupDiGetDeviceRegistryProperty SetupDiGetDeviceRegistryPropertyW")]
    public static delegate*<HDEVINFO, void*, uint, uint*, byte*, uint, uint*, BOOL> SetupDiGetDeviceRegistryProperty => &SetupDiGetDeviceRegistryPropertyW;

    [NativeTypeName("#define SetupDiGetClassRegistryProperty SetupDiGetClassRegistryPropertyW")]
    public static delegate*<Guid*, uint, uint*, byte*, uint, uint*, ushort*, void*, BOOL> SetupDiGetClassRegistryProperty => &SetupDiGetClassRegistryPropertyW;

    [NativeTypeName("#define SetupDiSetDeviceRegistryProperty SetupDiSetDeviceRegistryPropertyW")]
    public static delegate*<HDEVINFO, void*, uint, byte*, uint, BOOL> SetupDiSetDeviceRegistryProperty => &SetupDiSetDeviceRegistryPropertyW;

    [NativeTypeName("#define SetupDiSetClassRegistryProperty SetupDiSetClassRegistryPropertyW")]
    public static delegate*<Guid*, uint, byte*, uint, ushort*, void*, BOOL> SetupDiSetClassRegistryProperty => &SetupDiSetClassRegistryPropertyW;

    [NativeTypeName("#define SetupDiGetDeviceInstallParams SetupDiGetDeviceInstallParamsW")]
    public static delegate*<HDEVINFO, void*, void*, BOOL> SetupDiGetDeviceInstallParams => &SetupDiGetDeviceInstallParamsW;

    [NativeTypeName("#define SetupDiGetClassInstallParams SetupDiGetClassInstallParamsW")]
    public static delegate*<HDEVINFO, void*, void*, uint, uint*, BOOL> SetupDiGetClassInstallParams => &SetupDiGetClassInstallParamsW;

    [NativeTypeName("#define SetupDiSetDeviceInstallParams SetupDiSetDeviceInstallParamsW")]
    public static delegate*<HDEVINFO, void*, void*, BOOL> SetupDiSetDeviceInstallParams => &SetupDiSetDeviceInstallParamsW;

    [NativeTypeName("#define SetupDiSetClassInstallParams SetupDiSetClassInstallParamsW")]
    public static delegate*<HDEVINFO, void*, void*, uint, BOOL> SetupDiSetClassInstallParams => &SetupDiSetClassInstallParamsW;

    [NativeTypeName("#define SetupDiGetDriverInstallParams SetupDiGetDriverInstallParamsW")]
    public static delegate*<HDEVINFO, void*, void*, void*, BOOL> SetupDiGetDriverInstallParams => &SetupDiGetDriverInstallParamsW;

    [NativeTypeName("#define SetupDiSetDriverInstallParams SetupDiSetDriverInstallParamsW")]
    public static delegate*<HDEVINFO, void*, void*, void*, BOOL> SetupDiSetDriverInstallParams => &SetupDiSetDriverInstallParamsW;

    [NativeTypeName("#define DMI_MASK 0x00000001")]
    public const int DMI_MASK = 0x00000001;
    [NativeTypeName("#define DMI_BKCOLOR 0x00000002")]
    public const int DMI_BKCOLOR = 0x00000002;
    [NativeTypeName("#define DMI_USERECT 0x00000004")]
    public const int DMI_USERECT = 0x00000004;
    [NativeTypeName("#define SetupDiGetClassImageListEx SetupDiGetClassImageListExW")]
    public static delegate*<void*, ushort*, void*, BOOL> SetupDiGetClassImageListEx => &SetupDiGetClassImageListExW;

    [NativeTypeName("#define DIGCDP_FLAG_BASIC 0x00000001")]
    public const int DIGCDP_FLAG_BASIC = 0x00000001;
    [NativeTypeName("#define DIGCDP_FLAG_ADVANCED 0x00000002")]
    public const int DIGCDP_FLAG_ADVANCED = 0x00000002;
    [NativeTypeName("#define DIGCDP_FLAG_REMOTE_BASIC 0x00000003")]
    public const int DIGCDP_FLAG_REMOTE_BASIC = 0x00000003;
    [NativeTypeName("#define DIGCDP_FLAG_REMOTE_ADVANCED 0x00000004")]
    public const int DIGCDP_FLAG_REMOTE_ADVANCED = 0x00000004;
    [NativeTypeName("#define SetupDiGetClassDevPropertySheets SetupDiGetClassDevPropertySheetsW")]
    public static delegate*<HDEVINFO, void*, PROPSHEETHEADERW_V2*, uint, uint*, uint, BOOL> SetupDiGetClassDevPropertySheets => &SetupDiGetClassDevPropertySheetsW;

    [NativeTypeName("#define SetupDiClassNameFromGuid SetupDiClassNameFromGuidW")]
    public static delegate*<Guid*, ushort*, uint, uint*, BOOL> SetupDiClassNameFromGuid => &SetupDiClassNameFromGuidW;

    [NativeTypeName("#define SetupDiClassNameFromGuidEx SetupDiClassNameFromGuidExW")]
    public static delegate*<Guid*, ushort*, uint, uint*, ushort*, void*, BOOL> SetupDiClassNameFromGuidEx => &SetupDiClassNameFromGuidExW;

    [NativeTypeName("#define SetupDiClassGuidsFromName SetupDiClassGuidsFromNameW")]
    public static delegate*<ushort*, Guid*, uint, uint*, BOOL> SetupDiClassGuidsFromName => &SetupDiClassGuidsFromNameW;

    [NativeTypeName("#define SetupDiClassGuidsFromNameEx SetupDiClassGuidsFromNameExW")]
    public static delegate*<ushort*, Guid*, uint, uint*, ushort*, void*, BOOL> SetupDiClassGuidsFromNameEx => &SetupDiClassGuidsFromNameExW;

    [NativeTypeName("#define SetupDiGetHwProfileFriendlyName SetupDiGetHwProfileFriendlyNameW")]
    public static delegate*<uint, ushort*, uint, uint*, BOOL> SetupDiGetHwProfileFriendlyName => &SetupDiGetHwProfileFriendlyNameW;

    [NativeTypeName("#define SetupDiGetHwProfileFriendlyNameEx SetupDiGetHwProfileFriendlyNameExW")]
    public static delegate*<uint, ushort*, uint, uint*, ushort*, void*, BOOL> SetupDiGetHwProfileFriendlyNameEx => &SetupDiGetHwProfileFriendlyNameExW;

    [NativeTypeName("#define SPWPT_SELECTDEVICE 0x00000001")]
    public const int SPWPT_SELECTDEVICE = 0x00000001;
    [NativeTypeName("#define SPWP_USE_DEVINFO_DATA 0x00000001")]
    public const int SPWP_USE_DEVINFO_DATA = 0x00000001;
    [NativeTypeName("#define SetupDiGetActualModelsSection SetupDiGetActualModelsSectionW")]
    public static delegate*<void*, void*, ushort*, uint, uint*, void*, BOOL> SetupDiGetActualModelsSection => &SetupDiGetActualModelsSectionW;

    [NativeTypeName("#define SetupDiGetActualSectionToInstall SetupDiGetActualSectionToInstallW")]
    public static delegate*<HINF, ushort*, ushort*, uint, uint*, ushort**, BOOL> SetupDiGetActualSectionToInstall => &SetupDiGetActualSectionToInstallW;

    [NativeTypeName("#define SetupDiGetActualSectionToInstallEx SetupDiGetActualSectionToInstallExW")]
    public static delegate*<HINF, ushort*, void*, ushort*, uint, uint*, ushort**, void*, BOOL> SetupDiGetActualSectionToInstallEx => &SetupDiGetActualSectionToInstallExW;

    [NativeTypeName("#define SetupEnumInfSections SetupEnumInfSectionsW")]
    public static delegate*<HINF, uint, ushort*, uint, uint*, BOOL> SetupEnumInfSections => &SetupEnumInfSectionsW;

    [NativeTypeName("#define SetupVerifyInfFile SetupVerifyInfFileW")]
    public static delegate*<ushort*, void*, void*, BOOL> SetupVerifyInfFile => &SetupVerifyInfFileW;

    [NativeTypeName("#define DICUSTOMDEVPROP_MERGE_MULTISZ 0x00000001")]
    public const int DICUSTOMDEVPROP_MERGE_MULTISZ = 0x00000001;
    [NativeTypeName("#define SetupDiGetCustomDeviceProperty SetupDiGetCustomDevicePropertyW")]
    public static delegate*<HDEVINFO, void*, ushort*, uint, uint*, byte*, uint, uint*, BOOL> SetupDiGetCustomDeviceProperty => &SetupDiGetCustomDevicePropertyW;

    [NativeTypeName("#define SCWMI_CLOBBER_SECURITY 0x00000001")]
    public const int SCWMI_CLOBBER_SECURITY = 0x00000001;
    [NativeTypeName("#define SetupConfigureWmiFromInfSection SetupConfigureWmiFromInfSectionW")]
    public static delegate*<HINF, ushort*, uint, BOOL> SetupConfigureWmiFromInfSection => &SetupConfigureWmiFromInfSectionW;
}