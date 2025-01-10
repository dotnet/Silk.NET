// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D11_BLEND
{
    D3D11_BLEND_ZERO = 1,
    D3D11_BLEND_ONE = 2,
    D3D11_BLEND_SRC_COLOR = 3,
    D3D11_BLEND_INV_SRC_COLOR = 4,
    D3D11_BLEND_SRC_ALPHA = 5,
    D3D11_BLEND_INV_SRC_ALPHA = 6,
    D3D11_BLEND_DEST_ALPHA = 7,
    D3D11_BLEND_INV_DEST_ALPHA = 8,
    D3D11_BLEND_DEST_COLOR = 9,
    D3D11_BLEND_INV_DEST_COLOR = 10,
    D3D11_BLEND_SRC_ALPHA_SAT = 11,
    D3D11_BLEND_BLEND_FACTOR = 14,
    D3D11_BLEND_INV_BLEND_FACTOR = 15,
    D3D11_BLEND_SRC1_COLOR = 16,
    D3D11_BLEND_INV_SRC1_COLOR = 17,
    D3D11_BLEND_SRC1_ALPHA = 18,
    D3D11_BLEND_INV_SRC1_ALPHA = 19,
}
