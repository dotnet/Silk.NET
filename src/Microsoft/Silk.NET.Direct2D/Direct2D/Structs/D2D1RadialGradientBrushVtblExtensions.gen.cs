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

public unsafe static class D2D1RadialGradientBrushVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1RadialGradientBrush> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1RadialGradientBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1RadialGradientBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1RadialGradientBrush> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static void SetOpacity(this ComPtr<ID2D1RadialGradientBrush> thisVtbl, float opacity)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float, void>)@this->LpVtbl[4])(@this, opacity);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTransform(this ComPtr<ID2D1RadialGradientBrush> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[5])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static float GetOpacity(this ComPtr<ID2D1RadialGradientBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTransform(this ComPtr<ID2D1RadialGradientBrush> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[7])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void SetCenter(this ComPtr<ID2D1RadialGradientBrush> thisVtbl, Silk.NET.Maths.Vector2D<float> center)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Vector2D<float>, void>)@this->LpVtbl[8])(@this, center);
    }

    /// <summary>To be documented.</summary>
    public static void SetGradientOriginOffset(this ComPtr<ID2D1RadialGradientBrush> thisVtbl, Silk.NET.Maths.Vector2D<float> gradientOriginOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Vector2D<float>, void>)@this->LpVtbl[9])(@this, gradientOriginOffset);
    }

    /// <summary>To be documented.</summary>
    public static void SetRadiusX(this ComPtr<ID2D1RadialGradientBrush> thisVtbl, float radiusX)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float, void>)@this->LpVtbl[10])(@this, radiusX);
    }

    /// <summary>To be documented.</summary>
    public static void SetRadiusY(this ComPtr<ID2D1RadialGradientBrush> thisVtbl, float radiusY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float, void>)@this->LpVtbl[11])(@this, radiusY);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<float> GetCenter(this ComPtr<ID2D1RadialGradientBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<float>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)@this->LpVtbl[12])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<float> GetGradientOriginOffset(this ComPtr<ID2D1RadialGradientBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<float>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)@this->LpVtbl[13])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetRadiusX(this ComPtr<ID2D1RadialGradientBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetRadiusY(this ComPtr<ID2D1RadialGradientBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, float>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetGradientStopCollection(this ComPtr<ID2D1RadialGradientBrush> thisVtbl, ID2D1GradientStopCollection** gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RadialGradientBrush*, ID2D1GradientStopCollection**, void>)@this->LpVtbl[16])(@this, gradientStopCollection);
    }

}
