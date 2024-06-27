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

public unsafe static class D2D1BitmapBrush1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1BitmapBrush1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1BitmapBrush1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1BitmapBrush1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1BitmapBrush1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetOpacity(this ComPtr<ID2D1BitmapBrush1> thisVtbl, float opacity)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, float, void>)@this->LpVtbl[4])(@this, opacity);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTransform(this ComPtr<ID2D1BitmapBrush1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[5])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void SetTransform(this ComPtr<ID2D1BitmapBrush1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[5])(@this, transformPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static float GetOpacity(this ComPtr<ID2D1BitmapBrush1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, float>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTransform(this ComPtr<ID2D1BitmapBrush1> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[7])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void GetTransform(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ref Silk.NET.Maths.Matrix3X2<float> transform)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[7])(@this, transformPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetExtendModeX(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ExtendMode extendModeX)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, ExtendMode, void>)@this->LpVtbl[8])(@this, extendModeX);
    }

    /// <summary>To be documented.</summary>
    public static void SetExtendModeY(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ExtendMode extendModeY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, ExtendMode, void>)@this->LpVtbl[9])(@this, extendModeY);
    }

    /// <summary>To be documented.</summary>
    public static void SetInterpolationMode(this ComPtr<ID2D1BitmapBrush1> thisVtbl, BitmapInterpolationMode interpolationMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, BitmapInterpolationMode, void>)@this->LpVtbl[10])(@this, interpolationMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetBitmap(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, ID2D1Bitmap*, void>)@this->LpVtbl[11])(@this, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static void SetBitmap(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ref ID2D1Bitmap bitmap)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, ID2D1Bitmap*, void>)@this->LpVtbl[11])(@this, bitmapPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendModeX(this ComPtr<ID2D1BitmapBrush1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, ExtendMode>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendModeY(this ComPtr<ID2D1BitmapBrush1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, ExtendMode>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static BitmapInterpolationMode GetInterpolationMode(this ComPtr<ID2D1BitmapBrush1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        BitmapInterpolationMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, BitmapInterpolationMode>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetBitmap(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, ID2D1Bitmap**, void>)@this->LpVtbl[15])(@this, bitmap);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetBitmap(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ref ID2D1Bitmap* bitmap)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, ID2D1Bitmap**, void>)@this->LpVtbl[15])(@this, bitmapPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetInterpolationMode1(this ComPtr<ID2D1BitmapBrush1> thisVtbl, InterpolationMode interpolationMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, InterpolationMode, void>)@this->LpVtbl[16])(@this, interpolationMode);
    }

    /// <summary>To be documented.</summary>
    public static InterpolationMode GetInterpolationMode1(this ComPtr<ID2D1BitmapBrush1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        InterpolationMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapBrush1*, InterpolationMode>)@this->LpVtbl[17])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1BitmapBrush1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1BitmapBrush1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1BitmapBrush1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void SetTransform(this ComPtr<ID2D1BitmapBrush1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetTransform(in transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetTransform(this ComPtr<ID2D1BitmapBrush1> thisVtbl, Span<Silk.NET.Maths.Matrix3X2<float>> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTransform(ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetBitmap<TI0>(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetBitmap((ID2D1Bitmap*) bitmap.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void SetBitmap(this ComPtr<ID2D1BitmapBrush1> thisVtbl, Span<ID2D1Bitmap> bitmap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetBitmap(ref bitmap.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetBitmap<TI0>(this ComPtr<ID2D1BitmapBrush1> thisVtbl, ref ComPtr<TI0> bitmap) where TI0 : unmanaged, IComVtbl<ID2D1Bitmap>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetBitmap((ID2D1Bitmap**) bitmap.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1BitmapBrush1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
