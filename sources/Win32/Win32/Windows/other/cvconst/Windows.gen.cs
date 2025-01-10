// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    public const int NAMEHASH_BUILD_START = 0;
    public const int NAMEHASH_BUILD_PAUSE = 1;
    public const int NAMEHASH_BUILD_RESUME = 2;
    public const int NAMEHASH_BUILD_COMPLETE = 3;
    public const int NAMEHASH_BUILD_ERROR = 4;
    public const int NAMEHASH_BUILD_OOM = NAMEHASH_BUILD_ERROR;
    public const int NAMEHASH_BUILD_FAIL_TO_OPEN_MOD = 5;
}
