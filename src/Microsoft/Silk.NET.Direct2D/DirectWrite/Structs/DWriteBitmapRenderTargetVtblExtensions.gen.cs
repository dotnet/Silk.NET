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

public unsafe static class DWriteBitmapRenderTargetVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* blackBoxRectPtr = &blackBoxRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, ref IDWriteRenderingParams renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParamsPtr, textColor, blackBoxRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, ref IDWriteRenderingParams renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (Silk.NET.Maths.Box2D<int>* blackBoxRectPtr = &blackBoxRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParamsPtr, textColor, blackBoxRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, renderingParams, textColor, blackBoxRect);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (Silk.NET.Maths.Box2D<int>* blackBoxRectPtr = &blackBoxRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, renderingParams, textColor, blackBoxRectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, ref IDWriteRenderingParams renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, renderingParamsPtr, textColor, blackBoxRect);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, ref IDWriteRenderingParams renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
            {
                fixed (Silk.NET.Maths.Box2D<int>* blackBoxRectPtr = &blackBoxRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRunPtr, renderingParamsPtr, textColor, blackBoxRectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nint GetMemoryDC(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        nint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, nint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetPixelsPerDip(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelsPerDip(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float pixelsPerDip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, float, int>)@this->LpVtbl[6])(@this, pixelsPerDip);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix*, int>)@this->LpVtbl[7])(@this, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentTransform(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, ref Matrix transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix*, int>)@this->LpVtbl[7])(@this, transformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCurrentTransform(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix*, int>)@this->LpVtbl[8])(@this, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCurrentTransform(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix*, int>)@this->LpVtbl[8])(@this, transformPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<int>* size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[9])(@this, size);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, ref Silk.NET.Maths.Vector2D<int> size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Vector2D<int>* sizePtr = &size)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[9])(@this, sizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Resize(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, uint width, uint height)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, uint, uint, int>)@this->LpVtbl[10])(@this, width, height);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<TI0>(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, ComPtr<TI0> renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, glyphRun, (IDWriteRenderingParams*) renderingParams.Handle, textColor, blackBoxRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, Span<Silk.NET.Maths.Box2D<int>> blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, ref blackBoxRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<TI0>(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, ComPtr<TI0> renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, glyphRun, (IDWriteRenderingParams*) renderingParams.Handle, textColor, ref blackBoxRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, Span<IDWriteRenderingParams> renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, glyphRun, ref renderingParams.GetPinnableReference(), textColor, blackBoxRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, Span<IDWriteRenderingParams> renderingParams, uint textColor, Span<Silk.NET.Maths.Box2D<int>> blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, glyphRun, ref renderingParams.GetPinnableReference(), textColor, ref blackBoxRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), renderingParams, textColor, blackBoxRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun<TI0>(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, ComPtr<TI0> renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, in glyphRun, (IDWriteRenderingParams*) renderingParams.Handle, textColor, blackBoxRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, Span<Silk.NET.Maths.Box2D<int>> blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), renderingParams, textColor, ref blackBoxRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DrawGlyphRun<TI0>(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, ComPtr<TI0> renderingParams, uint textColor, ref Silk.NET.Maths.Box2D<int> blackBoxRect) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, in glyphRun, (IDWriteRenderingParams*) renderingParams.Handle, textColor, ref blackBoxRect);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, Span<IDWriteRenderingParams> renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), ref renderingParams.GetPinnableReference(), textColor, blackBoxRect);
    }

    /// <summary>To be documented.</summary>
    public static int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, Span<IDWriteRenderingParams> renderingParams, uint textColor, Span<Silk.NET.Maths.Box2D<int>> blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DrawGlyphRun(baselineOriginX, baselineOriginY, measuringMode, in glyphRun.GetPinnableReference(), ref renderingParams.GetPinnableReference(), textColor, ref blackBoxRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCurrentTransform(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, Span<Matrix> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCurrentTransform(ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int SetCurrentTransform(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetCurrentTransform(in transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSize(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, Span<Silk.NET.Maths.Vector2D<int>> size)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSize(ref size.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
