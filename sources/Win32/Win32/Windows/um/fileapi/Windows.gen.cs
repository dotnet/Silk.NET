// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int CompareFileTime(
        [NativeTypeName("const FILETIME *")] FILETIME* lpFileTime1,
        [NativeTypeName("const FILETIME *")] FILETIME* lpFileTime2
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryA(
        [NativeTypeName("LPCSTR")] sbyte* lpPathName,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryW(
        [NativeTypeName("LPCWSTR")] ushort* lpPathName,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("DWORD")] uint dwShareMode,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("DWORD")] uint dwCreationDisposition,
        [NativeTypeName("DWORD")] uint dwFlagsAndAttributes,
        HANDLE hTemplateFile
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("DWORD")] uint dwShareMode,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("DWORD")] uint dwCreationDisposition,
        [NativeTypeName("DWORD")] uint dwFlagsAndAttributes,
        HANDLE hTemplateFile
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DefineDosDeviceW(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* lpDeviceName,
        [NativeTypeName("LPCWSTR")] ushort* lpTargetPath
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteVolumeMountPointW(
        [NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FileTimeToLocalFileTime(
        [NativeTypeName("const FILETIME *")] FILETIME* lpFileTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpLocalFileTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindClose(HANDLE hFindFile);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindCloseChangeNotification(HANDLE hChangeHandle);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstChangeNotificationA(
        [NativeTypeName("LPCSTR")] sbyte* lpPathName,
        BOOL bWatchSubtree,
        [NativeTypeName("DWORD")] uint dwNotifyFilter
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstChangeNotificationW(
        [NativeTypeName("LPCWSTR")] ushort* lpPathName,
        BOOL bWatchSubtree,
        [NativeTypeName("DWORD")] uint dwNotifyFilter
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileExA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        FINDEX_INFO_LEVELS fInfoLevelId,
        [NativeTypeName("LPVOID")] void* lpFindFileData,
        FINDEX_SEARCH_OPS fSearchOp,
        [NativeTypeName("LPVOID")] void* lpSearchFilter,
        [NativeTypeName("DWORD")] uint dwAdditionalFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileExW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        FINDEX_INFO_LEVELS fInfoLevelId,
        [NativeTypeName("LPVOID")] void* lpFindFileData,
        FINDEX_SEARCH_OPS fSearchOp,
        [NativeTypeName("LPVOID")] void* lpSearchFilter,
        [NativeTypeName("DWORD")] uint dwAdditionalFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstVolumeW(
        [NativeTypeName("LPWSTR")] ushort* lpszVolumeName,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextChangeNotification(HANDLE hChangeHandle);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextFileA(
        HANDLE hFindFile,
        [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextFileW(
        HANDLE hFindFile,
        [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextVolumeW(
        HANDLE hFindVolume,
        [NativeTypeName("LPWSTR")] ushort* lpszVolumeName,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindVolumeClose(HANDLE hFindVolume);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FlushFileBuffers(HANDLE hFile);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDiskFreeSpaceA(
        [NativeTypeName("LPCSTR")] sbyte* lpRootPathName,
        [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster,
        [NativeTypeName("LPDWORD")] uint* lpBytesPerSector,
        [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters,
        [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDiskFreeSpaceW(
        [NativeTypeName("LPCWSTR")] ushort* lpRootPathName,
        [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster,
        [NativeTypeName("LPDWORD")] uint* lpBytesPerSector,
        [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters,
        [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDiskFreeSpaceExA(
        [NativeTypeName("LPCSTR")] sbyte* lpDirectoryName,
        [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller,
        [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes,
        [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDiskFreeSpaceExW(
        [NativeTypeName("LPCWSTR")] ushort* lpDirectoryName,
        [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller,
        [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes,
        [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT GetDiskSpaceInformationA(
        [NativeTypeName("LPCSTR")] sbyte* rootPath,
        DISK_SPACE_INFORMATION* diskSpaceInfo
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT GetDiskSpaceInformationW(
        [NativeTypeName("LPCWSTR")] ushort* rootPath,
        DISK_SPACE_INFORMATION* diskSpaceInfo
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetDriveTypeA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetDriveTypeW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFileAttributesW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileAttributesExA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        GET_FILEEX_INFO_LEVELS fInfoLevelId,
        [NativeTypeName("LPVOID")] void* lpFileInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileAttributesExW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        GET_FILEEX_INFO_LEVELS fInfoLevelId,
        [NativeTypeName("LPVOID")] void* lpFileInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileInformationByHandle(
        HANDLE hFile,
        [NativeTypeName("LPBY_HANDLE_FILE_INFORMATION")]
            BY_HANDLE_FILE_INFORMATION* lpFileInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFileSize(
        HANDLE hFile,
        [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileSizeEx(
        HANDLE hFile,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpFileSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFileType(HANDLE hFile);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFinalPathNameByHandleA(
        HANDLE hFile,
        [NativeTypeName("LPSTR")] sbyte* lpszFilePath,
        [NativeTypeName("DWORD")] uint cchFilePath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFinalPathNameByHandleW(
        HANDLE hFile,
        [NativeTypeName("LPWSTR")] ushort* lpszFilePath,
        [NativeTypeName("DWORD")] uint cchFilePath,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileTime(
        HANDLE hFile,
        [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpLastAccessTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpLastWriteTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFullPathNameW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        [NativeTypeName("LPWSTR *")] ushort** lpFilePart
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFullPathNameA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        [NativeTypeName("LPSTR *")] sbyte** lpFilePart
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLogicalDrives();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLogicalDriveStringsW(
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLongPathNameA(
        [NativeTypeName("LPCSTR")] sbyte* lpszShortPath,
        [NativeTypeName("LPSTR")] sbyte* lpszLongPath,
        [NativeTypeName("DWORD")] uint cchBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLongPathNameW(
        [NativeTypeName("LPCWSTR")] ushort* lpszShortPath,
        [NativeTypeName("LPWSTR")] ushort* lpszLongPath,
        [NativeTypeName("DWORD")] uint cchBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AreShortNamesEnabled(HANDLE Handle, BOOL* Enabled);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetShortPathNameW(
        [NativeTypeName("LPCWSTR")] ushort* lpszLongPath,
        [NativeTypeName("LPWSTR")] ushort* lpszShortPath,
        [NativeTypeName("DWORD")] uint cchBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetTempFileNameW(
        [NativeTypeName("LPCWSTR")] ushort* lpPathName,
        [NativeTypeName("LPCWSTR")] ushort* lpPrefixString,
        uint uUnique,
        [NativeTypeName("LPWSTR")] ushort* lpTempFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumeInformationByHandleW(
        HANDLE hFile,
        [NativeTypeName("LPWSTR")] ushort* lpVolumeNameBuffer,
        [NativeTypeName("DWORD")] uint nVolumeNameSize,
        [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber,
        [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength,
        [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags,
        [NativeTypeName("LPWSTR")] ushort* lpFileSystemNameBuffer,
        [NativeTypeName("DWORD")] uint nFileSystemNameSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumeInformationW(
        [NativeTypeName("LPCWSTR")] ushort* lpRootPathName,
        [NativeTypeName("LPWSTR")] ushort* lpVolumeNameBuffer,
        [NativeTypeName("DWORD")] uint nVolumeNameSize,
        [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber,
        [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength,
        [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags,
        [NativeTypeName("LPWSTR")] ushort* lpFileSystemNameBuffer,
        [NativeTypeName("DWORD")] uint nFileSystemNameSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumePathNameW(
        [NativeTypeName("LPCWSTR")] ushort* lpszFileName,
        [NativeTypeName("LPWSTR")] ushort* lpszVolumePathName,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LocalFileTimeToFileTime(
        [NativeTypeName("const FILETIME *")] FILETIME* lpLocalFileTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LockFile(
        HANDLE hFile,
        [NativeTypeName("DWORD")] uint dwFileOffsetLow,
        [NativeTypeName("DWORD")] uint dwFileOffsetHigh,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LockFileEx(
        HANDLE hFile,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwReserved,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint QueryDosDeviceW(
        [NativeTypeName("LPCWSTR")] ushort* lpDeviceName,
        [NativeTypeName("LPWSTR")] ushort* lpTargetPath,
        [NativeTypeName("DWORD")] uint ucchMax
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadFile(
        HANDLE hFile,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToRead,
        [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadFileEx(
        HANDLE hFile,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToRead,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped,
        [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")]
            delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadFileScatter(
        HANDLE hFile,
        [NativeTypeName("FILE_SEGMENT_ELEMENT[]")] FILE_SEGMENT_ELEMENT* aSegmentArray,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToRead,
        [NativeTypeName("LPDWORD")] uint* lpReserved,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetEndOfFile(HANDLE hFile);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileAttributesA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("DWORD")] uint dwFileAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileAttributesW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("DWORD")] uint dwFileAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileInformationByHandle(
        HANDLE hFile,
        FILE_INFO_BY_HANDLE_CLASS FileInformationClass,
        [NativeTypeName("LPVOID")] void* lpFileInformation,
        [NativeTypeName("DWORD")] uint dwBufferSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetFilePointer(
        HANDLE hFile,
        [NativeTypeName("LONG")] int lDistanceToMove,
        [NativeTypeName("PLONG")] int* lpDistanceToMoveHigh,
        [NativeTypeName("DWORD")] uint dwMoveMethod
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFilePointerEx(
        HANDLE hFile,
        LARGE_INTEGER liDistanceToMove,
        [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpNewFilePointer,
        [NativeTypeName("DWORD")] uint dwMoveMethod
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileTime(
        HANDLE hFile,
        [NativeTypeName("const FILETIME *")] FILETIME* lpCreationTime,
        [NativeTypeName("const FILETIME *")] FILETIME* lpLastAccessTime,
        [NativeTypeName("const FILETIME *")] FILETIME* lpLastWriteTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileValidData(
        HANDLE hFile,
        [NativeTypeName("LONGLONG")] long ValidDataLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnlockFile(
        HANDLE hFile,
        [NativeTypeName("DWORD")] uint dwFileOffsetLow,
        [NativeTypeName("DWORD")] uint dwFileOffsetHigh,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnlockFileEx(
        HANDLE hFile,
        [NativeTypeName("DWORD")] uint dwReserved,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteFile(
        HANDLE hFile,
        [NativeTypeName("LPCVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite,
        [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteFileEx(
        HANDLE hFile,
        [NativeTypeName("LPCVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped,
        [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")]
            delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteFileGather(
        HANDLE hFile,
        [NativeTypeName("FILE_SEGMENT_ELEMENT[]")] FILE_SEGMENT_ELEMENT* aSegmentArray,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite,
        [NativeTypeName("LPDWORD")] uint* lpReserved,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTempPathW(
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumeNameForVolumeMountPointW(
        [NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint,
        [NativeTypeName("LPWSTR")] ushort* lpszVolumeName,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumePathNamesForVolumeNameW(
        [NativeTypeName("LPCWSTR")] ushort* lpszVolumeName,
        [NativeTypeName("LPWCH")] ushort* lpszVolumePathNames,
        [NativeTypeName("DWORD")] uint cchBufferLength,
        [NativeTypeName("PDWORD")] uint* lpcchReturnLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern HANDLE CreateFile2(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("DWORD")] uint dwShareMode,
        [NativeTypeName("DWORD")] uint dwCreationDisposition,
        [NativeTypeName("LPCREATEFILE2_EXTENDED_PARAMETERS")]
            CREATEFILE2_EXTENDED_PARAMETERS* pCreateExParams
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileIoOverlappedRange(
        HANDLE FileHandle,
        [NativeTypeName("PUCHAR")] byte* OverlappedRangeStart,
        [NativeTypeName("ULONG")] uint Length
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCompressedFileSizeA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCompressedFileSizeW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstStreamW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        STREAM_INFO_LEVELS InfoLevel,
        [NativeTypeName("LPVOID")] void* lpFindStreamData,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextStreamW(
        HANDLE hFindStream,
        [NativeTypeName("LPVOID")] void* lpFindStreamData
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL AreFileApisANSI();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTempPathA(
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileNameW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPDWORD")] uint* StringLength,
        [NativeTypeName("PWSTR")] ushort* LinkName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextFileNameW(
        HANDLE hFindStream,
        [NativeTypeName("LPDWORD")] uint* StringLength,
        [NativeTypeName("PWSTR")] ushort* LinkName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumeInformationA(
        [NativeTypeName("LPCSTR")] sbyte* lpRootPathName,
        [NativeTypeName("LPSTR")] sbyte* lpVolumeNameBuffer,
        [NativeTypeName("DWORD")] uint nVolumeNameSize,
        [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber,
        [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength,
        [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags,
        [NativeTypeName("LPSTR")] sbyte* lpFileSystemNameBuffer,
        [NativeTypeName("DWORD")] uint nFileSystemNameSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetTempFileNameA(
        [NativeTypeName("LPCSTR")] sbyte* lpPathName,
        [NativeTypeName("LPCSTR")] sbyte* lpPrefixString,
        uint uUnique,
        [NativeTypeName("LPSTR")] sbyte* lpTempFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SetFileApisToOEM();

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SetFileApisToANSI();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint GetTempPath2W(
        [NativeTypeName("DWORD")] uint BufferLength,
        [NativeTypeName("LPWSTR")] ushort* Buffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint GetTempPath2A(
        [NativeTypeName("DWORD")] uint BufferLength,
        [NativeTypeName("LPSTR")] sbyte* Buffer
    );

    [NativeTypeName("#define TRUNCATE_EXISTING 5")]
    public const int TRUNCATE_EXISTING = 5;

    [NativeTypeName("#define INVALID_FILE_SIZE ((DWORD)0xFFFFFFFF)")]
    public const uint INVALID_FILE_SIZE = ((uint)(0xFFFFFFFF));

    [NativeTypeName("#define INVALID_SET_FILE_POINTER ((DWORD)-1)")]
    public const uint INVALID_SET_FILE_POINTER = unchecked((uint)(-1));

    [NativeTypeName("#define INVALID_FILE_ATTRIBUTES ((DWORD)-1)")]
    public const uint INVALID_FILE_ATTRIBUTES = unchecked((uint)(-1));

    [NativeTypeName("#define CreateDirectory CreateDirectoryW")]
    public static delegate* <ushort*, SECURITY_ATTRIBUTES*, BOOL> CreateDirectory =>
        &CreateDirectoryW;

    [NativeTypeName("#define CreateFile CreateFileW")]
    public static delegate* <
        ushort*,
        uint,
        uint,
        SECURITY_ATTRIBUTES*,
        uint,
        uint,
        HANDLE,
        HANDLE> CreateFile => &CreateFileW;

    [NativeTypeName("#define DefineDosDevice DefineDosDeviceW")]
    public static delegate* <uint, ushort*, ushort*, BOOL> DefineDosDevice => &DefineDosDeviceW;

    [NativeTypeName("#define DeleteFile DeleteFileW")]
    public static delegate* <ushort*, BOOL> DeleteFile => &DeleteFileW;

    [NativeTypeName("#define DeleteVolumeMountPoint DeleteVolumeMountPointW")]
    public static delegate* <ushort*, BOOL> DeleteVolumeMountPoint => &DeleteVolumeMountPointW;

    [NativeTypeName("#define FindFirstChangeNotification FindFirstChangeNotificationW")]
    public static delegate* <ushort*, BOOL, uint, HANDLE> FindFirstChangeNotification =>
        &FindFirstChangeNotificationW;

    [NativeTypeName("#define FindFirstFile FindFirstFileW")]
    public static delegate* <ushort*, WIN32_FIND_DATAW*, HANDLE> FindFirstFile => &FindFirstFileW;

    [NativeTypeName("#define FindFirstFileEx FindFirstFileExW")]
    public static delegate* <
        ushort*,
        FINDEX_INFO_LEVELS,
        void*,
        FINDEX_SEARCH_OPS,
        void*,
        uint,
        HANDLE> FindFirstFileEx => &FindFirstFileExW;

    [NativeTypeName("#define FindFirstVolume FindFirstVolumeW")]
    public static delegate* <ushort*, uint, HANDLE> FindFirstVolume => &FindFirstVolumeW;

    [NativeTypeName("#define FindNextFile FindNextFileW")]
    public static delegate* <HANDLE, WIN32_FIND_DATAW*, BOOL> FindNextFile => &FindNextFileW;

    [NativeTypeName("#define FindNextVolume FindNextVolumeW")]
    public static delegate* <HANDLE, ushort*, uint, BOOL> FindNextVolume => &FindNextVolumeW;

    [NativeTypeName("#define GetDiskFreeSpace GetDiskFreeSpaceW")]
    public static delegate* <ushort*, uint*, uint*, uint*, uint*, BOOL> GetDiskFreeSpace =>
        &GetDiskFreeSpaceW;

    [NativeTypeName("#define GetDiskFreeSpaceEx GetDiskFreeSpaceExW")]
    public static delegate* <
        ushort*,
        ULARGE_INTEGER*,
        ULARGE_INTEGER*,
        ULARGE_INTEGER*,
        BOOL> GetDiskFreeSpaceEx => &GetDiskFreeSpaceExW;

    [NativeTypeName("#define GetDiskSpaceInformation GetDiskSpaceInformationW")]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static delegate* <ushort*, DISK_SPACE_INFORMATION*, HRESULT> GetDiskSpaceInformation =>
        &GetDiskSpaceInformationW;

    [NativeTypeName("#define GetDriveType GetDriveTypeW")]
    public static delegate* <ushort*, uint> GetDriveType => &GetDriveTypeW;

    [NativeTypeName("#define GetFileAttributes GetFileAttributesW")]
    public static delegate* <ushort*, uint> GetFileAttributes => &GetFileAttributesW;

    [NativeTypeName("#define GetFileAttributesEx GetFileAttributesExW")]
    public static delegate* <ushort*, GET_FILEEX_INFO_LEVELS, void*, BOOL> GetFileAttributesEx =>
        &GetFileAttributesExW;

    [NativeTypeName("#define GetFinalPathNameByHandle GetFinalPathNameByHandleW")]
    public static delegate* <HANDLE, ushort*, uint, uint, uint> GetFinalPathNameByHandle =>
        &GetFinalPathNameByHandleW;

    [NativeTypeName("#define GetFullPathName GetFullPathNameW")]
    public static delegate* <ushort*, uint, ushort*, ushort**, uint> GetFullPathName =>
        &GetFullPathNameW;

    [NativeTypeName("#define GetLogicalDriveStrings GetLogicalDriveStringsW")]
    public static delegate* <uint, ushort*, uint> GetLogicalDriveStrings =>
        &GetLogicalDriveStringsW;

    [NativeTypeName("#define GetLongPathName GetLongPathNameW")]
    public static delegate* <ushort*, ushort*, uint, uint> GetLongPathName => &GetLongPathNameW;

    [NativeTypeName("#define GetShortPathName GetShortPathNameW")]
    public static delegate* <ushort*, ushort*, uint, uint> GetShortPathName => &GetShortPathNameW;

    [NativeTypeName("#define GetTempFileName GetTempFileNameW")]
    public static delegate* <ushort*, ushort*, uint, ushort*, uint> GetTempFileName =>
        &GetTempFileNameW;

    [NativeTypeName("#define GetVolumeInformation GetVolumeInformationW")]
    public static delegate* <
        ushort*,
        ushort*,
        uint,
        uint*,
        uint*,
        uint*,
        ushort*,
        uint,
        BOOL> GetVolumeInformation => &GetVolumeInformationW;

    [NativeTypeName("#define GetVolumePathName GetVolumePathNameW")]
    public static delegate* <ushort*, ushort*, uint, BOOL> GetVolumePathName => &GetVolumePathNameW;

    [NativeTypeName("#define QueryDosDevice QueryDosDeviceW")]
    public static delegate* <ushort*, ushort*, uint, uint> QueryDosDevice => &QueryDosDeviceW;

    [NativeTypeName("#define RemoveDirectory RemoveDirectoryW")]
    public static delegate* <ushort*, BOOL> RemoveDirectory => &RemoveDirectoryW;

    [NativeTypeName("#define SetFileAttributes SetFileAttributesW")]
    public static delegate* <ushort*, uint, BOOL> SetFileAttributes => &SetFileAttributesW;

    [NativeTypeName("#define GetTempPath GetTempPathW")]
    public static delegate* <uint, ushort*, uint> GetTempPath => &GetTempPathW;

    [NativeTypeName("#define GetVolumeNameForVolumeMountPoint GetVolumeNameForVolumeMountPointW")]
    public static delegate* <ushort*, ushort*, uint, BOOL> GetVolumeNameForVolumeMountPoint =>
        &GetVolumeNameForVolumeMountPointW;

    [NativeTypeName("#define GetVolumePathNamesForVolumeName GetVolumePathNamesForVolumeNameW")]
    public static delegate* <ushort*, ushort*, uint, uint*, BOOL> GetVolumePathNamesForVolumeName =>
        &GetVolumePathNamesForVolumeNameW;

    [NativeTypeName("#define GetCompressedFileSize GetCompressedFileSizeW")]
    public static delegate* <ushort*, uint*, uint> GetCompressedFileSize => &GetCompressedFileSizeW;

    [NativeTypeName("#define GetTempPath2 GetTempPath2W")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static delegate* <uint, ushort*, uint> GetTempPath2 => &GetTempPath2W;
}
