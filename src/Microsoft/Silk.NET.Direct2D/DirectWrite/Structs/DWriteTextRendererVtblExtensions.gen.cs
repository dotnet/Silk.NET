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

public unsafe static class DWriteTextRendererVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextRenderer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteTextRenderer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextRenderer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled(this ComPtr<IDWriteTextRenderer> thisVtbl, void* clientDrawingContext, int* isDisabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform(this ComPtr<IDWriteTextRenderer> thisVtbl, void* clientDrawingContext, Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip(this ComPtr<IDWriteTextRenderer> thisVtbl, void* clientDrawingContext, float* pixelsPerDip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDip);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<IDWriteTextRenderer> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer*, void*, float, float, MeasuringMode, GlyphRun*, GlyphRunDescription*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawUnderline(this ComPtr<IDWriteTextRenderer> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Underline* underline, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer*, void*, float, float, Underline*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[7])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawStrikethrough(this ComPtr<IDWriteTextRenderer> thisVtbl, void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Strikethrough* strikethrough, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer*, void*, float, float, Strikethrough*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[8])(@this, clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInlineObject(this ComPtr<IDWriteTextRenderer> thisVtbl, void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Core.Native.IUnknown* clientDrawingEffect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextRenderer*, void*, float, float, IDWriteInlineObject*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[9])(@this, clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
        return ret;
    }

}
