// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D_CBUFFER_TYPE
{
    D3D_CT_CBUFFER = 0,
    D3D_CT_TBUFFER = (D3D_CT_CBUFFER + 1),
    D3D_CT_INTERFACE_POINTERS = (D3D_CT_TBUFFER + 1),
    D3D_CT_RESOURCE_BIND_INFO = (D3D_CT_INTERFACE_POINTERS + 1),
    D3D10_CT_CBUFFER = D3D_CT_CBUFFER,
    D3D10_CT_TBUFFER = D3D_CT_TBUFFER,
    D3D11_CT_CBUFFER = D3D_CT_CBUFFER,
    D3D11_CT_TBUFFER = D3D_CT_TBUFFER,
    D3D11_CT_INTERFACE_POINTERS = D3D_CT_INTERFACE_POINTERS,
    D3D11_CT_RESOURCE_BIND_INFO = D3D_CT_RESOURCE_BIND_INFO,
}
