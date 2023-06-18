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

public unsafe static class DCompositionVisualVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionVisual> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionVisual> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionVisual> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOffsetX(this ComPtr<IDCompositionVisual> thisVtbl, float offsetX)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, float, int>)@this->LpVtbl[4])(@this, offsetX);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOffsetY(this ComPtr<IDCompositionVisual> thisVtbl, float offsetY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, float, int>)@this->LpVtbl[6])(@this, offsetY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransform(this ComPtr<IDCompositionVisual> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* matrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[8])(@this, matrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransformParent(this ComPtr<IDCompositionVisual> thisVtbl, IDCompositionVisual* visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int>)@this->LpVtbl[9])(@this, visual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetEffect(this ComPtr<IDCompositionVisual> thisVtbl, IDCompositionEffect* effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionEffect*, int>)@this->LpVtbl[10])(@this, effect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBitmapInterpolationMode(this ComPtr<IDCompositionVisual> thisVtbl, BitmapInterpolationMode interpolationMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, BitmapInterpolationMode, int>)@this->LpVtbl[11])(@this, interpolationMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBorderMode(this ComPtr<IDCompositionVisual> thisVtbl, BorderMode borderMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, BorderMode, int>)@this->LpVtbl[12])(@this, borderMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetClip(this ComPtr<IDCompositionVisual> thisVtbl, Silk.NET.Maths.Rectangle<float>* rect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Silk.NET.Maths.Rectangle<float>*, int>)@this->LpVtbl[14])(@this, rect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetContent(this ComPtr<IDCompositionVisual> thisVtbl, Silk.NET.Core.Native.IUnknown* content)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[15])(@this, content);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddVisual(this ComPtr<IDCompositionVisual> thisVtbl, IDCompositionVisual* visual, Silk.NET.Core.Bool32 insertAbove, IDCompositionVisual* referenceVisual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, Silk.NET.Core.Bool32, IDCompositionVisual*, int>)@this->LpVtbl[16])(@this, visual, insertAbove, referenceVisual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveVisual(this ComPtr<IDCompositionVisual> thisVtbl, IDCompositionVisual* visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, IDCompositionVisual*, int>)@this->LpVtbl[17])(@this, visual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveAllVisuals(this ComPtr<IDCompositionVisual> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, int>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCompositeMode(this ComPtr<IDCompositionVisual> thisVtbl, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVisual*, CompositeMode, int>)@this->LpVtbl[19])(@this, compositeMode);
        return ret;
    }

}
