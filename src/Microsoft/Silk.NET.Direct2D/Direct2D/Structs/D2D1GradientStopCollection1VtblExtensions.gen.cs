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

public unsafe static class D2D1GradientStopCollection1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GradientStopCollection1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1GradientStopCollection1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1GradientStopCollection1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1GradientStopCollection1> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static uint GetGradientStopCount(this ComPtr<ID2D1GradientStopCollection1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetGradientStops(this ComPtr<ID2D1GradientStopCollection1> thisVtbl, GradientStop* gradientStops, uint gradientStopsCount)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, GradientStop*, uint, void>)@this->LpVtbl[5])(@this, gradientStops, gradientStopsCount);
    }

    /// <summary>To be documented.</summary>
    public static Gamma GetColorInterpolationGamma(this ComPtr<ID2D1GradientStopCollection1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Gamma ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, Gamma>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendMode(this ComPtr<ID2D1GradientStopCollection1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ExtendMode>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetGradientStops1(this ComPtr<ID2D1GradientStopCollection1> thisVtbl, GradientStop* gradientStops, uint gradientStopsCount)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, GradientStop*, uint, void>)@this->LpVtbl[8])(@this, gradientStops, gradientStopsCount);
    }

    /// <summary>To be documented.</summary>
    public static ColorSpace GetPreInterpolationSpace(this ComPtr<ID2D1GradientStopCollection1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ColorSpace ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ColorSpace>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ColorSpace GetPostInterpolationSpace(this ComPtr<ID2D1GradientStopCollection1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ColorSpace ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ColorSpace>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static BufferPrecision GetBufferPrecision(this ComPtr<ID2D1GradientStopCollection1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        BufferPrecision ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, BufferPrecision>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ColorInterpolationMode GetColorInterpolationMode(this ComPtr<ID2D1GradientStopCollection1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ColorInterpolationMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GradientStopCollection1*, ColorInterpolationMode>)@this->LpVtbl[12])(@this);
        return ret;
    }

}
