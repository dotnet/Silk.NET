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
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static int GetAutoBreadcrumbsOutput(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, ref DredAutoBreadcrumbsOutput pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DredAutoBreadcrumbsOutput* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredAutoBreadcrumbsOutput*, int>)@this->LpVtbl[3])(@this, pOutputPtr);
        }
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
    public static int GetPageFaultAllocationOutput(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, ref DredPageFaultOutput pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DredPageFaultOutput* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput*, int>)@this->LpVtbl[4])(@this, pOutputPtr);
        }
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
    public static int GetAutoBreadcrumbsOutput1(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, ref DredAutoBreadcrumbsOutput1 pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DredAutoBreadcrumbsOutput1* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredAutoBreadcrumbsOutput1*, int>)@this->LpVtbl[5])(@this, pOutputPtr);
        }
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
    public static int GetPageFaultAllocationOutput1(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, ref DredPageFaultOutput1 pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DredPageFaultOutput1* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput1*, int>)@this->LpVtbl[6])(@this, pOutputPtr);
        }
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
    public static int GetPageFaultAllocationOutput2(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, ref DredPageFaultOutput2 pOutput)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DredPageFaultOutput2* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput2*, int>)@this->LpVtbl[7])(@this, pOutputPtr);
        }
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

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetAutoBreadcrumbsOutput(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, Span<DredAutoBreadcrumbsOutput> pOutput)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAutoBreadcrumbsOutput(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, Span<DredPageFaultOutput> pOutput)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPageFaultAllocationOutput(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAutoBreadcrumbsOutput1(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, Span<DredAutoBreadcrumbsOutput1> pOutput)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAutoBreadcrumbsOutput1(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput1(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, Span<DredPageFaultOutput1> pOutput)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPageFaultAllocationOutput1(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput2(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl, Span<DredPageFaultOutput2> pOutput)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPageFaultAllocationOutput2(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12DeviceRemovedExtendedData2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
