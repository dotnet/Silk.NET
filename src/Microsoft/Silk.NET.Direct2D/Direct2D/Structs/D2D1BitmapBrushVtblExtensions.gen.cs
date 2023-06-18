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

public unsafe static class D2D1BitmapBrushVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1BitmapBrush> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1BitmapBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1BitmapBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1BitmapBrush> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static void SetOpacity(this ComPtr<ID2D1BitmapBrush> thisVtbl, float opacity)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, float, void>)@this->LpVtbl[4])(@this, opacity);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTransform(this ComPtr<ID2D1BitmapBrush> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[5])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static float GetOpacity(this ComPtr<ID2D1BitmapBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, float>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTransform(this ComPtr<ID2D1BitmapBrush> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[7])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void SetExtendModeX(this ComPtr<ID2D1BitmapBrush> thisVtbl, ExtendMode extendModeX)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode, void>)@this->LpVtbl[8])(@this, extendModeX);
    }

    /// <summary>To be documented.</summary>
    public static void SetExtendModeY(this ComPtr<ID2D1BitmapBrush> thisVtbl, ExtendMode extendModeY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode, void>)@this->LpVtbl[9])(@this, extendModeY);
    }

    /// <summary>To be documented.</summary>
    public static void SetInterpolationMode(this ComPtr<ID2D1BitmapBrush> thisVtbl, BitmapInterpolationMode interpolationMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, BitmapInterpolationMode, void>)@this->LpVtbl[10])(@this, interpolationMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetBitmap(this ComPtr<ID2D1BitmapBrush> thisVtbl, ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Bitmap*, void>)@this->LpVtbl[11])(@this, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendModeX(this ComPtr<ID2D1BitmapBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendModeY(this ComPtr<ID2D1BitmapBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ExtendMode>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static BitmapInterpolationMode GetInterpolationMode(this ComPtr<ID2D1BitmapBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        BitmapInterpolationMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, BitmapInterpolationMode>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetBitmap(this ComPtr<ID2D1BitmapBrush> thisVtbl, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush*, ID2D1Bitmap**, void>)@this->LpVtbl[15])(@this, bitmap);
    }

}
