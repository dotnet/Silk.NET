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

public unsafe static class D2D1BitmapVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1Bitmap> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1Bitmap> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1Bitmap> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1Bitmap> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<float> GetSize(this ComPtr<ID2D1Bitmap> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<float> ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<float>>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<uint> GetPixelSize(this ComPtr<ID2D1Bitmap> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<uint> ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static PixelFormat GetPixelFormat(this ComPtr<ID2D1Bitmap> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        PixelFormat ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, PixelFormat>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1Bitmap> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, float*, float*, void>)@this->LpVtbl[7])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1Bitmap> thisVtbl, float* dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiYPtr = &dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, float*, float*, void>)@this->LpVtbl[7])(@this, dpiX, dpiYPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1Bitmap> thisVtbl, ref float dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, float*, float*, void>)@this->LpVtbl[7])(@this, dpiXPtr, dpiY);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetDpi(this ComPtr<ID2D1Bitmap> thisVtbl, ref float dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, float*, float*, void>)@this->LpVtbl[7])(@this, dpiXPtr, dpiYPtr);
            }
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1Bitmap* bitmap, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPoint, bitmap, srcRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1Bitmap* bitmap, ref Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPoint, bitmap, srcRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ref ID2D1Bitmap bitmap, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPoint, bitmapPtr, srcRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ref ID2D1Bitmap bitmap, ref Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPoint, bitmapPtr, srcRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ID2D1Bitmap* bitmap, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPointPtr, bitmap, srcRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ID2D1Bitmap* bitmap, ref Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPointPtr, bitmap, srcRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ref ID2D1Bitmap bitmap, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPointPtr, bitmapPtr, srcRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ref ID2D1Bitmap bitmap, ref Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPointPtr, bitmapPtr, srcRectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1RenderTarget* renderTarget, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPoint, renderTarget, srcRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1RenderTarget* renderTarget, ref Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPoint, renderTarget, srcRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ref ID2D1RenderTarget renderTarget, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPoint, renderTargetPtr, srcRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ref ID2D1RenderTarget renderTarget, ref Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPoint, renderTargetPtr, srcRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ID2D1RenderTarget* renderTarget, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPointPtr, renderTarget, srcRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ID2D1RenderTarget* renderTarget, ref Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPointPtr, renderTarget, srcRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ref ID2D1RenderTarget renderTarget, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPointPtr, renderTargetPtr, srcRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ref ID2D1RenderTarget renderTarget, ref Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
            {
                fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPointPtr, renderTargetPtr, srcRectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromMemory(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Box2D<uint>* dstRect, void* srcData, uint pitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, void*, uint, int>)@this->LpVtbl[10])(@this, dstRect, srcData, pitch);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromMemory<T0>(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Box2D<uint>* dstRect, ref T0 srcData, uint pitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* srcDataPtr = &srcData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, void*, uint, int>)@this->LpVtbl[10])(@this, dstRect, srcDataPtr, pitch);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromMemory(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Box2D<uint> dstRect, void* srcData, uint pitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* dstRectPtr = &dstRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, void*, uint, int>)@this->LpVtbl[10])(@this, dstRectPtr, srcData, pitch);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromMemory<T0>(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Box2D<uint> dstRect, ref T0 srcData, uint pitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* dstRectPtr = &dstRect)
        {
            fixed (void* srcDataPtr = &srcData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, void*, uint, int>)@this->LpVtbl[10])(@this, dstRectPtr, srcDataPtr, pitch);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1Bitmap> thisVtbl, float* dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(dpiX, ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1Bitmap> thisVtbl, Span<float> dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(ref dpiX.GetPinnableReference(), dpiY);
    }

    /// <summary>To be documented.</summary>
    public static void GetDpi(this ComPtr<ID2D1Bitmap> thisVtbl, Span<float> dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(ref dpiX.GetPinnableReference(), ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ComPtr<TI0> bitmap, Silk.NET.Maths.Box2D<uint>* srcRect) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromBitmap(destPoint, (ID2D1Bitmap*) bitmap.Handle, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1Bitmap* bitmap, Span<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(destPoint, bitmap, ref srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ComPtr<TI0> bitmap, ref Silk.NET.Maths.Box2D<uint> srcRect) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromBitmap(destPoint, (ID2D1Bitmap*) bitmap.Handle, ref srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, Span<ID2D1Bitmap> bitmap, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(destPoint, ref bitmap.GetPinnableReference(), srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, Span<ID2D1Bitmap> bitmap, Span<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(destPoint, ref bitmap.GetPinnableReference(), ref srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Silk.NET.Maths.Vector2D<uint>> destPoint, ID2D1Bitmap* bitmap, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(ref destPoint.GetPinnableReference(), bitmap, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ComPtr<TI0> bitmap, Silk.NET.Maths.Box2D<uint>* srcRect) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromBitmap(ref destPoint, (ID2D1Bitmap*) bitmap.Handle, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Silk.NET.Maths.Vector2D<uint>> destPoint, ID2D1Bitmap* bitmap, Span<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(ref destPoint.GetPinnableReference(), bitmap, ref srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromBitmap<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ComPtr<TI0> bitmap, ref Silk.NET.Maths.Box2D<uint> srcRect) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromBitmap(ref destPoint, (ID2D1Bitmap*) bitmap.Handle, ref srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Silk.NET.Maths.Vector2D<uint>> destPoint, Span<ID2D1Bitmap> bitmap, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(ref destPoint.GetPinnableReference(), ref bitmap.GetPinnableReference(), srcRect);
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromBitmap(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Silk.NET.Maths.Vector2D<uint>> destPoint, Span<ID2D1Bitmap> bitmap, Span<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(ref destPoint.GetPinnableReference(), ref bitmap.GetPinnableReference(), ref srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ComPtr<TI0> renderTarget, Silk.NET.Maths.Box2D<uint>* srcRect) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromRenderTarget(destPoint, (ID2D1RenderTarget*) renderTarget.Handle, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1RenderTarget* renderTarget, Span<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(destPoint, renderTarget, ref srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, ComPtr<TI0> renderTarget, ref Silk.NET.Maths.Box2D<uint> srcRect) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromRenderTarget(destPoint, (ID2D1RenderTarget*) renderTarget.Handle, ref srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, Span<ID2D1RenderTarget> renderTarget, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(destPoint, ref renderTarget.GetPinnableReference(), srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Vector2D<uint>* destPoint, Span<ID2D1RenderTarget> renderTarget, Span<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(destPoint, ref renderTarget.GetPinnableReference(), ref srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Silk.NET.Maths.Vector2D<uint>> destPoint, ID2D1RenderTarget* renderTarget, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(ref destPoint.GetPinnableReference(), renderTarget, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ComPtr<TI0> renderTarget, Silk.NET.Maths.Box2D<uint>* srcRect) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromRenderTarget(ref destPoint, (ID2D1RenderTarget*) renderTarget.Handle, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Silk.NET.Maths.Vector2D<uint>> destPoint, ID2D1RenderTarget* renderTarget, Span<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(ref destPoint.GetPinnableReference(), renderTarget, ref srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromRenderTarget<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl, ref Silk.NET.Maths.Vector2D<uint> destPoint, ComPtr<TI0> renderTarget, ref Silk.NET.Maths.Box2D<uint> srcRect) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromRenderTarget(ref destPoint, (ID2D1RenderTarget*) renderTarget.Handle, ref srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Silk.NET.Maths.Vector2D<uint>> destPoint, Span<ID2D1RenderTarget> renderTarget, Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(ref destPoint.GetPinnableReference(), ref renderTarget.GetPinnableReference(), srcRect);
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Silk.NET.Maths.Vector2D<uint>> destPoint, Span<ID2D1RenderTarget> renderTarget, Span<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(ref destPoint.GetPinnableReference(), ref renderTarget.GetPinnableReference(), ref srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromMemory<T0>(this ComPtr<ID2D1Bitmap> thisVtbl, Silk.NET.Maths.Box2D<uint>* dstRect, Span<T0> srcData, uint pitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromMemory(dstRect, ref srcData.GetPinnableReference(), pitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromMemory(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Silk.NET.Maths.Box2D<uint>> dstRect, void* srcData, uint pitch)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromMemory(ref dstRect.GetPinnableReference(), srcData, pitch);
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromMemory<T0>(this ComPtr<ID2D1Bitmap> thisVtbl, Span<Silk.NET.Maths.Box2D<uint>> dstRect, Span<T0> srcData, uint pitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromMemory(ref dstRect.GetPinnableReference(), ref srcData.GetPinnableReference(), pitch);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1Bitmap> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
