// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

public static partial class DIES
{
    [NativeTypeName("#define DIES_SOLO 0x00000001")]
    public const int DIES_SOLO = 0x00000001;

    [NativeTypeName("#define DIES_NODOWNLOAD 0x80000000")]
    public const uint DIES_NODOWNLOAD = 0x80000000;
}
