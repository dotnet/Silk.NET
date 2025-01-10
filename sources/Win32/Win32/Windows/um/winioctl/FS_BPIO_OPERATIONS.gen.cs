// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum FS_BPIO_OPERATIONS
{
    FS_BPIO_OP_ENABLE = 1,
    FS_BPIO_OP_DISABLE = 2,
    FS_BPIO_OP_QUERY = 3,
    FS_BPIO_OP_VOLUME_STACK_PAUSE = 4,
    FS_BPIO_OP_VOLUME_STACK_RESUME = 5,
    FS_BPIO_OP_STREAM_PAUSE = 6,
    FS_BPIO_OP_STREAM_RESUME = 7,
    FS_BPIO_OP_GET_INFO = 8,
    FS_BPIO_OP_MAX_OPERATION,
}
