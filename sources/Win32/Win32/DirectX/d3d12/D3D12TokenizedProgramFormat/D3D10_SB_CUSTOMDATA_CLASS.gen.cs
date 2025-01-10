// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D10_SB_CUSTOMDATA_CLASS
{
    D3D10_SB_CUSTOMDATA_COMMENT = 0,
    D3D10_SB_CUSTOMDATA_DEBUGINFO,
    D3D10_SB_CUSTOMDATA_OPAQUE,
    D3D10_SB_CUSTOMDATA_DCL_IMMEDIATE_CONSTANT_BUFFER,
    D3D11_SB_CUSTOMDATA_SHADER_MESSAGE,
    D3D11_SB_CUSTOMDATA_SHADER_CLIP_PLANE_CONSTANT_MAPPINGS_FOR_DX9,
}
