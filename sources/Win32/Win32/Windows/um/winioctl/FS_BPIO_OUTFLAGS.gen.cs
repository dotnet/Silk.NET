// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum FS_BPIO_OUTFLAGS
{
    FSBPIO_OUTFL_None = 0,
    FSBPIO_OUTFL_VOLUME_STACK_BYPASS_PAUSED = 0x00000001,
    FSBPIO_OUTFL_STREAM_BYPASS_PAUSED = 0x00000002,
    FSBPIO_OUTFL_FILTER_ATTACH_BLOCKED = 0x00000004,
    FSBPIO_OUTFL_COMPATIBLE_STORAGE_DRIVER = 0x00000008,
}
