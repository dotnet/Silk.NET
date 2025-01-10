// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using static Silk.NET.DirectX.D3D12_RESOURCE_DIMENSION;
using static Silk.NET.DirectX.D3D12_RESOURCE_FLAGS;
using static Silk.NET.DirectX.D3D12_TEXTURE_LAYOUT;
using static Silk.NET.DirectX.DirectX;
using static Silk.NET.DirectX.DXGI_FORMAT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("struct CD3DX12_RESOURCE_DESC : D3D12_RESOURCE_DESC")]
[NativeInheritance("D3D12_RESOURCE_DESC")]
public unsafe partial struct D3D12_RESOURCE_DESC
{
    public D3D12_RESOURCE_DESC(
        D3D12_RESOURCE_DIMENSION dimension,
        [NativeTypeName("UINT64")] ulong alignment,
        [NativeTypeName("UINT64")] ulong width,
        uint height,
        [NativeTypeName("UINT16")] ushort depthOrArraySize,
        [NativeTypeName("UINT16")] ushort mipLevels,
        DXGI_FORMAT format,
        uint sampleCount,
        uint sampleQuality,
        D3D12_TEXTURE_LAYOUT layout,
        D3D12_RESOURCE_FLAGS flags
    )
    {
        Dimension = dimension;
        Alignment = alignment;
        Width = width;
        Height = height;
        DepthOrArraySize = depthOrArraySize;
        MipLevels = mipLevels;
        Format = format;
        SampleDesc.Count = sampleCount;
        SampleDesc.Quality = sampleQuality;
        Layout = layout;
        Flags = flags;
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC")]
    public static D3D12_RESOURCE_DESC Buffer(
        [NativeTypeName("const D3D12_RESOURCE_ALLOCATION_INFO &")]
            D3D12_RESOURCE_ALLOCATION_INFO* resAllocInfo,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE
    )
    {
        return new D3D12_RESOURCE_DESC(
            D3D12_RESOURCE_DIMENSION_BUFFER,
            resAllocInfo->Alignment,
            resAllocInfo->SizeInBytes,
            1,
            1,
            1,
            DXGI_FORMAT_UNKNOWN,
            1,
            0,
            D3D12_TEXTURE_LAYOUT_ROW_MAJOR,
            flags
        );
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC")]
    public static D3D12_RESOURCE_DESC Buffer(
        [NativeTypeName("UINT64")] ulong width,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        [NativeTypeName("UINT64")] ulong alignment = 0
    )
    {
        return new D3D12_RESOURCE_DESC(
            D3D12_RESOURCE_DIMENSION_BUFFER,
            alignment,
            width,
            1,
            1,
            1,
            DXGI_FORMAT_UNKNOWN,
            1,
            0,
            D3D12_TEXTURE_LAYOUT_ROW_MAJOR,
            flags
        );
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC")]
    public static D3D12_RESOURCE_DESC Tex1D(
        DXGI_FORMAT format,
        [NativeTypeName("UINT64")] ulong width,
        [NativeTypeName("UINT16")] ushort arraySize = 1,
        [NativeTypeName("UINT16")] ushort mipLevels = 0,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN,
        [NativeTypeName("UINT64")] ulong alignment = 0
    )
    {
        return new D3D12_RESOURCE_DESC(
            D3D12_RESOURCE_DIMENSION_TEXTURE1D,
            alignment,
            width,
            1,
            arraySize,
            mipLevels,
            format,
            1,
            0,
            layout,
            flags
        );
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC")]
    public static D3D12_RESOURCE_DESC Tex2D(
        DXGI_FORMAT format,
        [NativeTypeName("UINT64")] ulong width,
        uint height,
        [NativeTypeName("UINT16")] ushort arraySize = 1,
        [NativeTypeName("UINT16")] ushort mipLevels = 0,
        uint sampleCount = 1,
        uint sampleQuality = 0,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN,
        [NativeTypeName("UINT64")] ulong alignment = 0
    )
    {
        return new D3D12_RESOURCE_DESC(
            D3D12_RESOURCE_DIMENSION_TEXTURE2D,
            alignment,
            width,
            height,
            arraySize,
            mipLevels,
            format,
            sampleCount,
            sampleQuality,
            layout,
            flags
        );
    }

    [return: NativeTypeName("CD3DX12_RESOURCE_DESC")]
    public static D3D12_RESOURCE_DESC Tex3D(
        DXGI_FORMAT format,
        [NativeTypeName("UINT64")] ulong width,
        uint height,
        [NativeTypeName("UINT16")] ushort depth,
        [NativeTypeName("UINT16")] ushort mipLevels = 0,
        D3D12_RESOURCE_FLAGS flags = D3D12_RESOURCE_FLAG_NONE,
        D3D12_TEXTURE_LAYOUT layout = D3D12_TEXTURE_LAYOUT_UNKNOWN,
        [NativeTypeName("UINT64")] ulong alignment = 0
    )
    {
        return new D3D12_RESOURCE_DESC(
            D3D12_RESOURCE_DIMENSION_TEXTURE3D,
            alignment,
            width,
            height,
            depth,
            mipLevels,
            format,
            1,
            0,
            layout,
            flags
        );
    }

    [return: NativeTypeName("UINT8")]
    public byte PlaneCount(ID3D12Device pDevice)
    {
        return D3D12GetFormatPlaneCount(pDevice, Format);
    }

    public uint Subresources(ID3D12Device pDevice)
    {
        return (uint)(MipLevels) * ArraySize() * PlaneCount(pDevice);
    }

    public uint CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice)
    {
        return D3D12CalcSubresource(MipSlice, ArraySlice, PlaneSlice, MipLevels, ArraySize());
    }
}
