// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("B4E3C01D-E79E-4637-91B2-510E9F4C9B8F")]
[NativeTypeName("struct ID3D11DeviceContext3 : ID3D11DeviceContext2")]
[NativeInheritance("ID3D11DeviceContext2")]
public unsafe partial struct ID3D11DeviceContext3 : ID3D11DeviceContext3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11DeviceContext3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11DeviceContext3, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11DeviceContext3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11DeviceContext3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device* ppDevice)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Device*, void>)((*lpVtbl)[3]))(
            this,
            ppDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D11DeviceContext3, Guid*, uint*, void*, int>)((*lpVtbl)[4])
        )(this, guid, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<ID3D11DeviceContext3, Guid*, uint, void*, int>)((*lpVtbl)[5]))(
            this,
            guid,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return ((delegate* unmanaged<ID3D11DeviceContext3, Guid*, IUnknown, int>)((*lpVtbl)[6]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void VSSetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[7]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void PSSetShaderResources(
        uint StartSlot,
        uint NumViews,
        [NativeTypeName("ID3D11ShaderResourceView *const *")]
            ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[8])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void PSSetShader(
        ID3D11PixelShader pPixelShader,
        [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance* ppClassInstances,
        uint NumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11PixelShader,
                ID3D11ClassInstance*,
                uint,
                void>)((*lpVtbl)[9])
        )(this, pPixelShader, ppClassInstances, NumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void PSSetSamplers(
        uint StartSlot,
        uint NumSamplers,
        [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState* ppSamplers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[10]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void VSSetShader(
        ID3D11VertexShader pVertexShader,
        [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance* ppClassInstances,
        uint NumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11VertexShader,
                ID3D11ClassInstance*,
                uint,
                void>)((*lpVtbl)[11])
        )(this, pVertexShader, ppClassInstances, NumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, uint, uint, int, void>)((*lpVtbl)[12]))(
            this,
            IndexCount,
            StartIndexLocation,
            BaseVertexLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void Draw(uint VertexCount, uint StartVertexLocation)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, uint, uint, void>)((*lpVtbl)[13]))(
            this,
            VertexCount,
            StartVertexLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Map(
        ID3D11Resource pResource,
        uint Subresource,
        D3D11_MAP MapType,
        uint MapFlags,
        D3D11_MAPPED_SUBRESOURCE* pMappedResource
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Resource,
                uint,
                D3D11_MAP,
                uint,
                D3D11_MAPPED_SUBRESOURCE*,
                int>)((*lpVtbl)[14])
        )(this, pResource, Subresource, MapType, MapFlags, pMappedResource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void Unmap(ID3D11Resource pResource, uint Subresource)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Resource, uint, void>)((*lpVtbl)[15]))(
            this,
            pResource,
            Subresource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void PSSetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[16]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void IASetInputLayout(ID3D11InputLayout pInputLayout)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11InputLayout, void>)((*lpVtbl)[17]))(
            this,
            pInputLayout
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void IASetVertexBuffers(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppVertexBuffers,
        [NativeTypeName("const UINT *")] uint* pStrides,
        [NativeTypeName("const UINT *")] uint* pOffsets
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[18])
        )(this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void IASetIndexBuffer(ID3D11Buffer pIndexBuffer, DXGI_FORMAT Format, uint Offset)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11Buffer, DXGI_FORMAT, uint, void>)(
                (*lpVtbl)[19]
            )
        )(this, pIndexBuffer, Format, Offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void DrawIndexedInstanced(
        uint IndexCountPerInstance,
        uint InstanceCount,
        uint StartIndexLocation,
        int BaseVertexLocation,
        uint StartInstanceLocation
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, uint, int, uint, void>)(
                (*lpVtbl)[20]
            )
        )(
            this,
            IndexCountPerInstance,
            InstanceCount,
            StartIndexLocation,
            BaseVertexLocation,
            StartInstanceLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void DrawInstanced(
        uint VertexCountPerInstance,
        uint InstanceCount,
        uint StartVertexLocation,
        uint StartInstanceLocation
    )
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, uint, uint, uint, uint, void>)((*lpVtbl)[21]))(
            this,
            VertexCountPerInstance,
            InstanceCount,
            StartVertexLocation,
            StartInstanceLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void GSSetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[22]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void GSSetShader(
        ID3D11GeometryShader pShader,
        [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance* ppClassInstances,
        uint NumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11GeometryShader,
                ID3D11ClassInstance*,
                uint,
                void>)((*lpVtbl)[23])
        )(this, pShader, ppClassInstances, NumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void IASetPrimitiveTopology(
        [NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY Topology
    )
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, D3D_PRIMITIVE_TOPOLOGY, void>)((*lpVtbl)[24]))(
            this,
            Topology
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void VSSetShaderResources(
        uint StartSlot,
        uint NumViews,
        [NativeTypeName("ID3D11ShaderResourceView *const *")]
            ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[25])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void VSSetSamplers(
        uint StartSlot,
        uint NumSamplers,
        [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState* ppSamplers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[26]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void Begin(ID3D11Asynchronous pAsync)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Asynchronous, void>)((*lpVtbl)[27]))(
            this,
            pAsync
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void End(ID3D11Asynchronous pAsync)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Asynchronous, void>)((*lpVtbl)[28]))(
            this,
            pAsync
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetData(ID3D11Asynchronous pAsync, void* pData, uint DataSize, uint GetDataFlags)
    {
        return (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11Asynchronous, void*, uint, uint, int>)(
                (*lpVtbl)[29]
            )
        )(this, pAsync, pData, DataSize, GetDataFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void SetPredication(ID3D11Predicate pPredicate, BOOL PredicateValue)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Predicate, BOOL, void>)((*lpVtbl)[30]))(
            this,
            pPredicate,
            PredicateValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void GSSetShaderResources(
        uint StartSlot,
        uint NumViews,
        [NativeTypeName("ID3D11ShaderResourceView *const *")]
            ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[31])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public void GSSetSamplers(
        uint StartSlot,
        uint NumSamplers,
        [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState* ppSamplers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[32]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public void OMSetRenderTargets(
        uint NumViews,
        [NativeTypeName("ID3D11RenderTargetView *const *")]
            ID3D11RenderTargetView* ppRenderTargetViews,
        ID3D11DepthStencilView pDepthStencilView
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                ID3D11RenderTargetView*,
                ID3D11DepthStencilView,
                void>)((*lpVtbl)[33])
        )(this, NumViews, ppRenderTargetViews, pDepthStencilView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void OMSetRenderTargetsAndUnorderedAccessViews(
        uint NumRTVs,
        [NativeTypeName("ID3D11RenderTargetView *const *")]
            ID3D11RenderTargetView* ppRenderTargetViews,
        ID3D11DepthStencilView pDepthStencilView,
        uint UAVStartSlot,
        uint NumUAVs,
        [NativeTypeName("ID3D11UnorderedAccessView *const *")]
            ID3D11UnorderedAccessView* ppUnorderedAccessViews,
        [NativeTypeName("const UINT *")] uint* pUAVInitialCounts
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                ID3D11RenderTargetView*,
                ID3D11DepthStencilView,
                uint,
                uint,
                ID3D11UnorderedAccessView*,
                uint*,
                void>)((*lpVtbl)[34])
        )(
            this,
            NumRTVs,
            ppRenderTargetViews,
            pDepthStencilView,
            UAVStartSlot,
            NumUAVs,
            ppUnorderedAccessViews,
            pUAVInitialCounts
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public void OMSetBlendState(
        ID3D11BlendState pBlendState,
        [NativeTypeName("const FLOAT[4]")] float* BlendFactor,
        uint SampleMask
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11BlendState, float*, uint, void>)(
                (*lpVtbl)[35]
            )
        )(this, pBlendState, BlendFactor, SampleMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void OMSetDepthStencilState(ID3D11DepthStencilState pDepthStencilState, uint StencilRef)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11DepthStencilState, uint, void>)(
                (*lpVtbl)[36]
            )
        )(this, pDepthStencilState, StencilRef);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public void SOSetTargets(
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppSOTargets,
        [NativeTypeName("const UINT *")] uint* pOffsets
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, ID3D11Buffer*, uint*, void>)(
                (*lpVtbl)[37]
            )
        )(this, NumBuffers, ppSOTargets, pOffsets);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void DrawAuto()
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, void>)((*lpVtbl)[38]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public void DrawIndexedInstancedIndirect(
        ID3D11Buffer pBufferForArgs,
        uint AlignedByteOffsetForArgs
    )
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Buffer, uint, void>)((*lpVtbl)[39]))(
            this,
            pBufferForArgs,
            AlignedByteOffsetForArgs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public void DrawInstancedIndirect(ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Buffer, uint, void>)((*lpVtbl)[40]))(
            this,
            pBufferForArgs,
            AlignedByteOffsetForArgs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, uint, uint, uint, void>)((*lpVtbl)[41]))(
            this,
            ThreadGroupCountX,
            ThreadGroupCountY,
            ThreadGroupCountZ
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public void DispatchIndirect(ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Buffer, uint, void>)((*lpVtbl)[42]))(
            this,
            pBufferForArgs,
            AlignedByteOffsetForArgs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public void RSSetState(ID3D11RasterizerState pRasterizerState)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11RasterizerState, void>)((*lpVtbl)[43]))(
            this,
            pRasterizerState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public void RSSetViewports(
        uint NumViewports,
        [NativeTypeName("const D3D11_VIEWPORT *")] D3D11_VIEWPORT* pViewports
    )
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, uint, D3D11_VIEWPORT*, void>)((*lpVtbl)[44]))(
            this,
            NumViewports,
            pViewports
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public void RSSetScissorRects(
        uint NumRects,
        [NativeTypeName("const D3D11_RECT *")] RECT* pRects
    )
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, uint, RECT*, void>)((*lpVtbl)[45]))(
            this,
            NumRects,
            pRects
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public void CopySubresourceRegion(
        ID3D11Resource pDstResource,
        uint DstSubresource,
        uint DstX,
        uint DstY,
        uint DstZ,
        ID3D11Resource pSrcResource,
        uint SrcSubresource,
        [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Resource,
                uint,
                uint,
                uint,
                uint,
                ID3D11Resource,
                uint,
                D3D11_BOX*,
                void>)((*lpVtbl)[46])
        )(
            this,
            pDstResource,
            DstSubresource,
            DstX,
            DstY,
            DstZ,
            pSrcResource,
            SrcSubresource,
            pSrcBox
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public void CopyResource(ID3D11Resource pDstResource, ID3D11Resource pSrcResource)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11Resource, ID3D11Resource, void>)(
                (*lpVtbl)[47]
            )
        )(this, pDstResource, pSrcResource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public void UpdateSubresource(
        ID3D11Resource pDstResource,
        uint DstSubresource,
        [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox,
        [NativeTypeName("const void *")] void* pSrcData,
        uint SrcRowPitch,
        uint SrcDepthPitch
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Resource,
                uint,
                D3D11_BOX*,
                void*,
                uint,
                uint,
                void>)((*lpVtbl)[48])
        )(this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public void CopyStructureCount(
        ID3D11Buffer pDstBuffer,
        uint DstAlignedByteOffset,
        ID3D11UnorderedAccessView pSrcView
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Buffer,
                uint,
                ID3D11UnorderedAccessView,
                void>)((*lpVtbl)[49])
        )(this, pDstBuffer, DstAlignedByteOffset, pSrcView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public void ClearRenderTargetView(
        ID3D11RenderTargetView pRenderTargetView,
        [NativeTypeName("const FLOAT[4]")] float* ColorRGBA
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11RenderTargetView, float*, void>)(
                (*lpVtbl)[50]
            )
        )(this, pRenderTargetView, ColorRGBA);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public void ClearUnorderedAccessViewUint(
        ID3D11UnorderedAccessView pUnorderedAccessView,
        [NativeTypeName("const UINT[4]")] uint* Values
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11UnorderedAccessView, uint*, void>)(
                (*lpVtbl)[51]
            )
        )(this, pUnorderedAccessView, Values);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public void ClearUnorderedAccessViewFloat(
        ID3D11UnorderedAccessView pUnorderedAccessView,
        [NativeTypeName("const FLOAT[4]")] float* Values
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11UnorderedAccessView, float*, void>)(
                (*lpVtbl)[52]
            )
        )(this, pUnorderedAccessView, Values);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public void ClearDepthStencilView(
        ID3D11DepthStencilView pDepthStencilView,
        uint ClearFlags,
        float Depth,
        [NativeTypeName("UINT8")] byte Stencil
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11DepthStencilView,
                uint,
                float,
                byte,
                void>)((*lpVtbl)[53])
        )(this, pDepthStencilView, ClearFlags, Depth, Stencil);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public void GenerateMips(ID3D11ShaderResourceView pShaderResourceView)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11ShaderResourceView, void>)(
                (*lpVtbl)[54]
            )
        )(this, pShaderResourceView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public void SetResourceMinLOD(ID3D11Resource pResource, float MinLOD)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Resource, float, void>)((*lpVtbl)[55]))(
            this,
            pResource,
            MinLOD
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public float GetResourceMinLOD(ID3D11Resource pResource)
    {
        return ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Resource, float>)((*lpVtbl)[56]))(
            this,
            pResource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public void ResolveSubresource(
        ID3D11Resource pDstResource,
        uint DstSubresource,
        ID3D11Resource pSrcResource,
        uint SrcSubresource,
        DXGI_FORMAT Format
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Resource,
                uint,
                ID3D11Resource,
                uint,
                DXGI_FORMAT,
                void>)((*lpVtbl)[57])
        )(this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public void ExecuteCommandList(ID3D11CommandList pCommandList, BOOL RestoreContextState)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11CommandList, BOOL, void>)((*lpVtbl)[58]))(
            this,
            pCommandList,
            RestoreContextState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public void HSSetShaderResources(
        uint StartSlot,
        uint NumViews,
        [NativeTypeName("ID3D11ShaderResourceView *const *")]
            ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[59])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public void HSSetShader(
        ID3D11HullShader pHullShader,
        [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance* ppClassInstances,
        uint NumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11HullShader,
                ID3D11ClassInstance*,
                uint,
                void>)((*lpVtbl)[60])
        )(this, pHullShader, ppClassInstances, NumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public void HSSetSamplers(
        uint StartSlot,
        uint NumSamplers,
        [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState* ppSamplers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[61]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public void HSSetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[62]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public void DSSetShaderResources(
        uint StartSlot,
        uint NumViews,
        [NativeTypeName("ID3D11ShaderResourceView *const *")]
            ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[63])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public void DSSetShader(
        ID3D11DomainShader pDomainShader,
        [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance* ppClassInstances,
        uint NumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11DomainShader,
                ID3D11ClassInstance*,
                uint,
                void>)((*lpVtbl)[64])
        )(this, pDomainShader, ppClassInstances, NumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public void DSSetSamplers(
        uint StartSlot,
        uint NumSamplers,
        [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState* ppSamplers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[65]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public void DSSetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[66]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public void CSSetShaderResources(
        uint StartSlot,
        uint NumViews,
        [NativeTypeName("ID3D11ShaderResourceView *const *")]
            ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[67])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public void CSSetUnorderedAccessViews(
        uint StartSlot,
        uint NumUAVs,
        [NativeTypeName("ID3D11UnorderedAccessView *const *")]
            ID3D11UnorderedAccessView* ppUnorderedAccessViews,
        [NativeTypeName("const UINT *")] uint* pUAVInitialCounts
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11UnorderedAccessView*,
                uint*,
                void>)((*lpVtbl)[68])
        )(this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public void CSSetShader(
        ID3D11ComputeShader pComputeShader,
        [NativeTypeName("ID3D11ClassInstance *const *")] ID3D11ClassInstance* ppClassInstances,
        uint NumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11ComputeShader,
                ID3D11ClassInstance*,
                uint,
                void>)((*lpVtbl)[69])
        )(this, pComputeShader, ppClassInstances, NumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public void CSSetSamplers(
        uint StartSlot,
        uint NumSamplers,
        [NativeTypeName("ID3D11SamplerState *const *")] ID3D11SamplerState* ppSamplers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[70]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public void CSSetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[71]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public void VSGetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[72]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public void PSGetShaderResources(
        uint StartSlot,
        uint NumViews,
        ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[73])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public void PSGetShader(
        ID3D11PixelShader* ppPixelShader,
        ID3D11ClassInstance* ppClassInstances,
        uint* pNumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11PixelShader*,
                ID3D11ClassInstance*,
                uint*,
                void>)((*lpVtbl)[74])
        )(this, ppPixelShader, ppClassInstances, pNumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public void PSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState* ppSamplers)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[75]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public void VSGetShader(
        ID3D11VertexShader* ppVertexShader,
        ID3D11ClassInstance* ppClassInstances,
        uint* pNumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11VertexShader*,
                ID3D11ClassInstance*,
                uint*,
                void>)((*lpVtbl)[76])
        )(this, ppVertexShader, ppClassInstances, pNumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public void PSGetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[77]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public void IAGetInputLayout(ID3D11InputLayout* ppInputLayout)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11InputLayout*, void>)((*lpVtbl)[78]))(
            this,
            ppInputLayout
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public void IAGetVertexBuffers(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppVertexBuffers,
        uint* pStrides,
        uint* pOffsets
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[79])
        )(this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public void IAGetIndexBuffer(ID3D11Buffer* pIndexBuffer, DXGI_FORMAT* Format, uint* Offset)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11Buffer*, DXGI_FORMAT*, uint*, void>)(
                (*lpVtbl)[80]
            )
        )(this, pIndexBuffer, Format, Offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public void GSGetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[81]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public void GSGetShader(
        ID3D11GeometryShader* ppGeometryShader,
        ID3D11ClassInstance* ppClassInstances,
        uint* pNumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11GeometryShader*,
                ID3D11ClassInstance*,
                uint*,
                void>)((*lpVtbl)[82])
        )(this, ppGeometryShader, ppClassInstances, pNumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public void IAGetPrimitiveTopology(
        [NativeTypeName("D3D11_PRIMITIVE_TOPOLOGY *")] D3D_PRIMITIVE_TOPOLOGY* pTopology
    )
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, D3D_PRIMITIVE_TOPOLOGY*, void>)((*lpVtbl)[83]))(
            this,
            pTopology
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public void VSGetShaderResources(
        uint StartSlot,
        uint NumViews,
        ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[84])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public void VSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState* ppSamplers)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[85]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public void GetPredication(ID3D11Predicate* ppPredicate, BOOL* pPredicateValue)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Predicate*, BOOL*, void>)((*lpVtbl)[86]))(
            this,
            ppPredicate,
            pPredicateValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public void GSGetShaderResources(
        uint StartSlot,
        uint NumViews,
        ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[87])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public void GSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState* ppSamplers)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[88]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public void OMGetRenderTargets(
        uint NumViews,
        ID3D11RenderTargetView* ppRenderTargetViews,
        ID3D11DepthStencilView* ppDepthStencilView
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                ID3D11RenderTargetView*,
                ID3D11DepthStencilView*,
                void>)((*lpVtbl)[89])
        )(this, NumViews, ppRenderTargetViews, ppDepthStencilView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public void OMGetRenderTargetsAndUnorderedAccessViews(
        uint NumRTVs,
        ID3D11RenderTargetView* ppRenderTargetViews,
        ID3D11DepthStencilView* ppDepthStencilView,
        uint UAVStartSlot,
        uint NumUAVs,
        ID3D11UnorderedAccessView* ppUnorderedAccessViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                ID3D11RenderTargetView*,
                ID3D11DepthStencilView*,
                uint,
                uint,
                ID3D11UnorderedAccessView*,
                void>)((*lpVtbl)[90])
        )(
            this,
            NumRTVs,
            ppRenderTargetViews,
            ppDepthStencilView,
            UAVStartSlot,
            NumUAVs,
            ppUnorderedAccessViews
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public void OMGetBlendState(
        ID3D11BlendState* ppBlendState,
        [NativeTypeName("FLOAT[4]")] float* BlendFactor,
        uint* pSampleMask
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11BlendState*, float*, uint*, void>)(
                (*lpVtbl)[91]
            )
        )(this, ppBlendState, BlendFactor, pSampleMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public void OMGetDepthStencilState(
        ID3D11DepthStencilState* ppDepthStencilState,
        uint* pStencilRef
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11DepthStencilState*, uint*, void>)(
                (*lpVtbl)[92]
            )
        )(this, ppDepthStencilState, pStencilRef);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public void SOGetTargets(uint NumBuffers, ID3D11Buffer* ppSOTargets)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, uint, ID3D11Buffer*, void>)((*lpVtbl)[93]))(
            this,
            NumBuffers,
            ppSOTargets
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public void RSGetState(ID3D11RasterizerState* ppRasterizerState)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11RasterizerState*, void>)((*lpVtbl)[94]))(
            this,
            ppRasterizerState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public void RSGetViewports(uint* pNumViewports, D3D11_VIEWPORT* pViewports)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, uint*, D3D11_VIEWPORT*, void>)((*lpVtbl)[95]))(
            this,
            pNumViewports,
            pViewports
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public void RSGetScissorRects(uint* pNumRects, [NativeTypeName("D3D11_RECT *")] RECT* pRects)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, uint*, RECT*, void>)((*lpVtbl)[96]))(
            this,
            pNumRects,
            pRects
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public void HSGetShaderResources(
        uint StartSlot,
        uint NumViews,
        ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[97])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public void HSGetShader(
        ID3D11HullShader* ppHullShader,
        ID3D11ClassInstance* ppClassInstances,
        uint* pNumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11HullShader*,
                ID3D11ClassInstance*,
                uint*,
                void>)((*lpVtbl)[98])
        )(this, ppHullShader, ppClassInstances, pNumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public void HSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState* ppSamplers)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[99]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public void HSGetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[100]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public void DSGetShaderResources(
        uint StartSlot,
        uint NumViews,
        ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[101])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public void DSGetShader(
        ID3D11DomainShader* ppDomainShader,
        ID3D11ClassInstance* ppClassInstances,
        uint* pNumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11DomainShader*,
                ID3D11ClassInstance*,
                uint*,
                void>)((*lpVtbl)[102])
        )(this, ppDomainShader, ppClassInstances, pNumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public void DSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState* ppSamplers)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[103]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public void DSGetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[104]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public void CSGetShaderResources(
        uint StartSlot,
        uint NumViews,
        ID3D11ShaderResourceView* ppShaderResourceViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11ShaderResourceView*,
                void>)((*lpVtbl)[105])
        )(this, StartSlot, NumViews, ppShaderResourceViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public void CSGetUnorderedAccessViews(
        uint StartSlot,
        uint NumUAVs,
        ID3D11UnorderedAccessView* ppUnorderedAccessViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11UnorderedAccessView*,
                void>)((*lpVtbl)[106])
        )(this, StartSlot, NumUAVs, ppUnorderedAccessViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public void CSGetShader(
        ID3D11ComputeShader* ppComputeShader,
        ID3D11ClassInstance* ppClassInstances,
        uint* pNumClassInstances
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11ComputeShader*,
                ID3D11ClassInstance*,
                uint*,
                void>)((*lpVtbl)[107])
        )(this, ppComputeShader, ppClassInstances, pNumClassInstances);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public void CSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState* ppSamplers)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11SamplerState*, void>)(
                (*lpVtbl)[108]
            )
        )(this, StartSlot, NumSamplers, ppSamplers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public void CSGetConstantBuffers(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, uint, uint, ID3D11Buffer*, void>)(
                (*lpVtbl)[109]
            )
        )(this, StartSlot, NumBuffers, ppConstantBuffers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public void ClearState()
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, void>)((*lpVtbl)[110]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public void Flush()
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, void>)((*lpVtbl)[111]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public new D3D11_DEVICE_CONTEXT_TYPE GetType()
    {
        return (
            (delegate* unmanaged<ID3D11DeviceContext3, D3D11_DEVICE_CONTEXT_TYPE>)((*lpVtbl)[112])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public uint GetContextFlags()
    {
        return ((delegate* unmanaged<ID3D11DeviceContext3, uint>)((*lpVtbl)[113]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT FinishCommandList(
        BOOL RestoreDeferredContextState,
        ID3D11CommandList* ppCommandList
    )
    {
        return (
            (delegate* unmanaged<ID3D11DeviceContext3, BOOL, ID3D11CommandList*, int>)(
                (*lpVtbl)[114]
            )
        )(this, RestoreDeferredContextState, ppCommandList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public void CopySubresourceRegion1(
        ID3D11Resource pDstResource,
        uint DstSubresource,
        uint DstX,
        uint DstY,
        uint DstZ,
        ID3D11Resource pSrcResource,
        uint SrcSubresource,
        [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pSrcBox,
        uint CopyFlags
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Resource,
                uint,
                uint,
                uint,
                uint,
                ID3D11Resource,
                uint,
                D3D11_BOX*,
                uint,
                void>)((*lpVtbl)[115])
        )(
            this,
            pDstResource,
            DstSubresource,
            DstX,
            DstY,
            DstZ,
            pSrcResource,
            SrcSubresource,
            pSrcBox,
            CopyFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public void UpdateSubresource1(
        ID3D11Resource pDstResource,
        uint DstSubresource,
        [NativeTypeName("const D3D11_BOX *")] D3D11_BOX* pDstBox,
        [NativeTypeName("const void *")] void* pSrcData,
        uint SrcRowPitch,
        uint SrcDepthPitch,
        uint CopyFlags
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Resource,
                uint,
                D3D11_BOX*,
                void*,
                uint,
                uint,
                uint,
                void>)((*lpVtbl)[116])
        )(
            this,
            pDstResource,
            DstSubresource,
            pDstBox,
            pSrcData,
            SrcRowPitch,
            SrcDepthPitch,
            CopyFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public void DiscardResource(ID3D11Resource pResource)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11Resource, void>)((*lpVtbl)[117]))(
            this,
            pResource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public void DiscardView(ID3D11View pResourceView)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ID3D11View, void>)((*lpVtbl)[118]))(
            this,
            pResourceView
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public void VSSetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers,
        [NativeTypeName("const UINT *")] uint* pFirstConstant,
        [NativeTypeName("const UINT *")] uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[119])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public void HSSetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers,
        [NativeTypeName("const UINT *")] uint* pFirstConstant,
        [NativeTypeName("const UINT *")] uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[120])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public void DSSetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers,
        [NativeTypeName("const UINT *")] uint* pFirstConstant,
        [NativeTypeName("const UINT *")] uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[121])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public void GSSetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers,
        [NativeTypeName("const UINT *")] uint* pFirstConstant,
        [NativeTypeName("const UINT *")] uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[122])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public void PSSetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers,
        [NativeTypeName("const UINT *")] uint* pFirstConstant,
        [NativeTypeName("const UINT *")] uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[123])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public void CSSetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        [NativeTypeName("ID3D11Buffer *const *")] ID3D11Buffer* ppConstantBuffers,
        [NativeTypeName("const UINT *")] uint* pFirstConstant,
        [NativeTypeName("const UINT *")] uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[124])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public void VSGetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers,
        uint* pFirstConstant,
        uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[125])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(126)]
    public void HSGetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers,
        uint* pFirstConstant,
        uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[126])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(127)]
    public void DSGetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers,
        uint* pFirstConstant,
        uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[127])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(128)]
    public void GSGetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers,
        uint* pFirstConstant,
        uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[128])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(129)]
    public void PSGetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers,
        uint* pFirstConstant,
        uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[129])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(130)]
    public void CSGetConstantBuffers1(
        uint StartSlot,
        uint NumBuffers,
        ID3D11Buffer* ppConstantBuffers,
        uint* pFirstConstant,
        uint* pNumConstants
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                uint,
                uint,
                ID3D11Buffer*,
                uint*,
                uint*,
                void>)((*lpVtbl)[130])
        )(this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(131)]
    public void SwapDeviceContextState(
        ID3DDeviceContextState pState,
        ID3DDeviceContextState* ppPreviousState
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3DDeviceContextState,
                ID3DDeviceContextState*,
                void>)((*lpVtbl)[131])
        )(this, pState, ppPreviousState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(132)]
    public void ClearView(
        ID3D11View pView,
        [NativeTypeName("const FLOAT[4]")] float* Color,
        [NativeTypeName("const D3D11_RECT *")] RECT* pRect,
        uint NumRects
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11View, float*, RECT*, uint, void>)(
                (*lpVtbl)[132]
            )
        )(this, pView, Color, pRect, NumRects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(133)]
    public void DiscardView1(
        ID3D11View pResourceView,
        [NativeTypeName("const D3D11_RECT *")] RECT* pRects,
        uint NumRects
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11View, RECT*, uint, void>)(
                (*lpVtbl)[133]
            )
        )(this, pResourceView, pRects, NumRects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(134)]
    public HRESULT UpdateTileMappings(
        ID3D11Resource pTiledResource,
        uint NumTiledResourceRegions,
        [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")]
            D3D11_TILED_RESOURCE_COORDINATE* pTiledResourceRegionStartCoordinates,
        [NativeTypeName("const D3D11_TILE_REGION_SIZE *")]
            D3D11_TILE_REGION_SIZE* pTiledResourceRegionSizes,
        ID3D11Buffer pTilePool,
        uint NumRanges,
        [NativeTypeName("const UINT *")] uint* pRangeFlags,
        [NativeTypeName("const UINT *")] uint* pTilePoolStartOffsets,
        [NativeTypeName("const UINT *")] uint* pRangeTileCounts,
        uint Flags
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Resource,
                uint,
                D3D11_TILED_RESOURCE_COORDINATE*,
                D3D11_TILE_REGION_SIZE*,
                ID3D11Buffer,
                uint,
                uint*,
                uint*,
                uint*,
                uint,
                int>)((*lpVtbl)[134])
        )(
            this,
            pTiledResource,
            NumTiledResourceRegions,
            pTiledResourceRegionStartCoordinates,
            pTiledResourceRegionSizes,
            pTilePool,
            NumRanges,
            pRangeFlags,
            pTilePoolStartOffsets,
            pRangeTileCounts,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(135)]
    public HRESULT CopyTileMappings(
        ID3D11Resource pDestTiledResource,
        [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")]
            D3D11_TILED_RESOURCE_COORDINATE* pDestRegionStartCoordinate,
        ID3D11Resource pSourceTiledResource,
        [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")]
            D3D11_TILED_RESOURCE_COORDINATE* pSourceRegionStartCoordinate,
        [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTileRegionSize,
        uint Flags
    )
    {
        return (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Resource,
                D3D11_TILED_RESOURCE_COORDINATE*,
                ID3D11Resource,
                D3D11_TILED_RESOURCE_COORDINATE*,
                D3D11_TILE_REGION_SIZE*,
                uint,
                int>)((*lpVtbl)[135])
        )(
            this,
            pDestTiledResource,
            pDestRegionStartCoordinate,
            pSourceTiledResource,
            pSourceRegionStartCoordinate,
            pTileRegionSize,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(136)]
    public void CopyTiles(
        ID3D11Resource pTiledResource,
        [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")]
            D3D11_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate,
        [NativeTypeName("const D3D11_TILE_REGION_SIZE *")] D3D11_TILE_REGION_SIZE* pTileRegionSize,
        ID3D11Buffer pBuffer,
        [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes,
        uint Flags
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Resource,
                D3D11_TILED_RESOURCE_COORDINATE*,
                D3D11_TILE_REGION_SIZE*,
                ID3D11Buffer,
                ulong,
                uint,
                void>)((*lpVtbl)[136])
        )(
            this,
            pTiledResource,
            pTileRegionStartCoordinate,
            pTileRegionSize,
            pBuffer,
            BufferStartOffsetInBytes,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(137)]
    public void UpdateTiles(
        ID3D11Resource pDestTiledResource,
        [NativeTypeName("const D3D11_TILED_RESOURCE_COORDINATE *")]
            D3D11_TILED_RESOURCE_COORDINATE* pDestTileRegionStartCoordinate,
        [NativeTypeName("const D3D11_TILE_REGION_SIZE *")]
            D3D11_TILE_REGION_SIZE* pDestTileRegionSize,
        [NativeTypeName("const void *")] void* pSourceTileData,
        uint Flags
    )
    {
        (
            (delegate* unmanaged<
                ID3D11DeviceContext3,
                ID3D11Resource,
                D3D11_TILED_RESOURCE_COORDINATE*,
                D3D11_TILE_REGION_SIZE*,
                void*,
                uint,
                void>)((*lpVtbl)[137])
        )(
            this,
            pDestTiledResource,
            pDestTileRegionStartCoordinate,
            pDestTileRegionSize,
            pSourceTileData,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(138)]
    public HRESULT ResizeTilePool(
        ID3D11Buffer pTilePool,
        [NativeTypeName("UINT64")] ulong NewSizeInBytes
    )
    {
        return (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11Buffer, ulong, int>)((*lpVtbl)[138])
        )(this, pTilePool, NewSizeInBytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(139)]
    public void TiledResourceBarrier(
        ID3D11DeviceChild pTiledResourceOrViewAccessBeforeBarrier,
        ID3D11DeviceChild pTiledResourceOrViewAccessAfterBarrier
    )
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, ID3D11DeviceChild, ID3D11DeviceChild, void>)(
                (*lpVtbl)[139]
            )
        )(this, pTiledResourceOrViewAccessBeforeBarrier, pTiledResourceOrViewAccessAfterBarrier);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(140)]
    public BOOL IsAnnotationEnabled()
    {
        return ((delegate* unmanaged<ID3D11DeviceContext3, int>)((*lpVtbl)[140]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(141)]
    public void SetMarkerInt([NativeTypeName("LPCWSTR")] ushort* pLabel, int Data)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ushort*, int, void>)((*lpVtbl)[141]))(
            this,
            pLabel,
            Data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(142)]
    public void BeginEventInt([NativeTypeName("LPCWSTR")] ushort* pLabel, int Data)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, ushort*, int, void>)((*lpVtbl)[142]))(
            this,
            pLabel,
            Data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(143)]
    public void EndEvent()
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, void>)((*lpVtbl)[143]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(144)]
    public void Flush1(D3D11_CONTEXT_TYPE ContextType, HANDLE hEvent)
    {
        (
            (delegate* unmanaged<ID3D11DeviceContext3, D3D11_CONTEXT_TYPE, HANDLE, void>)(
                (*lpVtbl)[144]
            )
        )(this, ContextType, hEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(145)]
    public void SetHardwareProtectionState(BOOL HwProtectionEnable)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, BOOL, void>)((*lpVtbl)[145]))(
            this,
            HwProtectionEnable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(146)]
    public void GetHardwareProtectionState(BOOL* pHwProtectionEnable)
    {
        ((delegate* unmanaged<ID3D11DeviceContext3, BOOL*, void>)((*lpVtbl)[146]))(
            this,
            pHwProtectionEnable
        );
    }

    public interface Interface : ID3D11DeviceContext2.Interface
    {
        [VtblIndex(144)]
        void Flush1(D3D11_CONTEXT_TYPE ContextType, HANDLE hEvent);

        [VtblIndex(145)]
        void SetHardwareProtectionState(BOOL HwProtectionEnable);

        [VtblIndex(146)]
        void GetHardwareProtectionState(BOOL* pHwProtectionEnable);
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

        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device*, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> VSSetConstantBuffers;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> PSSetShaderResources;

        [NativeTypeName(
            "void (ID3D11PixelShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11PixelShader,
            ID3D11ClassInstance*,
            uint,
            void> PSSetShader;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> PSSetSamplers;

        [NativeTypeName(
            "void (ID3D11VertexShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VertexShader,
            ID3D11ClassInstance*,
            uint,
            void> VSSetShader;

        [NativeTypeName("void (UINT, UINT, INT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int, void> DrawIndexed;

        [NativeTypeName("void (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, void> Draw;

        [NativeTypeName(
            "HRESULT (ID3D11Resource *, UINT, D3D11_MAP, UINT, D3D11_MAPPED_SUBRESOURCE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            uint,
            D3D11_MAP,
            uint,
            D3D11_MAPPED_SUBRESOURCE*,
            int> Map;

        [NativeTypeName("void (ID3D11Resource *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource, uint, void> Unmap;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> PSSetConstantBuffers;

        [NativeTypeName("void (ID3D11InputLayout *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11InputLayout, void> IASetInputLayout;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> IASetVertexBuffers;

        [NativeTypeName("void (ID3D11Buffer *, DXGI_FORMAT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Buffer, DXGI_FORMAT, uint, void> IASetIndexBuffer;

        [NativeTypeName("void (UINT, UINT, UINT, INT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;

        [NativeTypeName("void (UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, uint, void> DrawInstanced;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> GSSetConstantBuffers;

        [NativeTypeName(
            "void (ID3D11GeometryShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11GeometryShader,
            ID3D11ClassInstance*,
            uint,
            void> GSSetShader;

        [NativeTypeName("void (D3D11_PRIMITIVE_TOPOLOGY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D_PRIMITIVE_TOPOLOGY, void> IASetPrimitiveTopology;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> VSSetShaderResources;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> VSSetSamplers;

        [NativeTypeName("void (ID3D11Asynchronous *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Asynchronous, void> Begin;

        [NativeTypeName("void (ID3D11Asynchronous *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Asynchronous, void> End;

        [NativeTypeName(
            "HRESULT (ID3D11Asynchronous *, void *, UINT, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID3D11Asynchronous, void*, uint, uint, int> GetData;

        [NativeTypeName("void (ID3D11Predicate *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Predicate, BOOL, void> SetPredication;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> GSSetShaderResources;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> GSSetSamplers;

        [NativeTypeName(
            "void (UINT, ID3D11RenderTargetView *const *, ID3D11DepthStencilView *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ID3D11RenderTargetView*,
            ID3D11DepthStencilView,
            void> OMSetRenderTargets;

        [NativeTypeName(
            "void (UINT, ID3D11RenderTargetView *const *, ID3D11DepthStencilView *, UINT, UINT, ID3D11UnorderedAccessView *const *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ID3D11RenderTargetView*,
            ID3D11DepthStencilView,
            uint,
            uint,
            ID3D11UnorderedAccessView*,
            uint*,
            void> OMSetRenderTargetsAndUnorderedAccessViews;

        [NativeTypeName("void (ID3D11BlendState *, const FLOAT *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11BlendState, float*, uint, void> OMSetBlendState;

        [NativeTypeName("void (ID3D11DepthStencilState *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11DepthStencilState,
            uint,
            void> OMSetDepthStencilState;

        [NativeTypeName(
            "void (UINT, ID3D11Buffer *const *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ID3D11Buffer*, uint*, void> SOSetTargets;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> DrawAuto;

        [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Buffer, uint, void> DrawIndexedInstancedIndirect;

        [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Buffer, uint, void> DrawInstancedIndirect;

        [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, void> Dispatch;

        [NativeTypeName("void (ID3D11Buffer *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Buffer, uint, void> DispatchIndirect;

        [NativeTypeName("void (ID3D11RasterizerState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11RasterizerState, void> RSSetState;

        [NativeTypeName("void (UINT, const D3D11_VIEWPORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D11_VIEWPORT*, void> RSSetViewports;

        [NativeTypeName("void (UINT, const D3D11_RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT*, void> RSSetScissorRects;

        [NativeTypeName(
            "void (ID3D11Resource *, UINT, UINT, UINT, UINT, ID3D11Resource *, UINT, const D3D11_BOX *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            uint,
            uint,
            uint,
            uint,
            ID3D11Resource,
            uint,
            D3D11_BOX*,
            void> CopySubresourceRegion;

        [NativeTypeName("void (ID3D11Resource *, ID3D11Resource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource, ID3D11Resource, void> CopyResource;

        [NativeTypeName(
            "void (ID3D11Resource *, UINT, const D3D11_BOX *, const void *, UINT, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            uint,
            D3D11_BOX*,
            void*,
            uint,
            uint,
            void> UpdateSubresource;

        [NativeTypeName(
            "void (ID3D11Buffer *, UINT, ID3D11UnorderedAccessView *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Buffer,
            uint,
            ID3D11UnorderedAccessView,
            void> CopyStructureCount;

        [NativeTypeName("void (ID3D11RenderTargetView *, const FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11RenderTargetView,
            float*,
            void> ClearRenderTargetView;

        [NativeTypeName(
            "void (ID3D11UnorderedAccessView *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11UnorderedAccessView,
            uint*,
            void> ClearUnorderedAccessViewUint;

        [NativeTypeName(
            "void (ID3D11UnorderedAccessView *, const FLOAT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11UnorderedAccessView,
            float*,
            void> ClearUnorderedAccessViewFloat;

        [NativeTypeName(
            "void (ID3D11DepthStencilView *, UINT, FLOAT, UINT8) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11DepthStencilView,
            uint,
            float,
            byte,
            void> ClearDepthStencilView;

        [NativeTypeName("void (ID3D11ShaderResourceView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ShaderResourceView, void> GenerateMips;

        [NativeTypeName("void (ID3D11Resource *, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource, float, void> SetResourceMinLOD;

        [NativeTypeName("FLOAT (ID3D11Resource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource, float> GetResourceMinLOD;

        [NativeTypeName(
            "void (ID3D11Resource *, UINT, ID3D11Resource *, UINT, DXGI_FORMAT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            uint,
            ID3D11Resource,
            uint,
            DXGI_FORMAT,
            void> ResolveSubresource;

        [NativeTypeName("void (ID3D11CommandList *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11CommandList, BOOL, void> ExecuteCommandList;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> HSSetShaderResources;

        [NativeTypeName(
            "void (ID3D11HullShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11HullShader,
            ID3D11ClassInstance*,
            uint,
            void> HSSetShader;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> HSSetSamplers;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> HSSetConstantBuffers;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> DSSetShaderResources;

        [NativeTypeName(
            "void (ID3D11DomainShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11DomainShader,
            ID3D11ClassInstance*,
            uint,
            void> DSSetShader;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> DSSetSamplers;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> DSSetConstantBuffers;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11ShaderResourceView *const *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> CSSetShaderResources;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11UnorderedAccessView *const *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11UnorderedAccessView*,
            uint*,
            void> CSSetUnorderedAccessViews;

        [NativeTypeName(
            "void (ID3D11ComputeShader *, ID3D11ClassInstance *const *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11ComputeShader,
            ID3D11ClassInstance*,
            uint,
            void> CSSetShader;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> CSSetSamplers;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> CSSetConstantBuffers;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> VSGetConstantBuffers;

        [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> PSGetShaderResources;

        [NativeTypeName(
            "void (ID3D11PixelShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11PixelShader*,
            ID3D11ClassInstance*,
            uint*,
            void> PSGetShader;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> PSGetSamplers;

        [NativeTypeName(
            "void (ID3D11VertexShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11VertexShader*,
            ID3D11ClassInstance*,
            uint*,
            void> VSGetShader;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> PSGetConstantBuffers;

        [NativeTypeName("void (ID3D11InputLayout **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11InputLayout*, void> IAGetInputLayout;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> IAGetVertexBuffers;

        [NativeTypeName("void (ID3D11Buffer **, DXGI_FORMAT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Buffer*,
            DXGI_FORMAT*,
            uint*,
            void> IAGetIndexBuffer;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> GSGetConstantBuffers;

        [NativeTypeName(
            "void (ID3D11GeometryShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11GeometryShader*,
            ID3D11ClassInstance*,
            uint*,
            void> GSGetShader;

        [NativeTypeName("void (D3D11_PRIMITIVE_TOPOLOGY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D_PRIMITIVE_TOPOLOGY*, void> IAGetPrimitiveTopology;

        [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> VSGetShaderResources;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> VSGetSamplers;

        [NativeTypeName("void (ID3D11Predicate **, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Predicate*, BOOL*, void> GetPredication;

        [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> GSGetShaderResources;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> GSGetSamplers;

        [NativeTypeName(
            "void (UINT, ID3D11RenderTargetView **, ID3D11DepthStencilView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ID3D11RenderTargetView*,
            ID3D11DepthStencilView*,
            void> OMGetRenderTargets;

        [NativeTypeName(
            "void (UINT, ID3D11RenderTargetView **, ID3D11DepthStencilView **, UINT, UINT, ID3D11UnorderedAccessView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ID3D11RenderTargetView*,
            ID3D11DepthStencilView*,
            uint,
            uint,
            ID3D11UnorderedAccessView*,
            void> OMGetRenderTargetsAndUnorderedAccessViews;

        [NativeTypeName("void (ID3D11BlendState **, FLOAT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11BlendState*, float*, uint*, void> OMGetBlendState;

        [NativeTypeName("void (ID3D11DepthStencilState **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11DepthStencilState*,
            uint*,
            void> OMGetDepthStencilState;

        [NativeTypeName("void (UINT, ID3D11Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D11Buffer*, void> SOGetTargets;

        [NativeTypeName("void (ID3D11RasterizerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11RasterizerState*, void> RSGetState;

        [NativeTypeName("void (UINT *, D3D11_VIEWPORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, D3D11_VIEWPORT*, void> RSGetViewports;

        [NativeTypeName("void (UINT *, D3D11_RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, RECT*, void> RSGetScissorRects;

        [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> HSGetShaderResources;

        [NativeTypeName(
            "void (ID3D11HullShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11HullShader*,
            ID3D11ClassInstance*,
            uint*,
            void> HSGetShader;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> HSGetSamplers;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> HSGetConstantBuffers;

        [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> DSGetShaderResources;

        [NativeTypeName(
            "void (ID3D11DomainShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11DomainShader*,
            ID3D11ClassInstance*,
            uint*,
            void> DSGetShader;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> DSGetSamplers;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> DSGetConstantBuffers;

        [NativeTypeName("void (UINT, UINT, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11ShaderResourceView*,
            void> CSGetShaderResources;

        [NativeTypeName("void (UINT, UINT, ID3D11UnorderedAccessView **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11UnorderedAccessView*,
            void> CSGetUnorderedAccessViews;

        [NativeTypeName(
            "void (ID3D11ComputeShader **, ID3D11ClassInstance **, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11ComputeShader*,
            ID3D11ClassInstance*,
            uint*,
            void> CSGetShader;

        [NativeTypeName("void (UINT, UINT, ID3D11SamplerState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11SamplerState*, void> CSGetSamplers;

        [NativeTypeName("void (UINT, UINT, ID3D11Buffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ID3D11Buffer*, void> CSGetConstantBuffers;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ClearState;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Flush;

        [NativeTypeName("D3D11_DEVICE_CONTEXT_TYPE () __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3D11_DEVICE_CONTEXT_TYPE> GetType;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetContextFlags;

        [NativeTypeName("HRESULT (BOOL, ID3D11CommandList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, ID3D11CommandList*, int> FinishCommandList;

        [NativeTypeName(
            "void (ID3D11Resource *, UINT, UINT, UINT, UINT, ID3D11Resource *, UINT, const D3D11_BOX *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            uint,
            uint,
            uint,
            uint,
            ID3D11Resource,
            uint,
            D3D11_BOX*,
            uint,
            void> CopySubresourceRegion1;

        [NativeTypeName(
            "void (ID3D11Resource *, UINT, const D3D11_BOX *, const void *, UINT, UINT, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            uint,
            D3D11_BOX*,
            void*,
            uint,
            uint,
            uint,
            void> UpdateSubresource1;

        [NativeTypeName("void (ID3D11Resource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource, void> DiscardResource;

        [NativeTypeName("void (ID3D11View *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11View, void> DiscardView;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> VSSetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> HSSetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> DSSetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> GSSetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> PSSetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer *const *, const UINT *, const UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> CSSetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> VSGetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> HSGetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> DSGetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> GSGetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> PSGetConstantBuffers1;

        [NativeTypeName(
            "void (UINT, UINT, ID3D11Buffer **, UINT *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ID3D11Buffer*,
            uint*,
            uint*,
            void> CSGetConstantBuffers1;

        [NativeTypeName(
            "void (ID3DDeviceContextState *, ID3DDeviceContextState **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3DDeviceContextState,
            ID3DDeviceContextState*,
            void> SwapDeviceContextState;

        [NativeTypeName(
            "void (ID3D11View *, const FLOAT *, const D3D11_RECT *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID3D11View, float*, RECT*, uint, void> ClearView;

        [NativeTypeName("void (ID3D11View *, const D3D11_RECT *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11View, RECT*, uint, void> DiscardView1;

        [NativeTypeName(
            "HRESULT (ID3D11Resource *, UINT, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, ID3D11Buffer *, UINT, const UINT *, const UINT *, const UINT *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            uint,
            D3D11_TILED_RESOURCE_COORDINATE*,
            D3D11_TILE_REGION_SIZE*,
            ID3D11Buffer,
            uint,
            uint*,
            uint*,
            uint*,
            uint,
            int> UpdateTileMappings;

        [NativeTypeName(
            "HRESULT (ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            D3D11_TILED_RESOURCE_COORDINATE*,
            ID3D11Resource,
            D3D11_TILED_RESOURCE_COORDINATE*,
            D3D11_TILE_REGION_SIZE*,
            uint,
            int> CopyTileMappings;

        [NativeTypeName(
            "void (ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, ID3D11Buffer *, UINT64, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            D3D11_TILED_RESOURCE_COORDINATE*,
            D3D11_TILE_REGION_SIZE*,
            ID3D11Buffer,
            ulong,
            uint,
            void> CopyTiles;

        [NativeTypeName(
            "void (ID3D11Resource *, const D3D11_TILED_RESOURCE_COORDINATE *, const D3D11_TILE_REGION_SIZE *, const void *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D11Resource,
            D3D11_TILED_RESOURCE_COORDINATE*,
            D3D11_TILE_REGION_SIZE*,
            void*,
            uint,
            void> UpdateTiles;

        [NativeTypeName("HRESULT (ID3D11Buffer *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Buffer, ulong, int> ResizeTilePool;

        [NativeTypeName("void (ID3D11DeviceChild *, ID3D11DeviceChild *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D11DeviceChild,
            ID3D11DeviceChild,
            void> TiledResourceBarrier;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsAnnotationEnabled;

        [NativeTypeName("void (LPCWSTR, INT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, void> SetMarkerInt;

        [NativeTypeName("void (LPCWSTR, INT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, void> BeginEventInt;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EndEvent;

        [NativeTypeName("void (D3D11_CONTEXT_TYPE, HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_CONTEXT_TYPE, HANDLE, void> Flush1;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetHardwareProtectionState;

        [NativeTypeName("void (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, void> GetHardwareProtectionState;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11DeviceContext3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11DeviceContext3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11DeviceContext2"/> to <see cref = "ID3D11DeviceContext3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11DeviceContext2"/> instance to be converted </param>
    public static explicit operator ID3D11DeviceContext3(
        Silk.NET.DirectX.ID3D11DeviceContext2 value
    )
    {
        return new ID3D11DeviceContext3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11DeviceContext3"/> to <see cref = "Silk.NET.DirectX.ID3D11DeviceContext2"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11DeviceContext3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11DeviceContext2(
        ID3D11DeviceContext3 value
    )
    {
        return new Silk.NET.DirectX.ID3D11DeviceContext2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11DeviceContext1"/> to <see cref = "ID3D11DeviceContext3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11DeviceContext1"/> instance to be converted </param>
    public static explicit operator ID3D11DeviceContext3(
        Silk.NET.DirectX.ID3D11DeviceContext1 value
    )
    {
        return new ID3D11DeviceContext3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11DeviceContext3"/> to <see cref = "Silk.NET.DirectX.ID3D11DeviceContext1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11DeviceContext3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11DeviceContext1(
        ID3D11DeviceContext3 value
    )
    {
        return new Silk.NET.DirectX.ID3D11DeviceContext1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11DeviceContext"/> to <see cref = "ID3D11DeviceContext3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11DeviceContext"/> instance to be converted </param>
    public static explicit operator ID3D11DeviceContext3(Silk.NET.DirectX.ID3D11DeviceContext value)
    {
        return new ID3D11DeviceContext3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11DeviceContext3"/> to <see cref = "Silk.NET.DirectX.ID3D11DeviceContext"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11DeviceContext3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11DeviceContext(ID3D11DeviceContext3 value)
    {
        return new Silk.NET.DirectX.ID3D11DeviceContext(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> to <see cref = "ID3D11DeviceContext3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D11DeviceContext3(Silk.NET.DirectX.ID3D11DeviceChild value)
    {
        return new ID3D11DeviceContext3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11DeviceContext3"/> to <see cref = "Silk.NET.DirectX.ID3D11DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11DeviceContext3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D11DeviceChild(ID3D11DeviceContext3 value)
    {
        return new Silk.NET.DirectX.ID3D11DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11DeviceContext3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11DeviceContext3(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11DeviceContext3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11DeviceContext3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11DeviceContext3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11DeviceContext3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
