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

public unsafe static class DXGIAdapter4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIAdapter4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGIAdapter4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIAdapter4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateData(this ComPtr<IDXGIAdapter4> thisVtbl, Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPrivateDataInterface(this ComPtr<IDXGIAdapter4> thisVtbl, Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPrivateData(this ComPtr<IDXGIAdapter4> thisVtbl, Guid* Name, uint* pDataSize, void* pData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetParent(this ComPtr<IDXGIAdapter4> thisVtbl, Guid* riid, void** ppParent)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnumOutputs(this ComPtr<IDXGIAdapter4> thisVtbl, uint Output, IDXGIOutput** ppOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, IDXGIOutput**, int>)@this->LpVtbl[7])(@this, Output, ppOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc(this ComPtr<IDXGIAdapter4> thisVtbl, AdapterDesc* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc*, int>)@this->LpVtbl[8])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckInterfaceSupport(this ComPtr<IDXGIAdapter4> thisVtbl, Guid* InterfaceName, long* pUMDVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, Guid*, long*, int>)@this->LpVtbl[9])(@this, InterfaceName, pUMDVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc1(this ComPtr<IDXGIAdapter4> thisVtbl, AdapterDesc1* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc1*, int>)@this->LpVtbl[10])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc2(this ComPtr<IDXGIAdapter4> thisVtbl, AdapterDesc2* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc2*, int>)@this->LpVtbl[11])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterHardwareContentProtectionTeardownStatusEvent(this ComPtr<IDXGIAdapter4> thisVtbl, void* hEvent, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[12])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterHardwareContentProtectionTeardownStatus(this ComPtr<IDXGIAdapter4> thisVtbl, uint dwCookie)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, void>)@this->LpVtbl[13])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryVideoMemoryInfo(this ComPtr<IDXGIAdapter4> thisVtbl, uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, QueryVideoMemoryInfo* pVideoMemoryInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, int>)@this->LpVtbl[14])(@this, NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVideoMemoryReservation(this ComPtr<IDXGIAdapter4> thisVtbl, uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, ulong Reservation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, MemorySegmentGroup, ulong, int>)@this->LpVtbl[15])(@this, NodeIndex, MemorySegmentGroup, Reservation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent(this ComPtr<IDXGIAdapter4> thisVtbl, void* hEvent, uint* pdwCookie)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, void*, uint*, int>)@this->LpVtbl[16])(@this, hEvent, pdwCookie);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void UnregisterVideoMemoryBudgetChangeNotification(this ComPtr<IDXGIAdapter4> thisVtbl, uint dwCookie)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, uint, void>)@this->LpVtbl[17])(@this, dwCookie);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc3(this ComPtr<IDXGIAdapter4> thisVtbl, AdapterDesc3* pDesc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIAdapter4*, AdapterDesc3*, int>)@this->LpVtbl[18])(@this, pDesc);
        return ret;
    }

}
