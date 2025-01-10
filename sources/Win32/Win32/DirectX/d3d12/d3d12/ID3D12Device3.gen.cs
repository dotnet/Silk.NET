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

[Guid("81DADC15-2BAD-4392-93C5-101345C4AA98")]
[NativeTypeName("struct ID3D12Device3 : ID3D12Device2")]
[NativeInheritance("ID3D12Device2")]
public unsafe partial struct ID3D12Device3 : ID3D12Device3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Device3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Device3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12Device3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Device3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<ID3D12Device3, Guid*, uint*, void*, int>)((*lpVtbl)[3]))(
            this,
            guid,
            pDataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    )
    {
        return ((delegate* unmanaged<ID3D12Device3, Guid*, uint, void*, int>)((*lpVtbl)[4]))(
            this,
            guid,
            DataSize,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* guid,
        [NativeTypeName("const IUnknown *")] IUnknown pData
    )
    {
        return ((delegate* unmanaged<ID3D12Device3, Guid*, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12Device3, ushort*, int>)((*lpVtbl)[6]))(this, Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public uint GetNodeCount()
    {
        return ((delegate* unmanaged<ID3D12Device3, uint>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateCommandQueue(
        [NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12_COMMAND_QUEUE_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppCommandQueue
    )
    {
        return (
            (delegate* unmanaged<ID3D12Device3, D3D12_COMMAND_QUEUE_DESC*, Guid*, void**, int>)(
                (*lpVtbl)[8]
            )
        )(this, pDesc, riid, ppCommandQueue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateCommandAllocator(
        D3D12_COMMAND_LIST_TYPE type,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppCommandAllocator
    )
    {
        return (
            (delegate* unmanaged<ID3D12Device3, D3D12_COMMAND_LIST_TYPE, Guid*, void**, int>)(
                (*lpVtbl)[9]
            )
        )(this, type, riid, ppCommandAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateGraphicsPipelineState(
        [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")]
            D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppPipelineState
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_GRAPHICS_PIPELINE_STATE_DESC*,
                Guid*,
                void**,
                int>)((*lpVtbl)[10])
        )(this, pDesc, riid, ppPipelineState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateComputePipelineState(
        [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")]
            D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppPipelineState
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_COMPUTE_PIPELINE_STATE_DESC*,
                Guid*,
                void**,
                int>)((*lpVtbl)[11])
        )(this, pDesc, riid, ppPipelineState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCommandList(
        uint nodeMask,
        D3D12_COMMAND_LIST_TYPE type,
        ID3D12CommandAllocator pCommandAllocator,
        ID3D12PipelineState pInitialState,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppCommandList
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                uint,
                D3D12_COMMAND_LIST_TYPE,
                ID3D12CommandAllocator,
                ID3D12PipelineState,
                Guid*,
                void**,
                int>)((*lpVtbl)[12])
        )(this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CheckFeatureSupport(
        D3D12_FEATURE Feature,
        void* pFeatureSupportData,
        uint FeatureSupportDataSize
    )
    {
        return (
            (delegate* unmanaged<ID3D12Device3, D3D12_FEATURE, void*, uint, int>)((*lpVtbl)[13])
        )(this, Feature, pFeatureSupportData, FeatureSupportDataSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateDescriptorHeap(
        [NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")]
            D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvHeap
    )
    {
        return (
            (delegate* unmanaged<ID3D12Device3, D3D12_DESCRIPTOR_HEAP_DESC*, Guid*, void**, int>)(
                (*lpVtbl)[14]
            )
        )(this, pDescriptorHeapDesc, riid, ppvHeap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetDescriptorHandleIncrementSize(D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType)
    {
        return (
            (delegate* unmanaged<ID3D12Device3, D3D12_DESCRIPTOR_HEAP_TYPE, uint>)((*lpVtbl)[15])
        )(this, DescriptorHeapType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateRootSignature(
        uint nodeMask,
        [NativeTypeName("const void *")] void* pBlobWithRootSignature,
        [NativeTypeName("SIZE_T")] nuint blobLengthInBytes,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvRootSignature
    )
    {
        return (
            (delegate* unmanaged<ID3D12Device3, uint, void*, nuint, Guid*, void**, int>)(
                (*lpVtbl)[16]
            )
        )(this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void CreateConstantBufferView(
        [NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")]
            D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc,
        D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
    )
    {
        (
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_CONSTANT_BUFFER_VIEW_DESC*,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                void>)((*lpVtbl)[17])
        )(this, pDesc, DestDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void CreateShaderResourceView(
        ID3D12Resource pResource,
        [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")]
            D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc,
        D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
    )
    {
        (
            (delegate* unmanaged<
                ID3D12Device3,
                ID3D12Resource,
                D3D12_SHADER_RESOURCE_VIEW_DESC*,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                void>)((*lpVtbl)[18])
        )(this, pResource, pDesc, DestDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void CreateUnorderedAccessView(
        ID3D12Resource pResource,
        ID3D12Resource pCounterResource,
        [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")]
            D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc,
        D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
    )
    {
        (
            (delegate* unmanaged<
                ID3D12Device3,
                ID3D12Resource,
                ID3D12Resource,
                D3D12_UNORDERED_ACCESS_VIEW_DESC*,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                void>)((*lpVtbl)[19])
        )(this, pResource, pCounterResource, pDesc, DestDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void CreateRenderTargetView(
        ID3D12Resource pResource,
        [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")]
            D3D12_RENDER_TARGET_VIEW_DESC* pDesc,
        D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
    )
    {
        (
            (delegate* unmanaged<
                ID3D12Device3,
                ID3D12Resource,
                D3D12_RENDER_TARGET_VIEW_DESC*,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                void>)((*lpVtbl)[20])
        )(this, pResource, pDesc, DestDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void CreateDepthStencilView(
        ID3D12Resource pResource,
        [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")]
            D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc,
        D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
    )
    {
        (
            (delegate* unmanaged<
                ID3D12Device3,
                ID3D12Resource,
                D3D12_DEPTH_STENCIL_VIEW_DESC*,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                void>)((*lpVtbl)[21])
        )(this, pResource, pDesc, DestDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void CreateSampler(
        [NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12_SAMPLER_DESC* pDesc,
        D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
    )
    {
        (
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_SAMPLER_DESC*,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                void>)((*lpVtbl)[22])
        )(this, pDesc, DestDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void CopyDescriptors(
        uint NumDestDescriptorRanges,
        [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")]
            D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts,
        [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes,
        uint NumSrcDescriptorRanges,
        [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")]
            D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts,
        [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes,
        D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType
    )
    {
        (
            (delegate* unmanaged<
                ID3D12Device3,
                uint,
                D3D12_CPU_DESCRIPTOR_HANDLE*,
                uint*,
                uint,
                D3D12_CPU_DESCRIPTOR_HANDLE*,
                uint*,
                D3D12_DESCRIPTOR_HEAP_TYPE,
                void>)((*lpVtbl)[23])
        )(
            this,
            NumDestDescriptorRanges,
            pDestDescriptorRangeStarts,
            pDestDescriptorRangeSizes,
            NumSrcDescriptorRanges,
            pSrcDescriptorRangeStarts,
            pSrcDescriptorRangeSizes,
            DescriptorHeapsType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void CopyDescriptorsSimple(
        uint NumDescriptors,
        D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart,
        D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart,
        D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType
    )
    {
        (
            (delegate* unmanaged<
                ID3D12Device3,
                uint,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                D3D12_CPU_DESCRIPTOR_HANDLE,
                D3D12_DESCRIPTOR_HEAP_TYPE,
                void>)((*lpVtbl)[24])
        )(
            this,
            NumDescriptors,
            DestDescriptorRangeStart,
            SrcDescriptorRangeStart,
            DescriptorHeapsType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo(
        uint visibleMask,
        uint numResourceDescs,
        [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDescs
    )
    {
        D3D12_RESOURCE_ALLOCATION_INFO result;
        return *(
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_RESOURCE_ALLOCATION_INFO*,
                uint,
                uint,
                D3D12_RESOURCE_DESC*,
                D3D12_RESOURCE_ALLOCATION_INFO*>)((*lpVtbl)[25])
        )(this, &result, visibleMask, numResourceDescs, pResourceDescs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public D3D12_HEAP_PROPERTIES GetCustomHeapProperties(uint nodeMask, D3D12_HEAP_TYPE heapType)
    {
        D3D12_HEAP_PROPERTIES result;
        return *(
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_HEAP_PROPERTIES*,
                uint,
                D3D12_HEAP_TYPE,
                D3D12_HEAP_PROPERTIES*>)((*lpVtbl)[26])
        )(this, &result, nodeMask, heapType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateCommittedResource(
        [NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12_HEAP_PROPERTIES* pHeapProperties,
        D3D12_HEAP_FLAGS HeapFlags,
        [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc,
        D3D12_RESOURCE_STATES InitialResourceState,
        [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue,
        [NativeTypeName("const IID &")] Guid* riidResource,
        void** ppvResource
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_HEAP_PROPERTIES*,
                D3D12_HEAP_FLAGS,
                D3D12_RESOURCE_DESC*,
                D3D12_RESOURCE_STATES,
                D3D12_CLEAR_VALUE*,
                Guid*,
                void**,
                int>)((*lpVtbl)[27])
        )(
            this,
            pHeapProperties,
            HeapFlags,
            pDesc,
            InitialResourceState,
            pOptimizedClearValue,
            riidResource,
            ppvResource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateHeap(
        [NativeTypeName("const D3D12_HEAP_DESC *")] D3D12_HEAP_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvHeap
    )
    {
        return (
            (delegate* unmanaged<ID3D12Device3, D3D12_HEAP_DESC*, Guid*, void**, int>)(
                (*lpVtbl)[28]
            )
        )(this, pDesc, riid, ppvHeap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreatePlacedResource(
        ID3D12Heap pHeap,
        [NativeTypeName("UINT64")] ulong HeapOffset,
        [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc,
        D3D12_RESOURCE_STATES InitialState,
        [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvResource
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                ID3D12Heap,
                ulong,
                D3D12_RESOURCE_DESC*,
                D3D12_RESOURCE_STATES,
                D3D12_CLEAR_VALUE*,
                Guid*,
                void**,
                int>)((*lpVtbl)[29])
        )(this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT CreateReservedResource(
        [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pDesc,
        D3D12_RESOURCE_STATES InitialState,
        [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12_CLEAR_VALUE* pOptimizedClearValue,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvResource
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_RESOURCE_DESC*,
                D3D12_RESOURCE_STATES,
                D3D12_CLEAR_VALUE*,
                Guid*,
                void**,
                int>)((*lpVtbl)[30])
        )(this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CreateSharedHandle(
        ID3D12DeviceChild pObject,
        [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes,
        [NativeTypeName("DWORD")] uint Access,
        [NativeTypeName("LPCWSTR")] ushort* Name,
        HANDLE* pHandle
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                ID3D12DeviceChild,
                SECURITY_ATTRIBUTES*,
                uint,
                ushort*,
                HANDLE*,
                int>)((*lpVtbl)[31])
        )(this, pObject, pAttributes, Access, Name, pHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT OpenSharedHandle(
        HANDLE NTHandle,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObj
    )
    {
        return ((delegate* unmanaged<ID3D12Device3, HANDLE, Guid*, void**, int>)((*lpVtbl)[32]))(
            this,
            NTHandle,
            riid,
            ppvObj
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT OpenSharedHandleByName(
        [NativeTypeName("LPCWSTR")] ushort* Name,
        [NativeTypeName("DWORD")] uint Access,
        HANDLE* pNTHandle
    )
    {
        return ((delegate* unmanaged<ID3D12Device3, ushort*, uint, HANDLE*, int>)((*lpVtbl)[33]))(
            this,
            Name,
            Access,
            pNTHandle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT MakeResident(
        uint NumObjects,
        [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects
    )
    {
        return ((delegate* unmanaged<ID3D12Device3, uint, ID3D12Pageable*, int>)((*lpVtbl)[34]))(
            this,
            NumObjects,
            ppObjects
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT Evict(
        uint NumObjects,
        [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects
    )
    {
        return ((delegate* unmanaged<ID3D12Device3, uint, ID3D12Pageable*, int>)((*lpVtbl)[35]))(
            this,
            NumObjects,
            ppObjects
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CreateFence(
        [NativeTypeName("UINT64")] ulong InitialValue,
        D3D12_FENCE_FLAGS Flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppFence
    )
    {
        return (
            (delegate* unmanaged<ID3D12Device3, ulong, D3D12_FENCE_FLAGS, Guid*, void**, int>)(
                (*lpVtbl)[36]
            )
        )(this, InitialValue, Flags, riid, ppFence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT GetDeviceRemovedReason()
    {
        return ((delegate* unmanaged<ID3D12Device3, int>)((*lpVtbl)[37]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void GetCopyableFootprints(
        [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12_RESOURCE_DESC* pResourceDesc,
        uint FirstSubresource,
        uint NumSubresources,
        [NativeTypeName("UINT64")] ulong BaseOffset,
        D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts,
        uint* pNumRows,
        [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes,
        [NativeTypeName("UINT64 *")] ulong* pTotalBytes
    )
    {
        (
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_RESOURCE_DESC*,
                uint,
                uint,
                ulong,
                D3D12_PLACED_SUBRESOURCE_FOOTPRINT*,
                uint*,
                ulong*,
                ulong*,
                void>)((*lpVtbl)[38])
        )(
            this,
            pResourceDesc,
            FirstSubresource,
            NumSubresources,
            BaseOffset,
            pLayouts,
            pNumRows,
            pRowSizeInBytes,
            pTotalBytes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT CreateQueryHeap(
        [NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12_QUERY_HEAP_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvHeap
    )
    {
        return (
            (delegate* unmanaged<ID3D12Device3, D3D12_QUERY_HEAP_DESC*, Guid*, void**, int>)(
                (*lpVtbl)[39]
            )
        )(this, pDesc, riid, ppvHeap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT SetStablePowerState(BOOL Enable)
    {
        return ((delegate* unmanaged<ID3D12Device3, BOOL, int>)((*lpVtbl)[40]))(this, Enable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT CreateCommandSignature(
        [NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")]
            D3D12_COMMAND_SIGNATURE_DESC* pDesc,
        ID3D12RootSignature pRootSignature,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvCommandSignature
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_COMMAND_SIGNATURE_DESC*,
                ID3D12RootSignature,
                Guid*,
                void**,
                int>)((*lpVtbl)[41])
        )(this, pDesc, pRootSignature, riid, ppvCommandSignature);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public void GetResourceTiling(
        ID3D12Resource pTiledResource,
        uint* pNumTilesForEntireResource,
        D3D12_PACKED_MIP_INFO* pPackedMipDesc,
        D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips,
        uint* pNumSubresourceTilings,
        uint FirstSubresourceTilingToGet,
        D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips
    )
    {
        (
            (delegate* unmanaged<
                ID3D12Device3,
                ID3D12Resource,
                uint*,
                D3D12_PACKED_MIP_INFO*,
                D3D12_TILE_SHAPE*,
                uint*,
                uint,
                D3D12_SUBRESOURCE_TILING*,
                void>)((*lpVtbl)[42])
        )(
            this,
            pTiledResource,
            pNumTilesForEntireResource,
            pPackedMipDesc,
            pStandardTileShapeForNonPackedMips,
            pNumSubresourceTilings,
            FirstSubresourceTilingToGet,
            pSubresourceTilingsForNonPackedMips
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public LUID GetAdapterLuid()
    {
        LUID result;
        return *((delegate* unmanaged<ID3D12Device3, LUID*, LUID*>)((*lpVtbl)[43]))(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT CreatePipelineLibrary(
        [NativeTypeName("const void *")] void* pLibraryBlob,
        [NativeTypeName("SIZE_T")] nuint BlobLength,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppPipelineLibrary
    )
    {
        return (
            (delegate* unmanaged<ID3D12Device3, void*, nuint, Guid*, void**, int>)((*lpVtbl)[44])
        )(this, pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT SetEventOnMultipleFenceCompletion(
        [NativeTypeName("ID3D12Fence *const *")] ID3D12Fence* ppFences,
        [NativeTypeName("const UINT64 *")] ulong* pFenceValues,
        uint NumFences,
        D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags,
        HANDLE hEvent
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                ID3D12Fence*,
                ulong*,
                uint,
                D3D12_MULTIPLE_FENCE_WAIT_FLAGS,
                HANDLE,
                int>)((*lpVtbl)[45])
        )(this, ppFences, pFenceValues, NumFences, Flags, hEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT SetResidencyPriority(
        uint NumObjects,
        [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects,
        [NativeTypeName("const D3D12_RESIDENCY_PRIORITY *")] D3D12_RESIDENCY_PRIORITY* pPriorities
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                uint,
                ID3D12Pageable*,
                D3D12_RESIDENCY_PRIORITY*,
                int>)((*lpVtbl)[46])
        )(this, NumObjects, ppObjects, pPriorities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT CreatePipelineState(
        [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")]
            D3D12_PIPELINE_STATE_STREAM_DESC* pDesc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppPipelineState
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_PIPELINE_STATE_STREAM_DESC*,
                Guid*,
                void**,
                int>)((*lpVtbl)[47])
        )(this, pDesc, riid, ppPipelineState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT OpenExistingHeapFromAddress(
        [NativeTypeName("const void *")] void* pAddress,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvHeap
    )
    {
        return ((delegate* unmanaged<ID3D12Device3, void*, Guid*, void**, int>)((*lpVtbl)[48]))(
            this,
            pAddress,
            riid,
            ppvHeap
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT OpenExistingHeapFromFileMapping(
        HANDLE hFileMapping,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvHeap
    )
    {
        return ((delegate* unmanaged<ID3D12Device3, HANDLE, Guid*, void**, int>)((*lpVtbl)[49]))(
            this,
            hFileMapping,
            riid,
            ppvHeap
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT EnqueueMakeResident(
        D3D12_RESIDENCY_FLAGS Flags,
        uint NumObjects,
        [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects,
        ID3D12Fence pFenceToSignal,
        [NativeTypeName("UINT64")] ulong FenceValueToSignal
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12Device3,
                D3D12_RESIDENCY_FLAGS,
                uint,
                ID3D12Pageable*,
                ID3D12Fence,
                ulong,
                int>)((*lpVtbl)[50])
        )(this, Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
    }

    public interface Interface : ID3D12Device2.Interface
    {
        [VtblIndex(48)]
        HRESULT OpenExistingHeapFromAddress(
            [NativeTypeName("const void *")] void* pAddress,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvHeap
        );

        [VtblIndex(49)]
        HRESULT OpenExistingHeapFromFileMapping(
            HANDLE hFileMapping,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvHeap
        );

        [VtblIndex(50)]
        HRESULT EnqueueMakeResident(
            D3D12_RESIDENCY_FLAGS Flags,
            uint NumObjects,
            [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects,
            ID3D12Fence pFenceToSignal,
            [NativeTypeName("UINT64")] ulong FenceValueToSignal
        );
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

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetNodeCount;

        [NativeTypeName(
            "HRESULT (const D3D12_COMMAND_QUEUE_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_COMMAND_QUEUE_DESC*,
            Guid*,
            void**,
            int> CreateCommandQueue;

        [NativeTypeName(
            "HRESULT (D3D12_COMMAND_LIST_TYPE, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_COMMAND_LIST_TYPE,
            Guid*,
            void**,
            int> CreateCommandAllocator;

        [NativeTypeName(
            "HRESULT (const D3D12_GRAPHICS_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_GRAPHICS_PIPELINE_STATE_DESC*,
            Guid*,
            void**,
            int> CreateGraphicsPipelineState;

        [NativeTypeName(
            "HRESULT (const D3D12_COMPUTE_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_COMPUTE_PIPELINE_STATE_DESC*,
            Guid*,
            void**,
            int> CreateComputePipelineState;

        [NativeTypeName(
            "HRESULT (UINT, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator *, ID3D12PipelineState *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_COMMAND_LIST_TYPE,
            ID3D12CommandAllocator,
            ID3D12PipelineState,
            Guid*,
            void**,
            int> CreateCommandList;

        [NativeTypeName("HRESULT (D3D12_FEATURE, void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_FEATURE, void*, uint, int> CheckFeatureSupport;

        [NativeTypeName(
            "HRESULT (const D3D12_DESCRIPTOR_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DESCRIPTOR_HEAP_DESC*,
            Guid*,
            void**,
            int> CreateDescriptorHeap;

        [NativeTypeName("UINT (D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DESCRIPTOR_HEAP_TYPE,
            uint> GetDescriptorHandleIncrementSize;

        [NativeTypeName(
            "HRESULT (UINT, const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            void*,
            nuint,
            Guid*,
            void**,
            int> CreateRootSignature;

        [NativeTypeName(
            "void (const D3D12_CONSTANT_BUFFER_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_CONSTANT_BUFFER_VIEW_DESC*,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            void> CreateConstantBufferView;

        [NativeTypeName(
            "void (ID3D12Resource *, const D3D12_SHADER_RESOURCE_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            D3D12_SHADER_RESOURCE_VIEW_DESC*,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            void> CreateShaderResourceView;

        [NativeTypeName(
            "void (ID3D12Resource *, ID3D12Resource *, const D3D12_UNORDERED_ACCESS_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            ID3D12Resource,
            D3D12_UNORDERED_ACCESS_VIEW_DESC*,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            void> CreateUnorderedAccessView;

        [NativeTypeName(
            "void (ID3D12Resource *, const D3D12_RENDER_TARGET_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            D3D12_RENDER_TARGET_VIEW_DESC*,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            void> CreateRenderTargetView;

        [NativeTypeName(
            "void (ID3D12Resource *, const D3D12_DEPTH_STENCIL_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            D3D12_DEPTH_STENCIL_VIEW_DESC*,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            void> CreateDepthStencilView;

        [NativeTypeName(
            "void (const D3D12_SAMPLER_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_SAMPLER_DESC*,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            void> CreateSampler;

        [NativeTypeName(
            "void (UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, const UINT *, UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, const UINT *, D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_CPU_DESCRIPTOR_HANDLE*,
            uint*,
            uint,
            D3D12_CPU_DESCRIPTOR_HANDLE*,
            uint*,
            D3D12_DESCRIPTOR_HEAP_TYPE,
            void> CopyDescriptors;

        [NativeTypeName(
            "void (UINT, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            D3D12_CPU_DESCRIPTOR_HANDLE,
            D3D12_DESCRIPTOR_HEAP_TYPE,
            void> CopyDescriptorsSimple;

        [NativeTypeName(
            "D3D12_RESOURCE_ALLOCATION_INFO (UINT, UINT, const D3D12_RESOURCE_DESC *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_RESOURCE_ALLOCATION_INFO*,
            uint,
            uint,
            D3D12_RESOURCE_DESC*,
            D3D12_RESOURCE_ALLOCATION_INFO*> GetResourceAllocationInfo;

        [NativeTypeName("D3D12_HEAP_PROPERTIES (UINT, D3D12_HEAP_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_HEAP_PROPERTIES*,
            uint,
            D3D12_HEAP_TYPE,
            D3D12_HEAP_PROPERTIES*> GetCustomHeapProperties;

        [NativeTypeName(
            "HRESULT (const D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_HEAP_PROPERTIES*,
            D3D12_HEAP_FLAGS,
            D3D12_RESOURCE_DESC*,
            D3D12_RESOURCE_STATES,
            D3D12_CLEAR_VALUE*,
            Guid*,
            void**,
            int> CreateCommittedResource;

        [NativeTypeName(
            "HRESULT (const D3D12_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D12_HEAP_DESC*, Guid*, void**, int> CreateHeap;

        [NativeTypeName(
            "HRESULT (ID3D12Heap *, UINT64, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Heap,
            ulong,
            D3D12_RESOURCE_DESC*,
            D3D12_RESOURCE_STATES,
            D3D12_CLEAR_VALUE*,
            Guid*,
            void**,
            int> CreatePlacedResource;

        [NativeTypeName(
            "HRESULT (const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_RESOURCE_DESC*,
            D3D12_RESOURCE_STATES,
            D3D12_CLEAR_VALUE*,
            Guid*,
            void**,
            int> CreateReservedResource;

        [NativeTypeName(
            "HRESULT (ID3D12DeviceChild *, const SECURITY_ATTRIBUTES *, DWORD, LPCWSTR, HANDLE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12DeviceChild,
            SECURITY_ATTRIBUTES*,
            uint,
            ushort*,
            HANDLE*,
            int> CreateSharedHandle;

        [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, Guid*, void**, int> OpenSharedHandle;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, HANDLE*, int> OpenSharedHandleByName;

        [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12Pageable*, int> MakeResident;

        [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12Pageable*, int> Evict;

        [NativeTypeName(
            "HRESULT (UINT64, D3D12_FENCE_FLAGS, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            D3D12_FENCE_FLAGS,
            Guid*,
            void**,
            int> CreateFence;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetDeviceRemovedReason;

        [NativeTypeName(
            "void (const D3D12_RESOURCE_DESC *, UINT, UINT, UINT64, D3D12_PLACED_SUBRESOURCE_FOOTPRINT *, UINT *, UINT64 *, UINT64 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_RESOURCE_DESC*,
            uint,
            uint,
            ulong,
            D3D12_PLACED_SUBRESOURCE_FOOTPRINT*,
            uint*,
            ulong*,
            ulong*,
            void> GetCopyableFootprints;

        [NativeTypeName(
            "HRESULT (const D3D12_QUERY_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_QUERY_HEAP_DESC*,
            Guid*,
            void**,
            int> CreateQueryHeap;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetStablePowerState;

        [NativeTypeName(
            "HRESULT (const D3D12_COMMAND_SIGNATURE_DESC *, ID3D12RootSignature *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_COMMAND_SIGNATURE_DESC*,
            ID3D12RootSignature,
            Guid*,
            void**,
            int> CreateCommandSignature;

        [NativeTypeName(
            "void (ID3D12Resource *, UINT *, D3D12_PACKED_MIP_INFO *, D3D12_TILE_SHAPE *, UINT *, UINT, D3D12_SUBRESOURCE_TILING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            uint*,
            D3D12_PACKED_MIP_INFO*,
            D3D12_TILE_SHAPE*,
            uint*,
            uint,
            D3D12_SUBRESOURCE_TILING*,
            void> GetResourceTiling;

        [NativeTypeName("LUID () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LUID*, LUID*> GetAdapterLuid;

        [NativeTypeName(
            "HRESULT (const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void*, nuint, Guid*, void**, int> CreatePipelineLibrary;

        [NativeTypeName(
            "HRESULT (ID3D12Fence *const *, const UINT64 *, UINT, D3D12_MULTIPLE_FENCE_WAIT_FLAGS, HANDLE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Fence*,
            ulong*,
            uint,
            D3D12_MULTIPLE_FENCE_WAIT_FLAGS,
            HANDLE,
            int> SetEventOnMultipleFenceCompletion;

        [NativeTypeName(
            "HRESULT (UINT, ID3D12Pageable *const *, const D3D12_RESIDENCY_PRIORITY *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ID3D12Pageable*,
            D3D12_RESIDENCY_PRIORITY*,
            int> SetResidencyPriority;

        [NativeTypeName(
            "HRESULT (const D3D12_PIPELINE_STATE_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_PIPELINE_STATE_STREAM_DESC*,
            Guid*,
            void**,
            int> CreatePipelineState;

        [NativeTypeName("HRESULT (const void *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, Guid*, void**, int> OpenExistingHeapFromAddress;

        [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            HANDLE,
            Guid*,
            void**,
            int> OpenExistingHeapFromFileMapping;

        [NativeTypeName(
            "HRESULT (D3D12_RESIDENCY_FLAGS, UINT, ID3D12Pageable *const *, ID3D12Fence *, UINT64) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_RESIDENCY_FLAGS,
            uint,
            ID3D12Pageable*,
            ID3D12Fence,
            ulong,
            int> EnqueueMakeResident;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12Device3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Device3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Device2"/> to <see cref = "ID3D12Device3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Device2"/> instance to be converted </param>
    public static explicit operator ID3D12Device3(Silk.NET.DirectX.ID3D12Device2 value)
    {
        return new ID3D12Device3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Device3"/> to <see cref = "Silk.NET.DirectX.ID3D12Device2"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Device3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Device2(ID3D12Device3 value)
    {
        return new Silk.NET.DirectX.ID3D12Device2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Device1"/> to <see cref = "ID3D12Device3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Device1"/> instance to be converted </param>
    public static explicit operator ID3D12Device3(Silk.NET.DirectX.ID3D12Device1 value)
    {
        return new ID3D12Device3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Device3"/> to <see cref = "Silk.NET.DirectX.ID3D12Device1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Device3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Device1(ID3D12Device3 value)
    {
        return new Silk.NET.DirectX.ID3D12Device1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Device"/> to <see cref = "ID3D12Device3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Device"/> instance to be converted </param>
    public static explicit operator ID3D12Device3(Silk.NET.DirectX.ID3D12Device value)
    {
        return new ID3D12Device3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Device3"/> to <see cref = "Silk.NET.DirectX.ID3D12Device"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Device3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Device(ID3D12Device3 value)
    {
        return new Silk.NET.DirectX.ID3D12Device(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Object"/> to <see cref = "ID3D12Device3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Object"/> instance to be converted </param>
    public static explicit operator ID3D12Device3(Silk.NET.DirectX.ID3D12Object value)
    {
        return new ID3D12Device3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Device3"/> to <see cref = "Silk.NET.DirectX.ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Device3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Object(ID3D12Device3 value)
    {
        return new Silk.NET.DirectX.ID3D12Object(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12Device3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12Device3(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12Device3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Device3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Device3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12Device3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
