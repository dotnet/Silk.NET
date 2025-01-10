// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_STATIC_BORDER_COLOR
{
    D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK = 0,
    D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK = (D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK + 1),
    D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE = (D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK + 1),
    D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK_UINT = (D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE + 1),
    D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE_UINT = (D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK_UINT + 1),
}
