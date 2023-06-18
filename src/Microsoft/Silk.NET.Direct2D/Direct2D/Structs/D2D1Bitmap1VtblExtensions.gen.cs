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

namespace Silk.NET.Direct2D;

public unsafe static class D2D1Bitmap1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Bitmap1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Bitmap1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1Bitmap1> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<float> GetSize(this ComPtr<ID2D1Bitmap1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<float>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)@this->LpVtbl[4])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<uint> GetPixelSize(this ComPtr<ID2D1Bitmap1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<uint> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<uint>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, Silk.NET.Maths.Vector2D<uint>*>)@this->LpVtbl[5])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static PixelFormat GetPixelFormat(this ComPtr<ID2D1Bitmap1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        PixelFormat silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        PixelFormat* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, PixelFormat*, PixelFormat*>)@this->LpVtbl[6])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1Bitmap1> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, float*, float*, void>)@this->LpVtbl[7])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPoint, bitmap, srcRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1RenderTarget* renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPoint, renderTarget, srcRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromMemory(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* dstRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Box2D<uint>*, void*, uint, int>)@this->LpVtbl[10])(@this, dstRect, srcData, pitch);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetColorContext(this ComPtr<ID2D1Bitmap1> thisVtbl, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1ColorContext**, void>)@this->LpVtbl[11])(@this, colorContext);
    }

    /// <summary>To be documented.</summary>
    public static BitmapOptions GetOptions(this ComPtr<ID2D1Bitmap1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        BitmapOptions ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, BitmapOptions>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSurface(this ComPtr<ID2D1Bitmap1> thisVtbl, Silk.NET.DXGI.IDXGISurface** dxgiSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[13])(@this, dxgiSurface);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Map(this ComPtr<ID2D1Bitmap1> thisVtbl, MapOptions options, MappedRect* mappedRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, MapOptions, MappedRect*, int>)@this->LpVtbl[14])(@this, options, mappedRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Unmap(this ComPtr<ID2D1Bitmap1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, int>)@this->LpVtbl[15])(@this);
        return ret;
    }

}
