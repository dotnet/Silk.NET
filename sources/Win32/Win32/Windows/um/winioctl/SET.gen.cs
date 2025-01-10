// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SET
{
    [NativeTypeName("#define SET_REPAIR_ENABLED (0x00000001)")]
    public const int SET_REPAIR_ENABLED = (0x00000001);

    [NativeTypeName("#define SET_REPAIR_WARN_ABOUT_DATA_LOSS (0x00000008)")]
    public const int SET_REPAIR_WARN_ABOUT_DATA_LOSS = (0x00000008);

    [NativeTypeName("#define SET_REPAIR_DISABLED_AND_BUGCHECK_ON_CORRUPT (0x00000010)")]
    public const int SET_REPAIR_DISABLED_AND_BUGCHECK_ON_CORRUPT = (0x00000010);

    [NativeTypeName("#define SET_REPAIR_VALID_MASK (0x00000019)")]
    public const int SET_REPAIR_VALID_MASK = (0x00000019);

    [NativeTypeName("#define SET_PURGE_FAILURE_MODE_ENABLED 0x00000001")]
    public const int SET_PURGE_FAILURE_MODE_ENABLED = 0x00000001;

    [NativeTypeName("#define SET_PURGE_FAILURE_MODE_DISABLED 0x00000002")]
    public const int SET_PURGE_FAILURE_MODE_DISABLED = 0x00000002;
}
