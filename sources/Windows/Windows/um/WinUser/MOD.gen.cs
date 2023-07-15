// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MOD
{
    [NativeTypeName("#define MOD_ALT 0x0001")]
    public const int MOD_ALT = 0x0001;
    [NativeTypeName("#define MOD_CONTROL 0x0002")]
    public const int MOD_CONTROL = 0x0002;
    [NativeTypeName("#define MOD_SHIFT 0x0004")]
    public const int MOD_SHIFT = 0x0004;
    [NativeTypeName("#define MOD_WIN 0x0008")]
    public const int MOD_WIN = 0x0008;
    [NativeTypeName("#define MOD_NOREPEAT 0x4000")]
    public const int MOD_NOREPEAT = 0x4000;
}