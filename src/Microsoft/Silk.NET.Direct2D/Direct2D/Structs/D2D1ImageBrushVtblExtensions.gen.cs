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

public unsafe static class D2D1ImageBrushVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageBrush> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1ImageBrush> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static void SetOpacity(this ComPtr<ID2D1ImageBrush> thisVtbl, float opacity)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, float, void>)@this->LpVtbl[4])(@this, opacity);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTransform(this ComPtr<ID2D1ImageBrush> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[5])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static float GetOpacity(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, float>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTransform(this ComPtr<ID2D1ImageBrush> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[7])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetImage(this ComPtr<ID2D1ImageBrush> thisVtbl, ID2D1Image* image)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Image*, void>)@this->LpVtbl[8])(@this, image);
    }

    /// <summary>To be documented.</summary>
    public static void SetExtendModeX(this ComPtr<ID2D1ImageBrush> thisVtbl, ExtendMode extendModeX)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode, void>)@this->LpVtbl[9])(@this, extendModeX);
    }

    /// <summary>To be documented.</summary>
    public static void SetExtendModeY(this ComPtr<ID2D1ImageBrush> thisVtbl, ExtendMode extendModeY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode, void>)@this->LpVtbl[10])(@this, extendModeY);
    }

    /// <summary>To be documented.</summary>
    public static void SetInterpolationMode(this ComPtr<ID2D1ImageBrush> thisVtbl, InterpolationMode interpolationMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, InterpolationMode, void>)@this->LpVtbl[11])(@this, interpolationMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetSourceRectangle(this ComPtr<ID2D1ImageBrush> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[12])(@this, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetImage(this ComPtr<ID2D1ImageBrush> thisVtbl, ID2D1Image** image)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Image**, void>)@this->LpVtbl[13])(@this, image);
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendModeX(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendModeY(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static InterpolationMode GetInterpolationMode(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        InterpolationMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, InterpolationMode>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetSourceRectangle(this ComPtr<ID2D1ImageBrush> thisVtbl, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[17])(@this, sourceRectangle);
    }

}
