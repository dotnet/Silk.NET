// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DDOVERFX
{
    [NativeTypeName("#define DDOVERFX_ARITHSTRETCHY 0x00000001l")]
    public const int DDOVERFX_ARITHSTRETCHY = 0x00000001;
    [NativeTypeName("#define DDOVERFX_MIRRORLEFTRIGHT 0x00000002l")]
    public const int DDOVERFX_MIRRORLEFTRIGHT = 0x00000002;
    [NativeTypeName("#define DDOVERFX_MIRRORUPDOWN 0x00000004l")]
    public const int DDOVERFX_MIRRORUPDOWN = 0x00000004;
    [NativeTypeName("#define DDOVERFX_DEINTERLACE 0x00000008l")]
    public const int DDOVERFX_DEINTERLACE = 0x00000008;
}