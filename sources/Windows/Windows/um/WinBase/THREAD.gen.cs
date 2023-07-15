// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class THREAD
{
    [NativeTypeName("#define THREAD_PRIORITY_LOWEST THREAD_BASE_PRIORITY_MIN")]
    public const int THREAD_PRIORITY_LOWEST = (-2);
    [NativeTypeName("#define THREAD_PRIORITY_BELOW_NORMAL (THREAD_PRIORITY_LOWEST+1)")]
    public const int THREAD_PRIORITY_BELOW_NORMAL = ((-2) + 1);
    [NativeTypeName("#define THREAD_PRIORITY_NORMAL 0")]
    public const int THREAD_PRIORITY_NORMAL = 0;
    [NativeTypeName("#define THREAD_PRIORITY_HIGHEST THREAD_BASE_PRIORITY_MAX")]
    public const int THREAD_PRIORITY_HIGHEST = 2;
    [NativeTypeName("#define THREAD_PRIORITY_ABOVE_NORMAL (THREAD_PRIORITY_HIGHEST-1)")]
    public const int THREAD_PRIORITY_ABOVE_NORMAL = (2 - 1);
    [NativeTypeName("#define THREAD_PRIORITY_ERROR_RETURN (MAXLONG)")]
    public const int THREAD_PRIORITY_ERROR_RETURN = (0x7fffffff);
    [NativeTypeName("#define THREAD_PRIORITY_TIME_CRITICAL THREAD_BASE_PRIORITY_LOWRT")]
    public const int THREAD_PRIORITY_TIME_CRITICAL = 15;
    [NativeTypeName("#define THREAD_PRIORITY_IDLE THREAD_BASE_PRIORITY_IDLE")]
    public const int THREAD_PRIORITY_IDLE = (-15);
    [NativeTypeName("#define THREAD_MODE_BACKGROUND_BEGIN 0x00010000")]
    public const int THREAD_MODE_BACKGROUND_BEGIN = 0x00010000;
    [NativeTypeName("#define THREAD_MODE_BACKGROUND_END 0x00020000")]
    public const int THREAD_MODE_BACKGROUND_END = 0x00020000;
}