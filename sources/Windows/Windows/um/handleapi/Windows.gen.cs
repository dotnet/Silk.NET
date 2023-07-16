// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/handleapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CloseHandle"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseHandle(HANDLE hObject);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DuplicateHandle"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DuplicateHandle(HANDLE hSourceProcessHandle, HANDLE hSourceHandle, HANDLE hTargetProcessHandle, [NativeTypeName("LPHANDLE")] HANDLE* lpTargetHandle, [NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("DWORD")] uint dwOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CompareObjectHandles"]/*'/>
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern BOOL CompareObjectHandles(HANDLE hFirstObjectHandle, HANDLE hSecondObjectHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetHandleInformation"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetHandleInformation(HANDLE hObject, [NativeTypeName("LPDWORD")] uint* lpdwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetHandleInformation"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetHandleInformation(HANDLE hObject, [NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwFlags);
}