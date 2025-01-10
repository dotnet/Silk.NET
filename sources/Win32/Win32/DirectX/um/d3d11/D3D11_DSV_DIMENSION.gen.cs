// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D11_DSV_DIMENSION
{
    D3D11_DSV_DIMENSION_UNKNOWN = 0,
    D3D11_DSV_DIMENSION_TEXTURE1D = 1,
    D3D11_DSV_DIMENSION_TEXTURE1DARRAY = 2,
    D3D11_DSV_DIMENSION_TEXTURE2D = 3,
    D3D11_DSV_DIMENSION_TEXTURE2DARRAY = 4,
    D3D11_DSV_DIMENSION_TEXTURE2DMS = 5,
    D3D11_DSV_DIMENSION_TEXTURE2DMSARRAY = 6,
}
