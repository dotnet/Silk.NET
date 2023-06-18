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

public unsafe static class DCompositionDevice3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDevice3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionDevice3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionDevice3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Commit(this ComPtr<IDCompositionDevice3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WaitForCommitCompletion(this ComPtr<IDCompositionDevice3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameStatistics(this ComPtr<IDCompositionDevice3> thisVtbl, FRAMESTATISTICS* statistics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, FRAMESTATISTICS*, int>)@this->LpVtbl[5])(@this, statistics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVisual(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionVisual2** visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionVisual2**, int>)@this->LpVtbl[6])(@this, visual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurfaceFactory(this ComPtr<IDCompositionDevice3> thisVtbl, Silk.NET.Core.Native.IUnknown* renderingDevice, IDCompositionSurfaceFactory** surfaceFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, Silk.NET.Core.Native.IUnknown*, IDCompositionSurfaceFactory**, int>)@this->LpVtbl[7])(@this, renderingDevice, surfaceFactory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDCompositionDevice3> thisVtbl, uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionSurface** surface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)@this->LpVtbl[8])(@this, width, height, pixelFormat, alphaMode, surface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVirtualSurface(this ComPtr<IDCompositionDevice3> thisVtbl, uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)@this->LpVtbl[9])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTranslateTransform(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionTranslateTransform** translateTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTranslateTransform**, int>)@this->LpVtbl[10])(@this, translateTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateScaleTransform(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionScaleTransform** scaleTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionScaleTransform**, int>)@this->LpVtbl[11])(@this, scaleTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRotateTransform(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionRotateTransform** rotateTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionRotateTransform**, int>)@this->LpVtbl[12])(@this, rotateTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSkewTransform(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionSkewTransform** skewTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionSkewTransform**, int>)@this->LpVtbl[13])(@this, skewTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMatrixTransform(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionMatrixTransform** matrixTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionMatrixTransform**, int>)@this->LpVtbl[14])(@this, matrixTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformGroup(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[15])(@this, transforms, elements, transformGroup);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTranslateTransform3D(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionTranslateTransform3D** translateTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTranslateTransform3D**, int>)@this->LpVtbl[16])(@this, translateTransform3D);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateScaleTransform3D(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionScaleTransform3D** scaleTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionScaleTransform3D**, int>)@this->LpVtbl[17])(@this, scaleTransform3D);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRotateTransform3D(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionRotateTransform3D** rotateTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionRotateTransform3D**, int>)@this->LpVtbl[18])(@this, rotateTransform3D);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMatrixTransform3D(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionMatrixTransform3D** matrixTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionMatrixTransform3D**, int>)@this->LpVtbl[19])(@this, matrixTransform3D);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransform3DGroup(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[20])(@this, transforms3D, elements, transform3DGroup);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffectGroup(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionEffectGroup** effectGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionEffectGroup**, int>)@this->LpVtbl[21])(@this, effectGroup);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleClip(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionRectangleClip** clip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionRectangleClip**, int>)@this->LpVtbl[22])(@this, clip);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAnimation(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionAnimation** animation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionAnimation**, int>)@this->LpVtbl[23])(@this, animation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGaussianBlurEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionGaussianBlurEffect** gaussianBlurEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionGaussianBlurEffect**, int>)@this->LpVtbl[24])(@this, gaussianBlurEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBrightnessEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionBrightnessEffect** brightnessEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionBrightnessEffect**, int>)@this->LpVtbl[25])(@this, brightnessEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorMatrixEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionColorMatrixEffect** colorMatrixEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionColorMatrixEffect**, int>)@this->LpVtbl[26])(@this, colorMatrixEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateShadowEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionShadowEffect** shadowEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionShadowEffect**, int>)@this->LpVtbl[27])(@this, shadowEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateHueRotationEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionHueRotationEffect** hueRotationEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionHueRotationEffect**, int>)@this->LpVtbl[28])(@this, hueRotationEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSaturationEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionSaturationEffect** saturationEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionSaturationEffect**, int>)@this->LpVtbl[29])(@this, saturationEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTurbulenceEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionTurbulenceEffect** turbulenceEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTurbulenceEffect**, int>)@this->LpVtbl[30])(@this, turbulenceEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearTransferEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionLinearTransferEffect** linearTransferEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionLinearTransferEffect**, int>)@this->LpVtbl[31])(@this, linearTransferEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTableTransferEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionTableTransferEffect** tableTransferEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionTableTransferEffect**, int>)@this->LpVtbl[32])(@this, tableTransferEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompositeEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionCompositeEffect** compositeEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionCompositeEffect**, int>)@this->LpVtbl[33])(@this, compositeEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBlendEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionBlendEffect** blendEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionBlendEffect**, int>)@this->LpVtbl[34])(@this, blendEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateArithmeticCompositeEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionArithmeticCompositeEffect** arithmeticCompositeEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionArithmeticCompositeEffect**, int>)@this->LpVtbl[35])(@this, arithmeticCompositeEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAffineTransform2DEffect(this ComPtr<IDCompositionDevice3> thisVtbl, IDCompositionAffineTransform2DEffect** affineTransform2dEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice3*, IDCompositionAffineTransform2DEffect**, int>)@this->LpVtbl[36])(@this, affineTransform2dEffect);
        return ret;
    }

}
