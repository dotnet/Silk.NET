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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe int SetName<TThis>(this TThis thisVtbl, char* Name) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, ref char Name) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppvDevice) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvDevice) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Heap* pHeapPtr = &pHeap)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static void UpdateTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
        {
            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
        {
            fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
        {
            fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static void CopyTileMappings<TThis>(this TThis thisVtbl, ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static unsafe void ExecuteCommandLists<TThis>(this TThis thisVtbl, uint NumCommandLists, ID3D12CommandList** ppCommandLists) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, ID3D12CommandList**, void>)@this->LpVtbl[10])(@this, NumCommandLists, ppCommandLists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteCommandLists<TThis>(this TThis thisVtbl, uint NumCommandLists, ref ID3D12CommandList* ppCommandLists) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (ID3D12CommandList** ppCommandListsPtr = &ppCommandLists)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, ID3D12CommandList**, void>)@this->LpVtbl[10])(@this, NumCommandLists, ppCommandListsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker<TThis>(this TThis thisVtbl, uint Metadata, void* pData, uint Size) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[11])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0, TThis>(this TThis thisVtbl, uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[11])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEvent<TThis>(this TThis thisVtbl, uint Metadata, void* pData, uint Size) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[12])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0, TThis>(this TThis thisVtbl, uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[12])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static void EndEvent<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, void>)@this->LpVtbl[13])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Signal<TThis>(this TThis thisVtbl, ID3D12Fence* pFence, ulong Value) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[14])(@this, pFence, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Signal<TThis>(this TThis thisVtbl, ref ID3D12Fence pFence, ulong Value) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Fence* pFencePtr = &pFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[14])(@this, pFencePtr, Value);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Wait<TThis>(this TThis thisVtbl, ID3D12Fence* pFence, ulong Value) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[15])(@this, pFence, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Wait<TThis>(this TThis thisVtbl, ref ID3D12Fence pFence, ulong Value) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12Fence* pFencePtr = &pFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[15])(@this, pFencePtr, Value);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimestampFrequency<TThis>(this TThis thisVtbl, ulong* pFrequency) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, int>)@this->LpVtbl[16])(@this, pFrequency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTimestampFrequency<TThis>(this TThis thisVtbl, ref ulong pFrequency) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ulong* pFrequencyPtr = &pFrequency)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, int>)@this->LpVtbl[16])(@this, pFrequencyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClockCalibration<TThis>(this TThis thisVtbl, ulong* pGpuTimestamp, ulong* pCpuTimestamp) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, ulong*, int>)@this->LpVtbl[17])(@this, pGpuTimestamp, pCpuTimestamp);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClockCalibration<TThis>(this TThis thisVtbl, ulong* pGpuTimestamp, ref ulong pCpuTimestamp) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ulong* pCpuTimestampPtr = &pCpuTimestamp)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, ulong*, int>)@this->LpVtbl[17])(@this, pGpuTimestamp, pCpuTimestampPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClockCalibration<TThis>(this TThis thisVtbl, ref ulong pGpuTimestamp, ulong* pCpuTimestamp) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ulong* pGpuTimestampPtr = &pGpuTimestamp)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, ulong*, int>)@this->LpVtbl[17])(@this, pGpuTimestampPtr, pCpuTimestamp);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClockCalibration<TThis>(this TThis thisVtbl, ref ulong pGpuTimestamp, ref ulong pCpuTimestamp) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
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
    public static CommandQueueDesc GetDesc<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        CommandQueueDesc ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, CommandQueueDesc>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, Span<char> Name) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvDevice) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(pResource, NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, pResourceRegionStartCoordinates, ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), pResourceRegionSizes, ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), pHeap, NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, pRangeFlags, ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, uint* pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), pHeapRangeStartOffsets, ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void UpdateTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, uint NumResourceRegions, Span<TiledResourceCoordinate> pResourceRegionStartCoordinates, Span<TileRegionSize> pResourceRegionSizes, Span<ID3D12Heap> pHeap, uint NumRanges, Span<TileRangeFlags> pRangeFlags, Span<uint> pHeapRangeStartOffsets, Span<uint> pRangeTileCounts, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->UpdateTileMappings(ref pResource.GetPinnableReference(), NumResourceRegions, ref pResourceRegionStartCoordinates.GetPinnableReference(), ref pResourceRegionSizes.GetPinnableReference(), ref pHeap.GetPinnableReference(), NumRanges, ref pRangeFlags.GetPinnableReference(), ref pHeapRangeStartOffsets.GetPinnableReference(), ref pRangeTileCounts.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, pSrcResource, ref pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, pSrcResource, ref pSrcRegionStartCoordinate.GetPinnableReference(), ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), ref pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), ref pSrcRegionStartCoordinate.GetPinnableReference(), ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, ref pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, ref pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, pSrcRegionStartCoordinate, ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, ref pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, ref pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, ref pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, ref pSrcRegionStartCoordinate.GetPinnableReference(), ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, ref pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, ref pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, ref pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), ref pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, ID3D12Resource* pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(pDstResource, ref pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), ref pSrcRegionStartCoordinate.GetPinnableReference(), ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, pSrcResource, ref pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, pSrcResource, ref pSrcRegionStartCoordinate.GetPinnableReference(), ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), ref pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), pDstRegionStartCoordinate, ref pSrcResource.GetPinnableReference(), ref pSrcRegionStartCoordinate.GetPinnableReference(), ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), ref pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), ref pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, pSrcRegionStartCoordinate, ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), ref pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, ref pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), ref pDstRegionStartCoordinate.GetPinnableReference(), pSrcResource, ref pSrcRegionStartCoordinate.GetPinnableReference(), ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), ref pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), ref pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), pSrcRegionStartCoordinate, ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), ref pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), ref pSrcRegionStartCoordinate.GetPinnableReference(), pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static void CopyTileMappings<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pDstResource, Span<TiledResourceCoordinate> pDstRegionStartCoordinate, Span<ID3D12Resource> pSrcResource, Span<TiledResourceCoordinate> pSrcRegionStartCoordinate, Span<TileRegionSize> pRegionSize, TileMappingFlags Flags) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->CopyTileMappings(ref pDstResource.GetPinnableReference(), ref pDstRegionStartCoordinate.GetPinnableReference(), ref pSrcResource.GetPinnableReference(), ref pSrcRegionStartCoordinate.GetPinnableReference(), ref pRegionSize.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0, TThis>(this TThis thisVtbl, uint Metadata, Span<T0> pData, uint Size) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SetMarker(Metadata, ref pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0, TThis>(this TThis thisVtbl, uint Metadata, Span<T0> pData, uint Size) where T0 : unmanaged where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->BeginEvent(Metadata, ref pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static int Signal<TThis>(this TThis thisVtbl, Span<ID3D12Fence> pFence, ulong Value) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Signal(ref pFence.GetPinnableReference(), Value);
    }

    /// <summary>To be documented.</summary>
    public static int Wait<TThis>(this TThis thisVtbl, Span<ID3D12Fence> pFence, ulong Value) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Wait(ref pFence.GetPinnableReference(), Value);
    }

    /// <summary>To be documented.</summary>
    public static int GetTimestampFrequency<TThis>(this TThis thisVtbl, Span<ulong> pFrequency) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetTimestampFrequency(ref pFrequency.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClockCalibration<TThis>(this TThis thisVtbl, ulong* pGpuTimestamp, Span<ulong> pCpuTimestamp) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetClockCalibration(pGpuTimestamp, ref pCpuTimestamp.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClockCalibration<TThis>(this TThis thisVtbl, Span<ulong> pGpuTimestamp, ulong* pCpuTimestamp) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetClockCalibration(ref pGpuTimestamp.GetPinnableReference(), pCpuTimestamp);
    }

    /// <summary>To be documented.</summary>
    public static int GetClockCalibration<TThis>(this TThis thisVtbl, Span<ulong> pGpuTimestamp, Span<ulong> pCpuTimestamp) where TThis : IComVtbl<ID3D12CommandQueue>
    {
        var @this = (ID3D12CommandQueue*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetClockCalibration(ref pGpuTimestamp.GetPinnableReference(), ref pCpuTimestamp.GetPinnableReference());
    }

}
