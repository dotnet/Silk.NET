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

namespace Silk.NET.Direct3D9;

public unsafe static class Direct3DSwapChain9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DSwapChain9> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DSwapChain9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DSwapChain9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrontBufferData(this ComPtr<IDirect3DSwapChain9> thisVtbl, IDirect3DSurface9* pDestSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, IDirect3DSurface9*, int>)@this->LpVtbl[4])(@this, pDestSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackBuffer(this ComPtr<IDirect3DSwapChain9> thisVtbl, uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[5])(@this, iBackBuffer, Type, ppBackBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRasterStatus(this ComPtr<IDirect3DSwapChain9> thisVtbl, RasterStatus* pRasterStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, RasterStatus*, int>)@this->LpVtbl[6])(@this, pRasterStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayMode(this ComPtr<IDirect3DSwapChain9> thisVtbl, Displaymode* pMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Displaymode*, int>)@this->LpVtbl[7])(@this, pMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDirect3DSwapChain9> thisVtbl, IDirect3DDevice9** ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, IDirect3DDevice9**, int>)@this->LpVtbl[8])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPresentParameters(this ComPtr<IDirect3DSwapChain9> thisVtbl, PresentParameters* pPresentationParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, PresentParameters*, int>)@this->LpVtbl[9])(@this, pPresentationParameters);
        return ret;
    }

}
