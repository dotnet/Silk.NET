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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11DeviceContext1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11DeviceContext1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11DeviceContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11DeviceContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Device** ppDevice)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D11DeviceContext1> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D11DeviceContext1> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D11DeviceContext1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11PixelShader* pPixelShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[9])(@this, pPixelShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11VertexShader* pVertexShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[11])(@this, pVertexShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexed(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, int, void>)@this->LpVtbl[12])(@this, IndexCount, StartIndexLocation, BaseVertexLocation);
    }

    /// <summary>To be documented.</summary>
    public static void Draw(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint VertexCount, uint StartVertexLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, void>)@this->LpVtbl[13])(@this, VertexCount, StartVertexLocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)@this->LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Unmap(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pResource, uint Subresource)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, void>)@this->LpVtbl[15])(@this, pResource, Subresource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetInputLayout(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11InputLayout* pInputLayout)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11InputLayout*, void>)@this->LpVtbl[17])(@this, pInputLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetVertexBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppVertexBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pStrides, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IASetIndexBuffer(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)@this->LpVtbl[19])(@this, pIndexBuffer, Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static void DrawIndexedInstanced(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, uint, int, uint, void>)@this->LpVtbl[20])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static void DrawInstanced(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, uint, uint, void>)@this->LpVtbl[21])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11GeometryShader* pShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[23])(@this, pShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static void IASetPrimitiveTopology(this ComPtr<ID3D11DeviceContext1> thisVtbl, Silk.NET.Core.Native.D3DPrimitiveTopology Topology)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)@this->LpVtbl[24])(@this, Topology);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Begin(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Asynchronous* pAsync)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)@this->LpVtbl[27])(@this, pAsync);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void End(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Asynchronous* pAsync)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)@this->LpVtbl[28])(@this, pAsync);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Asynchronous* pAsync, void* pData, uint DataSize, uint GetDataFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)@this->LpVtbl[29])(@this, pAsync, pData, DataSize, GetDataFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPredication(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Predicate* pPredicate, Silk.NET.Core.Bool32 PredicateValue)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Predicate*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[30])(@this, pPredicate, PredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargets(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)@this->LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint NumRTVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetBlendState(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11BlendState* pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)@this->LpVtbl[35])(@this, pBlendState, BlendFactor, SampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMSetDepthStencilState(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11DepthStencilState* pDepthStencilState, uint StencilRef)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilState*, uint, void>)@this->LpVtbl[36])(@this, pDepthStencilState, StencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOSetTargets(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppSOTargets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)@this->LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static void DrawAuto(this ComPtr<ID3D11DeviceContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, void>)@this->LpVtbl[38])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawIndexedInstancedIndirect(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)@this->LpVtbl[39])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawInstancedIndirect(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)@this->LpVtbl[40])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static void Dispatch(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, uint, void>)@this->LpVtbl[41])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DispatchIndirect(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)@this->LpVtbl[42])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetState(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11RasterizerState* pRasterizerState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RasterizerState*, void>)@this->LpVtbl[43])(@this, pRasterizerState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetViewports(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint NumViewports, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport* pViewports)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, Viewport*, void>)@this->LpVtbl[44])(@this, NumViewports, pViewports);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSSetScissorRects(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint NumRects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[45])(@this, NumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)@this->LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyResource(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)@this->LpVtbl[47])(@this, pDstResource, pSrcResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)@this->LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyStructureCount(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)@this->LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearRenderTargetView(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)@this->LpVtbl[50])(@this, pRenderTargetView, ColorRGBA);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewUint(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] uint* Values)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)@this->LpVtbl[51])(@this, pUnorderedAccessView, Values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearUnorderedAccessViewFloat(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] float* Values)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)@this->LpVtbl[52])(@this, pUnorderedAccessView, Values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearDepthStencilView(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilView*, uint, float, byte, void>)@this->LpVtbl[53])(@this, pDepthStencilView, ClearFlags, Depth, Stencil);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GenerateMips(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11ShaderResourceView* pShaderResourceView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ShaderResourceView*, void>)@this->LpVtbl[54])(@this, pShaderResourceView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetResourceMinLOD(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pResource, float MinLOD)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, float, void>)@this->LpVtbl[55])(@this, pResource, MinLOD);
    }

    /// <summary>To be documented.</summary>
    public static unsafe float GetResourceMinLOD(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pResource)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, float>)@this->LpVtbl[56])(@this, pResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveSubresource(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)@this->LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteCommandList(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11CommandList* pCommandList, Silk.NET.Core.Bool32 RestoreContextState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11CommandList*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[58])(@this, pCommandList, RestoreContextState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11HullShader* pHullShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[60])(@this, pHullShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11DomainShader* pDomainShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[64])(@this, pDomainShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetUnorderedAccessViews(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumUAVs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11UnorderedAccessView** ppUnorderedAccessViews, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pUAVInitialCounts)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)@this->LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11ComputeShader* pComputeShader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)@this->LpVtbl[69])(@this, pComputeShader, ppClassInstances, NumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetInputLayout(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11InputLayout** ppInputLayout)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11InputLayout**, void>)@this->LpVtbl[78])(@this, ppInputLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetVertexBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetIndexBuffer(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)@this->LpVtbl[80])(@this, pIndexBuffer, Format, Offset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void IAGetPrimitiveTopology(this ComPtr<ID3D11DeviceContext1> thisVtbl, Silk.NET.Core.Native.D3DPrimitiveTopology* pTopology)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)@this->LpVtbl[83])(@this, pTopology);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPredication(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Predicate** ppPredicate, int* pPredicateValue)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)@this->LpVtbl[86])(@this, ppPredicate, pPredicateValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargets(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)@this->LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetRenderTargetsAndUnorderedAccessViews(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetBlendState(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)@this->LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMask);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void OMGetDepthStencilState(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11DepthStencilState** ppDepthStencilState, uint* pStencilRef)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)@this->LpVtbl[92])(@this, ppDepthStencilState, pStencilRef);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SOGetTargets(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint NumBuffers, ID3D11Buffer** ppSOTargets)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, void>)@this->LpVtbl[93])(@this, NumBuffers, ppSOTargets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetState(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11RasterizerState** ppRasterizerState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RasterizerState**, void>)@this->LpVtbl[94])(@this, ppRasterizerState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetViewports(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint* pNumViewports, Viewport* pViewports)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Viewport*, void>)@this->LpVtbl[95])(@this, pNumViewports, pViewports);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RSGetScissorRects(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint* pNumRects, Silk.NET.Maths.Box2D<int>* pRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Box2D<int>*, void>)@this->LpVtbl[96])(@this, pNumRects, pRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShaderResources(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)@this->LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetUnorderedAccessViews(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, void>)@this->LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetShader(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)@this->LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetSamplers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)@this->LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)@this->LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <summary>To be documented.</summary>
    public static void ClearState(this ComPtr<ID3D11DeviceContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, void>)@this->LpVtbl[110])(@this);
    }

    /// <summary>To be documented.</summary>
    public static void Flush(this ComPtr<ID3D11DeviceContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, void>)@this->LpVtbl[111])(@this);
    }

    /// <summary>To be documented.</summary>
    public static DeviceContextType GetType(this ComPtr<ID3D11DeviceContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        DeviceContextType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, DeviceContextType>)@this->LpVtbl[112])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetContextFlags(this ComPtr<ID3D11DeviceContext1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint>)@this->LpVtbl[113])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FinishCommandList(this ComPtr<ID3D11DeviceContext1> thisVtbl, Silk.NET.Core.Bool32 RestoreDeferredContextState, ID3D11CommandList** ppCommandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Silk.NET.Core.Bool32, ID3D11CommandList**, int>)@this->LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopySubresourceRegion1(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pSrcBox, uint CopyFlags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)@this->LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateSubresource1(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pDstResource, uint DstSubresource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Box* pDstBox, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)@this->LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11Resource* pResource)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, void>)@this->LpVtbl[117])(@this, pResource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardView(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11View* pResourceView)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, void>)@this->LpVtbl[118])(@this, pResourceView);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSSetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSSetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSSetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSSetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSSetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSSetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Buffer** ppConstantBuffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFirstConstant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void VSGetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void HSGetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DSGetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GSGetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PSGetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CSGetConstantBuffers1(this ComPtr<ID3D11DeviceContext1> thisVtbl, uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)@this->LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SwapDeviceContextState(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3DDeviceContextState* pState, ID3DDeviceContextState** ppPreviousState)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)@this->LpVtbl[131])(@this, pState, ppPreviousState);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ClearView(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11View* pView, [Count(Count = 4)] float* Color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint NumRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[132])(@this, pView, Color, pRect, NumRects);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardView1(this ComPtr<ID3D11DeviceContext1> thisVtbl, ID3D11View* pResourceView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRects, uint NumRects)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Box2D<int>*, uint, void>)@this->LpVtbl[133])(@this, pResourceView, pRects, NumRects);
    }

}
