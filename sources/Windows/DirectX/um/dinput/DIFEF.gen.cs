// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DIFEF
{
    [NativeTypeName("#define DIFEF_DEFAULT 0x00000000")]
    public const int DIFEF_DEFAULT = 0x00000000;
    [NativeTypeName("#define DIFEF_INCLUDENONSTANDARD 0x00000001")]
    public const int DIFEF_INCLUDENONSTANDARD = 0x00000001;
    [NativeTypeName("#define DIFEF_MODIFYIFNEEDED 0x00000010")]
    public const int DIFEF_MODIFYIFNEEDED = 0x00000010;
}