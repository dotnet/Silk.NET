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

[Guid("0EC870A6-5D7E-4C22-8CFC-5BAAE07616ED")]
[NativeTypeName("struct ID3D12CommandQueue : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
public unsafe partial struct ID3D12CommandQueue : ID3D12CommandQueue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12CommandQueue));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12CommandQueue, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12CommandQueue, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12CommandQueue, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* guid,
        uint* pDataSize,
        void* pData
    )
    {
        return ((delegate* unmanaged<ID3D12CommandQueue, Guid*, uint*, void*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<ID3D12CommandQueue, Guid*, uint, void*, int>)((*lpVtbl)[4]))(
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
        return ((delegate* unmanaged<ID3D12CommandQueue, Guid*, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            guid,
            pData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
    {
        return ((delegate* unmanaged<ID3D12CommandQueue, ushort*, int>)((*lpVtbl)[6]))(this, Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
    {
        return ((delegate* unmanaged<ID3D12CommandQueue, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppvDevice
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void UpdateTileMappings(
        ID3D12Resource pResource,
        uint NumResourceRegions,
        [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")]
            D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates,
        [NativeTypeName("const D3D12_TILE_REGION_SIZE *")]
            D3D12_TILE_REGION_SIZE* pResourceRegionSizes,
        ID3D12Heap pHeap,
        uint NumRanges,
        [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] D3D12_TILE_RANGE_FLAGS* pRangeFlags,
        [NativeTypeName("const UINT *")] uint* pHeapRangeStartOffsets,
        [NativeTypeName("const UINT *")] uint* pRangeTileCounts,
        D3D12_TILE_MAPPING_FLAGS Flags
    )
    {
        (
            (delegate* unmanaged<
                ID3D12CommandQueue,
                ID3D12Resource,
                uint,
                D3D12_TILED_RESOURCE_COORDINATE*,
                D3D12_TILE_REGION_SIZE*,
                ID3D12Heap,
                uint,
                D3D12_TILE_RANGE_FLAGS*,
                uint*,
                uint*,
                D3D12_TILE_MAPPING_FLAGS,
                void>)((*lpVtbl)[8])
        )(
            this,
            pResource,
            NumResourceRegions,
            pResourceRegionStartCoordinates,
            pResourceRegionSizes,
            pHeap,
            NumRanges,
            pRangeFlags,
            pHeapRangeStartOffsets,
            pRangeTileCounts,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void CopyTileMappings(
        ID3D12Resource pDstResource,
        [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")]
            D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate,
        ID3D12Resource pSrcResource,
        [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")]
            D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate,
        [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pRegionSize,
        D3D12_TILE_MAPPING_FLAGS Flags
    )
    {
        (
            (delegate* unmanaged<
                ID3D12CommandQueue,
                ID3D12Resource,
                D3D12_TILED_RESOURCE_COORDINATE*,
                ID3D12Resource,
                D3D12_TILED_RESOURCE_COORDINATE*,
                D3D12_TILE_REGION_SIZE*,
                D3D12_TILE_MAPPING_FLAGS,
                void>)((*lpVtbl)[9])
        )(
            this,
            pDstResource,
            pDstRegionStartCoordinate,
            pSrcResource,
            pSrcRegionStartCoordinate,
            pRegionSize,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void ExecuteCommandLists(
        uint NumCommandLists,
        [NativeTypeName("ID3D12CommandList *const *")] ID3D12CommandList* ppCommandLists
    )
    {
        ((delegate* unmanaged<ID3D12CommandQueue, uint, ID3D12CommandList*, void>)((*lpVtbl)[10]))(
            this,
            NumCommandLists,
            ppCommandLists
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged<ID3D12CommandQueue, uint, void*, uint, void>)((*lpVtbl)[11]))(
            this,
            Metadata,
            pData,
            Size
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
    {
        ((delegate* unmanaged<ID3D12CommandQueue, uint, void*, uint, void>)((*lpVtbl)[12]))(
            this,
            Metadata,
            pData,
            Size
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void EndEvent()
    {
        ((delegate* unmanaged<ID3D12CommandQueue, void>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Signal(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong Value)
    {
        return ((delegate* unmanaged<ID3D12CommandQueue, ID3D12Fence, ulong, int>)((*lpVtbl)[14]))(
            this,
            pFence,
            Value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Wait(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong Value)
    {
        return ((delegate* unmanaged<ID3D12CommandQueue, ID3D12Fence, ulong, int>)((*lpVtbl)[15]))(
            this,
            pFence,
            Value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetTimestampFrequency([NativeTypeName("UINT64 *")] ulong* pFrequency)
    {
        return ((delegate* unmanaged<ID3D12CommandQueue, ulong*, int>)((*lpVtbl)[16]))(
            this,
            pFrequency
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetClockCalibration(
        [NativeTypeName("UINT64 *")] ulong* pGpuTimestamp,
        [NativeTypeName("UINT64 *")] ulong* pCpuTimestamp
    )
    {
        return ((delegate* unmanaged<ID3D12CommandQueue, ulong*, ulong*, int>)((*lpVtbl)[17]))(
            this,
            pGpuTimestamp,
            pCpuTimestamp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public D3D12_COMMAND_QUEUE_DESC GetDesc()
    {
        D3D12_COMMAND_QUEUE_DESC result;
        return *(
            (delegate* unmanaged<
                ID3D12CommandQueue,
                D3D12_COMMAND_QUEUE_DESC*,
                D3D12_COMMAND_QUEUE_DESC*>)((*lpVtbl)[18])
        )(this, &result);
    }

    public interface Interface : ID3D12Pageable.Interface
    {
        [VtblIndex(8)]
        void UpdateTileMappings(
            ID3D12Resource pResource,
            uint NumResourceRegions,
            [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")]
                D3D12_TILED_RESOURCE_COORDINATE* pResourceRegionStartCoordinates,
            [NativeTypeName("const D3D12_TILE_REGION_SIZE *")]
                D3D12_TILE_REGION_SIZE* pResourceRegionSizes,
            ID3D12Heap pHeap,
            uint NumRanges,
            [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] D3D12_TILE_RANGE_FLAGS* pRangeFlags,
            [NativeTypeName("const UINT *")] uint* pHeapRangeStartOffsets,
            [NativeTypeName("const UINT *")] uint* pRangeTileCounts,
            D3D12_TILE_MAPPING_FLAGS Flags
        );

        [VtblIndex(9)]
        void CopyTileMappings(
            ID3D12Resource pDstResource,
            [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")]
                D3D12_TILED_RESOURCE_COORDINATE* pDstRegionStartCoordinate,
            ID3D12Resource pSrcResource,
            [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")]
                D3D12_TILED_RESOURCE_COORDINATE* pSrcRegionStartCoordinate,
            [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12_TILE_REGION_SIZE* pRegionSize,
            D3D12_TILE_MAPPING_FLAGS Flags
        );

        [VtblIndex(10)]
        void ExecuteCommandLists(
            uint NumCommandLists,
            [NativeTypeName("ID3D12CommandList *const *")] ID3D12CommandList* ppCommandLists
        );

        [VtblIndex(11)]
        void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);

        [VtblIndex(12)]
        void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);

        [VtblIndex(13)]
        void EndEvent();

        [VtblIndex(14)]
        HRESULT Signal(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong Value);

        [VtblIndex(15)]
        HRESULT Wait(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong Value);

        [VtblIndex(16)]
        HRESULT GetTimestampFrequency([NativeTypeName("UINT64 *")] ulong* pFrequency);

        [VtblIndex(17)]
        HRESULT GetClockCalibration(
            [NativeTypeName("UINT64 *")] ulong* pGpuTimestamp,
            [NativeTypeName("UINT64 *")] ulong* pCpuTimestamp
        );

        [VtblIndex(18)]
        D3D12_COMMAND_QUEUE_DESC GetDesc();
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

        [NativeTypeName(
            "void (ID3D12Resource *, UINT, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, ID3D12Heap *, UINT, const D3D12_TILE_RANGE_FLAGS *, const UINT *, const UINT *, D3D12_TILE_MAPPING_FLAGS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            uint,
            D3D12_TILED_RESOURCE_COORDINATE*,
            D3D12_TILE_REGION_SIZE*,
            ID3D12Heap,
            uint,
            D3D12_TILE_RANGE_FLAGS*,
            uint*,
            uint*,
            D3D12_TILE_MAPPING_FLAGS,
            void> UpdateTileMappings;

        [NativeTypeName(
            "void (ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, D3D12_TILE_MAPPING_FLAGS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            D3D12_TILED_RESOURCE_COORDINATE*,
            ID3D12Resource,
            D3D12_TILED_RESOURCE_COORDINATE*,
            D3D12_TILE_REGION_SIZE*,
            D3D12_TILE_MAPPING_FLAGS,
            void> CopyTileMappings;

        [NativeTypeName("void (UINT, ID3D12CommandList *const *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12CommandList*, void> ExecuteCommandLists;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void> SetMarker;

        [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, void> BeginEvent;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EndEvent;

        [NativeTypeName("HRESULT (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Fence, ulong, int> Signal;

        [NativeTypeName("HRESULT (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Fence, ulong, int> Wait;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetTimestampFrequency;

        [NativeTypeName("HRESULT (UINT64 *, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, ulong*, int> GetClockCalibration;

        [NativeTypeName("D3D12_COMMAND_QUEUE_DESC () __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_COMMAND_QUEUE_DESC*,
            D3D12_COMMAND_QUEUE_DESC*> GetDesc;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12CommandQueue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12CommandQueue(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Pageable"/> to <see cref = "ID3D12CommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Pageable"/> instance to be converted </param>
    public static explicit operator ID3D12CommandQueue(Silk.NET.DirectX.ID3D12Pageable value)
    {
        return new ID3D12CommandQueue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12CommandQueue"/> to <see cref = "Silk.NET.DirectX.ID3D12Pageable"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueue"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Pageable(ID3D12CommandQueue value)
    {
        return new Silk.NET.DirectX.ID3D12Pageable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> to <see cref = "ID3D12CommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/> instance to be converted </param>
    public static explicit operator ID3D12CommandQueue(Silk.NET.DirectX.ID3D12DeviceChild value)
    {
        return new ID3D12CommandQueue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12CommandQueue"/> to <see cref = "Silk.NET.DirectX.ID3D12DeviceChild"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueue"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DeviceChild(ID3D12CommandQueue value)
    {
        return new Silk.NET.DirectX.ID3D12DeviceChild(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Object"/> to <see cref = "ID3D12CommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Object"/> instance to be converted </param>
    public static explicit operator ID3D12CommandQueue(Silk.NET.DirectX.ID3D12Object value)
    {
        return new ID3D12CommandQueue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12CommandQueue"/> to <see cref = "Silk.NET.DirectX.ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueue"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Object(ID3D12CommandQueue value)
    {
        return new Silk.NET.DirectX.ID3D12Object(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12CommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12CommandQueue(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12CommandQueue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12CommandQueue"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueue"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12CommandQueue value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
