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

public unsafe static class DWriteBitmapRenderTarget1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, IDWriteRenderingParams* renderingParams, uint textColor, Silk.NET.Maths.Box2D<int>* blackBoxRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, float, float, MeasuringMode, GlyphRun*, IDWriteRenderingParams*, uint, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[3])(@this, baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static nint GetMemoryDC(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        nint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, nint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetPixelsPerDip(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, float>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPixelsPerDip(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl, float pixelsPerDip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, float, int>)@this->LpVtbl[6])(@this, pixelsPerDip);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl, Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, Matrix*, int>)@this->LpVtbl[7])(@this, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetCurrentTransform(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, Matrix*, int>)@this->LpVtbl[8])(@this, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSize(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl, Silk.NET.Maths.Vector2D<int>* size)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[9])(@this, size);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Resize(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl, uint width, uint height)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, uint, uint, int>)@this->LpVtbl[10])(@this, width, height);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static TextAntialiasMode GetTextAntialiasMode(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TextAntialiasMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, TextAntialiasMode>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextAntialiasMode(this ComPtr<IDWriteBitmapRenderTarget1> thisVtbl, TextAntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteBitmapRenderTarget1*, TextAntialiasMode, int>)@this->LpVtbl[12])(@this, antialiasMode);
        return ret;
    }

}
