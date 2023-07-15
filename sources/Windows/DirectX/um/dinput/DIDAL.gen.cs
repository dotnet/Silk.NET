// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DIDAL
{
    [NativeTypeName("#define DIDAL_CENTERED 0x00000000")]
    public const int DIDAL_CENTERED = 0x00000000;
    [NativeTypeName("#define DIDAL_LEFTALIGNED 0x00000001")]
    public const int DIDAL_LEFTALIGNED = 0x00000001;
    [NativeTypeName("#define DIDAL_RIGHTALIGNED 0x00000002")]
    public const int DIDAL_RIGHTALIGNED = 0x00000002;
    [NativeTypeName("#define DIDAL_MIDDLE 0x00000000")]
    public const int DIDAL_MIDDLE = 0x00000000;
    [NativeTypeName("#define DIDAL_TOPALIGNED 0x00000004")]
    public const int DIDAL_TOPALIGNED = 0x00000004;
    [NativeTypeName("#define DIDAL_BOTTOMALIGNED 0x00000008")]
    public const int DIDAL_BOTTOMALIGNED = 0x00000008;
}