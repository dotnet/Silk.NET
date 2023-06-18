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

public unsafe static class D2D1RenderTargetVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1RenderTarget> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1RenderTarget> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1RenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcData, pitch, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1RenderTarget> thisVtbl, IWICBitmapSource* wicBitmapSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSource, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1RenderTarget> thisVtbl, Guid* riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, data, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1RenderTarget> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, color, brushProperties, solidColorBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)@this->LpVtbl[9])(@this, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* size, ID2D1Layer** layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)@this->LpVtbl[13])(@this, size, layer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMesh(this ComPtr<ID2D1RenderTarget> thisVtbl, ID2D1Mesh** mesh)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ID2D1Mesh**, int>)@this->LpVtbl[14])(@this, mesh);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1RenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[15])(@this, point0, point1, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)@this->LpVtbl[17])(@this, rect, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRect, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, RoundedRect*, ID2D1Brush*, void>)@this->LpVtbl[19])(@this, roundedRect, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipse, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Ellipse*, ID2D1Brush*, void>)@this->LpVtbl[21])(@this, ellipse, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1RenderTarget> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometry, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1RenderTarget> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometry, brush, opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1RenderTarget> thisVtbl, ID2D1Mesh* mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)@this->LpVtbl[24])(@this, mesh, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1RenderTarget> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brush, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1RenderTarget> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout(this ComPtr<ID2D1RenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)@this->LpVtbl[28])(@this, origin, textLayout, defaultFillBrush, options);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun(this ComPtr<ID2D1RenderTarget> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)@this->LpVtbl[29])(@this, baselineOrigin, glyphRun, foregroundBrush, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTransform(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[30])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTransform(this ComPtr<ID2D1RenderTarget> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[31])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void SetAntialiasMode(this ComPtr<ID2D1RenderTarget> thisVtbl, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, AntialiasMode, void>)@this->LpVtbl[32])(@this, antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static AntialiasMode GetAntialiasMode(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        AntialiasMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, AntialiasMode>)@this->LpVtbl[33])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetTextAntialiasMode(this ComPtr<ID2D1RenderTarget> thisVtbl, TextAntialiasMode textAntialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, TextAntialiasMode, void>)@this->LpVtbl[34])(@this, textAntialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static TextAntialiasMode GetTextAntialiasMode(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TextAntialiasMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, TextAntialiasMode>)@this->LpVtbl[35])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTextRenderingParams(this ComPtr<ID2D1RenderTarget> thisVtbl, IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, IDWriteRenderingParams*, void>)@this->LpVtbl[36])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTextRenderingParams(this ComPtr<ID2D1RenderTarget> thisVtbl, IDWriteRenderingParams** textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, IDWriteRenderingParams**, void>)@this->LpVtbl[37])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static void SetTags(this ComPtr<ID2D1RenderTarget> thisVtbl, ulong tag1, ulong tag2)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ulong, ulong, void>)@this->LpVtbl[38])(@this, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1RenderTarget> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ulong*, ulong*, void>)@this->LpVtbl[39])(@this, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters* layerParameters, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, LayerParameters*, ID2D1Layer*, void>)@this->LpVtbl[40])(@this, layerParameters, layer);
    }

    /// <summary>To be documented.</summary>
    public static void PopLayer(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, void>)@this->LpVtbl[41])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1RenderTarget> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ulong*, ulong*, int>)@this->LpVtbl[42])(@this, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SaveDrawingState(this ComPtr<ID2D1RenderTarget> thisVtbl, ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[43])(@this, drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RestoreDrawingState(this ComPtr<ID2D1RenderTarget> thisVtbl, ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[44])(@this, drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushAxisAlignedClip(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, void>)@this->LpVtbl[45])(@this, clipRect, antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static void PopAxisAlignedClip(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, void>)@this->LpVtbl[46])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Clear(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* clearColor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[47])(@this, clearColor);
    }

    /// <summary>To be documented.</summary>
    public static void BeginDraw(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, void>)@this->LpVtbl[48])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1RenderTarget> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, ulong*, ulong*, int>)@this->LpVtbl[49])(@this, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static PixelFormat GetPixelFormat(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        PixelFormat silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        PixelFormat* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, PixelFormat*, PixelFormat*>)@this->LpVtbl[50])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDpi(this ComPtr<ID2D1RenderTarget> thisVtbl, float dpiX, float dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, float, float, void>)@this->LpVtbl[51])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1RenderTarget> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, float*, float*, void>)@this->LpVtbl[52])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<float> GetSize(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<float>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)@this->LpVtbl[53])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<uint> GetPixelSize(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<uint> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<uint>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, Silk.NET.Maths.Vector2D<uint>*, Silk.NET.Maths.Vector2D<uint>*>)@this->LpVtbl[54])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetMaximumBitmapSize(this ComPtr<ID2D1RenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, uint>)@this->LpVtbl[55])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsSupported(this ComPtr<ID2D1RenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1RenderTarget*, RenderTargetProperties*, Silk.NET.Core.Bool32>)@this->LpVtbl[56])(@this, renderTargetProperties);
        return ret;
    }

}
