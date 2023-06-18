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

namespace Silk.NET.Direct3D12
{
    [Guid("0ec870a6-5d7e-4c22-8cfc-5baae07616ed")]
    [NativeName("Name", "ID3D12CommandQueue")]
    public unsafe partial struct ID3D12CommandQueue : IComVtbl<ID3D12CommandQueue>, IComVtbl<ID3D12Pageable>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0ec870a6-5d7e-4c22-8cfc-5baae07616ed");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12Pageable(ID3D12CommandQueue val)
            => Unsafe.As<ID3D12CommandQueue, ID3D12Pageable>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12CommandQueue val)
            => Unsafe.As<ID3D12CommandQueue, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12CommandQueue val)
            => Unsafe.As<ID3D12CommandQueue, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12CommandQueue val)
            => Unsafe.As<ID3D12CommandQueue, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12CommandQueue
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pResourceRegionStartCoordinates, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRangeFlags* pRangeFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pHeapRangeStartOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)@this->LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTileMappings(ID3D12Resource* pDstResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TiledResourceCoordinate* pSrcRegionStartCoordinate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)@this->LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteCommandLists(uint NumCommandLists, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12CommandList** ppCommandLists)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, ID3D12CommandList**, void>)@this->LpVtbl[10])(@this, NumCommandLists, ppCommandLists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarker(uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[11])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginEvent(uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, uint, void*, uint, void>)@this->LpVtbl[12])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndEvent()
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, void>)@this->LpVtbl[13])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Signal(ID3D12Fence* pFence, ulong Value)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[14])(@this, pFence, Value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Wait(ID3D12Fence* pFence, ulong Value)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)@this->LpVtbl[15])(@this, pFence, Value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimestampFrequency(ulong* pFrequency)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, int>)@this->LpVtbl[16])(@this, pFrequency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClockCalibration(ulong* pGpuTimestamp, ulong* pCpuTimestamp)
        {
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, ulong*, ulong*, int>)@this->LpVtbl[17])(@this, pGpuTimestamp, pCpuTimestamp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CommandQueueDesc GetDesc()
        {
            CommandQueueDesc silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12CommandQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CommandQueueDesc* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CommandQueue*, CommandQueueDesc*, CommandQueueDesc*>)@this->LpVtbl[18])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

    }
}
