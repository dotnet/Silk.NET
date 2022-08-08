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

public unsafe static class Direct3DSwapChain9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Present<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[3])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrontBufferData<TThis>(this TThis thisVtbl, IDirect3DSurface9* pDestSurface) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, IDirect3DSurface9*, int>)@this->LpVtbl[4])(@this, pDestSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrontBufferData<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pDestSurface) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, IDirect3DSurface9*, int>)@this->LpVtbl[4])(@this, pDestSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackBuffer<TThis>(this TThis thisVtbl, uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[5])(@this, iBackBuffer, Type, ppBackBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackBuffer<TThis>(this TThis thisVtbl, uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[5])(@this, iBackBuffer, Type, ppBackBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRasterStatus<TThis>(this TThis thisVtbl, RasterStatus* pRasterStatus) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, RasterStatus*, int>)@this->LpVtbl[6])(@this, pRasterStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRasterStatus<TThis>(this TThis thisVtbl, ref RasterStatus pRasterStatus) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, RasterStatus*, int>)@this->LpVtbl[6])(@this, pRasterStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayMode<TThis>(this TThis thisVtbl, Displaymode* pMode) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Displaymode*, int>)@this->LpVtbl[7])(@this, pMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayMode<TThis>(this TThis thisVtbl, ref Displaymode pMode) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Displaymode* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, Displaymode*, int>)@this->LpVtbl[7])(@this, pModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, IDirect3DDevice9** ppDevice) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, IDirect3DDevice9**, int>)@this->LpVtbl[8])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref IDirect3DDevice9* ppDevice) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, IDirect3DDevice9**, int>)@this->LpVtbl[8])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPresentParameters<TThis>(this TThis thisVtbl, PresentParameters* pPresentationParameters) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, PresentParameters*, int>)@this->LpVtbl[9])(@this, pPresentationParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPresentParameters<TThis>(this TThis thisVtbl, ref PresentParameters pPresentationParameters) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DSwapChain9*, PresentParameters*, int>)@this->LpVtbl[9])(@this, pPresentationParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(pSourceRect, pDestRect, hDestWindowOverride, ref pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(pSourceRect, ref pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(pSourceRect, ref pDestRect.GetPinnableReference(), hDestWindowOverride, ref pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(ref pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(ref pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, ref pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(ref pSourceRect.GetPinnableReference(), ref pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static int Present<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(ref pSourceRect.GetPinnableReference(), ref pDestRect.GetPinnableReference(), hDestWindowOverride, ref pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static int GetFrontBufferData<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pDestSurface) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFrontBufferData(ref pDestSurface.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRasterStatus<TThis>(this TThis thisVtbl, Span<RasterStatus> pRasterStatus) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRasterStatus(ref pRasterStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayMode<TThis>(this TThis thisVtbl, Span<Displaymode> pMode) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDisplayMode(ref pMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPresentParameters<TThis>(this TThis thisVtbl, Span<PresentParameters> pPresentationParameters) where TThis : IComVtbl<IDirect3DSwapChain9>
    {
        var @this = (IDirect3DSwapChain9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPresentParameters(ref pPresentationParameters.GetPinnableReference());
    }

}
