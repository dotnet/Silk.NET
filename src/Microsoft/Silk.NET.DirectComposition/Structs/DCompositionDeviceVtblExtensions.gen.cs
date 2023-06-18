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

public unsafe static class DCompositionDeviceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDevice> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Commit(this ComPtr<IDCompositionDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WaitForCommitCompletion(this ComPtr<IDCompositionDevice> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrameStatistics(this ComPtr<IDCompositionDevice> thisVtbl, FRAMESTATISTICS* statistics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, FRAMESTATISTICS*, int>)@this->LpVtbl[5])(@this, statistics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTargetForHwnd(this ComPtr<IDCompositionDevice> thisVtbl, nint hwnd, Silk.NET.Core.Bool32 topmost, IDCompositionTarget** target)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, nint, Silk.NET.Core.Bool32, IDCompositionTarget**, int>)@this->LpVtbl[6])(@this, hwnd, topmost, target);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVisual(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionVisual** visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionVisual**, int>)@this->LpVtbl[7])(@this, visual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurface(this ComPtr<IDCompositionDevice> thisVtbl, uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionSurface** surface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)@this->LpVtbl[8])(@this, width, height, pixelFormat, alphaMode, surface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVirtualSurface(this ComPtr<IDCompositionDevice> thisVtbl, uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, IDCompositionVirtualSurface** virtualSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)@this->LpVtbl[9])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurfaceFromHandle(this ComPtr<IDCompositionDevice> thisVtbl, void* handle, Silk.NET.Core.Native.IUnknown** surface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, void*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, handle, surface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurfaceFromHwnd(this ComPtr<IDCompositionDevice> thisVtbl, nint hwnd, Silk.NET.Core.Native.IUnknown** surface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, nint, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[11])(@this, hwnd, surface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTranslateTransform(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionTranslateTransform** translateTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTranslateTransform**, int>)@this->LpVtbl[12])(@this, translateTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateScaleTransform(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionScaleTransform** scaleTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionScaleTransform**, int>)@this->LpVtbl[13])(@this, scaleTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRotateTransform(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionRotateTransform** rotateTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRotateTransform**, int>)@this->LpVtbl[14])(@this, rotateTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSkewTransform(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionSkewTransform** skewTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionSkewTransform**, int>)@this->LpVtbl[15])(@this, skewTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMatrixTransform(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionMatrixTransform** matrixTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionMatrixTransform**, int>)@this->LpVtbl[16])(@this, matrixTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformGroup(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionTransform** transforms, uint elements, IDCompositionTransform** transformGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[17])(@this, transforms, elements, transformGroup);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTranslateTransform3D(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionTranslateTransform3D** translateTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTranslateTransform3D**, int>)@this->LpVtbl[18])(@this, translateTransform3D);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateScaleTransform3D(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionScaleTransform3D** scaleTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionScaleTransform3D**, int>)@this->LpVtbl[19])(@this, scaleTransform3D);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRotateTransform3D(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionRotateTransform3D** rotateTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRotateTransform3D**, int>)@this->LpVtbl[20])(@this, rotateTransform3D);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMatrixTransform3D(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionMatrixTransform3D** matrixTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionMatrixTransform3D**, int>)@this->LpVtbl[21])(@this, matrixTransform3D);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransform3DGroup(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionTransform3D** transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[22])(@this, transforms3D, elements, transform3DGroup);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffectGroup(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionEffectGroup** effectGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionEffectGroup**, int>)@this->LpVtbl[23])(@this, effectGroup);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRectangleClip(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionRectangleClip** clip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRectangleClip**, int>)@this->LpVtbl[24])(@this, clip);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAnimation(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionAnimation** animation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionAnimation**, int>)@this->LpVtbl[25])(@this, animation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckDeviceState(this ComPtr<IDCompositionDevice> thisVtbl, int* pfValid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, int*, int>)@this->LpVtbl[26])(@this, pfValid);
        return ret;
    }

}
