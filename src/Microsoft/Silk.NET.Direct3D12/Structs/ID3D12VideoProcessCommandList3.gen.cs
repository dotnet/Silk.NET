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
    [Guid("1a0a4ca4-9f08-40ce-9558-b411fd2666ff")]
    [NativeName("Name", "ID3D12VideoProcessCommandList3")]
    public unsafe partial struct ID3D12VideoProcessCommandList3 : IComVtbl<ID3D12VideoProcessCommandList3>, IComVtbl<ID3D12VideoProcessCommandList2>, IComVtbl<ID3D12VideoProcessCommandList1>, IComVtbl<ID3D12VideoProcessCommandList>, IComVtbl<ID3D12CommandList>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1a0a4ca4-9f08-40ce-9558-b411fd2666ff");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12VideoProcessCommandList2(ID3D12VideoProcessCommandList3 val)
            => Unsafe.As<ID3D12VideoProcessCommandList3, ID3D12VideoProcessCommandList2>(ref val);

        public static implicit operator ID3D12VideoProcessCommandList1(ID3D12VideoProcessCommandList3 val)
            => Unsafe.As<ID3D12VideoProcessCommandList3, ID3D12VideoProcessCommandList1>(ref val);

        public static implicit operator ID3D12VideoProcessCommandList(ID3D12VideoProcessCommandList3 val)
            => Unsafe.As<ID3D12VideoProcessCommandList3, ID3D12VideoProcessCommandList>(ref val);

        public static implicit operator ID3D12CommandList(ID3D12VideoProcessCommandList3 val)
            => Unsafe.As<ID3D12VideoProcessCommandList3, ID3D12CommandList>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12VideoProcessCommandList3 val)
            => Unsafe.As<ID3D12VideoProcessCommandList3, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12VideoProcessCommandList3 val)
            => Unsafe.As<ID3D12VideoProcessCommandList3, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoProcessCommandList3 val)
            => Unsafe.As<ID3D12VideoProcessCommandList3, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VideoProcessCommandList3
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
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CommandListType GetType()
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CommandListType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, CommandListType>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, int>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ID3D12CommandAllocator* pAllocator)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset(ref ID3D12CommandAllocator pAllocator)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearState()
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, void>)@this->LpVtbl[11])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResourceBarrier(uint NumBarriers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceBarrier* pBarriers)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriers);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResourceBarrier(uint NumBarriers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceBarrier pBarriers)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegion);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DiscardRegion pRegion)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegion);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource(ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DiscardRegion pRegion)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (DiscardRegion* pRegionPtr = &pRegion)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication(ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarker(uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMarker<T0>(uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pDataPtr, Size);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginEvent(uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginEvent<T0>(uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pDataPtr, Size);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EndEvent()
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, void>)@this->LpVtbl[20])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames(ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ProcessFrames(ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateParameter* pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParams, pModes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateParameter* pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParams, pModesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WritebufferimmediateParameter pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParamsPtr, pModes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void WriteBufferImmediate(uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WritebufferimmediateParameter pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                fixed (WritebufferimmediateMode* pModesPtr = &pModes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParamsPtr, pModesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames1(ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames1(ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames1(ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames1(ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames1(ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames1(ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames1(ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ProcessFrames1(ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetProtectedResourceSession(ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[24])(@this, pProtectedResourceSession);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetProtectedResourceSession(ref ID3D12ProtectedResourceSession pProtectedResourceSession)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[24])(@this, pProtectedResourceSessionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pInitializationParametersPtr = &pInitializationParameters)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommand, pInitializationParametersPtr, InitializationParametersSizeInBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeExtensionCommand(ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParameters, InitializationParametersSizeInBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void InitializeExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                fixed (void* pInitializationParametersPtr = &pInitializationParameters)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParametersPtr, InitializationParametersSizeInBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pExecutionParametersPtr = &pExecutionParameters)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteExtensionCommand(ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                fixed (void* pExecutionParametersPtr = &pExecutionParameters)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, ID3D12VideoExtensionCommand*, void*, nuint, void>)@this->LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Barrier(uint NumBarrierGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BarrierGroup* pBarrierGroups)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, BarrierGroup*, void>)@this->LpVtbl[27])(@this, NumBarrierGroups, pBarrierGroups);
        }

        /// <summary>To be documented.</summary>
        public readonly void Barrier(uint NumBarrierGroups, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BarrierGroup pBarrierGroups)
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (BarrierGroup* pBarrierGroupsPtr = &pBarrierGroups)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList3*, uint, BarrierGroup*, void>)@this->LpVtbl[27])(@this, NumBarrierGroups, pBarrierGroupsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDevice = default;
            return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset<TI0>(ComPtr<TI0> pAllocator) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reset((ID3D12CommandAllocator*) pAllocator.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource<TI0>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DiscardResource((ID3D12Resource*) pResource.Handle, pRegion);
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource<TI0>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DiscardRegion pRegion) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DiscardResource((ID3D12Resource*) pResource.Handle, in pRegion);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginQuery<TI0>(ComPtr<TI0> pQueryHeap, QueryType Type, uint Index) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->BeginQuery((ID3D12QueryHeap*) pQueryHeap.Handle, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndQuery<TI0>(ComPtr<TI0> pQueryHeap, QueryType Type, uint Index) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->EndQuery((ID3D12QueryHeap*) pQueryHeap.Handle, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData<TI0, TI1>(ComPtr<TI0> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ComPtr<TI1> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveQueryData((ID3D12QueryHeap*) pQueryHeap.Handle, Type, StartIndex, NumQueries, (ID3D12Resource*) pDestinationBuffer.Handle, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData<TI0>(ComPtr<TI0> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveQueryData((ID3D12QueryHeap*) pQueryHeap.Handle, Type, StartIndex, NumQueries, ref pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData<TI0>(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ComPtr<TI0> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ResolveQueryData(ref pQueryHeap, Type, StartIndex, NumQueries, (ID3D12Resource*) pDestinationBuffer.Handle, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication<TI0>(ComPtr<TI0> pBuffer, ulong AlignedBufferOffset, PredicationOp Operation) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetPredication((ID3D12Resource*) pBuffer.Handle, AlignedBufferOffset, Operation);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ProcessFrames((ID3D12VideoProcessor*) pVideoProcessor.Handle, pOutputArguments, NumInputStreams, pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ProcessFrames((ID3D12VideoProcessor*) pVideoProcessor.Handle, pOutputArguments, NumInputStreams, in pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ProcessFrames((ID3D12VideoProcessor*) pVideoProcessor.Handle, in pOutputArguments, NumInputStreams, pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly void ProcessFrames<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ProcessFrames((ID3D12VideoProcessor*) pVideoProcessor.Handle, in pOutputArguments, NumInputStreams, in pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames1<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ProcessFrames1((ID3D12VideoProcessor*) pVideoProcessor.Handle, pOutputArguments, NumInputStreams, pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames1<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ProcessFrames1((ID3D12VideoProcessor*) pVideoProcessor.Handle, pOutputArguments, NumInputStreams, in pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ProcessFrames1<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ProcessFrames1((ID3D12VideoProcessor*) pVideoProcessor.Handle, in pOutputArguments, NumInputStreams, pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly void ProcessFrames1<TI0>(ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ProcessFrames1((ID3D12VideoProcessor*) pVideoProcessor.Handle, in pOutputArguments, NumInputStreams, in pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetProtectedResourceSession<TI0>(ComPtr<TI0> pProtectedResourceSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->SetProtectedResourceSession((ID3D12ProtectedResourceSession*) pProtectedResourceSession.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeExtensionCommand<TI0>(ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pInitializationParameters, nuint InitializationParametersSizeInBytes) where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->InitializeExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, pInitializationParameters, InitializationParametersSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly void InitializeExtensionCommand<T0, TI0>(ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->InitializeExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, in pInitializationParameters, InitializationParametersSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteExtensionCommand<TI0>(ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pExecutionParameters, nuint ExecutionParametersSizeInBytes) where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, pExecutionParameters, ExecutionParametersSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteExtensionCommand<T0, TI0>(ComPtr<TI0> pExtensionCommand, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12VideoExtensionCommand>, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ExecuteExtensionCommand((ID3D12VideoExtensionCommand*) pExtensionCommand.Handle, in pExecutionParameters, ExecutionParametersSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetDevice<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoProcessCommandList3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
