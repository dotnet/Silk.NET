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

public unsafe static class D2D1GdiMetafile1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1GdiMetafile1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1GdiMetafile1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Stream(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ID2D1GdiMetafileSink* sink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, ID2D1GdiMetafileSink*, int>)@this->LpVtbl[4])(@this, sink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Stream(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ref ID2D1GdiMetafileSink sink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID2D1GdiMetafileSink* sinkPtr = &sink)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, ID2D1GdiMetafileSink*, int>)@this->LpVtbl[4])(@this, sinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBounds(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, bounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBounds(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[5])(@this, boundsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDpi(this ComPtr<ID2D1GdiMetafile1> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, float*, float*, int>)@this->LpVtbl[6])(@this, dpiX, dpiY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDpi(this ComPtr<ID2D1GdiMetafile1> thisVtbl, float* dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* dpiYPtr = &dpiY)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, float*, float*, int>)@this->LpVtbl[6])(@this, dpiX, dpiYPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDpi(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ref float dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* dpiXPtr = &dpiX)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, float*, float*, int>)@this->LpVtbl[6])(@this, dpiXPtr, dpiY);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDpi(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ref float dpiX, ref float dpiY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* dpiXPtr = &dpiX)
        {
            fixed (float* dpiYPtr = &dpiY)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, float*, float*, int>)@this->LpVtbl[6])(@this, dpiXPtr, dpiYPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSourceBounds(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[7])(@this, bounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceBounds(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ref Silk.NET.Maths.Box2D<float> bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafile1*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[7])(@this, boundsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1GdiMetafile1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int Stream<TI0>(this ComPtr<ID2D1GdiMetafile1> thisVtbl, ComPtr<TI0> sink) where TI0 : unmanaged, IComVtbl<ID2D1GdiMetafileSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Stream((ID2D1GdiMetafileSink*) sink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Stream(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Span<ID2D1GdiMetafileSink> sink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Stream(ref sink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBounds(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBounds(ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDpi(this ComPtr<ID2D1GdiMetafile1> thisVtbl, float* dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDpi(dpiX, ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDpi(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Span<float> dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDpi(ref dpiX.GetPinnableReference(), dpiY);
    }

    /// <summary>To be documented.</summary>
    public static int GetDpi(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Span<float> dpiX, Span<float> dpiY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDpi(ref dpiX.GetPinnableReference(), ref dpiY.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSourceBounds(this ComPtr<ID2D1GdiMetafile1> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> bounds)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSourceBounds(ref bounds.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1GdiMetafile1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
