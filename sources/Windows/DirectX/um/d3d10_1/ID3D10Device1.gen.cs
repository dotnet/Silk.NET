// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D10Device1.xml' path='doc/member[@name="ID3D10Device1"]/*'/>
[Guid("9B7E4C8F-342C-4106-A19F-4F2704F689F0")]
[NativeTypeName("struct ID3D10Device1 : ID3D10Device")]
[NativeInheritance("ID3D10Device")]
public unsafe partial struct ID3D10Device1 : ID3D10Device1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10Device1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10Device1*, Guid*, void**, int> )(lpVtbl[0]))((ID3D10Device1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D10Device1*, uint> )(lpVtbl[1]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10Device1*, uint> )(lpVtbl[2]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D10Device.VSSetConstantBuffers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppConstantBuffers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void> )(lpVtbl[3]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <inheritdoc cref = "ID3D10Device.PSSetShaderResources"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void PSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D10ShaderResourceView *const *")] ID3D10ShaderResourceView** ppShaderResourceViews)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void> )(lpVtbl[4]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <inheritdoc cref = "ID3D10Device.PSSetShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void PSSetShader(ID3D10PixelShader* pPixelShader)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10PixelShader*, void> )(lpVtbl[5]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pPixelShader);
    }

    /// <inheritdoc cref = "ID3D10Device.PSSetSamplers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void PSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D10SamplerState *const *")] ID3D10SamplerState** ppSamplers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void> )(lpVtbl[6]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
    }

    /// <inheritdoc cref = "ID3D10Device.VSSetShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void VSSetShader(ID3D10VertexShader* pVertexShader)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10VertexShader*, void> )(lpVtbl[7]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pVertexShader);
    }

    /// <inheritdoc cref = "ID3D10Device.DrawIndexed"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, int, void> )(lpVtbl[8]))((ID3D10Device1*)Unsafe.AsPointer(ref this), IndexCount, StartIndexLocation, BaseVertexLocation);
    }

    /// <inheritdoc cref = "ID3D10Device.Draw"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void Draw(uint VertexCount, uint StartVertexLocation)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, void> )(lpVtbl[9]))((ID3D10Device1*)Unsafe.AsPointer(ref this), VertexCount, StartVertexLocation);
    }

    /// <inheritdoc cref = "ID3D10Device.PSSetConstantBuffers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppConstantBuffers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void> )(lpVtbl[10]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <inheritdoc cref = "ID3D10Device.IASetInputLayout"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void IASetInputLayout(ID3D10InputLayout* pInputLayout)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10InputLayout*, void> )(lpVtbl[11]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pInputLayout);
    }

    /// <inheritdoc cref = "ID3D10Device.IASetVertexBuffers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void IASetVertexBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppVertexBuffers, [NativeTypeName("const UINT *")] uint* pStrides, [NativeTypeName("const UINT *")] uint* pOffsets)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, uint*, uint*, void> )(lpVtbl[12]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
    }

    /// <inheritdoc cref = "ID3D10Device.IASetIndexBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void IASetIndexBuffer(ID3D10Buffer* pIndexBuffer, DXGI_FORMAT Format, uint Offset)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10Buffer*, DXGI_FORMAT, uint, void> )(lpVtbl[13]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
    }

    /// <inheritdoc cref = "ID3D10Device.DrawIndexedInstanced"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, uint, int, uint, void> )(lpVtbl[14]))((ID3D10Device1*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    }

    /// <inheritdoc cref = "ID3D10Device.DrawInstanced"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, uint, uint, void> )(lpVtbl[15]))((ID3D10Device1*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }

    /// <inheritdoc cref = "ID3D10Device.GSSetConstantBuffers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppConstantBuffers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void> )(lpVtbl[16]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <inheritdoc cref = "ID3D10Device.GSSetShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void GSSetShader(ID3D10GeometryShader* pShader)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10GeometryShader*, void> )(lpVtbl[17]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShader);
    }

    /// <inheritdoc cref = "ID3D10Device.IASetPrimitiveTopology"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void IASetPrimitiveTopology([NativeTypeName("D3D10_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY Topology)
    {
        ((delegate* unmanaged<ID3D10Device1*, D3D_PRIMITIVE_TOPOLOGY, void> )(lpVtbl[18]))((ID3D10Device1*)Unsafe.AsPointer(ref this), Topology);
    }

    /// <inheritdoc cref = "ID3D10Device.VSSetShaderResources"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void VSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D10ShaderResourceView *const *")] ID3D10ShaderResourceView** ppShaderResourceViews)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void> )(lpVtbl[19]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <inheritdoc cref = "ID3D10Device.VSSetSamplers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void VSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D10SamplerState *const *")] ID3D10SamplerState** ppSamplers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void> )(lpVtbl[20]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
    }

    /// <inheritdoc cref = "ID3D10Device.SetPredication"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void SetPredication(ID3D10Predicate* pPredicate, BOOL PredicateValue)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10Predicate*, BOOL, void> )(lpVtbl[21]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pPredicate, PredicateValue);
    }

    /// <inheritdoc cref = "ID3D10Device.GSSetShaderResources"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void GSSetShaderResources(uint StartSlot, uint NumViews, [NativeTypeName("ID3D10ShaderResourceView *const *")] ID3D10ShaderResourceView** ppShaderResourceViews)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void> )(lpVtbl[22]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <inheritdoc cref = "ID3D10Device.GSSetSamplers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void GSSetSamplers(uint StartSlot, uint NumSamplers, [NativeTypeName("ID3D10SamplerState *const *")] ID3D10SamplerState** ppSamplers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void> )(lpVtbl[23]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
    }

    /// <inheritdoc cref = "ID3D10Device.OMSetRenderTargets"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void OMSetRenderTargets(uint NumViews, [NativeTypeName("ID3D10RenderTargetView *const *")] ID3D10RenderTargetView** ppRenderTargetViews, ID3D10DepthStencilView* pDepthStencilView)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, ID3D10RenderTargetView**, ID3D10DepthStencilView*, void> )(lpVtbl[24]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, pDepthStencilView);
    }

    /// <inheritdoc cref = "ID3D10Device.OMSetBlendState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void OMSetBlendState(ID3D10BlendState* pBlendState, [NativeTypeName("const FLOAT[4]")] float* BlendFactor, uint SampleMask)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10BlendState*, float*, uint, void> )(lpVtbl[25]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pBlendState, BlendFactor, SampleMask);
    }

    /// <inheritdoc cref = "ID3D10Device.OMSetDepthStencilState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void OMSetDepthStencilState(ID3D10DepthStencilState* pDepthStencilState, uint StencilRef)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10DepthStencilState*, uint, void> )(lpVtbl[26]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDepthStencilState, StencilRef);
    }

    /// <inheritdoc cref = "ID3D10Device.SOSetTargets"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void SOSetTargets(uint NumBuffers, [NativeTypeName("ID3D10Buffer *const *")] ID3D10Buffer** ppSOTargets, [NativeTypeName("const UINT *")] uint* pOffsets)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, ID3D10Buffer**, uint*, void> )(lpVtbl[27]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
    }

    /// <inheritdoc cref = "ID3D10Device.DrawAuto"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void DrawAuto()
    {
        ((delegate* unmanaged<ID3D10Device1*, void> )(lpVtbl[28]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D10Device.RSSetState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public void RSSetState(ID3D10RasterizerState* pRasterizerState)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10RasterizerState*, void> )(lpVtbl[29]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pRasterizerState);
    }

    /// <inheritdoc cref = "ID3D10Device.RSSetViewports"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D10_VIEWPORT *")] D3D10_VIEWPORT* pViewports)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, D3D10_VIEWPORT*, void> )(lpVtbl[30]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
    }

    /// <inheritdoc cref = "ID3D10Device.RSSetScissorRects"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D10_RECT *")] RECT* pRects)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, RECT*, void> )(lpVtbl[31]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumRects, pRects);
    }

    /// <inheritdoc cref = "ID3D10Device.CopySubresourceRegion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public void CopySubresourceRegion(ID3D10Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D10Resource* pSrcResource, uint SrcSubresource, [NativeTypeName("const D3D10_BOX *")] D3D10_BOX* pSrcBox)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, uint, uint, uint, uint, ID3D10Resource*, uint, D3D10_BOX*, void> )(lpVtbl[32]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
    }

    /// <inheritdoc cref = "ID3D10Device.CopyResource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public void CopyResource(ID3D10Resource* pDstResource, ID3D10Resource* pSrcResource)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, ID3D10Resource*, void> )(lpVtbl[33]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
    }

    /// <inheritdoc cref = "ID3D10Device.UpdateSubresource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void UpdateSubresource(ID3D10Resource* pDstResource, uint DstSubresource, [NativeTypeName("const D3D10_BOX *")] D3D10_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, uint, D3D10_BOX*, void*, uint, uint, void> )(lpVtbl[34]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    /// <inheritdoc cref = "ID3D10Device.ClearRenderTargetView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public void ClearRenderTargetView(ID3D10RenderTargetView* pRenderTargetView, [NativeTypeName("const FLOAT[4]")] float* ColorRGBA)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10RenderTargetView*, float*, void> )(lpVtbl[35]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pRenderTargetView, ColorRGBA);
    }

    /// <inheritdoc cref = "ID3D10Device.ClearDepthStencilView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void ClearDepthStencilView(ID3D10DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10DepthStencilView*, uint, float, byte, void> )(lpVtbl[36]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDepthStencilView, ClearFlags, Depth, Stencil);
    }

    /// <inheritdoc cref = "ID3D10Device.GenerateMips"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public void GenerateMips(ID3D10ShaderResourceView* pShaderResourceView)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10ShaderResourceView*, void> )(lpVtbl[37]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShaderResourceView);
    }

    /// <inheritdoc cref = "ID3D10Device.ResolveSubresource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void ResolveSubresource(ID3D10Resource* pDstResource, uint DstSubresource, ID3D10Resource* pSrcResource, uint SrcSubresource, DXGI_FORMAT Format)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, uint, ID3D10Resource*, uint, DXGI_FORMAT, void> )(lpVtbl[38]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <inheritdoc cref = "ID3D10Device.VSGetConstantBuffers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D10Buffer** ppConstantBuffers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void> )(lpVtbl[39]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <inheritdoc cref = "ID3D10Device.PSGetShaderResources"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public void PSGetShaderResources(uint StartSlot, uint NumViews, ID3D10ShaderResourceView** ppShaderResourceViews)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void> )(lpVtbl[40]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <inheritdoc cref = "ID3D10Device.PSGetShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public void PSGetShader(ID3D10PixelShader** ppPixelShader)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10PixelShader**, void> )(lpVtbl[41]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppPixelShader);
    }

    /// <inheritdoc cref = "ID3D10Device.PSGetSamplers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public void PSGetSamplers(uint StartSlot, uint NumSamplers, ID3D10SamplerState** ppSamplers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void> )(lpVtbl[42]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
    }

    /// <inheritdoc cref = "ID3D10Device.VSGetShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public void VSGetShader(ID3D10VertexShader** ppVertexShader)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10VertexShader**, void> )(lpVtbl[43]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppVertexShader);
    }

    /// <inheritdoc cref = "ID3D10Device.PSGetConstantBuffers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D10Buffer** ppConstantBuffers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void> )(lpVtbl[44]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <inheritdoc cref = "ID3D10Device.IAGetInputLayout"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public void IAGetInputLayout(ID3D10InputLayout** ppInputLayout)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10InputLayout**, void> )(lpVtbl[45]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppInputLayout);
    }

    /// <inheritdoc cref = "ID3D10Device.IAGetVertexBuffers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D10Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, uint*, uint*, void> )(lpVtbl[46]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
    }

    /// <inheritdoc cref = "ID3D10Device.IAGetIndexBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public void IAGetIndexBuffer(ID3D10Buffer** pIndexBuffer, DXGI_FORMAT* Format, uint* Offset)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10Buffer**, DXGI_FORMAT*, uint*, void> )(lpVtbl[47]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pIndexBuffer, Format, Offset);
    }

    /// <inheritdoc cref = "ID3D10Device.GSGetConstantBuffers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D10Buffer** ppConstantBuffers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10Buffer**, void> )(lpVtbl[48]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumBuffers, ppConstantBuffers);
    }

    /// <inheritdoc cref = "ID3D10Device.GSGetShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public void GSGetShader(ID3D10GeometryShader** ppGeometryShader)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10GeometryShader**, void> )(lpVtbl[49]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppGeometryShader);
    }

    /// <inheritdoc cref = "ID3D10Device.IAGetPrimitiveTopology"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public void IAGetPrimitiveTopology([NativeTypeName("D3D10_PRIMITIVE_TOPOLOGY *")] D3D_PRIMITIVE_TOPOLOGY* pTopology)
    {
        ((delegate* unmanaged<ID3D10Device1*, D3D_PRIMITIVE_TOPOLOGY*, void> )(lpVtbl[50]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pTopology);
    }

    /// <inheritdoc cref = "ID3D10Device.VSGetShaderResources"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public void VSGetShaderResources(uint StartSlot, uint NumViews, ID3D10ShaderResourceView** ppShaderResourceViews)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void> )(lpVtbl[51]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <inheritdoc cref = "ID3D10Device.VSGetSamplers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public void VSGetSamplers(uint StartSlot, uint NumSamplers, ID3D10SamplerState** ppSamplers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void> )(lpVtbl[52]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
    }

    /// <inheritdoc cref = "ID3D10Device.GetPredication"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public void GetPredication(ID3D10Predicate** ppPredicate, BOOL* pPredicateValue)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10Predicate**, BOOL*, void> )(lpVtbl[53]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppPredicate, pPredicateValue);
    }

    /// <inheritdoc cref = "ID3D10Device.GSGetShaderResources"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public void GSGetShaderResources(uint StartSlot, uint NumViews, ID3D10ShaderResourceView** ppShaderResourceViews)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10ShaderResourceView**, void> )(lpVtbl[54]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumViews, ppShaderResourceViews);
    }

    /// <inheritdoc cref = "ID3D10Device.GSGetSamplers"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public void GSGetSamplers(uint StartSlot, uint NumSamplers, ID3D10SamplerState** ppSamplers)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, ID3D10SamplerState**, void> )(lpVtbl[55]))((ID3D10Device1*)Unsafe.AsPointer(ref this), StartSlot, NumSamplers, ppSamplers);
    }

    /// <inheritdoc cref = "ID3D10Device.OMGetRenderTargets"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public void OMGetRenderTargets(uint NumViews, ID3D10RenderTargetView** ppRenderTargetViews, ID3D10DepthStencilView** ppDepthStencilView)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, ID3D10RenderTargetView**, ID3D10DepthStencilView**, void> )(lpVtbl[56]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumViews, ppRenderTargetViews, ppDepthStencilView);
    }

    /// <inheritdoc cref = "ID3D10Device.OMGetBlendState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public void OMGetBlendState(ID3D10BlendState** ppBlendState, [NativeTypeName("FLOAT[4]")] float* BlendFactor, uint* pSampleMask)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10BlendState**, float*, uint*, void> )(lpVtbl[57]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppBlendState, BlendFactor, pSampleMask);
    }

    /// <inheritdoc cref = "ID3D10Device.OMGetDepthStencilState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public void OMGetDepthStencilState(ID3D10DepthStencilState** ppDepthStencilState, uint* pStencilRef)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10DepthStencilState**, uint*, void> )(lpVtbl[58]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppDepthStencilState, pStencilRef);
    }

    /// <inheritdoc cref = "ID3D10Device.SOGetTargets"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public void SOGetTargets(uint NumBuffers, ID3D10Buffer** ppSOTargets, uint* pOffsets)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, ID3D10Buffer**, uint*, void> )(lpVtbl[59]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumBuffers, ppSOTargets, pOffsets);
    }

    /// <inheritdoc cref = "ID3D10Device.RSGetState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public void RSGetState(ID3D10RasterizerState** ppRasterizerState)
    {
        ((delegate* unmanaged<ID3D10Device1*, ID3D10RasterizerState**, void> )(lpVtbl[60]))((ID3D10Device1*)Unsafe.AsPointer(ref this), ppRasterizerState);
    }

    /// <inheritdoc cref = "ID3D10Device.RSGetViewports"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public void RSGetViewports(uint* NumViewports, D3D10_VIEWPORT* pViewports)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint*, D3D10_VIEWPORT*, void> )(lpVtbl[61]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
    }

    /// <inheritdoc cref = "ID3D10Device.RSGetScissorRects"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public void RSGetScissorRects(uint* NumRects, [NativeTypeName("D3D10_RECT *")] RECT* pRects)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint*, RECT*, void> )(lpVtbl[62]))((ID3D10Device1*)Unsafe.AsPointer(ref this), NumRects, pRects);
    }

    /// <inheritdoc cref = "ID3D10Device.GetDeviceRemovedReason"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT GetDeviceRemovedReason()
    {
        return ((delegate* unmanaged<ID3D10Device1*, int> )(lpVtbl[63]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D10Device.SetExceptionMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT SetExceptionMode(uint RaiseFlags)
    {
        return ((delegate* unmanaged<ID3D10Device1*, uint, int> )(lpVtbl[64]))((ID3D10Device1*)Unsafe.AsPointer(ref this), RaiseFlags);
    }

    /// <inheritdoc cref = "ID3D10Device.GetExceptionMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public uint GetExceptionMode()
    {
        return ((delegate* unmanaged<ID3D10Device1*, uint> )(lpVtbl[65]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D10Device.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D10Device1*, Guid*, uint*, void*, int> )(lpVtbl[66]))((ID3D10Device1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref = "ID3D10Device.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D10Device1*, Guid*, uint, void*, int> )(lpVtbl[67]))((ID3D10Device1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D10Device.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D10Device1*, Guid*, IUnknown*, int> )(lpVtbl[68]))((ID3D10Device1*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref = "ID3D10Device.ClearState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public void ClearState()
    {
        ((delegate* unmanaged<ID3D10Device1*, void> )(lpVtbl[69]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D10Device.Flush"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public void Flush()
    {
        ((delegate* unmanaged<ID3D10Device1*, void> )(lpVtbl[70]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D10Device.CreateBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT CreateBuffer([NativeTypeName("const D3D10_BUFFER_DESC *")] D3D10_BUFFER_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, ID3D10Buffer** ppBuffer)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_BUFFER_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Buffer**, int> )(lpVtbl[71]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppBuffer);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateTexture1D"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT CreateTexture1D([NativeTypeName("const D3D10_TEXTURE1D_DESC *")] D3D10_TEXTURE1D_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, ID3D10Texture1D** ppTexture1D)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_TEXTURE1D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture1D**, int> )(lpVtbl[72]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture1D);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateTexture2D"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT CreateTexture2D([NativeTypeName("const D3D10_TEXTURE2D_DESC *")] D3D10_TEXTURE2D_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, ID3D10Texture2D** ppTexture2D)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_TEXTURE2D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture2D**, int> )(lpVtbl[73]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture2D);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateTexture3D"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT CreateTexture3D([NativeTypeName("const D3D10_TEXTURE3D_DESC *")] D3D10_TEXTURE3D_DESC* pDesc, [NativeTypeName("const D3D10_SUBRESOURCE_DATA *")] D3D10_SUBRESOURCE_DATA* pInitialData, ID3D10Texture3D** ppTexture3D)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_TEXTURE3D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture3D**, int> )(lpVtbl[74]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture3D);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateShaderResourceView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT CreateShaderResourceView(ID3D10Resource* pResource, [NativeTypeName("const D3D10_SHADER_RESOURCE_VIEW_DESC *")] D3D10_SHADER_RESOURCE_VIEW_DESC* pDesc, ID3D10ShaderResourceView** ppSRView)
    {
        return ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, D3D10_SHADER_RESOURCE_VIEW_DESC*, ID3D10ShaderResourceView**, int> )(lpVtbl[75]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateRenderTargetView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT CreateRenderTargetView(ID3D10Resource* pResource, [NativeTypeName("const D3D10_RENDER_TARGET_VIEW_DESC *")] D3D10_RENDER_TARGET_VIEW_DESC* pDesc, ID3D10RenderTargetView** ppRTView)
    {
        return ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, D3D10_RENDER_TARGET_VIEW_DESC*, ID3D10RenderTargetView**, int> )(lpVtbl[76]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppRTView);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateDepthStencilView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT CreateDepthStencilView(ID3D10Resource* pResource, [NativeTypeName("const D3D10_DEPTH_STENCIL_VIEW_DESC *")] D3D10_DEPTH_STENCIL_VIEW_DESC* pDesc, ID3D10DepthStencilView** ppDepthStencilView)
    {
        return ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, D3D10_DEPTH_STENCIL_VIEW_DESC*, ID3D10DepthStencilView**, int> )(lpVtbl[77]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppDepthStencilView);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateInputLayout"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT CreateInputLayout([NativeTypeName("const D3D10_INPUT_ELEMENT_DESC *")] D3D10_INPUT_ELEMENT_DESC* pInputElementDescs, uint NumElements, [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D10InputLayout** ppInputLayout)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_INPUT_ELEMENT_DESC*, uint, void*, nuint, ID3D10InputLayout**, int> )(lpVtbl[78]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateVertexShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT CreateVertexShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D10VertexShader** ppVertexShader)
    {
        return ((delegate* unmanaged<ID3D10Device1*, void*, nuint, ID3D10VertexShader**, int> )(lpVtbl[79]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, ppVertexShader);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateGeometryShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT CreateGeometryShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D10GeometryShader** ppGeometryShader)
    {
        return ((delegate* unmanaged<ID3D10Device1*, void*, nuint, ID3D10GeometryShader**, int> )(lpVtbl[80]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, ppGeometryShader);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateGeometryShaderWithStreamOutput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT CreateGeometryShaderWithStreamOutput([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("const D3D10_SO_DECLARATION_ENTRY *")] D3D10_SO_DECLARATION_ENTRY* pSODeclaration, uint NumEntries, uint OutputStreamStride, ID3D10GeometryShader** ppGeometryShader)
    {
        return ((delegate* unmanaged<ID3D10Device1*, void*, nuint, D3D10_SO_DECLARATION_ENTRY*, uint, uint, ID3D10GeometryShader**, int> )(lpVtbl[81]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, OutputStreamStride, ppGeometryShader);
    }

    /// <inheritdoc cref = "ID3D10Device.CreatePixelShader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT CreatePixelShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D10PixelShader** ppPixelShader)
    {
        return ((delegate* unmanaged<ID3D10Device1*, void*, nuint, ID3D10PixelShader**, int> )(lpVtbl[82]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, ppPixelShader);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateBlendState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT CreateBlendState([NativeTypeName("const D3D10_BLEND_DESC *")] D3D10_BLEND_DESC* pBlendStateDesc, ID3D10BlendState** ppBlendState)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_BLEND_DESC*, ID3D10BlendState**, int> )(lpVtbl[83]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateDepthStencilState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT CreateDepthStencilState([NativeTypeName("const D3D10_DEPTH_STENCIL_DESC *")] D3D10_DEPTH_STENCIL_DESC* pDepthStencilDesc, ID3D10DepthStencilState** ppDepthStencilState)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_DEPTH_STENCIL_DESC*, ID3D10DepthStencilState**, int> )(lpVtbl[84]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDepthStencilDesc, ppDepthStencilState);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateRasterizerState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT CreateRasterizerState([NativeTypeName("const D3D10_RASTERIZER_DESC *")] D3D10_RASTERIZER_DESC* pRasterizerDesc, ID3D10RasterizerState** ppRasterizerState)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_RASTERIZER_DESC*, ID3D10RasterizerState**, int> )(lpVtbl[85]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateSamplerState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT CreateSamplerState([NativeTypeName("const D3D10_SAMPLER_DESC *")] D3D10_SAMPLER_DESC* pSamplerDesc, ID3D10SamplerState** ppSamplerState)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_SAMPLER_DESC*, ID3D10SamplerState**, int> )(lpVtbl[86]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pSamplerDesc, ppSamplerState);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateQuery"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT CreateQuery([NativeTypeName("const D3D10_QUERY_DESC *")] D3D10_QUERY_DESC* pQueryDesc, ID3D10Query** ppQuery)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_QUERY_DESC*, ID3D10Query**, int> )(lpVtbl[87]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pQueryDesc, ppQuery);
    }

    /// <inheritdoc cref = "ID3D10Device.CreatePredicate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT CreatePredicate([NativeTypeName("const D3D10_QUERY_DESC *")] D3D10_QUERY_DESC* pPredicateDesc, ID3D10Predicate** ppPredicate)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_QUERY_DESC*, ID3D10Predicate**, int> )(lpVtbl[88]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pPredicateDesc, ppPredicate);
    }

    /// <inheritdoc cref = "ID3D10Device.CreateCounter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT CreateCounter([NativeTypeName("const D3D10_COUNTER_DESC *")] D3D10_COUNTER_DESC* pCounterDesc, ID3D10Counter** ppCounter)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_COUNTER_DESC*, ID3D10Counter**, int> )(lpVtbl[89]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pCounterDesc, ppCounter);
    }

    /// <inheritdoc cref = "ID3D10Device.CheckFormatSupport"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT CheckFormatSupport(DXGI_FORMAT Format, uint* pFormatSupport)
    {
        return ((delegate* unmanaged<ID3D10Device1*, DXGI_FORMAT, uint*, int> )(lpVtbl[90]))((ID3D10Device1*)Unsafe.AsPointer(ref this), Format, pFormatSupport);
    }

    /// <inheritdoc cref = "ID3D10Device.CheckMultisampleQualityLevels"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT CheckMultisampleQualityLevels(DXGI_FORMAT Format, uint SampleCount, uint* pNumQualityLevels)
    {
        return ((delegate* unmanaged<ID3D10Device1*, DXGI_FORMAT, uint, uint*, int> )(lpVtbl[91]))((ID3D10Device1*)Unsafe.AsPointer(ref this), Format, SampleCount, pNumQualityLevels);
    }

    /// <inheritdoc cref = "ID3D10Device.CheckCounterInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public void CheckCounterInfo(D3D10_COUNTER_INFO* pCounterInfo)
    {
        ((delegate* unmanaged<ID3D10Device1*, D3D10_COUNTER_INFO*, void> )(lpVtbl[92]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pCounterInfo);
    }

    /// <inheritdoc cref = "ID3D10Device.CheckCounter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT CheckCounter([NativeTypeName("const D3D10_COUNTER_DESC *")] D3D10_COUNTER_DESC* pDesc, D3D10_COUNTER_TYPE* pType, uint* pActiveCounters, [NativeTypeName("LPSTR")] sbyte* szName, uint* pNameLength, [NativeTypeName("LPSTR")] sbyte* szUnits, uint* pUnitsLength, [NativeTypeName("LPSTR")] sbyte* szDescription, uint* pDescriptionLength)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_COUNTER_DESC*, D3D10_COUNTER_TYPE*, uint*, sbyte*, uint*, sbyte*, uint*, sbyte*, uint*, int> )(lpVtbl[93]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
    }

    /// <inheritdoc cref = "ID3D10Device.GetCreationFlags"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public uint GetCreationFlags()
    {
        return ((delegate* unmanaged<ID3D10Device1*, uint> )(lpVtbl[94]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D10Device.OpenSharedResource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT OpenSharedResource(HANDLE hResource, [NativeTypeName("const IID &")] Guid* ReturnedInterface, void** ppResource)
    {
        return ((delegate* unmanaged<ID3D10Device1*, HANDLE, Guid*, void**, int> )(lpVtbl[95]))((ID3D10Device1*)Unsafe.AsPointer(ref this), hResource, ReturnedInterface, ppResource);
    }

    /// <inheritdoc cref = "ID3D10Device.SetTextFilterSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public void SetTextFilterSize(uint Width, uint Height)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint, uint, void> )(lpVtbl[96]))((ID3D10Device1*)Unsafe.AsPointer(ref this), Width, Height);
    }

    /// <inheritdoc cref = "ID3D10Device.GetTextFilterSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public void GetTextFilterSize(uint* pWidth, uint* pHeight)
    {
        ((delegate* unmanaged<ID3D10Device1*, uint*, uint*, void> )(lpVtbl[97]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pWidth, pHeight);
    }

    /// <include file='ID3D10Device1.xml' path='doc/member[@name="ID3D10Device1.CreateShaderResourceView1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT CreateShaderResourceView1(ID3D10Resource* pResource, [NativeTypeName("const D3D10_SHADER_RESOURCE_VIEW_DESC1 *")] D3D10_SHADER_RESOURCE_VIEW_DESC1* pDesc, ID3D10ShaderResourceView1** ppSRView)
    {
        return ((delegate* unmanaged<ID3D10Device1*, ID3D10Resource*, D3D10_SHADER_RESOURCE_VIEW_DESC1*, ID3D10ShaderResourceView1**, int> )(lpVtbl[98]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
    }

    /// <include file='ID3D10Device1.xml' path='doc/member[@name="ID3D10Device1.CreateBlendState1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT CreateBlendState1([NativeTypeName("const D3D10_BLEND_DESC1 *")] D3D10_BLEND_DESC1* pBlendStateDesc, ID3D10BlendState1** ppBlendState)
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_BLEND_DESC1*, ID3D10BlendState1**, int> )(lpVtbl[99]))((ID3D10Device1*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
    }

    /// <include file='ID3D10Device1.xml' path='doc/member[@name="ID3D10Device1.GetFeatureLevel"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public D3D10_FEATURE_LEVEL1 GetFeatureLevel()
    {
        return ((delegate* unmanaged<ID3D10Device1*, D3D10_FEATURE_LEVEL1> )(lpVtbl[100]))((ID3D10Device1*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID3D10Device.Interface
    {
        [VtblIndex(98)]
        HRESULT CreateShaderResourceView1(ID3D10Resource* pResource, [NativeTypeName("const D3D10_SHADER_RESOURCE_VIEW_DESC1 *")] D3D10_SHADER_RESOURCE_VIEW_DESC1* pDesc, ID3D10ShaderResourceView1** ppSRView);
        [VtblIndex(99)]
        HRESULT CreateBlendState1([NativeTypeName("const D3D10_BLEND_DESC1 *")] D3D10_BLEND_DESC1* pBlendStateDesc, ID3D10BlendState1** ppBlendState);
        [VtblIndex(100)]
        D3D10_FEATURE_LEVEL1 GetFeatureLevel();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("void (UINT, UINT, ID3D10Buffer *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10Buffer**, void> VSSetConstantBuffers;
        [NativeTypeName("void (UINT, UINT, ID3D10ShaderResourceView *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10ShaderResourceView**, void> PSSetShaderResources;
        [NativeTypeName("void (ID3D10PixelShader *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10PixelShader*, void> PSSetShader;
        [NativeTypeName("void (UINT, UINT, ID3D10SamplerState *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10SamplerState**, void> PSSetSamplers;
        [NativeTypeName("void (ID3D10VertexShader *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10VertexShader*, void> VSSetShader;
        [NativeTypeName("void (UINT, UINT, INT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int, void> DrawIndexed;
        [NativeTypeName("void (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, void> Draw;
        [NativeTypeName("void (UINT, UINT, ID3D10Buffer *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10Buffer**, void> PSSetConstantBuffers;
        [NativeTypeName("void (ID3D10InputLayout *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10InputLayout*, void> IASetInputLayout;
        [NativeTypeName("void (UINT, UINT, ID3D10Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10Buffer**, uint*, uint*, void> IASetVertexBuffers;
        [NativeTypeName("void (ID3D10Buffer *, DXGI_FORMAT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Buffer*, DXGI_FORMAT, uint, void> IASetIndexBuffer;
        [NativeTypeName("void (UINT, UINT, UINT, INT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;
        [NativeTypeName("void (UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, uint, void> DrawInstanced;
        [NativeTypeName("void (UINT, UINT, ID3D10Buffer *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10Buffer**, void> GSSetConstantBuffers;
        [NativeTypeName("void (ID3D10GeometryShader *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10GeometryShader*, void> GSSetShader;
        [NativeTypeName("void (D3D10_PRIMITIVE_TOPOLOGY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D_PRIMITIVE_TOPOLOGY, void> IASetPrimitiveTopology;
        [NativeTypeName("void (UINT, UINT, ID3D10ShaderResourceView *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10ShaderResourceView**, void> VSSetShaderResources;
        [NativeTypeName("void (UINT, UINT, ID3D10SamplerState *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10SamplerState**, void> VSSetSamplers;
        [NativeTypeName("void (ID3D10Predicate *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Predicate*, BOOL, void> SetPredication;
        [NativeTypeName("void (UINT, UINT, ID3D10ShaderResourceView *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10ShaderResourceView**, void> GSSetShaderResources;
        [NativeTypeName("void (UINT, UINT, ID3D10SamplerState *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10SamplerState**, void> GSSetSamplers;
        [NativeTypeName("void (UINT, ID3D10RenderTargetView *const *, ID3D10DepthStencilView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10RenderTargetView**, ID3D10DepthStencilView*, void> OMSetRenderTargets;
        [NativeTypeName("void (ID3D10BlendState *, const FLOAT *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10BlendState*, float*, uint, void> OMSetBlendState;
        [NativeTypeName("void (ID3D10DepthStencilState *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10DepthStencilState*, uint, void> OMSetDepthStencilState;
        [NativeTypeName("void (UINT, ID3D10Buffer *const *, const UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10Buffer**, uint*, void> SOSetTargets;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> DrawAuto;
        [NativeTypeName("void (ID3D10RasterizerState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10RasterizerState*, void> RSSetState;
        [NativeTypeName("void (UINT, const D3D10_VIEWPORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D10_VIEWPORT*, void> RSSetViewports;
        [NativeTypeName("void (UINT, const D3D10_RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT*, void> RSSetScissorRects;
        [NativeTypeName("void (ID3D10Resource *, UINT, UINT, UINT, UINT, ID3D10Resource *, UINT, const D3D10_BOX *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Resource*, uint, uint, uint, uint, ID3D10Resource*, uint, D3D10_BOX*, void> CopySubresourceRegion;
        [NativeTypeName("void (ID3D10Resource *, ID3D10Resource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Resource*, ID3D10Resource*, void> CopyResource;
        [NativeTypeName("void (ID3D10Resource *, UINT, const D3D10_BOX *, const void *, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Resource*, uint, D3D10_BOX*, void*, uint, uint, void> UpdateSubresource;
        [NativeTypeName("void (ID3D10RenderTargetView *, const FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10RenderTargetView*, float*, void> ClearRenderTargetView;
        [NativeTypeName("void (ID3D10DepthStencilView *, UINT, FLOAT, UINT8) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10DepthStencilView*, uint, float, byte, void> ClearDepthStencilView;
        [NativeTypeName("void (ID3D10ShaderResourceView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10ShaderResourceView*, void> GenerateMips;
        [NativeTypeName("void (ID3D10Resource *, UINT, ID3D10Resource *, UINT, DXGI_FORMAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Resource*, uint, ID3D10Resource*, uint, DXGI_FORMAT, void> ResolveSubresource;
        [NativeTypeName("void (UINT, UINT, ID3D10Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10Buffer**, void> VSGetConstantBuffers;
        [NativeTypeName("void (UINT, UINT, ID3D10ShaderResourceView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10ShaderResourceView**, void> PSGetShaderResources;
        [NativeTypeName("void (ID3D10PixelShader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10PixelShader**, void> PSGetShader;
        [NativeTypeName("void (UINT, UINT, ID3D10SamplerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10SamplerState**, void> PSGetSamplers;
        [NativeTypeName("void (ID3D10VertexShader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10VertexShader**, void> VSGetShader;
        [NativeTypeName("void (UINT, UINT, ID3D10Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10Buffer**, void> PSGetConstantBuffers;
        [NativeTypeName("void (ID3D10InputLayout **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10InputLayout**, void> IAGetInputLayout;
        [NativeTypeName("void (UINT, UINT, ID3D10Buffer **, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10Buffer**, uint*, uint*, void> IAGetVertexBuffers;
        [NativeTypeName("void (ID3D10Buffer **, DXGI_FORMAT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Buffer**, DXGI_FORMAT*, uint*, void> IAGetIndexBuffer;
        [NativeTypeName("void (UINT, UINT, ID3D10Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10Buffer**, void> GSGetConstantBuffers;
        [NativeTypeName("void (ID3D10GeometryShader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10GeometryShader**, void> GSGetShader;
        [NativeTypeName("void (D3D10_PRIMITIVE_TOPOLOGY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D_PRIMITIVE_TOPOLOGY*, void> IAGetPrimitiveTopology;
        [NativeTypeName("void (UINT, UINT, ID3D10ShaderResourceView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10ShaderResourceView**, void> VSGetShaderResources;
        [NativeTypeName("void (UINT, UINT, ID3D10SamplerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10SamplerState**, void> VSGetSamplers;
        [NativeTypeName("void (ID3D10Predicate **, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Predicate**, BOOL*, void> GetPredication;
        [NativeTypeName("void (UINT, UINT, ID3D10ShaderResourceView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10ShaderResourceView**, void> GSGetShaderResources;
        [NativeTypeName("void (UINT, UINT, ID3D10SamplerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D10SamplerState**, void> GSGetSamplers;
        [NativeTypeName("void (UINT, ID3D10RenderTargetView **, ID3D10DepthStencilView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10RenderTargetView**, ID3D10DepthStencilView**, void> OMGetRenderTargets;
        [NativeTypeName("void (ID3D10BlendState **, FLOAT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10BlendState**, float*, uint*, void> OMGetBlendState;
        [NativeTypeName("void (ID3D10DepthStencilState **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10DepthStencilState**, uint*, void> OMGetDepthStencilState;
        [NativeTypeName("void (UINT, ID3D10Buffer **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10Buffer**, uint*, void> SOGetTargets;
        [NativeTypeName("void (ID3D10RasterizerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10RasterizerState**, void> RSGetState;
        [NativeTypeName("void (UINT *, D3D10_VIEWPORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, D3D10_VIEWPORT*, void> RSGetViewports;
        [NativeTypeName("void (UINT *, D3D10_RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, RECT*, void> RSGetScissorRects;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetDeviceRemovedReason;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetExceptionMode;
        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetExceptionMode;
        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;
        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ClearState;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Flush;
        [NativeTypeName("HRESULT (const D3D10_BUFFER_DESC *, const D3D10_SUBRESOURCE_DATA *, ID3D10Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_BUFFER_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Buffer**, int> CreateBuffer;
        [NativeTypeName("HRESULT (const D3D10_TEXTURE1D_DESC *, const D3D10_SUBRESOURCE_DATA *, ID3D10Texture1D **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_TEXTURE1D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture1D**, int> CreateTexture1D;
        [NativeTypeName("HRESULT (const D3D10_TEXTURE2D_DESC *, const D3D10_SUBRESOURCE_DATA *, ID3D10Texture2D **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_TEXTURE2D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture2D**, int> CreateTexture2D;
        [NativeTypeName("HRESULT (const D3D10_TEXTURE3D_DESC *, const D3D10_SUBRESOURCE_DATA *, ID3D10Texture3D **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_TEXTURE3D_DESC*, D3D10_SUBRESOURCE_DATA*, ID3D10Texture3D**, int> CreateTexture3D;
        [NativeTypeName("HRESULT (ID3D10Resource *, const D3D10_SHADER_RESOURCE_VIEW_DESC *, ID3D10ShaderResourceView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Resource*, D3D10_SHADER_RESOURCE_VIEW_DESC*, ID3D10ShaderResourceView**, int> CreateShaderResourceView;
        [NativeTypeName("HRESULT (ID3D10Resource *, const D3D10_RENDER_TARGET_VIEW_DESC *, ID3D10RenderTargetView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Resource*, D3D10_RENDER_TARGET_VIEW_DESC*, ID3D10RenderTargetView**, int> CreateRenderTargetView;
        [NativeTypeName("HRESULT (ID3D10Resource *, const D3D10_DEPTH_STENCIL_VIEW_DESC *, ID3D10DepthStencilView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Resource*, D3D10_DEPTH_STENCIL_VIEW_DESC*, ID3D10DepthStencilView**, int> CreateDepthStencilView;
        [NativeTypeName("HRESULT (const D3D10_INPUT_ELEMENT_DESC *, UINT, const void *, SIZE_T, ID3D10InputLayout **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_INPUT_ELEMENT_DESC*, uint, void*, nuint, ID3D10InputLayout**, int> CreateInputLayout;
        [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D10VertexShader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, nuint, ID3D10VertexShader**, int> CreateVertexShader;
        [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D10GeometryShader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, nuint, ID3D10GeometryShader**, int> CreateGeometryShader;
        [NativeTypeName("HRESULT (const void *, SIZE_T, const D3D10_SO_DECLARATION_ENTRY *, UINT, UINT, ID3D10GeometryShader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, nuint, D3D10_SO_DECLARATION_ENTRY*, uint, uint, ID3D10GeometryShader**, int> CreateGeometryShaderWithStreamOutput;
        [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D10PixelShader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, nuint, ID3D10PixelShader**, int> CreatePixelShader;
        [NativeTypeName("HRESULT (const D3D10_BLEND_DESC *, ID3D10BlendState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_BLEND_DESC*, ID3D10BlendState**, int> CreateBlendState;
        [NativeTypeName("HRESULT (const D3D10_DEPTH_STENCIL_DESC *, ID3D10DepthStencilState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_DEPTH_STENCIL_DESC*, ID3D10DepthStencilState**, int> CreateDepthStencilState;
        [NativeTypeName("HRESULT (const D3D10_RASTERIZER_DESC *, ID3D10RasterizerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_RASTERIZER_DESC*, ID3D10RasterizerState**, int> CreateRasterizerState;
        [NativeTypeName("HRESULT (const D3D10_SAMPLER_DESC *, ID3D10SamplerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_SAMPLER_DESC*, ID3D10SamplerState**, int> CreateSamplerState;
        [NativeTypeName("HRESULT (const D3D10_QUERY_DESC *, ID3D10Query **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_QUERY_DESC*, ID3D10Query**, int> CreateQuery;
        [NativeTypeName("HRESULT (const D3D10_QUERY_DESC *, ID3D10Predicate **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_QUERY_DESC*, ID3D10Predicate**, int> CreatePredicate;
        [NativeTypeName("HRESULT (const D3D10_COUNTER_DESC *, ID3D10Counter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_COUNTER_DESC*, ID3D10Counter**, int> CreateCounter;
        [NativeTypeName("HRESULT (DXGI_FORMAT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FORMAT, uint*, int> CheckFormatSupport;
        [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_FORMAT, uint, uint*, int> CheckMultisampleQualityLevels;
        [NativeTypeName("void (D3D10_COUNTER_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_COUNTER_INFO*, void> CheckCounterInfo;
        [NativeTypeName("HRESULT (const D3D10_COUNTER_DESC *, D3D10_COUNTER_TYPE *, UINT *, LPSTR, UINT *, LPSTR, UINT *, LPSTR, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_COUNTER_DESC*, D3D10_COUNTER_TYPE*, uint*, sbyte*, uint*, sbyte*, uint*, sbyte*, uint*, int> CheckCounter;
        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetCreationFlags;
        [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, Guid*, void**, int> OpenSharedResource;
        [NativeTypeName("void (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, void> SetTextFilterSize;
        [NativeTypeName("void (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, void> GetTextFilterSize;
        [NativeTypeName("HRESULT (ID3D10Resource *, const D3D10_SHADER_RESOURCE_VIEW_DESC1 *, ID3D10ShaderResourceView1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Resource*, D3D10_SHADER_RESOURCE_VIEW_DESC1*, ID3D10ShaderResourceView1**, int> CreateShaderResourceView1;
        [NativeTypeName("HRESULT (const D3D10_BLEND_DESC1 *, ID3D10BlendState1 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_BLEND_DESC1*, ID3D10BlendState1**, int> CreateBlendState1;
        [NativeTypeName("D3D10_FEATURE_LEVEL1 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_FEATURE_LEVEL1> GetFeatureLevel;
    }
}