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

public unsafe static class DCompositionBrightnessEffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionBrightnessEffect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionBrightnessEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionBrightnessEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInput(this ComPtr<IDCompositionBrightnessEffect> thisVtbl, uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetWhitePoint(this ComPtr<IDCompositionBrightnessEffect> thisVtbl, Silk.NET.Maths.Vector2D<float>* whitePoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[4])(@this, whitePoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetBlackPoint(this ComPtr<IDCompositionBrightnessEffect> thisVtbl, Silk.NET.Maths.Vector2D<float>* blackPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[5])(@this, blackPoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetWhitePointX(this ComPtr<IDCompositionBrightnessEffect> thisVtbl, float whitePointX)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)@this->LpVtbl[7])(@this, whitePointX);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetWhitePointY(this ComPtr<IDCompositionBrightnessEffect> thisVtbl, float whitePointY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)@this->LpVtbl[9])(@this, whitePointY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBlackPointX(this ComPtr<IDCompositionBrightnessEffect> thisVtbl, float blackPointX)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)@this->LpVtbl[11])(@this, blackPointX);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBlackPointY(this ComPtr<IDCompositionBrightnessEffect> thisVtbl, float blackPointY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionBrightnessEffect*, float, int>)@this->LpVtbl[13])(@this, blackPointY);
        return ret;
    }

}
