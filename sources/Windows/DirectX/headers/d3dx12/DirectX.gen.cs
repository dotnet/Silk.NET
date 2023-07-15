// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D3D12_FEATURE;
using static TerraFX.Interop.DirectX.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.DirectX.D3D12_TEXTURE_LAYOUT;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12CalcSubresource"]/*'/>
    public static uint D3D12CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice, uint MipLevels, uint ArraySize)
    {
        return MipSlice + ArraySlice * MipLevels + PlaneSlice * MipLevels * ArraySize;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12GetFormatPlaneCount"]/*'/>
    [return: NativeTypeName("UINT8")]
    public static byte D3D12GetFormatPlaneCount(ID3D12Device* pDevice, DXGI_FORMAT Format)
    {
        D3D12_FEATURE_DATA_FORMAT_INFO formatInfo = new D3D12_FEATURE_DATA_FORMAT_INFO
        {
            Format = Format,
            PlaneCount = 0,
        };
        if ((((HRESULT)(pDevice->CheckFeatureSupport(D3D12_FEATURE_FORMAT_INFO, &formatInfo, (uint)(sizeof(D3D12_FEATURE_DATA_FORMAT_INFO))))) < 0))
        {
            return 0;
        }

        return formatInfo.PlaneCount;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.MemcpySubresource"]/*'/>
    public static void MemcpySubresource([NativeTypeName("const D3D12_MEMCPY_DEST *")] D3D12_MEMCPY_DEST* pDest, [NativeTypeName("const void *")] void* pResourceData, [NativeTypeName("const D3D12_SUBRESOURCE_INFO *")] D3D12_SUBRESOURCE_INFO* pSrc, [NativeTypeName("SIZE_T")] nuint RowSizeInBytes, uint NumRows, uint NumSlices)
    {
        for (uint z = 0; z < NumSlices; ++z)
        {
            byte* pDestSlice = (byte*)(pDest->pData) + pDest->SlicePitch * z;
            byte* pSrcSlice = ((byte*)(pResourceData) + pSrc->Offset) + pSrc->DepthPitch * (nuint)(z);
            for (uint y = 0; y < NumRows; ++y)
            {
                Unsafe.CopyBlockUnaligned(pDestSlice + pDest->RowPitch * y, pSrcSlice + pSrc->RowPitch * (nuint)(y), RowSizeInBytes);
            }
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.UpdateSubresources"]/*'/>
    [return: NativeTypeName("UINT64")]
    public static ulong UpdateSubresources(ID3D12GraphicsCommandList* pCmdList, ID3D12Resource* pDestinationResource, ID3D12Resource* pIntermediate, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong RequiredSize, [NativeTypeName("const D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("const UINT *")] uint* pNumRows, [NativeTypeName("const UINT64 *")] ulong* pRowSizesInBytes, [NativeTypeName("const D3D12_SUBRESOURCE_DATA *")] D3D12_SUBRESOURCE_DATA* pSrcData)
    {
        D3D12_RESOURCE_DESC IntermediateDesc = pIntermediate->GetDesc();
        D3D12_RESOURCE_DESC DestinationDesc = pDestinationResource->GetDesc();
        if (unchecked(IntermediateDesc.Dimension != D3D12_RESOURCE_DIMENSION_BUFFER || IntermediateDesc.Width < RequiredSize + pLayouts[0].Offset || RequiredSize > (nuint)(-1)) || (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER && (FirstSubresource != 0 || NumSubresources != 1)))
        {
            return 0;
        }

        byte* pData;
        HRESULT hr = pIntermediate->Map(0, null, (void**)(&pData));
        if ((((HRESULT)(hr)) < 0))
        {
            return 0;
        }

        for (uint i = 0; i < NumSubresources; ++i)
        {
            if (pRowSizesInBytes[i] > unchecked((nuint)(-1)))
            {
                return 0;
            }

            D3D12_MEMCPY_DEST DestData = new D3D12_MEMCPY_DEST
            {
                pData = pData + pLayouts[i].Offset,
                RowPitch = pLayouts[i].Footprint.RowPitch,
                SlicePitch = unchecked((nuint)(pLayouts[i].Footprint.RowPitch) * (nuint)(pNumRows[i])),
            };
            MemcpySubresource(&DestData, &pSrcData[i], unchecked((nuint)(pRowSizesInBytes[i])), pNumRows[i], pLayouts[i].Footprint.Depth);
        }

        pIntermediate->Unmap(0, null);
        if (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
        {
            pCmdList->CopyBufferRegion(pDestinationResource, 0, pIntermediate, pLayouts[0].Offset, pLayouts[0].Footprint.Width);
        }
        else
        {
            for (uint i = 0; i < NumSubresources; ++i)
            {
                D3D12_TEXTURE_COPY_LOCATION Dst = new D3D12_TEXTURE_COPY_LOCATION(pDestinationResource, i + FirstSubresource);
                D3D12_TEXTURE_COPY_LOCATION Src = new D3D12_TEXTURE_COPY_LOCATION(pIntermediate, pLayouts[i]);
                pCmdList->CopyTextureRegion(&Dst, 0, 0, 0, &Src, null);
            }
        }

        return RequiredSize;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.UpdateSubresources"]/*'/>
    [return: NativeTypeName("UINT64")]
    public static ulong UpdateSubresources(ID3D12GraphicsCommandList* pCmdList, ID3D12Resource* pDestinationResource, ID3D12Resource* pIntermediate, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong RequiredSize, [NativeTypeName("const D3D12_PLACED_SUBRESOURCE_FOOTPRINT *")] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, [NativeTypeName("const UINT *")] uint* pNumRows, [NativeTypeName("const UINT64 *")] ulong* pRowSizesInBytes, [NativeTypeName("const void *")] void* pResourceData, [NativeTypeName("const D3D12_SUBRESOURCE_INFO *")] D3D12_SUBRESOURCE_INFO* pSrcData)
    {
        D3D12_RESOURCE_DESC IntermediateDesc = pIntermediate->GetDesc();
        D3D12_RESOURCE_DESC DestinationDesc = pDestinationResource->GetDesc();
        if (unchecked(IntermediateDesc.Dimension != D3D12_RESOURCE_DIMENSION_BUFFER || IntermediateDesc.Width < RequiredSize + pLayouts[0].Offset || RequiredSize > (nuint)(-1)) || (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER && (FirstSubresource != 0 || NumSubresources != 1)))
        {
            return 0;
        }

        byte* pData;
        HRESULT hr = pIntermediate->Map(0, null, (void**)(&pData));
        if ((((HRESULT)(hr)) < 0))
        {
            return 0;
        }

        for (uint i = 0; i < NumSubresources; ++i)
        {
            if (pRowSizesInBytes[i] > unchecked((nuint)(-1)))
            {
                return 0;
            }

            D3D12_MEMCPY_DEST DestData = new D3D12_MEMCPY_DEST
            {
                pData = pData + pLayouts[i].Offset,
                RowPitch = pLayouts[i].Footprint.RowPitch,
                SlicePitch = unchecked((nuint)(pLayouts[i].Footprint.RowPitch) * (nuint)(pNumRows[i])),
            };
            MemcpySubresource(&DestData, pResourceData, &pSrcData[i], unchecked((nuint)(pRowSizesInBytes[i])), pNumRows[i], pLayouts[i].Footprint.Depth);
        }

        pIntermediate->Unmap(0, null);
        if (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
        {
            pCmdList->CopyBufferRegion(pDestinationResource, 0, pIntermediate, pLayouts[0].Offset, pLayouts[0].Footprint.Width);
        }
        else
        {
            for (uint i = 0; i < NumSubresources; ++i)
            {
                D3D12_TEXTURE_COPY_LOCATION Dst = new D3D12_TEXTURE_COPY_LOCATION(pDestinationResource, i + FirstSubresource);
                D3D12_TEXTURE_COPY_LOCATION Src = new D3D12_TEXTURE_COPY_LOCATION(pIntermediate, pLayouts[i]);
                pCmdList->CopyTextureRegion(&Dst, 0, 0, 0, &Src, null);
            }
        }

        return RequiredSize;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.UpdateSubresources"]/*'/>
    [return: NativeTypeName("UINT64")]
    public static ulong UpdateSubresources(ID3D12GraphicsCommandList* pCmdList, ID3D12Resource* pDestinationResource, ID3D12Resource* pIntermediate, [NativeTypeName("UINT64")] ulong IntermediateOffset, uint FirstSubresource, uint NumSubresources, [NativeTypeName("const void *")] void* pResourceData, [NativeTypeName("const D3D12_SUBRESOURCE_INFO *")] D3D12_SUBRESOURCE_INFO* pSrcData)
    {
        ulong RequiredSize = 0;
        ulong MemToAlloc = (ulong)(32 + 4 + 8) * NumSubresources;
        if (unchecked(MemToAlloc) > 0xffffffffffffffffUL)
        {
            return 0;
        }

        void* pMem = HeapAlloc(GetProcessHeap(), 0, (nuint)(MemToAlloc));
        if (pMem == null)
        {
            return 0;
        }

        D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts = (D3D12_PLACED_SUBRESOURCE_FOOTPRINT*)(pMem);
        ulong* pRowSizesInBytes = (ulong*)(pLayouts + NumSubresources);
        uint* pNumRows = (uint*)(pRowSizesInBytes + NumSubresources);
        D3D12_RESOURCE_DESC Desc = pDestinationResource->GetDesc();
        ID3D12Device* pDevice = null;
        _ = pDestinationResource->GetDevice(&IID_ID3D12Device, (void**)(&pDevice));
        pDevice->GetCopyableFootprints(&Desc, FirstSubresource, NumSubresources, IntermediateOffset, unchecked(pLayouts), unchecked(pNumRows), unchecked(pRowSizesInBytes), &RequiredSize);
        _ = pDevice->Release();
        ulong Result = UpdateSubresources(pCmdList, pDestinationResource, pIntermediate, FirstSubresource, NumSubresources, RequiredSize, pLayouts, pNumRows, pRowSizesInBytes, pResourceData, pSrcData);
        _ = HeapFree(GetProcessHeap(), 0, pMem);
        return Result;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12IsLayoutOpaque"]/*'/>
    public static bool D3D12IsLayoutOpaque(D3D12_TEXTURE_LAYOUT Layout)
    {
        return Layout == D3D12_TEXTURE_LAYOUT_UNKNOWN || Layout == D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE;
    }
}