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

public unsafe static class D2D1CommandSink3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1CommandSink3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1CommandSink3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1CommandSink3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginDraw(this ComPtr<ID2D1CommandSink3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, int>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndDraw(this ComPtr<ID2D1CommandSink3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAntialiasMode(this ComPtr<ID2D1CommandSink3> thisVtbl, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, AntialiasMode, int>)@this->LpVtbl[5])(@this, antialiasMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTags(this ComPtr<ID2D1CommandSink3> thisVtbl, ulong tag1, ulong tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ulong, ulong, int>)@this->LpVtbl[6])(@this, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextAntialiasMode(this ComPtr<ID2D1CommandSink3> thisVtbl, TextAntialiasMode textAntialiasMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, TextAntialiasMode, int>)@this->LpVtbl[7])(@this, textAntialiasMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTextRenderingParams(this ComPtr<ID2D1CommandSink3> thisVtbl, IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, IDWriteRenderingParams*, int>)@this->LpVtbl[8])(@this, textRenderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTransform(this ComPtr<ID2D1CommandSink3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, Silk.NET.Maths.Matrix3X2<float>*, int>)@this->LpVtbl[9])(@this, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrimitiveBlend(this ComPtr<ID2D1CommandSink3> thisVtbl, PrimitiveBlend primitiveBlend)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, PrimitiveBlend, int>)@this->LpVtbl[10])(@this, primitiveBlend);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetUnitMode(this ComPtr<ID2D1CommandSink3> thisVtbl, UnitMode unitMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, UnitMode, int>)@this->LpVtbl[11])(@this, unitMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clear(this ComPtr<ID2D1CommandSink3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[12])(@this, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGlyphRun(this ComPtr<ID2D1CommandSink3> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRunDescription* glyphRunDescription, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteGlyphRunDescription*, ID2D1Brush*, DwriteMeasuringMode, int>)@this->LpVtbl[13])(@this, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawLine(this ComPtr<ID2D1CommandSink3> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[14])(@this, point0, point1, brush, strokeWidth, strokeStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGeometry(this ComPtr<ID2D1CommandSink3> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[15])(@this, geometry, brush, strokeWidth, strokeStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawRectangle(this ComPtr<ID2D1CommandSink3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, int>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawBitmap(this ComPtr<ID2D1CommandSink3> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, InterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix4X4<float>* perspectiveTransform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, InterpolationMode, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Matrix4X4<float>*, int>)@this->LpVtbl[17])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawImage(this ComPtr<ID2D1CommandSink3> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, int>)@this->LpVtbl[18])(@this, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGdiMetafile(this ComPtr<ID2D1CommandSink3> thisVtbl, ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[19])(@this, gdiMetafile, targetOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillMesh(this ComPtr<ID2D1CommandSink3> thisVtbl, ID2D1Mesh* mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ID2D1Mesh*, ID2D1Brush*, int>)@this->LpVtbl[20])(@this, mesh, brush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillOpacityMask(this ComPtr<ID2D1CommandSink3> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ID2D1Bitmap*, ID2D1Brush*, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[21])(@this, opacityMask, brush, destinationRectangle, sourceRectangle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillGeometry(this ComPtr<ID2D1CommandSink3> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int>)@this->LpVtbl[22])(@this, geometry, brush, opacityBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FillRectangle(this ComPtr<ID2D1CommandSink3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, int>)@this->LpVtbl[23])(@this, rect, brush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushAxisAlignedClip(this ComPtr<ID2D1CommandSink3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, int>)@this->LpVtbl[24])(@this, clipRect, antialiasMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PushLayer(this ComPtr<ID2D1CommandSink3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters1* layerParameters1, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, LayerParameters1*, ID2D1Layer*, int>)@this->LpVtbl[25])(@this, layerParameters1, layer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PopAxisAlignedClip(this ComPtr<ID2D1CommandSink3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, int>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PopLayer(this ComPtr<ID2D1CommandSink3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, int>)@this->LpVtbl[27])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPrimitiveBlend1(this ComPtr<ID2D1CommandSink3> thisVtbl, PrimitiveBlend primitiveBlend)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, PrimitiveBlend, int>)@this->LpVtbl[28])(@this, primitiveBlend);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawInk(this ComPtr<ID2D1CommandSink3> thisVtbl, ID2D1Ink* ink, ID2D1Brush* brush, ID2D1InkStyle* inkStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, int>)@this->LpVtbl[29])(@this, ink, brush, inkStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawGradientMesh(this ComPtr<ID2D1CommandSink3> thisVtbl, ID2D1GradientMesh* gradientMesh)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ID2D1GradientMesh*, int>)@this->LpVtbl[30])(@this, gradientMesh);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DrawSpriteBatch(this ComPtr<ID2D1CommandSink3> thisVtbl, ID2D1SpriteBatch* spriteBatch, uint startIndex, uint spriteCount, ID2D1Bitmap* bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1CommandSink3*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, int>)@this->LpVtbl[32])(@this, spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
        return ret;
    }

}
