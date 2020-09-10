// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "ID3D12CommandQueue")]
    public unsafe partial struct ID3D12CommandQueue
    {
        public ID3D12CommandQueue
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Runtime.Windows.IUnknown* pData)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Runtime.Windows.IUnknown pData)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* guidPtr = &guid)
                {
                    fixed (Silk.NET.Core.Runtime.Windows.IUnknown* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, Silk.NET.Core.Runtime.Windows.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetName(char* Name)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, char*, int>)LpVtbl[6])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(ref char Name)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetName(string Name)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3D12CommandQueue*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDevicePtr = &ppvDevice)
                    {
                        ret = ((delegate* cdecl<ID3D12CommandQueue*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Heap* pHeapPtr = &pHeap)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ID3D12Resource* pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
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
                                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResource, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (ID3D12Heap* pHeapPtr = &pHeap)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, TiledResourceCoordinate* pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (ID3D12Heap* pHeapPtr = &pHeap)
                        {
                            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, TileRegionSize* pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizes, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                        {
                            fixed (uint* pRangeTileCountsPtr = &pRangeTileCounts)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                        {
                            fixed (uint* pHeapRangeStartOffsetsPtr = &pHeapRangeStartOffsets)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                        {
                            fixed (TileRangeFlags* pRangeFlagsPtr = &pRangeFlags)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ID3D12Heap* pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeap, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pResourcePtr = &pResource)
                {
                    fixed (TiledResourceCoordinate* pResourceRegionStartCoordinatesPtr = &pResourceRegionStartCoordinates)
                    {
                        fixed (TileRegionSize* pResourceRegionSizesPtr = &pResourceRegionSizes)
                        {
                            fixed (ID3D12Heap* pHeapPtr = &pHeap)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, TileRangeFlags* pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlags, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, uint* pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsets, pRangeTileCountsPtr, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, uint* pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCounts, Flags);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void UpdateTileMappings(ref ID3D12Resource pResource, uint NumResourceRegions, ref TiledResourceCoordinate pResourceRegionStartCoordinates, ref TileRegionSize pResourceRegionSizes, ref ID3D12Heap pHeap, uint NumRanges, ref TileRangeFlags pRangeFlags, ref uint pHeapRangeStartOffsets, ref uint pRangeTileCounts, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, uint, TiledResourceCoordinate*, TileRegionSize*, ID3D12Heap*, uint, TileRangeFlags*, uint*, uint*, TileMappingFlags, void>)LpVtbl[8])(@this, pResourcePtr, NumResourceRegions, pResourceRegionStartCoordinatesPtr, pResourceRegionSizesPtr, pHeapPtr, NumRanges, pRangeFlagsPtr, pHeapRangeStartOffsetsPtr, pRangeTileCountsPtr, Flags);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                {
                    fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                {
                    fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                {
                    fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                {
                    fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                {
                    fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ID3D12Resource* pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                {
                    fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                        {
                            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResource, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, TiledResourceCoordinate* pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                    {
                        fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                        {
                            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinate, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                    {
                        ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                    {
                        fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                    {
                        fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ID3D12Resource* pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                    {
                        fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                        {
                            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResource, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                    {
                        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                        {
                            ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSize, Flags);
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, TiledResourceCoordinate* pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                    {
                        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                        {
                            fixed (TileRegionSize* pRegionSizePtr = &pRegionSize)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinate, pRegionSizePtr, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void CopyTileMappings(ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, TileRegionSize* pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
                {
                    fixed (TiledResourceCoordinate* pDstRegionStartCoordinatePtr = &pDstRegionStartCoordinate)
                    {
                        fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                        {
                            fixed (TiledResourceCoordinate* pSrcRegionStartCoordinatePtr = &pSrcRegionStartCoordinate)
                            {
                                ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSize, Flags);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public void CopyTileMappings(ref ID3D12Resource pDstResource, ref TiledResourceCoordinate pDstRegionStartCoordinate, ref ID3D12Resource pSrcResource, ref TiledResourceCoordinate pSrcRegionStartCoordinate, ref TileRegionSize pRegionSize, TileMappingFlags Flags)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
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
                                    ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Resource*, TiledResourceCoordinate*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, TileMappingFlags, void>)LpVtbl[9])(@this, pDstResourcePtr, pDstRegionStartCoordinatePtr, pSrcResourcePtr, pSrcRegionStartCoordinatePtr, pRegionSizePtr, Flags);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteCommandLists(uint NumCommandLists, ID3D12CommandList** ppCommandLists)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12CommandQueue*, uint, ID3D12CommandList**, void>)LpVtbl[10])(@this, NumCommandLists, ppCommandLists);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void ExecuteCommandLists(uint NumCommandLists, ref ID3D12CommandList* ppCommandLists)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (ID3D12CommandList** ppCommandListsPtr = &ppCommandLists)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, uint, ID3D12CommandList**, void>)LpVtbl[10])(@this, NumCommandLists, ppCommandListsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetMarker(uint Metadata, void* pData, uint Size)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12CommandQueue*, uint, void*, uint, void>)LpVtbl[11])(@this, Metadata, pData, Size);
            }
        }

        /// <summary>To be added.</summary>
        public void SetMarker<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, uint, T0*, uint, void>)LpVtbl[11])(@this, Metadata, pDataPtr, Size);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void BeginEvent(uint Metadata, void* pData, uint Size)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12CommandQueue*, uint, void*, uint, void>)LpVtbl[12])(@this, Metadata, pData, Size);
            }
        }

        /// <summary>To be added.</summary>
        public void BeginEvent<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ((delegate* cdecl<ID3D12CommandQueue*, uint, T0*, uint, void>)LpVtbl[12])(@this, Metadata, pDataPtr, Size);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void EndEvent()
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                ((delegate* cdecl<ID3D12CommandQueue*, void>)LpVtbl[13])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Signal(ID3D12Fence* pFence, ulong Value)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)LpVtbl[14])(@this, pFence, Value);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Signal(ref ID3D12Fence pFence, ulong Value)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (ID3D12Fence* pFencePtr = &pFence)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)LpVtbl[14])(@this, pFencePtr, Value);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Wait(ID3D12Fence* pFence, ulong Value)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)LpVtbl[15])(@this, pFence, Value);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Wait(ref ID3D12Fence pFence, ulong Value)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (ID3D12Fence* pFencePtr = &pFence)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, ID3D12Fence*, ulong, int>)LpVtbl[15])(@this, pFencePtr, Value);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetTimestampFrequency(ulong* pFrequency)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, ulong*, int>)LpVtbl[16])(@this, pFrequency);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetTimestampFrequency(ref ulong pFrequency)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (ulong* pFrequencyPtr = &pFrequency)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, ulong*, int>)LpVtbl[16])(@this, pFrequencyPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClockCalibration(ulong* pGpuTimestamp, ulong* pCpuTimestamp)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, ulong*, ulong*, int>)LpVtbl[17])(@this, pGpuTimestamp, pCpuTimestamp);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClockCalibration(ulong* pGpuTimestamp, ref ulong pCpuTimestamp)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (ulong* pCpuTimestampPtr = &pCpuTimestamp)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, ulong*, ulong*, int>)LpVtbl[17])(@this, pGpuTimestamp, pCpuTimestampPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetClockCalibration(ref ulong pGpuTimestamp, ulong* pCpuTimestamp)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (ulong* pGpuTimestampPtr = &pGpuTimestamp)
                {
                    ret = ((delegate* cdecl<ID3D12CommandQueue*, ulong*, ulong*, int>)LpVtbl[17])(@this, pGpuTimestampPtr, pCpuTimestamp);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetClockCalibration(ref ulong pGpuTimestamp, ref ulong pCpuTimestamp)
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                int ret = default;
                fixed (ulong* pGpuTimestampPtr = &pGpuTimestamp)
                {
                    fixed (ulong* pCpuTimestampPtr = &pCpuTimestamp)
                    {
                        ret = ((delegate* cdecl<ID3D12CommandQueue*, ulong*, ulong*, int>)LpVtbl[17])(@this, pGpuTimestampPtr, pCpuTimestampPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public CommandQueueDesc GetDesc()
        {
            fixed (ID3D12CommandQueue* @this = &this)
            {
                CommandQueueDesc ret = default;
                ret = ((delegate* cdecl<ID3D12CommandQueue*, CommandQueueDesc>)LpVtbl[18])(@this);
                return ret;
            }
        }

    }
}
