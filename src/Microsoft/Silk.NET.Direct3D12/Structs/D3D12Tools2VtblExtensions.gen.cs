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

public unsafe static class D3D12Tools2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Tools2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Tools2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Tools2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Tools2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12Tools2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12Tools2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void EnableShaderInstrumentation(this ComPtr<ID3D12Tools2> thisVtbl, Silk.NET.Core.Bool32 bEnable)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[3])(@this, bEnable);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 ShaderInstrumentationEnabled(this ComPtr<ID3D12Tools2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Bool32>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReserveGPUVARangesAtCreate(this ComPtr<ID3D12Tools2> thisVtbl, GpuVirtualAddressRange* pRanges, uint uiNumRanges)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, GpuVirtualAddressRange*, uint, int>)@this->LpVtbl[5])(@this, pRanges, uiNumRanges);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReserveGPUVARangesAtCreate(this ComPtr<ID3D12Tools2> thisVtbl, ref GpuVirtualAddressRange pRanges, uint uiNumRanges)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GpuVirtualAddressRange* pRangesPtr = &pRanges)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, GpuVirtualAddressRange*, uint, int>)@this->LpVtbl[5])(@this, pRangesPtr, uiNumRanges);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void ClearReservedGPUVARangesList(this ComPtr<ID3D12Tools2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, void>)@this->LpVtbl[6])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetApplicationSpecificDriverState(this ComPtr<ID3D12Tools2> thisVtbl, Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.ID3D10Blob* pBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.ID3D10Blob*, int>)@this->LpVtbl[7])(@this, pAdapter, pBlob);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetApplicationSpecificDriverState(this ComPtr<ID3D12Tools2> thisVtbl, Silk.NET.Core.Native.IUnknown* pAdapter, ref Silk.NET.Core.Native.ID3D10Blob pBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob* pBlobPtr = &pBlob)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.ID3D10Blob*, int>)@this->LpVtbl[7])(@this, pAdapter, pBlobPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetApplicationSpecificDriverState(this ComPtr<ID3D12Tools2> thisVtbl, ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.ID3D10Blob* pBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pAdapterPtr = &pAdapter)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.ID3D10Blob*, int>)@this->LpVtbl[7])(@this, pAdapterPtr, pBlob);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetApplicationSpecificDriverState(this ComPtr<ID3D12Tools2> thisVtbl, ref Silk.NET.Core.Native.IUnknown pAdapter, ref Silk.NET.Core.Native.ID3D10Blob pBlob)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pAdapterPtr = &pAdapter)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.ID3D10Blob*, int>)@this->LpVtbl[7])(@this, pAdapterPtr, pBlobPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12Tools2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Tools2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12Tools2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int ReserveGPUVARangesAtCreate(this ComPtr<ID3D12Tools2> thisVtbl, Span<GpuVirtualAddressRange> pRanges, uint uiNumRanges)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReserveGPUVARangesAtCreate(ref pRanges.GetPinnableReference(), uiNumRanges);
    }

    /// <summary>To be documented.</summary>
    public static int SetApplicationSpecificDriverState<TI0, TI1>(this ComPtr<ID3D12Tools2> thisVtbl, ComPtr<TI0> pAdapter, ComPtr<TI1> pBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetApplicationSpecificDriverState((Silk.NET.Core.Native.IUnknown*) pAdapter.Handle, (Silk.NET.Core.Native.ID3D10Blob*) pBlob.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetApplicationSpecificDriverState(this ComPtr<ID3D12Tools2> thisVtbl, Silk.NET.Core.Native.IUnknown* pAdapter, Span<Silk.NET.Core.Native.ID3D10Blob> pBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetApplicationSpecificDriverState(pAdapter, ref pBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetApplicationSpecificDriverState<TI0>(this ComPtr<ID3D12Tools2> thisVtbl, ComPtr<TI0> pAdapter, ref Silk.NET.Core.Native.ID3D10Blob pBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetApplicationSpecificDriverState((Silk.NET.Core.Native.IUnknown*) pAdapter.Handle, ref pBlob);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetApplicationSpecificDriverState(this ComPtr<ID3D12Tools2> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pAdapter, Silk.NET.Core.Native.ID3D10Blob* pBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetApplicationSpecificDriverState(ref pAdapter.GetPinnableReference(), pBlob);
    }

    /// <summary>To be documented.</summary>
    public static int SetApplicationSpecificDriverState<TI0>(this ComPtr<ID3D12Tools2> thisVtbl, ref Silk.NET.Core.Native.IUnknown pAdapter, ComPtr<TI0> pBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetApplicationSpecificDriverState(ref pAdapter, (Silk.NET.Core.Native.ID3D10Blob*) pBlob.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetApplicationSpecificDriverState(this ComPtr<ID3D12Tools2> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pAdapter, Span<Silk.NET.Core.Native.ID3D10Blob> pBlob)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetApplicationSpecificDriverState(ref pAdapter.GetPinnableReference(), ref pBlob.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12Tools2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
