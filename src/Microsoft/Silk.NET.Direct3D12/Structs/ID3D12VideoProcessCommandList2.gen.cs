// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Guid("db525ae4-6ad6-473c-baa7-59b2e37082e4")]
    [NativeName("Name", "ID3D12VideoProcessCommandList2")]
    public unsafe partial struct ID3D12VideoProcessCommandList2
    {
        public static implicit operator ID3D12VideoProcessCommandList1(ID3D12VideoProcessCommandList2 val)
            => Unsafe.As<ID3D12VideoProcessCommandList2, ID3D12VideoProcessCommandList1>(ref val);

        public static implicit operator ID3D12VideoProcessCommandList(ID3D12VideoProcessCommandList2 val)
            => Unsafe.As<ID3D12VideoProcessCommandList2, ID3D12VideoProcessCommandList>(ref val);

        public static implicit operator ID3D12CommandList(ID3D12VideoProcessCommandList2 val)
            => Unsafe.As<ID3D12VideoProcessCommandList2, ID3D12CommandList>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12VideoProcessCommandList2 val)
            => Unsafe.As<ID3D12VideoProcessCommandList2, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12VideoProcessCommandList2 val)
            => Unsafe.As<ID3D12VideoProcessCommandList2, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoProcessCommandList2 val)
            => Unsafe.As<ID3D12VideoProcessCommandList2, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VideoProcessCommandList2
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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint*, T0*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, uint, T0*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, char*, int>)LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, char*, int>)LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetName(string Name)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly CommandListType GetType()
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                CommandListType ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, CommandListType>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int Close()
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, int>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Reset(ID3D12CommandAllocator* pAllocator)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocator);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int Reset(ref ID3D12CommandAllocator pAllocator)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocatorPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void ClearState()
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, void>)LpVtbl[11])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriers);
        }

        /// <summary>To be added.</summary>
        public readonly void ResourceBarrier(uint NumBarriers, ref ResourceBarrier pBarriers)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegion);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegionPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void DiscardResource(ref ID3D12Resource pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegion);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void DiscardResource(ref ID3D12Resource pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (DiscardRegion* pRegionPtr = &pRegion)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be added.</summary>
        public readonly void BeginQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be added.</summary>
        public readonly void EndQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
        }

        /// <summary>To be added.</summary>
        public readonly void SetPredication(ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void SetMarker(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pData, Size);
        }

        /// <summary>To be added.</summary>
        public readonly void SetMarker<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pDataPtr = &pData)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint, T0*, uint, void>)LpVtbl[18])(@this, Metadata, pDataPtr, Size);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void BeginEvent(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pData, Size);
        }

        /// <summary>To be added.</summary>
        public readonly void BeginEvent<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pDataPtr = &pData)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint, T0*, uint, void>)LpVtbl[19])(@this, Metadata, pDataPtr, Size);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void EndEvent()
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, void>)LpVtbl[20])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArguments);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArguments);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModes);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModesPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModes);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                fixed (WritebufferimmediateMode* pModesPtr = &pModes)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModesPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames1(ID3D12VideoProcessor* pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments1* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)LpVtbl[23])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArguments);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames1(ID3D12VideoProcessor* pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments1 pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)LpVtbl[23])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames1(ID3D12VideoProcessor* pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments1* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)LpVtbl[23])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames1(ID3D12VideoProcessor* pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments1 pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)LpVtbl[23])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames1(ref ID3D12VideoProcessor pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments1* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArguments);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames1(ref ID3D12VideoProcessor pVideoProcessor, VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments1 pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ProcessFrames1(ref ID3D12VideoProcessor pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, VideoProcessInputStreamArguments1* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly void ProcessFrames1(ref ID3D12VideoProcessor pVideoProcessor, ref VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, ref VideoProcessInputStreamArguments1 pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void SetProtectedResourceSession(ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12ProtectedResourceSession*, void>)LpVtbl[24])(@this, pProtectedResourceSession);
        }

        /// <summary>To be added.</summary>
        public readonly void SetProtectedResourceSession(ref ID3D12ProtectedResourceSession pProtectedResourceSession)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12ProtectedResourceSession*, void>)LpVtbl[24])(@this, pProtectedResourceSessionPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void InitializeExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, void* pInitializationParameters, uint InitializationParametersSizeInBytes)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoExtensionCommand*, void*, uint, void>)LpVtbl[25])(@this, pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void InitializeExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pInitializationParameters, uint InitializationParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pInitializationParametersPtr = &pInitializationParameters)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoExtensionCommand*, T0*, uint, void>)LpVtbl[25])(@this, pExtensionCommand, pInitializationParametersPtr, InitializationParametersSizeInBytes);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void InitializeExtensionCommand(ref ID3D12VideoExtensionCommand pExtensionCommand, void* pInitializationParameters, uint InitializationParametersSizeInBytes)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoExtensionCommand*, void*, uint, void>)LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParameters, InitializationParametersSizeInBytes);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void InitializeExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pInitializationParameters, uint InitializationParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                fixed (T0* pInitializationParametersPtr = &pInitializationParameters)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoExtensionCommand*, T0*, uint, void>)LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParametersPtr, InitializationParametersSizeInBytes);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ExecuteExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, void* pExecutionParameters, uint ExecutionParametersSizeInBytes)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoExtensionCommand*, void*, uint, void>)LpVtbl[26])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ExecuteExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pExecutionParameters, uint ExecutionParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (T0* pExecutionParametersPtr = &pExecutionParameters)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoExtensionCommand*, T0*, uint, void>)LpVtbl[26])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void ExecuteExtensionCommand(ref ID3D12VideoExtensionCommand pExtensionCommand, void* pExecutionParameters, uint ExecutionParametersSizeInBytes)
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoExtensionCommand*, void*, uint, void>)LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void ExecuteExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pExecutionParameters, uint ExecutionParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                fixed (T0* pExecutionParametersPtr = &pExecutionParameters)
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoProcessCommandList2*, ID3D12VideoExtensionCommand*, T0*, uint, void>)LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
                }
            }
        }

    }
}
