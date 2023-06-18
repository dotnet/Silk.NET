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

public unsafe static class D2D1ImageSourceFromWicVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static int OfferResources(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryReclaimResources(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, int* resourcesDiscarded)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, int*, int>)@this->LpVtbl[5])(@this, resourcesDiscarded);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnsureCached(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* rectangleToFill)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[6])(@this, rectangleToFill);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TrimCache(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* rectangleToPreserve)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[7])(@this, rectangleToPreserve);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetSource(this ComPtr<ID2D1ImageSourceFromWic> thisVtbl, IWICBitmapSource** wicBitmapSource)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageSourceFromWic*, IWICBitmapSource**, void>)@this->LpVtbl[8])(@this, wicBitmapSource);
    }

}
