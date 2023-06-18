// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12Device9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Device9> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12Device9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12Device9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12Device9> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12Device9> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12Device9> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNodeCount(this ComPtr<ID3D12Device9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, Guid* riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riid, ppCommandQueue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandAllocator(this ComPtr<ID3D12Device9> thisVtbl, CommandListType type, Guid* riid, void** ppCommandAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riid, ppCommandAllocator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGraphicsPipelineState(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateComputePipelineState(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID3D12Device9> thisVtbl, uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckFeatureSupport(this ComPtr<ID3D12Device9> thisVtbl, Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, Feature, void*, uint, int>)@this->LpVtbl[13])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDescriptorHeap(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetDescriptorHandleIncrementSize(this ComPtr<ID3D12Device9> thisVtbl, DescriptorHeapType DescriptorHeapType)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, DescriptorHeapType, uint>)@this->LpVtbl[15])(@this, DescriptorHeapType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRootSignature(this ComPtr<ID3D12Device9> thisVtbl, uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateConstantBufferView(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConstantBufferViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[17])(@this, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateShaderResourceView(this ComPtr<ID3D12Device9> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateUnorderedAccessView(this ComPtr<ID3D12Device9> thisVtbl, ID3D12Resource* pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateRenderTargetView(this ComPtr<ID3D12Device9> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateDepthStencilView(this ComPtr<ID3D12Device9> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResource, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateSampler(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerDesc* pDesc, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, SamplerDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[22])(@this, pDesc, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyDescriptors(this ComPtr<ID3D12Device9> thisVtbl, uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static void CopyDescriptorsSimple(this ComPtr<ID3D12Device9> thisVtbl, uint NumDescriptors, CpuDescriptorHandle DestDescriptorRangeStart, CpuDescriptorHandle SrcDescriptorRangeStart, DescriptorHeapType DescriptorHeapsType)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint, CpuDescriptorHandle, CpuDescriptorHandle, DescriptorHeapType, void>)@this->LpVtbl[24])(@this, NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo(this ComPtr<ID3D12Device9> thisVtbl, uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDescs)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)@this->LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static HeapProperties GetCustomHeapProperties(this ComPtr<ID3D12Device9> thisVtbl, uint nodeMask, HeapType heapType)
    {
        var @this = thisVtbl.Handle;
        HeapProperties silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        HeapProperties* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, HeapProperties*, uint, HeapType, HeapProperties*>)@this->LpVtbl[26])(@this, pSilkDotNetReturnFixupResult, nodeMask, heapType);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource(this ComPtr<ID3D12Device9> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedHandle(this ComPtr<ID3D12Device9> thisVtbl, ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandle(this ComPtr<ID3D12Device9> thisVtbl, void* NTHandle, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riid, ppvObj);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenSharedHandleByName(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, uint Access, void** pNTHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, Name, Access, pNTHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MakeResident(this ComPtr<ID3D12Device9> thisVtbl, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint, ID3D12Pageable**, int>)@this->LpVtbl[34])(@this, NumObjects, ppObjects);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Evict(this ComPtr<ID3D12Device9> thisVtbl, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint, ID3D12Pageable**, int>)@this->LpVtbl[35])(@this, NumObjects, ppObjects);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFence(this ComPtr<ID3D12Device9> thisVtbl, ulong InitialValue, FenceFlags Flags, Guid* riid, void** ppFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riid, ppFence);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceRemovedReason(this ComPtr<ID3D12Device9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, int>)@this->LpVtbl[37])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueryHeap(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStablePowerState(this ComPtr<ID3D12Device9> thisVtbl, Silk.NET.Core.Bool32 Enable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[40])(@this, Enable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandSignature(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignature);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetResourceTiling(this ComPtr<ID3D12Device9> thisVtbl, ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <summary>To be documented.</summary>
    public static Luid GetAdapterLuid(this ComPtr<ID3D12Device9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Luid silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Luid* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, Luid*, Luid*>)@this->LpVtbl[43])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineLibrary(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEventOnMultipleFenceCompletion(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Fence** ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValues, NumFences, Flags, hEvent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetResidencyPriority(this ComPtr<ID3D12Device9> thisVtbl, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResidencyPriority* pPriorities)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjects, pPriorities);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePipelineState(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riid, ppPipelineState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromAddress(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pAddress, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenExistingHeapFromFileMapping(this ComPtr<ID3D12Device9> thisVtbl, void* hFileMapping, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueMakeResident(this ComPtr<ID3D12Device9> thisVtbl, ResidencyFlags Flags, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects, ID3D12Fence* pFenceToSignal, ulong FenceValueToSignal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList1(this ComPtr<ID3D12Device9> thisVtbl, uint nodeMask, CommandListType type, CommandListFlags flags, Guid* riid, void** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riid, ppCommandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProtectedResourceSessionDesc* pDesc, Guid* riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riid, ppSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource1(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHeap1(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvHeap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riid, ppvHeap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateReservedResource1(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo1(this ComPtr<ID3D12Device9> thisVtbl, uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLifetimeTracker(this ComPtr<ID3D12Device9> thisVtbl, ID3D12LifetimeOwner* pOwner, Guid* riid, void** ppvTracker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riid, ppvTracker);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void RemoveDevice(this ComPtr<ID3D12Device9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, void>)@this->LpVtbl[58])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommands(this ComPtr<ID3D12Device9> thisVtbl, uint* pNumMetaCommands, MetaCommandDesc* pDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommands, pDescs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumerateMetaCommandParameters(this ComPtr<ID3D12Device9> thisVtbl, Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMetaCommand(this ComPtr<ID3D12Device9> thisVtbl, Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateObject(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, Guid* riid, void** ppStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riid, ppStateObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRaytracingAccelerationStructurePrebuildInfo(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BuildRaytracingAccelerationStructureInputs* pDesc, RaytracingAccelerationStructurePrebuildInfo* pInfo)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDesc, pInfo);
    }

    /// <summary>To be documented.</summary>
    public static unsafe DriverMatchingIdentifierStatus CheckDriverMatchingIdentifier(this ComPtr<ID3D12Device9> thisVtbl, SerializedDataType SerializedDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SerializedDataDriverMatchingIdentifier* pIdentifierToCheck)
    {
        var @this = thisVtbl.Handle;
        DriverMatchingIdentifierStatus ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, SerializedDataType, SerializedDataDriverMatchingIdentifier*, DriverMatchingIdentifierStatus>)@this->LpVtbl[64])(@this, SerializedDataType, pIdentifierToCheck);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBackgroundProcessingMode(this ComPtr<ID3D12Device9> thisVtbl, BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, void* hEventToSignalUponCompletion, int* pbFurtherMeasurementsDesired)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesired);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddToStateObject(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ID3D12StateObject* pStateObjectToGrowFrom, Guid* riid, void** ppNewStateObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, StateObjectDesc*, ID3D12StateObject*, Guid*, void**, int>)@this->LpVtbl[66])(@this, pAddition, pStateObjectToGrowFrom, riid, ppNewStateObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateProtectedResourceSession1(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProtectedResourceSessionDesc1* pDesc, Guid* riid, void** ppSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ProtectedResourceSessionDesc1*, Guid*, void**, int>)@this->LpVtbl[67])(@this, pDesc, riid, ppSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ResourceAllocationInfo GetResourceAllocationInfo2(this ComPtr<ID3D12Device9> thisVtbl, uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc1* pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
    {
        var @this = thisVtbl.Handle;
        ResourceAllocationInfo silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        ResourceAllocationInfo* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ResourceAllocationInfo*, uint, uint, ResourceDesc1*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[68])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommittedResource2(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc1* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, HeapProperties*, HeapFlags, ResourceDesc1*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[69])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePlacedResource1(this ComPtr<ID3D12Device9> thisVtbl, ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc1* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12Heap*, ulong, ResourceDesc1*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[70])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CreateSamplerFeedbackUnorderedAccessView(this ComPtr<ID3D12Device9> thisVtbl, ID3D12Resource* pTargetedResource, ID3D12Resource* pFeedbackResource, CpuDescriptorHandle DestDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ID3D12Resource*, ID3D12Resource*, CpuDescriptorHandle, void>)@this->LpVtbl[71])(@this, pTargetedResource, pFeedbackResource, DestDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCopyableFootprints1(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc1* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ResourceDesc1*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[72])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShaderCacheSession(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderCacheSessionDesc* pDesc, Guid* riid, void** ppvSession)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ShaderCacheSessionDesc*, Guid*, void**, int>)@this->LpVtbl[73])(@this, pDesc, riid, ppvSession);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ShaderCacheControl(this ComPtr<ID3D12Device9> thisVtbl, ShaderCacheKindFlags Kinds, ShaderCacheControlFlags Control)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, ShaderCacheKindFlags, ShaderCacheControlFlags, int>)@this->LpVtbl[74])(@this, Kinds, Control);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandQueue1(this ComPtr<ID3D12Device9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, Guid* CreatorID, Guid* riid, void** ppCommandQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device9*, CommandQueueDesc*, Guid*, Guid*, void**, int>)@this->LpVtbl[75])(@this, pDesc, CreatorID, riid, ppCommandQueue);
        return ret;
    }

}
