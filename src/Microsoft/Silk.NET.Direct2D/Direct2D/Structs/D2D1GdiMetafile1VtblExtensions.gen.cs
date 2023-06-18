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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1GdiMetafile1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1GdiMetafile1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1GdiMetafile1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Stream(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ID2D1GdiMetafileSink* sink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, ID2D1GdiMetafileSink*, int>)@this->LpVtbl[4])(@this, sink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, bounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDpi(this ComPtr<ID2D1GdiMetafile1> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, float*, float*, int>)@this->LpVtbl[6])(@this, dpiX, dpiY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceBounds(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[7])(@this, bounds);
        return ret;
    }

}
