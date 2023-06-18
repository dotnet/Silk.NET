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

public unsafe static class DXGIDecodeSwapChainVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDXGIDecodeSwapChain> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDXGIDecodeSwapChain> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PresentBuffer(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, uint BufferToPresent, uint SyncInterval, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint, uint, uint, int>)@this->LpVtbl[3])(@this, BufferToPresent, SyncInterval, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[4])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTargetRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[5])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDestSize(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, uint Width, uint Height)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint, uint, int>)@this->LpVtbl[6])(@this, Width, Height);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[7])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTargetRect(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[8])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDestSize(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, uint* pWidth, uint* pHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, uint*, uint*, int>)@this->LpVtbl[9])(@this, pWidth, pHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetColorSpace(this ComPtr<IDXGIDecodeSwapChain> thisVtbl, MULTIPLANEOVERLAYYCbCrFLAGS ColorSpace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, MULTIPLANEOVERLAYYCbCrFLAGS, int>)@this->LpVtbl[10])(@this, ColorSpace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static MULTIPLANEOVERLAYYCbCrFLAGS GetColorSpace(this ComPtr<IDXGIDecodeSwapChain> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        MULTIPLANEOVERLAYYCbCrFLAGS ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDXGIDecodeSwapChain*, MULTIPLANEOVERLAYYCbCrFLAGS>)@this->LpVtbl[11])(@this);
        return ret;
    }

}
