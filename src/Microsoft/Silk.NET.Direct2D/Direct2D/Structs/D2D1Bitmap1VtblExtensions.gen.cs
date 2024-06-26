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
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static unsafe void GetFactory(this ComPtr<ID2D1Bitmap1> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
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
    public static unsafe void GetDpi(this ComPtr<ID2D1Bitmap1> thisVtbl, float* dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiYPtr = &dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, float*, float*, void>)@this->LpVtbl[7])(@this, dpiX, dpiYPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1Bitmap1> thisVtbl, ref float dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, float*, float*, void>)@this->LpVtbl[7])(@this, dpiXPtr, dpiY);
        }
    }

    /// <summary>To be documented.</summary>
    public static void GetDpi(this ComPtr<ID2D1Bitmap1> thisVtbl, ref float dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        fixed (float* dpiXPtr = &dpiX)
        {
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, float*, float*, void>)@this->LpVtbl[7])(@this, dpiXPtr, dpiYPtr);
            }
        }
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
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPoint, bitmap, srcRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPoint, bitmapPtr, srcRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPoint, bitmapPtr, srcRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPointPtr, bitmap, srcRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPointPtr, bitmap, srcRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPointPtr, bitmapPtr, srcRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ref ID2D1Bitmap bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPointPtr, bitmapPtr, srcRectPtr);
                }
            }
        }
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
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1RenderTarget* renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPoint, renderTarget, srcRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ref ID2D1RenderTarget renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPoint, renderTargetPtr, srcRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ref ID2D1RenderTarget renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPoint, renderTargetPtr, srcRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ID2D1RenderTarget* renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPointPtr, renderTarget, srcRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ID2D1RenderTarget* renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPointPtr, renderTarget, srcRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ref ID2D1RenderTarget renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPointPtr, renderTargetPtr, srcRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ref ID2D1RenderTarget renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<uint>* destPointPtr = &destPoint)
        {
            fixed (ID2D1RenderTarget* renderTargetPtr = &renderTarget)
            {
                fixed (Silk.NET.Maths.Box2D<uint>* srcRectPtr = &srcRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPointPtr, renderTargetPtr, srcRectPtr);
                }
            }
        }
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
    public static unsafe int CopyFromMemory<T0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* dstRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 srcData, uint pitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* srcDataPtr = &srcData)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Box2D<uint>*, void*, uint, int>)@this->LpVtbl[10])(@this, dstRect, srcDataPtr, pitch);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromMemory(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> dstRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* dstRectPtr = &dstRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Box2D<uint>*, void*, uint, int>)@this->LpVtbl[10])(@this, dstRectPtr, srcData, pitch);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromMemory<T0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> dstRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 srcData, uint pitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* dstRectPtr = &dstRect)
        {
            fixed (void* srcDataPtr = &srcData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Box2D<uint>*, void*, uint, int>)@this->LpVtbl[10])(@this, dstRectPtr, srcDataPtr, pitch);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetColorContext(this ComPtr<ID2D1Bitmap1> thisVtbl, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1ColorContext**, void>)@this->LpVtbl[11])(@this, colorContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetColorContext(this ComPtr<ID2D1Bitmap1> thisVtbl, ref ID2D1ColorContext* colorContext)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1ColorContext**, void>)@this->LpVtbl[11])(@this, colorContextPtr);
        }
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
    public static unsafe int GetSurface(this ComPtr<ID2D1Bitmap1> thisVtbl, ref Silk.NET.DXGI.IDXGISurface* dxgiSurface)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.IDXGISurface** dxgiSurfacePtr = &dxgiSurface)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[13])(@this, dxgiSurfacePtr);
        }
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
    public static int Map(this ComPtr<ID2D1Bitmap1> thisVtbl, MapOptions options, ref MappedRect mappedRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MappedRect* mappedRectPtr = &mappedRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, MapOptions, MappedRect*, int>)@this->LpVtbl[14])(@this, options, mappedRectPtr);
        }
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

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1Bitmap1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1Bitmap1> thisVtbl, float* dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(dpiX, ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1Bitmap1> thisVtbl, Span<float> dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(ref dpiX.GetPinnableReference(), dpiY);
    }

    /// <summary>To be documented.</summary>
    public static void GetDpi(this ComPtr<ID2D1Bitmap1> thisVtbl, Span<float> dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetDpi(ref dpiX.GetPinnableReference(), ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromBitmap(destPoint, (ID2D1Bitmap*) bitmap.Handle, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(destPoint, bitmap, in srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromBitmap(destPoint, (ID2D1Bitmap*) bitmap.Handle, in srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(destPoint, ref bitmap.GetPinnableReference(), srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(destPoint, ref bitmap.GetPinnableReference(), in srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> destPoint, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(in destPoint.GetPinnableReference(), bitmap, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromBitmap(in destPoint, (ID2D1Bitmap*) bitmap.Handle, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> destPoint, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(in destPoint.GetPinnableReference(), bitmap, in srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromBitmap<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ComPtr<TI0> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromBitmap(in destPoint, (ID2D1Bitmap*) bitmap.Handle, in srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> destPoint, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(in destPoint.GetPinnableReference(), ref bitmap.GetPinnableReference(), srcRect);
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromBitmap(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> destPoint, Span<ID2D1Bitmap> bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromBitmap(in destPoint.GetPinnableReference(), ref bitmap.GetPinnableReference(), in srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ComPtr<TI0> renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromRenderTarget(destPoint, (ID2D1RenderTarget*) renderTarget.Handle, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1RenderTarget* renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(destPoint, renderTarget, in srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ComPtr<TI0> renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromRenderTarget(destPoint, (ID2D1RenderTarget*) renderTarget.Handle, in srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, Span<ID2D1RenderTarget> renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(destPoint, ref renderTarget.GetPinnableReference(), srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, Span<ID2D1RenderTarget> renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(destPoint, ref renderTarget.GetPinnableReference(), in srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> destPoint, ID2D1RenderTarget* renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(in destPoint.GetPinnableReference(), renderTarget, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ComPtr<TI0> renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromRenderTarget(in destPoint, (ID2D1RenderTarget*) renderTarget.Handle, srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> destPoint, ID2D1RenderTarget* renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(in destPoint.GetPinnableReference(), renderTarget, in srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromRenderTarget<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Vector2D<uint> destPoint, ComPtr<TI0> renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<uint> srcRect) where TI0 : unmanaged, IComVtbl<ID2D1RenderTarget>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CopyFromRenderTarget(in destPoint, (ID2D1RenderTarget*) renderTarget.Handle, in srcRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> destPoint, Span<ID2D1RenderTarget> renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(in destPoint.GetPinnableReference(), ref renderTarget.GetPinnableReference(), srcRect);
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromRenderTarget(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Vector2D<uint>> destPoint, Span<ID2D1RenderTarget> renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> srcRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromRenderTarget(in destPoint.GetPinnableReference(), ref renderTarget.GetPinnableReference(), in srcRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromMemory<T0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* dstRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> srcData, uint pitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromMemory(dstRect, in srcData.GetPinnableReference(), pitch);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CopyFromMemory(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> dstRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromMemory(in dstRect.GetPinnableReference(), srcData, pitch);
    }

    /// <summary>To be documented.</summary>
    public static int CopyFromMemory<T0>(this ComPtr<ID2D1Bitmap1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<uint>> dstRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> srcData, uint pitch) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CopyFromMemory(in dstRect.GetPinnableReference(), in srcData.GetPinnableReference(), pitch);
    }

    /// <summary>To be documented.</summary>
    public static void GetColorContext<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl, ref ComPtr<TI0> colorContext) where TI0 : unmanaged, IComVtbl<ID2D1ColorContext>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetColorContext((ID2D1ColorContext**) colorContext.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int Map(this ComPtr<ID2D1Bitmap1> thisVtbl, MapOptions options, Span<MappedRect> mappedRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Map(options, ref mappedRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1Bitmap1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
