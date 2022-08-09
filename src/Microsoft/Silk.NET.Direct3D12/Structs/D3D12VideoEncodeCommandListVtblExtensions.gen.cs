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

public unsafe static class D3D12VideoEncodeCommandListVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, void* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* guidPtr = &guid)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetName<TThis>(this TThis thisVtbl, char* Name) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, char*, int>)@this->LpVtbl[6])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, ref char Name) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, void** ppvDevice) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvDevicePtr = &ppvDevice)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvDevice) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CommandListType GetType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        CommandListType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, CommandListType>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Close<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, int>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset<TThis>(this TThis thisVtbl, ID3D12CommandAllocator* pAllocator) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset<TThis>(this TThis thisVtbl, ref ID3D12CommandAllocator pAllocator) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearState<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, void>)@this->LpVtbl[11])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResourceBarrier<TThis>(this TThis thisVtbl, uint NumBarriers, ResourceBarrier* pBarriers) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriers);
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier<TThis>(this TThis thisVtbl, uint NumBarriers, ref ResourceBarrier pBarriers) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, DiscardRegion* pRegion) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, ref DiscardRegion pRegion) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (DiscardRegion* pRegionPtr = &pRegion)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, DiscardRegion* pRegion) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegion);
        }
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource<TThis>(this TThis thisVtbl, ref ID3D12Resource pResource, ref DiscardRegion pRegion) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pResourcePtr = &pResource)
        {
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginQuery<TThis>(this TThis thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery<TThis>(this TThis thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EndQuery<TThis>(this TThis thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeap, Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery<TThis>(this TThis thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData<TThis>(this TThis thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData<TThis>(this TThis thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData<TThis>(this TThis thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TThis>(this TThis thisVtbl, ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
        {
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetPredication<TThis>(this TThis thisVtbl, ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication<TThis>(this TThis thisVtbl, ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker<TThis>(this TThis thisVtbl, uint Metadata, void* pData, uint Size) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0, TThis>(this TThis thisVtbl, uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void BeginEvent<TThis>(this TThis thisVtbl, uint Metadata, void* pData, uint Size) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pData, Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0, TThis>(this TThis thisVtbl, uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (void* pDataPtr = &pData)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pDataPtr, Size);
        }
    }

    /// <summary>To be documented.</summary>
    public static void EndEvent<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, void>)@this->LpVtbl[20])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, VideoMotionEstimatorInput* pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimator, pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, ref VideoMotionEstimatorInput pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimator, pOutputArguments, pInputArgumentsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, ref VideoMotionEstimatorOutput pOutputArguments, VideoMotionEstimatorInput* pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimator, pOutputArgumentsPtr, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, ref VideoMotionEstimatorOutput pOutputArguments, ref VideoMotionEstimatorInput pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
        {
            fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimator, pOutputArgumentsPtr, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, ref ID3D12VideoMotionEstimator pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, VideoMotionEstimatorInput* pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArguments, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, ref ID3D12VideoMotionEstimator pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, ref VideoMotionEstimatorInput pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
        {
            fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArguments, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, ref ID3D12VideoMotionEstimator pMotionEstimator, ref VideoMotionEstimatorOutput pOutputArguments, VideoMotionEstimatorInput* pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
        {
            fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArgumentsPtr, pInputArguments);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static void EstimateMotion<TThis>(this TThis thisVtbl, ref ID3D12VideoMotionEstimator pMotionEstimator, ref VideoMotionEstimatorOutput pOutputArguments, ref VideoMotionEstimatorInput pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12VideoMotionEstimator* pMotionEstimatorPtr = &pMotionEstimator)
        {
            fixed (VideoMotionEstimatorOutput* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoMotionEstimatorInput* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12VideoMotionEstimator*, VideoMotionEstimatorOutput*, VideoMotionEstimatorInput*, void>)@this->LpVtbl[21])(@this, pMotionEstimatorPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                }
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveMotionVectorHeap<TThis>(this TThis thisVtbl, ResolveVideoMotionVectorHeapOutput* pOutputArguments, ResolveVideoMotionVectorHeapInput* pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)@this->LpVtbl[22])(@this, pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveMotionVectorHeap<TThis>(this TThis thisVtbl, ResolveVideoMotionVectorHeapOutput* pOutputArguments, ref ResolveVideoMotionVectorHeapInput pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ResolveVideoMotionVectorHeapInput* pInputArgumentsPtr = &pInputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)@this->LpVtbl[22])(@this, pOutputArguments, pInputArgumentsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveMotionVectorHeap<TThis>(this TThis thisVtbl, ref ResolveVideoMotionVectorHeapOutput pOutputArguments, ResolveVideoMotionVectorHeapInput* pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ResolveVideoMotionVectorHeapOutput* pOutputArgumentsPtr = &pOutputArguments)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)@this->LpVtbl[22])(@this, pOutputArgumentsPtr, pInputArguments);
        }
    }

    /// <summary>To be documented.</summary>
    public static void ResolveMotionVectorHeap<TThis>(this TThis thisVtbl, ref ResolveVideoMotionVectorHeapOutput pOutputArguments, ref ResolveVideoMotionVectorHeapInput pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ResolveVideoMotionVectorHeapOutput* pOutputArgumentsPtr = &pOutputArguments)
        {
            fixed (ResolveVideoMotionVectorHeapInput* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ResolveVideoMotionVectorHeapOutput*, ResolveVideoMotionVectorHeapInput*, void>)@this->LpVtbl[22])(@this, pOutputArgumentsPtr, pInputArgumentsPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[23])(@this, Count, pParams, pModes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (WritebufferimmediateMode* pModesPtr = &pModes)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[23])(@this, Count, pParams, pModesPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[23])(@this, Count, pParamsPtr, pModes);
        }
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
        {
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[23])(@this, Count, pParamsPtr, pModesPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetProtectedResourceSession<TThis>(this TThis thisVtbl, ID3D12ProtectedResourceSession* pProtectedResourceSession) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[24])(@this, pProtectedResourceSession);
    }

    /// <summary>To be documented.</summary>
    public static void SetProtectedResourceSession<TThis>(this TThis thisVtbl, ref ID3D12ProtectedResourceSession pProtectedResourceSession) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
        {
            ((delegate* unmanaged[Stdcall]<ID3D12VideoEncodeCommandList*, ID3D12ProtectedResourceSession*, void>)@this->LpVtbl[24])(@this, pProtectedResourceSessionPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(guid, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, void* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint* pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, void* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPrivateData(ref guid.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0, TThis>(this TThis thisVtbl, Guid* guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(guid, DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, void* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0, TThis>(this TThis thisVtbl, Span<Guid> guid, uint DataSize, Span<T0> pData) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateData(ref guid.GetPinnableReference(), DataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Guid* guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(guid, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TThis>(this TThis thisVtbl, Span<Guid> guid, [Flow(FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pData) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref guid.GetPinnableReference(), in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetName<TThis>(this TThis thisVtbl, Span<char> Name) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvDevice = default;
        return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvDevice) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvDevice) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDevice(ref riid.GetPinnableReference(), ref ppvDevice);
    }

    /// <summary>To be documented.</summary>
    public static int Reset<TThis>(this TThis thisVtbl, Span<ID3D12CommandAllocator> pAllocator) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Reset(ref pAllocator.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ResourceBarrier<TThis>(this TThis thisVtbl, uint NumBarriers, Span<ResourceBarrier> pBarriers) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ResourceBarrier(NumBarriers, ref pBarriers.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TThis>(this TThis thisVtbl, ID3D12Resource* pResource, Span<DiscardRegion> pRegion) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DiscardResource(pResource, ref pRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DiscardResource<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, DiscardRegion* pRegion) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference(), pRegion);
    }

    /// <summary>To be documented.</summary>
    public static void DiscardResource<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pResource, Span<DiscardRegion> pRegion) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->DiscardResource(ref pResource.GetPinnableReference(), ref pRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void BeginQuery<TThis>(this TThis thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint Index) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->BeginQuery(ref pQueryHeap.GetPinnableReference(), Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static void EndQuery<TThis>(this TThis thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint Index) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EndQuery(ref pQueryHeap.GetPinnableReference(), Type, Index);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData<TThis>(this TThis thisVtbl, ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, Span<ID3D12Resource> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ResolveQueryData(pQueryHeap, Type, StartIndex, NumQueries, ref pDestinationBuffer.GetPinnableReference(), AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveQueryData<TThis>(this TThis thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ResolveQueryData(ref pQueryHeap.GetPinnableReference(), Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveQueryData<TThis>(this TThis thisVtbl, Span<ID3D12QueryHeap> pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, Span<ID3D12Resource> pDestinationBuffer, ulong AlignedDestinationBufferOffset) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ResolveQueryData(ref pQueryHeap.GetPinnableReference(), Type, StartIndex, NumQueries, ref pDestinationBuffer.GetPinnableReference(), AlignedDestinationBufferOffset);
    }

    /// <summary>To be documented.</summary>
    public static void SetPredication<TThis>(this TThis thisVtbl, Span<ID3D12Resource> pBuffer, ulong AlignedBufferOffset, PredicationOp Operation) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SetPredication(ref pBuffer.GetPinnableReference(), AlignedBufferOffset, Operation);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<T0, TThis>(this TThis thisVtbl, uint Metadata, Span<T0> pData, uint Size) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SetMarker(Metadata, ref pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static void BeginEvent<T0, TThis>(this TThis thisVtbl, uint Metadata, Span<T0> pData, uint Size) where T0 : unmanaged where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->BeginEvent(Metadata, ref pData.GetPinnableReference(), Size);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, Span<VideoMotionEstimatorInput> pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EstimateMotion(pMotionEstimator, pOutputArguments, ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, Span<VideoMotionEstimatorOutput> pOutputArguments, VideoMotionEstimatorInput* pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EstimateMotion(pMotionEstimator, ref pOutputArguments.GetPinnableReference(), pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, ID3D12VideoMotionEstimator* pMotionEstimator, Span<VideoMotionEstimatorOutput> pOutputArguments, Span<VideoMotionEstimatorInput> pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EstimateMotion(pMotionEstimator, ref pOutputArguments.GetPinnableReference(), ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, Span<ID3D12VideoMotionEstimator> pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, VideoMotionEstimatorInput* pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EstimateMotion(ref pMotionEstimator.GetPinnableReference(), pOutputArguments, pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, Span<ID3D12VideoMotionEstimator> pMotionEstimator, VideoMotionEstimatorOutput* pOutputArguments, Span<VideoMotionEstimatorInput> pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EstimateMotion(ref pMotionEstimator.GetPinnableReference(), pOutputArguments, ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void EstimateMotion<TThis>(this TThis thisVtbl, Span<ID3D12VideoMotionEstimator> pMotionEstimator, Span<VideoMotionEstimatorOutput> pOutputArguments, VideoMotionEstimatorInput* pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EstimateMotion(ref pMotionEstimator.GetPinnableReference(), ref pOutputArguments.GetPinnableReference(), pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static void EstimateMotion<TThis>(this TThis thisVtbl, Span<ID3D12VideoMotionEstimator> pMotionEstimator, Span<VideoMotionEstimatorOutput> pOutputArguments, Span<VideoMotionEstimatorInput> pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->EstimateMotion(ref pMotionEstimator.GetPinnableReference(), ref pOutputArguments.GetPinnableReference(), ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveMotionVectorHeap<TThis>(this TThis thisVtbl, ResolveVideoMotionVectorHeapOutput* pOutputArguments, Span<ResolveVideoMotionVectorHeapInput> pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ResolveMotionVectorHeap(pOutputArguments, ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ResolveMotionVectorHeap<TThis>(this TThis thisVtbl, Span<ResolveVideoMotionVectorHeapOutput> pOutputArguments, ResolveVideoMotionVectorHeapInput* pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ResolveMotionVectorHeap(ref pOutputArguments.GetPinnableReference(), pInputArguments);
    }

    /// <summary>To be documented.</summary>
    public static void ResolveMotionVectorHeap<TThis>(this TThis thisVtbl, Span<ResolveVideoMotionVectorHeapOutput> pOutputArguments, Span<ResolveVideoMotionVectorHeapInput> pInputArguments) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->ResolveMotionVectorHeap(ref pOutputArguments.GetPinnableReference(), ref pInputArguments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, WritebufferimmediateParameter* pParams, Span<WritebufferimmediateMode> pModes) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->WriteBufferImmediate(Count, pParams, ref pModes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, Span<WritebufferimmediateParameter> pParams, WritebufferimmediateMode* pModes) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->WriteBufferImmediate(Count, ref pParams.GetPinnableReference(), pModes);
    }

    /// <summary>To be documented.</summary>
    public static void WriteBufferImmediate<TThis>(this TThis thisVtbl, uint Count, Span<WritebufferimmediateParameter> pParams, Span<WritebufferimmediateMode> pModes) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->WriteBufferImmediate(Count, ref pParams.GetPinnableReference(), ref pModes.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetProtectedResourceSession<TThis>(this TThis thisVtbl, Span<ID3D12ProtectedResourceSession> pProtectedResourceSession) where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SetProtectedResourceSession(ref pProtectedResourceSession.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetDevice<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12VideoEncodeCommandList>
    {
        var @this = (ID3D12VideoEncodeCommandList*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
