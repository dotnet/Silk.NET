// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D_SHADER_MODEL
{
    D3D_SHADER_MODEL_NONE = 0,
    D3D_SHADER_MODEL_5_1 = 0x51,
    D3D_SHADER_MODEL_6_0 = 0x60,
    D3D_SHADER_MODEL_6_1 = 0x61,
    D3D_SHADER_MODEL_6_2 = 0x62,
    D3D_SHADER_MODEL_6_3 = 0x63,
    D3D_SHADER_MODEL_6_4 = 0x64,
    D3D_SHADER_MODEL_6_5 = 0x65,
    D3D_SHADER_MODEL_6_6 = 0x66,
    D3D_SHADER_MODEL_6_7 = 0x67,
    D3D_SHADER_MODEL_6_8 = 0x68,
    D3D_SHADER_MODEL_6_9 = 0x69,
    D3D_HIGHEST_SHADER_MODEL = D3D_SHADER_MODEL_6_9,
}
