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
    public static unsafe int SetCurrentTransform(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, Matrix*, int>)@this->LpVtbl[8])(@this, transform);
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
    public static int Resize(this ComPtr<IDWriteBitmapRenderTarget> thisVtbl, uint width, uint height)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget*, uint, uint, int>)@this->LpVtbl[10])(@this, width, height);
        return ret;
    }

}
