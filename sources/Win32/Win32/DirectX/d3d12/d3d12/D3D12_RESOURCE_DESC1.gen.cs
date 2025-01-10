// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_RESOURCE_DESC1
{
    public D3D12_RESOURCE_DIMENSION Dimension;

    [NativeTypeName("UINT64")]
    public ulong Alignment;

    [NativeTypeName("UINT64")]
    public ulong Width;
    public uint Height;

    [NativeTypeName("UINT16")]
    public ushort DepthOrArraySize;

    [NativeTypeName("UINT16")]
    public ushort MipLevels;
    public DXGI_FORMAT Format;
    public DXGI_SAMPLE_DESC SampleDesc;
    public D3D12_TEXTURE_LAYOUT Layout;
    public D3D12_RESOURCE_FLAGS Flags;
    public D3D12_MIP_REGION SamplerFeedbackMipRegion;
}
