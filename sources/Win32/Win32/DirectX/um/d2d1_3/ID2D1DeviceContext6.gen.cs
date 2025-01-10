// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.DirectX.D2D1_ALPHA_MODE;
using static Silk.NET.DirectX.D2D1_BITMAP_INTERPOLATION_MODE;
using static Silk.NET.DirectX.D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION;
using static Silk.NET.DirectX.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS;
using static Silk.NET.DirectX.D2D1_COMPOSITE_MODE;
using static Silk.NET.DirectX.D2D1_DRAW_TEXT_OPTIONS;
using static Silk.NET.DirectX.D2D1_EXTEND_MODE;
using static Silk.NET.DirectX.D2D1_GAMMA;
using static Silk.NET.DirectX.D2D1_IMAGE_SOURCE_LOADING_OPTIONS;
using static Silk.NET.DirectX.D2D1_INTERPOLATION_MODE;
using static Silk.NET.DirectX.D2D1_SPRITE_OPTIONS;
using static Silk.NET.DirectX.DWRITE_MEASURING_MODE;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("985F7E37-4ED0-4A19-98A3-15B0EDFDE306")]
[NativeTypeName("struct ID2D1DeviceContext6 : ID2D1DeviceContext5")]
[NativeInheritance("ID2D1DeviceContext5")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID2D1DeviceContext6 : ID2D1DeviceContext6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1DeviceContext6));
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

    public HRESULT CreateBitmapFromWicBitmap(IWICBitmapSource wicBitmapSource, ID2D1Bitmap1* bitmap)
    {
        return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
    }

    public HRESULT CreateImageBrush(
        ID2D1Image image,
        [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES &")]
            D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties,
        ID2D1ImageBrush* imageBrush
    )
    {
        return CreateImageBrush(image, imageBrushProperties, null, imageBrush);
    }

    public HRESULT CreateBitmapBrush(ID2D1Bitmap bitmap, ID2D1BitmapBrush1* bitmapBrush)
    {
        return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
    }

    public HRESULT CreateBitmapBrush(
        ID2D1Bitmap bitmap,
        [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 &")]
            D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties,
        ID2D1BitmapBrush1* bitmapBrush
    )
    {
        return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
    }

    public void DrawImage(
        ID2D1Effect effect,
        [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER
    )
    {
        ID2D1Image output = default;
        effect.GetOutput(&output);
        DrawImage(output, targetOffset, imageRectangle, interpolationMode, compositeMode);
        _ = output.Release();
    }

    public void DrawImage(
        ID2D1Image image,
        D2D1_INTERPOLATION_MODE interpolationMode,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER
    )
    {
        DrawImage(image, null, null, interpolationMode, compositeMode);
    }

    public void DrawImage(
        ID2D1Effect effect,
        D2D1_INTERPOLATION_MODE interpolationMode,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER
    )
    {
        DrawImage(effect, null, null, interpolationMode, compositeMode);
    }

    public void DrawImage(
        ID2D1Image image,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER
    )
    {
        DrawImage(image, &targetOffset, null, interpolationMode, compositeMode);
    }

    public void DrawImage(
        ID2D1Effect effect,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER
    )
    {
        DrawImage(effect, &targetOffset, null, interpolationMode, compositeMode);
    }

    public void DrawImage(
        ID2D1Image image,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset,
        [NativeTypeName("const D2D1_RECT_F &")] D2D_RECT_F* imageRectangle,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER
    )
    {
        DrawImage(image, &targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    public void DrawImage(
        ID2D1Effect effect,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset,
        [NativeTypeName("const D2D1_RECT_F &")] D2D_RECT_F* imageRectangle,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER
    )
    {
        DrawImage(effect, &targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    public void DrawGdiMetafile(
        ID2D1GdiMetafile gdiMetafile,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset
    )
    {
        DrawGdiMetafile(gdiMetafile, &targetOffset);
    }

    public HRESULT CreateImageSourceFromWic(
        IWICBitmapSource wicBitmapSource,
        D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions,
        ID2D1ImageSourceFromWic* imageSource
    )
    {
        return CreateImageSourceFromWic(
            wicBitmapSource,
            loadingOptions,
            D2D1_ALPHA_MODE_UNKNOWN,
            imageSource
        );
    }

    public HRESULT CreateImageSourceFromWic(
        IWICBitmapSource wicBitmapSource,
        ID2D1ImageSourceFromWic* imageSource
    )
    {
        return CreateImageSourceFromWic(
            wicBitmapSource,
            D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE,
            D2D1_ALPHA_MODE_UNKNOWN,
            imageSource
        );
    }

    public void DrawSpriteBatch(
        ID2D1SpriteBatch spriteBatch,
        ID2D1Bitmap bitmap,
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR,
        D2D1_SPRITE_OPTIONS spriteOptions = D2D1_SPRITE_OPTIONS_NONE
    )
    {
        DrawSpriteBatch(
            spriteBatch,
            0,
            spriteBatch.GetSpriteCount(),
            bitmap,
            interpolationMode,
            spriteOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1DeviceContext6, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1Factory*, void>)((*lpVtbl)[3]))(
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
            (delegate* unmanaged<ID2D1DeviceContext6, D2D_SIZE_F*, ID2D1Layer*, int>)((*lpVtbl)[13])
        )(this, size, layer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateMesh(ID2D1Mesh* mesh)
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1Mesh*, int>)((*lpVtbl)[14]))(
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
        ((delegate* unmanaged<ID2D1DeviceContext6, D2D_RECT_F*, ID2D1Brush, void>)((*lpVtbl)[17]))(
            this,
            rect,
            brush
        );
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
                ID2D1DeviceContext6,
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
            (delegate* unmanaged<ID2D1DeviceContext6, D2D1_ROUNDED_RECT*, ID2D1Brush, void>)(
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
                ID2D1DeviceContext6,
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
            (delegate* unmanaged<ID2D1DeviceContext6, D2D1_ELLIPSE*, ID2D1Brush, void>)(
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
                ID2D1DeviceContext6,
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
            (delegate* unmanaged<ID2D1DeviceContext6, ID2D1Geometry, ID2D1Brush, ID2D1Brush, void>)(
                (*lpVtbl)[23]
            )
        )(this, geometry, brush, opacityBrush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void FillMesh(ID2D1Mesh mesh, ID2D1Brush brush)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1Mesh, ID2D1Brush, void>)((*lpVtbl)[24]))(
            this,
            mesh,
            brush
        );
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
                ID2D1DeviceContext6,
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
        ((delegate* unmanaged<ID2D1DeviceContext6, D2D_MATRIX_3X2_F*, void>)((*lpVtbl)[30]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, D2D_MATRIX_3X2_F*, void>)((*lpVtbl)[31]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, D2D1_ANTIALIAS_MODE, void>)((*lpVtbl)[32]))(
            this,
            antialiasMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public D2D1_ANTIALIAS_MODE GetAntialiasMode()
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, D2D1_ANTIALIAS_MODE>)((*lpVtbl)[33]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, D2D1_TEXT_ANTIALIAS_MODE, void>)((*lpVtbl)[34]))(
            this,
            textAntialiasMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, D2D1_TEXT_ANTIALIAS_MODE>)((*lpVtbl)[35])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void SetTextRenderingParams(IDWriteRenderingParams textRenderingParams = default)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, IDWriteRenderingParams, void>)((*lpVtbl)[36]))(
            this,
            textRenderingParams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public void GetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, IDWriteRenderingParams*, void>)((*lpVtbl)[37]))(
            this,
            textRenderingParams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void SetTags(
        [NativeTypeName("D2D1_TAG")] ulong tag1,
        [NativeTypeName("D2D1_TAG")] ulong tag2
    )
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, ulong, ulong, void>)((*lpVtbl)[38]))(
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
        ((delegate* unmanaged<ID2D1DeviceContext6, ulong*, ulong*, void>)((*lpVtbl)[39]))(
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
            (delegate* unmanaged<ID2D1DeviceContext6, D2D1_LAYER_PARAMETERS*, ID2D1Layer, void>)(
                (*lpVtbl)[40]
            )
        )(this, layerParameters, layer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public void PopLayer()
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, void>)((*lpVtbl)[41]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT Flush(
        [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null,
        [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null
    )
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, ulong*, ulong*, int>)((*lpVtbl)[42]))(
            this,
            tag1,
            tag2
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public void SaveDrawingState(ID2D1DrawingStateBlock drawingStateBlock)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1DrawingStateBlock, void>)((*lpVtbl)[43]))(
            this,
            drawingStateBlock
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public void RestoreDrawingState(ID2D1DrawingStateBlock drawingStateBlock)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1DrawingStateBlock, void>)((*lpVtbl)[44]))(
            this,
            drawingStateBlock
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public void PushAxisAlignedClip(
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect,
        D2D1_ANTIALIAS_MODE antialiasMode
    )
    {
        (
            (delegate* unmanaged<ID2D1DeviceContext6, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, void>)(
                (*lpVtbl)[45]
            )
        )(this, clipRect, antialiasMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public void PopAxisAlignedClip()
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, void>)((*lpVtbl)[46]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public void Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* clearColor = null)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, DXGI_RGBA*, void>)((*lpVtbl)[47]))(
            this,
            clearColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public void BeginDraw()
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, void>)((*lpVtbl)[48]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT EndDraw(
        [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null,
        [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null
    )
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, ulong*, ulong*, int>)((*lpVtbl)[49]))(
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
            (delegate* unmanaged<ID2D1DeviceContext6, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*>)(
                (*lpVtbl)[50]
            )
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public void SetDpi(float dpiX, float dpiY)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, float, float, void>)((*lpVtbl)[51]))(
            this,
            dpiX,
            dpiY
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public void GetDpi(float* dpiX, float* dpiY)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, float*, float*, void>)((*lpVtbl)[52]))(
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
            (delegate* unmanaged<ID2D1DeviceContext6, D2D_SIZE_F*, D2D_SIZE_F*>)((*lpVtbl)[53])
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    [return: NativeTypeName("D2D1_SIZE_U")]
    public D2D_SIZE_U GetPixelSize()
    {
        D2D_SIZE_U result;
        return *(
            (delegate* unmanaged<ID2D1DeviceContext6, D2D_SIZE_U*, D2D_SIZE_U*>)((*lpVtbl)[54])
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    [return: NativeTypeName("UINT32")]
    public uint GetMaximumBitmapSize()
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, uint>)((*lpVtbl)[55]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public BOOL IsSupported(
        [NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")]
            D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties
    )
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, D2D1_RENDER_TARGET_PROPERTIES*, int>)(
                (*lpVtbl)[56]
            )
        )(this, renderTargetProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT CreateBitmap(
        [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size,
        [NativeTypeName("const void *")] void* sourceData,
        [NativeTypeName("UINT32")] uint pitch,
        [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")]
            D2D1_BITMAP_PROPERTIES1* bitmapProperties,
        ID2D1Bitmap1* bitmap
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D_SIZE_U,
                void*,
                uint,
                D2D1_BITMAP_PROPERTIES1*,
                ID2D1Bitmap1*,
                int>)((*lpVtbl)[57])
        )(this, size, sourceData, pitch, bitmapProperties, bitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT CreateBitmapFromWicBitmap(
        IWICBitmapSource wicBitmapSource,
        [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")]
            D2D1_BITMAP_PROPERTIES1* bitmapProperties,
        ID2D1Bitmap1* bitmap
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                IWICBitmapSource,
                D2D1_BITMAP_PROPERTIES1*,
                ID2D1Bitmap1*,
                int>)((*lpVtbl)[58])
        )(this, wicBitmapSource, bitmapProperties, bitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT CreateColorContext(
        D2D1_COLOR_SPACE space,
        [NativeTypeName("const BYTE *")] byte* profile,
        [NativeTypeName("UINT32")] uint profileSize,
        ID2D1ColorContext* colorContext
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D1_COLOR_SPACE,
                byte*,
                uint,
                ID2D1ColorContext*,
                int>)((*lpVtbl)[59])
        )(this, space, profile, profileSize, colorContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT CreateColorContextFromFilename(
        [NativeTypeName("PCWSTR")] ushort* filename,
        ID2D1ColorContext* colorContext
    )
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, ushort*, ID2D1ColorContext*, int>)(
                (*lpVtbl)[60]
            )
        )(this, filename, colorContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT CreateColorContextFromWicColorContext(
        IWICColorContext wicColorContext,
        ID2D1ColorContext* colorContext
    )
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, IWICColorContext, ID2D1ColorContext*, int>)(
                (*lpVtbl)[61]
            )
        )(this, wicColorContext, colorContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT CreateBitmapFromDxgiSurface(
        IDXGISurface surface,
        [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")]
            D2D1_BITMAP_PROPERTIES1* bitmapProperties,
        ID2D1Bitmap1* bitmap
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                IDXGISurface,
                D2D1_BITMAP_PROPERTIES1*,
                ID2D1Bitmap1*,
                int>)((*lpVtbl)[62])
        )(this, surface, bitmapProperties, bitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT CreateEffect([NativeTypeName("const IID &")] Guid* effectId, ID2D1Effect* effect)
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, Guid*, ID2D1Effect*, int>)((*lpVtbl)[63])
        )(this, effectId, effect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT CreateGradientStopCollection(
        [NativeTypeName("const D2D1_GRADIENT_STOP *")]
            D2D1_GRADIENT_STOP* straightAlphaGradientStops,
        [NativeTypeName("UINT32")] uint straightAlphaGradientStopsCount,
        D2D1_COLOR_SPACE preInterpolationSpace,
        D2D1_COLOR_SPACE postInterpolationSpace,
        D2D1_BUFFER_PRECISION bufferPrecision,
        D2D1_EXTEND_MODE extendMode,
        D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode,
        ID2D1GradientStopCollection1* gradientStopCollection1
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D1_GRADIENT_STOP*,
                uint,
                D2D1_COLOR_SPACE,
                D2D1_COLOR_SPACE,
                D2D1_BUFFER_PRECISION,
                D2D1_EXTEND_MODE,
                D2D1_COLOR_INTERPOLATION_MODE,
                ID2D1GradientStopCollection1*,
                int>)((*lpVtbl)[64])
        )(
            this,
            straightAlphaGradientStops,
            straightAlphaGradientStopsCount,
            preInterpolationSpace,
            postInterpolationSpace,
            bufferPrecision,
            extendMode,
            colorInterpolationMode,
            gradientStopCollection1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT CreateImageBrush(
        ID2D1Image image,
        [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES *")]
            D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties,
        [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties,
        ID2D1ImageBrush* imageBrush
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1Image,
                D2D1_IMAGE_BRUSH_PROPERTIES*,
                D2D1_BRUSH_PROPERTIES*,
                ID2D1ImageBrush*,
                int>)((*lpVtbl)[65])
        )(this, image, imageBrushProperties, brushProperties, imageBrush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT CreateBitmapBrush(
        ID2D1Bitmap bitmap,
        [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 *")]
            D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties,
        [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties,
        ID2D1BitmapBrush1* bitmapBrush
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1Bitmap,
                D2D1_BITMAP_BRUSH_PROPERTIES1*,
                D2D1_BRUSH_PROPERTIES*,
                ID2D1BitmapBrush1*,
                int>)((*lpVtbl)[66])
        )(this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT CreateCommandList(ID2D1CommandList* commandList)
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1CommandList*, int>)((*lpVtbl)[67]))(
            this,
            commandList
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public BOOL IsDxgiFormatSupported(DXGI_FORMAT format)
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, DXGI_FORMAT, int>)((*lpVtbl)[68]))(
            this,
            format
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public BOOL IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision)
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, D2D1_BUFFER_PRECISION, int>)((*lpVtbl)[69])
        )(this, bufferPrecision);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT GetImageLocalBounds(
        ID2D1Image image,
        [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* localBounds
    )
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, ID2D1Image, D2D_RECT_F*, int>)((*lpVtbl)[70])
        )(this, image, localBounds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT GetImageWorldBounds(
        ID2D1Image image,
        [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* worldBounds
    )
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, ID2D1Image, D2D_RECT_F*, int>)((*lpVtbl)[71])
        )(this, image, worldBounds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT GetGlyphRunWorldBounds(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
        [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun,
        DWRITE_MEASURING_MODE measuringMode,
        [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D_POINT_2F,
                DWRITE_GLYPH_RUN*,
                DWRITE_MEASURING_MODE,
                D2D_RECT_F*,
                int>)((*lpVtbl)[72])
        )(this, baselineOrigin, glyphRun, measuringMode, bounds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public void GetDevice(ID2D1Device* device)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1Device*, void>)((*lpVtbl)[73]))(
            this,
            device
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public void SetTarget(ID2D1Image image)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1Image, void>)((*lpVtbl)[74]))(this, image);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public void GetTarget(ID2D1Image* image)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1Image*, void>)((*lpVtbl)[75]))(this, image);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public void SetRenderingControls(
        [NativeTypeName("const D2D1_RENDERING_CONTROLS *")]
            D2D1_RENDERING_CONTROLS* renderingControls
    )
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, D2D1_RENDERING_CONTROLS*, void>)((*lpVtbl)[76]))(
            this,
            renderingControls
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public void GetRenderingControls(D2D1_RENDERING_CONTROLS* renderingControls)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, D2D1_RENDERING_CONTROLS*, void>)((*lpVtbl)[77]))(
            this,
            renderingControls
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public void SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, D2D1_PRIMITIVE_BLEND, void>)((*lpVtbl)[78]))(
            this,
            primitiveBlend
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public D2D1_PRIMITIVE_BLEND GetPrimitiveBlend()
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, D2D1_PRIMITIVE_BLEND>)((*lpVtbl)[79]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public void SetUnitMode(D2D1_UNIT_MODE unitMode)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, D2D1_UNIT_MODE, void>)((*lpVtbl)[80]))(
            this,
            unitMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public D2D1_UNIT_MODE GetUnitMode()
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, D2D1_UNIT_MODE>)((*lpVtbl)[81]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public void DrawGlyphRun(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
        [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun,
        [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")]
            DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription,
        ID2D1Brush foregroundBrush,
        DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D_POINT_2F,
                DWRITE_GLYPH_RUN*,
                DWRITE_GLYPH_RUN_DESCRIPTION*,
                ID2D1Brush,
                DWRITE_MEASURING_MODE,
                void>)((*lpVtbl)[82])
        )(this, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public void DrawImage(
        ID2D1Image image,
        [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR,
        D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1Image,
                D2D_POINT_2F*,
                D2D_RECT_F*,
                D2D1_INTERPOLATION_MODE,
                D2D1_COMPOSITE_MODE,
                void>)((*lpVtbl)[83])
        )(this, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public void DrawGdiMetafile(
        ID2D1GdiMetafile gdiMetafile,
        [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null
    )
    {
        (
            (delegate* unmanaged<ID2D1DeviceContext6, ID2D1GdiMetafile, D2D_POINT_2F*, void>)(
                (*lpVtbl)[84]
            )
        )(this, gdiMetafile, targetOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public void DrawBitmap(
        ID2D1Bitmap bitmap,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle,
        float opacity,
        D2D1_INTERPOLATION_MODE interpolationMode,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null,
        [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform = null
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1Bitmap,
                D2D_RECT_F*,
                float,
                D2D1_INTERPOLATION_MODE,
                D2D_RECT_F*,
                D2D_MATRIX_4X4_F*,
                void>)((*lpVtbl)[85])
        )(
            this,
            bitmap,
            destinationRectangle,
            opacity,
            interpolationMode,
            sourceRectangle,
            perspectiveTransform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public void PushLayer(
        [NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters,
        ID2D1Layer layer
    )
    {
        (
            (delegate* unmanaged<ID2D1DeviceContext6, D2D1_LAYER_PARAMETERS1*, ID2D1Layer, void>)(
                (*lpVtbl)[86]
            )
        )(this, layerParameters, layer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT InvalidateEffectInputRectangle(
        ID2D1Effect effect,
        [NativeTypeName("UINT32")] uint input,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* inputRectangle
    )
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, ID2D1Effect, uint, D2D_RECT_F*, int>)(
                (*lpVtbl)[87]
            )
        )(this, effect, input, inputRectangle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT GetEffectInvalidRectangleCount(
        ID2D1Effect effect,
        [NativeTypeName("UINT32 *")] uint* rectangleCount
    )
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1Effect, uint*, int>)((*lpVtbl)[88]))(
            this,
            effect,
            rectangleCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT GetEffectInvalidRectangles(
        ID2D1Effect effect,
        [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* rectangles,
        [NativeTypeName("UINT32")] uint rectanglesCount
    )
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, ID2D1Effect, D2D_RECT_F*, uint, int>)(
                (*lpVtbl)[89]
            )
        )(this, effect, rectangles, rectanglesCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT GetEffectRequiredInputRectangles(
        ID2D1Effect renderEffect,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* renderImageRectangle,
        [NativeTypeName("const D2D1_EFFECT_INPUT_DESCRIPTION *")]
            D2D1_EFFECT_INPUT_DESCRIPTION* inputDescriptions,
        [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* requiredInputRects,
        [NativeTypeName("UINT32")] uint inputCount
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1Effect,
                D2D_RECT_F*,
                D2D1_EFFECT_INPUT_DESCRIPTION*,
                D2D_RECT_F*,
                uint,
                int>)((*lpVtbl)[90])
        )(
            this,
            renderEffect,
            renderImageRectangle,
            inputDescriptions,
            requiredInputRects,
            inputCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public void FillOpacityMask(
        ID2D1Bitmap opacityMask,
        ID2D1Brush brush,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1Bitmap,
                ID2D1Brush,
                D2D_RECT_F*,
                D2D_RECT_F*,
                void>)((*lpVtbl)[91])
        )(this, opacityMask, brush, destinationRectangle, sourceRectangle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT CreateFilledGeometryRealization(
        ID2D1Geometry geometry,
        float flatteningTolerance,
        ID2D1GeometryRealization* geometryRealization
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1Geometry,
                float,
                ID2D1GeometryRealization*,
                int>)((*lpVtbl)[92])
        )(this, geometry, flatteningTolerance, geometryRealization);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT CreateStrokedGeometryRealization(
        ID2D1Geometry geometry,
        float flatteningTolerance,
        float strokeWidth,
        ID2D1StrokeStyle strokeStyle,
        ID2D1GeometryRealization* geometryRealization
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1Geometry,
                float,
                float,
                ID2D1StrokeStyle,
                ID2D1GeometryRealization*,
                int>)((*lpVtbl)[93])
        )(this, geometry, flatteningTolerance, strokeWidth, strokeStyle, geometryRealization);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public void DrawGeometryRealization(
        ID2D1GeometryRealization geometryRealization,
        ID2D1Brush brush
    )
    {
        (
            (delegate* unmanaged<ID2D1DeviceContext6, ID2D1GeometryRealization, ID2D1Brush, void>)(
                (*lpVtbl)[94]
            )
        )(this, geometryRealization, brush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT CreateInk(
        [NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint,
        ID2D1Ink* ink
    )
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, D2D1_INK_POINT*, ID2D1Ink*, int>)(
                (*lpVtbl)[95]
            )
        )(this, startPoint, ink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT CreateInkStyle(
        [NativeTypeName("const D2D1_INK_STYLE_PROPERTIES *")]
            D2D1_INK_STYLE_PROPERTIES* inkStyleProperties,
        ID2D1InkStyle* inkStyle
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D1_INK_STYLE_PROPERTIES*,
                ID2D1InkStyle*,
                int>)((*lpVtbl)[96])
        )(this, inkStyleProperties, inkStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT CreateGradientMesh(
        [NativeTypeName("const D2D1_GRADIENT_MESH_PATCH *")] D2D1_GRADIENT_MESH_PATCH* patches,
        [NativeTypeName("UINT32")] uint patchesCount,
        ID2D1GradientMesh* gradientMesh
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D1_GRADIENT_MESH_PATCH*,
                uint,
                ID2D1GradientMesh*,
                int>)((*lpVtbl)[97])
        )(this, patches, patchesCount, gradientMesh);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT CreateImageSourceFromWic(
        IWICBitmapSource wicBitmapSource,
        D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions,
        D2D1_ALPHA_MODE alphaMode,
        ID2D1ImageSourceFromWic* imageSource
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                IWICBitmapSource,
                D2D1_IMAGE_SOURCE_LOADING_OPTIONS,
                D2D1_ALPHA_MODE,
                ID2D1ImageSourceFromWic*,
                int>)((*lpVtbl)[98])
        )(this, wicBitmapSource, loadingOptions, alphaMode, imageSource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT CreateLookupTable3D(
        D2D1_BUFFER_PRECISION precision,
        [NativeTypeName("const UINT32 *")] uint* extents,
        [NativeTypeName("const BYTE *")] byte* data,
        [NativeTypeName("UINT32")] uint dataCount,
        [NativeTypeName("const UINT32 *")] uint* strides,
        ID2D1LookupTable3D* lookupTable
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D1_BUFFER_PRECISION,
                uint*,
                byte*,
                uint,
                uint*,
                ID2D1LookupTable3D*,
                int>)((*lpVtbl)[99])
        )(this, precision, extents, data, dataCount, strides, lookupTable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT CreateImageSourceFromDxgi(
        IDXGISurface* surfaces,
        [NativeTypeName("UINT32")] uint surfaceCount,
        DXGI_COLOR_SPACE_TYPE colorSpace,
        D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options,
        ID2D1ImageSource* imageSource
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                IDXGISurface*,
                uint,
                DXGI_COLOR_SPACE_TYPE,
                D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS,
                ID2D1ImageSource*,
                int>)((*lpVtbl)[100])
        )(this, surfaces, surfaceCount, colorSpace, options, imageSource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT GetGradientMeshWorldBounds(
        ID2D1GradientMesh gradientMesh,
        [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* pBounds
    )
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, ID2D1GradientMesh, D2D_RECT_F*, int>)(
                (*lpVtbl)[101]
            )
        )(this, gradientMesh, pBounds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public void DrawInk(ID2D1Ink ink, ID2D1Brush brush, ID2D1InkStyle inkStyle)
    {
        (
            (delegate* unmanaged<ID2D1DeviceContext6, ID2D1Ink, ID2D1Brush, ID2D1InkStyle, void>)(
                (*lpVtbl)[102]
            )
        )(this, ink, brush, inkStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public void DrawGradientMesh(ID2D1GradientMesh gradientMesh)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1GradientMesh, void>)((*lpVtbl)[103]))(
            this,
            gradientMesh
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public void DrawGdiMetafile(
        ID2D1GdiMetafile gdiMetafile,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1GdiMetafile,
                D2D_RECT_F*,
                D2D_RECT_F*,
                void>)((*lpVtbl)[104])
        )(this, gdiMetafile, destinationRectangle, sourceRectangle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT CreateTransformedImageSource(
        ID2D1ImageSource imageSource,
        [NativeTypeName("const D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *")]
            D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties,
        ID2D1TransformedImageSource* transformedImageSource
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1ImageSource,
                D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*,
                ID2D1TransformedImageSource*,
                int>)((*lpVtbl)[105])
        )(this, imageSource, properties, transformedImageSource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT CreateSpriteBatch(ID2D1SpriteBatch* spriteBatch)
    {
        return ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1SpriteBatch*, int>)((*lpVtbl)[106]))(
            this,
            spriteBatch
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public void DrawSpriteBatch(
        ID2D1SpriteBatch spriteBatch,
        [NativeTypeName("UINT32")] uint startIndex,
        [NativeTypeName("UINT32")] uint spriteCount,
        ID2D1Bitmap bitmap,
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR,
        D2D1_SPRITE_OPTIONS spriteOptions = D2D1_SPRITE_OPTIONS_NONE
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1SpriteBatch,
                uint,
                uint,
                ID2D1Bitmap,
                D2D1_BITMAP_INTERPOLATION_MODE,
                D2D1_SPRITE_OPTIONS,
                void>)((*lpVtbl)[107])
        )(this, spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT CreateSvgGlyphStyle(ID2D1SvgGlyphStyle* svgGlyphStyle)
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, ID2D1SvgGlyphStyle*, int>)((*lpVtbl)[108])
        )(this, svgGlyphStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public void DrawText(
        [NativeTypeName("const WCHAR *")] ushort* @string,
        [NativeTypeName("UINT32")] uint stringLength,
        IDWriteTextFormat textFormat,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect,
        ID2D1Brush defaultFillBrush,
        ID2D1SvgGlyphStyle svgGlyphStyle,
        [NativeTypeName("UINT32")] uint colorPaletteIndex = 0,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT,
        DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ushort*,
                uint,
                IDWriteTextFormat,
                D2D_RECT_F*,
                ID2D1Brush,
                ID2D1SvgGlyphStyle,
                uint,
                D2D1_DRAW_TEXT_OPTIONS,
                DWRITE_MEASURING_MODE,
                void>)((*lpVtbl)[109])
        )(
            this,
            @string,
            stringLength,
            textFormat,
            layoutRect,
            defaultFillBrush,
            svgGlyphStyle,
            colorPaletteIndex,
            options,
            measuringMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public void DrawTextLayout(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin,
        IDWriteTextLayout textLayout,
        ID2D1Brush defaultFillBrush,
        ID2D1SvgGlyphStyle svgGlyphStyle,
        [NativeTypeName("UINT32")] uint colorPaletteIndex = 0,
        D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D_POINT_2F,
                IDWriteTextLayout,
                ID2D1Brush,
                ID2D1SvgGlyphStyle,
                uint,
                D2D1_DRAW_TEXT_OPTIONS,
                void>)((*lpVtbl)[110])
        )(this, origin, textLayout, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public void DrawColorBitmapGlyphRun(
        DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
        [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun,
        DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL,
        D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION bitmapSnapOption =
            D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                DWRITE_GLYPH_IMAGE_FORMATS,
                D2D_POINT_2F,
                DWRITE_GLYPH_RUN*,
                DWRITE_MEASURING_MODE,
                D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION,
                void>)((*lpVtbl)[111])
        )(this, glyphImageFormat, baselineOrigin, glyphRun, measuringMode, bitmapSnapOption);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public void DrawSvgGlyphRun(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
        [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun,
        ID2D1Brush defaultFillBrush = default,
        ID2D1SvgGlyphStyle svgGlyphStyle = default,
        [NativeTypeName("UINT32")] uint colorPaletteIndex = 0,
        DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D_POINT_2F,
                DWRITE_GLYPH_RUN*,
                ID2D1Brush,
                ID2D1SvgGlyphStyle,
                uint,
                DWRITE_MEASURING_MODE,
                void>)((*lpVtbl)[112])
        )(
            this,
            baselineOrigin,
            glyphRun,
            defaultFillBrush,
            svgGlyphStyle,
            colorPaletteIndex,
            measuringMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT GetColorBitmapGlyphImage(
        DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F glyphOrigin,
        IDWriteFontFace fontFace,
        float fontEmSize,
        [NativeTypeName("UINT16")] ushort glyphIndex,
        BOOL isSideways,
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform,
        float dpiX,
        float dpiY,
        [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* glyphTransform,
        ID2D1Image* glyphImage
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                DWRITE_GLYPH_IMAGE_FORMATS,
                D2D_POINT_2F,
                IDWriteFontFace,
                float,
                ushort,
                BOOL,
                D2D_MATRIX_3X2_F*,
                float,
                float,
                D2D_MATRIX_3X2_F*,
                ID2D1Image*,
                int>)((*lpVtbl)[113])
        )(
            this,
            glyphImageFormat,
            glyphOrigin,
            fontFace,
            fontEmSize,
            glyphIndex,
            isSideways,
            worldTransform,
            dpiX,
            dpiY,
            glyphTransform,
            glyphImage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT GetSvgGlyphImage(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F glyphOrigin,
        IDWriteFontFace fontFace,
        float fontEmSize,
        [NativeTypeName("UINT16")] ushort glyphIndex,
        BOOL isSideways,
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* worldTransform,
        ID2D1Brush defaultFillBrush,
        ID2D1SvgGlyphStyle svgGlyphStyle,
        [NativeTypeName("UINT32")] uint colorPaletteIndex,
        [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* glyphTransform,
        ID2D1CommandList* glyphImage
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D_POINT_2F,
                IDWriteFontFace,
                float,
                ushort,
                BOOL,
                D2D_MATRIX_3X2_F*,
                ID2D1Brush,
                ID2D1SvgGlyphStyle,
                uint,
                D2D_MATRIX_3X2_F*,
                ID2D1CommandList*,
                int>)((*lpVtbl)[114])
        )(
            this,
            glyphOrigin,
            fontFace,
            fontEmSize,
            glyphIndex,
            isSideways,
            worldTransform,
            defaultFillBrush,
            svgGlyphStyle,
            colorPaletteIndex,
            glyphTransform,
            glyphImage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT CreateSvgDocument(
        IStream inputXmlStream,
        [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize,
        ID2D1SvgDocument* svgDocument
    )
    {
        return (
            (delegate* unmanaged<ID2D1DeviceContext6, IStream, D2D_SIZE_F, ID2D1SvgDocument*, int>)(
                (*lpVtbl)[115]
            )
        )(this, inputXmlStream, viewportSize, svgDocument);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public void DrawSvgDocument(ID2D1SvgDocument svgDocument)
    {
        ((delegate* unmanaged<ID2D1DeviceContext6, ID2D1SvgDocument, void>)((*lpVtbl)[116]))(
            this,
            svgDocument
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT CreateColorContextFromDxgiColorSpace(
        DXGI_COLOR_SPACE_TYPE colorSpace,
        ID2D1ColorContext1* colorContext
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                DXGI_COLOR_SPACE_TYPE,
                ID2D1ColorContext1*,
                int>)((*lpVtbl)[117])
        )(this, colorSpace, colorContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT CreateColorContextFromSimpleColorProfile(
        [NativeTypeName("const D2D1_SIMPLE_COLOR_PROFILE *")]
            D2D1_SIMPLE_COLOR_PROFILE* simpleProfile,
        ID2D1ColorContext1* colorContext
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                D2D1_SIMPLE_COLOR_PROFILE*,
                ID2D1ColorContext1*,
                int>)((*lpVtbl)[118])
        )(this, simpleProfile, colorContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public void BlendImage(
        ID2D1Image image,
        D2D1_BLEND_MODE blendMode,
        [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null,
        D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR
    )
    {
        (
            (delegate* unmanaged<
                ID2D1DeviceContext6,
                ID2D1Image,
                D2D1_BLEND_MODE,
                D2D_POINT_2F*,
                D2D_RECT_F*,
                D2D1_INTERPOLATION_MODE,
                void>)((*lpVtbl)[119])
        )(this, image, blendMode, targetOffset, imageRectangle, interpolationMode);
    }

    public interface Interface : ID2D1DeviceContext5.Interface
    {
        [VtblIndex(119)]
        void BlendImage(
            ID2D1Image image,
            D2D1_BLEND_MODE blendMode,
            [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null,
            [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null,
            D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR
        );
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
            "HRESULT (D2D1_SIZE_U, const void *, UINT32, const D2D1_BITMAP_PROPERTIES1 *, ID2D1Bitmap1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_SIZE_U,
            void*,
            uint,
            D2D1_BITMAP_PROPERTIES1*,
            ID2D1Bitmap1*,
            int> CreateBitmap2;

        [NativeTypeName(
            "HRESULT (IWICBitmapSource *, const D2D1_BITMAP_PROPERTIES1 *, ID2D1Bitmap1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICBitmapSource,
            D2D1_BITMAP_PROPERTIES1*,
            ID2D1Bitmap1*,
            int> CreateBitmapFromWicBitmap3;

        [NativeTypeName(
            "HRESULT (D2D1_COLOR_SPACE, const BYTE *, UINT32, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_COLOR_SPACE,
            byte*,
            uint,
            ID2D1ColorContext*,
            int> CreateColorContext;

        [NativeTypeName(
            "HRESULT (PCWSTR, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ID2D1ColorContext*,
            int> CreateColorContextFromFilename;

        [NativeTypeName(
            "HRESULT (IWICColorContext *, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICColorContext,
            ID2D1ColorContext*,
            int> CreateColorContextFromWicColorContext;

        [NativeTypeName(
            "HRESULT (IDXGISurface *, const D2D1_BITMAP_PROPERTIES1 *, ID2D1Bitmap1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDXGISurface,
            D2D1_BITMAP_PROPERTIES1*,
            ID2D1Bitmap1*,
            int> CreateBitmapFromDxgiSurface;

        [NativeTypeName(
            "HRESULT (const IID &, ID2D1Effect **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ID2D1Effect*, int> CreateEffect;

        [NativeTypeName(
            "HRESULT (const D2D1_GRADIENT_STOP *, UINT32, D2D1_COLOR_SPACE, D2D1_COLOR_SPACE, D2D1_BUFFER_PRECISION, D2D1_EXTEND_MODE, D2D1_COLOR_INTERPOLATION_MODE, ID2D1GradientStopCollection1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_GRADIENT_STOP*,
            uint,
            D2D1_COLOR_SPACE,
            D2D1_COLOR_SPACE,
            D2D1_BUFFER_PRECISION,
            D2D1_EXTEND_MODE,
            D2D1_COLOR_INTERPOLATION_MODE,
            ID2D1GradientStopCollection1*,
            int> CreateGradientStopCollection2;

        [NativeTypeName(
            "HRESULT (ID2D1Image *, const D2D1_IMAGE_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1ImageBrush **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Image,
            D2D1_IMAGE_BRUSH_PROPERTIES*,
            D2D1_BRUSH_PROPERTIES*,
            ID2D1ImageBrush*,
            int> CreateImageBrush1;

        [NativeTypeName(
            "HRESULT (ID2D1Bitmap *, const D2D1_BITMAP_BRUSH_PROPERTIES1 *, const D2D1_BRUSH_PROPERTIES *, ID2D1BitmapBrush1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Bitmap,
            D2D1_BITMAP_BRUSH_PROPERTIES1*,
            D2D1_BRUSH_PROPERTIES*,
            ID2D1BitmapBrush1*,
            int> CreateBitmapBrush5;

        [NativeTypeName(
            "HRESULT (ID2D1CommandList **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1CommandList*, int> CreateCommandList;

        [NativeTypeName(
            "BOOL (DXGI_FORMAT) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DXGI_FORMAT, int> IsDxgiFormatSupported;

        [NativeTypeName(
            "BOOL (D2D1_BUFFER_PRECISION) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_BUFFER_PRECISION, int> IsBufferPrecisionSupported;

        [NativeTypeName(
            "HRESULT (ID2D1Image *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Image, D2D_RECT_F*, int> GetImageLocalBounds;

        [NativeTypeName(
            "HRESULT (ID2D1Image *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Image, D2D_RECT_F*, int> GetImageWorldBounds;

        [NativeTypeName(
            "HRESULT (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, DWRITE_MEASURING_MODE, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F,
            DWRITE_GLYPH_RUN*,
            DWRITE_MEASURING_MODE,
            D2D_RECT_F*,
            int> GetGlyphRunWorldBounds;

        [NativeTypeName(
            "void (ID2D1Device **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Device*, void> GetDevice;

        [NativeTypeName("void (ID2D1Image *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Image, void> SetTarget;

        [NativeTypeName(
            "void (ID2D1Image **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Image*, void> GetTarget;

        [NativeTypeName(
            "void (const D2D1_RENDERING_CONTROLS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_RENDERING_CONTROLS*, void> SetRenderingControls;

        [NativeTypeName(
            "void (D2D1_RENDERING_CONTROLS *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_RENDERING_CONTROLS*, void> GetRenderingControls;

        [NativeTypeName(
            "void (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_PRIMITIVE_BLEND, void> SetPrimitiveBlend;

        [NativeTypeName(
            "D2D1_PRIMITIVE_BLEND () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_PRIMITIVE_BLEND> GetPrimitiveBlend;

        [NativeTypeName("void (D2D1_UNIT_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_UNIT_MODE, void> SetUnitMode;

        [NativeTypeName(
            "D2D1_UNIT_MODE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_UNIT_MODE> GetUnitMode;

        [NativeTypeName(
            "void (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F,
            DWRITE_GLYPH_RUN*,
            DWRITE_GLYPH_RUN_DESCRIPTION*,
            ID2D1Brush,
            DWRITE_MEASURING_MODE,
            void> DrawGlyphRun1;

        [NativeTypeName(
            "void (ID2D1Image *, const D2D1_POINT_2F *, const D2D1_RECT_F *, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Image,
            D2D_POINT_2F*,
            D2D_RECT_F*,
            D2D1_INTERPOLATION_MODE,
            D2D1_COMPOSITE_MODE,
            void> DrawImage7;

        [NativeTypeName(
            "void (ID2D1GdiMetafile *, const D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1GdiMetafile, D2D_POINT_2F*, void> DrawGdiMetafile1;

        [NativeTypeName(
            "void (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_INTERPOLATION_MODE, const D2D1_RECT_F *, const D2D1_MATRIX_4X4_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Bitmap,
            D2D_RECT_F*,
            float,
            D2D1_INTERPOLATION_MODE,
            D2D_RECT_F*,
            D2D_MATRIX_4X4_F*,
            void> DrawBitmap1;

        [NativeTypeName(
            "void (const D2D1_LAYER_PARAMETERS1 *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_LAYER_PARAMETERS1*, ID2D1Layer, void> PushLayer1;

        [NativeTypeName(
            "HRESULT (ID2D1Effect *, UINT32, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Effect,
            uint,
            D2D_RECT_F*,
            int> InvalidateEffectInputRectangle;

        [NativeTypeName(
            "HRESULT (ID2D1Effect *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Effect, uint*, int> GetEffectInvalidRectangleCount;

        [NativeTypeName(
            "HRESULT (ID2D1Effect *, D2D1_RECT_F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Effect,
            D2D_RECT_F*,
            uint,
            int> GetEffectInvalidRectangles;

        [NativeTypeName(
            "HRESULT (ID2D1Effect *, const D2D1_RECT_F *, const D2D1_EFFECT_INPUT_DESCRIPTION *, D2D1_RECT_F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Effect,
            D2D_RECT_F*,
            D2D1_EFFECT_INPUT_DESCRIPTION*,
            D2D_RECT_F*,
            uint,
            int> GetEffectRequiredInputRectangles;

        [NativeTypeName(
            "void (ID2D1Bitmap *, ID2D1Brush *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Bitmap,
            ID2D1Brush,
            D2D_RECT_F*,
            D2D_RECT_F*,
            void> FillOpacityMask1;

        [NativeTypeName(
            "HRESULT (ID2D1Geometry *, FLOAT, ID2D1GeometryRealization **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Geometry,
            float,
            ID2D1GeometryRealization*,
            int> CreateFilledGeometryRealization;

        [NativeTypeName(
            "HRESULT (ID2D1Geometry *, FLOAT, FLOAT, ID2D1StrokeStyle *, ID2D1GeometryRealization **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Geometry,
            float,
            float,
            ID2D1StrokeStyle,
            ID2D1GeometryRealization*,
            int> CreateStrokedGeometryRealization;

        [NativeTypeName(
            "void (ID2D1GeometryRealization *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1GeometryRealization,
            ID2D1Brush,
            void> DrawGeometryRealization;

        [NativeTypeName(
            "HRESULT (const D2D1_INK_POINT *, ID2D1Ink **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_INK_POINT*, ID2D1Ink*, int> CreateInk;

        [NativeTypeName(
            "HRESULT (const D2D1_INK_STYLE_PROPERTIES *, ID2D1InkStyle **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_INK_STYLE_PROPERTIES*,
            ID2D1InkStyle*,
            int> CreateInkStyle;

        [NativeTypeName(
            "HRESULT (const D2D1_GRADIENT_MESH_PATCH *, UINT32, ID2D1GradientMesh **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_GRADIENT_MESH_PATCH*,
            uint,
            ID2D1GradientMesh*,
            int> CreateGradientMesh;

        [NativeTypeName(
            "HRESULT (IWICBitmapSource *, D2D1_IMAGE_SOURCE_LOADING_OPTIONS, D2D1_ALPHA_MODE, ID2D1ImageSourceFromWic **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICBitmapSource,
            D2D1_IMAGE_SOURCE_LOADING_OPTIONS,
            D2D1_ALPHA_MODE,
            ID2D1ImageSourceFromWic*,
            int> CreateImageSourceFromWic2;

        [NativeTypeName(
            "HRESULT (D2D1_BUFFER_PRECISION, const UINT32 *, const BYTE *, UINT32, const UINT32 *, ID2D1LookupTable3D **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_BUFFER_PRECISION,
            uint*,
            byte*,
            uint,
            uint*,
            ID2D1LookupTable3D*,
            int> CreateLookupTable3D;

        [NativeTypeName(
            "HRESULT (IDXGISurface **, UINT32, DXGI_COLOR_SPACE_TYPE, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS, ID2D1ImageSource **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDXGISurface*,
            uint,
            DXGI_COLOR_SPACE_TYPE,
            D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS,
            ID2D1ImageSource*,
            int> CreateImageSourceFromDxgi;

        [NativeTypeName(
            "HRESULT (ID2D1GradientMesh *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1GradientMesh,
            D2D_RECT_F*,
            int> GetGradientMeshWorldBounds;

        [NativeTypeName(
            "void (ID2D1Ink *, ID2D1Brush *, ID2D1InkStyle *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Ink, ID2D1Brush, ID2D1InkStyle, void> DrawInk;

        [NativeTypeName(
            "void (ID2D1GradientMesh *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1GradientMesh, void> DrawGradientMesh;

        [NativeTypeName(
            "void (ID2D1GdiMetafile *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1GdiMetafile,
            D2D_RECT_F*,
            D2D_RECT_F*,
            void> DrawGdiMetafile2;

        [NativeTypeName(
            "HRESULT (ID2D1ImageSource *, const D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *, ID2D1TransformedImageSource **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1ImageSource,
            D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*,
            ID2D1TransformedImageSource*,
            int> CreateTransformedImageSource;

        [NativeTypeName(
            "HRESULT (ID2D1SpriteBatch **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1SpriteBatch*, int> CreateSpriteBatch;

        [NativeTypeName(
            "void (ID2D1SpriteBatch *, UINT32, UINT32, ID2D1Bitmap *, D2D1_BITMAP_INTERPOLATION_MODE, D2D1_SPRITE_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1SpriteBatch,
            uint,
            uint,
            ID2D1Bitmap,
            D2D1_BITMAP_INTERPOLATION_MODE,
            D2D1_SPRITE_OPTIONS,
            void> DrawSpriteBatch1;

        [NativeTypeName(
            "HRESULT (ID2D1SvgGlyphStyle **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1SvgGlyphStyle*, int> CreateSvgGlyphStyle;

        [NativeTypeName(
            "void (const WCHAR *, UINT32, IDWriteTextFormat *, const D2D1_RECT_F *, ID2D1Brush *, ID2D1SvgGlyphStyle *, UINT32, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IDWriteTextFormat,
            D2D_RECT_F*,
            ID2D1Brush,
            ID2D1SvgGlyphStyle,
            uint,
            D2D1_DRAW_TEXT_OPTIONS,
            DWRITE_MEASURING_MODE,
            void> DrawText1;

        [NativeTypeName(
            "void (D2D1_POINT_2F, IDWriteTextLayout *, ID2D1Brush *, ID2D1SvgGlyphStyle *, UINT32, D2D1_DRAW_TEXT_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F,
            IDWriteTextLayout,
            ID2D1Brush,
            ID2D1SvgGlyphStyle,
            uint,
            D2D1_DRAW_TEXT_OPTIONS,
            void> DrawTextLayout1;

        [NativeTypeName(
            "void (DWRITE_GLYPH_IMAGE_FORMATS, D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, DWRITE_MEASURING_MODE, D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_GLYPH_IMAGE_FORMATS,
            D2D_POINT_2F,
            DWRITE_GLYPH_RUN*,
            DWRITE_MEASURING_MODE,
            D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION,
            void> DrawColorBitmapGlyphRun;

        [NativeTypeName(
            "void (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, ID2D1Brush *, ID2D1SvgGlyphStyle *, UINT32, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F,
            DWRITE_GLYPH_RUN*,
            ID2D1Brush,
            ID2D1SvgGlyphStyle,
            uint,
            DWRITE_MEASURING_MODE,
            void> DrawSvgGlyphRun;

        [NativeTypeName(
            "HRESULT (DWRITE_GLYPH_IMAGE_FORMATS, D2D1_POINT_2F, IDWriteFontFace *, FLOAT, UINT16, BOOL, const D2D1_MATRIX_3X2_F *, FLOAT, FLOAT, D2D1_MATRIX_3X2_F *, ID2D1Image **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_GLYPH_IMAGE_FORMATS,
            D2D_POINT_2F,
            IDWriteFontFace,
            float,
            ushort,
            BOOL,
            D2D_MATRIX_3X2_F*,
            float,
            float,
            D2D_MATRIX_3X2_F*,
            ID2D1Image*,
            int> GetColorBitmapGlyphImage;

        [NativeTypeName(
            "HRESULT (D2D1_POINT_2F, IDWriteFontFace *, FLOAT, UINT16, BOOL, const D2D1_MATRIX_3X2_F *, ID2D1Brush *, ID2D1SvgGlyphStyle *, UINT32, D2D1_MATRIX_3X2_F *, ID2D1CommandList **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F,
            IDWriteFontFace,
            float,
            ushort,
            BOOL,
            D2D_MATRIX_3X2_F*,
            ID2D1Brush,
            ID2D1SvgGlyphStyle,
            uint,
            D2D_MATRIX_3X2_F*,
            ID2D1CommandList*,
            int> GetSvgGlyphImage;

        [NativeTypeName(
            "HRESULT (IStream *, D2D1_SIZE_F, ID2D1SvgDocument **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            D2D_SIZE_F,
            ID2D1SvgDocument*,
            int> CreateSvgDocument;

        [NativeTypeName(
            "void (ID2D1SvgDocument *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1SvgDocument, void> DrawSvgDocument;

        [NativeTypeName(
            "HRESULT (DXGI_COLOR_SPACE_TYPE, ID2D1ColorContext1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXGI_COLOR_SPACE_TYPE,
            ID2D1ColorContext1*,
            int> CreateColorContextFromDxgiColorSpace;

        [NativeTypeName(
            "HRESULT (const D2D1_SIMPLE_COLOR_PROFILE *, ID2D1ColorContext1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_SIMPLE_COLOR_PROFILE*,
            ID2D1ColorContext1*,
            int> CreateColorContextFromSimpleColorProfile;

        [NativeTypeName(
            "void (ID2D1Image *, D2D1_BLEND_MODE, const D2D1_POINT_2F *, const D2D1_RECT_F *, D2D1_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Image,
            D2D1_BLEND_MODE,
            D2D_POINT_2F*,
            D2D_RECT_F*,
            D2D1_INTERPOLATION_MODE,
            void> BlendImage;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1DeviceContext6"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1DeviceContext6(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1DeviceContext5"/> to <see cref = "ID2D1DeviceContext6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1DeviceContext5"/> instance to be converted </param>
    public static explicit operator ID2D1DeviceContext6(Silk.NET.DirectX.ID2D1DeviceContext5 value)
    {
        return new ID2D1DeviceContext6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DeviceContext6"/> to <see cref = "Silk.NET.DirectX.ID2D1DeviceContext5"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DeviceContext6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1DeviceContext5(ID2D1DeviceContext6 value)
    {
        return new Silk.NET.DirectX.ID2D1DeviceContext5(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1DeviceContext4"/> to <see cref = "ID2D1DeviceContext6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1DeviceContext4"/> instance to be converted </param>
    public static explicit operator ID2D1DeviceContext6(Silk.NET.DirectX.ID2D1DeviceContext4 value)
    {
        return new ID2D1DeviceContext6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DeviceContext6"/> to <see cref = "Silk.NET.DirectX.ID2D1DeviceContext4"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DeviceContext6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1DeviceContext4(ID2D1DeviceContext6 value)
    {
        return new Silk.NET.DirectX.ID2D1DeviceContext4(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1DeviceContext3"/> to <see cref = "ID2D1DeviceContext6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1DeviceContext3"/> instance to be converted </param>
    public static explicit operator ID2D1DeviceContext6(Silk.NET.DirectX.ID2D1DeviceContext3 value)
    {
        return new ID2D1DeviceContext6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DeviceContext6"/> to <see cref = "Silk.NET.DirectX.ID2D1DeviceContext3"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DeviceContext6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1DeviceContext3(ID2D1DeviceContext6 value)
    {
        return new Silk.NET.DirectX.ID2D1DeviceContext3(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1DeviceContext2"/> to <see cref = "ID2D1DeviceContext6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1DeviceContext2"/> instance to be converted </param>
    public static explicit operator ID2D1DeviceContext6(Silk.NET.DirectX.ID2D1DeviceContext2 value)
    {
        return new ID2D1DeviceContext6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DeviceContext6"/> to <see cref = "Silk.NET.DirectX.ID2D1DeviceContext2"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DeviceContext6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1DeviceContext2(ID2D1DeviceContext6 value)
    {
        return new Silk.NET.DirectX.ID2D1DeviceContext2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1DeviceContext1"/> to <see cref = "ID2D1DeviceContext6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1DeviceContext1"/> instance to be converted </param>
    public static explicit operator ID2D1DeviceContext6(Silk.NET.DirectX.ID2D1DeviceContext1 value)
    {
        return new ID2D1DeviceContext6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DeviceContext6"/> to <see cref = "Silk.NET.DirectX.ID2D1DeviceContext1"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DeviceContext6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1DeviceContext1(ID2D1DeviceContext6 value)
    {
        return new Silk.NET.DirectX.ID2D1DeviceContext1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1DeviceContext"/> to <see cref = "ID2D1DeviceContext6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1DeviceContext"/> instance to be converted </param>
    public static explicit operator ID2D1DeviceContext6(Silk.NET.DirectX.ID2D1DeviceContext value)
    {
        return new ID2D1DeviceContext6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DeviceContext6"/> to <see cref = "Silk.NET.DirectX.ID2D1DeviceContext"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DeviceContext6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1DeviceContext(ID2D1DeviceContext6 value)
    {
        return new Silk.NET.DirectX.ID2D1DeviceContext(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1RenderTarget"/> to <see cref = "ID2D1DeviceContext6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1RenderTarget"/> instance to be converted </param>
    public static explicit operator ID2D1DeviceContext6(Silk.NET.DirectX.ID2D1RenderTarget value)
    {
        return new ID2D1DeviceContext6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DeviceContext6"/> to <see cref = "Silk.NET.DirectX.ID2D1RenderTarget"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DeviceContext6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1RenderTarget(ID2D1DeviceContext6 value)
    {
        return new Silk.NET.DirectX.ID2D1RenderTarget(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1DeviceContext6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1DeviceContext6(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1DeviceContext6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DeviceContext6"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DeviceContext6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1DeviceContext6 value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1DeviceContext6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1DeviceContext6(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1DeviceContext6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1DeviceContext6"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1DeviceContext6"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1DeviceContext6 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
