// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class GL
{
    [NativeTypeName("#define GL_STOP_LISTENING 0x00000002")]
    public const int GL_STOP_LISTENING = 0x00000002;

    [NativeTypeName("#define GL_CACHE_CLEANUP 0x00000004")]
    public const int GL_CACHE_CLEANUP = 0x00000004;

    [NativeTypeName("#define GL_CACHE_OPERATION 0x00000010")]
    public const int GL_CACHE_OPERATION = 0x00000010;

    [NativeTypeName("#define GL_HEALTH_CHECK 0x00000020")]
    public const int GL_HEALTH_CHECK = 0x00000020;

    [NativeTypeName("#define GL_CONFIGURATION_CHANGE 0x00000040")]
    public const int GL_CONFIGURATION_CHANGE = 0x00000040;

    [NativeTypeName("#define GL_FILE_CHANGE 0x00000080")]
    public const int GL_FILE_CHANGE = 0x00000080;

    [NativeTypeName("#define GL_PRE_BEGIN_REQUEST 0x00000100")]
    public const int GL_PRE_BEGIN_REQUEST = 0x00000100;

    [NativeTypeName("#define GL_APPLICATION_START 0x00000200")]
    public const int GL_APPLICATION_START = 0x00000200;

    [NativeTypeName("#define GL_APPLICATION_RESOLVE_MODULES 0x00000400")]
    public const int GL_APPLICATION_RESOLVE_MODULES = 0x00000400;

    [NativeTypeName("#define GL_APPLICATION_STOP 0x00000800")]
    public const int GL_APPLICATION_STOP = 0x00000800;

    [NativeTypeName("#define GL_RSCA_QUERY 0x00001000")]
    public const int GL_RSCA_QUERY = 0x00001000;

    [NativeTypeName("#define GL_TRACE_EVENT 0x00002000")]
    public const int GL_TRACE_EVENT = 0x00002000;

    [NativeTypeName("#define GL_CUSTOM_NOTIFICATION 0x00004000")]
    public const int GL_CUSTOM_NOTIFICATION = 0x00004000;

    [NativeTypeName("#define GL_THREAD_CLEANUP 0x00008000")]
    public const int GL_THREAD_CLEANUP = 0x00008000;

    [NativeTypeName("#define GL_APPLICATION_PRELOAD 0x00010000")]
    public const int GL_APPLICATION_PRELOAD = 0x00010000;

    [NativeTypeName("#define GL_SUSPEND_PROCESS 0x00020000")]
    public const int GL_SUSPEND_PROCESS = 0x00020000;
}
