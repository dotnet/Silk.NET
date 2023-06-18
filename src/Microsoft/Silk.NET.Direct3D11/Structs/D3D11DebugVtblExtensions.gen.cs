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
    public static unsafe int GetSwapChain(this ComPtr<ID3D11Debug> thisVtbl, Silk.NET.DXGI.IDXGISwapChain** ppSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11Debug*, Silk.NET.DXGI.IDXGISwapChain**, int>)@this->LpVtbl[8])(@this, ppSwapChain);
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

}
