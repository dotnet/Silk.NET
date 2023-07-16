// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12Device6.xml' path='doc/member[@name="ID3D12Device6"]/*'/>
[Guid("C70B221B-40E4-4A17-89AF-025A0727A6DC")]
[NativeTypeName("struct ID3D12Device6 : ID3D12Device5")]
[NativeInheritance("ID3D12Device5")]
public unsafe partial struct ID3D12Device6 : ID3D12Device6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Device6));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Device6*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12Device6*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12Device6*, uint> )(lpVtbl[1]))((ID3D12Device6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Device6*, uint> )(lpVtbl[2]))((ID3D12Device6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D12Device6*, Guid*, uint*, void*, int> )(lpVtbl[3]))((ID3D12Device6*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D12Device6*, Guid*, uint, void*, int> )(lpVtbl[4]))((ID3D12Device6*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D12Device6*, Guid*, IUnknown*, int> )(lpVtbl[5]))((ID3D12Device6*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref = "ID3D12Object.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12Device6*, ushort*, int> )(lpVtbl[6]))((ID3D12Device6*)Unsafe.AsPointer(ref this), Name);
    }

    /// <inheritdoc cref = "ID3D12Device.GetNodeCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public uint GetNodeCount()
    {
        return ((delegate* unmanaged<ID3D12Device6*, uint> )(lpVtbl[7]))((ID3D12Device6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Device.CreateCommandQueue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12_COMMAND_QUEUE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandQueue)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_COMMAND_QUEUE_DESC*, Guid*, void**, int> )(lpVtbl[8]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, riid, ppCommandQueue);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateCommandAllocator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateCommandAllocator(D3D12_COMMAND_LIST_TYPE type, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandAllocator)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_COMMAND_LIST_TYPE, Guid*, void**, int> )(lpVtbl[9]))((ID3D12Device6*)Unsafe.AsPointer(ref this), type, riid, ppCommandAllocator);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateGraphicsPipelineState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_GRAPHICS_PIPELINE_STATE_DESC*, Guid*, void**, int> )(lpVtbl[10]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateComputePipelineState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_COMPUTE_PIPELINE_STATE_DESC*, Guid*, void**, int> )(lpVtbl[11]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateCommandList"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCommandList(uint nodeMask, D3D12_COMMAND_LIST_TYPE type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandList)
    {
        return ((delegate* unmanaged<ID3D12Device6*, uint, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int> )(lpVtbl[12]))((ID3D12Device6*)Unsafe.AsPointer(ref this), nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
    }

    /// <inheritdoc cref = "ID3D12Device.CheckFeatureSupport"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CheckFeatureSupport(D3D12_FEATURE Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_FEATURE, void*, uint, int> )(lpVtbl[13]))((ID3D12Device6*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateDescriptorHeap"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_DESCRIPTOR_HEAP_DESC*, Guid*, void**, int> )(lpVtbl[14]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDescriptorHeapDesc, riid, ppvHeap);
    }

    /// <inheritdoc cref = "ID3D12Device.GetDescriptorHandleIncrementSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_DESCRIPTOR_HEAP_TYPE, uint> )(lpVtbl[15]))((ID3D12Device6*)Unsafe.AsPointer(ref this), DescriptorHeapType);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateRootSignature"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateRootSignature(uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, void** ppvRootSignature)
    {
        return ((delegate* unmanaged<ID3D12Device6*, uint, void*, nuint, Guid*, void**, int> )(lpVtbl[16]))((ID3D12Device6*)Unsafe.AsPointer(ref this), nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateConstantBufferView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
    {
        ((delegate* unmanaged<ID3D12Device6*, D3D12_CONSTANT_BUFFER_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> )(lpVtbl[17]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateShaderResourceView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void CreateShaderResourceView(ID3D12Resource* pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
    {
        ((delegate* unmanaged<ID3D12Device6*, ID3D12Resource*, D3D12_SHADER_RESOURCE_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> )(lpVtbl[18]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateUnorderedAccessView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
    {
        ((delegate* unmanaged<ID3D12Device6*, ID3D12Resource*, ID3D12Resource*, D3D12_UNORDERED_ACCESS_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> )(lpVtbl[19]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pResource, pCounterResource, pDesc, DestDescriptor);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateRenderTargetView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void CreateRenderTargetView(ID3D12Resource* pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12_RENDER_TARGET_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
    {
        ((delegate* unmanaged<ID3D12Device6*, ID3D12Resource*, D3D12_RENDER_TARGET_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> )(lpVtbl[20]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateDepthStencilView"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void CreateDepthStencilView(ID3D12Resource* pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
    {
        ((delegate* unmanaged<ID3D12Device6*, ID3D12Resource*, D3D12_DEPTH_STENCIL_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> )(lpVtbl[21]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pResource, pDesc, DestDescriptor);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateSampler"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12_SAMPLER_DESC* pDesc, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor)
    {
        ((delegate* unmanaged<ID3D12Device6*, D3D12_SAMPLER_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> )(lpVtbl[22]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
    }

    /// <inheritdoc cref = "ID3D12Device.CopyDescriptors"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void CopyDescriptors(uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
    {
        ((delegate* unmanaged<ID3D12Device6*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, D3D12_DESCRIPTOR_HEAP_TYPE, void> )(lpVtbl[23]))((ID3D12Device6*)Unsafe.AsPointer(ref this), NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    }

    /// <inheritdoc cref = "ID3D12Device.CopyDescriptorsSimple"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void CopyDescriptorsSimple(uint NumDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType)
    {
        ((delegate* unmanaged<ID3D12Device6*, uint, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE, void> )(lpVtbl[24]))((ID3D12Device6*)Unsafe.AsPointer(ref this), NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
    }

    /// <inheritdoc cref = "ID3D12Device.GetResourceAllocationInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs)
    {
        D3D12_RESOURCE_ALLOCATION_INFO result;
        return *((delegate* unmanaged<ID3D12Device6*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_ALLOCATION_INFO*> )(lpVtbl[25]))((ID3D12Device6*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs);
    }

    /// <inheritdoc cref = "ID3D12Device.GetCustomHeapProperties"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public D3D12_HEAP_PROPERTIES GetCustomHeapProperties(uint nodeMask, D3D12_HEAP_TYPE heapType)
    {
        D3D12_HEAP_PROPERTIES result;
        return *((delegate* unmanaged<ID3D12Device6*, D3D12_HEAP_PROPERTIES*, uint, D3D12_HEAP_TYPE, D3D12_HEAP_PROPERTIES*> )(lpVtbl[26]))((ID3D12Device6*)Unsafe.AsPointer(ref this), &result, nodeMask, heapType);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateCommittedResource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int> )(lpVtbl[27]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateHeap"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_HEAP_DESC*, Guid*, void**, int> )(lpVtbl[28]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
    }

    /// <inheritdoc cref = "ID3D12Device.CreatePlacedResource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreatePlacedResource(ID3D12Heap* pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource)
    {
        return ((delegate* unmanaged<ID3D12Device6*, ID3D12Heap*, ulong, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int> )(lpVtbl[29]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateReservedResource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int> )(lpVtbl[30]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateSharedHandle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CreateSharedHandle(ID3D12DeviceChild* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, HANDLE* pHandle)
    {
        return ((delegate* unmanaged<ID3D12Device6*, ID3D12DeviceChild*, SECURITY_ATTRIBUTES*, uint, ushort*, HANDLE*, int> )(lpVtbl[31]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pObject, pAttributes, Access, Name, pHandle);
    }

    /// <inheritdoc cref = "ID3D12Device.OpenSharedHandle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT OpenSharedHandle(HANDLE NTHandle, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj)
    {
        return ((delegate* unmanaged<ID3D12Device6*, HANDLE, Guid*, void**, int> )(lpVtbl[32]))((ID3D12Device6*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
    }

    /// <inheritdoc cref = "ID3D12Device.OpenSharedHandleByName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, HANDLE* pNTHandle)
    {
        return ((delegate* unmanaged<ID3D12Device6*, ushort*, uint, HANDLE*, int> )(lpVtbl[33]))((ID3D12Device6*)Unsafe.AsPointer(ref this), Name, Access, pNTHandle);
    }

    /// <inheritdoc cref = "ID3D12Device.MakeResident"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT MakeResident(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
    {
        return ((delegate* unmanaged<ID3D12Device6*, uint, ID3D12Pageable**, int> )(lpVtbl[34]))((ID3D12Device6*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
    }

    /// <inheritdoc cref = "ID3D12Device.Evict"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT Evict(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects)
    {
        return ((delegate* unmanaged<ID3D12Device6*, uint, ID3D12Pageable**, int> )(lpVtbl[35]))((ID3D12Device6*)Unsafe.AsPointer(ref this), NumObjects, ppObjects);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateFence"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12_FENCE_FLAGS Flags, [NativeTypeName("const IID &")] Guid* riid, void** ppFence)
    {
        return ((delegate* unmanaged<ID3D12Device6*, ulong, D3D12_FENCE_FLAGS, Guid*, void**, int> )(lpVtbl[36]))((ID3D12Device6*)Unsafe.AsPointer(ref this), InitialValue, Flags, riid, ppFence);
    }

    /// <inheritdoc cref = "ID3D12Device.GetDeviceRemovedReason"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT GetDeviceRemovedReason()
    {
        return ((delegate* unmanaged<ID3D12Device6*, int> )(lpVtbl[37]))((ID3D12Device6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Device.GetCopyableFootprints"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDesc, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes)
    {
        ((delegate* unmanaged<ID3D12Device6*, D3D12_RESOURCE_DESC*, uint, uint, ulong, D3D12_PLACED_SUBRESOURCE_FOOTPRINT*, uint*, ulong*, ulong*, void> )(lpVtbl[38]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateQueryHeap"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12_QUERY_HEAP_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_QUERY_HEAP_DESC*, Guid*, void**, int> )(lpVtbl[39]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
    }

    /// <inheritdoc cref = "ID3D12Device.SetStablePowerState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT SetStablePowerState(BOOL Enable)
    {
        return ((delegate* unmanaged<ID3D12Device6*, BOOL, int> )(lpVtbl[40]))((ID3D12Device6*)Unsafe.AsPointer(ref this), Enable);
    }

    /// <inheritdoc cref = "ID3D12Device.CreateCommandSignature"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12_COMMAND_SIGNATURE_DESC* pDesc, ID3D12RootSignature* pRootSignature, [NativeTypeName("const IID &")] Guid* riid, void** ppvCommandSignature)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_COMMAND_SIGNATURE_DESC*, ID3D12RootSignature*, Guid*, void**, int> )(lpVtbl[41]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, pRootSignature, riid, ppvCommandSignature);
    }

    /// <inheritdoc cref = "ID3D12Device.GetResourceTiling"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, D3D12_PACKED_MIP_INFO* pPackedMipDesc, D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips)
    {
        ((delegate* unmanaged<ID3D12Device6*, ID3D12Resource*, uint*, D3D12_PACKED_MIP_INFO*, D3D12_TILE_SHAPE*, uint*, uint, D3D12_SUBRESOURCE_TILING*, void> )(lpVtbl[42]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    }

    /// <inheritdoc cref = "ID3D12Device.GetAdapterLuid"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public LUID GetAdapterLuid()
    {
        LUID result;
        return *((delegate* unmanaged<ID3D12Device6*, LUID*, LUID*> )(lpVtbl[43]))((ID3D12Device6*)Unsafe.AsPointer(ref this), &result);
    }

    /// <inheritdoc cref = "ID3D12Device1.CreatePipelineLibrary"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT CreatePipelineLibrary([NativeTypeName("const void *")] void* pLibraryBlob, [NativeTypeName("SIZE_T")] nuint BlobLength, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineLibrary)
    {
        return ((delegate* unmanaged<ID3D12Device6*, void*, nuint, Guid*, void**, int> )(lpVtbl[44]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
    }

    /// <inheritdoc cref = "ID3D12Device1.SetEventOnMultipleFenceCompletion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT SetEventOnMultipleFenceCompletion([NativeTypeName("ID3D12Fence *const *")] ID3D12Fence** ppFences, [NativeTypeName("const UINT64 *")] ulong* pFenceValues, uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, HANDLE hEvent)
    {
        return ((delegate* unmanaged<ID3D12Device6*, ID3D12Fence**, ulong*, uint, D3D12_MULTIPLE_FENCE_WAIT_FLAGS, HANDLE, int> )(lpVtbl[45]))((ID3D12Device6*)Unsafe.AsPointer(ref this), ppFences, pFenceValues, NumFences, Flags, hEvent);
    }

    /// <inheritdoc cref = "ID3D12Device1.SetResidencyPriority"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT SetResidencyPriority(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, [NativeTypeName("const D3D12_RESIDENCY_PRIORITY *")] D3D12_RESIDENCY_PRIORITY* pPriorities)
    {
        return ((delegate* unmanaged<ID3D12Device6*, uint, ID3D12Pageable**, D3D12_RESIDENCY_PRIORITY*, int> )(lpVtbl[46]))((ID3D12Device6*)Unsafe.AsPointer(ref this), NumObjects, ppObjects, pPriorities);
    }

    /// <inheritdoc cref = "ID3D12Device2.CreatePipelineState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT CreatePipelineState([NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12_PIPELINE_STATE_STREAM_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_PIPELINE_STATE_STREAM_DESC*, Guid*, void**, int> )(lpVtbl[47]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
    }

    /// <inheritdoc cref = "ID3D12Device3.OpenExistingHeapFromAddress"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT OpenExistingHeapFromAddress([NativeTypeName("const void *")] void* pAddress, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
    {
        return ((delegate* unmanaged<ID3D12Device6*, void*, Guid*, void**, int> )(lpVtbl[48]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pAddress, riid, ppvHeap);
    }

    /// <inheritdoc cref = "ID3D12Device3.OpenExistingHeapFromFileMapping"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT OpenExistingHeapFromFileMapping(HANDLE hFileMapping, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
    {
        return ((delegate* unmanaged<ID3D12Device6*, HANDLE, Guid*, void**, int> )(lpVtbl[49]))((ID3D12Device6*)Unsafe.AsPointer(ref this), hFileMapping, riid, ppvHeap);
    }

    /// <inheritdoc cref = "ID3D12Device3.EnqueueMakeResident"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT EnqueueMakeResident(D3D12_RESIDENCY_FLAGS Flags, uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable** ppObjects, ID3D12Fence* pFenceToSignal, [NativeTypeName("UINT64")] ulong FenceValueToSignal)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_RESIDENCY_FLAGS, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int> )(lpVtbl[50]))((ID3D12Device6*)Unsafe.AsPointer(ref this), Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
    }

    /// <inheritdoc cref = "ID3D12Device4.CreateCommandList1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT CreateCommandList1(uint nodeMask, D3D12_COMMAND_LIST_TYPE type, D3D12_COMMAND_LIST_FLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandList)
    {
        return ((delegate* unmanaged<ID3D12Device6*, uint, D3D12_COMMAND_LIST_TYPE, D3D12_COMMAND_LIST_FLAGS, Guid*, void**, int> )(lpVtbl[51]))((ID3D12Device6*)Unsafe.AsPointer(ref this), nodeMask, type, flags, riid, ppCommandList);
    }

    /// <inheritdoc cref = "ID3D12Device4.CreateProtectedResourceSession"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT CreateProtectedResourceSession([NativeTypeName("const D3D12_PROTECTED_RESOURCE_SESSION_DESC *")] D3D12_PROTECTED_RESOURCE_SESSION_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppSession)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, Guid*, void**, int> )(lpVtbl[52]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, riid, ppSession);
    }

    /// <inheritdoc cref = "ID3D12Device4.CreateCommittedResource1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT CreateCommittedResource1([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, ID3D12ProtectedResourceSession*, Guid*, void**, int> )(lpVtbl[53]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
    }

    /// <inheritdoc cref = "ID3D12Device4.CreateHeap1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT CreateHeap1([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_HEAP_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int> )(lpVtbl[54]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, pProtectedSession, riid, ppvHeap);
    }

    /// <inheritdoc cref = "ID3D12Device4.CreateReservedResource1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT CreateReservedResource1([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc, D3D12_RESOURCE_STATES InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, ID3D12ProtectedResourceSession*, Guid*, void**, int> )(lpVtbl[55]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
    }

    /// <inheritdoc cref = "ID3D12Device4.GetResourceAllocationInfo1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs, D3D12_RESOURCE_ALLOCATION_INFO1* pResourceAllocationInfo1)
    {
        D3D12_RESOURCE_ALLOCATION_INFO result;
        return *((delegate* unmanaged<ID3D12Device6*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_ALLOCATION_INFO1*, D3D12_RESOURCE_ALLOCATION_INFO*> )(lpVtbl[56]))((ID3D12Device6*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
    }

    /// <inheritdoc cref = "ID3D12Device5.CreateLifetimeTracker"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT CreateLifetimeTracker(ID3D12LifetimeOwner* pOwner, [NativeTypeName("const IID &")] Guid* riid, void** ppvTracker)
    {
        return ((delegate* unmanaged<ID3D12Device6*, ID3D12LifetimeOwner*, Guid*, void**, int> )(lpVtbl[57]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pOwner, riid, ppvTracker);
    }

    /// <inheritdoc cref = "ID3D12Device5.RemoveDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public void RemoveDevice()
    {
        ((delegate* unmanaged<ID3D12Device6*, void> )(lpVtbl[58]))((ID3D12Device6*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID3D12Device5.EnumerateMetaCommands"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT EnumerateMetaCommands(uint* pNumMetaCommands, D3D12_META_COMMAND_DESC* pDescs)
    {
        return ((delegate* unmanaged<ID3D12Device6*, uint*, D3D12_META_COMMAND_DESC*, int> )(lpVtbl[59]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pNumMetaCommands, pDescs);
    }

    /// <inheritdoc cref = "ID3D12Device5.EnumerateMetaCommandParameters"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT EnumerateMetaCommandParameters([NativeTypeName("const GUID &")] Guid* CommandId, D3D12_META_COMMAND_PARAMETER_STAGE Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, D3D12_META_COMMAND_PARAMETER_DESC* pParameterDescs)
    {
        return ((delegate* unmanaged<ID3D12Device6*, Guid*, D3D12_META_COMMAND_PARAMETER_STAGE, uint*, uint*, D3D12_META_COMMAND_PARAMETER_DESC*, int> )(lpVtbl[60]))((ID3D12Device6*)Unsafe.AsPointer(ref this), CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
    }

    /// <inheritdoc cref = "ID3D12Device5.CreateMetaCommand"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT CreateMetaCommand([NativeTypeName("const GUID &")] Guid* CommandId, uint NodeMask, [NativeTypeName("const void *")] void* pCreationParametersData, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, [NativeTypeName("const IID &")] Guid* riid, void** ppMetaCommand)
    {
        return ((delegate* unmanaged<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int> )(lpVtbl[61]))((ID3D12Device6*)Unsafe.AsPointer(ref this), CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
    }

    /// <inheritdoc cref = "ID3D12Device5.CreateStateObject"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT CreateStateObject([NativeTypeName("const D3D12_STATE_OBJECT_DESC *")] D3D12_STATE_OBJECT_DESC* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppStateObject)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_STATE_OBJECT_DESC*, Guid*, void**, int> )(lpVtbl[62]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, riid, ppStateObject);
    }

    /// <inheritdoc cref = "ID3D12Device5.GetRaytracingAccelerationStructurePrebuildInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public void GetRaytracingAccelerationStructurePrebuildInfo([NativeTypeName("const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS *")] D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS* pDesc, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO* pInfo)
    {
        ((delegate* unmanaged<ID3D12Device6*, D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS*, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO*, void> )(lpVtbl[63]))((ID3D12Device6*)Unsafe.AsPointer(ref this), pDesc, pInfo);
    }

    /// <inheritdoc cref = "ID3D12Device5.CheckDriverMatchingIdentifier"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS CheckDriverMatchingIdentifier(D3D12_SERIALIZED_DATA_TYPE SerializedDataType, [NativeTypeName("const D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER *")] D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER* pIdentifierToCheck)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_SERIALIZED_DATA_TYPE, D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER*, D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS> )(lpVtbl[64]))((ID3D12Device6*)Unsafe.AsPointer(ref this), SerializedDataType, pIdentifierToCheck);
    }

    /// <include file='ID3D12Device6.xml' path='doc/member[@name="ID3D12Device6.SetBackgroundProcessingMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT SetBackgroundProcessingMode(D3D12_BACKGROUND_PROCESSING_MODE Mode, D3D12_MEASUREMENTS_ACTION MeasurementsAction, HANDLE hEventToSignalUponCompletion, BOOL* pbFurtherMeasurementsDesired)
    {
        return ((delegate* unmanaged<ID3D12Device6*, D3D12_BACKGROUND_PROCESSING_MODE, D3D12_MEASUREMENTS_ACTION, HANDLE, BOOL*, int> )(lpVtbl[65]))((ID3D12Device6*)Unsafe.AsPointer(ref this), Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesired);
    }

    public interface Interface : ID3D12Device5.Interface
    {
        [VtblIndex(65)]
        HRESULT SetBackgroundProcessingMode(D3D12_BACKGROUND_PROCESSING_MODE Mode, D3D12_MEASUREMENTS_ACTION MeasurementsAction, HANDLE hEventToSignalUponCompletion, BOOL* pbFurtherMeasurementsDesired);
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
        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetNodeCount;
        [NativeTypeName("HRESULT (const D3D12_COMMAND_QUEUE_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_COMMAND_QUEUE_DESC*, Guid*, void**, int> CreateCommandQueue;
        [NativeTypeName("HRESULT (D3D12_COMMAND_LIST_TYPE, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_COMMAND_LIST_TYPE, Guid*, void**, int> CreateCommandAllocator;
        [NativeTypeName("HRESULT (const D3D12_GRAPHICS_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_GRAPHICS_PIPELINE_STATE_DESC*, Guid*, void**, int> CreateGraphicsPipelineState;
        [NativeTypeName("HRESULT (const D3D12_COMPUTE_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_COMPUTE_PIPELINE_STATE_DESC*, Guid*, void**, int> CreateComputePipelineState;
        [NativeTypeName("HRESULT (UINT, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator *, ID3D12PipelineState *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int> CreateCommandList;
        [NativeTypeName("HRESULT (D3D12_FEATURE, void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_FEATURE, void*, uint, int> CheckFeatureSupport;
        [NativeTypeName("HRESULT (const D3D12_DESCRIPTOR_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DESCRIPTOR_HEAP_DESC*, Guid*, void**, int> CreateDescriptorHeap;
        [NativeTypeName("UINT (D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DESCRIPTOR_HEAP_TYPE, uint> GetDescriptorHandleIncrementSize;
        [NativeTypeName("HRESULT (UINT, const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, nuint, Guid*, void**, int> CreateRootSignature;
        [NativeTypeName("void (const D3D12_CONSTANT_BUFFER_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_CONSTANT_BUFFER_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateConstantBufferView;
        [NativeTypeName("void (ID3D12Resource *, const D3D12_SHADER_RESOURCE_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, D3D12_SHADER_RESOURCE_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateShaderResourceView;
        [NativeTypeName("void (ID3D12Resource *, ID3D12Resource *, const D3D12_UNORDERED_ACCESS_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, ID3D12Resource*, D3D12_UNORDERED_ACCESS_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateUnorderedAccessView;
        [NativeTypeName("void (ID3D12Resource *, const D3D12_RENDER_TARGET_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, D3D12_RENDER_TARGET_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateRenderTargetView;
        [NativeTypeName("void (ID3D12Resource *, const D3D12_DEPTH_STENCIL_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, D3D12_DEPTH_STENCIL_VIEW_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateDepthStencilView;
        [NativeTypeName("void (const D3D12_SAMPLER_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_SAMPLER_DESC*, D3D12_CPU_DESCRIPTOR_HANDLE, void> CreateSampler;
        [NativeTypeName("void (UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, const UINT *, UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, const UINT *, D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, uint, D3D12_CPU_DESCRIPTOR_HANDLE*, uint*, D3D12_DESCRIPTOR_HEAP_TYPE, void> CopyDescriptors;
        [NativeTypeName("void (UINT, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE, void> CopyDescriptorsSimple;
        [NativeTypeName("D3D12_RESOURCE_ALLOCATION_INFO (UINT, UINT, const D3D12_RESOURCE_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_ALLOCATION_INFO*> GetResourceAllocationInfo;
        [NativeTypeName("D3D12_HEAP_PROPERTIES (UINT, D3D12_HEAP_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_HEAP_PROPERTIES*, uint, D3D12_HEAP_TYPE, D3D12_HEAP_PROPERTIES*> GetCustomHeapProperties;
        [NativeTypeName("HRESULT (const D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int> CreateCommittedResource;
        [NativeTypeName("HRESULT (const D3D12_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_HEAP_DESC*, Guid*, void**, int> CreateHeap;
        [NativeTypeName("HRESULT (ID3D12Heap *, UINT64, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Heap*, ulong, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int> CreatePlacedResource;
        [NativeTypeName("HRESULT (const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, Guid*, void**, int> CreateReservedResource;
        [NativeTypeName("HRESULT (ID3D12DeviceChild *, const SECURITY_ATTRIBUTES *, DWORD, LPCWSTR, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12DeviceChild*, SECURITY_ATTRIBUTES*, uint, ushort*, HANDLE*, int> CreateSharedHandle;
        [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, Guid*, void**, int> OpenSharedHandle;
        [NativeTypeName("HRESULT (LPCWSTR, DWORD, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, HANDLE*, int> OpenSharedHandleByName;
        [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12Pageable**, int> MakeResident;
        [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12Pageable**, int> Evict;
        [NativeTypeName("HRESULT (UINT64, D3D12_FENCE_FLAGS, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, D3D12_FENCE_FLAGS, Guid*, void**, int> CreateFence;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetDeviceRemovedReason;
        [NativeTypeName("void (const D3D12_RESOURCE_DESC *, UINT, UINT, UINT64, D3D12_PLACED_SUBRESOURCE_FOOTPRINT *, UINT *, UINT64 *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_RESOURCE_DESC*, uint, uint, ulong, D3D12_PLACED_SUBRESOURCE_FOOTPRINT*, uint*, ulong*, ulong*, void> GetCopyableFootprints;
        [NativeTypeName("HRESULT (const D3D12_QUERY_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_QUERY_HEAP_DESC*, Guid*, void**, int> CreateQueryHeap;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetStablePowerState;
        [NativeTypeName("HRESULT (const D3D12_COMMAND_SIGNATURE_DESC *, ID3D12RootSignature *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_COMMAND_SIGNATURE_DESC*, ID3D12RootSignature*, Guid*, void**, int> CreateCommandSignature;
        [NativeTypeName("void (ID3D12Resource *, UINT *, D3D12_PACKED_MIP_INFO *, D3D12_TILE_SHAPE *, UINT *, UINT, D3D12_SUBRESOURCE_TILING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, uint*, D3D12_PACKED_MIP_INFO*, D3D12_TILE_SHAPE*, uint*, uint, D3D12_SUBRESOURCE_TILING*, void> GetResourceTiling;
        [NativeTypeName("LUID () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LUID*, LUID*> GetAdapterLuid;
        [NativeTypeName("HRESULT (const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, nuint, Guid*, void**, int> CreatePipelineLibrary;
        [NativeTypeName("HRESULT (ID3D12Fence *const *, const UINT64 *, UINT, D3D12_MULTIPLE_FENCE_WAIT_FLAGS, HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Fence**, ulong*, uint, D3D12_MULTIPLE_FENCE_WAIT_FLAGS, HANDLE, int> SetEventOnMultipleFenceCompletion;
        [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *, const D3D12_RESIDENCY_PRIORITY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12Pageable**, D3D12_RESIDENCY_PRIORITY*, int> SetResidencyPriority;
        [NativeTypeName("HRESULT (const D3D12_PIPELINE_STATE_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_PIPELINE_STATE_STREAM_DESC*, Guid*, void**, int> CreatePipelineState;
        [NativeTypeName("HRESULT (const void *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, Guid*, void**, int> OpenExistingHeapFromAddress;
        [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, Guid*, void**, int> OpenExistingHeapFromFileMapping;
        [NativeTypeName("HRESULT (D3D12_RESIDENCY_FLAGS, UINT, ID3D12Pageable *const *, ID3D12Fence *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_RESIDENCY_FLAGS, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int> EnqueueMakeResident;
        [NativeTypeName("HRESULT (UINT, D3D12_COMMAND_LIST_TYPE, D3D12_COMMAND_LIST_FLAGS, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_COMMAND_LIST_TYPE, D3D12_COMMAND_LIST_FLAGS, Guid*, void**, int> CreateCommandList1;
        [NativeTypeName("HRESULT (const D3D12_PROTECTED_RESOURCE_SESSION_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, Guid*, void**, int> CreateProtectedResourceSession;
        [NativeTypeName("HRESULT (const D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, ID3D12ProtectedResourceSession*, Guid*, void**, int> CreateCommittedResource1;
        [NativeTypeName("HRESULT (const D3D12_HEAP_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_HEAP_DESC*, ID3D12ProtectedResourceSession*, Guid*, void**, int> CreateHeap1;
        [NativeTypeName("HRESULT (const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_STATES, D3D12_CLEAR_VALUE*, ID3D12ProtectedResourceSession*, Guid*, void**, int> CreateReservedResource1;
        [NativeTypeName("D3D12_RESOURCE_ALLOCATION_INFO (UINT, UINT, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_ALLOCATION_INFO1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_RESOURCE_ALLOCATION_INFO*, uint, uint, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_ALLOCATION_INFO1*, D3D12_RESOURCE_ALLOCATION_INFO*> GetResourceAllocationInfo1;
        [NativeTypeName("HRESULT (ID3D12LifetimeOwner *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12LifetimeOwner*, Guid*, void**, int> CreateLifetimeTracker;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> RemoveDevice;
        [NativeTypeName("HRESULT (UINT *, D3D12_META_COMMAND_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, D3D12_META_COMMAND_DESC*, int> EnumerateMetaCommands;
        [NativeTypeName("HRESULT (const GUID &, D3D12_META_COMMAND_PARAMETER_STAGE, UINT *, UINT *, D3D12_META_COMMAND_PARAMETER_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, D3D12_META_COMMAND_PARAMETER_STAGE, uint*, uint*, D3D12_META_COMMAND_PARAMETER_DESC*, int> EnumerateMetaCommandParameters;
        [NativeTypeName("HRESULT (const GUID &, UINT, const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, nuint, Guid*, void**, int> CreateMetaCommand;
        [NativeTypeName("HRESULT (const D3D12_STATE_OBJECT_DESC *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_STATE_OBJECT_DESC*, Guid*, void**, int> CreateStateObject;
        [NativeTypeName("void (const D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS *, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS*, D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO*, void> GetRaytracingAccelerationStructurePrebuildInfo;
        [NativeTypeName("D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS (D3D12_SERIALIZED_DATA_TYPE, const D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_SERIALIZED_DATA_TYPE, D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER*, D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS> CheckDriverMatchingIdentifier;
        [NativeTypeName("HRESULT (D3D12_BACKGROUND_PROCESSING_MODE, D3D12_MEASUREMENTS_ACTION, HANDLE, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_BACKGROUND_PROCESSING_MODE, D3D12_MEASUREMENTS_ACTION, HANDLE, BOOL*, int> SetBackgroundProcessingMode;
    }
}