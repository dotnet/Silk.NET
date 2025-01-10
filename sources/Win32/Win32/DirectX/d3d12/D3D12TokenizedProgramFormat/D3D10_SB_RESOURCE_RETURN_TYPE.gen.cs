// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D10_SB_RESOURCE_RETURN_TYPE
{
    D3D10_SB_RETURN_TYPE_UNORM = 1,
    D3D10_SB_RETURN_TYPE_SNORM = 2,
    D3D10_SB_RETURN_TYPE_SINT = 3,
    D3D10_SB_RETURN_TYPE_UINT = 4,
    D3D10_SB_RETURN_TYPE_FLOAT = 5,
    D3D10_SB_RETURN_TYPE_MIXED = 6,
    D3D11_SB_RETURN_TYPE_DOUBLE = 7,
    D3D11_SB_RETURN_TYPE_CONTINUED = 8,
    D3D11_SB_RETURN_TYPE_UNUSED = 9,
}
