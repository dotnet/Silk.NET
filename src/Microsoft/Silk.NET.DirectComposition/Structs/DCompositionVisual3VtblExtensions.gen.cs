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

public unsafe static class DCompositionVisual3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionVisual3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionVisual3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionVisual3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOffsetX(this ComPtr<IDCompositionVisual3> thisVtbl, float offsetX)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, float, int>)@this->LpVtbl[4])(@this, offsetX);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOffsetY(this ComPtr<IDCompositionVisual3> thisVtbl, float offsetY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, float, int>)@this->LpVtbl[6])(@this, offsetY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransform(this ComPtr<IDCompositionVisual3> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* matrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[8])(@this, matrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransformParent(this ComPtr<IDCompositionVisual3> thisVtbl, IDCompositionVisual* visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionVisual*, int>)@this->LpVtbl[9])(@this, visual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEffect(this ComPtr<IDCompositionVisual3> thisVtbl, IDCompositionEffect* effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionEffect*, int>)@this->LpVtbl[10])(@this, effect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBitmapInterpolationMode(this ComPtr<IDCompositionVisual3> thisVtbl, BitmapInterpolationMode interpolationMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, BitmapInterpolationMode, int>)@this->LpVtbl[11])(@this, interpolationMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBorderMode(this ComPtr<IDCompositionVisual3> thisVtbl, BorderMode borderMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, BorderMode, int>)@this->LpVtbl[12])(@this, borderMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetClip(this ComPtr<IDCompositionVisual3> thisVtbl, Silk.NET.Maths.Rectangle<float>* rect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Silk.NET.Maths.Rectangle<float>*, int>)@this->LpVtbl[14])(@this, rect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetContent(this ComPtr<IDCompositionVisual3> thisVtbl, Silk.NET.Core.Native.IUnknown* content)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[15])(@this, content);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddVisual(this ComPtr<IDCompositionVisual3> thisVtbl, IDCompositionVisual* visual, Silk.NET.Core.Bool32 insertAbove, IDCompositionVisual* referenceVisual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visual, insertAbove, referenceVisual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveVisual(this ComPtr<IDCompositionVisual3> thisVtbl, IDCompositionVisual* visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, IDCompositionVisual*, int>)@this->LpVtbl[17])(@this, visual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveAllVisuals(this ComPtr<IDCompositionVisual3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, int>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCompositeMode(this ComPtr<IDCompositionVisual3> thisVtbl, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, CompositeMode, int>)@this->LpVtbl[19])(@this, compositeMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOpacityMode(this ComPtr<IDCompositionVisual3> thisVtbl, OpacityMode mode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, OpacityMode, int>)@this->LpVtbl[20])(@this, mode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBackFaceVisibility(this ComPtr<IDCompositionVisual3> thisVtbl, BackfaceVisibility visibility)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, BackfaceVisibility, int>)@this->LpVtbl[21])(@this, visibility);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnableHeatMap(this ComPtr<IDCompositionVisual3> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[22])(@this, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DisableHeatMap(this ComPtr<IDCompositionVisual3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, int>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnableRedrawRegions(this ComPtr<IDCompositionVisual3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, int>)@this->LpVtbl[24])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DisableRedrawRegions(this ComPtr<IDCompositionVisual3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, int>)@this->LpVtbl[25])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDepthMode(this ComPtr<IDCompositionVisual3> thisVtbl, DepthMode mode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, DepthMode, int>)@this->LpVtbl[26])(@this, mode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOffsetZ(this ComPtr<IDCompositionVisual3> thisVtbl, float offsetZ)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, float, int>)@this->LpVtbl[28])(@this, offsetZ);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOpacity(this ComPtr<IDCompositionVisual3> thisVtbl, float opacity)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, float, int>)@this->LpVtbl[30])(@this, opacity);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVisible(this ComPtr<IDCompositionVisual3> thisVtbl, Silk.NET.Core.Bool32 visible)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual3*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[33])(@this, visible);
        return ret;
    }

}
