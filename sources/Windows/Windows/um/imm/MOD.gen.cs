// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MOD
{
    [NativeTypeName("#define MOD_LEFT 0x8000")]
    public const int MOD_LEFT = 0x8000;
    [NativeTypeName("#define MOD_RIGHT 0x4000")]
    public const int MOD_RIGHT = 0x4000;
    [NativeTypeName("#define MOD_ON_KEYUP 0x0800")]
    public const int MOD_ON_KEYUP = 0x0800;
    [NativeTypeName("#define MOD_IGNORE_ALL_MODIFIER 0x0400")]
    public const int MOD_IGNORE_ALL_MODIFIER = 0x0400;
}