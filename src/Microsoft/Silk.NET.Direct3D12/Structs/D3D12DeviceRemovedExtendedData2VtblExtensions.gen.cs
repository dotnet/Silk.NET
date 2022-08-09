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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAutoBreadcrumbsOutput<TThis>(this TThis thisVtbl, DredAutoBreadcrumbsOutput* pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredAutoBreadcrumbsOutput*, int>)@this->LpVtbl[3])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAutoBreadcrumbsOutput<TThis>(this TThis thisVtbl, ref DredAutoBreadcrumbsOutput pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DredAutoBreadcrumbsOutput* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredAutoBreadcrumbsOutput*, int>)@this->LpVtbl[3])(@this, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPageFaultAllocationOutput<TThis>(this TThis thisVtbl, DredPageFaultOutput* pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput*, int>)@this->LpVtbl[4])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput<TThis>(this TThis thisVtbl, ref DredPageFaultOutput pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DredPageFaultOutput* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput*, int>)@this->LpVtbl[4])(@this, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAutoBreadcrumbsOutput1<TThis>(this TThis thisVtbl, DredAutoBreadcrumbsOutput1* pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredAutoBreadcrumbsOutput1*, int>)@this->LpVtbl[5])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAutoBreadcrumbsOutput1<TThis>(this TThis thisVtbl, ref DredAutoBreadcrumbsOutput1 pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DredAutoBreadcrumbsOutput1* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredAutoBreadcrumbsOutput1*, int>)@this->LpVtbl[5])(@this, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPageFaultAllocationOutput1<TThis>(this TThis thisVtbl, DredPageFaultOutput1* pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput1*, int>)@this->LpVtbl[6])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput1<TThis>(this TThis thisVtbl, ref DredPageFaultOutput1 pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DredPageFaultOutput1* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput1*, int>)@this->LpVtbl[6])(@this, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPageFaultAllocationOutput2<TThis>(this TThis thisVtbl, DredPageFaultOutput2* pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput2*, int>)@this->LpVtbl[7])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput2<TThis>(this TThis thisVtbl, ref DredPageFaultOutput2 pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DredPageFaultOutput2* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredPageFaultOutput2*, int>)@this->LpVtbl[7])(@this, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static DredDeviceState GetDeviceState<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        DredDeviceState ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData2*, DredDeviceState>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetAutoBreadcrumbsOutput<TThis>(this TThis thisVtbl, Span<DredAutoBreadcrumbsOutput> pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetAutoBreadcrumbsOutput(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput<TThis>(this TThis thisVtbl, Span<DredPageFaultOutput> pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPageFaultAllocationOutput(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetAutoBreadcrumbsOutput1<TThis>(this TThis thisVtbl, Span<DredAutoBreadcrumbsOutput1> pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetAutoBreadcrumbsOutput1(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput1<TThis>(this TThis thisVtbl, Span<DredPageFaultOutput1> pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPageFaultAllocationOutput1(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput2<TThis>(this TThis thisVtbl, Span<DredPageFaultOutput2> pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPageFaultAllocationOutput2(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData2>
    {
        var @this = (ID3D12DeviceRemovedExtendedData2*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
