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

public unsafe static class D3D12DeviceRemovedExtendedDataVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAutoBreadcrumbsOutput<TThis>(this TThis thisVtbl, DredAutoBreadcrumbsOutput* pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredAutoBreadcrumbsOutput*, int>)@this->LpVtbl[3])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAutoBreadcrumbsOutput<TThis>(this TThis thisVtbl, ref DredAutoBreadcrumbsOutput pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DredAutoBreadcrumbsOutput* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredAutoBreadcrumbsOutput*, int>)@this->LpVtbl[3])(@this, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPageFaultAllocationOutput<TThis>(this TThis thisVtbl, DredPageFaultOutput* pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredPageFaultOutput*, int>)@this->LpVtbl[4])(@this, pOutput);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput<TThis>(this TThis thisVtbl, ref DredPageFaultOutput pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DredPageFaultOutput* pOutputPtr = &pOutput)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData*, DredPageFaultOutput*, int>)@this->LpVtbl[4])(@this, pOutputPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetAutoBreadcrumbsOutput<TThis>(this TThis thisVtbl, Span<DredAutoBreadcrumbsOutput> pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetAutoBreadcrumbsOutput(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPageFaultAllocationOutput<TThis>(this TThis thisVtbl, Span<DredPageFaultOutput> pOutput) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPageFaultAllocationOutput(ref pOutput.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D12DeviceRemovedExtendedData>
    {
        var @this = (ID3D12DeviceRemovedExtendedData*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
