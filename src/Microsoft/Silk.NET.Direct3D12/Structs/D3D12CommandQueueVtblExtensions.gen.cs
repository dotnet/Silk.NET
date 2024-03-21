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

public unsafe static class D3D12CommandQueueVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12CommandQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12CommandQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12CommandQueue> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12CommandQueue> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12CommandQueue> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
        {
            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
            {
                fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
            {
                fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
            {
                fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
            {
                fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
            {
                fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
            {
                fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                        }
                    }
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteCommandLists(this ComPtr<ID3D12CommandQueue> thisVtbl, uint NumCommandLists, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12CommandList** ppCommandLists)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, ID3D12CommandList**, void>)@this->LpVtbl[10])(@this, NumCommandLists, ppCommandLists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteCommandLists(this ComPtr<ID3D12CommandQueue> thisVtbl, uint NumCommandLists, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12CommandList* ppCommandLists)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12CommandList** ppCommandListsPtr = &ppCommandLists)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, ID3D12CommandList**, void>)@this->LpVtbl[10])(@this, NumCommandLists, ppCommandListsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker(this ComPtr<ID3D12CommandQueue> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[11])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[11])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEvent(this ComPtr<ID3D12CommandQueue> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[12])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[12])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static void EndEvent(this ComPtr<ID3D12CommandQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, void>)@this->LpVtbl[13])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Signal(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Fence* pFence, ulong Value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[14])(@this, pFence, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Signal(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Fence pFence, ulong Value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Fence* pFencePtr = &pFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[14])(@this, pFencePtr, Value);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Wait(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Fence* pFence, ulong Value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[15])(@this, pFence, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Wait(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Fence pFence, ulong Value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12Fence* pFencePtr = &pFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[15])(@this, pFencePtr, Value);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimestampFrequency(this ComPtr<ID3D12CommandQueue> thisVtbl, ulong* pFrequency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, int>)@this->LpVtbl[16])(@this, pFrequency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTimestampFrequency(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ulong pFrequency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pFrequencyPtr = &pFrequency)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, int>)@this->LpVtbl[16])(@this, pFrequencyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClockCalibration(this ComPtr<ID3D12CommandQueue> thisVtbl, ulong* pGpuTimestamp, ulong* pCpuTimestamp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, ulong*, int>)@this->LpVtbl[17])(@this, pGpuTimestamp, pCpuTimestamp);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClockCalibration(this ComPtr<ID3D12CommandQueue> thisVtbl, ulong* pGpuTimestamp, ref ulong pCpuTimestamp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pCpuTimestampPtr = &pCpuTimestamp)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, ulong*, int>)@this->LpVtbl[17])(@this, pGpuTimestamp, pCpuTimestampPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClockCalibration(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ulong pGpuTimestamp, ulong* pCpuTimestamp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pGpuTimestampPtr = &pGpuTimestamp)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, ulong*, int>)@this->LpVtbl[17])(@this, pGpuTimestampPtr, pCpuTimestamp);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClockCalibration(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ulong pGpuTimestamp, ref ulong pCpuTimestamp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pGpuTimestampPtr = &pGpuTimestamp)
        {
            fixed (ulong* pCpuTimestampPtr = &pCpuTimestamp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, ulong*, int>)@this->LpVtbl[17])(@this, pGpuTimestampPtr, pCpuTimestampPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CommandQueueDesc GetDesc(this ComPtr<ID3D12CommandQueue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CommandQueueDesc silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        CommandQueueDesc* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, CommandQueueDesc*, CommandQueueDesc*>)@this->LpVtbl[18])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12CommandQueue> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<Guid> riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static void UpdateTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI1> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings((ID3D12Resource*) pResource.Handle, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, ref pHeap, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static void UpdateTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pResourceRegionSizes, ComPtr<TI0> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRangeFlags pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pRangeTileCounts, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->UpdateTileMappings(ref pResource, NumResourceRegions, in pResourceRegionStartCoordinates, in pResourceRegionSizes, (ID3D12Heap*) pHeap.Handle, NumRanges, in pRangeFlags, in pHeapRangeStartOffsets, in pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRangeFlags> pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, in pResourceRegionStartCoordinates.GetPinnableReference(), in pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, in pRangeFlags.GetPinnableReference(), in pHeapRangeStartOffsets.GetPinnableReference(), in pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ComPtr<TI1> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ComPtr<TI1> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, pSrcResource, in pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ComPtr<TI1> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, in pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, pSrcResource, in pSrcRegionStartCoordinate.GetPinnableReference(), in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ComPtr<TI1> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, in pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, pDstRegionStartCoordinate, ref pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, pDstRegionStartCoordinate, ref pSrcResource, pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), in pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, pDstRegionStartCoordinate, ref pSrcResource, in pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), in pSrcRegionStartCoordinate.GetPinnableReference(), in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, pDstRegionStartCoordinate, ref pSrcResource, in pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, in pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ComPtr<TI1> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, in pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, in pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, pSrcRegionStartCoordinate, in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ComPtr<TI1> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, in pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, in pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, in pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ComPtr<TI1> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, in pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, in pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, in pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, in pSrcRegionStartCoordinate.GetPinnableReference(), in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTileMappings<TI0, TI1>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ComPtr<TI1> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, in pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, in pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, in pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, in pDstRegionStartCoordinate, ref pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, in pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, in pDstRegionStartCoordinate, ref pSrcResource, pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, in pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), in pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, in pDstRegionStartCoordinate, ref pSrcResource, in pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, in pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), in pSrcRegionStartCoordinate.GetPinnableReference(), in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings((ID3D12Resource*) pDstResource.Handle, in pDstRegionStartCoordinate, ref pSrcResource, in pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ComPtr<TI0> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings(ref pDstResource, pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ComPtr<TI0> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings(ref pDstResource, pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, pSrcResource, in pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ComPtr<TI0> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings(ref pDstResource, pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, in pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, pSrcResource, in pSrcRegionStartCoordinate.GetPinnableReference(), in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ComPtr<TI0> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings(ref pDstResource, pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, in pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), in pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), in pSrcRegionStartCoordinate.GetPinnableReference(), in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), in pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ComPtr<TI0> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings(ref pDstResource, in pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), in pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, pSrcRegionStartCoordinate, in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ComPtr<TI0> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings(ref pDstResource, in pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), in pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, in pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ComPtr<TI0> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings(ref pDstResource, in pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, in pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), in pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, in pSrcRegionStartCoordinate.GetPinnableReference(), in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTileMappings<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ref ID3D12Resource pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pDstRegionStartCoordinate, ComPtr<TI0> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TiledResourceCoordinate pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TileRegionSize pRegionSize, TileMappingFlags Flags) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->CopyTileMappings(ref pDstResource, in pDstRegionStartCoordinate, (ID3D12Resource*) pSrcResource.Handle, in pSrcRegionStartCoordinate, in pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), in pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), in pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), in pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), in pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Resource> pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TiledResourceCoordinate> pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TileRegionSize> pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), in pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), in pSrcRegionStartCoordinate.GetPinnableReference(), in pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static void ExecuteCommandLists<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, uint NumCommandLists, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppCommandLists) where TI0 : unmanaged, IComVtbl<ID3D12CommandList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ExecuteCommandLists(NumCommandLists, (ID3D12CommandList**) ppCommandLists.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetMarker(Metadata, in pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0>(this ComPtr<ID3D12CommandQueue> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginEvent(Metadata, in pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static int Signal<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pFence, ulong Value) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Signal((ID3D12Fence*) pFence.Handle, Value);
    }

    /// <summary>To be documented.</summary>
    public static int Signal(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Fence> pFence, ulong Value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Signal(ref pFence.GetPinnableReference(), Value);
    }

    /// <summary>To be documented.</summary>
    public static int Wait<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl, ComPtr<TI0> pFence, ulong Value) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Wait((ID3D12Fence*) pFence.Handle, Value);
    }

    /// <summary>To be documented.</summary>
    public static int Wait(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ID3D12Fence> pFence, ulong Value)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Wait(ref pFence.GetPinnableReference(), Value);
    }

    /// <summary>To be documented.</summary>
    public static int GetTimestampFrequency(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ulong> pFrequency)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimestampFrequency(ref pFrequency.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClockCalibration(this ComPtr<ID3D12CommandQueue> thisVtbl, ulong* pGpuTimestamp, Span<ulong> pCpuTimestamp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClockCalibration(pGpuTimestamp, ref pCpuTimestamp.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClockCalibration(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ulong> pGpuTimestamp, ulong* pCpuTimestamp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClockCalibration(ref pGpuTimestamp.GetPinnableReference(), pCpuTimestamp);
    }

    /// <summary>To be documented.</summary>
    public static int GetClockCalibration(this ComPtr<ID3D12CommandQueue> thisVtbl, Span<ulong> pGpuTimestamp, Span<ulong> pCpuTimestamp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClockCalibration(ref pGpuTimestamp.GetPinnableReference(), ref pCpuTimestamp.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0>(this ComPtr<ID3D12CommandQueue> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
