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

public unsafe static class D3D12GraphicsCommandList2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CommandListType GetType(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CommandListType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, CommandListType>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)@this->LpVtbl[10])(@this, pAllocator, pInitialState);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearState(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12PipelineState* pPipelineState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12PipelineState*, void>)@this->LpVtbl[11])(@this, pPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstanced(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, uint, uint, void>)@this->LpVtbl[12])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstanced(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, uint, int, uint, void>)@this->LpVtbl[13])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static void Dispatch(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, uint, void>)@this->LpVtbl[14])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyBufferRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)@this->LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTextureRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureCopyLocation* pSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)@this->LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ID3D12Resource*, void>)@this->LpVtbl[17])(@this, pDstResource, pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTiles(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pTiledResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pTileRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)@this->LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static void IASetPrimitiveTopology(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, Silk.NET.Core.Native.D3DPrimitiveTopology PrimitiveTopology)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)@this->LpVtbl[20])(@this, PrimitiveTopology);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetViewports(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumViewports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport* pViewports)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, Viewport*, void>)@this->LpVtbl[21])(@this, NumViewports, pViewports);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetScissorRects(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[22])(@this, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendFactor(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, [Count(Count = 4)] float* BlendFactor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, float*, void>)@this->LpVtbl[23])(@this, BlendFactor);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetStencilRef(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint StencilRef)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, void>)@this->LpVtbl[24])(@this, StencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPipelineState(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12PipelineState* pPipelineState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12PipelineState*, void>)@this->LpVtbl[25])(@this, pPipelineState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResourceBarrier(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumBarriers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceBarrier* pBarriers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ResourceBarrier*, void>)@this->LpVtbl[26])(@this, NumBarriers, pBarriers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteBundle(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12GraphicsCommandList* pCommandList)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12GraphicsCommandList*, void>)@this->LpVtbl[27])(@this, pCommandList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetDescriptorHeaps(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumDescriptorHeaps, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12DescriptorHeap** ppDescriptorHeaps)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ID3D12DescriptorHeap**, void>)@this->LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeaps);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetComputeRootSignature(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12RootSignature* pRootSignature)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12RootSignature*, void>)@this->LpVtbl[29])(@this, pRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetGraphicsRootSignature(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12RootSignature* pRootSignature)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12RootSignature*, void>)@this->LpVtbl[30])(@this, pRootSignature);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootDescriptorTable(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, GpuDescriptorHandle, void>)@this->LpVtbl[31])(@this, RootParameterIndex, BaseDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootDescriptorTable(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, GpuDescriptorHandle, void>)@this->LpVtbl[32])(@this, RootParameterIndex, BaseDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRoot32BitConstant(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, uint, void>)@this->LpVtbl[33])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRoot32BitConstant(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, uint, void>)@this->LpVtbl[34])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetComputeRoot32BitConstants(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint DestOffsetIn32BitValues)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, void*, uint, void>)@this->LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetGraphicsRoot32BitConstants(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, uint Num32BitValuesToSet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint DestOffsetIn32BitValues)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, void*, uint, void>)@this->LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootConstantBufferView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[37])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootConstantBufferView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[38])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootShaderResourceView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[39])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootShaderResourceView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[40])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetComputeRootUnorderedAccessView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[41])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static void SetGraphicsRootUnorderedAccessView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint RootParameterIndex, ulong BufferLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, ulong, void>)@this->LpVtbl[42])(@this, RootParameterIndex, BufferLocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetIndexBuffer(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexBufferView* pView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, IndexBufferView*, void>)@this->LpVtbl[43])(@this, pView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferView* pViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, VertexBufferView*, void>)@this->LpVtbl[44])(@this, StartSlot, NumViews, pViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StreamOutputBufferView* pViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, StreamOutputBufferView*, void>)@this->LpVtbl[45])(@this, StartSlot, NumViews, pViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumRenderTargetDescriptors, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pRenderTargetDescriptors, Silk.NET.Core.Bool32 RTsSingleHandleToDescriptorRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDepthStencilDescriptor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, CpuDescriptorHandle*, Silk.NET.Core.Bool32, CpuDescriptorHandle*, void>)@this->LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearDepthStencilView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[51])(@this, pResource, pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginQuery(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[52])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EndQuery(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[53])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPredication(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[55])(@this, pBuffer, AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, void*, uint, void>)@this->LpVtbl[56])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEvent(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, void*, uint, void>)@this->LpVtbl[57])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void EndEvent(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, void>)@this->LpVtbl[58])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteIndirect(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)@this->LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Resource** ppDependentResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void AtomicCopyBufferUINT64(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Resource** ppDependentResources, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SubresourceRangeUint64* pDependentSubresourceRanges)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)@this->LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
    }

    /// <summary>To be documented.</summary>
    public static void OMSetDepthBounds(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, float Min, float Max)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, float, float, void>)@this->LpVtbl[62])(@this, Min, Max);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetSamplePositions(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint NumSamplesPerPixel, uint NumPixels, SamplePosition* pSamplePositions)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, uint, SamplePosition*, void>)@this->LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositions);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresourceRegion(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Box2D<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Box2D<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)@this->LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
    }

    /// <summary>To be documented.</summary>
    public static void SetViewInstanceMask(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Mask)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, void>)@this->LpVtbl[65])(@this, Mask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12GraphicsCommandList2> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateParameter* pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[66])(@this, Count, pParams, pModes);
    }

}
