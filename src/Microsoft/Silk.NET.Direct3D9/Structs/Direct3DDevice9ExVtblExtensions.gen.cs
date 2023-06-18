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
    public static unsafe int GetDeviceCaps(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Caps9* pCaps)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Caps9*, int>)@this->LpVtbl[7])(@this, pCaps);
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
    public static unsafe int GetCreationParameters(this ComPtr<IDirect3DDevice9Ex> thisVtbl, DeviceCreationParameters* pParameters)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, DeviceCreationParameters*, int>)@this->LpVtbl[9])(@this, pParameters);
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
    public static unsafe int GetSwapChain(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, IDirect3DSwapChain9** pSwapChain)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSwapChain9**, int>)@this->LpVtbl[14])(@this, iSwapChain, pSwapChain);
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
    public static unsafe int Present(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, int>)@this->LpVtbl[17])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
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
    public static unsafe int GetRasterStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, RasterStatus* pRasterStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, RasterStatus*, int>)@this->LpVtbl[19])(@this, iSwapChain, pRasterStatus);
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
    public static unsafe void GetGammaRamp(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint iSwapChain, Gammaramp* pRamp)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Gammaramp*, void>)@this->LpVtbl[22])(@this, iSwapChain, pRamp);
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
    public static unsafe int CreateVolumeTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, uint Depth, uint Levels, uint Usage, Format Format, Pool Pool, IDirect3DVolumeTexture9** ppVolumeTexture, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, uint, uint, Format, Pool, IDirect3DVolumeTexture9**, void**, int>)@this->LpVtbl[24])(@this, Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
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
    public static unsafe int CreateVertexBuffer(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Length, uint Usage, uint FVF, Pool Pool, IDirect3DVertexBuffer9** ppVertexBuffer, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, uint, Pool, IDirect3DVertexBuffer9**, void**, int>)@this->LpVtbl[26])(@this, Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
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
    public static unsafe int CreateRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, MultisampleType MultiSample, uint MultisampleQuality, Silk.NET.Core.Bool32 Lockable, IDirect3DSurface9** ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, MultisampleType, uint, Silk.NET.Core.Bool32, IDirect3DSurface9**, void**, int>)@this->LpVtbl[28])(@this, Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
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
    public static unsafe int UpdateSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestinationSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<int>* pDestPoint)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[30])(@this, pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
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
    public static unsafe int GetRenderTargetData(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pRenderTarget, IDirect3DSurface9* pDestSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, IDirect3DSurface9*, int>)@this->LpVtbl[32])(@this, pRenderTarget, pDestSurface);
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
    public static unsafe int StretchRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9* pSourceSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, IDirect3DSurface9* pDestSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, Texturefiltertype Filter)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, IDirect3DSurface9*, Silk.NET.Maths.Box2D<int>*, Texturefiltertype, int>)@this->LpVtbl[34])(@this, pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
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
    public static unsafe int CreateOffscreenPlainSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, void** pSharedHandle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, int>)@this->LpVtbl[36])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle);
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
    public static unsafe int GetRenderTarget(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint RenderTargetIndex, IDirect3DSurface9** ppRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DSurface9**, int>)@this->LpVtbl[38])(@this, RenderTargetIndex, ppRenderTarget);
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
    public static unsafe int GetDepthStencilSurface(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DSurface9** ppZStencilSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DSurface9**, int>)@this->LpVtbl[40])(@this, ppZStencilSurface);
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
    public static unsafe int SetTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype State, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* pMatrix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[44])(@this, State, pMatrix);
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
    public static unsafe int MultiplyTransform(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Transformstatetype arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* arg1)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Transformstatetype, System.Numerics.Matrix4x4*, int>)@this->LpVtbl[46])(@this, arg0, arg1);
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
    public static unsafe int GetViewport(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Viewport9* pViewport)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Viewport9*, int>)@this->LpVtbl[48])(@this, pViewport);
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
    public static unsafe int GetMaterial(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Material9* pMaterial)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Material9*, int>)@this->LpVtbl[50])(@this, pMaterial);
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
    public static unsafe int GetLight(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, Light9* arg1)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Light9*, int>)@this->LpVtbl[52])(@this, Index, arg1);
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
    public static unsafe int SetClipPlane(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pPlane)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, int>)@this->LpVtbl[55])(@this, Index, pPlane);
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
    public static unsafe int CreateStateBlock(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Stateblocktype Type, IDirect3DStateBlock9** ppSB)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Stateblocktype, IDirect3DStateBlock9**, int>)@this->LpVtbl[59])(@this, Type, ppSB);
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
    public static unsafe int SetClipStatus(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Clipstatus9* pClipStatus)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Clipstatus9*, int>)@this->LpVtbl[62])(@this, pClipStatus);
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
    public static unsafe int GetTexture(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, IDirect3DBaseTexture9** ppTexture)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DBaseTexture9**, int>)@this->LpVtbl[64])(@this, Stage, ppTexture);
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
    public static unsafe int GetTextureStageState(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Stage, Texturestagestatetype Type, uint* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Texturestagestatetype, uint*, int>)@this->LpVtbl[66])(@this, Stage, Type, pValue);
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
    public static unsafe int SetPaletteEntries(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint PaletteNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector4D<byte>* pEntries)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, Silk.NET.Maths.Vector4D<byte>*, int>)@this->LpVtbl[71])(@this, PaletteNumber, pEntries);
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
    public static unsafe int SetScissorRect(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[75])(@this, pRect);
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
    public static unsafe int DrawIndexedPrimitiveUP(this ComPtr<IDirect3DDevice9Ex> thisVtbl, Primitivetype PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pIndexData, Format IndexDataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Primitivetype, uint, uint, uint, void*, Format, void*, uint, int>)@this->LpVtbl[84])(@this, PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
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
    public static unsafe int CreateVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Vertexelement9* pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Vertexelement9*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[86])(@this, pVertexElements, ppDecl);
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
    public static unsafe int GetVertexDeclaration(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DVertexDeclaration9** ppDecl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexDeclaration9**, int>)@this->LpVtbl[88])(@this, ppDecl);
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
    public static unsafe int CreateVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, IDirect3DVertexShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DVertexShader9**, int>)@this->LpVtbl[91])(@this, pFunction, ppShader);
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
    public static unsafe int GetVertexShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DVertexShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DVertexShader9**, int>)@this->LpVtbl[93])(@this, ppShader);
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
    public static unsafe int GetVertexShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, float* pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[95])(@this, StartRegister, pConstantData, Vector4fCount);
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
    public static unsafe int GetVertexShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, int* pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[97])(@this, StartRegister, pConstantData, Vector4iCount);
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
    public static unsafe int GetVertexShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, int* pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[99])(@this, StartRegister, pConstantData, BoolCount);
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
    public static unsafe int GetStreamSource(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, uint* pStride)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)@this->LpVtbl[101])(@this, StreamNumber, ppStreamData, pOffsetInBytes, pStride);
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
    public static unsafe int SetIndices(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DIndexBuffer9* pIndexData)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DIndexBuffer9*, int>)@this->LpVtbl[104])(@this, pIndexData);
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
    public static unsafe int CreatePixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pFunction, IDirect3DPixelShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint*, IDirect3DPixelShader9**, int>)@this->LpVtbl[106])(@this, pFunction, ppShader);
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
    public static unsafe int GetPixelShader(this ComPtr<IDirect3DDevice9Ex> thisVtbl, IDirect3DPixelShader9** ppShader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, IDirect3DPixelShader9**, int>)@this->LpVtbl[108])(@this, ppShader);
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
    public static unsafe int GetPixelShaderConstantF(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, float* pConstantData, uint Vector4fCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, uint, int>)@this->LpVtbl[110])(@this, StartRegister, pConstantData, Vector4fCount);
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
    public static unsafe int GetPixelShaderConstantI(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, int* pConstantData, uint Vector4iCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[112])(@this, StartRegister, pConstantData, Vector4iCount);
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
    public static unsafe int GetPixelShaderConstantB(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint StartRegister, int* pConstantData, uint BoolCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, int*, uint, int>)@this->LpVtbl[114])(@this, StartRegister, pConstantData, BoolCount);
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
    public static unsafe int DrawTriPatch(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pNumSegs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TripatchInfo* pTriPatchInfo)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, float*, TripatchInfo*, int>)@this->LpVtbl[116])(@this, Handle, pNumSegs, pTriPatchInfo);
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
    public static unsafe int SetConvolutionMonoKernel(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint width, uint height, float* rows, float* columns)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, float*, float*, int>)@this->LpVtbl[119])(@this, width, height, rows, columns);
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
    public static unsafe int PresentEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pSourceRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDestRect, nint hDestWindowOverride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RGNData* pDirtyRegion, uint dwFlags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, nint, RGNData*, uint, int>)@this->LpVtbl[121])(@this, pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
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
    public static unsafe int CreateOffscreenPlainSurfaceEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, uint Width, uint Height, Format Format, Pool Pool, IDirect3DSurface9** ppSurface, void** pSharedHandle, uint Usage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, uint, uint, Format, Pool, IDirect3DSurface9**, void**, uint, int>)@this->LpVtbl[130])(@this, Width, Height, Format, Pool, ppSurface, pSharedHandle, Usage);
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
    public static unsafe int ResetEx(this ComPtr<IDirect3DDevice9Ex> thisVtbl, PresentParameters* pPresentationParameters, Displaymodeex* pFullscreenDisplayMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Ex*, PresentParameters*, Displaymodeex*, int>)@this->LpVtbl[132])(@this, pPresentationParameters, pFullscreenDisplayMode);
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

}
