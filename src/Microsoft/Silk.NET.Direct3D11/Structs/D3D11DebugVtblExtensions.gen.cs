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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11DebugVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Debug> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Debug> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Debug> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Debug> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11Debug> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11Debug> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFeatureMask(this ComPtr<ID3D11Debug> thisVtbl, uint Mask)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, int>)@this->LpVtbl[3])(@this, Mask);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFeatureMask(this ComPtr<ID3D11Debug> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPresentPerRenderOpDelay(this ComPtr<ID3D11Debug> thisVtbl, uint Milliseconds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, int>)@this->LpVtbl[5])(@this, Milliseconds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPresentPerRenderOpDelay(this ComPtr<ID3D11Debug> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSwapChain(this ComPtr<ID3D11Debug> thisVtbl, Silk.NET.DXGI.IDXGISwapChain* pSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)@this->LpVtbl[7])(@this, pSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSwapChain(this ComPtr<ID3D11Debug> thisVtbl, ref Silk.NET.DXGI.IDXGISwapChain pSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISwapChain* pSwapChainPtr = &pSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)@this->LpVtbl[7])(@this, pSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChain(this ComPtr<ID3D11Debug> thisVtbl, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[8])(@this, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChain(this ComPtr<ID3D11Debug> thisVtbl, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[8])(@this, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateContext(this ComPtr<ID3D11Debug> thisVtbl, ID3D11DeviceContext* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[9])(@this, pContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ValidateContext(this ComPtr<ID3D11Debug> thisVtbl, ref ID3D11DeviceContext pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11DeviceContext* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[9])(@this, pContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReportLiveDeviceObjects(this ComPtr<ID3D11Debug> thisVtbl, RldoFlags Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, RldoFlags, int>)@this->LpVtbl[10])(@this, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateContextForDispatch(this ComPtr<ID3D11Debug> thisVtbl, ID3D11DeviceContext* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[11])(@this, pContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ValidateContextForDispatch(this ComPtr<ID3D11Debug> thisVtbl, ref ID3D11DeviceContext pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11DeviceContext* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[11])(@this, pContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11Debug> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Debug> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11Debug> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetSwapChain<TI0>(this ComPtr<ID3D11Debug> thisVtbl, ComPtr<TI0> pSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetSwapChain((Silk.NET.DXGI.IDXGISwapChain*) pSwapChain.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetSwapChain(this ComPtr<ID3D11Debug> thisVtbl, Span<Silk.NET.DXGI.IDXGISwapChain> pSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSwapChain(ref pSwapChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSwapChain<TI0>(this ComPtr<ID3D11Debug> thisVtbl, ref ComPtr<TI0> ppSwapChain) where TI0 : unmanaged, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSwapChain((Silk.NET.DXGI.IDXGISwapChain**) ppSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int ValidateContext<TI0>(this ComPtr<ID3D11Debug> thisVtbl, ComPtr<TI0> pContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ValidateContext((ID3D11DeviceContext*) pContext.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int ValidateContext(this ComPtr<ID3D11Debug> thisVtbl, Span<ID3D11DeviceContext> pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ValidateContext(ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ValidateContextForDispatch<TI0>(this ComPtr<ID3D11Debug> thisVtbl, ComPtr<TI0> pContext) where TI0 : unmanaged, IComVtbl<ID3D11DeviceContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ValidateContextForDispatch((ID3D11DeviceContext*) pContext.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int ValidateContextForDispatch(this ComPtr<ID3D11Debug> thisVtbl, Span<ID3D11DeviceContext> pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ValidateContextForDispatch(ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11Debug> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
