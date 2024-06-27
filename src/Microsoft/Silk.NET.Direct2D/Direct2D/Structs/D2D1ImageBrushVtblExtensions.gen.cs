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

public unsafe static class D2D1ImageBrushVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageBrush> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageBrush> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageBrush> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageBrush> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1ImageBrush> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1ImageBrush> thisVtbl, ref ID2D1Factory* factory)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Factory** factoryPtr = &factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetOpacity(this ComPtr<ID2D1ImageBrush> thisVtbl, float opacity)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, float, void>)@this->LpVtbl[4])(@this, opacity);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTransform(this ComPtr<ID2D1ImageBrush> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[5])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void SetTransform(this ComPtr<ID2D1ImageBrush> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Matrix3X2<float> transform)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[5])(@this, transformPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static float GetOpacity(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, float>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTransform(this ComPtr<ID2D1ImageBrush> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[7])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void GetTransform(this ComPtr<ID2D1ImageBrush> thisVtbl, ref Silk.NET.Maths.Matrix3X2<float> transform)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[7])(@this, transformPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetImage(this ComPtr<ID2D1ImageBrush> thisVtbl, ID2D1Image* image)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Image*, void>)@this->LpVtbl[8])(@this, image);
    }

    /// <summary>To be documented.</summary>
    public static void SetImage(this ComPtr<ID2D1ImageBrush> thisVtbl, ref ID2D1Image image)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image* imagePtr = &image)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Image*, void>)@this->LpVtbl[8])(@this, imagePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetExtendModeX(this ComPtr<ID2D1ImageBrush> thisVtbl, ExtendMode extendModeX)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode, void>)@this->LpVtbl[9])(@this, extendModeX);
    }

    /// <summary>To be documented.</summary>
    public static void SetExtendModeY(this ComPtr<ID2D1ImageBrush> thisVtbl, ExtendMode extendModeY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode, void>)@this->LpVtbl[10])(@this, extendModeY);
    }

    /// <summary>To be documented.</summary>
    public static void SetInterpolationMode(this ComPtr<ID2D1ImageBrush> thisVtbl, InterpolationMode interpolationMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, InterpolationMode, void>)@this->LpVtbl[11])(@this, interpolationMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetSourceRectangle(this ComPtr<ID2D1ImageBrush> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[12])(@this, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static void SetSourceRectangle(this ComPtr<ID2D1ImageBrush> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[12])(@this, sourceRectanglePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetImage(this ComPtr<ID2D1ImageBrush> thisVtbl, ID2D1Image** image)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Image**, void>)@this->LpVtbl[13])(@this, image);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetImage(this ComPtr<ID2D1ImageBrush> thisVtbl, ref ID2D1Image* image)
    {
        var @this = thisVtbl.Handle;
        fixed (ID2D1Image** imagePtr = &image)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ID2D1Image**, void>)@this->LpVtbl[13])(@this, imagePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendModeX(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ExtendMode GetExtendModeY(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ExtendMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, ExtendMode>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static InterpolationMode GetInterpolationMode(this ComPtr<ID2D1ImageBrush> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        InterpolationMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, InterpolationMode>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetSourceRectangle(this ComPtr<ID2D1ImageBrush> thisVtbl, Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[17])(@this, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static void GetSourceRectangle(this ComPtr<ID2D1ImageBrush> thisVtbl, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1ImageBrush*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[17])(@this, sourceRectanglePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1ImageBrush> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageBrush> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1ImageBrush> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static void GetFactory<TI0>(this ComPtr<ID2D1ImageBrush> thisVtbl, ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void SetTransform(this ComPtr<ID2D1ImageBrush> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X2<float>> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetTransform(in transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetTransform(this ComPtr<ID2D1ImageBrush> thisVtbl, Span<Silk.NET.Maths.Matrix3X2<float>> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetTransform(ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetImage<TI0>(this ComPtr<ID2D1ImageBrush> thisVtbl, ComPtr<TI0> image) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->SetImage((ID2D1Image*) image.Handle);
    }

    /// <summary>To be documented.</summary>
    public static void SetImage(this ComPtr<ID2D1ImageBrush> thisVtbl, Span<ID2D1Image> image)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetImage(ref image.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetSourceRectangle(this ComPtr<ID2D1ImageBrush> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetSourceRectangle(in sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void GetImage<TI0>(this ComPtr<ID2D1ImageBrush> thisVtbl, ref ComPtr<TI0> image) where TI0 : unmanaged, IComVtbl<ID2D1Image>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        @this->GetImage((ID2D1Image**) image.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetSourceRectangle(this ComPtr<ID2D1ImageBrush> thisVtbl, Span<Silk.NET.Maths.Box2D<float>> sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetSourceRectangle(ref sourceRectangle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1ImageBrush> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
