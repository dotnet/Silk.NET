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

public unsafe static class D3D12DeviceRemovedExtendedData2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAutoBreadcrumbsOutput(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, DredAutoBreadcrumbsOutput* pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredAutoBreadcrumbsOutput*, int>)@this->LpVtbl[3])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPageFaultAllocationOutput(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, DredPageFaultOutput* pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput*, int>)@this->LpVtbl[4])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAutoBreadcrumbsOutput1(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, DredAutoBreadcrumbsOutput1* pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredAutoBreadcrumbsOutput1*, int>)@this->LpVtbl[5])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPageFaultAllocationOutput1(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, DredPageFaultOutput1* pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput1*, int>)@this->LpVtbl[6])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPageFaultAllocationOutput2(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, DredPageFaultOutput2* pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput2*, int>)@this->LpVtbl[7])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static DredDeviceState GetDeviceState(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        DredDeviceState ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredDeviceState>)@this->LpVtbl[8])(@this);
        return ret;
    }

}
