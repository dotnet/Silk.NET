// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PROCESS
{
    [NativeTypeName("#define PROCESS_AFFINITY_ENABLE_AUTO_UPDATE 0x00000001UL")]
    public const uint PROCESS_AFFINITY_ENABLE_AUTO_UPDATE = 0x00000001U;
    [NativeTypeName("#define PROCESS_POWER_THROTTLING_CURRENT_VERSION 1")]
    public const int PROCESS_POWER_THROTTLING_CURRENT_VERSION = 1;
    [NativeTypeName("#define PROCESS_POWER_THROTTLING_EXECUTION_SPEED 0x1")]
    public const int PROCESS_POWER_THROTTLING_EXECUTION_SPEED = 0x1;
    [NativeTypeName("#define PROCESS_POWER_THROTTLING_IGNORE_TIMER_RESOLUTION 0x4")]
    public const int PROCESS_POWER_THROTTLING_IGNORE_TIMER_RESOLUTION = 0x4;
    [NativeTypeName("#define PROCESS_POWER_THROTTLING_VALID_FLAGS ((PROCESS_POWER_THROTTLING_EXECUTION_SPEED | \\\r\n                                               PROCESS_POWER_THROTTLING_IGNORE_TIMER_RESOLUTION))")]
    public const int PROCESS_POWER_THROTTLING_VALID_FLAGS = ((0x1 | 0x4));
    [NativeTypeName("#define PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND 0x1")]
    public const int PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND = 0x1;
    [NativeTypeName("#define PROCESS_LEAP_SECOND_INFO_VALID_FLAGS (PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND)")]
    public const int PROCESS_LEAP_SECOND_INFO_VALID_FLAGS = (0x1);
}