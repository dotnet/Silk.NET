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
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int TestCooperativeLevel(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetAvailableTextureMem(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EvictManagedResources(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDirect3D(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3D9** ppD3D9)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3D9**, int>)@this->LpVtbl[6])(@this, ppD3D9);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDirect3D(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3D9* ppD3D9)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3D9** ppD3D9Ptr = &ppD3D9)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3D9**, int>)@this->LpVtbl[6])(@this, ppD3D9Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeviceCaps(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Caps9* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Caps9*, int>)@this->LpVtbl[7])(@this, pCaps);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceCaps(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref Caps9 pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Caps9* pCapsPtr = &pCaps)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Caps9*, int>)@this->LpVtbl[7])(@this, pCapsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayMode(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Displaymode* pMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, iSwapChain, pMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayMode(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, ref Displaymode pMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Displaymode* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, iSwapChain, pModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCreationParameters(this ComPtr<IDirect3DDevice9Ex> thisVtbl, DeviceCreationParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, DeviceCreationParameters*, int>)@this->LpVtbl[9])(@this, pParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCreationParameters(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref DeviceCreationParameters pParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (DeviceCreationParameters* pParametersPtr = &pParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, DeviceCreationParameters*, int>)@this->LpVtbl[9])(@this, pParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCursorProperties(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint XHotSpot, uint YHotSpot, IDirect3DSurface9* pCursorBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, IDirect3DSurface9*, int>)@this->LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCursorProperties(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint XHotSpot, uint YHotSpot, ref IDirect3DSurface9 pCursorBitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pCursorBitmapPtr = &pCursorBitmap)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, IDirect3DSurface9*, int>)@this->LpVtbl[10])(@this, XHotSpot, YHotSpot, pCursorBitmapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetCursorPosition(this ComPtr<IDirect3DDevice9Ex> thisVtbl, int X, int Y, uint Flags)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int, int, uint, void>)@this->LpVtbl[11])(@this, X, Y, Flags);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 ShowCursor(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Silk.NET.Core.Bool32 bShow)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32>)@this->LpVtbl[12])(@this, bShow);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain(this ComPtr<IDirect3DDevice9Ex> thisVtbl, PresentParameters* pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParameters, pSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain(this ComPtr<IDirect3DDevice9Ex> thisVtbl, PresentParameters* pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParameters, pSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref PresentParameters pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, IDirect3DSwapChain9**, int>)@this->LpVtbl[13])(@this, pPresentationParametersPtr, pSwapChain);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref PresentParameters pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetSwapChain(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, IDirect3DSwapChain9** pSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSwapChain9**, int>)@this->LpVtbl[14])(@this, iSwapChain, pSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChain(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, ref IDirect3DSwapChain9* pSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSwapChain9** pSwapChainPtr = &pSwapChain)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSwapChain9**, int>)@this->LpVtbl[14])(@this, iSwapChain, pSwapChainPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumberOfSwapChains(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reset(this ComPtr<IDirect3DDevice9Ex> thisVtbl, PresentParameters* pPresentationParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, int>)@this->LpVtbl[16])(@this, pPresentationParameters);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref PresentParameters pPresentationParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, int>)@this->LpVtbl[16])(@this, pPresentationParametersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, uint iBackBuffer, BackbufferType Type, IDirect3DSurface9** ppBackBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, uint iBackBuffer, BackbufferType Type, ref IDirect3DSurface9* ppBackBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppBackBufferPtr = &ppBackBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, BackbufferType, IDirect3DSurface9**, int>)@this->LpVtbl[18])(@this, iSwapChain, iBackBuffer, Type, ppBackBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRasterStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, RasterStatus* pRasterStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, RasterStatus*, int>)@this->LpVtbl[19])(@this, iSwapChain, pRasterStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRasterStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, ref RasterStatus pRasterStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RasterStatus* pRasterStatusPtr = &pRasterStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, RasterStatus*, int>)@this->LpVtbl[19])(@this, iSwapChain, pRasterStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDialogBoxMode(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Silk.NET.Core.Bool32 bEnableDialogs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[20])(@this, bEnableDialogs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetGammaRamp(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Gammaramp* pRamp)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Gammaramp*, void>)@this->LpVtbl[21])(@this, iSwapChain, Flags, pRamp);
    }

    /// <summary>To be documented.</summary>
    public static void SetGammaRamp(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Gammaramp pRamp)
    {
        var @this = thisVtbl.Handle;
        fixed (Gammaramp* pRampPtr = &pRamp)
        {
            ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Gammaramp*, void>)@this->LpVtbl[21])(@this, iSwapChain, Flags, pRampPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetGammaRamp(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Gammaramp* pRamp)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Gammaramp*, void>)@this->LpVtbl[22])(@this, iSwapChain, pRamp);
    }

    /// <summary>To be documented.</summary>
    public static void GetGammaRamp(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, ref Gammaramp pRamp)
    {
        var @this = thisVtbl.Handle;
        fixed (Gammaramp* pRampPtr = &pRamp)
        {
            ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Gammaramp*, void>)@this->LpVtbl[22])(@this, iSwapChain, pRampPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DTexture9** ppTexture, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DTexture9** ppTexturePtr = &ppTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, Format, Pool, IDirect3DTexture9**, void**, int>)@this->LpVtbl[23])(@this, Width, Height, Levels, Usage, Format, Pool, ppTexturePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DTexture9* ppTexture, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVolumeTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVolumeTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVolumeTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVolumeTexture9** ppVolumeTexturePtr = &ppVolumeTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexturePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVolumeTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DVolumeTexture9* ppVolumeTexture, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateCubeTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCubeTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DCubeTexture9** ppCubeTexture, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCubeTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DCubeTexture9** ppCubeTexturePtr = &ppCubeTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Format, Pool, IDirect3DCubeTexture9**, void**, int>)@this->LpVtbl[25])(@this, EdgeLength, Levels, Usage, Format, Pool, ppCubeTexturePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCubeTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref IDirect3DCubeTexture9* ppCubeTexture, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVertexBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexBuffer9** ppVertexBufferPtr = &ppVertexBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBufferPtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, ref IDirect3DVertexBuffer9* ppVertexBuffer, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateIndexBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIndexBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, Format Format, Pool Pool, IDirect3DIndexBuffer9** ppIndexBuffer, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIndexBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DIndexBuffer9** ppIndexBufferPtr = &ppIndexBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DIndexBuffer9**, void**, int>)@this->LpVtbl[27])(@this, Length, Usage, Format, Pool, ppIndexBufferPtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIndexBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, Format Format, Pool Pool, ref IDirect3DIndexBuffer9* ppIndexBuffer, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, IDirect3DSurface9** ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, IDirect3DSurface9** ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[29])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPointPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPoint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPoint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPoint);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurface, pDestPointPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPoint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRect, pDestinationSurfacePtr, pDestPointPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPoint);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurface, pDestPointPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPoint);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestinationSurfacePtr = &pDestinationSurface)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pDestPointPtr = &pDestPoint)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestinationSurfacePtr, pDestPointPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DBaseTexture9* pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexture, pDestinationTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DBaseTexture9* pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DBaseTexture9* pDestinationTexturePtr = &pDestinationTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexture, pDestinationTexturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DBaseTexture9 pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DBaseTexture9* pSourceTexturePtr = &pSourceTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)@this->LpVtbl[31])(@this, pSourceTexturePtr, pDestinationTexture);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UpdateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DBaseTexture9 pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetRenderTargetData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pRenderTarget, IDirect3DSurface9* pDestSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTarget, pDestSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTargetData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pRenderTarget, ref IDirect3DSurface9 pDestSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTarget, pDestSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTargetData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pRenderTarget, IDirect3DSurface9* pDestSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTargetPtr, pDestSurface);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderTargetData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pRenderTarget, ref IDirect3DSurface9 pDestSurface)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetFrontBufferData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, IDirect3DSurface9* pDestSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[33])(@this, iSwapChain, pDestSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFrontBufferData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, ref IDirect3DSurface9 pDestSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[33])(@this, iSwapChain, pDestSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRectPtr, Filter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRect, Filter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRect, Filter);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurface, pDestRectPtr, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRect, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRect, pDestSurfacePtr, pDestRectPtr, Filter);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRect, Filter);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurface, pDestRectPtr, Filter);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRect, Filter);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSourceSurfacePtr = &pSourceSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
            {
                fixed (IDirect3DSurface9* pDestSurfacePtr = &pDestSurface)
                {
                    fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurfacePtr, pSourceRectPtr, pDestSurfacePtr, pDestRectPtr, Filter);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurface, pRect, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurface, pRectPtr, color);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurfacePtr, pRect, color);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ColorFill(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSurfacePtr = &pSurface)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[35])(@this, pSurfacePtr, pRectPtr, color);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int SetRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint RenderTargetIndex, IDirect3DSurface9* pRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[37])(@this, RenderTargetIndex, pRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint RenderTargetIndex, ref IDirect3DSurface9 pRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9*, int>)@this->LpVtbl[37])(@this, RenderTargetIndex, pRenderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint RenderTargetIndex, IDirect3DSurface9** ppRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9**, int>)@this->LpVtbl[38])(@this, RenderTargetIndex, ppRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint RenderTargetIndex, ref IDirect3DSurface9* ppRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppRenderTargetPtr = &ppRenderTarget)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9**, int>)@this->LpVtbl[38])(@this, RenderTargetIndex, ppRenderTargetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDepthStencilSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pNewZStencil)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, int>)@this->LpVtbl[39])(@this, pNewZStencil);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDepthStencilSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pNewZStencil)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pNewZStencilPtr = &pNewZStencil)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, int>)@this->LpVtbl[39])(@this, pNewZStencilPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDepthStencilSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9** ppZStencilSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9**, int>)@this->LpVtbl[40])(@this, ppZStencilSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDepthStencilSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9* ppZStencilSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppZStencilSurfacePtr = &ppZStencilSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9**, int>)@this->LpVtbl[40])(@this, ppZStencilSurfacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginScene(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[41])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndScene(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[42])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clear(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Rect* pRects, uint Flags, uint Color, float Z, uint Stencil)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Rect*, uint, uint, float, uint, int>)@this->LpVtbl[43])(@this, Count, pRects, Flags, Color, Z, Stencil);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Clear(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Rect pRects, uint Flags, uint Color, float Z, uint Stencil)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Rect* pRectsPtr = &pRects)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Rect*, uint, uint, float, uint, int>)@this->LpVtbl[43])(@this, Count, pRectsPtr, Flags, Color, Z, Stencil);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype State, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* pMatrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[44])(@this, State, pMatrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype State, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 pMatrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (System.Numerics.Matrix4x4* pMatrixPtr = &pMatrix)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[44])(@this, State, pMatrixPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype State, System.Numerics.Matrix4x4* pMatrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[45])(@this, State, pMatrix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype State, ref System.Numerics.Matrix4x4 pMatrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (System.Numerics.Matrix4x4* pMatrixPtr = &pMatrix)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[45])(@this, State, pMatrixPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MultiplyTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* arg1)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[46])(@this, arg0, arg1);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MultiplyTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in System.Numerics.Matrix4x4 arg1)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (System.Numerics.Matrix4x4* arg1Ptr = &arg1)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[46])(@this, arg0, arg1Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetViewport(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Viewport9* pViewport)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Viewport9*, int>)@this->LpVtbl[47])(@this, pViewport);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetViewport(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Viewport9 pViewport)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Viewport9* pViewportPtr = &pViewport)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Viewport9*, int>)@this->LpVtbl[47])(@this, pViewportPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetViewport(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Viewport9* pViewport)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Viewport9*, int>)@this->LpVtbl[48])(@this, pViewport);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetViewport(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref Viewport9 pViewport)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Viewport9* pViewportPtr = &pViewport)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Viewport9*, int>)@this->LpVtbl[48])(@this, pViewportPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetMaterial(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material9* pMaterial)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Material9*, int>)@this->LpVtbl[49])(@this, pMaterial);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaterial(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Material9 pMaterial)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Material9* pMaterialPtr = &pMaterial)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Material9*, int>)@this->LpVtbl[49])(@this, pMaterialPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaterial(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Material9* pMaterial)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Material9*, int>)@this->LpVtbl[50])(@this, pMaterial);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMaterial(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref Material9 pMaterial)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Material9* pMaterialPtr = &pMaterial)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Material9*, int>)@this->LpVtbl[50])(@this, pMaterialPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetLight(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Light9* arg1)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Light9*, int>)@this->LpVtbl[51])(@this, Index, arg1);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLight(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Light9 arg1)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Light9* arg1Ptr = &arg1)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Light9*, int>)@this->LpVtbl[51])(@this, Index, arg1Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLight(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, Light9* arg1)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Light9*, int>)@this->LpVtbl[52])(@this, Index, arg1);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLight(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, ref Light9 arg1)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Light9* arg1Ptr = &arg1)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Light9*, int>)@this->LpVtbl[52])(@this, Index, arg1Ptr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LightEnable(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, Silk.NET.Core.Bool32 Enable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[53])(@this, Index, Enable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLightEnable(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, int* pEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, int>)@this->LpVtbl[54])(@this, Index, pEnable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLightEnable(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, ref int pEnable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pEnablePtr = &pEnable)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, int>)@this->LpVtbl[54])(@this, Index, pEnablePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetClipPlane(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pPlane)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, int>)@this->LpVtbl[55])(@this, Index, pPlane);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClipPlane(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pPlane)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pPlanePtr = &pPlane)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, int>)@this->LpVtbl[55])(@this, Index, pPlanePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClipPlane(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, float* pPlane)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, int>)@this->LpVtbl[56])(@this, Index, pPlane);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClipPlane(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, ref float pPlane)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pPlanePtr = &pPlane)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, int>)@this->LpVtbl[56])(@this, Index, pPlanePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Renderstatetype State, uint Value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Renderstatetype, uint, int>)@this->LpVtbl[57])(@this, State, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Renderstatetype State, uint* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Renderstatetype, uint*, int>)@this->LpVtbl[58])(@this, State, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Renderstatetype State, ref uint pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Renderstatetype, uint*, int>)@this->LpVtbl[58])(@this, State, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateBlock(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Stateblocktype Type, IDirect3DStateBlock9** ppSB)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Stateblocktype, IDirect3DStateBlock9**, int>)@this->LpVtbl[59])(@this, Type, ppSB);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStateBlock(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Stateblocktype Type, ref IDirect3DStateBlock9* ppSB)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Stateblocktype, IDirect3DStateBlock9**, int>)@this->LpVtbl[59])(@this, Type, ppSBPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginStateBlock(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int>)@this->LpVtbl[60])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndStateBlock(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DStateBlock9** ppSB)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DStateBlock9**, int>)@this->LpVtbl[61])(@this, ppSB);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndStateBlock(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DStateBlock9* ppSB)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DStateBlock9** ppSBPtr = &ppSB)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DStateBlock9**, int>)@this->LpVtbl[61])(@this, ppSBPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetClipStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Clipstatus9* pClipStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Clipstatus9*, int>)@this->LpVtbl[62])(@this, pClipStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetClipStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Clipstatus9 pClipStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Clipstatus9*, int>)@this->LpVtbl[62])(@this, pClipStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClipStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Clipstatus9* pClipStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Clipstatus9*, int>)@this->LpVtbl[63])(@this, pClipStatus);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClipStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref Clipstatus9 pClipStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Clipstatus9* pClipStatusPtr = &pClipStatus)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Clipstatus9*, int>)@this->LpVtbl[63])(@this, pClipStatusPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, IDirect3DBaseTexture9** ppTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9**, int>)@this->LpVtbl[64])(@this, Stage, ppTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, ref IDirect3DBaseTexture9* ppTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DBaseTexture9** ppTexturePtr = &ppTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9**, int>)@this->LpVtbl[64])(@this, Stage, ppTexturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, IDirect3DBaseTexture9* pTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9*, int>)@this->LpVtbl[65])(@this, Stage, pTexture);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, ref IDirect3DBaseTexture9 pTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DBaseTexture9* pTexturePtr = &pTexture)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9*, int>)@this->LpVtbl[65])(@this, Stage, pTexturePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextureStageState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, Texturestagestatetype Type, uint* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Texturestagestatetype, uint*, int>)@this->LpVtbl[66])(@this, Stage, Type, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTextureStageState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, Texturestagestatetype Type, ref uint pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Texturestagestatetype, uint*, int>)@this->LpVtbl[66])(@this, Stage, Type, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextureStageState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, Texturestagestatetype Type, uint Value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Texturestagestatetype, uint, int>)@this->LpVtbl[67])(@this, Stage, Type, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSamplerState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Sampler, Samplerstatetype Type, uint* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Samplerstatetype, uint*, int>)@this->LpVtbl[68])(@this, Sampler, Type, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSamplerState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Sampler, Samplerstatetype Type, ref uint pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Samplerstatetype, uint*, int>)@this->LpVtbl[68])(@this, Sampler, Type, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSamplerState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Sampler, Samplerstatetype Type, uint Value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Samplerstatetype, uint, int>)@this->LpVtbl[69])(@this, Sampler, Type, Value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateDevice(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint* pNumPasses)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[70])(@this, pNumPasses);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ValidateDevice(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref uint pNumPasses)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pNumPassesPtr = &pNumPasses)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[70])(@this, pNumPassesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPaletteEntries(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint PaletteNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector4D<byte>* pEntries)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[71])(@this, PaletteNumber, pEntries);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPaletteEntries(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint PaletteNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector4D<byte> pEntries)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector4D<byte>* pEntriesPtr = &pEntries)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[71])(@this, PaletteNumber, pEntriesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPaletteEntries(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint PaletteNumber, Silk.NET.Maths.Vector4D<byte>* pEntries)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[72])(@this, PaletteNumber, pEntries);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPaletteEntries(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint PaletteNumber, ref Silk.NET.Maths.Vector4D<byte> pEntries)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector4D<byte>* pEntriesPtr = &pEntries)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[72])(@this, PaletteNumber, pEntriesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCurrentTexturePalette(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint PaletteNumber)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int>)@this->LpVtbl[73])(@this, PaletteNumber);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTexturePalette(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint* PaletteNumber)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[74])(@this, PaletteNumber);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentTexturePalette(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref uint PaletteNumber)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* PaletteNumberPtr = &PaletteNumber)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[74])(@this, PaletteNumberPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetScissorRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[75])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetScissorRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[75])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetScissorRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[76])(@this, pRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetScissorRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref Silk.NET.Maths.Box2D<int> pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[76])(@this, pRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSoftwareVertexProcessing(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Silk.NET.Core.Bool32 bSoftware)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[77])(@this, bSoftware);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetSoftwareVertexProcessing(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Core.Bool32>)@this->LpVtbl[78])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetNPatchMode(this ComPtr<IDirect3DDevice9Ex> thisVtbl, float nSegments)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, float, int>)@this->LpVtbl[79])(@this, nSegments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetNPatchMode(this ComPtr<IDirect3DDevice9Ex> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, float>)@this->LpVtbl[80])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawPrimitive(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint StartVertex, uint PrimitiveCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, uint, int>)@this->LpVtbl[81])(@this, PrimitiveType, StartVertex, PrimitiveCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawIndexedPrimitive(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype arg0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, int, uint, uint, uint, uint, int>)@this->LpVtbl[82])(@this, arg0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawPrimitiveUP(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, void*, uint, int>)@this->LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawPrimitiveUP<T0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, void*, uint, int>)@this->LpVtbl[83])(@this, PrimitiveType, PrimitiveCount, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawIndexedPrimitiveUP(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawIndexedPrimitiveUP<T0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pVertexStreamZeroDataPtr = &pVertexStreamZeroData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroDataPtr, VertexStreamZeroStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawIndexedPrimitiveUP<T0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pIndexDataPtr = &pIndexData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexDataPtr, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawIndexedPrimitiveUP<T0, T1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ProcessVertices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessVertices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexDeclaration9* pVertexDeclPtr = &pVertexDecl)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDeclPtr, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessVertices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexBuffer9* pDestBufferPtr = &pDestBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)@this->LpVtbl[85])(@this, SrcStartIndex, DestIndex, VertexCount, pDestBufferPtr, pVertexDecl, Flags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ProcessVertices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Vertexelement9* pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElements, ppDecl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Vertexelement9* pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElements, ppDeclPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Vertexelement9 pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Vertexelement9* pVertexElementsPtr = &pVertexElements)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElementsPtr, ppDecl);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Vertexelement9 pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int SetVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DVertexDeclaration9* pDecl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9*, int>)@this->LpVtbl[87])(@this, pDecl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DVertexDeclaration9 pDecl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexDeclaration9* pDeclPtr = &pDecl)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9*, int>)@this->LpVtbl[87])(@this, pDeclPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DVertexDeclaration9** ppDecl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[88])(@this, ppDecl);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DVertexDeclaration9* ppDecl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexDeclaration9** ppDeclPtr = &ppDecl)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[88])(@this, ppDeclPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFVF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint FVF)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int>)@this->LpVtbl[89])(@this, FVF);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFVF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint* pFVF)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[90])(@this, pFVF);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFVF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref uint pFVF)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFVFPtr = &pFVF)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[90])(@this, pFVFPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, IDirect3DVertexShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunction, ppShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, ref IDirect3DVertexShader9* ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunction, ppShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, IDirect3DVertexShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFunctionPtr = &pFunction)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunctionPtr, ppShader);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, ref IDirect3DVertexShader9* ppShader)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int SetVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DVertexShader9* pShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexShader9*, int>)@this->LpVtbl[92])(@this, pShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DVertexShader9 pShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexShader9* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexShader9*, int>)@this->LpVtbl[92])(@this, pShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DVertexShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexShader9**, int>)@this->LpVtbl[93])(@this, ppShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DVertexShader9* ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexShader9** ppShaderPtr = &ppShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexShader9**, int>)@this->LpVtbl[93])(@this, ppShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[94])(@this, StartRegister, pConstantData, Vector4fCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[94])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, float* pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[95])(@this, StartRegister, pConstantData, Vector4fCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, ref float pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[95])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[96])(@this, StartRegister, pConstantData, Vector4iCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[96])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, int* pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[97])(@this, StartRegister, pConstantData, Vector4iCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, ref int pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[97])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetVertexShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[98])(@this, StartRegister, pConstantData, BoolCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[98])(@this, StartRegister, pConstantDataPtr, BoolCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVertexShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, int* pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[99])(@this, StartRegister, pConstantData, BoolCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, ref int pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[99])(@this, StartRegister, pConstantDataPtr, BoolCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9* pStreamData, uint OffsetInBytes, uint Stride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)@this->LpVtbl[100])(@this, StreamNumber, pStreamData, OffsetInBytes, Stride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9 pStreamData, uint OffsetInBytes, uint Stride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexBuffer9* pStreamDataPtr = &pStreamData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)@this->LpVtbl[100])(@this, StreamNumber, pStreamDataPtr, OffsetInBytes, Stride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, uint* pStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStride);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, ref uint pStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pStridePtr = &pStride)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStridePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint pOffsetInBytes, uint* pStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pOffsetInBytesPtr = &pOffsetInBytes)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytesPtr, pStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, ref uint pOffsetInBytes, ref uint pStride)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, uint* pStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexBuffer9** ppStreamDataPtr = &ppStreamData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamDataPtr, pOffsetInBytes, pStride);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, ref uint pStride)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint pOffsetInBytes, uint* pStride)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, ref uint pOffsetInBytes, ref uint pStride)
    {
        var @this = thisVtbl.Handle;
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
    public static int SetStreamSourceFreq(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, uint Setting)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, int>)@this->LpVtbl[102])(@this, StreamNumber, Setting);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSourceFreq(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, uint* pSetting)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint*, int>)@this->LpVtbl[103])(@this, StreamNumber, pSetting);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStreamSourceFreq(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref uint pSetting)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pSettingPtr = &pSetting)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint*, int>)@this->LpVtbl[103])(@this, StreamNumber, pSettingPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetIndices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DIndexBuffer9* pIndexData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9*, int>)@this->LpVtbl[104])(@this, pIndexData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetIndices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DIndexBuffer9 pIndexData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DIndexBuffer9* pIndexDataPtr = &pIndexData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9*, int>)@this->LpVtbl[104])(@this, pIndexDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIndices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DIndexBuffer9** ppIndexData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9**, int>)@this->LpVtbl[105])(@this, ppIndexData);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetIndices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DIndexBuffer9* ppIndexData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DIndexBuffer9** ppIndexDataPtr = &ppIndexData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9**, int>)@this->LpVtbl[105])(@this, ppIndexDataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, IDirect3DPixelShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunction, ppShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, ref IDirect3DPixelShader9* ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunction, ppShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, IDirect3DPixelShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pFunctionPtr = &pFunction)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunctionPtr, ppShader);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, ref IDirect3DPixelShader9* ppShader)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int SetPixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DPixelShader9* pShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DPixelShader9*, int>)@this->LpVtbl[107])(@this, pShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DPixelShader9 pShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DPixelShader9* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DPixelShader9*, int>)@this->LpVtbl[107])(@this, pShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DPixelShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DPixelShader9**, int>)@this->LpVtbl[108])(@this, ppShader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DPixelShader9* ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DPixelShader9** ppShaderPtr = &ppShader)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DPixelShader9**, int>)@this->LpVtbl[108])(@this, ppShaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPixelShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[109])(@this, StartRegister, pConstantData, Vector4fCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[109])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, float* pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[110])(@this, StartRegister, pConstantData, Vector4fCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, ref float pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[110])(@this, StartRegister, pConstantDataPtr, Vector4fCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPixelShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[111])(@this, StartRegister, pConstantData, Vector4iCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[111])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, int* pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[112])(@this, StartRegister, pConstantData, Vector4iCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, ref int pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[112])(@this, StartRegister, pConstantDataPtr, Vector4iCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetPixelShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[113])(@this, StartRegister, pConstantData, BoolCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[113])(@this, StartRegister, pConstantDataPtr, BoolCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, int* pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[114])(@this, StartRegister, pConstantData, BoolCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, ref int pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pConstantDataPtr = &pConstantData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[114])(@this, StartRegister, pConstantDataPtr, BoolCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RectpatchInfo* pRectPatchInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RectpatchInfo pRectPatchInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RectpatchInfo* pRectPatchInfoPtr = &pRectPatchInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegs, pRectPatchInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RectpatchInfo* pRectPatchInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pNumSegsPtr = &pNumSegs)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, RectpatchInfo*, int>)@this->LpVtbl[115])(@this, Handle, pNumSegsPtr, pRectPatchInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawRectPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RectpatchInfo pRectPatchInfo)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int DrawTriPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TripatchInfo* pTriPatchInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfo);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawTriPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TripatchInfo pTriPatchInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TripatchInfo* pTriPatchInfoPtr = &pTriPatchInfo)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfoPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawTriPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TripatchInfo* pTriPatchInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pNumSegsPtr = &pNumSegs)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegsPtr, pTriPatchInfo);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawTriPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TripatchInfo pTriPatchInfo)
    {
        var @this = thisVtbl.Handle;
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
    public static int DeletePatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int>)@this->LpVtbl[117])(@this, Handle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQuery(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Querytype Type, IDirect3DQuery9** ppQuery)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Querytype, IDirect3DQuery9**, int>)@this->LpVtbl[118])(@this, Type, ppQuery);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQuery(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Querytype Type, ref IDirect3DQuery9* ppQuery)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DQuery9** ppQueryPtr = &ppQuery)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Querytype, IDirect3DQuery9**, int>)@this->LpVtbl[118])(@this, Type, ppQueryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetConvolutionMonoKernel(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint width, uint height, float* rows, float* columns)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, float*, float*, int>)@this->LpVtbl[119])(@this, width, height, rows, columns);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetConvolutionMonoKernel(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint width, uint height, float* rows, ref float columns)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* columnsPtr = &columns)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, float*, float*, int>)@this->LpVtbl[119])(@this, width, height, rows, columnsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetConvolutionMonoKernel(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint width, uint height, ref float rows, float* columns)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* rowsPtr = &rows)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, float*, float*, int>)@this->LpVtbl[119])(@this, width, height, rowsPtr, columns);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetConvolutionMonoKernel(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint width, uint height, ref float rows, ref float columns)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDst, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexBuffer9* pDstRectDescsPtr = &pDstRectDescs)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDst, pSrcRectDescs, NumRects, pDstRectDescsPtr, Operation, Xoffset, Yoffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DVertexBuffer9* pSrcRectDescsPtr = &pSrcRectDescs)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDst, pSrcRectDescsPtr, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, ref IDirect3DSurface9 pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pDstPtr = &pDst)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrc, pDstPtr, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, ref IDirect3DSurface9 pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9* pSrcPtr = &pSrc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, IDirect3DVertexBuffer9*, uint, IDirect3DVertexBuffer9*, Composerectsop, int, int, int>)@this->LpVtbl[120])(@this, pSrcPtr, pDst, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, IDirect3DSurface9* pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, IDirect3DSurface9* pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRect, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRectPtr, pDestRect, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegion, dwFlags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RGNData pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* pSourceRectPtr = &pSourceRect)
        {
            fixed (Silk.NET.Maths.Box2D<int>* pDestRectPtr = &pDestRect)
            {
                fixed (RGNData* pDirtyRegionPtr = &pDirtyRegion)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRectPtr, pDestRectPtr, hDestWindowOverride, pDirtyRegionPtr, dwFlags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGPUThreadPriority(this ComPtr<IDirect3DDevice9Ex> thisVtbl, int* pPriority)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int*, int>)@this->LpVtbl[122])(@this, pPriority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGPUThreadPriority(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref int pPriority)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* pPriorityPtr = &pPriority)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int*, int>)@this->LpVtbl[122])(@this, pPriorityPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetGPUThreadPriority(this ComPtr<IDirect3DDevice9Ex> thisVtbl, int Priority)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, int, int>)@this->LpVtbl[123])(@this, Priority);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WaitForVBlank(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int>)@this->LpVtbl[124])(@this, iSwapChain);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckResourceResidency(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DResource9** pResourceArray, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DResource9**, uint, int>)@this->LpVtbl[125])(@this, pResourceArray, NumResources);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckResourceResidency(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DResource9* pResourceArray, uint NumResources)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DResource9** pResourceArrayPtr = &pResourceArray)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DResource9**, uint, int>)@this->LpVtbl[125])(@this, pResourceArrayPtr, NumResources);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaximumFrameLatency(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint MaxLatency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int>)@this->LpVtbl[126])(@this, MaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMaximumFrameLatency(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint* pMaxLatency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[127])(@this, pMaxLatency);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumFrameLatency(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref uint pMaxLatency)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pMaxLatencyPtr = &pMaxLatency)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, int>)@this->LpVtbl[127])(@this, pMaxLatencyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CheckDeviceState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, nint hDestinationWindow)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, nint, int>)@this->LpVtbl[128])(@this, hDestinationWindow);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTargetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, IDirect3DSurface9** ppSurface, void** pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[129])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle, Usage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTargetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, IDirect3DSurface9** ppSurface, ref void* pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[129])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandlePtr, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTargetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref IDirect3DSurface9* ppSurface, void** pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[129])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandle, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTargetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[129])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurfacePtr, pSharedHandlePtr, Usage);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurfaceEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, void** pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[130])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle, Usage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurfaceEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, ref void* pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[130])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandlePtr, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurfaceEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, void** pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[130])(@this, Width, Height, Format, Pool, ppSurfacePtr, pSharedHandle, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurfaceEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CreateDepthStencilSurfaceEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, IDirect3DSurface9** ppSurface, void** pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[131])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle, Usage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurfaceEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, IDirect3DSurface9** ppSurface, ref void* pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** pSharedHandlePtr = &pSharedHandle)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[131])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandlePtr, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurfaceEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref IDirect3DSurface9* ppSurface, void** pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[131])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandle, Usage);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurfaceEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref IDirect3DSurface9* ppSurface, ref void* pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DSurface9** ppSurfacePtr = &ppSurface)
        {
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[131])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurfacePtr, pSharedHandlePtr, Usage);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, PresentParameters* pPresentationParameters, Displaymodeex* pFullscreenDisplayMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, Displaymodeex*, int>)@this->LpVtbl[132])(@this, pPresentationParameters, pFullscreenDisplayMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, PresentParameters* pPresentationParameters, ref Displaymodeex pFullscreenDisplayMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Displaymodeex* pFullscreenDisplayModePtr = &pFullscreenDisplayMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, Displaymodeex*, int>)@this->LpVtbl[132])(@this, pPresentationParameters, pFullscreenDisplayModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref PresentParameters pPresentationParameters, Displaymodeex* pFullscreenDisplayMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, Displaymodeex*, int>)@this->LpVtbl[132])(@this, pPresentationParametersPtr, pFullscreenDisplayMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ResetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref PresentParameters pPresentationParameters, ref Displaymodeex pFullscreenDisplayMode)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetDisplayModeEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Displaymodeex* pMode, Displayrotation* pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[133])(@this, iSwapChain, pMode, pRotation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Displaymodeex* pMode, ref Displayrotation pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Displayrotation* pRotationPtr = &pRotation)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[133])(@this, iSwapChain, pMode, pRotationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, ref Displaymodeex pMode, Displayrotation* pRotation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Displaymodeex* pModePtr = &pMode)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[133])(@this, iSwapChain, pModePtr, pRotation);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, ref Displaymodeex pMode, ref Displayrotation pRotation)
    {
        var @this = thisVtbl.Handle;
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
    public static int QueryInterface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetDirect3D<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref ComPtr<TI0> ppD3D9) where TI0 : unmanaged, IComVtbl<IDirect3D9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDirect3D((IDirect3D9**) ppD3D9.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetDeviceCaps(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<Caps9> pCaps)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeviceCaps(ref pCaps.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayMode(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Span<Displaymode> pMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayMode(iSwapChain, ref pMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCreationParameters(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<DeviceCreationParameters> pParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCreationParameters(ref pParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetCursorProperties<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint XHotSpot, uint YHotSpot, ComPtr<TI0> pCursorBitmap) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetCursorProperties(XHotSpot, YHotSpot, (IDirect3DSurface9*) pCursorBitmap.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetCursorProperties(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint XHotSpot, uint YHotSpot, Span<IDirect3DSurface9> pCursorBitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetCursorProperties(XHotSpot, YHotSpot, ref pCursorBitmap.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, PresentParameters* pPresentationParameters, ref ComPtr<TI0> pSwapChain) where TI0 : unmanaged, IComVtbl<IDirect3DSwapChain9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateAdditionalSwapChain(pPresentationParameters, (IDirect3DSwapChain9**) pSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<PresentParameters> pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateAdditionalSwapChain(ref pPresentationParameters.GetPinnableReference(), pSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int CreateAdditionalSwapChain<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref PresentParameters pPresentationParameters, ref ComPtr<TI0> pSwapChain) where TI0 : unmanaged, IComVtbl<IDirect3DSwapChain9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateAdditionalSwapChain(ref pPresentationParameters, (IDirect3DSwapChain9**) pSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateAdditionalSwapChain(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<PresentParameters> pPresentationParameters, ref IDirect3DSwapChain9* pSwapChain)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateAdditionalSwapChain(ref pPresentationParameters.GetPinnableReference(), ref pSwapChain);
    }

    /// <summary>To be documented.</summary>
    public static int GetSwapChain<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, ref ComPtr<TI0> pSwapChain) where TI0 : unmanaged, IComVtbl<IDirect3DSwapChain9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSwapChain(iSwapChain, (IDirect3DSwapChain9**) pSwapChain.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<PresentParameters> pPresentationParameters)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reset(ref pPresentationParameters.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(pSourceRect, pDestRect, hDestWindowOverride, in pDirtyRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(pSourceRect, in pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(pSourceRect, in pDestRect.GetPinnableReference(), hDestWindowOverride, in pDirtyRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(in pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, pDirtyRegion);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(in pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, in pDirtyRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(in pSourceRect.GetPinnableReference(), in pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion);
    }

    /// <summary>To be documented.</summary>
    public static int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Present(in pSourceRect.GetPinnableReference(), in pDestRect.GetPinnableReference(), hDestWindowOverride, in pDirtyRegion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBackBuffer<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, uint iBackBuffer, BackbufferType Type, ref ComPtr<TI0> ppBackBuffer) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBackBuffer(iSwapChain, iBackBuffer, Type, (IDirect3DSurface9**) ppBackBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetRasterStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Span<RasterStatus> pRasterStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRasterStatus(iSwapChain, ref pRasterStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetGammaRamp(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, uint Flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Gammaramp> pRamp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetGammaRamp(iSwapChain, Flags, in pRamp.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetGammaRamp(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Span<Gammaramp> pRamp)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetGammaRamp(iSwapChain, ref pRamp.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTexture<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppTexture, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DTexture9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTexture(Width, Height, Levels, Usage, Format, Pool, (IDirect3DTexture9**) ppTexture.GetAddressOf(), pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTexture<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppTexture, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DTexture9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTexture(Width, Height, Levels, Usage, Format, Pool, (IDirect3DTexture9**) ppTexture.GetAddressOf(), ref pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVolumeTexture<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppVolumeTexture, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DVolumeTexture9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVolumeTexture(Width, Height, Depth, Levels, Usage, Format, Pool, (IDirect3DVolumeTexture9**) ppVolumeTexture.GetAddressOf(), pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVolumeTexture<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppVolumeTexture, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DVolumeTexture9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVolumeTexture(Width, Height, Depth, Levels, Usage, Format, Pool, (IDirect3DVolumeTexture9**) ppVolumeTexture.GetAddressOf(), ref pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCubeTexture<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppCubeTexture, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCubeTexture9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCubeTexture(EdgeLength, Levels, Usage, Format, Pool, (IDirect3DCubeTexture9**) ppCubeTexture.GetAddressOf(), pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCubeTexture<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint EdgeLength, uint Levels, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppCubeTexture, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DCubeTexture9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCubeTexture(EdgeLength, Levels, Usage, Format, Pool, (IDirect3DCubeTexture9**) ppCubeTexture.GetAddressOf(), ref pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, ref ComPtr<TI0> ppVertexBuffer, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexBuffer(Length, Usage, FVF, Pool, (IDirect3DVertexBuffer9**) ppVertexBuffer.GetAddressOf(), pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexBuffer<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, ref ComPtr<TI0> ppVertexBuffer, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexBuffer(Length, Usage, FVF, Pool, (IDirect3DVertexBuffer9**) ppVertexBuffer.GetAddressOf(), ref pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIndexBuffer<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppIndexBuffer, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DIndexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateIndexBuffer(Length, Usage, Format, Pool, (IDirect3DIndexBuffer9**) ppIndexBuffer.GetAddressOf(), pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateIndexBuffer<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, Format Format, Pool Pool, ref ComPtr<TI0> ppIndexBuffer, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DIndexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateIndexBuffer(Length, Usage, Format, Pool, (IDirect3DIndexBuffer9**) ppIndexBuffer.GetAddressOf(), ref pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTarget<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref ComPtr<TI0> ppSurface, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRenderTarget(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, (IDirect3DSurface9**) ppSurface.GetAddressOf(), pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTarget<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref ComPtr<TI0> ppSurface, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRenderTarget(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, (IDirect3DSurface9**) ppSurface.GetAddressOf(), ref pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref ComPtr<TI0> ppSurface, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDepthStencilSurface(Width, Height, Format, MultiSample, MultisampleQuality, Discard, (IDirect3DSurface9**) ppSurface.GetAddressOf(), pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref ComPtr<TI0> ppSurface, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDepthStencilSurface(Width, Height, Format, MultiSample, MultisampleQuality, Discard, (IDirect3DSurface9**) ppSurface.GetAddressOf(), ref pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI1> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<int>> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, pSourceRect, pDestinationSurface, in pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI1> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, in pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, pSourceRect, ref pDestinationSurface.GetPinnableReference(), pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, ref pDestinationSurface, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<int>> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, pSourceRect, ref pDestinationSurface.GetPinnableReference(), in pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, ref pDestinationSurface, in pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, in pSourceRect.GetPinnableReference(), pDestinationSurface, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI1> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<int>> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, in pSourceRect.GetPinnableReference(), pDestinationSurface, in pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int UpdateSurface<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI1> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, in pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, in pSourceRect.GetPinnableReference(), ref pDestinationSurface.GetPinnableReference(), pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, ref pDestinationSurface, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<int>> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(pSourceSurface, in pSourceRect.GetPinnableReference(), ref pDestinationSurface.GetPinnableReference(), in pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int UpdateSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, ref pDestinationSurface, in pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), pSourceRect, pDestinationSurface, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI0> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface(ref pSourceSurface, pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<int>> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), pSourceRect, pDestinationSurface, in pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI0> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface(ref pSourceSurface, pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, in pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), pSourceRect, ref pDestinationSurface.GetPinnableReference(), pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<int>> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), pSourceRect, ref pDestinationSurface.GetPinnableReference(), in pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), in pSourceRect.GetPinnableReference(), pDestinationSurface, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI0> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface(ref pSourceSurface, in pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<int>> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), in pSourceRect.GetPinnableReference(), pDestinationSurface, in pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int UpdateSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI0> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<int> pDestPoint) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateSurface(ref pSourceSurface, in pSourceRect, (IDirect3DSurface9*) pDestinationSurface.Handle, in pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), in pSourceRect.GetPinnableReference(), ref pDestinationSurface.GetPinnableReference(), pDestPoint);
    }

    /// <summary>To be documented.</summary>
    public static int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, Span<IDirect3DSurface9> pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<int>> pDestPoint)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateSurface(ref pSourceSurface.GetPinnableReference(), in pSourceRect.GetPinnableReference(), ref pDestinationSurface.GetPinnableReference(), in pDestPoint.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int UpdateTexture<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceTexture, ComPtr<TI1> pDestinationTexture) where TI0 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateTexture((IDirect3DBaseTexture9*) pSourceTexture.Handle, (IDirect3DBaseTexture9*) pDestinationTexture.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DBaseTexture9* pSourceTexture, Span<IDirect3DBaseTexture9> pDestinationTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateTexture(pSourceTexture, ref pDestinationTexture.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int UpdateTexture<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceTexture, ref IDirect3DBaseTexture9 pDestinationTexture) where TI0 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateTexture((IDirect3DBaseTexture9*) pSourceTexture.Handle, ref pDestinationTexture);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UpdateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DBaseTexture9> pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateTexture(ref pSourceTexture.GetPinnableReference(), pDestinationTexture);
    }

    /// <summary>To be documented.</summary>
    public static int UpdateTexture<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DBaseTexture9 pSourceTexture, ComPtr<TI0> pDestinationTexture) where TI0 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UpdateTexture(ref pSourceTexture, (IDirect3DBaseTexture9*) pDestinationTexture.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int UpdateTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DBaseTexture9> pSourceTexture, Span<IDirect3DBaseTexture9> pDestinationTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UpdateTexture(ref pSourceTexture.GetPinnableReference(), ref pDestinationTexture.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderTargetData<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pRenderTarget, ComPtr<TI1> pDestSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRenderTargetData((IDirect3DSurface9*) pRenderTarget.Handle, (IDirect3DSurface9*) pDestSurface.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTargetData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pRenderTarget, Span<IDirect3DSurface9> pDestSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRenderTargetData(pRenderTarget, ref pDestSurface.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderTargetData<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pRenderTarget, ref IDirect3DSurface9 pDestSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRenderTargetData((IDirect3DSurface9*) pRenderTarget.Handle, ref pDestSurface);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRenderTargetData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pRenderTarget, IDirect3DSurface9* pDestSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRenderTargetData(ref pRenderTarget.GetPinnableReference(), pDestSurface);
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderTargetData<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pRenderTarget, ComPtr<TI0> pDestSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRenderTargetData(ref pRenderTarget, (IDirect3DSurface9*) pDestSurface.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderTargetData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pRenderTarget, Span<IDirect3DSurface9> pDestSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRenderTargetData(ref pRenderTarget.GetPinnableReference(), ref pDestSurface.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFrontBufferData<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, ComPtr<TI0> pDestSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFrontBufferData(iSwapChain, (IDirect3DSurface9*) pDestSurface.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int GetFrontBufferData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Span<IDirect3DSurface9> pDestSurface)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFrontBufferData(iSwapChain, ref pDestSurface.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI1> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, pSourceRect, pDestSurface, in pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI1> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, in pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, Span<IDirect3DSurface9> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, pSourceRect, ref pDestSurface.GetPinnableReference(), pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, ref pDestSurface, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, Span<IDirect3DSurface9> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, pSourceRect, ref pDestSurface.GetPinnableReference(), in pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, pSourceRect, ref pDestSurface, in pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, in pSourceRect.GetPinnableReference(), pDestSurface, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI1> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, in pSourceRect.GetPinnableReference(), pDestSurface, in pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static int StretchRect<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI1> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, in pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, Span<IDirect3DSurface9> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, in pSourceRect.GetPinnableReference(), ref pDestSurface.GetPinnableReference(), pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, ref pDestSurface, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, Span<IDirect3DSurface9> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(pSourceSurface, in pSourceRect.GetPinnableReference(), ref pDestSurface.GetPinnableReference(), in pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static int StretchRect<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ref IDirect3DSurface9 pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect((IDirect3DSurface9*) pSourceSurface.Handle, in pSourceRect, ref pDestSurface, in pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), pSourceRect, pDestSurface, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI0> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect(ref pSourceSurface, pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), pSourceRect, pDestSurface, in pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, ComPtr<TI0> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect(ref pSourceSurface, pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, in pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, Span<IDirect3DSurface9> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), pSourceRect, ref pDestSurface.GetPinnableReference(), pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, Span<IDirect3DSurface9> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), pSourceRect, ref pDestSurface.GetPinnableReference(), in pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), in pSourceRect.GetPinnableReference(), pDestSurface, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI0> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect(ref pSourceSurface, in pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), in pSourceRect.GetPinnableReference(), pDestSurface, in pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static int StretchRect<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pSourceRect, ComPtr<TI0> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pDestRect, Texturefiltertype Filter) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->StretchRect(ref pSourceSurface, in pSourceRect, (IDirect3DSurface9*) pDestSurface.Handle, in pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, Span<IDirect3DSurface9> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), in pSourceRect.GetPinnableReference(), ref pDestSurface.GetPinnableReference(), pDestRect, Filter);
    }

    /// <summary>To be documented.</summary>
    public static int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, Span<IDirect3DSurface9> pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StretchRect(ref pSourceSurface.GetPinnableReference(), in pSourceRect.GetPinnableReference(), ref pDestSurface.GetPinnableReference(), in pDestRect.GetPinnableReference(), Filter);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint color) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ColorFill((IDirect3DSurface9*) pSurface.Handle, pRect, color);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pRect, uint color)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ColorFill(pSurface, in pRect.GetPinnableReference(), color);
    }

    /// <summary>To be documented.</summary>
    public static int ColorFill<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> pRect, uint color) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ColorFill((IDirect3DSurface9*) pSurface.Handle, in pRect, color);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ColorFill(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint color)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ColorFill(ref pSurface.GetPinnableReference(), pRect, color);
    }

    /// <summary>To be documented.</summary>
    public static int ColorFill(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pRect, uint color)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ColorFill(ref pSurface.GetPinnableReference(), in pRect.GetPinnableReference(), color);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref ComPtr<TI0> ppSurface, void** pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateOffscreenPlainSurface(Width, Height, Format, Pool, (IDirect3DSurface9**) ppSurface.GetAddressOf(), pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref ComPtr<TI0> ppSurface, ref void* pSharedHandle) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateOffscreenPlainSurface(Width, Height, Format, Pool, (IDirect3DSurface9**) ppSurface.GetAddressOf(), ref pSharedHandle);
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderTarget<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint RenderTargetIndex, ComPtr<TI0> pRenderTarget) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetRenderTarget(RenderTargetIndex, (IDirect3DSurface9*) pRenderTarget.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint RenderTargetIndex, Span<IDirect3DSurface9> pRenderTarget)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetRenderTarget(RenderTargetIndex, ref pRenderTarget.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderTarget<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint RenderTargetIndex, ref ComPtr<TI0> ppRenderTarget) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRenderTarget(RenderTargetIndex, (IDirect3DSurface9**) ppRenderTarget.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetDepthStencilSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pNewZStencil) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetDepthStencilSurface((IDirect3DSurface9*) pNewZStencil.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetDepthStencilSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pNewZStencil)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetDepthStencilSurface(ref pNewZStencil.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDepthStencilSurface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref ComPtr<TI0> ppZStencilSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDepthStencilSurface((IDirect3DSurface9**) ppZStencilSurface.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int Clear(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Rect> pRects, uint Flags, uint Color, float Z, uint Stencil)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Clear(Count, in pRects.GetPinnableReference(), Flags, Color, Z, Stencil);
    }

    /// <summary>To be documented.</summary>
    public static int SetTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype State, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> pMatrix)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTransform(State, in pMatrix.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype State, Span<System.Numerics.Matrix4x4> pMatrix)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTransform(State, ref pMatrix.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MultiplyTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> arg1)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MultiplyTransform(arg0, in arg1.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetViewport(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Viewport9> pViewport)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetViewport(in pViewport.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetViewport(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<Viewport9> pViewport)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetViewport(ref pViewport.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetMaterial(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material9> pMaterial)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetMaterial(in pMaterial.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMaterial(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<Material9> pMaterial)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMaterial(ref pMaterial.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetLight(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Light9> arg1)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetLight(Index, in arg1.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLight(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, Span<Light9> arg1)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLight(Index, ref arg1.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLightEnable(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, Span<int> pEnable)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLightEnable(Index, ref pEnable.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetClipPlane(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pPlane)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetClipPlane(Index, in pPlane.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetClipPlane(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, Span<float> pPlane)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClipPlane(Index, ref pPlane.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRenderState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Renderstatetype State, Span<uint> pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRenderState(State, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateStateBlock<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Stateblocktype Type, ref ComPtr<TI0> ppSB) where TI0 : unmanaged, IComVtbl<IDirect3DStateBlock9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStateBlock(Type, (IDirect3DStateBlock9**) ppSB.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int EndStateBlock<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref ComPtr<TI0> ppSB) where TI0 : unmanaged, IComVtbl<IDirect3DStateBlock9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->EndStateBlock((IDirect3DStateBlock9**) ppSB.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetClipStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Clipstatus9> pClipStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetClipStatus(in pClipStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetClipStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<Clipstatus9> pClipStatus)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClipStatus(ref pClipStatus.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTexture<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, ref ComPtr<TI0> ppTexture) where TI0 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTexture(Stage, (IDirect3DBaseTexture9**) ppTexture.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetTexture<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, ComPtr<TI0> pTexture) where TI0 : unmanaged, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetTexture(Stage, (IDirect3DBaseTexture9*) pTexture.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, Span<IDirect3DBaseTexture9> pTexture)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTexture(Stage, ref pTexture.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTextureStageState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, Texturestagestatetype Type, Span<uint> pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextureStageState(Stage, Type, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSamplerState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Sampler, Samplerstatetype Type, Span<uint> pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSamplerState(Sampler, Type, ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ValidateDevice(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<uint> pNumPasses)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ValidateDevice(ref pNumPasses.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetPaletteEntries(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint PaletteNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector4D<byte>> pEntries)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPaletteEntries(PaletteNumber, in pEntries.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPaletteEntries(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint PaletteNumber, Span<Silk.NET.Maths.Vector4D<byte>> pEntries)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPaletteEntries(PaletteNumber, ref pEntries.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentTexturePalette(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<uint> PaletteNumber)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentTexturePalette(ref PaletteNumber.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetScissorRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetScissorRect(in pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetScissorRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<Silk.NET.Maths.Box2D<int>> pRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetScissorRect(ref pRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawPrimitiveUP<T0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawPrimitiveUP(PrimitiveType, PrimitiveCount, in pVertexStreamZeroData.GetPinnableReference(), VertexStreamZeroStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawIndexedPrimitiveUP<T0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawIndexedPrimitiveUP(PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, in pVertexStreamZeroData.GetPinnableReference(), VertexStreamZeroStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawIndexedPrimitiveUP<T0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawIndexedPrimitiveUP(PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, in pIndexData.GetPinnableReference(), IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
    }

    /// <summary>To be documented.</summary>
    public static int DrawIndexedPrimitiveUP<T0, T1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pVertexStreamZeroData, uint VertexStreamZeroStride) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawIndexedPrimitiveUP(PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, in pIndexData.GetPinnableReference(), IndexDataFormat, in pVertexStreamZeroData.GetPinnableReference(), VertexStreamZeroStride);
    }

    /// <summary>To be documented.</summary>
    public static int ProcessVertices<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, ComPtr<TI0> pDestBuffer, ComPtr<TI1> pVertexDecl, uint Flags) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, (IDirect3DVertexBuffer9*) pDestBuffer.Handle, (IDirect3DVertexDeclaration9*) pVertexDecl.Handle, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessVertices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, Span<IDirect3DVertexDeclaration9> pVertexDecl, uint Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, pDestBuffer, ref pVertexDecl.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static int ProcessVertices<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, ComPtr<TI0> pDestBuffer, ref IDirect3DVertexDeclaration9 pVertexDecl, uint Flags) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, (IDirect3DVertexBuffer9*) pDestBuffer.Handle, ref pVertexDecl, Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ProcessVertices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, Span<IDirect3DVertexBuffer9> pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, uint Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, ref pDestBuffer.GetPinnableReference(), pVertexDecl, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int ProcessVertices<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, ref IDirect3DVertexBuffer9 pDestBuffer, ComPtr<TI0> pVertexDecl, uint Flags) where TI0 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, ref pDestBuffer, (IDirect3DVertexDeclaration9*) pVertexDecl.Handle, Flags);
    }

    /// <summary>To be documented.</summary>
    public static int ProcessVertices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint SrcStartIndex, uint DestIndex, uint VertexCount, Span<IDirect3DVertexBuffer9> pDestBuffer, Span<IDirect3DVertexDeclaration9> pVertexDecl, uint Flags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ProcessVertices(SrcStartIndex, DestIndex, VertexCount, ref pDestBuffer.GetPinnableReference(), ref pVertexDecl.GetPinnableReference(), Flags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Vertexelement9* pVertexElements, ref ComPtr<TI0> ppDecl) where TI0 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexDeclaration(pVertexElements, (IDirect3DVertexDeclaration9**) ppDecl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Vertexelement9> pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexDeclaration(in pVertexElements.GetPinnableReference(), ppDecl);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVertexDeclaration<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Vertexelement9 pVertexElements, ref ComPtr<TI0> ppDecl) where TI0 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexDeclaration(in pVertexElements, (IDirect3DVertexDeclaration9**) ppDecl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Vertexelement9> pVertexElements, ref IDirect3DVertexDeclaration9* ppDecl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexDeclaration(in pVertexElements.GetPinnableReference(), ref ppDecl);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexDeclaration<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pDecl) where TI0 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetVertexDeclaration((IDirect3DVertexDeclaration9*) pDecl.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DVertexDeclaration9> pDecl)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexDeclaration(ref pDecl.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexDeclaration<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref ComPtr<TI0> ppDecl) where TI0 : unmanaged, IComVtbl<IDirect3DVertexDeclaration9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetVertexDeclaration((IDirect3DVertexDeclaration9**) ppDecl.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFVF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<uint> pFVF)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFVF(ref pFVF.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DVertexShader9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexShader(pFunction, (IDirect3DVertexShader9**) ppShader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pFunction, IDirect3DVertexShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexShader(in pFunction.GetPinnableReference(), ppShader);
    }

    /// <summary>To be documented.</summary>
    public static int CreateVertexShader<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DVertexShader9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateVertexShader(in pFunction, (IDirect3DVertexShader9**) ppShader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pFunction, ref IDirect3DVertexShader9* ppShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateVertexShader(in pFunction.GetPinnableReference(), ref ppShader);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShader<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pShader) where TI0 : unmanaged, IComVtbl<IDirect3DVertexShader9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetVertexShader((IDirect3DVertexShader9*) pShader.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DVertexShader9> pShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexShader(ref pShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShader<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DVertexShader9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetVertexShader((IDirect3DVertexShader9**) ppShader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexShaderConstantF(StartRegister, in pConstantData.GetPinnableReference(), Vector4fCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, Span<float> pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVertexShaderConstantF(StartRegister, ref pConstantData.GetPinnableReference(), Vector4fCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexShaderConstantI(StartRegister, in pConstantData.GetPinnableReference(), Vector4iCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, Span<int> pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVertexShaderConstantI(StartRegister, ref pConstantData.GetPinnableReference(), Vector4iCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetVertexShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetVertexShaderConstantB(StartRegister, in pConstantData.GetPinnableReference(), BoolCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetVertexShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, Span<int> pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVertexShaderConstantB(StartRegister, ref pConstantData.GetPinnableReference(), BoolCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetStreamSource<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ComPtr<TI0> pStreamData, uint OffsetInBytes, uint Stride) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetStreamSource(StreamNumber, (IDirect3DVertexBuffer9*) pStreamData.Handle, OffsetInBytes, Stride);
    }

    /// <summary>To be documented.</summary>
    public static int SetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, Span<IDirect3DVertexBuffer9> pStreamData, uint OffsetInBytes, uint Stride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetStreamSource(StreamNumber, ref pStreamData.GetPinnableReference(), OffsetInBytes, Stride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref ComPtr<TI0> ppStreamData, uint* pOffsetInBytes, uint* pStride) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetStreamSource(StreamNumber, (IDirect3DVertexBuffer9**) ppStreamData.GetAddressOf(), pOffsetInBytes, pStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, Span<uint> pStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ppStreamData, pOffsetInBytes, ref pStride.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref ComPtr<TI0> ppStreamData, uint* pOffsetInBytes, ref uint pStride) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetStreamSource(StreamNumber, (IDirect3DVertexBuffer9**) ppStreamData.GetAddressOf(), pOffsetInBytes, ref pStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, Span<uint> pOffsetInBytes, uint* pStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ppStreamData, ref pOffsetInBytes.GetPinnableReference(), pStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref ComPtr<TI0> ppStreamData, ref uint pOffsetInBytes, uint* pStride) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetStreamSource(StreamNumber, (IDirect3DVertexBuffer9**) ppStreamData.GetAddressOf(), ref pOffsetInBytes, pStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, Span<uint> pOffsetInBytes, Span<uint> pStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ppStreamData, ref pOffsetInBytes.GetPinnableReference(), ref pStride.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetStreamSource<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref ComPtr<TI0> ppStreamData, ref uint pOffsetInBytes, ref uint pStride) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetStreamSource(StreamNumber, (IDirect3DVertexBuffer9**) ppStreamData.GetAddressOf(), ref pOffsetInBytes, ref pStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, uint* pOffsetInBytes, Span<uint> pStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ref ppStreamData, pOffsetInBytes, ref pStride.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, Span<uint> pOffsetInBytes, uint* pStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ref ppStreamData, ref pOffsetInBytes.GetPinnableReference(), pStride);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, ref IDirect3DVertexBuffer9* ppStreamData, Span<uint> pOffsetInBytes, Span<uint> pStride)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamSource(StreamNumber, ref ppStreamData, ref pOffsetInBytes.GetPinnableReference(), ref pStride.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetStreamSourceFreq(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, Span<uint> pSetting)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStreamSourceFreq(StreamNumber, ref pSetting.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetIndices<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pIndexData) where TI0 : unmanaged, IComVtbl<IDirect3DIndexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetIndices((IDirect3DIndexBuffer9*) pIndexData.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetIndices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DIndexBuffer9> pIndexData)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetIndices(ref pIndexData.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetIndices<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref ComPtr<TI0> ppIndexData) where TI0 : unmanaged, IComVtbl<IDirect3DIndexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetIndices((IDirect3DIndexBuffer9**) ppIndexData.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DPixelShader9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePixelShader(pFunction, (IDirect3DPixelShader9**) ppShader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pFunction, IDirect3DPixelShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePixelShader(in pFunction.GetPinnableReference(), ppShader);
    }

    /// <summary>To be documented.</summary>
    public static int CreatePixelShader<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pFunction, ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DPixelShader9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreatePixelShader(in pFunction, (IDirect3DPixelShader9**) ppShader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreatePixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pFunction, ref IDirect3DPixelShader9* ppShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreatePixelShader(in pFunction.GetPinnableReference(), ref ppShader);
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShader<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pShader) where TI0 : unmanaged, IComVtbl<IDirect3DPixelShader9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetPixelShader((IDirect3DPixelShader9*) pShader.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DPixelShader9> pShader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPixelShader(ref pShader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShader<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref ComPtr<TI0> ppShader) where TI0 : unmanaged, IComVtbl<IDirect3DPixelShader9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPixelShader((IDirect3DPixelShader9**) ppShader.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPixelShaderConstantF(StartRegister, in pConstantData.GetPinnableReference(), Vector4fCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, Span<float> pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelShaderConstantF(StartRegister, ref pConstantData.GetPinnableReference(), Vector4fCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPixelShaderConstantI(StartRegister, in pConstantData.GetPinnableReference(), Vector4iCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, Span<int> pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelShaderConstantI(StartRegister, ref pConstantData.GetPinnableReference(), Vector4iCount);
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetPixelShaderConstantB(StartRegister, in pConstantData.GetPinnableReference(), BoolCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, Span<int> pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelShaderConstantB(StartRegister, ref pConstantData.GetPinnableReference(), BoolCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RectpatchInfo> pRectPatchInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawRectPatch(Handle, pNumSegs, in pRectPatchInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RectpatchInfo* pRectPatchInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawRectPatch(Handle, in pNumSegs.GetPinnableReference(), pRectPatchInfo);
    }

    /// <summary>To be documented.</summary>
    public static int DrawRectPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RectpatchInfo> pRectPatchInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawRectPatch(Handle, in pNumSegs.GetPinnableReference(), in pRectPatchInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawTriPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TripatchInfo> pTriPatchInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawTriPatch(Handle, pNumSegs, in pTriPatchInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawTriPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TripatchInfo* pTriPatchInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawTriPatch(Handle, in pNumSegs.GetPinnableReference(), pTriPatchInfo);
    }

    /// <summary>To be documented.</summary>
    public static int DrawTriPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TripatchInfo> pTriPatchInfo)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawTriPatch(Handle, in pNumSegs.GetPinnableReference(), in pTriPatchInfo.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateQuery<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Querytype Type, ref ComPtr<TI0> ppQuery) where TI0 : unmanaged, IComVtbl<IDirect3DQuery9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateQuery(Type, (IDirect3DQuery9**) ppQuery.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetConvolutionMonoKernel(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint width, uint height, float* rows, Span<float> columns)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetConvolutionMonoKernel(width, height, rows, ref columns.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetConvolutionMonoKernel(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint width, uint height, Span<float> rows, float* columns)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetConvolutionMonoKernel(width, height, ref rows.GetPinnableReference(), columns);
    }

    /// <summary>To be documented.</summary>
    public static int SetConvolutionMonoKernel(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint width, uint height, Span<float> rows, Span<float> columns)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetConvolutionMonoKernel(width, height, ref rows.GetPinnableReference(), ref columns.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1, TI2, TI3>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSrc, ComPtr<TI1> pDst, ComPtr<TI2> pSrcRectDescs, uint NumRects, ComPtr<TI3> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI2> where TI3 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI3>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects((IDirect3DSurface9*) pSrc.Handle, (IDirect3DSurface9*) pDst.Handle, (IDirect3DVertexBuffer9*) pSrcRectDescs.Handle, NumRects, (IDirect3DVertexBuffer9*) pDstRectDescs.Handle, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(pSrc, pDst, pSrcRectDescs, NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1, TI2>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSrc, ComPtr<TI1> pDst, ComPtr<TI2> pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects((IDirect3DSurface9*) pSrc.Handle, (IDirect3DSurface9*) pDst.Handle, (IDirect3DVertexBuffer9*) pSrcRectDescs.Handle, NumRects, ref pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(pSrc, pDst, ref pSrcRectDescs.GetPinnableReference(), NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1, TI2>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSrc, ComPtr<TI1> pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ComPtr<TI2> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects((IDirect3DSurface9*) pSrc.Handle, (IDirect3DSurface9*) pDst.Handle, ref pSrcRectDescs, NumRects, (IDirect3DVertexBuffer9*) pDstRectDescs.Handle, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, IDirect3DSurface9* pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(pSrc, pDst, ref pSrcRectDescs.GetPinnableReference(), NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSrc, ComPtr<TI1> pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects((IDirect3DSurface9*) pSrc.Handle, (IDirect3DSurface9*) pDst.Handle, ref pSrcRectDescs, NumRects, ref pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, Span<IDirect3DSurface9> pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(pSrc, ref pDst.GetPinnableReference(), pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1, TI2>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSrc, ref IDirect3DSurface9 pDst, ComPtr<TI1> pSrcRectDescs, uint NumRects, ComPtr<TI2> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects((IDirect3DSurface9*) pSrc.Handle, ref pDst, (IDirect3DVertexBuffer9*) pSrcRectDescs.Handle, NumRects, (IDirect3DVertexBuffer9*) pDstRectDescs.Handle, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, Span<IDirect3DSurface9> pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(pSrc, ref pDst.GetPinnableReference(), pSrcRectDescs, NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSrc, ref IDirect3DSurface9 pDst, ComPtr<TI1> pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects((IDirect3DSurface9*) pSrc.Handle, ref pDst, (IDirect3DVertexBuffer9*) pSrcRectDescs.Handle, NumRects, ref pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, Span<IDirect3DSurface9> pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(pSrc, ref pDst.GetPinnableReference(), ref pSrcRectDescs.GetPinnableReference(), NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ComPtr<TI1> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects((IDirect3DSurface9*) pSrc.Handle, ref pDst, ref pSrcRectDescs, NumRects, (IDirect3DVertexBuffer9*) pDstRectDescs.Handle, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSrc, Span<IDirect3DSurface9> pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(pSrc, ref pDst.GetPinnableReference(), ref pSrcRectDescs.GetPinnableReference(), NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ComPtr<TI0> pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects((IDirect3DSurface9*) pSrc.Handle, ref pDst, ref pSrcRectDescs, NumRects, ref pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), pDst, pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1, TI2>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ComPtr<TI0> pDst, ComPtr<TI1> pSrcRectDescs, uint NumRects, ComPtr<TI2> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects(ref pSrc, (IDirect3DSurface9*) pDst.Handle, (IDirect3DVertexBuffer9*) pSrcRectDescs.Handle, NumRects, (IDirect3DVertexBuffer9*) pDstRectDescs.Handle, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSrc, IDirect3DSurface9* pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), pDst, pSrcRectDescs, NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ComPtr<TI0> pDst, ComPtr<TI1> pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects(ref pSrc, (IDirect3DSurface9*) pDst.Handle, (IDirect3DVertexBuffer9*) pSrcRectDescs.Handle, NumRects, ref pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSrc, IDirect3DSurface9* pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), pDst, ref pSrcRectDescs.GetPinnableReference(), NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ComPtr<TI0> pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ComPtr<TI1> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects(ref pSrc, (IDirect3DSurface9*) pDst.Handle, ref pSrcRectDescs, NumRects, (IDirect3DVertexBuffer9*) pDstRectDescs.Handle, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSrc, IDirect3DSurface9* pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), pDst, ref pSrcRectDescs.GetPinnableReference(), NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ComPtr<TI0> pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects(ref pSrc, (IDirect3DSurface9*) pDst.Handle, ref pSrcRectDescs, NumRects, ref pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSrc, Span<IDirect3DSurface9> pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), ref pDst.GetPinnableReference(), pSrcRectDescs, NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0, TI1>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, ComPtr<TI0> pSrcRectDescs, uint NumRects, ComPtr<TI1> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects(ref pSrc, ref pDst, (IDirect3DVertexBuffer9*) pSrcRectDescs.Handle, NumRects, (IDirect3DVertexBuffer9*) pDstRectDescs.Handle, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSrc, Span<IDirect3DSurface9> pDst, IDirect3DVertexBuffer9* pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), ref pDst.GetPinnableReference(), pSrcRectDescs, NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, ComPtr<TI0> pSrcRectDescs, uint NumRects, ref IDirect3DVertexBuffer9 pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects(ref pSrc, ref pDst, (IDirect3DVertexBuffer9*) pSrcRectDescs.Handle, NumRects, ref pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSrc, Span<IDirect3DSurface9> pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9* pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), ref pDst.GetPinnableReference(), ref pSrcRectDescs.GetPinnableReference(), NumRects, pDstRectDescs, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref IDirect3DSurface9 pSrc, ref IDirect3DSurface9 pDst, ref IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, ComPtr<TI0> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset) where TI0 : unmanaged, IComVtbl<IDirect3DVertexBuffer9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeRects(ref pSrc, ref pDst, ref pSrcRectDescs, NumRects, (IDirect3DVertexBuffer9*) pDstRectDescs.Handle, Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeRects(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<IDirect3DSurface9> pSrc, Span<IDirect3DSurface9> pDst, Span<IDirect3DVertexBuffer9> pSrcRectDescs, uint NumRects, Span<IDirect3DVertexBuffer9> pDstRectDescs, Composerectsop Operation, int Xoffset, int Yoffset)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeRects(ref pSrc.GetPinnableReference(), ref pDst.GetPinnableReference(), ref pSrcRectDescs.GetPinnableReference(), NumRects, ref pDstRectDescs.GetPinnableReference(), Operation, Xoffset, Yoffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PresentEx(pSourceRect, pDestRect, hDestWindowOverride, in pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PresentEx(pSourceRect, in pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PresentEx(pSourceRect, in pDestRect.GetPinnableReference(), hDestWindowOverride, in pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PresentEx(in pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PresentEx(in pSourceRect.GetPinnableReference(), pDestRect, hDestWindowOverride, in pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PresentEx(in pSourceRect.GetPinnableReference(), in pDestRect.GetPinnableReference(), hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RGNData> pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PresentEx(in pSourceRect.GetPinnableReference(), in pDestRect.GetPinnableReference(), hDestWindowOverride, in pDirtyRegion.GetPinnableReference(), dwFlags);
    }

    /// <summary>To be documented.</summary>
    public static int GetGPUThreadPriority(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<int> pPriority)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGPUThreadPriority(ref pPriority.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CheckResourceResidency<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, ref ComPtr<TI0> pResourceArray, uint NumResources) where TI0 : unmanaged, IComVtbl<IDirect3DResource9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CheckResourceResidency((IDirect3DResource9**) pResourceArray.GetAddressOf(), NumResources);
    }

    /// <summary>To be documented.</summary>
    public static int GetMaximumFrameLatency(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<uint> pMaxLatency)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMaximumFrameLatency(ref pMaxLatency.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTargetEx<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref ComPtr<TI0> ppSurface, void** pSharedHandle, uint Usage) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRenderTargetEx(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, (IDirect3DSurface9**) ppSurface.GetAddressOf(), pSharedHandle, Usage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderTargetEx<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, ref ComPtr<TI0> ppSurface, ref void* pSharedHandle, uint Usage) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRenderTargetEx(Width, Height, Format, MultiSample, MultisampleQuality, Lockable, (IDirect3DSurface9**) ppSurface.GetAddressOf(), ref pSharedHandle, Usage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurfaceEx<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref ComPtr<TI0> ppSurface, void** pSharedHandle, uint Usage) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateOffscreenPlainSurfaceEx(Width, Height, Format, Pool, (IDirect3DSurface9**) ppSurface.GetAddressOf(), pSharedHandle, Usage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateOffscreenPlainSurfaceEx<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, ref ComPtr<TI0> ppSurface, ref void* pSharedHandle, uint Usage) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateOffscreenPlainSurfaceEx(Width, Height, Format, Pool, (IDirect3DSurface9**) ppSurface.GetAddressOf(), ref pSharedHandle, Usage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurfaceEx<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref ComPtr<TI0> ppSurface, void** pSharedHandle, uint Usage) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDepthStencilSurfaceEx(Width, Height, Format, MultiSample, MultisampleQuality, Discard, (IDirect3DSurface9**) ppSurface.GetAddressOf(), pSharedHandle, Usage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateDepthStencilSurfaceEx<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Discard, ref ComPtr<TI0> ppSurface, ref void* pSharedHandle, uint Usage) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateDepthStencilSurfaceEx(Width, Height, Format, MultiSample, MultisampleQuality, Discard, (IDirect3DSurface9**) ppSurface.GetAddressOf(), ref pSharedHandle, Usage);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, PresentParameters* pPresentationParameters, Span<Displaymodeex> pFullscreenDisplayMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ResetEx(pPresentationParameters, ref pFullscreenDisplayMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ResetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<PresentParameters> pPresentationParameters, Displaymodeex* pFullscreenDisplayMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ResetEx(ref pPresentationParameters.GetPinnableReference(), pFullscreenDisplayMode);
    }

    /// <summary>To be documented.</summary>
    public static int ResetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Span<PresentParameters> pPresentationParameters, Span<Displaymodeex> pFullscreenDisplayMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ResetEx(ref pPresentationParameters.GetPinnableReference(), ref pFullscreenDisplayMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Displaymodeex* pMode, Span<Displayrotation> pRotation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeEx(iSwapChain, pMode, ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayModeEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Span<Displaymodeex> pMode, Displayrotation* pRotation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeEx(iSwapChain, ref pMode.GetPinnableReference(), pRotation);
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayModeEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Span<Displaymodeex> pMode, Span<Displayrotation> pRotation)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayModeEx(iSwapChain, ref pMode.GetPinnableReference(), ref pRotation.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirect3DDevice9Ex> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
