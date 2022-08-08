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

public unsafe static class Direct3DDevice9ExVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TestCooperativeLevel<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetAvailableTextureMem<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EvictManagedResources<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDirect3D<TThis>(this TThis thisVtbl, IDirect3D9** ppD3D9) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3D9**, int>)@this->LpVtbl[6])(@this, ppD3D9);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDirect3D<TThis>(this TThis thisVtbl, ref IDirect3D9* ppD3D9) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3D9** ppD3D9Ptr = &ppD3D9)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3D9**, int>)@this->LpVtbl[6])(@this, ppD3D9Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceCaps<TThis>(this TThis thisVtbl, Caps9* pCaps) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Caps9*, int>)@this->LpVtbl[7])(@this, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceCaps<TThis>(this TThis thisVtbl, ref Caps9 pCaps) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Caps9* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Caps9*, int>)@this->LpVtbl[7])(@this, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayMode<TThis>(this TThis thisVtbl, uint iSwapChain, Displaymode* pMode) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, iSwapChain, pMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayMode<TThis>(this TThis thisVtbl, uint iSwapChain, ref Displaymode pMode) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Displaymode* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, iSwapChain, pModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters<TThis>(this TThis thisVtbl, DeviceCreationParameters* pParameters) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, DeviceCreationParameters*, int>)@this->LpVtbl[9])(@this, pParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCreationParameters<TThis>(this TThis thisVtbl, ref DeviceCreationParameters pParameters) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (DeviceCreationParameters* pParametersPtr = &pParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, DeviceCreationParameters*, int>)@this->LpVtbl[9])(@this, pParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCursorProperties<TThis>(this TThis thisVtbl, uint XHotSpot, uint YHotSpot, IDirect3DSurface9* pCursorBitmap) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, IDirect3DSurface9*, int>)@this->LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCursorProperties<TThis>(this TThis thisVtbl, uint XHotSpot, uint YHotSpot, ref IDirect3DSurface9 pCursorBitmap) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pCursorBitmapPtr = &pCursorBitmap)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, IDirect3DSurface9*, int>)@this->LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetCursorPosition<TThis>(this TThis thisVtbl, int X, int Y, uint Flags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int, int, uint, void>)@this->LpVtbl[11])(@this, X, Y, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int ShowCursor<TThis>(this TThis thisVtbl, int bShow) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int, int>)@this->LpVtbl[12])(@this, bShow);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain<TThis>(this TThis thisVtbl, PresentParameters* pPresentationParameters, IDirect3DSwapChain9** pSwapChain) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParameters, pSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain<TThis>(this TThis thisVtbl, PresentParameters* pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParameters, pSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain<TThis>(this TThis thisVtbl, ref PresentParameters pPresentationParameters, IDirect3DSwapChain9** pSwapChain) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain<TThis>(this TThis thisVtbl, ref PresentParameters pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChainPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChain<TThis>(this TThis thisVtbl, uint iSwapChain, IDirect3DSwapChain9** pSwapChain) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSwapChain9**, int>)@this->LpVtbl[14])(@this, iSwapChain, pSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChain<TThis>(this TThis thisVtbl, uint iSwapChain, ref IDirect3DSwapChain9* pSwapChain) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSwapChain9**, int>)@this->LpVtbl[14])(@this, iSwapChain, pSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumberOfSwapChains<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset<TThis>(this TThis thisVtbl, PresentParameters* pPresentationParameters) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, int>)@this->LpVtbl[16])(@this, pPresentationParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset<TThis>(this TThis thisVtbl, ref PresentParameters pPresentationParameters) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, int>)@this->LpVtbl[16])(@this, pPresentationParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Present<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackBuffer<TThis>(this TThis thisVtbl, uint iSwapChain, uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackBuffer<TThis>(this TThis thisVtbl, uint iSwapChain, uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRasterStatus<TThis>(this TThis thisVtbl, uint iSwapChain, RasterStatus* pRasterStatus) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, RasterStatus*, int>)@this->LpVtbl[19])(@this, iSwapChain, pRasterStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRasterStatus<TThis>(this TThis thisVtbl, uint iSwapChain, ref RasterStatus pRasterStatus) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, RasterStatus*, int>)@this->LpVtbl[19])(@this, iSwapChain, pRasterStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDialogBoxMode<TThis>(this TThis thisVtbl, int bEnableDialogs) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int, int>)@this->LpVtbl[20])(@this, bEnableDialogs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetGammaRamp<TThis>(this TThis thisVtbl, uint iSwapChain, uint Flags, Gammaramp* pRamp) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Gammaramp*, void>)@this->LpVtbl[21])(@this, iSwapChain, Flags, pRamp);
    }

    /// <summary>To be documented.</summary>
    public static void SetGammaRamp<TThis>(this TThis thisVtbl, uint iSwapChain, uint Flags, ref Gammaramp pRamp) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        fixed (Gammaramp* pRampPtr = &pRamp)
        {
            ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Gammaramp*, void>)@this->LpVtbl[21])(@this, iSwapChain, Flags, pRampPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetGammaRamp<TThis>(this TThis thisVtbl, uint iSwapChain, Gammaramp* pRamp) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Gammaramp*, void>)@this->LpVtbl[22])(@this, iSwapChain, pRamp);
    }

    /// <summary>To be documented.</summary>
    public static void GetGammaRamp<TThis>(this TThis thisVtbl, uint iSwapChain, ref Gammaramp pRamp) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        fixed (Gammaramp* pRampPtr = &pRamp)
        {
            ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Gammaramp*, void>)@this->LpVtbl[22])(@this, iSwapChain, pRampPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTexture<TThis>(this TThis thisVtbl, uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTexture<TThis>(this TThis thisVtbl, uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTexture<TThis>(this TThis thisVtbl, uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTexture<TThis>(this TThis thisVtbl, uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVolumeTexture<TThis>(this TThis thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVolumeTexture<TThis>(this TThis thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVolumeTexture<TThis>(this TThis thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVolumeTexture<TThis>(this TThis thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCubeTexture<TThis>(this TThis thisVtbl, uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCubeTexture<TThis>(this TThis thisVtbl, uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCubeTexture<TThis>(this TThis thisVtbl, uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCubeTexture<TThis>(this TThis thisVtbl, uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TThis>(this TThis thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TThis>(this TThis thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TThis>(this TThis thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TThis>(this TThis thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIndexBuffer<TThis>(this TThis thisVtbl, uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIndexBuffer<TThis>(this TThis thisVtbl, uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIndexBuffer<TThis>(this TThis thisVtbl, uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIndexBuffer<TThis>(this TThis thisVtbl, uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTarget<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, IDirect3DSurface9** ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTarget<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, IDirect3DSurface9** ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTarget<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, ref IDirect3DSurface9* ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTarget<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, IDirect3DSurface9** ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, IDirect3DSurface9** ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, ref IDirect3DSurface9* ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPoint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPoint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPoint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPointPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPoint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPoint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UpdateSurface<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, ref Silk.NET.Maths.Vector2D<int> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTexture<TThis>(this TThis thisVtbl, IDirect3DBaseTexture9* pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexture, pDestinationTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTexture<TThis>(this TThis thisVtbl, IDirect3DBaseTexture9* pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexture, pDestinationTexturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTexture<TThis>(this TThis thisVtbl, ref IDirect3DBaseTexture9 pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexture);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UpdateTexture<TThis>(this TThis thisVtbl, ref IDirect3DBaseTexture9 pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
        {
            fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexturePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTargetData<TThis>(this TThis thisVtbl, IDirect3DSurface9* pRenderTarget, IDirect3DSurface9* pDestSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTarget, pDestSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTargetData<TThis>(this TThis thisVtbl, IDirect3DSurface9* pRenderTarget, ref IDirect3DSurface9 pDestSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTarget, pDestSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTargetData<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pRenderTarget, IDirect3DSurface9* pDestSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTargetPtr, pDestSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderTargetData<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pRenderTarget, ref IDirect3DSurface9 pDestSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTargetPtr, pDestSurfacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFrontBufferData<TThis>(this TThis thisVtbl, uint iSwapChain, IDirect3DSurface9* pDestSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[33])(@this, iSwapChain, pDestSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrontBufferData<TThis>(this TThis thisVtbl, uint iSwapChain, ref IDirect3DSurface9 pDestSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[33])(@this, iSwapChain, pDestSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRectPtr, Filter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRect, Filter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRect, Filter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRectPtr, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRect, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, IDirect3DSurface9* pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StretchRect<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSourceSurface, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, ref Silk.NET.Maths.Rectangle<int> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSurface, Silk.NET.Maths.Rectangle<int>* pRect, uint color) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurface, pRect, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSurface, ref Silk.NET.Maths.Rectangle<int> pRect, uint color) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurface, pRectPtr, color);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSurface, Silk.NET.Maths.Rectangle<int>* pRect, uint color) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurfacePtr, pRect, color);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ColorFill<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSurface, ref Silk.NET.Maths.Rectangle<int> pRect, uint color) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Rectangle<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurfacePtr, pRectPtr, color);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, void** pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurface<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetRenderTarget<TThis>(this TThis thisVtbl, uint RenderTargetIndex, IDirect3DSurface9* pRenderTarget) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[37])(@this, RenderTargetIndex, pRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderTarget<TThis>(this TThis thisVtbl, uint RenderTargetIndex, ref IDirect3DSurface9 pRenderTarget) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[37])(@this, RenderTargetIndex, pRenderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTarget<TThis>(this TThis thisVtbl, uint RenderTargetIndex, IDirect3DSurface9** ppRenderTarget) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9**, int>)@this->LpVtbl[38])(@this, RenderTargetIndex, ppRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTarget<TThis>(this TThis thisVtbl, uint RenderTargetIndex, ref IDirect3DSurface9* ppRenderTarget) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppRenderTargetPtr = &ppRenderTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9**, int>)@this->LpVtbl[38])(@this, RenderTargetIndex, ppRenderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDepthStencilSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pNewZStencil) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, int>)@this->LpVtbl[39])(@this, pNewZStencil);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDepthStencilSurface<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pNewZStencil) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pNewZStencilPtr = &pNewZStencil)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, int>)@this->LpVtbl[39])(@this, pNewZStencilPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDepthStencilSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9** ppZStencilSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9**, int>)@this->LpVtbl[40])(@this, ppZStencilSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDepthStencilSurface<TThis>(this TThis thisVtbl, ref IDirect3DSurface9* ppZStencilSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppZStencilSurfacePtr = &ppZStencilSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9**, int>)@this->LpVtbl[40])(@this, ppZStencilSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginScene<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[41])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndScene<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[42])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clear<TThis>(this TThis thisVtbl, uint Count, Rect* pRects, uint Flags, uint Color, float Z, uint Stencil) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Rect*, uint, uint, float, uint, int>)@this->LpVtbl[43])(@this, Count, pRects, Flags, Color, Z, Stencil);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Clear<TThis>(this TThis thisVtbl, uint Count, ref Rect pRects, uint Flags, uint Color, float Z, uint Stencil) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Rect* pRectsPtr = &pRects)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Rect*, uint, uint, float, uint, int>)@this->LpVtbl[43])(@this, Count, pRectsPtr, Flags, Color, Z, Stencil);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransform<TThis>(this TThis thisVtbl, Transformstatetype State, System.Numerics.Matrix4x4* pMatrix) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[44])(@this, State, pMatrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTransform<TThis>(this TThis thisVtbl, Transformstatetype State, ref System.Numerics.Matrix4x4 pMatrix) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (System.Numerics.Matrix4x4* pMatrixPtr = &pMatrix)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[44])(@this, State, pMatrixPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTransform<TThis>(this TThis thisVtbl, Transformstatetype State, System.Numerics.Matrix4x4* pMatrix) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[45])(@this, State, pMatrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTransform<TThis>(this TThis thisVtbl, Transformstatetype State, ref System.Numerics.Matrix4x4 pMatrix) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (System.Numerics.Matrix4x4* pMatrixPtr = &pMatrix)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[45])(@this, State, pMatrixPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MultiplyTransform<TThis>(this TThis thisVtbl, Transformstatetype arg0, System.Numerics.Matrix4x4* arg1) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[46])(@this, arg0, arg1);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MultiplyTransform<TThis>(this TThis thisVtbl, Transformstatetype arg0, ref System.Numerics.Matrix4x4 arg1) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (System.Numerics.Matrix4x4* arg1Ptr = &arg1)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[46])(@this, arg0, arg1Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetViewport<TThis>(this TThis thisVtbl, Viewport9* pViewport) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Viewport9*, int>)@this->LpVtbl[47])(@this, pViewport);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetViewport<TThis>(this TThis thisVtbl, ref Viewport9 pViewport) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Viewport9* pViewportPtr = &pViewport)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Viewport9*, int>)@this->LpVtbl[47])(@this, pViewportPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetViewport<TThis>(this TThis thisVtbl, Viewport9* pViewport) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Viewport9*, int>)@this->LpVtbl[48])(@this, pViewport);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetViewport<TThis>(this TThis thisVtbl, ref Viewport9 pViewport) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Viewport9* pViewportPtr = &pViewport)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Viewport9*, int>)@this->LpVtbl[48])(@this, pViewportPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetMaterial<TThis>(this TThis thisVtbl, Material9* pMaterial) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Material9*, int>)@this->LpVtbl[49])(@this, pMaterial);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaterial<TThis>(this TThis thisVtbl, ref Material9 pMaterial) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Material9* pMaterialPtr = &pMaterial)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Material9*, int>)@this->LpVtbl[49])(@this, pMaterialPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaterial<TThis>(this TThis thisVtbl, Material9* pMaterial) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Material9*, int>)@this->LpVtbl[50])(@this, pMaterial);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMaterial<TThis>(this TThis thisVtbl, ref Material9 pMaterial) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Material9* pMaterialPtr = &pMaterial)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Material9*, int>)@this->LpVtbl[50])(@this, pMaterialPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetLight<TThis>(this TThis thisVtbl, uint Index, Light9* arg1) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Light9*, int>)@this->LpVtbl[51])(@this, Index, arg1);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLight<TThis>(this TThis thisVtbl, uint Index, ref Light9 arg1) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Light9* arg1Ptr = &arg1)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Light9*, int>)@this->LpVtbl[51])(@this, Index, arg1Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLight<TThis>(this TThis thisVtbl, uint Index, Light9* arg1) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Light9*, int>)@this->LpVtbl[52])(@this, Index, arg1);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLight<TThis>(this TThis thisVtbl, uint Index, ref Light9 arg1) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Light9* arg1Ptr = &arg1)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Light9*, int>)@this->LpVtbl[52])(@this, Index, arg1Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LightEnable<TThis>(this TThis thisVtbl, uint Index, int Enable) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int, int>)@this->LpVtbl[53])(@this, Index, Enable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLightEnable<TThis>(this TThis thisVtbl, uint Index, int* pEnable) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, int>)@this->LpVtbl[54])(@this, Index, pEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLightEnable<TThis>(this TThis thisVtbl, uint Index, ref int pEnable) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pEnablePtr = &pEnable)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, int>)@this->LpVtbl[54])(@this, Index, pEnablePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetClipPlane<TThis>(this TThis thisVtbl, uint Index, float* pPlane) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, int>)@this->LpVtbl[55])(@this, Index, pPlane);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClipPlane<TThis>(this TThis thisVtbl, uint Index, ref float pPlane) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* pPlanePtr = &pPlane)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, int>)@this->LpVtbl[55])(@this, Index, pPlanePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClipPlane<TThis>(this TThis thisVtbl, uint Index, float* pPlane) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, int>)@this->LpVtbl[56])(@this, Index, pPlane);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClipPlane<TThis>(this TThis thisVtbl, uint Index, ref float pPlane) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* pPlanePtr = &pPlane)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, int>)@this->LpVtbl[56])(@this, Index, pPlanePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderState<TThis>(this TThis thisVtbl, Renderstatetype State, uint Value) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Renderstatetype, uint, int>)@this->LpVtbl[57])(@this, State, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderState<TThis>(this TThis thisVtbl, Renderstatetype State, uint* pValue) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Renderstatetype, uint*, int>)@this->LpVtbl[58])(@this, State, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderState<TThis>(this TThis thisVtbl, Renderstatetype State, ref uint pValue) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Renderstatetype, uint*, int>)@this->LpVtbl[58])(@this, State, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateBlock<TThis>(this TThis thisVtbl, Stateblocktype Type, IDirect3DStateBlock9** ppSB) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Stateblocktype, IDirect3DStateBlock9**, int>)@this->LpVtbl[59])(@this, Type, ppSB);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateBlock<TThis>(this TThis thisVtbl, Stateblocktype Type, ref IDirect3DStateBlock9* ppSB) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Stateblocktype, IDirect3DStateBlock9**, int>)@this->LpVtbl[59])(@this, Type, ppSBPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginStateBlock<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[60])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndStateBlock<TThis>(this TThis thisVtbl, IDirect3DStateBlock9** ppSB) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DStateBlock9**, int>)@this->LpVtbl[61])(@this, ppSB);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndStateBlock<TThis>(this TThis thisVtbl, ref IDirect3DStateBlock9* ppSB) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DStateBlock9**, int>)@this->LpVtbl[61])(@this, ppSBPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetClipStatus<TThis>(this TThis thisVtbl, Clipstatus9* pClipStatus) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Clipstatus9*, int>)@this->LpVtbl[62])(@this, pClipStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClipStatus<TThis>(this TThis thisVtbl, ref Clipstatus9 pClipStatus) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Clipstatus9*, int>)@this->LpVtbl[62])(@this, pClipStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClipStatus<TThis>(this TThis thisVtbl, Clipstatus9* pClipStatus) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Clipstatus9*, int>)@this->LpVtbl[63])(@this, pClipStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClipStatus<TThis>(this TThis thisVtbl, ref Clipstatus9 pClipStatus) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Clipstatus9*, int>)@this->LpVtbl[63])(@this, pClipStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTexture<TThis>(this TThis thisVtbl, uint Stage, IDirect3DBaseTexture9** ppTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9**, int>)@this->LpVtbl[64])(@this, Stage, ppTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTexture<TThis>(this TThis thisVtbl, uint Stage, ref IDirect3DBaseTexture9* ppTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DBaseTexture9** ppTexturePtr = &ppTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9**, int>)@this->LpVtbl[64])(@this, Stage, ppTexturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTexture<TThis>(this TThis thisVtbl, uint Stage, IDirect3DBaseTexture9* pTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9*, int>)@this->LpVtbl[65])(@this, Stage, pTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTexture<TThis>(this TThis thisVtbl, uint Stage, ref IDirect3DBaseTexture9 pTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DBaseTexture9* pTexturePtr = &pTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9*, int>)@this->LpVtbl[65])(@this, Stage, pTexturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextureStageState<TThis>(this TThis thisVtbl, uint Stage, Texturestagestatetype Type, uint* pValue) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Texturestagestatetype, uint*, int>)@this->LpVtbl[66])(@this, Stage, Type, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTextureStageState<TThis>(this TThis thisVtbl, uint Stage, Texturestagestatetype Type, ref uint pValue) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Texturestagestatetype, uint*, int>)@this->LpVtbl[66])(@this, Stage, Type, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextureStageState<TThis>(this TThis thisVtbl, uint Stage, Texturestagestatetype Type, uint Value) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Texturestagestatetype, uint, int>)@this->LpVtbl[67])(@this, Stage, Type, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSamplerState<TThis>(this TThis thisVtbl, uint Sampler, Samplerstatetype Type, uint* pValue) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Samplerstatetype, uint*, int>)@this->LpVtbl[68])(@this, Sampler, Type, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSamplerState<TThis>(this TThis thisVtbl, uint Sampler, Samplerstatetype Type, ref uint pValue) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Samplerstatetype, uint*, int>)@this->LpVtbl[68])(@this, Sampler, Type, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSamplerState<TThis>(this TThis thisVtbl, uint Sampler, Samplerstatetype Type, uint Value) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Samplerstatetype, uint, int>)@this->LpVtbl[69])(@this, Sampler, Type, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateDevice<TThis>(this TThis thisVtbl, uint* pNumPasses) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[70])(@this, pNumPasses);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ValidateDevice<TThis>(this TThis thisVtbl, ref uint pNumPasses) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pNumPassesPtr = &pNumPasses)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[70])(@this, pNumPassesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPaletteEntries<TThis>(this TThis thisVtbl, uint PaletteNumber, Silk.NET.Maths.Vector4D<byte>* pEntries) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[71])(@this, PaletteNumber, pEntries);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPaletteEntries<TThis>(this TThis thisVtbl, uint PaletteNumber, ref Silk.NET.Maths.Vector4D<byte> pEntries) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Vector4D<byte>* pEntriesPtr = &pEntries)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[71])(@this, PaletteNumber, pEntriesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPaletteEntries<TThis>(this TThis thisVtbl, uint PaletteNumber, Silk.NET.Maths.Vector4D<byte>* pEntries) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[72])(@this, PaletteNumber, pEntries);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPaletteEntries<TThis>(this TThis thisVtbl, uint PaletteNumber, ref Silk.NET.Maths.Vector4D<byte> pEntries) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Vector4D<byte>* pEntriesPtr = &pEntries)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[72])(@this, PaletteNumber, pEntriesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCurrentTexturePalette<TThis>(this TThis thisVtbl, uint PaletteNumber) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int>)@this->LpVtbl[73])(@this, PaletteNumber);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTexturePalette<TThis>(this TThis thisVtbl, uint* PaletteNumber) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[74])(@this, PaletteNumber);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentTexturePalette<TThis>(this TThis thisVtbl, ref uint PaletteNumber) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* PaletteNumberPtr = &PaletteNumber)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[74])(@this, PaletteNumberPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetScissorRect<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[75])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetScissorRect<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[75])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetScissorRect<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pRect) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[76])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetScissorRect<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pRect) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[76])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSoftwareVertexProcessing<TThis>(this TThis thisVtbl, int bSoftware) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int, int>)@this->LpVtbl[77])(@this, bSoftware);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSoftwareVertexProcessing<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[78])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetNPatchMode<TThis>(this TThis thisVtbl, float nSegments) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, float, int>)@this->LpVtbl[79])(@this, nSegments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetNPatchMode<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        float ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, float>)@this->LpVtbl[80])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawPrimitive<TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint StartVertex, uint PrimitiveCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, uint, int>)@this->LpVtbl[81])(@this, PrimitiveType, StartVertex, PrimitiveCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawIndexedPrimitive<TThis>(this TThis thisVtbl, Primitivetype arg0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, int, uint, uint, uint, uint, int>)@this->LpVtbl[82])(@this, arg0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawPrimitiveUP<TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint PrimitiveCount, void* pVertexStreamZeroData, uint VertexStreamZeroStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, void*, uint, int>)@this->LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawPrimitiveUP<T0, TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint PrimitiveCount, ref T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, void*, uint, int>)@this->LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawIndexedPrimitiveUP<TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, void* pIndexData, Format IndexDataFormat, void* pVertexStreamZeroData, uint VertexStreamZeroStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawIndexedPrimitiveUP<T0, TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, void* pIndexData, Format IndexDataFormat, ref T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawIndexedPrimitiveUP<T0, TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, ref T0 pIndexData, Format IndexDataFormat, void* pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pIndexDataPtr = &pIndexData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawIndexedPrimitiveUP<T0, T1, TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, ref T0 pIndexData, Format IndexDataFormat, ref T1 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pIndexDataPtr = &pIndexData)
        {
            fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessVertices<TThis>(this TThis thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessVertices<TThis>(this TThis thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDeclPtr, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessVertices<TThis>(this TThis thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDecl, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ProcessVertices<TThis>(this TThis thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
        {
            fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDeclPtr, Flags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration<TThis>(this TThis thisVtbl, Vertexelement9* pVertexElements, IDirect3DVertexDeclaration9** ppDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElements, ppDecl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration<TThis>(this TThis thisVtbl, Vertexelement9* pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElements, ppDeclPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration<TThis>(this TThis thisVtbl, ref Vertexelement9 pVertexElements, IDirect3DVertexDeclaration9** ppDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElementsPtr, ppDecl);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration<TThis>(this TThis thisVtbl, ref Vertexelement9 pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
        {
            fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElementsPtr, ppDeclPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexDeclaration<TThis>(this TThis thisVtbl, IDirect3DVertexDeclaration9* pDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9*, int>)@this->LpVtbl[87])(@this, pDecl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexDeclaration<TThis>(this TThis thisVtbl, ref IDirect3DVertexDeclaration9 pDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexDeclaration9* pDeclPtr = &pDecl)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9*, int>)@this->LpVtbl[87])(@this, pDeclPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexDeclaration<TThis>(this TThis thisVtbl, IDirect3DVertexDeclaration9** ppDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[88])(@this, ppDecl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexDeclaration<TThis>(this TThis thisVtbl, ref IDirect3DVertexDeclaration9* ppDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[88])(@this, ppDeclPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFVF<TThis>(this TThis thisVtbl, uint FVF) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int>)@this->LpVtbl[89])(@this, FVF);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFVF<TThis>(this TThis thisVtbl, uint* pFVF) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[90])(@this, pFVF);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFVF<TThis>(this TThis thisVtbl, ref uint pFVF) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pFVFPtr = &pFVF)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[90])(@this, pFVFPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader<TThis>(this TThis thisVtbl, uint* pFunction, IDirect3DVertexShader9** ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunction, ppShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader<TThis>(this TThis thisVtbl, uint* pFunction, ref IDirect3DVertexShader9* ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunction, ppShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader<TThis>(this TThis thisVtbl, ref uint pFunction, IDirect3DVertexShader9** ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pFunctionPtr = &pFunction)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunctionPtr, ppShader);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader<TThis>(this TThis thisVtbl, ref uint pFunction, ref IDirect3DVertexShader9* ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pFunctionPtr = &pFunction)
        {
            fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunctionPtr, ppShaderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexShader<TThis>(this TThis thisVtbl, IDirect3DVertexShader9* pShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexShader9*, int>)@this->LpVtbl[92])(@this, pShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShader<TThis>(this TThis thisVtbl, ref IDirect3DVertexShader9 pShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexShader9* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexShader9*, int>)@this->LpVtbl[92])(@this, pShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexShader<TThis>(this TThis thisVtbl, IDirect3DVertexShader9** ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexShader9**, int>)@this->LpVtbl[93])(@this, ppShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexShader<TThis>(this TThis thisVtbl, ref IDirect3DVertexShader9* ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexShader9**, int>)@this->LpVtbl[93])(@this, ppShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, float* pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[94])(@this, StartRegister, pConstantData, Vector4fCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, ref float pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[94])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, float* pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[95])(@this, StartRegister, pConstantData, Vector4fCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, ref float pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[95])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, int* pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[96])(@this, StartRegister, pConstantData, Vector4iCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, ref int pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[96])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, int* pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[97])(@this, StartRegister, pConstantData, Vector4iCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, ref int pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[97])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, int* pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[98])(@this, StartRegister, pConstantData, BoolCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, ref int pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[98])(@this, StartRegister, pConstantDataPtr, BoolCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, int* pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[99])(@this, StartRegister, pConstantData, BoolCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, ref int pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[99])(@this, StartRegister, pConstantDataPtr, BoolCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9* pStreamData, uint OffsetInBytes, uint Stride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)@this->LpVtbl[100])(@this, StreamNumber, pStreamData, OffsetInBytes, Stride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9* pStreamDataPtr = &pStreamData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)@this->LpVtbl[100])(@this, StreamNumber, pStreamDataPtr, OffsetInBytes, Stride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, uint* pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, ref uint pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pStridePtr = &pStride)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStridePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint pOffsetInBytes, uint* pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint pOffsetInBytes, ref uint pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
        {
            fixed (uint* pStridePtr = &pStride)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStridePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, uint* pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, ref uint pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
        {
            fixed (uint* pStridePtr = &pStride)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStridePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint pOffsetInBytes, uint* pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
        {
            fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytesPtr, pStride);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint pOffsetInBytes, ref uint pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
        {
            fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
            {
                fixed (uint* pStridePtr = &pStride)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytesPtr, pStridePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStreamSourceFreq<TThis>(this TThis thisVtbl, uint StreamNumber, uint Setting) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, int>)@this->LpVtbl[102])(@this, StreamNumber, Setting);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSourceFreq<TThis>(this TThis thisVtbl, uint StreamNumber, uint* pSetting) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint*, int>)@this->LpVtbl[103])(@this, StreamNumber, pSetting);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStreamSourceFreq<TThis>(this TThis thisVtbl, uint StreamNumber, ref uint pSetting) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pSettingPtr = &pSetting)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint*, int>)@this->LpVtbl[103])(@this, StreamNumber, pSettingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetIndices<TThis>(this TThis thisVtbl, IDirect3DIndexBuffer9* pIndexData) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9*, int>)@this->LpVtbl[104])(@this, pIndexData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetIndices<TThis>(this TThis thisVtbl, ref IDirect3DIndexBuffer9 pIndexData) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DIndexBuffer9* pIndexDataPtr = &pIndexData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9*, int>)@this->LpVtbl[104])(@this, pIndexDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIndices<TThis>(this TThis thisVtbl, IDirect3DIndexBuffer9** ppIndexData) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9**, int>)@this->LpVtbl[105])(@this, ppIndexData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIndices<TThis>(this TThis thisVtbl, ref IDirect3DIndexBuffer9* ppIndexData) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DIndexBuffer9** ppIndexDataPtr = &ppIndexData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9**, int>)@this->LpVtbl[105])(@this, ppIndexDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader<TThis>(this TThis thisVtbl, uint* pFunction, IDirect3DPixelShader9** ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunction, ppShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader<TThis>(this TThis thisVtbl, uint* pFunction, ref IDirect3DPixelShader9* ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunction, ppShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader<TThis>(this TThis thisVtbl, ref uint pFunction, IDirect3DPixelShader9** ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pFunctionPtr = &pFunction)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunctionPtr, ppShader);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader<TThis>(this TThis thisVtbl, ref uint pFunction, ref IDirect3DPixelShader9* ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pFunctionPtr = &pFunction)
        {
            fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunctionPtr, ppShaderPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPixelShader<TThis>(this TThis thisVtbl, IDirect3DPixelShader9* pShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DPixelShader9*, int>)@this->LpVtbl[107])(@this, pShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShader<TThis>(this TThis thisVtbl, ref IDirect3DPixelShader9 pShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DPixelShader9* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DPixelShader9*, int>)@this->LpVtbl[107])(@this, pShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelShader<TThis>(this TThis thisVtbl, IDirect3DPixelShader9** ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DPixelShader9**, int>)@this->LpVtbl[108])(@this, ppShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelShader<TThis>(this TThis thisVtbl, ref IDirect3DPixelShader9* ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DPixelShader9**, int>)@this->LpVtbl[108])(@this, ppShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPixelShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, float* pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[109])(@this, StartRegister, pConstantData, Vector4fCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, ref float pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[109])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, float* pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[110])(@this, StartRegister, pConstantData, Vector4fCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, ref float pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[110])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPixelShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, int* pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[111])(@this, StartRegister, pConstantData, Vector4iCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, ref int pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[111])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, int* pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[112])(@this, StartRegister, pConstantData, Vector4iCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, ref int pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[112])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPixelShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, int* pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[113])(@this, StartRegister, pConstantData, BoolCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, ref int pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[113])(@this, StartRegister, pConstantDataPtr, BoolCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, int* pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[114])(@this, StartRegister, pConstantData, BoolCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, ref int pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[114])(@this, StartRegister, pConstantDataPtr, BoolCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectPatch<TThis>(this TThis thisVtbl, uint Handle, float* pNumSegs, RectpatchInfo* pRectPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectPatch<TThis>(this TThis thisVtbl, uint Handle, float* pNumSegs, ref RectpatchInfo pRectPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectPatch<TThis>(this TThis thisVtbl, uint Handle, ref float pNumSegs, RectpatchInfo* pRectPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* pNumSegsPtr = &pNumSegs)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawRectPatch<TThis>(this TThis thisVtbl, uint Handle, ref float pNumSegs, ref RectpatchInfo pRectPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* pNumSegsPtr = &pNumSegs)
        {
            fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfoPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawTriPatch<TThis>(this TThis thisVtbl, uint Handle, float* pNumSegs, TripatchInfo* pTriPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawTriPatch<TThis>(this TThis thisVtbl, uint Handle, float* pNumSegs, ref TripatchInfo pTriPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawTriPatch<TThis>(this TThis thisVtbl, uint Handle, ref float pNumSegs, TripatchInfo* pTriPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* pNumSegsPtr = &pNumSegs)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawTriPatch<TThis>(this TThis thisVtbl, uint Handle, ref float pNumSegs, ref TripatchInfo pTriPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* pNumSegsPtr = &pNumSegs)
        {
            fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfoPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DeletePatch<TThis>(this TThis thisVtbl, uint Handle) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int>)@this->LpVtbl[117])(@this, Handle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQuery<TThis>(this TThis thisVtbl, Querytype Type, IDirect3DQuery9** ppQuery) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Querytype, IDirect3DQuery9**, int>)@this->LpVtbl[118])(@this, Type, ppQuery);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQuery<TThis>(this TThis thisVtbl, Querytype Type, ref IDirect3DQuery9* ppQuery) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DQuery9** ppQueryPtr = &ppQuery)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Querytype, IDirect3DQuery9**, int>)@this->LpVtbl[118])(@this, Type, ppQueryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetConvolutionMonoKernel<TThis>(this TThis thisVtbl, uint width, uint height, float* rows, float* columns) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, float*, float*, int>)@this->LpVtbl[119])(@this, width, height, rows, columns);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetConvolutionMonoKernel<TThis>(this TThis thisVtbl, uint width, uint height, float* rows, ref float columns) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* columnsPtr = &columns)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, float*, float*, int>)@this->LpVtbl[119])(@this, width, height, rows, columnsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetConvolutionMonoKernel<TThis>(this TThis thisVtbl, uint width, uint height, ref float rows, float* columns) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* rowsPtr = &rows)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, float*, float*, int>)@this->LpVtbl[119])(@this, width, height, rowsPtr, columns);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetConvolutionMonoKernel<TThis>(this TThis thisVtbl, uint width, uint height, ref float rows, ref float columns) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (float* rowsPtr = &rows)
        {
            fixed (float* columnsPtr = &columns)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, float*, float*, int>)@this->LpVtbl[119])(@this, width, height, rowsPtr, columnsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDst, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9* pDstRectDescsPtr = &pDstRectDescs)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDst, pSrcRectDescs, NumRects, pDstRectDescsPtr, Operation, Xoffset, Yoffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9* pSrcRectDescsPtr = &pSrcRectDescs)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDst, pSrcRectDescsPtr, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DVertexBuffer9* pSrcRectDescsPtr = &pSrcRectDescs)
        {
            fixed (IDirect3DVertexBuffer9* pDstRectDescsPtr = &pDstRectDescs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDst, pSrcRectDescsPtr, NumRects, pDstRectDescsPtr, Operation, Xoffset, Yoffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, ref IDirect3DSurface9 pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDstPtr = &pDst)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDstPtr, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, ref IDirect3DSurface9 pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDstPtr = &pDst)
        {
            fixed (IDirect3DVertexBuffer9* pDstRectDescsPtr = &pDstRectDescs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDstPtr, pSrcRectDescs, NumRects, pDstRectDescsPtr, Operation, Xoffset, Yoffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDstPtr = &pDst)
        {
            fixed (IDirect3DVertexBuffer9* pSrcRectDescsPtr = &pSrcRectDescs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDstPtr, pSrcRectDescsPtr, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pDstPtr = &pDst)
        {
            fixed (IDirect3DVertexBuffer9* pSrcRectDescsPtr = &pSrcRectDescs)
            {
                fixed (IDirect3DVertexBuffer9* pDstRectDescsPtr = &pDstRectDescs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDstPtr, pSrcRectDescsPtr, NumRects, pDstRectDescsPtr, Operation, Xoffset, Yoffset);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcPtr = &pSrc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrcPtr, pDst, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcPtr = &pSrc)
        {
            fixed (IDirect3DVertexBuffer9* pDstRectDescsPtr = &pDstRectDescs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrcPtr, pDst, pSrcRectDescs, NumRects, pDstRectDescsPtr, Operation, Xoffset, Yoffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrc, IDirect3DSurface9* pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcPtr = &pSrc)
        {
            fixed (IDirect3DVertexBuffer9* pSrcRectDescsPtr = &pSrcRectDescs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrcPtr, pDst, pSrcRectDescsPtr, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrc, IDirect3DSurface9* pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcPtr = &pSrc)
        {
            fixed (IDirect3DVertexBuffer9* pSrcRectDescsPtr = &pSrcRectDescs)
            {
                fixed (IDirect3DVertexBuffer9* pDstRectDescsPtr = &pDstRectDescs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrcPtr, pDst, pSrcRectDescsPtr, NumRects, pDstRectDescsPtr, Operation, Xoffset, Yoffset);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcPtr = &pSrc)
        {
            fixed (IDirect3DSurface9* pDstPtr = &pDst)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrcPtr, pDstPtr, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcPtr = &pSrc)
        {
            fixed (IDirect3DSurface9* pDstPtr = &pDst)
            {
                fixed (IDirect3DVertexBuffer9* pDstRectDescsPtr = &pDstRectDescs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrcPtr, pDstPtr, pSrcRectDescs, NumRects, pDstRectDescsPtr, Operation, Xoffset, Yoffset);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcPtr = &pSrc)
        {
            fixed (IDirect3DSurface9* pDstPtr = &pDst)
            {
                fixed (IDirect3DVertexBuffer9* pSrcRectDescsPtr = &pSrcRectDescs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrcPtr, pDstPtr, pSrcRectDescsPtr, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TThis>(this TThis thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9* pSrcPtr = &pSrc)
        {
            fixed (IDirect3DSurface9* pDstPtr = &pDst)
            {
                fixed (IDirect3DVertexBuffer9* pSrcRectDescsPtr = &pSrcRectDescs)
                {
                    fixed (IDirect3DVertexBuffer9* pDstRectDescsPtr = &pDstRectDescs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrcPtr, pDstPtr, pSrcRectDescsPtr, NumRects, pDstRectDescsPtr, Operation, Xoffset, Yoffset);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PresentEx<TThis>(this TThis thisVtbl, ref Silk.NET.Maths.Rectangle<int> pSourceRect, ref Silk.NET.Maths.Rectangle<int> pDestRect, nint hDestWindowOverride, ref RGNData pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGPUThreadPriority<TThis>(this TThis thisVtbl, int* pPriority) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int*, int>)@this->LpVtbl[122])(@this, pPriority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGPUThreadPriority<TThis>(this TThis thisVtbl, ref int pPriority) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (int* pPriorityPtr = &pPriority)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int*, int>)@this->LpVtbl[122])(@this, pPriorityPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGPUThreadPriority<TThis>(this TThis thisVtbl, int Priority) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int, int>)@this->LpVtbl[123])(@this, Priority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WaitForVBlank<TThis>(this TThis thisVtbl, uint iSwapChain) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int>)@this->LpVtbl[124])(@this, iSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckResourceResidency<TThis>(this TThis thisVtbl, IDirect3DResource9** pResourceArray, uint NumResources) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DResource9**, uint, int>)@this->LpVtbl[125])(@this, pResourceArray, NumResources);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckResourceResidency<TThis>(this TThis thisVtbl, ref IDirect3DResource9* pResourceArray, uint NumResources) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DResource9** pResourceArrayPtr = &pResourceArray)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DResource9**, uint, int>)@this->LpVtbl[125])(@this, pResourceArrayPtr, NumResources);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaximumFrameLatency<TThis>(this TThis thisVtbl, uint MaxLatency) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int>)@this->LpVtbl[126])(@this, MaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumFrameLatency<TThis>(this TThis thisVtbl, uint* pMaxLatency) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[127])(@this, pMaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumFrameLatency<TThis>(this TThis thisVtbl, ref uint pMaxLatency) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pMaxLatencyPtr = &pMaxLatency)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[127])(@this, pMaxLatencyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceState<TThis>(this TThis thisVtbl, nint hDestinationWindow) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, nint, int>)@this->LpVtbl[128])(@this, hDestinationWindow);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTargetEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, IDirect3DSurface9** ppSurface, void** pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[129])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle, Usage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTargetEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, IDirect3DSurface9** ppSurface, ref void* pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[129])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandlePtr, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTargetEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, ref IDirect3DSurface9* ppSurface, void** pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[129])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandle, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTargetEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Lockable, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[129])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandlePtr, Usage);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurfaceEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, void** pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[130])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle, Usage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurfaceEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, ref void* pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[130])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandlePtr, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurfaceEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, void** pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[130])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandle, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurfaceEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[130])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandlePtr, Usage);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurfaceEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, IDirect3DSurface9** ppSurface, void** pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[131])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle, Usage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurfaceEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, IDirect3DSurface9** ppSurface, ref void* pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[131])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandlePtr, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurfaceEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, ref IDirect3DSurface9* ppSurface, void** pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[131])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandle, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurfaceEx<TThis>(this TThis thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, int Discard, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle, uint Usage) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, int, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[131])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandlePtr, Usage);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetEx<TThis>(this TThis thisVtbl, PresentParameters* pPresentationParameters, Displaymodeex* pFullscreenDisplayMode) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, Displaymodeex*, int>)@this->LpVtbl[132])(@this, pPresentationParameters, pFullscreenDisplayMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetEx<TThis>(this TThis thisVtbl, PresentParameters* pPresentationParameters, ref Displaymodeex pFullscreenDisplayMode) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Displaymodeex* pFullscreenDisplayModePtr = &pFullscreenDisplayMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, Displaymodeex*, int>)@this->LpVtbl[132])(@this, pPresentationParameters, pFullscreenDisplayModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetEx<TThis>(this TThis thisVtbl, ref PresentParameters pPresentationParameters, Displaymodeex* pFullscreenDisplayMode) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, Displaymodeex*, int>)@this->LpVtbl[132])(@this, pPresentationParametersPtr, pFullscreenDisplayMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResetEx<TThis>(this TThis thisVtbl, ref PresentParameters pPresentationParameters, ref Displaymodeex pFullscreenDisplayMode) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            fixed (Displaymodeex* pFullscreenDisplayModePtr = &pFullscreenDisplayMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, Displaymodeex*, int>)@this->LpVtbl[132])(@this, pPresentationParametersPtr, pFullscreenDisplayModePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx<TThis>(this TThis thisVtbl, uint iSwapChain, Displaymodeex* pMode, Displayrotation* pRotation) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[133])(@this, iSwapChain, pMode, pRotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx<TThis>(this TThis thisVtbl, uint iSwapChain, Displaymodeex* pMode, ref Displayrotation pRotation) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Displayrotation* pRotationPtr = &pRotation)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[133])(@this, iSwapChain, pMode, pRotationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx<TThis>(this TThis thisVtbl, uint iSwapChain, ref Displaymodeex pMode, Displayrotation* pRotation) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Displaymodeex* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[133])(@this, iSwapChain, pModePtr, pRotation);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeEx<TThis>(this TThis thisVtbl, uint iSwapChain, ref Displaymodeex pMode, ref Displayrotation pRotation) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Displaymodeex* pModePtr = &pMode)
        {
            fixed (Displayrotation* pRotationPtr = &pRotation)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[133])(@this, iSwapChain, pModePtr, pRotationPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceCaps<TThis>(this TThis thisVtbl, Span<Caps9> pCaps) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDeviceCaps(ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayMode<TThis>(this TThis thisVtbl, uint iSwapChain, Span<Displaymode> pMode) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDisplayMode(iSwapChain, ref pMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCreationParameters<TThis>(this TThis thisVtbl, Span<DeviceCreationParameters> pParameters) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCreationParameters(ref pParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetCursorProperties<TThis>(this TThis thisVtbl, uint XHotSpot, uint YHotSpot, Span<IDirect3DSurface9> pCursorBitmap) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetCursorProperties(XHotSpot, YHotSpot, ref pCursorBitmap.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain<TThis>(this TThis thisVtbl, Span<PresentParameters> pPresentationParameters, IDirect3DSwapChain9** pSwapChain) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateAdditionalSwapChain(ref pPresentationParameters.GetPinnableReference(), pSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain<TThis>(this TThis thisVtbl, Span<PresentParameters> pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateAdditionalSwapChain(ref pPresentationParameters.GetPinnableReference(), ref pSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int Reset<TThis>(this TThis thisVtbl, Span<PresentParameters> pPresentationParameters) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Reset(ref pPresentationParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(pSourceRect, pDestRect, hDestWindowOverride, ref pDirtyRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(pSourceRect, ref pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(pSourceRect, ref pDestRect.GetPinnableReference(), hDestWindowOverride, ref pDirtyRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(ref pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, pDirtyRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(ref pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, ref pDirtyRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(ref pSourceRect.GetPinnableReference(), ref pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion);
    }

    /// <summary>To be documented.</summary>
    public static int Present<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Present(ref pSourceRect.GetPinnableReference(), ref pDestRect.GetPinnableReference(), hDestWindowOverride, ref pDirtyRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRasterStatus<TThis>(this TThis thisVtbl, uint iSwapChain, Span<RasterStatus> pRasterStatus) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRasterStatus(iSwapChain, ref pRasterStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetGammaRamp<TThis>(this TThis thisVtbl, uint iSwapChain, uint Flags, Span<Gammaramp> pRamp) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SetGammaRamp(iSwapChain, Flags, ref pRamp.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetGammaRamp<TThis>(this TThis thisVtbl, uint iSwapChain, Span<Gammaramp> pRamp) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->GetGammaRamp(iSwapChain, ref pRamp.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, Span<Silk.NET.Maths.Vector2D<int>> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, pSourceRect, pDestinationSurface, ref pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, pSourceRect, ref pDestinationSurface.GetPinnableReference(), pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, Span<Silk.NET.Maths.Vector2D<int>> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, pSourceRect, ref pDestinationSurface.GetPinnableReference(), ref pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, ref pSourceRect.GetPinnableReference(), pDestinationSurface, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, IDirect3DSurface9* pDestinationSurface, Span<Silk.NET.Maths.Vector2D<int>> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, ref pSourceRect.GetPinnableReference(), pDestinationSurface, ref pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, ref pSourceRect.GetPinnableReference(), ref pDestinationSurface.GetPinnableReference(), pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, Span<Silk.NET.Maths.Vector2D<int>> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, ref pSourceRect.GetPinnableReference(), ref pDestinationSurface.GetPinnableReference(), ref pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), pSourceRect, pDestinationSurface, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, Span<Silk.NET.Maths.Vector2D<int>> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), pSourceRect, pDestinationSurface, ref pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), pSourceRect, ref pDestinationSurface.GetPinnableReference(), pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, Span<Silk.NET.Maths.Vector2D<int>> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), pSourceRect, ref pDestinationSurface.GetPinnableReference(), ref pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, IDirect3DSurface9* pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), ref pSourceRect.GetPinnableReference(), pDestinationSurface, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, IDirect3DSurface9* pDestinationSurface, Span<Silk.NET.Maths.Vector2D<int>> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), ref pSourceRect.GetPinnableReference(), pDestinationSurface, ref pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, Silk.NET.Maths.Vector2D<int>* pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), ref pSourceRect.GetPinnableReference(), ref pDestinationSurface.GetPinnableReference(), pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static int UpdateSurface<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, Span<Silk.NET.Maths.Vector2D<int>> pDestPoint) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), ref pSourceRect.GetPinnableReference(), ref pDestinationSurface.GetPinnableReference(), ref pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTexture<TThis>(this TThis thisVtbl, IDirect3DBaseTexture9* pSourceTexture, Span<IDirect3DBaseTexture9> pDestinationTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTexture(pSourceTexture, ref pDestinationTexture.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTexture<TThis>(this TThis thisVtbl, Span<IDirect3DBaseTexture9> pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTexture(ref pSourceTexture.GetPinnableReference(), pDestinationTexture);
    }

    /// <summary>To be documented.</summary>
    public static int UpdateTexture<TThis>(this TThis thisVtbl, Span<IDirect3DBaseTexture9> pSourceTexture, Span<IDirect3DBaseTexture9> pDestinationTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->UpdateTexture(ref pSourceTexture.GetPinnableReference(), ref pDestinationTexture.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTargetData<TThis>(this TThis thisVtbl, IDirect3DSurface9* pRenderTarget, Span<IDirect3DSurface9> pDestSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRenderTargetData(pRenderTarget, ref pDestSurface.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTargetData<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pRenderTarget, IDirect3DSurface9* pDestSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRenderTargetData(ref pRenderTarget.GetPinnableReference(), pDestSurface);
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderTargetData<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pRenderTarget, Span<IDirect3DSurface9> pDestSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRenderTargetData(ref pRenderTarget.GetPinnableReference(), ref pDestSurface.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFrontBufferData<TThis>(this TThis thisVtbl, uint iSwapChain, Span<IDirect3DSurface9> pDestSurface) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFrontBufferData(iSwapChain, ref pDestSurface.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, pSourceRect, pDestSurface, ref pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<IDirect3DSurface9> pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, pSourceRect, ref pDestSurface.GetPinnableReference(), pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<IDirect3DSurface9> pDestSurface, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, pSourceRect, ref pDestSurface.GetPinnableReference(), ref pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, ref pSourceRect.GetPinnableReference(), pDestSurface, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, IDirect3DSurface9* pDestSurface, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, ref pSourceRect.GetPinnableReference(), pDestSurface, ref pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<IDirect3DSurface9> pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, ref pSourceRect.GetPinnableReference(), ref pDestSurface.GetPinnableReference(), pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<IDirect3DSurface9> pDestSurface, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, ref pSourceRect.GetPinnableReference(), ref pDestSurface.GetPinnableReference(), ref pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), pSourceRect, pDestSurface, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, IDirect3DSurface9* pDestSurface, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), pSourceRect, pDestSurface, ref pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<IDirect3DSurface9> pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), pSourceRect, ref pDestSurface.GetPinnableReference(), pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<IDirect3DSurface9> pDestSurface, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), pSourceRect, ref pDestSurface.GetPinnableReference(), ref pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, IDirect3DSurface9* pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), ref pSourceRect.GetPinnableReference(), pDestSurface, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, IDirect3DSurface9* pDestSurface, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), ref pSourceRect.GetPinnableReference(), pDestSurface, ref pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<IDirect3DSurface9> pDestSurface, Silk.NET.Maths.Rectangle<int>* pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), ref pSourceRect.GetPinnableReference(), ref pDestSurface.GetPinnableReference(), pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static int StretchRect<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSourceSurface, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<IDirect3DSurface9> pDestSurface, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, Texturefiltertype Filter) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), ref pSourceRect.GetPinnableReference(), ref pDestSurface.GetPinnableReference(), ref pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSurface, Span<Silk.NET.Maths.Rectangle<int>> pRect, uint color) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ColorFill(pSurface, ref pRect.GetPinnableReference(), color);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSurface, Silk.NET.Maths.Rectangle<int>* pRect, uint color) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ColorFill(ref pSurface.GetPinnableReference(), pRect, color);
    }

    /// <summary>To be documented.</summary>
    public static int ColorFill<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSurface, Span<Silk.NET.Maths.Rectangle<int>> pRect, uint color) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ColorFill(ref pSurface.GetPinnableReference(), ref pRect.GetPinnableReference(), color);
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderTarget<TThis>(this TThis thisVtbl, uint RenderTargetIndex, Span<IDirect3DSurface9> pRenderTarget) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetRenderTarget(RenderTargetIndex, ref pRenderTarget.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetDepthStencilSurface<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pNewZStencil) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetDepthStencilSurface(ref pNewZStencil.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Clear<TThis>(this TThis thisVtbl, uint Count, Span<Rect> pRects, uint Flags, uint Color, float Z, uint Stencil) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->Clear(Count, ref pRects.GetPinnableReference(), Flags, Color, Z, Stencil);
    }

    /// <summary>To be documented.</summary>
    public static int SetTransform<TThis>(this TThis thisVtbl, Transformstatetype State, Span<System.Numerics.Matrix4x4> pMatrix) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetTransform(State, ref pMatrix.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTransform<TThis>(this TThis thisVtbl, Transformstatetype State, Span<System.Numerics.Matrix4x4> pMatrix) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetTransform(State, ref pMatrix.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MultiplyTransform<TThis>(this TThis thisVtbl, Transformstatetype arg0, Span<System.Numerics.Matrix4x4> arg1) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->MultiplyTransform(arg0, ref arg1.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetViewport<TThis>(this TThis thisVtbl, Span<Viewport9> pViewport) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetViewport(ref pViewport.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetViewport<TThis>(this TThis thisVtbl, Span<Viewport9> pViewport) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetViewport(ref pViewport.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetMaterial<TThis>(this TThis thisVtbl, Span<Material9> pMaterial) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetMaterial(ref pMaterial.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMaterial<TThis>(this TThis thisVtbl, Span<Material9> pMaterial) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetMaterial(ref pMaterial.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetLight<TThis>(this TThis thisVtbl, uint Index, Span<Light9> arg1) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetLight(Index, ref arg1.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLight<TThis>(this TThis thisVtbl, uint Index, Span<Light9> arg1) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetLight(Index, ref arg1.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLightEnable<TThis>(this TThis thisVtbl, uint Index, Span<int> pEnable) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetLightEnable(Index, ref pEnable.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetClipPlane<TThis>(this TThis thisVtbl, uint Index, Span<float> pPlane) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetClipPlane(Index, ref pPlane.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetClipPlane<TThis>(this TThis thisVtbl, uint Index, Span<float> pPlane) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetClipPlane(Index, ref pPlane.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderState<TThis>(this TThis thisVtbl, Renderstatetype State, Span<uint> pValue) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetRenderState(State, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetClipStatus<TThis>(this TThis thisVtbl, Span<Clipstatus9> pClipStatus) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetClipStatus(ref pClipStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetClipStatus<TThis>(this TThis thisVtbl, Span<Clipstatus9> pClipStatus) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetClipStatus(ref pClipStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetTexture<TThis>(this TThis thisVtbl, uint Stage, Span<IDirect3DBaseTexture9> pTexture) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetTexture(Stage, ref pTexture.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTextureStageState<TThis>(this TThis thisVtbl, uint Stage, Texturestagestatetype Type, Span<uint> pValue) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetTextureStageState(Stage, Type, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSamplerState<TThis>(this TThis thisVtbl, uint Sampler, Samplerstatetype Type, Span<uint> pValue) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetSamplerState(Sampler, Type, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ValidateDevice<TThis>(this TThis thisVtbl, Span<uint> pNumPasses) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ValidateDevice(ref pNumPasses.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetPaletteEntries<TThis>(this TThis thisVtbl, uint PaletteNumber, Span<Silk.NET.Maths.Vector4D<byte>> pEntries) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPaletteEntries(PaletteNumber, ref pEntries.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPaletteEntries<TThis>(this TThis thisVtbl, uint PaletteNumber, Span<Silk.NET.Maths.Vector4D<byte>> pEntries) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPaletteEntries(PaletteNumber, ref pEntries.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentTexturePalette<TThis>(this TThis thisVtbl, Span<uint> PaletteNumber) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetCurrentTexturePalette(ref PaletteNumber.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetScissorRect<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetScissorRect(ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetScissorRect<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pRect) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetScissorRect(ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawPrimitiveUP<T0, TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint PrimitiveCount, Span<T0> pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DrawPrimitiveUP(PrimitiveType, PrimitiveCount, ref pVertexStreamZeroData.GetPinnableReference(), VertexStreamZeroStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawIndexedPrimitiveUP<T0, TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, void* pIndexData, Format IndexDataFormat, Span<T0> pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DrawIndexedPrimitiveUP(PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, ref pVertexStreamZeroData.GetPinnableReference(), VertexStreamZeroStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawIndexedPrimitiveUP<T0, TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, Span<T0> pIndexData, Format IndexDataFormat, void* pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DrawIndexedPrimitiveUP(PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, ref pIndexData.GetPinnableReference(), IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
    }

    /// <summary>To be documented.</summary>
    public static int DrawIndexedPrimitiveUP<T0, T1, TThis>(this TThis thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, Span<T0> pIndexData, Format IndexDataFormat, Span<T1> pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where T1 : unmanaged where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DrawIndexedPrimitiveUP(PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, ref pIndexData.GetPinnableReference(), IndexDataFormat, ref pVertexStreamZeroData.GetPinnableReference(), VertexStreamZeroStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessVertices<TThis>(this TThis thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, Span<IDirect3DVertexDeclaration9> pVertexDecl, uint Flags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, pDestBuffer, ref pVertexDecl.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessVertices<TThis>(this TThis thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, Span<IDirect3DVertexBuffer9> pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, ref pDestBuffer.GetPinnableReference(), pVertexDecl, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int ProcessVertices<TThis>(this TThis thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, Span<IDirect3DVertexBuffer9> pDestBuffer, Span<IDirect3DVertexDeclaration9> pVertexDecl, uint Flags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, ref pDestBuffer.GetPinnableReference(), ref pVertexDecl.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration<TThis>(this TThis thisVtbl, Span<Vertexelement9> pVertexElements, IDirect3DVertexDeclaration9** ppDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVertexDeclaration(ref pVertexElements.GetPinnableReference(), ppDecl);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration<TThis>(this TThis thisVtbl, Span<Vertexelement9> pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVertexDeclaration(ref pVertexElements.GetPinnableReference(), ref ppDecl);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexDeclaration<TThis>(this TThis thisVtbl, Span<IDirect3DVertexDeclaration9> pDecl) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetVertexDeclaration(ref pDecl.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFVF<TThis>(this TThis thisVtbl, Span<uint> pFVF) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetFVF(ref pFVF.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader<TThis>(this TThis thisVtbl, Span<uint> pFunction, IDirect3DVertexShader9** ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVertexShader(ref pFunction.GetPinnableReference(), ppShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader<TThis>(this TThis thisVtbl, Span<uint> pFunction, ref IDirect3DVertexShader9* ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateVertexShader(ref pFunction.GetPinnableReference(), ref ppShader);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShader<TThis>(this TThis thisVtbl, Span<IDirect3DVertexShader9> pShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetVertexShader(ref pShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, Span<float> pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetVertexShaderConstantF(StartRegister, ref pConstantData.GetPinnableReference(), Vector4fCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, Span<float> pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVertexShaderConstantF(StartRegister, ref pConstantData.GetPinnableReference(), Vector4fCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, Span<int> pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetVertexShaderConstantI(StartRegister, ref pConstantData.GetPinnableReference(), Vector4iCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, Span<int> pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVertexShaderConstantI(StartRegister, ref pConstantData.GetPinnableReference(), Vector4iCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, Span<int> pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetVertexShaderConstantB(StartRegister, ref pConstantData.GetPinnableReference(), BoolCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, Span<int> pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetVertexShaderConstantB(StartRegister, ref pConstantData.GetPinnableReference(), BoolCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, Span<IDirect3DVertexBuffer9> pStreamData, uint OffsetInBytes, uint Stride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetStreamSource(StreamNumber, ref pStreamData.GetPinnableReference(), OffsetInBytes, Stride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, Span<uint> pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ppStreamData, pOffsetInBytes, ref pStride.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, Span<uint> pOffsetInBytes, uint* pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ppStreamData, ref pOffsetInBytes.GetPinnableReference(), pStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, Span<uint> pOffsetInBytes, Span<uint> pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ppStreamData, ref pOffsetInBytes.GetPinnableReference(), ref pStride.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, Span<uint> pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ref ppStreamData, pOffsetInBytes, ref pStride.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, Span<uint> pOffsetInBytes, uint* pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ref ppStreamData, ref pOffsetInBytes.GetPinnableReference(), pStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TThis>(this TThis thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, Span<uint> pOffsetInBytes, Span<uint> pStride) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ref ppStreamData, ref pOffsetInBytes.GetPinnableReference(), ref pStride.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetStreamSourceFreq<TThis>(this TThis thisVtbl, uint StreamNumber, Span<uint> pSetting) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetStreamSourceFreq(StreamNumber, ref pSetting.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetIndices<TThis>(this TThis thisVtbl, Span<IDirect3DIndexBuffer9> pIndexData) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetIndices(ref pIndexData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader<TThis>(this TThis thisVtbl, Span<uint> pFunction, IDirect3DPixelShader9** ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreatePixelShader(ref pFunction.GetPinnableReference(), ppShader);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader<TThis>(this TThis thisVtbl, Span<uint> pFunction, ref IDirect3DPixelShader9* ppShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreatePixelShader(ref pFunction.GetPinnableReference(), ref ppShader);
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShader<TThis>(this TThis thisVtbl, Span<IDirect3DPixelShader9> pShader) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPixelShader(ref pShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, Span<float> pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPixelShaderConstantF(StartRegister, ref pConstantData.GetPinnableReference(), Vector4fCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantF<TThis>(this TThis thisVtbl, uint StartRegister, Span<float> pConstantData, uint Vector4fCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPixelShaderConstantF(StartRegister, ref pConstantData.GetPinnableReference(), Vector4fCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, Span<int> pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPixelShaderConstantI(StartRegister, ref pConstantData.GetPinnableReference(), Vector4iCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantI<TThis>(this TThis thisVtbl, uint StartRegister, Span<int> pConstantData, uint Vector4iCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPixelShaderConstantI(StartRegister, ref pConstantData.GetPinnableReference(), Vector4iCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, Span<int> pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetPixelShaderConstantB(StartRegister, ref pConstantData.GetPinnableReference(), BoolCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantB<TThis>(this TThis thisVtbl, uint StartRegister, Span<int> pConstantData, uint BoolCount) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetPixelShaderConstantB(StartRegister, ref pConstantData.GetPinnableReference(), BoolCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectPatch<TThis>(this TThis thisVtbl, uint Handle, float* pNumSegs, Span<RectpatchInfo> pRectPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DrawRectPatch(Handle, pNumSegs, ref pRectPatchInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectPatch<TThis>(this TThis thisVtbl, uint Handle, Span<float> pNumSegs, RectpatchInfo* pRectPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DrawRectPatch(Handle, ref pNumSegs.GetPinnableReference(), pRectPatchInfo);
    }

    /// <summary>To be documented.</summary>
    public static int DrawRectPatch<TThis>(this TThis thisVtbl, uint Handle, Span<float> pNumSegs, Span<RectpatchInfo> pRectPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DrawRectPatch(Handle, ref pNumSegs.GetPinnableReference(), ref pRectPatchInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawTriPatch<TThis>(this TThis thisVtbl, uint Handle, float* pNumSegs, Span<TripatchInfo> pTriPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DrawTriPatch(Handle, pNumSegs, ref pTriPatchInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawTriPatch<TThis>(this TThis thisVtbl, uint Handle, Span<float> pNumSegs, TripatchInfo* pTriPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DrawTriPatch(Handle, ref pNumSegs.GetPinnableReference(), pTriPatchInfo);
    }

    /// <summary>To be documented.</summary>
    public static int DrawTriPatch<TThis>(this TThis thisVtbl, uint Handle, Span<float> pNumSegs, Span<TripatchInfo> pTriPatchInfo) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->DrawTriPatch(Handle, ref pNumSegs.GetPinnableReference(), ref pTriPatchInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetConvolutionMonoKernel<TThis>(this TThis thisVtbl, uint width, uint height, float* rows, Span<float> columns) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetConvolutionMonoKernel(width, height, rows, ref columns.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetConvolutionMonoKernel<TThis>(this TThis thisVtbl, uint width, uint height, Span<float> rows, float* columns) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetConvolutionMonoKernel(width, height, ref rows.GetPinnableReference(), columns);
    }

    /// <summary>To be documented.</summary>
    public static int SetConvolutionMonoKernel<TThis>(this TThis thisVtbl, uint width, uint height, Span<float> rows, Span<float> columns) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetConvolutionMonoKernel(width, height, ref rows.GetPinnableReference(), ref columns.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(pSrc, pDst, pSrcRectDescs, NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(pSrc, pDst, ref pSrcRectDescs.GetPinnableReference(), NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(pSrc, pDst, ref pSrcRectDescs.GetPinnableReference(), NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, Span<IDirect3DSurface9> pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(pSrc, ref pDst.GetPinnableReference(), pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, Span<IDirect3DSurface9> pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(pSrc, ref pDst.GetPinnableReference(), pSrcRectDescs, NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, Span<IDirect3DSurface9> pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(pSrc, ref pDst.GetPinnableReference(), ref pSrcRectDescs.GetPinnableReference(), NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, IDirect3DSurface9* pSrc, Span<IDirect3DSurface9> pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(pSrc, ref pDst.GetPinnableReference(), ref pSrcRectDescs.GetPinnableReference(), NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), pDst, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), pDst, pSrcRectDescs, NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrc, IDirect3DSurface9* pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), pDst, ref pSrcRectDescs.GetPinnableReference(), NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrc, IDirect3DSurface9* pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), pDst, ref pSrcRectDescs.GetPinnableReference(), NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrc, Span<IDirect3DSurface9> pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), ref pDst.GetPinnableReference(), pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrc, Span<IDirect3DSurface9> pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), ref pDst.GetPinnableReference(), pSrcRectDescs, NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrc, Span<IDirect3DSurface9> pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), ref pDst.GetPinnableReference(), ref pSrcRectDescs.GetPinnableReference(), NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TThis>(this TThis thisVtbl, Span<IDirect3DSurface9> pSrc, Span<IDirect3DSurface9> pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), ref pDst.GetPinnableReference(), ref pSrcRectDescs.GetPinnableReference(), NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PresentEx(pSourceRect, pDestRect, hDestWindowOverride, ref pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PresentEx(pSourceRect, ref pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, Silk.NET.Maths.Rectangle<int>* pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PresentEx(pSourceRect, ref pDestRect.GetPinnableReference(), hDestWindowOverride, ref pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PresentEx(ref pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Silk.NET.Maths.Rectangle<int>* pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PresentEx(ref pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, ref pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, RGNData* pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PresentEx(ref pSourceRect.GetPinnableReference(), ref pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static int PresentEx<TThis>(this TThis thisVtbl, Span<Silk.NET.Maths.Rectangle<int>> pSourceRect, Span<Silk.NET.Maths.Rectangle<int>> pDestRect, nint hDestWindowOverride, Span<RGNData> pDirtyRegion, uint dwFlags) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PresentEx(ref pSourceRect.GetPinnableReference(), ref pDestRect.GetPinnableReference(), hDestWindowOverride, ref pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static int GetGPUThreadPriority<TThis>(this TThis thisVtbl, Span<int> pPriority) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetGPUThreadPriority(ref pPriority.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumFrameLatency<TThis>(this TThis thisVtbl, Span<uint> pMaxLatency) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetMaximumFrameLatency(ref pMaxLatency.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetEx<TThis>(this TThis thisVtbl, PresentParameters* pPresentationParameters, Span<Displaymodeex> pFullscreenDisplayMode) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ResetEx(pPresentationParameters, ref pFullscreenDisplayMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetEx<TThis>(this TThis thisVtbl, Span<PresentParameters> pPresentationParameters, Displaymodeex* pFullscreenDisplayMode) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ResetEx(ref pPresentationParameters.GetPinnableReference(), pFullscreenDisplayMode);
    }

    /// <summary>To be documented.</summary>
    public static int ResetEx<TThis>(this TThis thisVtbl, Span<PresentParameters> pPresentationParameters, Span<Displaymodeex> pFullscreenDisplayMode) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ResetEx(ref pPresentationParameters.GetPinnableReference(), ref pFullscreenDisplayMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx<TThis>(this TThis thisVtbl, uint iSwapChain, Displaymodeex* pMode, Span<Displayrotation> pRotation) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDisplayModeEx(iSwapChain, pMode, ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx<TThis>(this TThis thisVtbl, uint iSwapChain, Span<Displaymodeex> pMode, Displayrotation* pRotation) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDisplayModeEx(iSwapChain, ref pMode.GetPinnableReference(), pRotation);
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeEx<TThis>(this TThis thisVtbl, uint iSwapChain, Span<Displaymodeex> pMode, Span<Displayrotation> pRotation) where TThis : IComVtbl<IDirect3DDevice9Ex>
    {
        var @this = (IDirect3DDevice9Ex*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDisplayModeEx(iSwapChain, ref pMode.GetPinnableReference(), ref pRotation.GetPinnableReference());
    }

}
