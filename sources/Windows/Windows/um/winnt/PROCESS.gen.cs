// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PROCESS
{
    [NativeTypeName("#define PROCESS_TRUST_LABEL_SECURITY_INFORMATION (0x00000080L)")]
    public const int PROCESS_TRUST_LABEL_SECURITY_INFORMATION = (0x00000080);
    [NativeTypeName("#define PROCESS_TERMINATE (0x0001)")]
    public const int PROCESS_TERMINATE = (0x0001);
    [NativeTypeName("#define PROCESS_CREATE_THREAD (0x0002)")]
    public const int PROCESS_CREATE_THREAD = (0x0002);
    [NativeTypeName("#define PROCESS_SET_SESSIONID (0x0004)")]
    public const int PROCESS_SET_SESSIONID = (0x0004);
    [NativeTypeName("#define PROCESS_VM_OPERATION (0x0008)")]
    public const int PROCESS_VM_OPERATION = (0x0008);
    [NativeTypeName("#define PROCESS_VM_READ (0x0010)")]
    public const int PROCESS_VM_READ = (0x0010);
    [NativeTypeName("#define PROCESS_VM_WRITE (0x0020)")]
    public const int PROCESS_VM_WRITE = (0x0020);
    [NativeTypeName("#define PROCESS_DUP_HANDLE (0x0040)")]
    public const int PROCESS_DUP_HANDLE = (0x0040);
    [NativeTypeName("#define PROCESS_CREATE_PROCESS (0x0080)")]
    public const int PROCESS_CREATE_PROCESS = (0x0080);
    [NativeTypeName("#define PROCESS_SET_QUOTA (0x0100)")]
    public const int PROCESS_SET_QUOTA = (0x0100);
    [NativeTypeName("#define PROCESS_SET_INFORMATION (0x0200)")]
    public const int PROCESS_SET_INFORMATION = (0x0200);
    [NativeTypeName("#define PROCESS_QUERY_INFORMATION (0x0400)")]
    public const int PROCESS_QUERY_INFORMATION = (0x0400);
    [NativeTypeName("#define PROCESS_SUSPEND_RESUME (0x0800)")]
    public const int PROCESS_SUSPEND_RESUME = (0x0800);
    [NativeTypeName("#define PROCESS_QUERY_LIMITED_INFORMATION (0x1000)")]
    public const int PROCESS_QUERY_LIMITED_INFORMATION = (0x1000);
    [NativeTypeName("#define PROCESS_SET_LIMITED_INFORMATION (0x2000)")]
    public const int PROCESS_SET_LIMITED_INFORMATION = (0x2000);
    [NativeTypeName("#define PROCESS_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | \\\r\n                                   0xFFFF)")]
    public const int PROCESS_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0xFFFF);
}