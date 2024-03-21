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

namespace Silk.NET.Direct3D9;

public unsafe static class Direct3DSwapChain9ExVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrontBufferData(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, IDirect3DSurface9* pDestSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, IDirect3DSurface9*, int>)@this->LpVtbl[4])(@this, pDestSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrontBufferData(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref IDirect3DSurface9 pDestSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, IDirect3DSurface9*, int>)@this->LpVtbl[4])(@this, pDestSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackBuffer(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[5])(@this, iBackBuffer, Type, ppBackBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackBuffer(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[5])(@this, iBackBuffer, Type, ppBackBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRasterStatus(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, RasterStatus* pRasterStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, RasterStatus*, int>)@this->LpVtbl[6])(@this, pRasterStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRasterStatus(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref RasterStatus pRasterStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, RasterStatus*, int>)@this->LpVtbl[6])(@this, pRasterStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayMode(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Displaymode* pMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymode*, int>)@this->LpVtbl[7])(@this, pMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayMode(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref Displaymode pMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Displaymode* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymode*, int>)@this->LpVtbl[7])(@this, pModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, IDirect3DDevice9** ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, IDirect3DDevice9**, int>)@this->LpVtbl[8])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref IDirect3DDevice9* ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, IDirect3DDevice9**, int>)@this->LpVtbl[8])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPresentParameters(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, PresentParameters* pPresentationParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, PresentParameters*, int>)@this->LpVtbl[9])(@this, pPresentationParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPresentParameters(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref PresentParameters pPresentationParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, PresentParameters*, int>)@this->LpVtbl[9])(@this, pPresentationParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastPresentCount(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, uint* pLastPresentCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint*, int>)@this->LpVtbl[10])(@this, pLastPresentCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLastPresentCount(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref uint pLastPresentCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pLastPresentCountPtr = &pLastPresentCount)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, uint*, int>)@this->LpVtbl[10])(@this, pLastPresentCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPresentStats(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Presentstats* pPresentationStatistics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Presentstats*, int>)@this->LpVtbl[11])(@this, pPresentationStatistics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPresentStats(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref Presentstats pPresentationStatistics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Presentstats* pPresentationStatisticsPtr = &pPresentationStatistics)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Presentstats*, int>)@this->LpVtbl[11])(@this, pPresentationStatisticsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Displaymodeex* pMode, Displayrotation* pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[12])(@this, pMode, pRotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Displaymodeex* pMode, ref Displayrotation pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Displayrotation* pRotationPtr = &pRotation)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[12])(@this, pMode, pRotationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref Displaymodeex pMode, Displayrotation* pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Displaymodeex* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[12])(@this, pModePtr, pRotation);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeEx(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref Displaymodeex pMode, ref Displayrotation pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Displaymodeex* pModePtr = &pMode)
        {
            fixed (Displayrotation* pRotationPtr = &pRotation)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9Ex*, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[12])(@this, pModePtr, pRotationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(pSourceRect, pDestRect, hDestWindowOverride, in pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(pSourceRect, in pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(pSourceRect, in pDestRect.GetPinnableReference(), hDestWindowOverride, in pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(in pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(in pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, in pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(in pSourceRect.GetPinnableReference(), in pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static int Present(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(in pSourceRect.GetPinnableReference(), in pDestRect.GetPinnableReference(), hDestWindowOverride, in pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static int GetFrontBufferData<TI0>(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ComPtr<TI0> pDestSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFrontBufferData((IDirect3DSurface9*) pDestSurface.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int GetFrontBufferData(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Span<IDirect3DSurface9> pDestSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrontBufferData(ref pDestSurface.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBackBuffer<TI0>(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, uint iBackBuffer, BackbufferType Type, ref ComPtr<TI0> ppBackBuffer) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBackBuffer(iBackBuffer, Type, (IDirect3DSurface9**) ppBackBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetRasterStatus(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Span<RasterStatus> pRasterStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRasterStatus(ref pRasterStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayMode(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Span<Displaymode> pMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayMode(ref pMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDevice((IDirect3DDevice9**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetPresentParameters(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Span<PresentParameters> pPresentationParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPresentParameters(ref pPresentationParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLastPresentCount(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Span<uint> pLastPresentCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLastPresentCount(ref pLastPresentCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPresentStats(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Span<Presentstats> pPresentationStatistics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPresentStats(ref pPresentationStatistics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Displaymodeex* pMode, Span<Displayrotation> pRotation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeEx(pMode, ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Span<Displaymodeex> pMode, Displayrotation* pRotation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeEx(ref pMode.GetPinnableReference(), pRotation);
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeEx(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl, Span<Displaymodeex> pMode, Span<Displayrotation> pRotation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeEx(ref pMode.GetPinnableReference(), ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirect3DSwapChain9Ex> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
