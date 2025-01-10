// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_REFLECT_SHARED_PROPERTY
{
    D3D12_REFLECT_SHARED_PROPERTY_D3D11_RESOURCE_FLAGS = 0,
    D3D12_REFELCT_SHARED_PROPERTY_COMPATIBILITY_SHARED_FLAGS =
        (D3D12_REFLECT_SHARED_PROPERTY_D3D11_RESOURCE_FLAGS + 1),
    D3D12_REFLECT_SHARED_PROPERTY_NON_NT_SHARED_HANDLE =
        (D3D12_REFELCT_SHARED_PROPERTY_COMPATIBILITY_SHARED_FLAGS + 1),
}
