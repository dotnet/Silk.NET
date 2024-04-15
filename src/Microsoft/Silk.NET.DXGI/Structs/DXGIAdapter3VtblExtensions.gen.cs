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

namespace Silk.NET.DXGI;

public unsafe static class DXGIAdapter3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGIAdapter3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIAdapter3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pDataSizePtr = &pDataSize)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid Name, ref uint pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* NamePtr = &Name)
        {
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppParentPtr = &ppParent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumOutputs(this ComPtr<IDXGIAdapter3> thisVtbl, uint Output, IDXGIOutput** ppOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, uint, IDXGIOutput**, int>)@this->LpVtbl[7])(@this, Output, ppOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumOutputs(this ComPtr<IDXGIAdapter3> thisVtbl, uint Output, ref IDXGIOutput* ppOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, uint, IDXGIOutput**, int>)@this->LpVtbl[7])(@this, Output, ppOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<IDXGIAdapter3> thisVtbl, AdapterDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, AdapterDesc*, int>)@this->LpVtbl[8])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<IDXGIAdapter3> thisVtbl, ref AdapterDesc pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (AdapterDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, AdapterDesc*, int>)@this->LpVtbl[8])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* InterfaceName, long* pUMDVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceName, pUMDVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* InterfaceName, ref long pUMDVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (long* pUMDVersionPtr = &pUMDVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceName, pUMDVersionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid InterfaceName, long* pUMDVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* InterfaceNamePtr = &InterfaceName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceNamePtr, pUMDVersion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckInterfaceSupport(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid InterfaceName, ref long pUMDVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* InterfaceNamePtr = &InterfaceName)
        {
            fixed (long* pUMDVersionPtr = &pUMDVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceNamePtr, pUMDVersionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc1(this ComPtr<IDXGIAdapter3> thisVtbl, AdapterDesc1* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, AdapterDesc1*, int>)@this->LpVtbl[10])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1(this ComPtr<IDXGIAdapter3> thisVtbl, ref AdapterDesc1 pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (AdapterDesc1* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, AdapterDesc1*, int>)@this->LpVtbl[10])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc2(this ComPtr<IDXGIAdapter3> thisVtbl, AdapterDesc2* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, AdapterDesc2*, int>)@this->LpVtbl[11])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc2(this ComPtr<IDXGIAdapter3> thisVtbl, ref AdapterDesc2 pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (AdapterDesc2* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, AdapterDesc2*, int>)@this->LpVtbl[11])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent(this ComPtr<IDXGIAdapter3> thisVtbl, void* hEvent, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, void*, uint*, int>)@this->LpVtbl[12])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent(this ComPtr<IDXGIAdapter3> thisVtbl, void* hEvent, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, void*, uint*, int>)@this->LpVtbl[12])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, void*, uint*, int>)@this->LpVtbl[12])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterHardwareContentProtectionTeardownStatusEvent<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, void*, uint*, int>)@this->LpVtbl[12])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterHardwareContentProtectionTeardownStatus(this ComPtr<IDXGIAdapter3> thisVtbl, uint dwCookie)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, uint, void>)@this->LpVtbl[13])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryVideoMemoryInfo(this ComPtr<IDXGIAdapter3> thisVtbl, uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, QueryVideoMemoryInfo* pVideoMemoryInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, int>)@this->LpVtbl[14])(@this, NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryVideoMemoryInfo(this ComPtr<IDXGIAdapter3> thisVtbl, uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, ref QueryVideoMemoryInfo pVideoMemoryInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (QueryVideoMemoryInfo* pVideoMemoryInfoPtr = &pVideoMemoryInfo)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, int>)@this->LpVtbl[14])(@this, NodeIndex, MemorySegmentGroup, pVideoMemoryInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoMemoryReservation(this ComPtr<IDXGIAdapter3> thisVtbl, uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, ulong Reservation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, uint, MemorySegmentGroup, ulong, int>)@this->LpVtbl[15])(@this, NodeIndex, MemorySegmentGroup, Reservation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent(this ComPtr<IDXGIAdapter3> thisVtbl, void* hEvent, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, void*, uint*, int>)@this->LpVtbl[16])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent(this ComPtr<IDXGIAdapter3> thisVtbl, void* hEvent, ref uint pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwCookiePtr = &pdwCookie)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, void*, uint*, int>)@this->LpVtbl[16])(@this, hEvent, pdwCookiePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, void*, uint*, int>)@this->LpVtbl[16])(@this, hEventPtr, pdwCookie);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterVideoMemoryBudgetChangeNotificationEvent<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* hEventPtr = &hEvent)
        {
            fixed (uint* pdwCookiePtr = &pdwCookie)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, void*, uint*, int>)@this->LpVtbl[16])(@this, hEventPtr, pdwCookiePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterVideoMemoryBudgetChangeNotification(this ComPtr<IDXGIAdapter3> thisVtbl, uint dwCookie)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIAdapter3*, uint, void>)@this->LpVtbl[17])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDXGIAdapter3> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(Name, DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateData(ref Name.GetPinnableReference(), DataSize, in pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface<TI0>(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(Name, in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), pUnknown);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface<TI0>(this ComPtr<IDXGIAdapter3> thisVtbl, ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPrivateDataInterface(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Native.IUnknown> pUnknown)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPrivateDataInterface(ref Name.GetPinnableReference(), in pUnknown.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(Name, ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, pData);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> Name, uint* pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), pDataSize, ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), pData);
    }

    /// <summary>To be documented.</summary>
    public static int GetPrivateData<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> Name, Span<uint> pDataSize, Span<T0> pData) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPrivateData(ref Name.GetPinnableReference(), ref pDataSize.GetPinnableReference(), ref pData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetParent<TI0>(this ComPtr<IDXGIAdapter3> thisVtbl, out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppParent = default;
        return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ppParent);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> riid, ref void* ppParent)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetParent(ref riid.GetPinnableReference(), ref ppParent);
    }

    /// <summary>To be documented.</summary>
    public static int EnumOutputs<TI0>(this ComPtr<IDXGIAdapter3> thisVtbl, uint Output, ref ComPtr<TI0> ppOutput) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EnumOutputs(Output, (IDXGIOutput**) ppOutput.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc(this ComPtr<IDXGIAdapter3> thisVtbl, Span<AdapterDesc> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport(this ComPtr<IDXGIAdapter3> thisVtbl, Guid* InterfaceName, Span<long> pUMDVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckInterfaceSupport(InterfaceName, ref pUMDVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> InterfaceName, long* pUMDVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckInterfaceSupport(ref InterfaceName.GetPinnableReference(), pUMDVersion);
    }

    /// <summary>To be documented.</summary>
    public static int CheckInterfaceSupport(this ComPtr<IDXGIAdapter3> thisVtbl, Span<Guid> InterfaceName, Span<long> pUMDVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckInterfaceSupport(ref InterfaceName.GetPinnableReference(), ref pUMDVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc1(this ComPtr<IDXGIAdapter3> thisVtbl, Span<AdapterDesc1> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc1(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc2(this ComPtr<IDXGIAdapter3> thisVtbl, Span<AdapterDesc2> pDesc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesc2(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent(this ComPtr<IDXGIAdapter3> thisVtbl, void* hEvent, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterHardwareContentProtectionTeardownStatusEvent(hEvent, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Span<T0> hEvent, uint* pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterHardwareContentProtectionTeardownStatusEvent(ref hEvent.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterHardwareContentProtectionTeardownStatusEvent<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Span<T0> hEvent, Span<uint> pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterHardwareContentProtectionTeardownStatusEvent(ref hEvent.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int QueryVideoMemoryInfo(this ComPtr<IDXGIAdapter3> thisVtbl, uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, Span<QueryVideoMemoryInfo> pVideoMemoryInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryVideoMemoryInfo(NodeIndex, MemorySegmentGroup, ref pVideoMemoryInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent(this ComPtr<IDXGIAdapter3> thisVtbl, void* hEvent, Span<uint> pdwCookie)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterVideoMemoryBudgetChangeNotificationEvent(hEvent, ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Span<T0> hEvent, uint* pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterVideoMemoryBudgetChangeNotificationEvent(ref hEvent.GetPinnableReference(), pdwCookie);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterVideoMemoryBudgetChangeNotificationEvent<T0>(this ComPtr<IDXGIAdapter3> thisVtbl, Span<T0> hEvent, Span<uint> pdwCookie) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterVideoMemoryBudgetChangeNotificationEvent(ref hEvent.GetPinnableReference(), ref pdwCookie.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDXGIAdapter3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetParent<TI0>(this ComPtr<IDXGIAdapter3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
