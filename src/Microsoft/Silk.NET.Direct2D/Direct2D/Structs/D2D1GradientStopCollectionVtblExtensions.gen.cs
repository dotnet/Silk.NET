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

public unsafe static class D2D1GradientStopCollectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GradientStopCollection> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1GradientStopCollection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1GradientStopCollection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1GradientStopCollection> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static uint GetGradientStopCount(this ComPtr<ID2D1GradientStopCollection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetGradientStops(this ComPtr<ID2D1GradientStopCollection> thisVtbl, GradientStop* gradientStops, uint gradientStopsCount)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, GradientStop*, uint, void>)@this->LpVtbl[5])(@this, gradientStops, gradientStopsCount);
    }

    /// <summary>To be documented.</summary>
    public static Gamma GetColorInterpolationGamma(this ComPtr<ID2D1GradientStopCollection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Gamma ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, Gamma>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendMode(this ComPtr<ID2D1GradientStopCollection> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection*, ExtendMode>)@this->LpVtbl[7])(@this);
        return ret;
    }

}
