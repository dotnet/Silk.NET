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

public unsafe static class DCompositionColorMatrixEffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInput(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetMatrix(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Silk.NET.Maths.Matrix5X4<float>* matrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Silk.NET.Maths.Matrix5X4<float>*, int>)@this->LpVtbl[4])(@this, matrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMatrixElement(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, int row, int column, float value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, int, int, float, int>)@this->LpVtbl[6])(@this, row, column, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlphaMode(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Silk.NET.Direct2D.ColormatrixAlphaMode mode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Silk.NET.Direct2D.ColormatrixAlphaMode, int>)@this->LpVtbl[7])(@this, mode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClampOutput(this ComPtr<IDCompositionColorMatrixEffect> thisVtbl, Silk.NET.Core.Bool32 clamp)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionColorMatrixEffect*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[8])(@this, clamp);
        return ret;
    }

}
