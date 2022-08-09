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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFeatureMask<TThis>(this TThis thisVtbl, uint Mask) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, int>)@this->LpVtbl[3])(@this, Mask);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFeatureMask<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPresentPerRenderOpDelay<TThis>(this TThis thisVtbl, uint Milliseconds) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint, int>)@this->LpVtbl[5])(@this, Milliseconds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPresentPerRenderOpDelay<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, uint>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSwapChain<TThis>(this TThis thisVtbl, Silk.NET.DXGI.IDXGISwapChain* pSwapChain) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)@this->LpVtbl[7])(@this, pSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.DXGI.IDXGISwapChain pSwapChain) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISwapChain* pSwapChainPtr = &pSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain*, int>)@this->LpVtbl[7])(@this, pSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChain<TThis>(this TThis thisVtbl, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[8])(@this, ppSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChain<TThis>(this TThis thisVtbl, ref Silk.NET.DXGI.IDXGISwapChain* ppSwapChain) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISwapChain** ppSwapChainPtr = &ppSwapChain)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[8])(@this, ppSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateContext<TThis>(this TThis thisVtbl, ID3D11DeviceContext* pContext) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[9])(@this, pContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ValidateContext<TThis>(this TThis thisVtbl, ref ID3D11DeviceContext pContext) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11DeviceContext* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[9])(@this, pContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReportLiveDeviceObjects<TThis>(this TThis thisVtbl, RldoFlags Flags) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, RldoFlags, int>)@this->LpVtbl[10])(@this, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateContextForDispatch<TThis>(this TThis thisVtbl, ID3D11DeviceContext* pContext) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[11])(@this, pContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ValidateContextForDispatch<TThis>(this TThis thisVtbl, ref ID3D11DeviceContext pContext) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11DeviceContext* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, ID3D11DeviceContext*, int>)@this->LpVtbl[11])(@this, pContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetSwapChain<TThis>(this TThis thisVtbl, Span<Silk.NET.DXGI.IDXGISwapChain> pSwapChain) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetSwapChain(ref pSwapChain.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ValidateContext<TThis>(this TThis thisVtbl, Span<ID3D11DeviceContext> pContext) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ValidateContext(ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ValidateContextForDispatch<TThis>(this TThis thisVtbl, Span<ID3D11DeviceContext> pContext) where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ValidateContextForDispatch(ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<ID3D11Debug>
    {
        var @this = (ID3D11Debug*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
