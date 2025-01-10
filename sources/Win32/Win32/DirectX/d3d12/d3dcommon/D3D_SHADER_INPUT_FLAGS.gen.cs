// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D_SHADER_INPUT_FLAGS
{
    D3D_SIF_USERPACKED = 0x1,
    D3D_SIF_COMPARISON_SAMPLER = 0x2,
    D3D_SIF_TEXTURE_COMPONENT_0 = 0x4,
    D3D_SIF_TEXTURE_COMPONENT_1 = 0x8,
    D3D_SIF_TEXTURE_COMPONENTS = 0xc,
    D3D_SIF_UNUSED = 0x10,
    D3D10_SIF_USERPACKED = D3D_SIF_USERPACKED,
    D3D10_SIF_COMPARISON_SAMPLER = D3D_SIF_COMPARISON_SAMPLER,
    D3D10_SIF_TEXTURE_COMPONENT_0 = D3D_SIF_TEXTURE_COMPONENT_0,
    D3D10_SIF_TEXTURE_COMPONENT_1 = D3D_SIF_TEXTURE_COMPONENT_1,
    D3D10_SIF_TEXTURE_COMPONENTS = D3D_SIF_TEXTURE_COMPONENTS,
    D3D_SIF_FORCE_DWORD = 0x7fffffff,
}
