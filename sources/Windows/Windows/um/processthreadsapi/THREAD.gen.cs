// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class THREAD
{
    [NativeTypeName("#define THREAD_POWER_THROTTLING_CURRENT_VERSION 1")]
    public const int THREAD_POWER_THROTTLING_CURRENT_VERSION = 1;

    [NativeTypeName("#define THREAD_POWER_THROTTLING_EXECUTION_SPEED 0x1")]
    public const int THREAD_POWER_THROTTLING_EXECUTION_SPEED = 0x1;

    [NativeTypeName("#define THREAD_POWER_THROTTLING_VALID_FLAGS (THREAD_POWER_THROTTLING_EXECUTION_SPEED)")]
    public const int THREAD_POWER_THROTTLING_VALID_FLAGS = (0x1);
}
