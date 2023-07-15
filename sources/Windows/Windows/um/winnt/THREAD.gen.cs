// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class THREAD
{
    [NativeTypeName("#define THREAD_TERMINATE (0x0001)")]
    public const int THREAD_TERMINATE = (0x0001);
    [NativeTypeName("#define THREAD_SUSPEND_RESUME (0x0002)")]
    public const int THREAD_SUSPEND_RESUME = (0x0002);
    [NativeTypeName("#define THREAD_GET_CONTEXT (0x0008)")]
    public const int THREAD_GET_CONTEXT = (0x0008);
    [NativeTypeName("#define THREAD_SET_CONTEXT (0x0010)")]
    public const int THREAD_SET_CONTEXT = (0x0010);
    [NativeTypeName("#define THREAD_QUERY_INFORMATION (0x0040)")]
    public const int THREAD_QUERY_INFORMATION = (0x0040);
    [NativeTypeName("#define THREAD_SET_INFORMATION (0x0020)")]
    public const int THREAD_SET_INFORMATION = (0x0020);
    [NativeTypeName("#define THREAD_SET_THREAD_TOKEN (0x0080)")]
    public const int THREAD_SET_THREAD_TOKEN = (0x0080);
    [NativeTypeName("#define THREAD_IMPERSONATE (0x0100)")]
    public const int THREAD_IMPERSONATE = (0x0100);
    [NativeTypeName("#define THREAD_DIRECT_IMPERSONATION (0x0200)")]
    public const int THREAD_DIRECT_IMPERSONATION = (0x0200);
    [NativeTypeName("#define THREAD_SET_LIMITED_INFORMATION (0x0400)")]
    public const int THREAD_SET_LIMITED_INFORMATION = (0x0400);
    [NativeTypeName("#define THREAD_QUERY_LIMITED_INFORMATION (0x0800)")]
    public const int THREAD_QUERY_LIMITED_INFORMATION = (0x0800);
    [NativeTypeName("#define THREAD_RESUME (0x1000)")]
    public const int THREAD_RESUME = (0x1000);
    [NativeTypeName("#define THREAD_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | \\\r\n                                   0xFFFF)")]
    public const int THREAD_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0xFFFF);
    [NativeTypeName("#define THREAD_DYNAMIC_CODE_ALLOW 1")]
    public const int THREAD_DYNAMIC_CODE_ALLOW = 1;
    [NativeTypeName("#define THREAD_BASE_PRIORITY_LOWRT 15")]
    public const int THREAD_BASE_PRIORITY_LOWRT = 15;
    [NativeTypeName("#define THREAD_BASE_PRIORITY_MAX 2")]
    public const int THREAD_BASE_PRIORITY_MAX = 2;
    [NativeTypeName("#define THREAD_BASE_PRIORITY_MIN (-2)")]
    public const int THREAD_BASE_PRIORITY_MIN = (-2);
    [NativeTypeName("#define THREAD_BASE_PRIORITY_IDLE (-15)")]
    public const int THREAD_BASE_PRIORITY_IDLE = (-15);
    [NativeTypeName("#define THREAD_PROFILING_FLAG_DISPATCH 0x00000001")]
    public const int THREAD_PROFILING_FLAG_DISPATCH = 0x00000001;
}