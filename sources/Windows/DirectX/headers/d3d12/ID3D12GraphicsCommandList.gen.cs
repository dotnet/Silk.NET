// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList"]/*'/>
[Guid("5B160D0F-AC1B-4185-8BA8-B3AE42A5A455")]
[NativeTypeName("struct ID3D12GraphicsCommandList : ID3D12CommandList")]
[NativeInheritance("ID3D12CommandList")]
public unsafe partial struct ID3D12GraphicsCommandList : ID3D12GraphicsCommandList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12GraphicsCommandList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint> )(lpVtbl[1]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint> )(lpVtbl[2]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, Guid*, uint*, void*, int> )(lpVtbl[3]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, Guid*, uint, void*, int> )(lpVtbl[4]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, Guid*, IUnknown*, int> )(lpVtbl[5]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, ushort*, int> )(lpVtbl[6]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, Guid*, void**, int> )(lpVtbl[7]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), riid, ppvDevice);
    }

    /// <inheritdoc cref = "ID3D12CommandList.GetType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public new D3D12_COMMAND_LIST_TYPE GetType()
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, D3D12_COMMAND_LIST_TYPE> )(lpVtbl[8]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, int> )(lpVtbl[9]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Reset(ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState)
    {
        return ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12CommandAllocator*, ID3D12PipelineState*, int> )(lpVtbl[10]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pAllocator, pInitialState);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void ClearState(ID3D12PipelineState* pPipelineState)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12PipelineState*, void> )(lpVtbl[11]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pPipelineState);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.DrawInstanced"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, uint, uint, uint, void> )(lpVtbl[12]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.DrawIndexedInstanced"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, uint, uint, int, uint, void> )(lpVtbl[13]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.Dispatch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, uint, uint, void> )(lpVtbl[14]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyBufferRegion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void CopyBufferRegion(ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void> )(lpVtbl[15]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyTextureRegion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pDst, uint DstX, uint DstY, uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pSrc, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, D3D12_TEXTURE_COPY_LOCATION*, uint, uint, uint, D3D12_TEXTURE_COPY_LOCATION*, D3D12_BOX*, void> )(lpVtbl[16]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void CopyResource(ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12Resource*, ID3D12Resource*, void> )(lpVtbl[17]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pDstResource, pSrcResource);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyTiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void CopyTiles(ID3D12Resource* pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pTileRegionSize, ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12Resource*, D3D12_TILED_RESOURCE_COORDINATE*, D3D12_TILE_REGION_SIZE*, ID3D12Resource*, ulong, D3D12_TILE_COPY_FLAGS, void> )(lpVtbl[18]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ResolveSubresource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, DXGI_FORMAT Format)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12Resource*, uint, ID3D12Resource*, uint, DXGI_FORMAT, void> )(lpVtbl[19]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.IASetPrimitiveTopology"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void IASetPrimitiveTopology([NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, D3D_PRIMITIVE_TOPOLOGY, void> )(lpVtbl[20]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), PrimitiveTopology);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.RSSetViewports"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] D3D12_VIEWPORT* pViewports)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, D3D12_VIEWPORT*, void> )(lpVtbl[21]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.RSSetScissorRects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, RECT*, void> )(lpVtbl[22]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), NumRects, pRects);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.OMSetBlendFactor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void OMSetBlendFactor([NativeTypeName("const FLOAT[4]")] float* BlendFactor)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, float*, void> )(lpVtbl[23]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), BlendFactor);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.OMSetStencilRef"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void OMSetStencilRef(uint StencilRef)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, void> )(lpVtbl[24]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), StencilRef);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetPipelineState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void SetPipelineState(ID3D12PipelineState* pPipelineState)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12PipelineState*, void> )(lpVtbl[25]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pPipelineState);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ResourceBarrier"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, D3D12_RESOURCE_BARRIER*, void> )(lpVtbl[26]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ExecuteBundle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void ExecuteBundle(ID3D12GraphicsCommandList* pCommandList)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12GraphicsCommandList*, void> )(lpVtbl[27]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pCommandList);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetDescriptorHeaps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void SetDescriptorHeaps(uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] ID3D12DescriptorHeap** ppDescriptorHeaps)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, ID3D12DescriptorHeap**, void> )(lpVtbl[28]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), NumDescriptorHeaps, ppDescriptorHeaps);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootSignature"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public void SetComputeRootSignature(ID3D12RootSignature* pRootSignature)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12RootSignature*, void> )(lpVtbl[29]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pRootSignature);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootSignature"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void SetGraphicsRootSignature(ID3D12RootSignature* pRootSignature)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12RootSignature*, void> )(lpVtbl[30]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pRootSignature);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootDescriptorTable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void SetComputeRootDescriptorTable(uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, D3D12_GPU_DESCRIPTOR_HANDLE, void> )(lpVtbl[31]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootDescriptorTable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public void SetGraphicsRootDescriptorTable(uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, D3D12_GPU_DESCRIPTOR_HANDLE, void> )(lpVtbl[32]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRoot32BitConstant"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, uint, uint, void> )(lpVtbl[33]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRoot32BitConstant"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, uint, uint, void> )(lpVtbl[34]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRoot32BitConstants"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, uint DestOffsetIn32BitValues)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, uint, void*, uint, void> )(lpVtbl[35]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRoot32BitConstants"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, uint DestOffsetIn32BitValues)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, uint, void*, uint, void> )(lpVtbl[36]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootConstantBufferView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public void SetComputeRootConstantBufferView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, ulong, void> )(lpVtbl[37]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootConstantBufferView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void SetGraphicsRootConstantBufferView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, ulong, void> )(lpVtbl[38]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootShaderResourceView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public void SetComputeRootShaderResourceView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, ulong, void> )(lpVtbl[39]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootShaderResourceView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public void SetGraphicsRootShaderResourceView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, ulong, void> )(lpVtbl[40]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootUnorderedAccessView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public void SetComputeRootUnorderedAccessView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, ulong, void> )(lpVtbl[41]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootUnorderedAccessView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, ulong, void> )(lpVtbl[42]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.IASetIndexBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] D3D12_INDEX_BUFFER_VIEW* pView)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, D3D12_INDEX_BUFFER_VIEW*, void> )(lpVtbl[43]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pView);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.IASetVertexBuffers"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public void IASetVertexBuffers(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] D3D12_VERTEX_BUFFER_VIEW* pViews)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, uint, D3D12_VERTEX_BUFFER_VIEW*, void> )(lpVtbl[44]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SOSetTargets"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public void SOSetTargets(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, uint, D3D12_STREAM_OUTPUT_BUFFER_VIEW*, void> )(lpVtbl[45]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.OMSetRenderTargets"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public void OMSetRenderTargets(uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors, BOOL RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, BOOL, D3D12_CPU_DESCRIPTOR_HANDLE*, void> )(lpVtbl[46]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearDepthStencilView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public void ClearDepthStencilView(D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CLEAR_FLAGS, float, byte, uint, RECT*, void> )(lpVtbl[47]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearRenderTargetView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public void ClearRenderTargetView(D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, [NativeTypeName("const FLOAT[4]")] float* ColorRGBA, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, D3D12_CPU_DESCRIPTOR_HANDLE, float*, uint, RECT*, void> )(lpVtbl[48]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), RenderTargetView, ColorRGBA, NumRects, pRects);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearUnorderedAccessViewUint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public void ClearUnorderedAccessViewUint(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource* pResource, [NativeTypeName("const UINT[4]")] uint* Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource*, uint*, uint, RECT*, void> )(lpVtbl[49]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearUnorderedAccessViewFloat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public void ClearUnorderedAccessViewFloat(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource* pResource, [NativeTypeName("const FLOAT[4]")] float* Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource*, float*, uint, RECT*, void> )(lpVtbl[50]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.DiscardResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public void DiscardResource(ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12Resource*, D3D12_DISCARD_REGION*, void> )(lpVtbl[51]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pResource, pRegion);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.BeginQuery"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public void BeginQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint Index)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> )(lpVtbl[52]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.EndQuery"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public void EndQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint Index)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> )(lpVtbl[53]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, Index);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ResolveQueryData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, uint, ID3D12Resource*, ulong, void> )(lpVtbl[54]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetPredication"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public void SetPredication(ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12Resource*, ulong, D3D12_PREDICATION_OP, void> )(lpVtbl[55]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pBuffer, AlignedBufferOffset, Operation);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetMarker"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, void*, uint, void> )(lpVtbl[56]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.BeginEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, uint, void*, uint, void> )(lpVtbl[57]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.EndEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public void EndEvent()
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, void> )(lpVtbl[58]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ExecuteIndirect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset)
    {
        ((delegate* unmanaged<ID3D12GraphicsCommandList*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void> )(lpVtbl[59]))((ID3D12GraphicsCommandList*)Unsafe.AsPointer(ref this), pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
    }

    public interface Interface : ID3D12CommandList.Interface
    {
        [VtblIndex(9)]
        HRESULT Close();
        [VtblIndex(10)]
        HRESULT Reset(ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState);
        [VtblIndex(11)]
        void ClearState(ID3D12PipelineState* pPipelineState);
        [VtblIndex(12)]
        void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation);
        [VtblIndex(13)]
        void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation);
        [VtblIndex(14)]
        void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ);
        [VtblIndex(15)]
        void CopyBufferRegion(ID3D12Resource* pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, ID3D12Resource* pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes);
        [VtblIndex(16)]
        void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pDst, uint DstX, uint DstY, uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12_TEXTURE_COPY_LOCATION* pSrc, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox);
        [VtblIndex(17)]
        void CopyResource(ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource);
        [VtblIndex(18)]
        void CopyTiles(ID3D12Resource* pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12_TILED_RESOURCE_COORDINATE* pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pTileRegionSize, ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags);
        [VtblIndex(19)]
        void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, DXGI_FORMAT Format);
        [VtblIndex(20)]
        void IASetPrimitiveTopology([NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY")] D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology);
        [VtblIndex(21)]
        void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] D3D12_VIEWPORT* pViewports);
        [VtblIndex(22)]
        void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);
        [VtblIndex(23)]
        void OMSetBlendFactor([NativeTypeName("const FLOAT[4]")] float* BlendFactor);
        [VtblIndex(24)]
        void OMSetStencilRef(uint StencilRef);
        [VtblIndex(25)]
        void SetPipelineState(ID3D12PipelineState* pPipelineState);
        [VtblIndex(26)]
        void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12_RESOURCE_BARRIER* pBarriers);
        [VtblIndex(27)]
        void ExecuteBundle(ID3D12GraphicsCommandList* pCommandList);
        [VtblIndex(28)]
        void SetDescriptorHeaps(uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] ID3D12DescriptorHeap** ppDescriptorHeaps);
        [VtblIndex(29)]
        void SetComputeRootSignature(ID3D12RootSignature* pRootSignature);
        [VtblIndex(30)]
        void SetGraphicsRootSignature(ID3D12RootSignature* pRootSignature);
        [VtblIndex(31)]
        void SetComputeRootDescriptorTable(uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);
        [VtblIndex(32)]
        void SetGraphicsRootDescriptorTable(uint RootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);
        [VtblIndex(33)]
        void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues);
        [VtblIndex(34)]
        void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues);
        [VtblIndex(35)]
        void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, uint DestOffsetIn32BitValues);
        [VtblIndex(36)]
        void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, uint DestOffsetIn32BitValues);
        [VtblIndex(37)]
        void SetComputeRootConstantBufferView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(38)]
        void SetGraphicsRootConstantBufferView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(39)]
        void SetComputeRootShaderResourceView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(40)]
        void SetGraphicsRootShaderResourceView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(41)]
        void SetComputeRootUnorderedAccessView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(42)]
        void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(43)]
        void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] D3D12_INDEX_BUFFER_VIEW* pView);
        [VtblIndex(44)]
        void IASetVertexBuffers(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] D3D12_VERTEX_BUFFER_VIEW* pViews);
        [VtblIndex(45)]
        void SOSetTargets(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] D3D12_STREAM_OUTPUT_BUFFER_VIEW* pViews);
        [VtblIndex(46)]
        void OMSetRenderTargets(uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pRenderTargetDescriptors, BOOL RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDepthStencilDescriptor);
        [VtblIndex(47)]
        void ClearDepthStencilView(D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, D3D12_CLEAR_FLAGS ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);
        [VtblIndex(48)]
        void ClearRenderTargetView(D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, [NativeTypeName("const FLOAT[4]")] float* ColorRGBA, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);
        [VtblIndex(49)]
        void ClearUnorderedAccessViewUint(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource* pResource, [NativeTypeName("const UINT[4]")] uint* Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);
        [VtblIndex(50)]
        void ClearUnorderedAccessViewFloat(D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, ID3D12Resource* pResource, [NativeTypeName("const FLOAT[4]")] float* Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);
        [VtblIndex(51)]
        void DiscardResource(ID3D12Resource* pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12_DISCARD_REGION* pRegion);
        [VtblIndex(52)]
        void BeginQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
        [VtblIndex(53)]
        void EndQuery(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint Index);
        [VtblIndex(54)]
        void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, D3D12_QUERY_TYPE Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset);
        [VtblIndex(55)]
        void SetPredication(ID3D12Resource* pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12_PREDICATION_OP Operation);
        [VtblIndex(56)]
        void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);
        [VtblIndex(57)]
        void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);
        [VtblIndex(58)]
        void EndEvent();
        [VtblIndex(59)]
        void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset);
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
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetDevice;
        [NativeTypeName("D3D12_COMMAND_LIST_TYPE () __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, D3D12_COMMAND_LIST_TYPE> GetType;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
        [NativeTypeName("HRESULT (ID3D12CommandAllocator *, ID3D12PipelineState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12CommandAllocator*, ID3D12PipelineState*, int> Reset;
        [NativeTypeName("void (ID3D12PipelineState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12PipelineState*, void> ClearState;
        [NativeTypeName("void (UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, uint, void> DrawInstanced;
        [NativeTypeName("void (UINT, UINT, UINT, INT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;
        [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, void> Dispatch;
        [NativeTypeName("void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void> CopyBufferRegion;
        [NativeTypeName("void (const D3D12_TEXTURE_COPY_LOCATION *, UINT, UINT, UINT, const D3D12_TEXTURE_COPY_LOCATION *, const D3D12_BOX *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_TEXTURE_COPY_LOCATION*, uint, uint, uint, D3D12_TEXTURE_COPY_LOCATION*, D3D12_BOX*, void> CopyTextureRegion;
        [NativeTypeName("void (ID3D12Resource *, ID3D12Resource *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, ID3D12Resource*, void> CopyResource;
        [NativeTypeName("void (ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, ID3D12Resource *, UINT64, D3D12_TILE_COPY_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, D3D12_TILED_RESOURCE_COORDINATE*, D3D12_TILE_REGION_SIZE*, ID3D12Resource*, ulong, D3D12_TILE_COPY_FLAGS, void> CopyTiles;
        [NativeTypeName("void (ID3D12Resource *, UINT, ID3D12Resource *, UINT, DXGI_FORMAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, uint, ID3D12Resource*, uint, DXGI_FORMAT, void> ResolveSubresource;
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
        public delegate* unmanaged<TSelf*, ID3D12PipelineState*, void> SetPipelineState;
        [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_RESOURCE_BARRIER*, void> ResourceBarrier;
        [NativeTypeName("void (ID3D12GraphicsCommandList *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12GraphicsCommandList*, void> ExecuteBundle;
        [NativeTypeName("void (UINT, ID3D12DescriptorHeap *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12DescriptorHeap**, void> SetDescriptorHeaps;
        [NativeTypeName("void (ID3D12RootSignature *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12RootSignature*, void> SetComputeRootSignature;
        [NativeTypeName("void (ID3D12RootSignature *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12RootSignature*, void> SetGraphicsRootSignature;
        [NativeTypeName("void (UINT, D3D12_GPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_GPU_DESCRIPTOR_HANDLE, void> SetComputeRootDescriptorTable;
        [NativeTypeName("void (UINT, D3D12_GPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_GPU_DESCRIPTOR_HANDLE, void> SetGraphicsRootDescriptorTable;
        [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, void> SetComputeRoot32BitConstant;
        [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, void> SetGraphicsRoot32BitConstant;
        [NativeTypeName("void (UINT, UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, void*, uint, void> SetComputeRoot32BitConstants;
        [NativeTypeName("void (UINT, UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, void*, uint, void> SetGraphicsRoot32BitConstants;
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
        [NativeTypeName("void (UINT, UINT, const D3D12_VERTEX_BUFFER_VIEW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, D3D12_VERTEX_BUFFER_VIEW*, void> IASetVertexBuffers;
        [NativeTypeName("void (UINT, UINT, const D3D12_STREAM_OUTPUT_BUFFER_VIEW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, D3D12_STREAM_OUTPUT_BUFFER_VIEW*, void> SOSetTargets;
        [NativeTypeName("void (UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, BOOL, const D3D12_CPU_DESCRIPTOR_HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, BOOL, D3D12_CPU_DESCRIPTOR_HANDLE*, void> OMSetRenderTargets;
        [NativeTypeName("void (D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CLEAR_FLAGS, FLOAT, UINT8, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CLEAR_FLAGS, float, byte, uint, RECT*, void> ClearDepthStencilView;
        [NativeTypeName("void (D3D12_CPU_DESCRIPTOR_HANDLE, const FLOAT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_CPU_DESCRIPTOR_HANDLE, float*, uint, RECT*, void> ClearRenderTargetView;
        [NativeTypeName("void (D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource *, const UINT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource*, uint*, uint, RECT*, void> ClearUnorderedAccessViewUint;
        [NativeTypeName("void (D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource *, const FLOAT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource*, float*, uint, RECT*, void> ClearUnorderedAccessViewFloat;
        [NativeTypeName("void (ID3D12Resource *, const D3D12_DISCARD_REGION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, D3D12_DISCARD_REGION*, void> DiscardResource;
        [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> BeginQuery;
        [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, void> EndQuery;
        [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT, UINT, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12QueryHeap*, D3D12_QUERY_TYPE, uint, uint, ID3D12Resource*, ulong, void> ResolveQueryData;
        [NativeTypeName("void (ID3D12Resource *, UINT64, D3D12_PREDICATION_OP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, ulong, D3D12_PREDICATION_OP, void> SetPredication;
        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void> SetMarker;
        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void> BeginEvent;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EndEvent;
        [NativeTypeName("void (ID3D12CommandSignature *, UINT, ID3D12Resource *, UINT64, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void> ExecuteIndirect;
    }
}