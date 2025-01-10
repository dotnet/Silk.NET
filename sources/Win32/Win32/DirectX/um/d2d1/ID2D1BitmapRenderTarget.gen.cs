// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.DirectX.D2D1_BITMAP_INTERPOLATION_MODE;
using static Silk.NET.DirectX.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS;
using static Silk.NET.DirectX.D2D1_DRAW_TEXT_OPTIONS;
using static Silk.NET.DirectX.D2D1_EXTEND_MODE;
using static Silk.NET.DirectX.D2D1_GAMMA;
using static Silk.NET.DirectX.DWRITE_MEASURING_MODE;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("2CD90695-12E2-11DC-9FED-001143A055F9")]
[NativeTypeName("struct ID2D1BitmapRenderTarget : ID2D1RenderTarget")]
[NativeInheritance("ID2D1RenderTarget")]
public unsafe partial struct ID2D1BitmapRenderTarget
    : ID2D1BitmapRenderTarget.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1BitmapRenderTarget));
    public void*** lpVtbl;

    public HRESULT CreateBitmap(
        [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size,
        [NativeTypeName("const D2D1_BITMAP_PROPERTIES &")] D2D1_BITMAP_PROPERTIES* bitmapProperties,
        ID2D1Bitmap* bitmap
    )
    {
        return CreateBitmap(size, null, 0, bitmapProperties, bitmap);
    }

    public HRESULT CreateBitmapFromWicBitmap(IWICBitmapSource wicBitmapSource, ID2D1Bitmap* bitmap)
    {
        return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
    }

    public HRESULT CreateBitmapBrush(ID2D1Bitmap bitmap, ID2D1BitmapBrush* bitmapBrush)
    {
        return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
    }

    public HRESULT CreateBitmapBrush(
        ID2D1Bitmap bitmap,
        [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES &")]
            D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties,
        ID2D1BitmapBrush* bitmapBrush
    )
    {
        return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
    }

    public HRESULT CreateSolidColorBrush(
        [NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color,
        ID2D1SolidColorBrush* solidColorBrush
    )
    {
        return CreateSolidColorBrush(color, null, solidColorBrush);
    }

    public HRESULT CreateGradientStopCollection(
        [NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops,
        [NativeTypeName("UINT32")] uint gradientStopsCount,
        ID2D1GradientStopCollection* gradientStopCollection
    )
    {
        return CreateGradientStopCollection(
            gradientStops,
            gradientStopsCount,
            D2D1_GAMMA_2_2,
            D2D1_EXTEND_MODE_CLAMP,
            gradientStopCollection
        );
    }

    public HRESULT CreateLinearGradientBrush(
        [NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES &")]
            D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties,
        ID2D1GradientStopCollection gradientStopCollection,
        ID2D1LinearGradientBrush* linearGradientBrush
    )
    {
        return CreateLinearGradientBrush(
            linearGradientBrushProperties,
            null,
            gradientStopCollection,
            linearGradientBrush
        );
    }

    public HRESULT CreateRadialGradientBrush(
        [NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES &")]
            D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties,
        ID2D1GradientStopCollection gradientStopCollection,
        ID2D1RadialGradientBrush* radialGradientBrush
    )
    {
        return CreateRadialGradientBrush(
            radialGradientBrushProperties,
            null,
            gradientStopCollection,
            radialGradientBrush
        );
    }

    public HRESULT CreateCompatibleRenderTarget(ID2D1BitmapRenderTarget* bitmapRenderTarget)
    {
        return CreateCompatibleRenderTarget(
            null,
            null,
            null,
            D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE,
            bitmapRenderTarget
        );
    }

    public HRESULT CreateCompatibleRenderTarget(
        [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize,
        ID2D1BitmapRenderTarget* bitmapRenderTarget
    )
    {
        return CreateCompatibleRenderTarget(
            &desiredSize,
            null,
            null,
            D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE,
            bitmapRenderTarget
        );
    }

    public HRESULT CreateCompatibleRenderTarget(
        [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize,
        [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize,
        ID2D1BitmapRenderTarget* bitmapRenderTarget
    )
    {
        return CreateCompatibleRenderTarget(
            &desiredSize,
            &desiredPixelSize,
            null,
            D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE,
            bitmapRenderTarget
        );
    }

    public HRESULT CreateCompatibleRenderTarget(
        [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize,
        [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize,
        D2D1_PIXEL_FORMAT desiredFormat,
        ID2D1BitmapRenderTarget* bitmapRenderTarget
    )
    {
        return CreateCompatibleRenderTarget(
            &desiredSize,
            &desiredPixelSize,
            &desiredFormat,
            D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE,
            bitmapRenderTarget
        );
    }

    public HRESULT CreateCompatibleRenderTarget(
        [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize,
        [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize,
        D2D1_PIXEL_FORMAT desiredFormat,
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options,
        ID2D1BitmapRenderTarget* bitmapRenderTarget
    )
    {
        return CreateCompatibleRenderTarget(
            &desiredSize,
            &desiredPixelSize,
            &desiredFormat,
            options,
            bitmapRenderTarget
        );
    }

    public HRESULT CreateLayer([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F size, ID2D1Layer* layer)
    {
        return CreateLayer(&size, layer);
    }

    public HRESULT CreateLayer(ID2D1Layer* layer)
    {
        return CreateLayer(null, layer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1BitmapRenderTarget, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1BitmapRenderTarget, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1BitmapRenderTarget, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateBitmap(
        [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size,
        [NativeTypeName("const void *")] void* srcData,
        [NativeTypeName("UINT32")] uint pitch,
        [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties,
        ID2D1Bitmap* bitmap
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D_SIZE_U,
                void*,
                uint,
                D2D1_BITMAP_PROPERTIES*,
                ID2D1Bitmap*,
                int>)((*lpVtbl)[4])
        )(this, size, srcData, pitch, bitmapProperties, bitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateBitmapFromWicBitmap(
        IWICBitmapSource wicBitmapSource,
        [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties,
        ID2D1Bitmap* bitmap
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                IWICBitmapSource,
                D2D1_BITMAP_PROPERTIES*,
                ID2D1Bitmap*,
                int>)((*lpVtbl)[5])
        )(this, wicBitmapSource, bitmapProperties, bitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateSharedBitmap(
        [NativeTypeName("const IID &")] Guid* riid,
        void* data,
        [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties,
        ID2D1Bitmap* bitmap
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                Guid*,
                void*,
                D2D1_BITMAP_PROPERTIES*,
                ID2D1Bitmap*,
                int>)((*lpVtbl)[6])
        )(this, riid, data, bitmapProperties, bitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateBitmapBrush(
        ID2D1Bitmap bitmap,
        [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES *")]
            D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties,
        [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties,
        ID2D1BitmapBrush* bitmapBrush
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                ID2D1Bitmap,
                D2D1_BITMAP_BRUSH_PROPERTIES*,
                D2D1_BRUSH_PROPERTIES*,
                ID2D1BitmapBrush*,
                int>)((*lpVtbl)[7])
        )(this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateSolidColorBrush(
        [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color,
        [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties,
        ID2D1SolidColorBrush* solidColorBrush
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                DXGI_RGBA*,
                D2D1_BRUSH_PROPERTIES*,
                ID2D1SolidColorBrush*,
                int>)((*lpVtbl)[8])
        )(this, color, brushProperties, solidColorBrush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateGradientStopCollection(
        [NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops,
        [NativeTypeName("UINT32")] uint gradientStopsCount,
        D2D1_GAMMA colorInterpolationGamma,
        D2D1_EXTEND_MODE extendMode,
        ID2D1GradientStopCollection* gradientStopCollection
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D1_GRADIENT_STOP*,
                uint,
                D2D1_GAMMA,
                D2D1_EXTEND_MODE,
                ID2D1GradientStopCollection*,
                int>)((*lpVtbl)[9])
        )(
            this,
            gradientStops,
            gradientStopsCount,
            colorInterpolationGamma,
            extendMode,
            gradientStopCollection
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateLinearGradientBrush(
        [NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *")]
            D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties,
        [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties,
        ID2D1GradientStopCollection gradientStopCollection,
        ID2D1LinearGradientBrush* linearGradientBrush
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES*,
                D2D1_BRUSH_PROPERTIES*,
                ID2D1GradientStopCollection,
                ID2D1LinearGradientBrush*,
                int>)((*lpVtbl)[10])
        )(
            this,
            linearGradientBrushProperties,
            brushProperties,
            gradientStopCollection,
            linearGradientBrush
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateRadialGradientBrush(
        [NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *")]
            D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties,
        [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties,
        ID2D1GradientStopCollection gradientStopCollection,
        ID2D1RadialGradientBrush* radialGradientBrush
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*,
                D2D1_BRUSH_PROPERTIES*,
                ID2D1GradientStopCollection,
                ID2D1RadialGradientBrush*,
                int>)((*lpVtbl)[11])
        )(
            this,
            radialGradientBrushProperties,
            brushProperties,
            gradientStopCollection,
            radialGradientBrush
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCompatibleRenderTarget(
        [NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* desiredSize,
        [NativeTypeName("const D2D1_SIZE_U *")] D2D_SIZE_U* desiredPixelSize,
        [NativeTypeName("const D2D1_PIXEL_FORMAT *")] D2D1_PIXEL_FORMAT* desiredFormat,
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options,
        ID2D1BitmapRenderTarget* bitmapRenderTarget
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D_SIZE_F*,
                D2D_SIZE_U*,
                D2D1_PIXEL_FORMAT*,
                D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS,
                ID2D1BitmapRenderTarget*,
                int>)((*lpVtbl)[12])
        )(this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateLayer(
        [NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* size,
        ID2D1Layer* layer
    )
    {
        return (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D_SIZE_F*, ID2D1Layer*, int>)(
                (*lpVtbl)[13]
            )
        )(this, size, layer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateMesh(ID2D1Mesh* mesh)
    {
        return ((delegate* unmanaged<ID2D1BitmapRenderTarget, ID2D1Mesh*, int>)((*lpVtbl)[14]))(
            this,
            mesh
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void DrawLine(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1,
        ID2D1Brush brush,
        float strokeWidth = 1.0f,
        ID2D1StrokeStyle strokeStyle = default
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D_POINT_2F,
                D2D_POINT_2F,
                ID2D1Brush,
                float,
                ID2D1StrokeStyle,
                void>)((*lpVtbl)[15])
        )(this, point0, point1, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void DrawRectangle(
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect,
        ID2D1Brush brush,
        float strokeWidth = 1.0f,
        ID2D1StrokeStyle strokeStyle = default
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D_RECT_F*,
                ID2D1Brush,
                float,
                ID2D1StrokeStyle,
                void>)((*lpVtbl)[16])
        )(this, rect, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void FillRectangle(
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect,
        ID2D1Brush brush
    )
    {
        (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D_RECT_F*, ID2D1Brush, void>)(
                (*lpVtbl)[17]
            )
        )(this, rect, brush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void DrawRoundedRectangle(
        [NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect,
        ID2D1Brush brush,
        float strokeWidth = 1.0f,
        ID2D1StrokeStyle strokeStyle = default
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D1_ROUNDED_RECT*,
                ID2D1Brush,
                float,
                ID2D1StrokeStyle,
                void>)((*lpVtbl)[18])
        )(this, roundedRect, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void FillRoundedRectangle(
        [NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect,
        ID2D1Brush brush
    )
    {
        (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D1_ROUNDED_RECT*, ID2D1Brush, void>)(
                (*lpVtbl)[19]
            )
        )(this, roundedRect, brush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void DrawEllipse(
        [NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse,
        ID2D1Brush brush,
        float strokeWidth = 1.0f,
        ID2D1StrokeStyle strokeStyle = default
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D1_ELLIPSE*,
                ID2D1Brush,
                float,
                ID2D1StrokeStyle,
                void>)((*lpVtbl)[20])
        )(this, ellipse, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void FillEllipse(
        [NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse,
        ID2D1Brush brush
    )
    {
        (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D1_ELLIPSE*, ID2D1Brush, void>)(
                (*lpVtbl)[21]
            )
        )(this, ellipse, brush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void DrawGeometry(
        ID2D1Geometry geometry,
        ID2D1Brush brush,
        float strokeWidth = 1.0f,
        ID2D1StrokeStyle strokeStyle = default
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                ID2D1Geometry,
                ID2D1Brush,
                float,
                ID2D1StrokeStyle,
                void>)((*lpVtbl)[22])
        )(this, geometry, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void FillGeometry(
        ID2D1Geometry geometry,
        ID2D1Brush brush,
        ID2D1Brush opacityBrush = default
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                ID2D1Geometry,
                ID2D1Brush,
                ID2D1Brush,
                void>)((*lpVtbl)[23])
        )(this, geometry, brush, opacityBrush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void FillMesh(ID2D1Mesh mesh, ID2D1Brush brush)
    {
        (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, ID2D1Mesh, ID2D1Brush, void>)(
                (*lpVtbl)[24]
            )
        )(this, mesh, brush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void FillOpacityMask(
        ID2D1Bitmap opacityMask,
        ID2D1Brush brush,
        D2D1_OPACITY_MASK_CONTENT content,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                ID2D1Bitmap,
                ID2D1Brush,
                D2D1_OPACITY_MASK_CONTENT,
                D2D_RECT_F*,
                D2D_RECT_F*,
                void>)((*lpVtbl)[25])
        )(this, opacityMask, brush, content, destinationRectangle, sourceRectangle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void DrawBitmap(
        ID2D1Bitmap bitmap,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null,
        float opacity = 1.0f,
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                ID2D1Bitmap,
                D2D_RECT_F*,
                float,
                D2D1_BITMAP_INTERPOLATION_MODE,
                D2D_RECT_F*,
                void>)((*lpVtbl)[26])
        )(this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void DrawText(
        [NativeTypeName("const WCHAR *")] ushort* @string,
        [NativeTypeName("UINT32")] uint stringLength,
        IDWriteTextFormat textFormat,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect,
        ID2D1Brush defaultFillBrush,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE,
        DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                ushort*,
                uint,
                IDWriteTextFormat,
                D2D_RECT_F*,
                ID2D1Brush,
                D2D1_DRAW_TEXT_OPTIONS,
                DWRITE_MEASURING_MODE,
                void>)((*lpVtbl)[27])
        )(
            this,
            @string,
            stringLength,
            textFormat,
            layoutRect,
            defaultFillBrush,
            options,
            measuringMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void DrawTextLayout(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin,
        IDWriteTextLayout textLayout,
        ID2D1Brush defaultFillBrush,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D_POINT_2F,
                IDWriteTextLayout,
                ID2D1Brush,
                D2D1_DRAW_TEXT_OPTIONS,
                void>)((*lpVtbl)[28])
        )(this, origin, textLayout, defaultFillBrush, options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public void DrawGlyphRun(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
        [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun,
        ID2D1Brush foregroundBrush,
        DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D_POINT_2F,
                DWRITE_GLYPH_RUN*,
                ID2D1Brush,
                DWRITE_MEASURING_MODE,
                void>)((*lpVtbl)[29])
        )(this, baselineOrigin, glyphRun, foregroundBrush, measuringMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void SetTransform(
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform
    )
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, D2D_MATRIX_3X2_F*, void>)((*lpVtbl)[30]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, D2D_MATRIX_3X2_F*, void>)((*lpVtbl)[31]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, D2D1_ANTIALIAS_MODE, void>)((*lpVtbl)[32]))(
            this,
            antialiasMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public D2D1_ANTIALIAS_MODE GetAntialiasMode()
    {
        return ((delegate* unmanaged<ID2D1BitmapRenderTarget, D2D1_ANTIALIAS_MODE>)((*lpVtbl)[33]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
    {
        (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D1_TEXT_ANTIALIAS_MODE, void>)(
                (*lpVtbl)[34]
            )
        )(this, textAntialiasMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
    {
        return (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D1_TEXT_ANTIALIAS_MODE>)((*lpVtbl)[35])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void SetTextRenderingParams(IDWriteRenderingParams textRenderingParams = default)
    {
        (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, IDWriteRenderingParams, void>)(
                (*lpVtbl)[36]
            )
        )(this, textRenderingParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public void GetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
    {
        (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, IDWriteRenderingParams*, void>)(
                (*lpVtbl)[37]
            )
        )(this, textRenderingParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void SetTags(
        [NativeTypeName("D2D1_TAG")] ulong tag1,
        [NativeTypeName("D2D1_TAG")] ulong tag2
    )
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, ulong, ulong, void>)((*lpVtbl)[38]))(
            this,
            tag1,
            tag2
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public void GetTags(
        [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null,
        [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null
    )
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, ulong*, ulong*, void>)((*lpVtbl)[39]))(
            this,
            tag1,
            tag2
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public void PushLayer(
        [NativeTypeName("const D2D1_LAYER_PARAMETERS *")] D2D1_LAYER_PARAMETERS* layerParameters,
        ID2D1Layer layer
    )
    {
        (
            (delegate* unmanaged<
                ID2D1BitmapRenderTarget,
                D2D1_LAYER_PARAMETERS*,
                ID2D1Layer,
                void>)((*lpVtbl)[40])
        )(this, layerParameters, layer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public void PopLayer()
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, void>)((*lpVtbl)[41]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT Flush(
        [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null,
        [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null
    )
    {
        return ((delegate* unmanaged<ID2D1BitmapRenderTarget, ulong*, ulong*, int>)((*lpVtbl)[42]))(
            this,
            tag1,
            tag2
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public void SaveDrawingState(ID2D1DrawingStateBlock drawingStateBlock)
    {
        (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, ID2D1DrawingStateBlock, void>)(
                (*lpVtbl)[43]
            )
        )(this, drawingStateBlock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public void RestoreDrawingState(ID2D1DrawingStateBlock drawingStateBlock)
    {
        (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, ID2D1DrawingStateBlock, void>)(
                (*lpVtbl)[44]
            )
        )(this, drawingStateBlock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public void PushAxisAlignedClip(
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect,
        D2D1_ANTIALIAS_MODE antialiasMode
    )
    {
        (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, void>)(
                (*lpVtbl)[45]
            )
        )(this, clipRect, antialiasMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public void PopAxisAlignedClip()
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, void>)((*lpVtbl)[46]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public void Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* clearColor = null)
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, DXGI_RGBA*, void>)((*lpVtbl)[47]))(
            this,
            clearColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public void BeginDraw()
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, void>)((*lpVtbl)[48]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT EndDraw(
        [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null,
        [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null
    )
    {
        return ((delegate* unmanaged<ID2D1BitmapRenderTarget, ulong*, ulong*, int>)((*lpVtbl)[49]))(
            this,
            tag1,
            tag2
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public D2D1_PIXEL_FORMAT GetPixelFormat()
    {
        D2D1_PIXEL_FORMAT result;
        return *(
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*>)(
                (*lpVtbl)[50]
            )
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public void SetDpi(float dpiX, float dpiY)
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, float, float, void>)((*lpVtbl)[51]))(
            this,
            dpiX,
            dpiY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public void GetDpi(float* dpiX, float* dpiY)
    {
        ((delegate* unmanaged<ID2D1BitmapRenderTarget, float*, float*, void>)((*lpVtbl)[52]))(
            this,
            dpiX,
            dpiY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    [return: NativeTypeName("D2D1_SIZE_F")]
    public D2D_SIZE_F GetSize()
    {
        D2D_SIZE_F result;
        return *(
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D_SIZE_F*, D2D_SIZE_F*>)((*lpVtbl)[53])
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    [return: NativeTypeName("D2D1_SIZE_U")]
    public D2D_SIZE_U GetPixelSize()
    {
        D2D_SIZE_U result;
        return *(
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D_SIZE_U*, D2D_SIZE_U*>)((*lpVtbl)[54])
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    [return: NativeTypeName("UINT32")]
    public uint GetMaximumBitmapSize()
    {
        return ((delegate* unmanaged<ID2D1BitmapRenderTarget, uint>)((*lpVtbl)[55]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public BOOL IsSupported(
        [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")]
            D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties
    )
    {
        return (
            (delegate* unmanaged<ID2D1BitmapRenderTarget, D2D1_RENDER_TARGET_PROPERTIES*, int>)(
                (*lpVtbl)[56]
            )
        )(this, renderTargetProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT GetBitmap(ID2D1Bitmap* bitmap)
    {
        return ((delegate* unmanaged<ID2D1BitmapRenderTarget, ID2D1Bitmap*, int>)((*lpVtbl)[57]))(
            this,
            bitmap
        );
    }

    public interface Interface : ID2D1RenderTarget.Interface
    {
        [VtblIndex(57)]
        HRESULT GetBitmap(ID2D1Bitmap* bitmap);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName(
            "void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Factory*, void> GetFactory;

        [NativeTypeName(
            "HRESULT (D2D1_SIZE_U, const void *, UINT32, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_SIZE_U,
            void*,
            uint,
            D2D1_BITMAP_PROPERTIES*,
            ID2D1Bitmap*,
            int> CreateBitmap1;

        [NativeTypeName(
            "HRESULT (IWICBitmapSource *, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICBitmapSource,
            D2D1_BITMAP_PROPERTIES*,
            ID2D1Bitmap*,
            int> CreateBitmapFromWicBitmap1;

        [NativeTypeName(
            "HRESULT (const IID &, void *, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            void*,
            D2D1_BITMAP_PROPERTIES*,
            ID2D1Bitmap*,
            int> CreateSharedBitmap;

        [NativeTypeName(
            "HRESULT (ID2D1Bitmap *, const D2D1_BITMAP_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1BitmapBrush **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Bitmap,
            D2D1_BITMAP_BRUSH_PROPERTIES*,
            D2D1_BRUSH_PROPERTIES*,
            ID2D1BitmapBrush*,
            int> CreateBitmapBrush2;

        [NativeTypeName(
            "HRESULT (const D2D1_COLOR_F *, const D2D1_BRUSH_PROPERTIES *, ID2D1SolidColorBrush **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXGI_RGBA*,
            D2D1_BRUSH_PROPERTIES*,
            ID2D1SolidColorBrush*,
            int> CreateSolidColorBrush1;

        [NativeTypeName(
            "HRESULT (const D2D1_GRADIENT_STOP *, UINT32, D2D1_GAMMA, D2D1_EXTEND_MODE, ID2D1GradientStopCollection **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_GRADIENT_STOP*,
            uint,
            D2D1_GAMMA,
            D2D1_EXTEND_MODE,
            ID2D1GradientStopCollection*,
            int> CreateGradientStopCollection1;

        [NativeTypeName(
            "HRESULT (const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1GradientStopCollection *, ID2D1LinearGradientBrush **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES*,
            D2D1_BRUSH_PROPERTIES*,
            ID2D1GradientStopCollection,
            ID2D1LinearGradientBrush*,
            int> CreateLinearGradientBrush1;

        [NativeTypeName(
            "HRESULT (const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1GradientStopCollection *, ID2D1RadialGradientBrush **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*,
            D2D1_BRUSH_PROPERTIES*,
            ID2D1GradientStopCollection,
            ID2D1RadialGradientBrush*,
            int> CreateRadialGradientBrush1;

        [NativeTypeName(
            "HRESULT (const D2D1_SIZE_F *, const D2D1_SIZE_U *, const D2D1_PIXEL_FORMAT *, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, ID2D1BitmapRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_SIZE_F*,
            D2D_SIZE_U*,
            D2D1_PIXEL_FORMAT*,
            D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS,
            ID2D1BitmapRenderTarget*,
            int> CreateCompatibleRenderTarget5;

        [NativeTypeName(
            "HRESULT (const D2D1_SIZE_F *, ID2D1Layer **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_SIZE_F*, ID2D1Layer*, int> CreateLayer2;

        [NativeTypeName("HRESULT (ID2D1Mesh **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Mesh*, int> CreateMesh;

        [NativeTypeName(
            "void (D2D1_POINT_2F, D2D1_POINT_2F, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F,
            D2D_POINT_2F,
            ID2D1Brush,
            float,
            ID2D1StrokeStyle,
            void> DrawLine;

        [NativeTypeName(
            "void (const D2D1_RECT_F *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_RECT_F*,
            ID2D1Brush,
            float,
            ID2D1StrokeStyle,
            void> DrawRectangle;

        [NativeTypeName(
            "void (const D2D1_RECT_F *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, ID2D1Brush, void> FillRectangle;

        [NativeTypeName(
            "void (const D2D1_ROUNDED_RECT *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_ROUNDED_RECT*,
            ID2D1Brush,
            float,
            ID2D1StrokeStyle,
            void> DrawRoundedRectangle;

        [NativeTypeName(
            "void (const D2D1_ROUNDED_RECT *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_ROUNDED_RECT*,
            ID2D1Brush,
            void> FillRoundedRectangle;

        [NativeTypeName(
            "void (const D2D1_ELLIPSE *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_ELLIPSE*,
            ID2D1Brush,
            float,
            ID2D1StrokeStyle,
            void> DrawEllipse;

        [NativeTypeName(
            "void (const D2D1_ELLIPSE *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_ELLIPSE*, ID2D1Brush, void> FillEllipse;

        [NativeTypeName(
            "void (ID2D1Geometry *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Geometry,
            ID2D1Brush,
            float,
            ID2D1StrokeStyle,
            void> DrawGeometry;

        [NativeTypeName(
            "void (ID2D1Geometry *, ID2D1Brush *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Geometry,
            ID2D1Brush,
            ID2D1Brush,
            void> FillGeometry;

        [NativeTypeName(
            "void (ID2D1Mesh *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Mesh, ID2D1Brush, void> FillMesh;

        [NativeTypeName(
            "void (ID2D1Bitmap *, ID2D1Brush *, D2D1_OPACITY_MASK_CONTENT, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Bitmap,
            ID2D1Brush,
            D2D1_OPACITY_MASK_CONTENT,
            D2D_RECT_F*,
            D2D_RECT_F*,
            void> FillOpacityMask;

        [NativeTypeName(
            "void (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_BITMAP_INTERPOLATION_MODE, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Bitmap,
            D2D_RECT_F*,
            float,
            D2D1_BITMAP_INTERPOLATION_MODE,
            D2D_RECT_F*,
            void> DrawBitmap;

        [NativeTypeName(
            "void (const WCHAR *, UINT32, IDWriteTextFormat *, const D2D1_RECT_F *, ID2D1Brush *, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IDWriteTextFormat,
            D2D_RECT_F*,
            ID2D1Brush,
            D2D1_DRAW_TEXT_OPTIONS,
            DWRITE_MEASURING_MODE,
            void> DrawText;

        [NativeTypeName(
            "void (D2D1_POINT_2F, IDWriteTextLayout *, ID2D1Brush *, D2D1_DRAW_TEXT_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F,
            IDWriteTextLayout,
            ID2D1Brush,
            D2D1_DRAW_TEXT_OPTIONS,
            void> DrawTextLayout;

        [NativeTypeName(
            "void (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F,
            DWRITE_GLYPH_RUN*,
            ID2D1Brush,
            DWRITE_MEASURING_MODE,
            void> DrawGlyphRun;

        [NativeTypeName(
            "void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> SetTransform;

        [NativeTypeName(
            "void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, void> GetTransform;

        [NativeTypeName(
            "void (D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_ANTIALIAS_MODE, void> SetAntialiasMode;

        [NativeTypeName(
            "D2D1_ANTIALIAS_MODE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_ANTIALIAS_MODE> GetAntialiasMode;

        [NativeTypeName(
            "void (D2D1_TEXT_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_TEXT_ANTIALIAS_MODE, void> SetTextAntialiasMode;

        [NativeTypeName(
            "D2D1_TEXT_ANTIALIAS_MODE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_TEXT_ANTIALIAS_MODE> GetTextAntialiasMode;

        [NativeTypeName(
            "void (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteRenderingParams, void> SetTextRenderingParams;

        [NativeTypeName(
            "void (IDWriteRenderingParams **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteRenderingParams*, void> GetTextRenderingParams;

        [NativeTypeName(
            "void (D2D1_TAG, D2D1_TAG) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong, ulong, void> SetTags;

        [NativeTypeName(
            "void (D2D1_TAG *, D2D1_TAG *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong*, ulong*, void> GetTags;

        [NativeTypeName(
            "void (const D2D1_LAYER_PARAMETERS *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_LAYER_PARAMETERS*, ID2D1Layer, void> PushLayer;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> PopLayer;

        [NativeTypeName(
            "HRESULT (D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong*, ulong*, int> Flush;

        [NativeTypeName(
            "void (ID2D1DrawingStateBlock *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1DrawingStateBlock, void> SaveDrawingState;

        [NativeTypeName(
            "void (ID2D1DrawingStateBlock *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1DrawingStateBlock, void> RestoreDrawingState;

        [NativeTypeName(
            "void (const D2D1_RECT_F *, D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_RECT_F*,
            D2D1_ANTIALIAS_MODE,
            void> PushAxisAlignedClip;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> PopAxisAlignedClip;

        [NativeTypeName(
            "void (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, void> Clear;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> BeginDraw;

        [NativeTypeName(
            "HRESULT (D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong*, ulong*, int> EndDraw;

        [NativeTypeName(
            "D2D1_PIXEL_FORMAT () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*> GetPixelFormat;

        [NativeTypeName("void (FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, void> SetDpi;

        [NativeTypeName(
            "void (FLOAT *, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float*, float*, void> GetDpi;

        [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_SIZE_F*, D2D_SIZE_F*> GetSize;

        [NativeTypeName("D2D1_SIZE_U () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_SIZE_U*, D2D_SIZE_U*> GetPixelSize;

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetMaximumBitmapSize;

        [NativeTypeName(
            "BOOL (const D2D1_RENDER_TARGET_PROPERTIES *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_RENDER_TARGET_PROPERTIES*, int> IsSupported;

        [NativeTypeName(
            "HRESULT (ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Bitmap*, int> GetBitmap;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1BitmapRenderTarget"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1BitmapRenderTarget(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1RenderTarget"/> to <see cref = "ID2D1BitmapRenderTarget"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1RenderTarget"/> instance to be converted </param>
    public static explicit operator ID2D1BitmapRenderTarget(
        Silk.NET.DirectX.ID2D1RenderTarget value
    )
    {
        return new ID2D1BitmapRenderTarget(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1BitmapRenderTarget"/> to <see cref = "Silk.NET.DirectX.ID2D1RenderTarget"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1BitmapRenderTarget"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1RenderTarget(
        ID2D1BitmapRenderTarget value
    )
    {
        return new Silk.NET.DirectX.ID2D1RenderTarget(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1BitmapRenderTarget"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1BitmapRenderTarget(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1BitmapRenderTarget(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1BitmapRenderTarget"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1BitmapRenderTarget"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1BitmapRenderTarget value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1BitmapRenderTarget"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1BitmapRenderTarget(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1BitmapRenderTarget(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1BitmapRenderTarget"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1BitmapRenderTarget"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1BitmapRenderTarget value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
