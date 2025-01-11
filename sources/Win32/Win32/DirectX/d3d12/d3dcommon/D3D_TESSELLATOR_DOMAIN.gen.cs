// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D_TESSELLATOR_DOMAIN
{
    D3D_TESSELLATOR_DOMAIN_UNDEFINED = 0,
    D3D_TESSELLATOR_DOMAIN_ISOLINE = 1,
    D3D_TESSELLATOR_DOMAIN_TRI = 2,
    D3D_TESSELLATOR_DOMAIN_QUAD = 3,
    D3D11_TESSELLATOR_DOMAIN_UNDEFINED = D3D_TESSELLATOR_DOMAIN_UNDEFINED,
    D3D11_TESSELLATOR_DOMAIN_ISOLINE = D3D_TESSELLATOR_DOMAIN_ISOLINE,
    D3D11_TESSELLATOR_DOMAIN_TRI = D3D_TESSELLATOR_DOMAIN_TRI,
    D3D11_TESSELLATOR_DOMAIN_QUAD = D3D_TESSELLATOR_DOMAIN_QUAD,
}
