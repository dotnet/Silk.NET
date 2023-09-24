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

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICPlanarBitmapFrameEncodeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WritePixels(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, uint lineCount, BitmapPlane* pPlanes, uint cPlanes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint, BitmapPlane*, uint, int>)@this->LpVtbl[3])(@this, lineCount, pPlanes, cPlanes);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int WritePixels(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, uint lineCount, ref BitmapPlane pPlanes, uint cPlanes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (BitmapPlane* pPlanesPtr = &pPlanes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, uint, BitmapPlane*, uint, int>)@this->LpVtbl[3])(@this, lineCount, pPlanesPtr, cPlanes);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, IWICBitmapSource** ppPlanes, uint cPlanes, Silk.NET.Maths.Rectangle<int>* prcSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[4])(@this, ppPlanes, cPlanes, prcSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, IWICBitmapSource** ppPlanes, uint cPlanes, ref Silk.NET.Maths.Rectangle<int> prcSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Rectangle<int>* prcSourcePtr = &prcSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[4])(@this, ppPlanes, cPlanes, prcSourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, ref IWICBitmapSource* ppPlanes, uint cPlanes, Silk.NET.Maths.Rectangle<int>* prcSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource** ppPlanesPtr = &ppPlanes)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[4])(@this, ppPlanesPtr, cPlanes, prcSource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, ref IWICBitmapSource* ppPlanes, uint cPlanes, ref Silk.NET.Maths.Rectangle<int> prcSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICBitmapSource** ppPlanesPtr = &ppPlanes)
        {
            fixed (Silk.NET.Maths.Rectangle<int>* prcSourcePtr = &prcSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPlanarBitmapFrameEncode*, IWICBitmapSource**, uint, Silk.NET.Maths.Rectangle<int>*, int>)@this->LpVtbl[4])(@this, ppPlanesPtr, cPlanes, prcSourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int WritePixels(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, uint lineCount, Span<BitmapPlane> pPlanes, uint cPlanes)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WritePixels(lineCount, ref pPlanes.GetPinnableReference(), cPlanes);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource<TI0>(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, ref ComPtr<TI0> ppPlanes, uint cPlanes, Silk.NET.Maths.Rectangle<int>* prcSource) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteSource((IWICBitmapSource**) ppPlanes.GetAddressOf(), cPlanes, prcSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, IWICBitmapSource** ppPlanes, uint cPlanes, Span<Silk.NET.Maths.Rectangle<int>> prcSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteSource(ppPlanes, cPlanes, ref prcSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int WriteSource<TI0>(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, ref ComPtr<TI0> ppPlanes, uint cPlanes, ref Silk.NET.Maths.Rectangle<int> prcSource) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->WriteSource((IWICBitmapSource**) ppPlanes.GetAddressOf(), cPlanes, ref prcSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int WriteSource(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl, ref IWICBitmapSource* ppPlanes, uint cPlanes, Span<Silk.NET.Maths.Rectangle<int>> prcSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->WriteSource(ref ppPlanes, cPlanes, ref prcSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICPlanarBitmapFrameEncode> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
