// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_resource_helpers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D3D12_TEXTURE_LAYOUT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static void MemcpySubresource(
        [NativeTypeName("const D3D12_MEMCPY_DEST *")] D3D12_MEMCPY_DEST* pDest,
        [NativeTypeName("const D3D12_SUBRESOURCE_DATA *")] D3D12_SUBRESOURCE_DATA* pSrc,
        [NativeTypeName("SIZE_T")] nuint RowSizeInBytes,
        uint NumRows,
        uint NumSlices
    )
    {
        for (uint z = 0; z < NumSlices; ++z)
        {
            byte* pDestSlice = (byte*)(pDest->pData) + pDest->SlicePitch * z;
            byte* pSrcSlice = unchecked((byte*)(pSrc->pData) + pSrc->SlicePitch * (nint)(z));
            for (uint y = 0; y < NumRows; ++y)
            {
                NativeMemory.Copy(
                    unchecked(pSrcSlice + pSrc->RowPitch * (nint)(y)),
                    pDestSlice + pDest->RowPitch * y,
                    RowSizeInBytes
                );
            }
        }
    }

    public static void MemcpySubresource(
        [NativeTypeName("const D3D12_MEMCPY_DEST *")] D3D12_MEMCPY_DEST* pDest,
        [NativeTypeName("const void *")] void* pResourceData,
        [NativeTypeName("const D3D12_SUBRESOURCE_INFO *")] D3D12_SUBRESOURCE_INFO* pSrc,
        [NativeTypeName("SIZE_T")] nuint RowSizeInBytes,
        uint NumRows,
        uint NumSlices
    )
    {
        for (uint z = 0; z < NumSlices; ++z)
        {
            byte* pDestSlice = (byte*)(pDest->pData) + pDest->SlicePitch * z;
            byte* pSrcSlice =
                ((byte*)(pResourceData) + pSrc->Offset) + pSrc->DepthPitch * (nuint)(z);
            for (uint y = 0; y < NumRows; ++y)
            {
                NativeMemory.Copy(
                    pSrcSlice + pSrc->RowPitch * (nuint)(y),
                    pDestSlice + pDest->RowPitch * y,
                    RowSizeInBytes
                );
            }
        }
    }

    public static bool D3D12IsLayoutOpaque(D3D12_TEXTURE_LAYOUT Layout)
    {
        return Layout == D3D12_TEXTURE_LAYOUT_UNKNOWN
            || Layout == D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE;
    }

    public static bool D3DX12GetCopyableFootprints(
        [NativeTypeName("const D3D12_RESOURCE_DESC &")] D3D12_RESOURCE_DESC* pResourceDesc,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("UINT64")] ulong BaseOffset,
        D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts,
        uint* pNumRows,
        [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes,
        [NativeTypeName("UINT64 *")] ulong* pTotalBytes
    )
    {
        D3D12_RESOURCE_DESC1 desc = D3DX12ResourceDesc0ToDesc1(pResourceDesc);
        return D3DX12GetCopyableFootprints(
            unchecked((D3D12_RESOURCE_DESC1*)(&desc)),
            FirstSubresource,
            NumSubresources,
            BaseOffset,
            pLayouts,
            pNumRows,
            pRowSizeInBytes,
            pTotalBytes
        );
    }
}
