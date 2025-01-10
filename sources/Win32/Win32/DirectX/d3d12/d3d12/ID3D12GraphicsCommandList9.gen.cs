// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("34ED2808-FFE6-4C2B-B11A-CABD2B0C59E1")]
[NativeTypeName("struct ID3D12GraphicsCommandList9 : ID3D12GraphicsCommandList8")]
[NativeInheritance("ID3D12GraphicsCommandList8")]
public unsafe partial struct ID3D12GraphicsCommandList9
    : ID3D12GraphicsCommandList9.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12GraphicsCommandList9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, Guid*, uint*, void*, int>)(
                (*lpVtbl)[3]
            )
        )(this, guid, pDataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, Guid*, uint, void*, int>)((*lpVtbl)[4])
        )(this, guid, DataSize, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, Guid*, IUnknown, int>)((*lpVtbl)[5])
        )(this, guid, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList9, ushort*, int>)((*lpVtbl)[6]))(
            this,
            Name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, Guid*, void**, int>)((*lpVtbl)[7])
        )(this, riid, ppvDevice);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public new D3D12_COMMAND_LIST_TYPE GetType()
    {
        return (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, D3D12_COMMAND_LIST_TYPE>)((*lpVtbl)[8])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList9, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Reset(ID3D12CommandAllocator pAllocator, ID3D12PipelineState pInitialState)
    {
        return (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12CommandAllocator,
                ID3D12PipelineState,
                int>)((*lpVtbl)[10])
        )(this, pAllocator, pInitialState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void ClearState(ID3D12PipelineState pPipelineState)
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, ID3D12PipelineState, void>)(
                (*lpVtbl)[11]
            )
        )(this, pPipelineState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void DrawInstanced(
        uint VertexCountPerInstance,
        uint InstanceCount,
        uint StartVertexLocation,
        uint StartInstanceLocation
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, uint, uint, uint, uint, void>)(
                (*lpVtbl)[12]
            )
        )(this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void DrawIndexedInstanced(
        uint IndexCountPerInstance,
        uint InstanceCount,
        uint StartIndexLocation,
        int BaseVertexLocation,
        uint StartInstanceLocation
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, uint, uint, uint, int, uint, void>)(
                (*lpVtbl)[13]
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
    [VtblIndex(14)]
    public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, uint, uint, void>)((*lpVtbl)[14]))(
            this,
            ThreadGroupCountX,
            ThreadGroupCountY,
            ThreadGroupCountZ
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void CopyBufferRegion(
        ID3D12Resource pDstBuffer,
        [NativeTypeName("UINT64")] ulong DstOffset,
        ID3D12Resource pSrcBuffer,
        [NativeTypeName("UINT64")] ulong SrcOffset,
        [NativeTypeName("UINT64")] ulong NumBytes
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12Resource,
                ulong,
                ID3D12Resource,
                ulong,
                ulong,
                void>)((*lpVtbl)[15])
        )(this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void CopyTextureRegion(
        [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pDst,
        uint DstX,
        uint DstY,
        uint DstZ,
        [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pSrc,
        [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                D3D12_TEXTURE_COPY_LOCATION*,
                uint,
                uint,
                uint,
                D3D12_TEXTURE_COPY_LOCATION*,
                D3D12_BOX*,
                void>)((*lpVtbl)[16])
        )(this, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void CopyResource(ID3D12Resource pDstResource, ID3D12Resource pSrcResource)
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, ID3D12Resource, ID3D12Resource, void>)(
                (*lpVtbl)[17]
            )
        )(this, pDstResource, pSrcResource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void CopyTiles(
        ID3D12Resource pTiledResource,
        [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")]
            D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate,
        [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pTileRegionSize,
        ID3D12Resource pBuffer,
        [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes,
        D3D12_TILE_COPY_FLAGS Flags
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12Resource,
                D3D12_TILED_RESOURCE_COORDINATE*,
                D3D12_TILE_REGION_SIZE*,
                ID3D12Resource,
                ulong,
                D3D12_TILE_COPY_FLAGS,
                void>)((*lpVtbl)[18])
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
    [VtblIndex(19)]
    public void ResolveSubresource(
        ID3D12Resource pDstResource,
        uint DstSubresource,
        ID3D12Resource pSrcResource,
        uint SrcSubresource,
        DXGI_FORMAT Format
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12Resource,
                uint,
                ID3D12Resource,
                uint,
                DXGI_FORMAT,
                void>)((*lpVtbl)[19])
        )(this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void IASetPrimitiveTopology(
        [NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, D3D_PRIMITIVE_TOPOLOGY, void>)(
                (*lpVtbl)[20]
            )
        )(this, PrimitiveTopology);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void RSSetViewports(
        uint NumViewports,
        [NativeTypeName("const D3D12_VIEWPORT *")] D3D12_VIEWPORT* pViewports
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, uint, D3D12_VIEWPORT*, void>)(
                (*lpVtbl)[21]
            )
        )(this, NumViewports, pViewports);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void RSSetScissorRects(
        uint NumRects,
        [NativeTypeName("const D3D12_RECT *")] RECT* pRects
    )
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, RECT*, void>)((*lpVtbl)[22]))(
            this,
            NumRects,
            pRects
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void OMSetBlendFactor([NativeTypeName("const FLOAT[4]")] float* BlendFactor)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, float*, void>)((*lpVtbl)[23]))(
            this,
            BlendFactor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void OMSetStencilRef(uint StencilRef)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, void>)((*lpVtbl)[24]))(
            this,
            StencilRef
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void SetPipelineState(ID3D12PipelineState pPipelineState)
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, ID3D12PipelineState, void>)(
                (*lpVtbl)[25]
            )
        )(this, pPipelineState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void ResourceBarrier(
        uint NumBarriers,
        [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, uint, D3D12_RESOURCE_BARRIER*, void>)(
                (*lpVtbl)[26]
            )
        )(this, NumBarriers, pBarriers);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void ExecuteBundle(ID3D12GraphicsCommandList pCommandList)
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, ID3D12GraphicsCommandList, void>)(
                (*lpVtbl)[27]
            )
        )(this, pCommandList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void SetDescriptorHeaps(
        uint NumDescriptorHeaps,
        [NativeTypeName("ID3D12DescriptorHeap *const *")] ID3D12DescriptorHeap* ppDescriptorHeaps
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, uint, ID3D12DescriptorHeap*, void>)(
                (*lpVtbl)[28]
            )
        )(this, NumDescriptorHeaps, ppDescriptorHeaps);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public void SetComputeRootSignature(ID3D12RootSignature pRootSignature)
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, ID3D12RootSignature, void>)(
                (*lpVtbl)[29]
            )
        )(this, pRootSignature);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void SetGraphicsRootSignature(ID3D12RootSignature pRootSignature)
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, ID3D12RootSignature, void>)(
                (*lpVtbl)[30]
            )
        )(this, pRootSignature);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void SetComputeRootDescriptorTable(
        uint RootParameterIndex,
        D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                uint,
                D3D12_GPU_DESCRIPTOR_HANDLE,
                void>)((*lpVtbl)[31])
        )(this, RootParameterIndex, BaseDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public void SetGraphicsRootDescriptorTable(
        uint RootParameterIndex,
        D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                uint,
                D3D12_GPU_DESCRIPTOR_HANDLE,
                void>)((*lpVtbl)[32])
        )(this, RootParameterIndex, BaseDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public void SetComputeRoot32BitConstant(
        uint RootParameterIndex,
        uint SrcData,
        uint DestOffsetIn32BitValues
    )
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, uint, uint, void>)((*lpVtbl)[33]))(
            this,
            RootParameterIndex,
            SrcData,
            DestOffsetIn32BitValues
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void SetGraphicsRoot32BitConstant(
        uint RootParameterIndex,
        uint SrcData,
        uint DestOffsetIn32BitValues
    )
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, uint, uint, void>)((*lpVtbl)[34]))(
            this,
            RootParameterIndex,
            SrcData,
            DestOffsetIn32BitValues
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public void SetComputeRoot32BitConstants(
        uint RootParameterIndex,
        uint Num32BitValuesToSet,
        [NativeTypeName("const void *")] void* pSrcData,
        uint DestOffsetIn32BitValues
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, uint, uint, void*, uint, void>)(
                (*lpVtbl)[35]
            )
        )(this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void SetGraphicsRoot32BitConstants(
        uint RootParameterIndex,
        uint Num32BitValuesToSet,
        [NativeTypeName("const void *")] void* pSrcData,
        uint DestOffsetIn32BitValues
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, uint, uint, void*, uint, void>)(
                (*lpVtbl)[36]
            )
        )(this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public void SetComputeRootConstantBufferView(
        uint RootParameterIndex,
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
    )
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, ulong, void>)((*lpVtbl)[37]))(
            this,
            RootParameterIndex,
            BufferLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void SetGraphicsRootConstantBufferView(
        uint RootParameterIndex,
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
    )
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, ulong, void>)((*lpVtbl)[38]))(
            this,
            RootParameterIndex,
            BufferLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public void SetComputeRootShaderResourceView(
        uint RootParameterIndex,
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
    )
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, ulong, void>)((*lpVtbl)[39]))(
            this,
            RootParameterIndex,
            BufferLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public void SetGraphicsRootShaderResourceView(
        uint RootParameterIndex,
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
    )
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, ulong, void>)((*lpVtbl)[40]))(
            this,
            RootParameterIndex,
            BufferLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public void SetComputeRootUnorderedAccessView(
        uint RootParameterIndex,
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
    )
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, ulong, void>)((*lpVtbl)[41]))(
            this,
            RootParameterIndex,
            BufferLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public void SetGraphicsRootUnorderedAccessView(
        uint RootParameterIndex,
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation
    )
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, ulong, void>)((*lpVtbl)[42]))(
            this,
            RootParameterIndex,
            BufferLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public void IASetIndexBuffer(
        [NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] D3D12_INDEX_BUFFER_VIEW* pView
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, D3D12_INDEX_BUFFER_VIEW*, void>)(
                (*lpVtbl)[43]
            )
        )(this, pView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public void IASetVertexBuffers(
        uint StartSlot,
        uint NumViews,
        [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] D3D12_VERTEX_BUFFER_VIEW* pViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                uint,
                uint,
                D3D12_VERTEX_BUFFER_VIEW*,
                void>)((*lpVtbl)[44])
        )(this, StartSlot, NumViews, pViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public void SOSetTargets(
        uint StartSlot,
        uint NumViews,
        [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")]
            D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                uint,
                uint,
                D3D12_STREAM_OUTPUT_BUFFER_VIEW*,
                void>)((*lpVtbl)[45])
        )(this, StartSlot, NumViews, pViews);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public void OMSetRenderTargets(
        uint NumRenderTargetDescriptors,
        [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")]
            D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors,
        BOOL RTsSingleHandleToDescriptorRange,
        [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")]
            D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                uint,
                D3D12_CPU_DESCRIPTOR_HANDLE*,
                BOOL,
                D3D12_CPU_DESCRIPTOR_HANDLE*,
                void>)((*lpVtbl)[46])
        )(
            this,
            NumRenderTargetDescriptors,
            pRenderTargetDescriptors,
            RTsSingleHandleToDescriptorRange,
            pDepthStencilDescriptor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public void ClearDepthStencilView(
        D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView,
        D3D12_CLEAR_FLAGS ClearFlags,
        float Depth,
        [NativeTypeName("UINT8")] byte Stencil,
        uint NumRects,
        [NativeTypeName("const D3D12_RECT *")] RECT* pRects
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                D3D12_CLEAR_FLAGS,
                float,
                byte,
                uint,
                RECT*,
                void>)((*lpVtbl)[47])
        )(this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public void ClearRenderTargetView(
        D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView,
        [NativeTypeName("const FLOAT[4]")] float* ColorRGBA,
        uint NumRects,
        [NativeTypeName("const D3D12_RECT *")] RECT* pRects
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                float*,
                uint,
                RECT*,
                void>)((*lpVtbl)[48])
        )(this, RenderTargetView, ColorRGBA, NumRects, pRects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public void ClearUnorderedAccessViewUint(
        D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap,
        D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle,
        ID3D12Resource pResource,
        [NativeTypeName("const UINT[4]")] uint* Values,
        uint NumRects,
        [NativeTypeName("const D3D12_RECT *")] RECT* pRects
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                D3D12_GPU_DESCRIPTOR_HANDLE,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                ID3D12Resource,
                uint*,
                uint,
                RECT*,
                void>)((*lpVtbl)[49])
        )(this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public void ClearUnorderedAccessViewFloat(
        D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap,
        D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle,
        ID3D12Resource pResource,
        [NativeTypeName("const FLOAT[4]")] float* Values,
        uint NumRects,
        [NativeTypeName("const D3D12_RECT *")] RECT* pRects
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                D3D12_GPU_DESCRIPTOR_HANDLE,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                ID3D12Resource,
                float*,
                uint,
                RECT*,
                void>)((*lpVtbl)[50])
        )(this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public void DiscardResource(
        ID3D12Resource pResource,
        [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12Resource,
                D3D12_DISCARD_REGION*,
                void>)((*lpVtbl)[51])
        )(this, pResource, pRegion);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index)
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12QueryHeap,
                D3D12_QUERY_TYPE,
                uint,
                void>)((*lpVtbl)[52])
        )(this, pQueryHeap, Type, Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12_QUERY_TYPE Type, uint Index)
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12QueryHeap,
                D3D12_QUERY_TYPE,
                uint,
                void>)((*lpVtbl)[53])
        )(this, pQueryHeap, Type, Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public void ResolveQueryData(
        ID3D12QueryHeap pQueryHeap,
        D3D12_QUERY_TYPE Type,
        uint StartIndex,
        uint NumQueries,
        ID3D12Resource pDestinationBuffer,
        [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12QueryHeap,
                D3D12_QUERY_TYPE,
                uint,
                uint,
                ID3D12Resource,
                ulong,
                void>)((*lpVtbl)[54])
        )(
            this,
            pQueryHeap,
            Type,
            StartIndex,
            NumQueries,
            pDestinationBuffer,
            AlignedDestinationBufferOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public void SetPredication(
        ID3D12Resource pBuffer,
        [NativeTypeName("UINT64")] ulong AlignedBufferOffset,
        D3D12_PREDICATION_OP Operation
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12Resource,
                ulong,
                D3D12_PREDICATION_OP,
                void>)((*lpVtbl)[55])
        )(this, pBuffer, AlignedBufferOffset, Operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, void*, uint, void>)((*lpVtbl)[56]))(
            this,
            Metadata,
            pData,
            Size
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, void*, uint, void>)((*lpVtbl)[57]))(
            this,
            Metadata,
            pData,
            Size
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public void EndEvent()
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, void>)((*lpVtbl)[58]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public void ExecuteIndirect(
        ID3D12CommandSignature pCommandSignature,
        uint MaxCommandCount,
        ID3D12Resource pArgumentBuffer,
        [NativeTypeName("UINT64")] ulong ArgumentBufferOffset,
        ID3D12Resource pCountBuffer,
        [NativeTypeName("UINT64")] ulong CountBufferOffset
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12CommandSignature,
                uint,
                ID3D12Resource,
                ulong,
                ID3D12Resource,
                ulong,
                void>)((*lpVtbl)[59])
        )(
            this,
            pCommandSignature,
            MaxCommandCount,
            pArgumentBuffer,
            ArgumentBufferOffset,
            pCountBuffer,
            CountBufferOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public void AtomicCopyBufferUINT(
        ID3D12Resource pDstBuffer,
        [NativeTypeName("UINT64")] ulong DstOffset,
        ID3D12Resource pSrcBuffer,
        [NativeTypeName("UINT64")] ulong SrcOffset,
        uint Dependencies,
        [NativeTypeName("ID3D12Resource *const *")] ID3D12Resource* ppDependentResources,
        [NativeTypeName("const D3D12_SUBRESOURCE_RANGE_UINT64 *")]
            D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12Resource,
                ulong,
                ID3D12Resource,
                ulong,
                uint,
                ID3D12Resource*,
                D3D12_SUBRESOURCE_RANGE_UINT64*,
                void>)((*lpVtbl)[60])
        )(
            this,
            pDstBuffer,
            DstOffset,
            pSrcBuffer,
            SrcOffset,
            Dependencies,
            ppDependentResources,
            pDependentSubresourceRanges
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public void AtomicCopyBufferUINT64(
        ID3D12Resource pDstBuffer,
        [NativeTypeName("UINT64")] ulong DstOffset,
        ID3D12Resource pSrcBuffer,
        [NativeTypeName("UINT64")] ulong SrcOffset,
        uint Dependencies,
        [NativeTypeName("ID3D12Resource *const *")] ID3D12Resource* ppDependentResources,
        [NativeTypeName("const D3D12_SUBRESOURCE_RANGE_UINT64 *")]
            D3D12_SUBRESOURCE_RANGE_UINT64* pDependentSubresourceRanges
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12Resource,
                ulong,
                ID3D12Resource,
                ulong,
                uint,
                ID3D12Resource*,
                D3D12_SUBRESOURCE_RANGE_UINT64*,
                void>)((*lpVtbl)[61])
        )(
            this,
            pDstBuffer,
            DstOffset,
            pSrcBuffer,
            SrcOffset,
            Dependencies,
            ppDependentResources,
            pDependentSubresourceRanges
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public void OMSetDepthBounds(float Min, float Max)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, float, float, void>)((*lpVtbl)[62]))(
            this,
            Min,
            Max
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public void SetSamplePositions(
        uint NumSamplesPerPixel,
        uint NumPixels,
        D3D12_SAMPLE_POSITION* pSamplePositions
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                uint,
                uint,
                D3D12_SAMPLE_POSITION*,
                void>)((*lpVtbl)[63])
        )(this, NumSamplesPerPixel, NumPixels, pSamplePositions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public void ResolveSubresourceRegion(
        ID3D12Resource pDstResource,
        uint DstSubresource,
        uint DstX,
        uint DstY,
        ID3D12Resource pSrcResource,
        uint SrcSubresource,
        [NativeTypeName("D3D12_RECT *")] RECT* pSrcRect,
        DXGI_FORMAT Format,
        D3D12_RESOLVE_MODE ResolveMode
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12Resource,
                uint,
                uint,
                uint,
                ID3D12Resource,
                uint,
                RECT*,
                DXGI_FORMAT,
                D3D12_RESOLVE_MODE,
                void>)((*lpVtbl)[64])
        )(
            this,
            pDstResource,
            DstSubresource,
            DstX,
            DstY,
            pSrcResource,
            SrcSubresource,
            pSrcRect,
            Format,
            ResolveMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public void SetViewInstanceMask(uint Mask)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, void>)((*lpVtbl)[65]))(this, Mask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public void WriteBufferImmediate(
        uint Count,
        [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")]
            D3D12_WRITEBUFFERIMMEDIATE_PARAMETER* pParams,
        [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")]
            D3D12_WRITEBUFFERIMMEDIATE_MODE* pModes
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                uint,
                D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*,
                D3D12_WRITEBUFFERIMMEDIATE_MODE*,
                void>)((*lpVtbl)[66])
        )(this, Count, pParams, pModes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public void SetProtectedResourceSession(
        ID3D12ProtectedResourceSession pProtectedResourceSession
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, ID3D12ProtectedResourceSession, void>)(
                (*lpVtbl)[67]
            )
        )(this, pProtectedResourceSession);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public void BeginRenderPass(
        uint NumRenderTargets,
        [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC *")]
            D3D12_RENDER_PASS_RENDER_TARGET_DESC* pRenderTargets,
        [NativeTypeName("const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC *")]
            D3D12_RENDER_PASS_DEPTH_STENCIL_DESC* pDepthStencil,
        D3D12_RENDER_PASS_FLAGS Flags
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                uint,
                D3D12_RENDER_PASS_RENDER_TARGET_DESC*,
                D3D12_RENDER_PASS_DEPTH_STENCIL_DESC*,
                D3D12_RENDER_PASS_FLAGS,
                void>)((*lpVtbl)[68])
        )(this, NumRenderTargets, pRenderTargets, pDepthStencil, Flags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public void EndRenderPass()
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, void>)((*lpVtbl)[69]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public void InitializeMetaCommand(
        ID3D12MetaCommand pMetaCommand,
        [NativeTypeName("const void *")] void* pInitializationParametersData,
        [NativeTypeName("SIZE_T")] nuint InitializationParametersDataSizeInBytes
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12MetaCommand,
                void*,
                nuint,
                void>)((*lpVtbl)[70])
        )(
            this,
            pMetaCommand,
            pInitializationParametersData,
            InitializationParametersDataSizeInBytes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public void ExecuteMetaCommand(
        ID3D12MetaCommand pMetaCommand,
        [NativeTypeName("const void *")] void* pExecutionParametersData,
        [NativeTypeName("SIZE_T")] nuint ExecutionParametersDataSizeInBytes
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ID3D12MetaCommand,
                void*,
                nuint,
                void>)((*lpVtbl)[71])
        )(this, pMetaCommand, pExecutionParametersData, ExecutionParametersDataSizeInBytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public void BuildRaytracingAccelerationStructure(
        [NativeTypeName("const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC *")]
            D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC* pDesc,
        uint NumPostbuildInfoDescs,
        [NativeTypeName("const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *")]
            D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* pPostbuildInfoDescs
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC*,
                uint,
                D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC*,
                void>)((*lpVtbl)[72])
        )(this, pDesc, NumPostbuildInfoDescs, pPostbuildInfoDescs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public void EmitRaytracingAccelerationStructurePostbuildInfo(
        [NativeTypeName("const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *")]
            D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC* pDesc,
        uint NumSourceAccelerationStructures,
        [NativeTypeName("const D3D12_GPU_VIRTUAL_ADDRESS *")]
            ulong* pSourceAccelerationStructureData
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC*,
                uint,
                ulong*,
                void>)((*lpVtbl)[73])
        )(this, pDesc, NumSourceAccelerationStructures, pSourceAccelerationStructureData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public void CopyRaytracingAccelerationStructure(
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong DestAccelerationStructureData,
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong SourceAccelerationStructureData,
        D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE Mode
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                ulong,
                ulong,
                D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE,
                void>)((*lpVtbl)[74])
        )(this, DestAccelerationStructureData, SourceAccelerationStructureData, Mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public void SetPipelineState1(ID3D12StateObject pStateObject)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, ID3D12StateObject, void>)((*lpVtbl)[75]))(
            this,
            pStateObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public void DispatchRays(
        [NativeTypeName("const D3D12_DISPATCH_RAYS_DESC *")] D3D12_DISPATCH_RAYS_DESC* pDesc
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, D3D12_DISPATCH_RAYS_DESC*, void>)(
                (*lpVtbl)[76]
            )
        )(this, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public void RSSetShadingRate(
        D3D12_SHADING_RATE baseShadingRate,
        [NativeTypeName("const D3D12_SHADING_RATE_COMBINER *")]
            D3D12_SHADING_RATE_COMBINER* combiners
    )
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                D3D12_SHADING_RATE,
                D3D12_SHADING_RATE_COMBINER*,
                void>)((*lpVtbl)[77])
        )(this, baseShadingRate, combiners);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public void RSSetShadingRateImage(ID3D12Resource shadingRateImage)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, ID3D12Resource, void>)((*lpVtbl)[78]))(
            this,
            shadingRateImage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public void DispatchMesh(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, uint, uint, void>)((*lpVtbl)[79]))(
            this,
            ThreadGroupCountX,
            ThreadGroupCountY,
            ThreadGroupCountZ
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public void Barrier(
        [NativeTypeName("UINT32")] uint NumBarrierGroups,
        [NativeTypeName("const D3D12_BARRIER_GROUP *")] D3D12_BARRIER_GROUP* pBarrierGroups
    )
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, uint, D3D12_BARRIER_GROUP*, void>)(
                (*lpVtbl)[80]
            )
        )(this, NumBarrierGroups, pBarrierGroups);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public void OMSetFrontAndBackStencilRef(uint FrontStencilRef, uint BackStencilRef)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList9, uint, uint, void>)((*lpVtbl)[81]))(
            this,
            FrontStencilRef,
            BackStencilRef
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public void RSSetDepthBias(float DepthBias, float DepthBiasClamp, float SlopeScaledDepthBias)
    {
        (
            (delegate* unmanaged<ID3D12GraphicsCommandList9, float, float, float, void>)(
                (*lpVtbl)[82]
            )
        )(this, DepthBias, DepthBiasClamp, SlopeScaledDepthBias);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public void IASetIndexBufferStripCutValue(D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue)
    {
        (
            (delegate* unmanaged<
                ID3D12GraphicsCommandList9,
                D3D12_INDEX_BUFFER_STRIP_CUT_VALUE,
                void>)((*lpVtbl)[83])
        )(this, IBStripCutValue);
    }

    public interface Interface : ID3D12GraphicsCommandList8.Interface
    {
        [VtblIndex(82)]
        void RSSetDepthBias(float DepthBias, float DepthBiasClamp, float SlopeScaledDepthBias);

        [VtblIndex(83)]
        void IASetIndexBufferStripCutValue(D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue);
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

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;

        [NativeTypeName("D3D12_COMMAND_LIST_TYPE () __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3D12_COMMAND_LIST_TYPE> GetType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;

        [NativeTypeName(
            "HRESULT (ID3D12CommandAllocator *, ID3D12PipelineState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID3D12CommandAllocator, ID3D12PipelineState, int> Reset;

        [NativeTypeName("void (ID3D12PipelineState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12PipelineState, void> ClearState;

        [NativeTypeName("void (UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, uint, void> DrawInstanced;

        [NativeTypeName("void (UINT, UINT, UINT, INT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;

        [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, void> Dispatch;

        [NativeTypeName(
            "void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT64) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            ulong,
            ID3D12Resource,
            ulong,
            ulong,
            void> CopyBufferRegion;

        [NativeTypeName(
            "void (const D3D12_TEXTURE_COPY_LOCATION *, UINT, UINT, UINT, const D3D12_TEXTURE_COPY_LOCATION *, const D3D12_BOX *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_TEXTURE_COPY_LOCATION*,
            uint,
            uint,
            uint,
            D3D12_TEXTURE_COPY_LOCATION*,
            D3D12_BOX*,
            void> CopyTextureRegion;

        [NativeTypeName("void (ID3D12Resource *, ID3D12Resource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource, ID3D12Resource, void> CopyResource;

        [NativeTypeName(
            "void (ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, ID3D12Resource *, UINT64, D3D12_TILE_COPY_FLAGS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            D3D12_TILED_RESOURCE_COORDINATE*,
            D3D12_TILE_REGION_SIZE*,
            ID3D12Resource,
            ulong,
            D3D12_TILE_COPY_FLAGS,
            void> CopyTiles;

        [NativeTypeName(
            "void (ID3D12Resource *, UINT, ID3D12Resource *, UINT, DXGI_FORMAT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            uint,
            ID3D12Resource,
            uint,
            DXGI_FORMAT,
            void> ResolveSubresource;

        [NativeTypeName("void (D3D12_PRIMITIVE_TOPOLOGY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D_PRIMITIVE_TOPOLOGY, void> IASetPrimitiveTopology;

        [NativeTypeName("void (UINT, const D3D12_VIEWPORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_VIEWPORT*, void> RSSetViewports;

        [NativeTypeName("void (UINT, const D3D12_RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT*, void> RSSetScissorRects;

        [NativeTypeName("void (const FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, void> OMSetBlendFactor;

        [NativeTypeName("void (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> OMSetStencilRef;

        [NativeTypeName("void (ID3D12PipelineState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12PipelineState, void> SetPipelineState;

        [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_RESOURCE_BARRIER*, void> ResourceBarrier;

        [NativeTypeName("void (ID3D12GraphicsCommandList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12GraphicsCommandList, void> ExecuteBundle;

        [NativeTypeName("void (UINT, ID3D12DescriptorHeap *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12DescriptorHeap*, void> SetDescriptorHeaps;

        [NativeTypeName("void (ID3D12RootSignature *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12RootSignature, void> SetComputeRootSignature;

        [NativeTypeName("void (ID3D12RootSignature *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12RootSignature, void> SetGraphicsRootSignature;

        [NativeTypeName("void (UINT, D3D12_GPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_GPU_DESCRIPTOR_HANDLE,
            void> SetComputeRootDescriptorTable;

        [NativeTypeName("void (UINT, D3D12_GPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_GPU_DESCRIPTOR_HANDLE,
            void> SetGraphicsRootDescriptorTable;

        [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, void> SetComputeRoot32BitConstant;

        [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, void> SetGraphicsRoot32BitConstant;

        [NativeTypeName("void (UINT, UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            void*,
            uint,
            void> SetComputeRoot32BitConstants;

        [NativeTypeName("void (UINT, UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            void*,
            uint,
            void> SetGraphicsRoot32BitConstants;

        [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong, void> SetComputeRootConstantBufferView;

        [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong, void> SetGraphicsRootConstantBufferView;

        [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong, void> SetComputeRootShaderResourceView;

        [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong, void> SetGraphicsRootShaderResourceView;

        [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong, void> SetComputeRootUnorderedAccessView;

        [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong, void> SetGraphicsRootUnorderedAccessView;

        [NativeTypeName("void (const D3D12_INDEX_BUFFER_VIEW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_INDEX_BUFFER_VIEW*, void> IASetIndexBuffer;

        [NativeTypeName(
            "void (UINT, UINT, const D3D12_VERTEX_BUFFER_VIEW *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3D12_VERTEX_BUFFER_VIEW*,
            void> IASetVertexBuffers;

        [NativeTypeName(
            "void (UINT, UINT, const D3D12_STREAM_OUTPUT_BUFFER_VIEW *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3D12_STREAM_OUTPUT_BUFFER_VIEW*,
            void> SOSetTargets;

        [NativeTypeName(
            "void (UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, BOOL, const D3D12_CPU_DESCRIPTOR_HANDLE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_CPU_DESCRIPTOR_HANDLE*,
            BOOL,
            D3D12_CPU_DESCRIPTOR_HANDLE*,
            void> OMSetRenderTargets;

        [NativeTypeName(
            "void (D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CLEAR_FLAGS, FLOAT, UINT8, UINT, const D3D12_RECT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            D3D12_CLEAR_FLAGS,
            float,
            byte,
            uint,
            RECT*,
            void> ClearDepthStencilView;

        [NativeTypeName(
            "void (D3D12_CPU_DESCRIPTOR_HANDLE, const FLOAT *, UINT, const D3D12_RECT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            float*,
            uint,
            RECT*,
            void> ClearRenderTargetView;

        [NativeTypeName(
            "void (D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource *, const UINT *, UINT, const D3D12_RECT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_GPU_DESCRIPTOR_HANDLE,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            ID3D12Resource,
            uint*,
            uint,
            RECT*,
            void> ClearUnorderedAccessViewUint;

        [NativeTypeName(
            "void (D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource *, const FLOAT *, UINT, const D3D12_RECT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_GPU_DESCRIPTOR_HANDLE,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            ID3D12Resource,
            float*,
            uint,
            RECT*,
            void> ClearUnorderedAccessViewFloat;

        [NativeTypeName(
            "void (ID3D12Resource *, const D3D12_DISCARD_REGION *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            D3D12_DISCARD_REGION*,
            void> DiscardResource;

        [NativeTypeName(
            "void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12QueryHeap,
            D3D12_QUERY_TYPE,
            uint,
            void> BeginQuery;

        [NativeTypeName(
            "void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID3D12QueryHeap, D3D12_QUERY_TYPE, uint, void> EndQuery;

        [NativeTypeName(
            "void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT, UINT, ID3D12Resource *, UINT64) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12QueryHeap,
            D3D12_QUERY_TYPE,
            uint,
            uint,
            ID3D12Resource,
            ulong,
            void> ResolveQueryData;

        [NativeTypeName(
            "void (ID3D12Resource *, UINT64, D3D12_PREDICATION_OP) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            ulong,
            D3D12_PREDICATION_OP,
            void> SetPredication;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void> SetMarker;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void> BeginEvent;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EndEvent;

        [NativeTypeName(
            "void (ID3D12CommandSignature *, UINT, ID3D12Resource *, UINT64, ID3D12Resource *, UINT64) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12CommandSignature,
            uint,
            ID3D12Resource,
            ulong,
            ID3D12Resource,
            ulong,
            void> ExecuteIndirect;

        [NativeTypeName(
            "void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT, ID3D12Resource *const *, const D3D12_SUBRESOURCE_RANGE_UINT64 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            ulong,
            ID3D12Resource,
            ulong,
            uint,
            ID3D12Resource*,
            D3D12_SUBRESOURCE_RANGE_UINT64*,
            void> AtomicCopyBufferUINT;

        [NativeTypeName(
            "void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT, ID3D12Resource *const *, const D3D12_SUBRESOURCE_RANGE_UINT64 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            ulong,
            ID3D12Resource,
            ulong,
            uint,
            ID3D12Resource*,
            D3D12_SUBRESOURCE_RANGE_UINT64*,
            void> AtomicCopyBufferUINT64;

        [NativeTypeName("void (FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, void> OMSetDepthBounds;

        [NativeTypeName("void (UINT, UINT, D3D12_SAMPLE_POSITION *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            D3D12_SAMPLE_POSITION*,
            void> SetSamplePositions;

        [NativeTypeName(
            "void (ID3D12Resource *, UINT, UINT, UINT, ID3D12Resource *, UINT, D3D12_RECT *, DXGI_FORMAT, D3D12_RESOLVE_MODE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            uint,
            uint,
            uint,
            ID3D12Resource,
            uint,
            RECT*,
            DXGI_FORMAT,
            D3D12_RESOLVE_MODE,
            void> ResolveSubresourceRegion;

        [NativeTypeName("void (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> SetViewInstanceMask;

        [NativeTypeName(
            "void (UINT, const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *, const D3D12_WRITEBUFFERIMMEDIATE_MODE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_WRITEBUFFERIMMEDIATE_PARAMETER*,
            D3D12_WRITEBUFFERIMMEDIATE_MODE*,
            void> WriteBufferImmediate;

        [NativeTypeName("void (ID3D12ProtectedResourceSession *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ID3D12ProtectedResourceSession,
            void> SetProtectedResourceSession;

        [NativeTypeName(
            "void (UINT, const D3D12_RENDER_PASS_RENDER_TARGET_DESC *, const D3D12_RENDER_PASS_DEPTH_STENCIL_DESC *, D3D12_RENDER_PASS_FLAGS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_RENDER_PASS_RENDER_TARGET_DESC*,
            D3D12_RENDER_PASS_DEPTH_STENCIL_DESC*,
            D3D12_RENDER_PASS_FLAGS,
            void> BeginRenderPass;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EndRenderPass;

        [NativeTypeName(
            "void (ID3D12MetaCommand *, const void *, SIZE_T) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12MetaCommand,
            void*,
            nuint,
            void> InitializeMetaCommand;

        [NativeTypeName(
            "void (ID3D12MetaCommand *, const void *, SIZE_T) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12MetaCommand,
            void*,
            nuint,
            void> ExecuteMetaCommand;

        [NativeTypeName(
            "void (const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC *, UINT, const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC*,
            uint,
            D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC*,
            void> BuildRaytracingAccelerationStructure;

        [NativeTypeName(
            "void (const D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC *, UINT, const D3D12_GPU_VIRTUAL_ADDRESS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC*,
            uint,
            ulong*,
            void> EmitRaytracingAccelerationStructurePostbuildInfo;

        [NativeTypeName(
            "void (D3D12_GPU_VIRTUAL_ADDRESS, D3D12_GPU_VIRTUAL_ADDRESS, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            ulong,
            D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE,
            void> CopyRaytracingAccelerationStructure;

        [NativeTypeName("void (ID3D12StateObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12StateObject, void> SetPipelineState1;

        [NativeTypeName("void (const D3D12_DISPATCH_RAYS_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DISPATCH_RAYS_DESC*, void> DispatchRays;

        [NativeTypeName(
            "void (D3D12_SHADING_RATE, const D3D12_SHADING_RATE_COMBINER *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_SHADING_RATE,
            D3D12_SHADING_RATE_COMBINER*,
            void> RSSetShadingRate;

        [NativeTypeName("void (ID3D12Resource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource, void> RSSetShadingRateImage;

        [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, void> DispatchMesh;

        [NativeTypeName("void (UINT32, const D3D12_BARRIER_GROUP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_BARRIER_GROUP*, void> Barrier;

        [NativeTypeName("void (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, void> OMSetFrontAndBackStencilRef;

        [NativeTypeName("void (FLOAT, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, void> RSSetDepthBias;

        [NativeTypeName("void (D3D12_INDEX_BUFFER_STRIP_CUT_VALUE) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_INDEX_BUFFER_STRIP_CUT_VALUE,
            void> IASetIndexBufferStripCutValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12GraphicsCommandList9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12GraphicsCommandList9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList8"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList8"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12GraphicsCommandList8 value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList8"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12GraphicsCommandList8(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12GraphicsCommandList8(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList7"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList7"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12GraphicsCommandList7 value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList7"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12GraphicsCommandList7(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12GraphicsCommandList7(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList6"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList6"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12GraphicsCommandList6 value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList6"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12GraphicsCommandList6(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12GraphicsCommandList6(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList5"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList5"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12GraphicsCommandList5 value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList5"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12GraphicsCommandList5(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12GraphicsCommandList5(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList4"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList4"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12GraphicsCommandList4 value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList4"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12GraphicsCommandList4(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12GraphicsCommandList4(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList3"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList3"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12GraphicsCommandList3 value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList3"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12GraphicsCommandList3(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12GraphicsCommandList3(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList2"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList2"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12GraphicsCommandList2 value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList2"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12GraphicsCommandList2(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12GraphicsCommandList2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList1"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList1"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12GraphicsCommandList1 value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12GraphicsCommandList1(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12GraphicsCommandList1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12GraphicsCommandList value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12GraphicsCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12GraphicsCommandList(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12GraphicsCommandList(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12CommandList"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12CommandList"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12CommandList value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12CommandList"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12CommandList(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12CommandList(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(
        Silk.NET.DirectX.ID3D12DeviceChild value
    )
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DeviceChild(
        ID3D12GraphicsCommandList9 value
    )
    {
        return new Silk.NET.DirectX.ID3D12DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Object"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Object"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(Silk.NET.DirectX.ID3D12Object value)
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.DirectX.ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Object(ID3D12GraphicsCommandList9 value)
    {
        return new Silk.NET.DirectX.ID3D12Object(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12GraphicsCommandList9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList9(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12GraphicsCommandList9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12GraphicsCommandList9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12GraphicsCommandList9 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
