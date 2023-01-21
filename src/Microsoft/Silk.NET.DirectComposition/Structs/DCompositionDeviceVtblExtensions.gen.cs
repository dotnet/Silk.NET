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
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDevice> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDevice> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDevice> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static int GetFrameStatistics(this ComPtr<IDCompositionDevice> thisVtbl, ref FRAMESTATISTICS statistics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FRAMESTATISTICS* statisticsPtr = &statistics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, FRAMESTATISTICS*, int>)@this->LpVtbl[5])(@this, statisticsPtr);
        }
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
    public static unsafe int CreateTargetForHwnd(this ComPtr<IDCompositionDevice> thisVtbl, nint hwnd, Silk.NET.Core.Bool32 topmost, ref IDCompositionTarget* target)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionTarget** targetPtr = &target)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, nint, Silk.NET.Core.Bool32, IDCompositionTarget**, int>)@this->LpVtbl[6])(@this, hwnd, topmost, targetPtr);
        }
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
    public static unsafe int CreateVisual(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionVisual* visual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionVisual** visualPtr = &visual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionVisual**, int>)@this->LpVtbl[7])(@this, visualPtr);
        }
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
    public static unsafe int CreateSurface(this ComPtr<IDCompositionDevice> thisVtbl, uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref IDCompositionSurface* surface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionSurface** surfacePtr = &surface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionSurface**, int>)@this->LpVtbl[8])(@this, width, height, pixelFormat, alphaMode, surfacePtr);
        }
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
    public static unsafe int CreateVirtualSurface(this ComPtr<IDCompositionDevice> thisVtbl, uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref IDCompositionVirtualSurface* virtualSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionVirtualSurface** virtualSurfacePtr = &virtualSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, uint, uint, Silk.NET.DXGI.Format, Silk.NET.DXGI.AlphaMode, IDCompositionVirtualSurface**, int>)@this->LpVtbl[9])(@this, initialWidth, initialHeight, pixelFormat, alphaMode, virtualSurfacePtr);
        }
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
    public static unsafe int CreateSurfaceFromHandle(this ComPtr<IDCompositionDevice> thisVtbl, void* handle, ref Silk.NET.Core.Native.IUnknown* surface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** surfacePtr = &surface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, void*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, handle, surfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurfaceFromHandle<T0>(this ComPtr<IDCompositionDevice> thisVtbl, ref T0 handle, Silk.NET.Core.Native.IUnknown** surface) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* handlePtr = &handle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, void*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, handlePtr, surface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurfaceFromHandle<T0>(this ComPtr<IDCompositionDevice> thisVtbl, ref T0 handle, ref Silk.NET.Core.Native.IUnknown* surface) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* handlePtr = &handle)
        {
            fixed (Silk.NET.Core.Native.IUnknown** surfacePtr = &surface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, void*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[10])(@this, handlePtr, surfacePtr);
            }
        }
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
    public static unsafe int CreateSurfaceFromHwnd(this ComPtr<IDCompositionDevice> thisVtbl, nint hwnd, ref Silk.NET.Core.Native.IUnknown* surface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** surfacePtr = &surface)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, nint, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[11])(@this, hwnd, surfacePtr);
        }
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
    public static unsafe int CreateTranslateTransform(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionTranslateTransform* translateTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionTranslateTransform** translateTransformPtr = &translateTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTranslateTransform**, int>)@this->LpVtbl[12])(@this, translateTransformPtr);
        }
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
    public static unsafe int CreateScaleTransform(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionScaleTransform* scaleTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionScaleTransform** scaleTransformPtr = &scaleTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionScaleTransform**, int>)@this->LpVtbl[13])(@this, scaleTransformPtr);
        }
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
    public static unsafe int CreateRotateTransform(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionRotateTransform* rotateTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionRotateTransform** rotateTransformPtr = &rotateTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRotateTransform**, int>)@this->LpVtbl[14])(@this, rotateTransformPtr);
        }
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
    public static unsafe int CreateSkewTransform(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionSkewTransform* skewTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionSkewTransform** skewTransformPtr = &skewTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionSkewTransform**, int>)@this->LpVtbl[15])(@this, skewTransformPtr);
        }
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
    public static unsafe int CreateMatrixTransform(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionMatrixTransform* matrixTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionMatrixTransform** matrixTransformPtr = &matrixTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionMatrixTransform**, int>)@this->LpVtbl[16])(@this, matrixTransformPtr);
        }
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
    public static unsafe int CreateTransformGroup(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionTransform** transforms, uint elements, ref IDCompositionTransform* transformGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionTransform** transformGroupPtr = &transformGroup)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[17])(@this, transforms, elements, transformGroupPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformGroup(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionTransform* transforms, uint elements, IDCompositionTransform** transformGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionTransform** transformsPtr = &transforms)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[17])(@this, transformsPtr, elements, transformGroup);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformGroup(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionTransform* transforms, uint elements, ref IDCompositionTransform* transformGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionTransform** transformsPtr = &transforms)
        {
            fixed (IDCompositionTransform** transformGroupPtr = &transformGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform**, uint, IDCompositionTransform**, int>)@this->LpVtbl[17])(@this, transformsPtr, elements, transformGroupPtr);
            }
        }
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
    public static unsafe int CreateTranslateTransform3D(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionTranslateTransform3D* translateTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionTranslateTransform3D** translateTransform3DPtr = &translateTransform3D)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTranslateTransform3D**, int>)@this->LpVtbl[18])(@this, translateTransform3DPtr);
        }
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
    public static unsafe int CreateScaleTransform3D(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionScaleTransform3D* scaleTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionScaleTransform3D** scaleTransform3DPtr = &scaleTransform3D)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionScaleTransform3D**, int>)@this->LpVtbl[19])(@this, scaleTransform3DPtr);
        }
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
    public static unsafe int CreateRotateTransform3D(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionRotateTransform3D* rotateTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionRotateTransform3D** rotateTransform3DPtr = &rotateTransform3D)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRotateTransform3D**, int>)@this->LpVtbl[20])(@this, rotateTransform3DPtr);
        }
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
    public static unsafe int CreateMatrixTransform3D(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionMatrixTransform3D* matrixTransform3D)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionMatrixTransform3D** matrixTransform3DPtr = &matrixTransform3D)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionMatrixTransform3D**, int>)@this->LpVtbl[21])(@this, matrixTransform3DPtr);
        }
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
    public static unsafe int CreateTransform3DGroup(this ComPtr<IDCompositionDevice> thisVtbl, IDCompositionTransform3D** transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionTransform3D** transform3DGroupPtr = &transform3DGroup)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[22])(@this, transforms3D, elements, transform3DGroupPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransform3DGroup(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionTransform3D* transforms3D, uint elements, IDCompositionTransform3D** transform3DGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionTransform3D** transforms3DPtr = &transforms3D)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[22])(@this, transforms3DPtr, elements, transform3DGroup);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransform3DGroup(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionTransform3D* transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionTransform3D** transforms3DPtr = &transforms3D)
        {
            fixed (IDCompositionTransform3D** transform3DGroupPtr = &transform3DGroup)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionTransform3D**, uint, IDCompositionTransform3D**, int>)@this->LpVtbl[22])(@this, transforms3DPtr, elements, transform3DGroupPtr);
            }
        }
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
    public static unsafe int CreateEffectGroup(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionEffectGroup* effectGroup)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionEffectGroup** effectGroupPtr = &effectGroup)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionEffectGroup**, int>)@this->LpVtbl[23])(@this, effectGroupPtr);
        }
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
    public static unsafe int CreateRectangleClip(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionRectangleClip* clip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionRectangleClip** clipPtr = &clip)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionRectangleClip**, int>)@this->LpVtbl[24])(@this, clipPtr);
        }
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
    public static unsafe int CreateAnimation(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionAnimation* animation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDCompositionAnimation** animationPtr = &animation)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, IDCompositionAnimation**, int>)@this->LpVtbl[25])(@this, animationPtr);
        }
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

    /// <summary>To be documented.</summary>
    public static int CheckDeviceState(this ComPtr<IDCompositionDevice> thisVtbl, ref int pfValid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pfValidPtr = &pfValid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDevice*, int*, int>)@this->LpVtbl[26])(@this, pfValidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDevice> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionDevice> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetFrameStatistics(this ComPtr<IDCompositionDevice> thisVtbl, Span<FRAMESTATISTICS> statistics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrameStatistics(ref statistics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateTargetForHwnd<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, nint hwnd, Silk.NET.Core.Bool32 topmost, ref ComPtr<TI0> target) where TI0 : unmanaged, IComVtbl<IDCompositionTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTargetForHwnd(hwnd, topmost, (IDCompositionTarget**) target.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateVisual<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> visual) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVisual((IDCompositionVisual**) visual.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateSurface<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, uint width, uint height, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref ComPtr<TI0> surface) where TI0 : unmanaged, IComVtbl<IDCompositionSurface>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSurface(width, height, pixelFormat, alphaMode, (IDCompositionSurface**) surface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateVirtualSurface<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, uint initialWidth, uint initialHeight, Silk.NET.DXGI.Format pixelFormat, Silk.NET.DXGI.AlphaMode alphaMode, ref ComPtr<TI0> virtualSurface) where TI0 : unmanaged, IComVtbl<IDCompositionVirtualSurface>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVirtualSurface(initialWidth, initialHeight, pixelFormat, alphaMode, (IDCompositionVirtualSurface**) virtualSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurfaceFromHandle<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, void* handle, ref ComPtr<TI0> surface) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSurfaceFromHandle(handle, (Silk.NET.Core.Native.IUnknown**) surface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurfaceFromHandle<T0>(this ComPtr<IDCompositionDevice> thisVtbl, Span<T0> handle, Silk.NET.Core.Native.IUnknown** surface) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSurfaceFromHandle(ref handle.GetPinnableReference(), surface);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSurfaceFromHandle<T0, TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref T0 handle, ref ComPtr<TI0> surface) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSurfaceFromHandle(ref handle, (Silk.NET.Core.Native.IUnknown**) surface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSurfaceFromHandle<T0>(this ComPtr<IDCompositionDevice> thisVtbl, Span<T0> handle, ref Silk.NET.Core.Native.IUnknown* surface) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateSurfaceFromHandle(ref handle.GetPinnableReference(), ref surface);
    }

    /// <summary>To be documented.</summary>
    public static int CreateSurfaceFromHwnd<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, nint hwnd, ref ComPtr<TI0> surface) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSurfaceFromHwnd(hwnd, (Silk.NET.Core.Native.IUnknown**) surface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateTranslateTransform<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> translateTransform) where TI0 : unmanaged, IComVtbl<IDCompositionTranslateTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTranslateTransform((IDCompositionTranslateTransform**) translateTransform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateScaleTransform<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> scaleTransform) where TI0 : unmanaged, IComVtbl<IDCompositionScaleTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateScaleTransform((IDCompositionScaleTransform**) scaleTransform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateRotateTransform<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> rotateTransform) where TI0 : unmanaged, IComVtbl<IDCompositionRotateTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRotateTransform((IDCompositionRotateTransform**) rotateTransform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateSkewTransform<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> skewTransform) where TI0 : unmanaged, IComVtbl<IDCompositionSkewTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateSkewTransform((IDCompositionSkewTransform**) skewTransform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateMatrixTransform<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> matrixTransform) where TI0 : unmanaged, IComVtbl<IDCompositionMatrixTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMatrixTransform((IDCompositionMatrixTransform**) matrixTransform.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateTransformGroup<TI0, TI1>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> transforms, uint elements, ref ComPtr<TI1> transformGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformGroup((IDCompositionTransform**) transforms.GetAddressOf(), elements, (IDCompositionTransform**) transformGroup.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformGroup<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> transforms, uint elements, ref IDCompositionTransform* transformGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformGroup((IDCompositionTransform**) transforms.GetAddressOf(), elements, ref transformGroup);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformGroup<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionTransform* transforms, uint elements, ref ComPtr<TI0> transformGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransformGroup(ref transforms, elements, (IDCompositionTransform**) transformGroup.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateTranslateTransform3D<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> translateTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionTranslateTransform3D>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTranslateTransform3D((IDCompositionTranslateTransform3D**) translateTransform3D.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateScaleTransform3D<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> scaleTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionScaleTransform3D>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateScaleTransform3D((IDCompositionScaleTransform3D**) scaleTransform3D.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateRotateTransform3D<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> rotateTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionRotateTransform3D>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRotateTransform3D((IDCompositionRotateTransform3D**) rotateTransform3D.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateMatrixTransform3D<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> matrixTransform3D) where TI0 : unmanaged, IComVtbl<IDCompositionMatrixTransform3D>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMatrixTransform3D((IDCompositionMatrixTransform3D**) matrixTransform3D.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateTransform3DGroup<TI0, TI1>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> transforms3D, uint elements, ref ComPtr<TI1> transform3DGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransform3DGroup((IDCompositionTransform3D**) transforms3D.GetAddressOf(), elements, (IDCompositionTransform3D**) transform3DGroup.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransform3DGroup<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> transforms3D, uint elements, ref IDCompositionTransform3D* transform3DGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransform3DGroup((IDCompositionTransform3D**) transforms3D.GetAddressOf(), elements, ref transform3DGroup);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransform3DGroup<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref IDCompositionTransform3D* transforms3D, uint elements, ref ComPtr<TI0> transform3DGroup) where TI0 : unmanaged, IComVtbl<IDCompositionTransform3D>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTransform3DGroup(ref transforms3D, elements, (IDCompositionTransform3D**) transform3DGroup.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateEffectGroup<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> effectGroup) where TI0 : unmanaged, IComVtbl<IDCompositionEffectGroup>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEffectGroup((IDCompositionEffectGroup**) effectGroup.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateRectangleClip<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> clip) where TI0 : unmanaged, IComVtbl<IDCompositionRectangleClip>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRectangleClip((IDCompositionRectangleClip**) clip.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateAnimation<TI0>(this ComPtr<IDCompositionDevice> thisVtbl, ref ComPtr<TI0> animation) where TI0 : unmanaged, IComVtbl<IDCompositionAnimation>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateAnimation((IDCompositionAnimation**) animation.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceState(this ComPtr<IDCompositionDevice> thisVtbl, Span<int> pfValid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CheckDeviceState(ref pfValid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionDevice> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
