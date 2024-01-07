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

public unsafe static class D3D12VideoProcessCommandList1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid guid, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CommandListType GetType(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CommandListType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, CommandListType>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12CommandAllocator* pAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12CommandAllocator pAllocator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearState(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, void>)@this->LpVtbl[11])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResourceBarrier(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint NumBarriers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceBarrier* pBarriers)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriers);
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint NumBarriers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceBarrier pBarriers)
    {
        var @this = thisVtbl.Handle;
        fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DiscardRegion pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (DiscardRegion* pRegionPtr = &pRegion)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegion);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DiscardRegion pRegion)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginQuery(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EndQuery(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPredication(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEvent(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint Size)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static void EndEvent(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, void>)@this->LpVtbl[20])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
        {
            fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoProcessInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateParameter* pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParams, pModes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateParameter* pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WritebufferimmediateMode pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateMode* pModesPtr = &pModes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParams, pModesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WritebufferimmediateParameter pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParamsPtr, pModes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WritebufferimmediateParameter pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in WritebufferimmediateMode pModes)
    {
        var @this = thisVtbl.Handle;
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParamsPtr, pModesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
        {
            fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessor, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArguments, NumInputStreams, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArguments);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12VideoProcessor pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments)
    {
        var @this = thisVtbl.Handle;
        fixed (ID3D12VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
        {
            fixed (VideoProcessOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoProcessInputStreamArguments1* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoProcessCommandList1*, ID3D12VideoProcessor*, VideoProcessOutputStreamArguments*, uint, VideoProcessInputStreamArguments1*, void>)@this->LpVtbl[23])(@this, pVideoProcessorPtr, pOutputArgumentsPtr, NumInputStreams, pInputArgumentsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetName(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> riid, void** ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<Guid> riid, ref void* ppvDevice)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static int Reset<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pAllocator) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reset((ID3D12CommandAllocator*) pAllocator.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12CommandAllocator> pAllocator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reset(ref pAllocator.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint NumBarriers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ResourceBarrier> pBarriers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResourceBarrier(NumBarriers, in pBarriers.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DiscardResource((ID3D12Resource*) pResource.Handle, pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DiscardRegion> pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(pResource, in pRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DiscardRegion pRegion) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->DiscardResource((ID3D12Resource*) pResource.Handle, in pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DiscardRegion* pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference(), pRegion);
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12Resource> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DiscardRegion> pRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference(), in pRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint Index) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->BeginQuery((ID3D12QueryHeap*) pQueryHeap.Handle, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginQuery(ref pQueryHeap.GetPinnableReference(), Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint Index) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->EndQuery((ID3D12QueryHeap*) pQueryHeap.Handle, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint Index)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->EndQuery(ref pQueryHeap.GetPinnableReference(), Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TI0, TI1>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ComPtr<TI1> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveQueryData((ID3D12QueryHeap*) pQueryHeap.Handle, Type, StartIndex, NumQueries, (ID3D12Resource*) pDestinationBuffer.Handle, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, Span<ID3D12Resource> pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(pQueryHeap, Type, StartIndex, NumQueries, ref pDestinationBuffer.GetPinnableReference(), AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12QueryHeap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveQueryData((ID3D12QueryHeap*) pQueryHeap.Handle, Type, StartIndex, NumQueries, ref pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(ref pQueryHeap.GetPinnableReference(), Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ComPtr<TI0> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ResolveQueryData(ref pQueryHeap, Type, StartIndex, NumQueries, (ID3D12Resource*) pDestinationBuffer.Handle, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, Span<ID3D12Resource> pDestinationBuffer, ulong AlignedDestinationBufferOffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ResolveQueryData(ref pQueryHeap.GetPinnableReference(), Type, StartIndex, NumQueries, ref pDestinationBuffer.GetPinnableReference(), AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pBuffer, ulong AlignedBufferOffset, PredicationOp Operation) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetPredication((ID3D12Resource*) pBuffer.Handle, AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12Resource> pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetPredication(ref pBuffer.GetPinnableReference(), AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetMarker(Metadata, in pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Metadata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData, uint Size) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->BeginEvent(Metadata, in pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ProcessFrames((ID3D12VideoProcessor*) pVideoProcessor.Handle, pOutputArguments, NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames(pVideoProcessor, pOutputArguments, NumInputStreams, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ProcessFrames((ID3D12VideoProcessor*) pVideoProcessor.Handle, pOutputArguments, NumInputStreams, in pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamArguments> pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames(pVideoProcessor, in pOutputArguments.GetPinnableReference(), NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ProcessFrames((ID3D12VideoProcessor*) pVideoProcessor.Handle, in pOutputArguments, NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamArguments> pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames(pVideoProcessor, in pOutputArguments.GetPinnableReference(), NumInputStreams, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ProcessFrames<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ProcessFrames((ID3D12VideoProcessor*) pVideoProcessor.Handle, in pOutputArguments, NumInputStreams, in pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12VideoProcessor> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames(ref pVideoProcessor.GetPinnableReference(), pOutputArguments, NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12VideoProcessor> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames(ref pVideoProcessor.GetPinnableReference(), pOutputArguments, NumInputStreams, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12VideoProcessor> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamArguments> pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames(ref pVideoProcessor.GetPinnableReference(), in pOutputArguments.GetPinnableReference(), NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static void ProcessFrames(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12VideoProcessor> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamArguments> pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamArguments> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames(ref pVideoProcessor.GetPinnableReference(), in pOutputArguments.GetPinnableReference(), NumInputStreams, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateParameter* pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WritebufferimmediateMode> pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, pParams, in pModes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WritebufferimmediateParameter> pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] WritebufferimmediateMode* pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, in pParams.GetPinnableReference(), pModes);
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WritebufferimmediateParameter> pParams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WritebufferimmediateMode> pModes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->WriteBufferImmediate(Count, in pParams.GetPinnableReference(), in pModes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ProcessFrames1((ID3D12VideoProcessor*) pVideoProcessor.Handle, pOutputArguments, NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamArguments1> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames1(pVideoProcessor, pOutputArguments, NumInputStreams, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ProcessFrames1((ID3D12VideoProcessor*) pVideoProcessor.Handle, pOutputArguments, NumInputStreams, in pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamArguments> pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames1(pVideoProcessor, in pOutputArguments.GetPinnableReference(), NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ProcessFrames1((ID3D12VideoProcessor*) pVideoProcessor.Handle, in pOutputArguments, NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ID3D12VideoProcessor* pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamArguments> pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamArguments1> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames1(pVideoProcessor, in pOutputArguments.GetPinnableReference(), NumInputStreams, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ProcessFrames1<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, ComPtr<TI0> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessOutputStreamArguments pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VideoProcessInputStreamArguments1 pInputArguments) where TI0 : unmanaged, IComVtbl<ID3D12VideoProcessor>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->ProcessFrames1((ID3D12VideoProcessor*) pVideoProcessor.Handle, in pOutputArguments, NumInputStreams, in pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12VideoProcessor> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames1(ref pVideoProcessor.GetPinnableReference(), pOutputArguments, NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12VideoProcessor> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessOutputStreamArguments* pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamArguments1> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames1(ref pVideoProcessor.GetPinnableReference(), pOutputArguments, NumInputStreams, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12VideoProcessor> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamArguments> pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VideoProcessInputStreamArguments1* pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames1(ref pVideoProcessor.GetPinnableReference(), in pOutputArguments.GetPinnableReference(), NumInputStreams, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static void ProcessFrames1(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl, Span<ID3D12VideoProcessor> pVideoProcessor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessOutputStreamArguments> pOutputArguments, uint NumInputStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VideoProcessInputStreamArguments1> pInputArguments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ProcessFrames1(ref pVideoProcessor.GetPinnableReference(), in pOutputArguments.GetPinnableReference(), NumInputStreams, in pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0>(this ComPtr<ID3D12VideoProcessCommandList1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
