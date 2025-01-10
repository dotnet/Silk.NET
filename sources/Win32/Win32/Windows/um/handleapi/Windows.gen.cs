// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/handleapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseHandle(HANDLE hObject);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DuplicateHandle(
        HANDLE hSourceProcessHandle,
        HANDLE hSourceHandle,
        HANDLE hTargetProcessHandle,
        [NativeTypeName("LPHANDLE")] HANDLE* lpTargetHandle,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        BOOL bInheritHandle,
        [NativeTypeName("DWORD")] uint dwOptions
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL CompareObjectHandles(
        HANDLE hFirstObjectHandle,
        HANDLE hSecondObjectHandle
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetHandleInformation(
        HANDLE hObject,
        [NativeTypeName("LPDWORD")] uint* lpdwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetHandleInformation(
        HANDLE hObject,
        [NativeTypeName("DWORD")] uint dwMask,
        [NativeTypeName("DWORD")] uint dwFlags
    );
}
