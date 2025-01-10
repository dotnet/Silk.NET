// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO
{
    public DXGI_FORMAT Format;
    public D3D12_RESOURCE_DIMENSION Dimension;
    public D3D12_HEAP_PROPERTIES DestHeapProperties;
    public BOOL Supported;
}
