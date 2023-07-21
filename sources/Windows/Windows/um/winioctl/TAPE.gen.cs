// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class TAPE
{
    [NativeTypeName("#define TAPE_RETURN_STATISTICS 0L")]
    public const int TAPE_RETURN_STATISTICS = 0;

    [NativeTypeName("#define TAPE_RETURN_ENV_INFO 1L")]
    public const int TAPE_RETURN_ENV_INFO = 1;

    [NativeTypeName("#define TAPE_RESET_STATISTICS 2L")]
    public const int TAPE_RESET_STATISTICS = 2;
}
