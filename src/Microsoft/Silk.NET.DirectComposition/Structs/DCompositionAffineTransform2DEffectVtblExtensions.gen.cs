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

public unsafe static class DCompositionAffineTransform2DEffectVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionAffineTransform2DEffect> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionAffineTransform2DEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionAffineTransform2DEffect> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInput(this ComPtr<IDCompositionAffineTransform2DEffect> thisVtbl, uint index, Silk.NET.Core.Native.IUnknown* input, uint flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, uint, Silk.NET.Core.Native.IUnknown*, uint, int>)@this->LpVtbl[3])(@this, index, input, flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetInterpolationMode(this ComPtr<IDCompositionAffineTransform2DEffect> thisVtbl, Silk.NET.Direct2D.D2D12DaffinetransformInterpolationMode interpolationMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Silk.NET.Direct2D.D2D12DaffinetransformInterpolationMode, int>)@this->LpVtbl[4])(@this, interpolationMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBorderMode(this ComPtr<IDCompositionAffineTransform2DEffect> thisVtbl, Silk.NET.Direct2D.BorderMode borderMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Silk.NET.Direct2D.BorderMode, int>)@this->LpVtbl[5])(@this, borderMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransformMatrix(this ComPtr<IDCompositionAffineTransform2DEffect> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transformMatrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[6])(@this, transformMatrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTransformMatrixElement(this ComPtr<IDCompositionAffineTransform2DEffect> thisVtbl, int row, int column, float value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, int, int, float, int>)@this->LpVtbl[8])(@this, row, column, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSharpness(this ComPtr<IDCompositionAffineTransform2DEffect> thisVtbl, float sharpness)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionAffineTransform2DEffect*, float, int>)@this->LpVtbl[10])(@this, sharpness);
        return ret;
    }

}
