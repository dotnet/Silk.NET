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

namespace Silk.NET.DirectWrite;

public unsafe static class DWritePixelSnappingVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWritePixelSnapping> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWritePixelSnapping> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWritePixelSnapping> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWritePixelSnapping> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWritePixelSnapping> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWritePixelSnapping> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, int* isDisabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, ref int isDisabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isDisabledPtr = &isDisabled)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabledPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, ref T0 clientDrawingContext, int* isDisabled) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, isDisabled);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsPixelSnappingDisabled<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, ref T0 clientDrawingContext, ref int isDisabled) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            fixed (int* isDisabledPtr = &isDisabled)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContextPtr, isDisabledPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, ref Matrix transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, ref T0 clientDrawingContext, Matrix* transform) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContextPtr, transform);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentTransform<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, ref T0 clientDrawingContext, ref Matrix transform) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContextPtr, transformPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, float* pixelsPerDip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDip);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, ref float pixelsPerDip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pixelsPerDipPtr = &pixelsPerDip)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDipPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, ref T0 clientDrawingContext, float* pixelsPerDip) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContextPtr, pixelsPerDip);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelsPerDip<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, ref T0 clientDrawingContext, ref float pixelsPerDip) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            fixed (float* pixelsPerDipPtr = &pixelsPerDip)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContextPtr, pixelsPerDipPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWritePixelSnapping> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWritePixelSnapping> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWritePixelSnapping> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, Span<int> isDisabled)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsPixelSnappingDisabled(clientDrawingContext, ref isDisabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, Span<T0> clientDrawingContext, int* isDisabled) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsPixelSnappingDisabled(ref clientDrawingContext.GetPinnableReference(), isDisabled);
    }

    /// <summary>To be documented.</summary>
    public static int IsPixelSnappingDisabled<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, Span<T0> clientDrawingContext, Span<int> isDisabled) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsPixelSnappingDisabled(ref clientDrawingContext.GetPinnableReference(), ref isDisabled.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, Span<Matrix> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentTransform(clientDrawingContext, ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, Span<T0> clientDrawingContext, Matrix* transform) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentTransform(ref clientDrawingContext.GetPinnableReference(), transform);
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentTransform<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, Span<T0> clientDrawingContext, Span<Matrix> transform) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentTransform(ref clientDrawingContext.GetPinnableReference(), ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, Span<float> pixelsPerDip)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelsPerDip(clientDrawingContext, ref pixelsPerDip.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, Span<T0> clientDrawingContext, float* pixelsPerDip) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelsPerDip(ref clientDrawingContext.GetPinnableReference(), pixelsPerDip);
    }

    /// <summary>To be documented.</summary>
    public static int GetPixelsPerDip<T0>(this ComPtr<IDWritePixelSnapping> thisVtbl, Span<T0> clientDrawingContext, Span<float> pixelsPerDip) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPixelsPerDip(ref clientDrawingContext.GetPinnableReference(), ref pixelsPerDip.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWritePixelSnapping> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
