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
    public static unsafe int SetPrivateData(this ComPtr<ID3D12CommandQueue> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
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
    public static unsafe int SetName(this ComPtr<ID3D12CommandQueue> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, char*, int>)@this->LpVtbl[6])(@this, Name);
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
    public static unsafe void UpdateTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void CopyTileMappings(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ExecuteCommandLists(this ComPtr<ID3D12CommandQueue> thisVtbl, uint NumCommandLists, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12CommandList** ppCommandLists)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, ID3D12CommandList**, void>)@this->LpVtbl[10])(@this, NumCommandLists, ppCommandLists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker(this ComPtr<ID3D12CommandQueue> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[11])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEvent(this ComPtr<ID3D12CommandQueue> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[12])(@this, Metadata, pData, Size);
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
    public static unsafe int Wait(this ComPtr<ID3D12CommandQueue> thisVtbl, ID3D12Fence* pFence, ulong Value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[15])(@this, pFence, Value);
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
    public static unsafe int GetClockCalibration(this ComPtr<ID3D12CommandQueue> thisVtbl, ulong* pGpuTimestamp, ulong* pCpuTimestamp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, ulong*, int>)@this->LpVtbl[17])(@this, pGpuTimestamp, pCpuTimestamp);
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

}
