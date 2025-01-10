// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D_FORMAT_COMPONENT_INTERPRETATION
{
    D3DFCI_TYPELESS = 0,
    D3DFCI_FLOAT = -4,
    D3DFCI_SNORM = -3,
    D3DFCI_UNORM = -2,
    D3DFCI_SINT = -1,
    D3DFCI_UINT = 1,
    D3DFCI_UNORM_SRGB = 2,
    D3DFCI_BIASED_FIXED_2_8 = 3,
}
