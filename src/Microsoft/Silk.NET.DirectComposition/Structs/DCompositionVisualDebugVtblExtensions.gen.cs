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

namespace Silk.NET.DirectComposition;

public unsafe static class DCompositionVisualDebugVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionVisualDebug> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionVisualDebug> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionVisualDebug> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOffsetX(this ComPtr<IDCompositionVisualDebug> thisVtbl, float offsetX)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, float, int>)@this->LpVtbl[4])(@this, offsetX);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOffsetY(this ComPtr<IDCompositionVisualDebug> thisVtbl, float offsetY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, float, int>)@this->LpVtbl[6])(@this, offsetY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransform(this ComPtr<IDCompositionVisualDebug> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* matrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[8])(@this, matrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransformParent(this ComPtr<IDCompositionVisualDebug> thisVtbl, IDCompositionVisual* visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)@this->LpVtbl[9])(@this, visual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEffect(this ComPtr<IDCompositionVisualDebug> thisVtbl, IDCompositionEffect* effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionEffect*, int>)@this->LpVtbl[10])(@this, effect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBitmapInterpolationMode(this ComPtr<IDCompositionVisualDebug> thisVtbl, BitmapInterpolationMode interpolationMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BitmapInterpolationMode, int>)@this->LpVtbl[11])(@this, interpolationMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBorderMode(this ComPtr<IDCompositionVisualDebug> thisVtbl, BorderMode borderMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BorderMode, int>)@this->LpVtbl[12])(@this, borderMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetClip(this ComPtr<IDCompositionVisualDebug> thisVtbl, Silk.NET.Maths.Rectangle<float>* rect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Maths.Rectangle<float>*, int>)@this->LpVtbl[14])(@this, rect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetContent(this ComPtr<IDCompositionVisualDebug> thisVtbl, Silk.NET.Core.Native.IUnknown* content)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[15])(@this, content);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddVisual(this ComPtr<IDCompositionVisualDebug> thisVtbl, IDCompositionVisual* visual, Silk.NET.Core.Bool32 insertAbove, IDCompositionVisual* referenceVisual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visual, insertAbove, referenceVisual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveVisual(this ComPtr<IDCompositionVisualDebug> thisVtbl, IDCompositionVisual* visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, IDCompositionVisual*, int>)@this->LpVtbl[17])(@this, visual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveAllVisuals(this ComPtr<IDCompositionVisualDebug> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCompositeMode(this ComPtr<IDCompositionVisualDebug> thisVtbl, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, CompositeMode, int>)@this->LpVtbl[19])(@this, compositeMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOpacityMode(this ComPtr<IDCompositionVisualDebug> thisVtbl, OpacityMode mode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, OpacityMode, int>)@this->LpVtbl[20])(@this, mode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBackFaceVisibility(this ComPtr<IDCompositionVisualDebug> thisVtbl, BackfaceVisibility visibility)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, BackfaceVisibility, int>)@this->LpVtbl[21])(@this, visibility);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableHeatMap(this ComPtr<IDCompositionVisualDebug> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[22])(@this, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DisableHeatMap(this ComPtr<IDCompositionVisualDebug> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnableRedrawRegions(this ComPtr<IDCompositionVisualDebug> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)@this->LpVtbl[24])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DisableRedrawRegions(this ComPtr<IDCompositionVisualDebug> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisualDebug*, int>)@this->LpVtbl[25])(@this);
        return ret;
    }

}
