// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DDEDM
{
    [NativeTypeName("#define DDEDM_REFRESHRATES 0x00000001l")]
    public const int DDEDM_REFRESHRATES = 0x00000001;
    [NativeTypeName("#define DDEDM_STANDARDVGAMODES 0x00000002L")]
    public const int DDEDM_STANDARDVGAMODES = 0x00000002;
}