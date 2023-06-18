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

public unsafe static class D2D1DeviceContext4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1DeviceContext4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmap(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.Maths.Vector2D<uint> size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[4])(@this, size, srcData, pitch, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromWicBitmap(this ComPtr<ID2D1DeviceContext4> thisVtbl, IWICBitmapSource* wicBitmapSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[5])(@this, wicBitmapSource, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSharedBitmap(this ComPtr<ID2D1DeviceContext4> thisVtbl, Guid* riid, void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)@this->LpVtbl[6])(@this, riid, data, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapBrush(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapBrushProperties* bitmapBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)@this->LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSolidColorBrush(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)@this->LpVtbl[8])(@this, color, brushProperties, solidColorBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientStopCollection(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)@this->LpVtbl[9])(@this, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLinearGradientBrush(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LinearGradientBrushProperties* linearGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)@this->LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRadialGradientBrush(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RadialGradientBrushProperties* radialGradientBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)@this->LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCompatibleRenderTarget(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* desiredSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)@this->LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLayer(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* size, ID2D1Layer** layer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)@this->LpVtbl[13])(@this, size, layer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMesh(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Mesh** mesh)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Mesh**, int>)@this->LpVtbl[14])(@this, mesh);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawLine(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[15])(@this, point0, point1, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRectangle(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRectangle(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)@this->LpVtbl[17])(@this, rect, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawRoundedRectangle(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[18])(@this, roundedRect, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillRoundedRectangle(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RoundedRect* roundedRect, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, RoundedRect*, ID2D1Brush*, void>)@this->LpVtbl[19])(@this, roundedRect, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawEllipse(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[20])(@this, ellipse, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillEllipse(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Ellipse* ellipse, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Ellipse*, ID2D1Brush*, void>)@this->LpVtbl[21])(@this, ellipse, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometry(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)@this->LpVtbl[22])(@this, geometry, brush, strokeWidth, strokeStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillGeometry(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)@this->LpVtbl[23])(@this, geometry, brush, opacityBrush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillMesh(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Mesh* mesh, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Mesh*, ID2D1Brush*, void>)@this->LpVtbl[24])(@this, mesh, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void FillOpacityMask(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[25])(@this, opacityMask, brush, content, destinationRectangle, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawBitmap(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* sourceRectangle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)@this->LpVtbl[26])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextA(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)@this->LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawTextLayout(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)@this->LpVtbl[28])(@this, origin, textLayout, defaultFillBrush, options);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGlyphRun(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)@this->LpVtbl[29])(@this, baselineOrigin, glyphRun, foregroundBrush, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTransform(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[30])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTransform(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.Maths.Matrix3X2<float>* transform)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Matrix3X2<float>*, void>)@this->LpVtbl[31])(@this, transform);
    }

    /// <summary>To be documented.</summary>
    public static void SetAntialiasMode(this ComPtr<ID2D1DeviceContext4> thisVtbl, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, AntialiasMode, void>)@this->LpVtbl[32])(@this, antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static AntialiasMode GetAntialiasMode(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        AntialiasMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, AntialiasMode>)@this->LpVtbl[33])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetTextAntialiasMode(this ComPtr<ID2D1DeviceContext4> thisVtbl, TextAntialiasMode textAntialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, TextAntialiasMode, void>)@this->LpVtbl[34])(@this, textAntialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static TextAntialiasMode GetTextAntialiasMode(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TextAntialiasMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, TextAntialiasMode>)@this->LpVtbl[35])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTextRenderingParams(this ComPtr<ID2D1DeviceContext4> thisVtbl, IDWriteRenderingParams* textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, IDWriteRenderingParams*, void>)@this->LpVtbl[36])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTextRenderingParams(this ComPtr<ID2D1DeviceContext4> thisVtbl, IDWriteRenderingParams** textRenderingParams)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, IDWriteRenderingParams**, void>)@this->LpVtbl[37])(@this, textRenderingParams);
    }

    /// <summary>To be documented.</summary>
    public static void SetTags(this ComPtr<ID2D1DeviceContext4> thisVtbl, ulong tag1, ulong tag2)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ulong, ulong, void>)@this->LpVtbl[38])(@this, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTags(this ComPtr<ID2D1DeviceContext4> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ulong*, ulong*, void>)@this->LpVtbl[39])(@this, tag1, tag2);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushLayer(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LayerParameters* layerParameters, ID2D1Layer* layer)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, LayerParameters*, ID2D1Layer*, void>)@this->LpVtbl[40])(@this, layerParameters, layer);
    }

    /// <summary>To be documented.</summary>
    public static void PopLayer(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, void>)@this->LpVtbl[41])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Flush(this ComPtr<ID2D1DeviceContext4> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ulong*, ulong*, int>)@this->LpVtbl[42])(@this, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SaveDrawingState(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[43])(@this, drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void RestoreDrawingState(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1DrawingStateBlock* drawingStateBlock)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1DrawingStateBlock*, void>)@this->LpVtbl[44])(@this, drawingStateBlock);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void PushAxisAlignedClip(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* clipRect, AntialiasMode antialiasMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, void>)@this->LpVtbl[45])(@this, clipRect, antialiasMode);
    }

    /// <summary>To be documented.</summary>
    public static void PopAxisAlignedClip(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, void>)@this->LpVtbl[46])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void Clear(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* clearColor)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[47])(@this, clearColor);
    }

    /// <summary>To be documented.</summary>
    public static void BeginDraw(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, void>)@this->LpVtbl[48])(@this);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EndDraw(this ComPtr<ID2D1DeviceContext4> thisVtbl, ulong* tag1, ulong* tag2)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ulong*, ulong*, int>)@this->LpVtbl[49])(@this, tag1, tag2);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static PixelFormat GetPixelFormat(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        PixelFormat silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        PixelFormat* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, PixelFormat*, PixelFormat*>)@this->LpVtbl[50])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDpi(this ComPtr<ID2D1DeviceContext4> thisVtbl, float dpiX, float dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, float, float, void>)@this->LpVtbl[51])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDpi(this ComPtr<ID2D1DeviceContext4> thisVtbl, float* dpiX, float* dpiY)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, float*, float*, void>)@this->LpVtbl[52])(@this, dpiX, dpiY);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<float> GetSize(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<float>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)@this->LpVtbl[53])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Maths.Vector2D<uint> GetPixelSize(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Maths.Vector2D<uint> silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Silk.NET.Maths.Vector2D<uint>* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<uint>*, Silk.NET.Maths.Vector2D<uint>*>)@this->LpVtbl[54])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetMaximumBitmapSize(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, uint>)@this->LpVtbl[55])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsSupported(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetProperties* renderTargetProperties)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, RenderTargetProperties*, Silk.NET.Core.Bool32>)@this->LpVtbl[56])(@this, renderTargetProperties);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContext(this ComPtr<ID2D1DeviceContext4> thisVtbl, ColorSpace space, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* profile, uint profileSize, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)@this->LpVtbl[59])(@this, space, profile, profileSize, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromFilename(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filename, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, char*, ID2D1ColorContext**, int>)@this->LpVtbl[60])(@this, filename, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateColorContextFromWicColorContext(this ComPtr<ID2D1DeviceContext4> thisVtbl, IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, IWICColorContext*, ID2D1ColorContext**, int>)@this->LpVtbl[61])(@this, wicColorContext, colorContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateBitmapFromDxgiSurface(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.DXGI.IDXGISurface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BitmapProperties1* bitmapProperties, ID2D1Bitmap1** bitmap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)@this->LpVtbl[62])(@this, surface, bitmapProperties, bitmap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEffect(this ComPtr<ID2D1DeviceContext4> thisVtbl, Guid* effectId, ID2D1Effect** effect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Guid*, ID2D1Effect**, int>)@this->LpVtbl[63])(@this, effectId, effect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageBrush(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageBrushProperties* imageBrushProperties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)@this->LpVtbl[65])(@this, image, imageBrushProperties, brushProperties, imageBrush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCommandList(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1CommandList** commandList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1CommandList**, int>)@this->LpVtbl[67])(@this, commandList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsDxgiFormatSupported(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.DXGI.Format format)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.DXGI.Format, Silk.NET.Core.Bool32>)@this->LpVtbl[68])(@this, format);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsBufferPrecisionSupported(this ComPtr<ID2D1DeviceContext4> thisVtbl, BufferPrecision bufferPrecision)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, BufferPrecision, Silk.NET.Core.Bool32>)@this->LpVtbl[69])(@this, bufferPrecision);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageLocalBounds(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Image* image, Silk.NET.Maths.Box2D<float>* localBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[70])(@this, image, localBounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetImageWorldBounds(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Image* image, Silk.NET.Maths.Box2D<float>* worldBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[71])(@this, image, worldBounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunWorldBounds(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, DwriteMeasuringMode measuringMode, Silk.NET.Maths.Box2D<float>* bounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteMeasuringMode, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[72])(@this, baselineOrigin, glyphRun, measuringMode, bounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDevice(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Device** device)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Device**, void>)@this->LpVtbl[73])(@this, device);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetTarget(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Image* image)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Image*, void>)@this->LpVtbl[74])(@this, image);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetTarget(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Image** image)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Image**, void>)@this->LpVtbl[75])(@this, image);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetRenderingControls(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingControls* renderingControls)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, RenderingControls*, void>)@this->LpVtbl[76])(@this, renderingControls);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetRenderingControls(this ComPtr<ID2D1DeviceContext4> thisVtbl, RenderingControls* renderingControls)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, RenderingControls*, void>)@this->LpVtbl[77])(@this, renderingControls);
    }

    /// <summary>To be documented.</summary>
    public static void SetPrimitiveBlend(this ComPtr<ID2D1DeviceContext4> thisVtbl, PrimitiveBlend primitiveBlend)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, PrimitiveBlend, void>)@this->LpVtbl[78])(@this, primitiveBlend);
    }

    /// <summary>To be documented.</summary>
    public static PrimitiveBlend GetPrimitiveBlend(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        PrimitiveBlend ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, PrimitiveBlend>)@this->LpVtbl[79])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetUnitMode(this ComPtr<ID2D1DeviceContext4> thisVtbl, UnitMode unitMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, UnitMode, void>)@this->LpVtbl[80])(@this, unitMode);
    }

    /// <summary>To be documented.</summary>
    public static UnitMode GetUnitMode(this ComPtr<ID2D1DeviceContext4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        UnitMode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, UnitMode>)@this->LpVtbl[81])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawImage(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)@this->LpVtbl[83])(@this, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGdiMetafile(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1GdiMetafile* gdiMetafile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* targetOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, void>)@this->LpVtbl[84])(@this, gdiMetafile, targetOffset);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InvalidateEffectInputRectangle(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Effect* effect, uint input, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* inputRectangle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Effect*, uint, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[87])(@this, effect, input, inputRectangle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangleCount(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Effect* effect, uint* rectangleCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Effect*, uint*, int>)@this->LpVtbl[88])(@this, effect, rectangleCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectInvalidRectangles(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Effect* effect, Silk.NET.Maths.Box2D<float>* rectangles, uint rectanglesCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[89])(@this, effect, rectangles, rectanglesCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEffectRequiredInputRectangles(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Effect* renderEffect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<float>* renderImageRectangle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)@this->LpVtbl[90])(@this, renderEffect, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFilledGeometryRealization(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Geometry* geometry, float flatteningTolerance, ID2D1GeometryRealization** geometryRealization)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Geometry*, float, ID2D1GeometryRealization**, int>)@this->LpVtbl[92])(@this, geometry, flatteningTolerance, geometryRealization);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStrokedGeometryRealization(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Geometry* geometry, float flatteningTolerance, float strokeWidth, ID2D1StrokeStyle* strokeStyle, ID2D1GeometryRealization** geometryRealization)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int>)@this->LpVtbl[93])(@this, geometry, flatteningTolerance, strokeWidth, strokeStyle, geometryRealization);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGeometryRealization(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1GeometryRealization* geometryRealization, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1GeometryRealization*, ID2D1Brush*, void>)@this->LpVtbl[94])(@this, geometryRealization, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInk(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkPoint* startPoint, ID2D1Ink** ink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, InkPoint*, ID2D1Ink**, int>)@this->LpVtbl[95])(@this, startPoint, ink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInkStyle(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkStyleProperties* inkStyleProperties, ID2D1InkStyle** inkStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, InkStyleProperties*, ID2D1InkStyle**, int>)@this->LpVtbl[96])(@this, inkStyleProperties, inkStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGradientMesh(this ComPtr<ID2D1DeviceContext4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GradientMeshPatch* patches, uint patchesCount, ID2D1GradientMesh** gradientMesh)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, GradientMeshPatch*, uint, ID2D1GradientMesh**, int>)@this->LpVtbl[97])(@this, patches, patchesCount, gradientMesh);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageSourceFromWic(this ComPtr<ID2D1DeviceContext4> thisVtbl, IWICBitmapSource* wicBitmapSource, ImageSourceLoadingOptions loadingOptions, AlphaMode alphaMode, ID2D1ImageSourceFromWic** imageSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, IWICBitmapSource*, ImageSourceLoadingOptions, AlphaMode, ID2D1ImageSourceFromWic**, int>)@this->LpVtbl[98])(@this, wicBitmapSource, loadingOptions, alphaMode, imageSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateLookupTable3D(this ComPtr<ID2D1DeviceContext4> thisVtbl, BufferPrecision precision, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* extents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, ID2D1LookupTable3D** lookupTable)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)@this->LpVtbl[99])(@this, precision, extents, data, dataCount, strides, lookupTable);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateImageSourceFromDxgi(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.DXGI.IDXGISurface** surfaces, uint surfaceCount, Silk.NET.DXGI.ColorSpaceType colorSpace, ImageSourceFromDxgiOptions options, ID2D1ImageSource** imageSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.DXGI.IDXGISurface**, uint, Silk.NET.DXGI.ColorSpaceType, ImageSourceFromDxgiOptions, ID2D1ImageSource**, int>)@this->LpVtbl[100])(@this, surfaces, surfaceCount, colorSpace, options, imageSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGradientMeshWorldBounds(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1GradientMesh* gradientMesh, Silk.NET.Maths.Box2D<float>* pBounds)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1GradientMesh*, Silk.NET.Maths.Box2D<float>*, int>)@this->LpVtbl[101])(@this, gradientMesh, pBounds);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawInk(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1Ink* ink, ID2D1Brush* brush, ID2D1InkStyle* inkStyle)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void>)@this->LpVtbl[102])(@this, ink, brush, inkStyle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawGradientMesh(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1GradientMesh* gradientMesh)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1GradientMesh*, void>)@this->LpVtbl[103])(@this, gradientMesh);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTransformedImageSource(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1ImageSource* imageSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformedImageSourceProperties* properties, ID2D1TransformedImageSource** transformedImageSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1ImageSource*, TransformedImageSourceProperties*, ID2D1TransformedImageSource**, int>)@this->LpVtbl[105])(@this, imageSource, properties, transformedImageSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSpriteBatch(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1SpriteBatch** spriteBatch)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1SpriteBatch**, int>)@this->LpVtbl[106])(@this, spriteBatch);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawSpriteBatch(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1SpriteBatch* spriteBatch, uint startIndex, uint spriteCount, ID2D1Bitmap* bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, void>)@this->LpVtbl[107])(@this, spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateSvgGlyphStyle(this ComPtr<ID2D1DeviceContext4> thisVtbl, ID2D1SvgGlyphStyle** svgGlyphStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, ID2D1SvgGlyphStyle**, int>)@this->LpVtbl[108])(@this, svgGlyphStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawColorBitmapGlyphRun(this ComPtr<ID2D1DeviceContext4> thisVtbl, DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, DwriteMeasuringMode measuringMode, ColorBitmapGlyphSnapOption bitmapSnapOption)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteMeasuringMode, ColorBitmapGlyphSnapOption, void>)@this->LpVtbl[111])(@this, glyphImageFormat, baselineOrigin, glyphRun, measuringMode, bitmapSnapOption);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void DrawSvgGlyphRun(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DwriteGlyphRun* glyphRun, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, DwriteMeasuringMode measuringMode)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, DwriteMeasuringMode, void>)@this->LpVtbl[112])(@this, baselineOrigin, glyphRun, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, measuringMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColorBitmapGlyphImage(this ComPtr<ID2D1DeviceContext4> thisVtbl, DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, Silk.NET.Core.Bool32 isSideways, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, float dpiX, float dpiY, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1Image** glyphImage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, Silk.NET.Core.Bool32, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)@this->LpVtbl[113])(@this, glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransform, glyphImage);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSvgGlyphImage(this ComPtr<ID2D1DeviceContext4> thisVtbl, Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, Silk.NET.Core.Bool32 isSideways, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext4*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, Silk.NET.Core.Bool32, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)@this->LpVtbl[114])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
        return ret;
    }

}
