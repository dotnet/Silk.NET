// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("C78A6519-40D6-4218-B2DE-BEEEB744BB3E")]
[NativeTypeName("struct ID2D1CommandSink4 : ID2D1CommandSink3")]
[NativeInheritance("ID2D1CommandSink3")]
public unsafe partial struct ID2D1CommandSink4 : ID2D1CommandSink4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1CommandSink4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1CommandSink4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginDraw()
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, D2D1_ANTIALIAS_MODE, int>)((*lpVtbl)[5]))(
            this,
            antialiasMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTags(
        [NativeTypeName("D2D1_TAG")] ulong tag1,
        [NativeTypeName("D2D1_TAG")] ulong tag2
    )
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, ulong, ulong, int>)((*lpVtbl)[6]))(
            this,
            tag1,
            tag2
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
    {
        return (
            (delegate* unmanaged<ID2D1CommandSink4, D2D1_TEXT_ANTIALIAS_MODE, int>)((*lpVtbl)[7])
        )(this, textAntialiasMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTextRenderingParams(IDWriteRenderingParams textRenderingParams)
    {
        return (
            (delegate* unmanaged<ID2D1CommandSink4, IDWriteRenderingParams, int>)((*lpVtbl)[8])
        )(this, textRenderingParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTransform(
        [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform
    )
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, D2D_MATRIX_3X2_F*, int>)((*lpVtbl)[9]))(
            this,
            transform
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, D2D1_PRIMITIVE_BLEND, int>)((*lpVtbl)[10]))(
            this,
            primitiveBlend
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetUnitMode(D2D1_UNIT_MODE unitMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, D2D1_UNIT_MODE, int>)((*lpVtbl)[11]))(
            this,
            unitMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, DXGI_RGBA*, int>)((*lpVtbl)[12]))(
            this,
            color
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DrawGlyphRun(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
        [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun,
        [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")]
            DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription,
        ID2D1Brush foregroundBrush,
        DWRITE_MEASURING_MODE measuringMode
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1CommandSink4,
                D2D_POINT_2F,
                DWRITE_GLYPH_RUN*,
                DWRITE_GLYPH_RUN_DESCRIPTION*,
                ID2D1Brush,
                DWRITE_MEASURING_MODE,
                int>)((*lpVtbl)[13])
        )(this, baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT DrawLine(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1,
        ID2D1Brush brush,
        float strokeWidth,
        ID2D1StrokeStyle strokeStyle
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1CommandSink4,
                D2D_POINT_2F,
                D2D_POINT_2F,
                ID2D1Brush,
                float,
                ID2D1StrokeStyle,
                int>)((*lpVtbl)[14])
        )(this, point0, point1, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DrawGeometry(
        ID2D1Geometry geometry,
        ID2D1Brush brush,
        float strokeWidth,
        ID2D1StrokeStyle strokeStyle
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1CommandSink4,
                ID2D1Geometry,
                ID2D1Brush,
                float,
                ID2D1StrokeStyle,
                int>)((*lpVtbl)[15])
        )(this, geometry, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DrawRectangle(
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect,
        ID2D1Brush brush,
        float strokeWidth,
        ID2D1StrokeStyle strokeStyle
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1CommandSink4,
                D2D_RECT_F*,
                ID2D1Brush,
                float,
                ID2D1StrokeStyle,
                int>)((*lpVtbl)[16])
        )(this, rect, brush, strokeWidth, strokeStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT DrawBitmap(
        ID2D1Bitmap bitmap,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle,
        float opacity,
        D2D1_INTERPOLATION_MODE interpolationMode,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle,
        [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1CommandSink4,
                ID2D1Bitmap,
                D2D_RECT_F*,
                float,
                D2D1_INTERPOLATION_MODE,
                D2D_RECT_F*,
                D2D_MATRIX_4X4_F*,
                int>)((*lpVtbl)[17])
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
    [VtblIndex(18)]
    public HRESULT DrawImage(
        ID2D1Image image,
        [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle,
        D2D1_INTERPOLATION_MODE interpolationMode,
        D2D1_COMPOSITE_MODE compositeMode
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1CommandSink4,
                ID2D1Image,
                D2D_POINT_2F*,
                D2D_RECT_F*,
                D2D1_INTERPOLATION_MODE,
                D2D1_COMPOSITE_MODE,
                int>)((*lpVtbl)[18])
        )(this, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DrawGdiMetafile(
        ID2D1GdiMetafile gdiMetafile,
        [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset
    )
    {
        return (
            (delegate* unmanaged<ID2D1CommandSink4, ID2D1GdiMetafile, D2D_POINT_2F*, int>)(
                (*lpVtbl)[19]
            )
        )(this, gdiMetafile, targetOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FillMesh(ID2D1Mesh mesh, ID2D1Brush brush)
    {
        return (
            (delegate* unmanaged<ID2D1CommandSink4, ID2D1Mesh, ID2D1Brush, int>)((*lpVtbl)[20])
        )(this, mesh, brush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT FillOpacityMask(
        ID2D1Bitmap opacityMask,
        ID2D1Brush brush,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1CommandSink4,
                ID2D1Bitmap,
                ID2D1Brush,
                D2D_RECT_F*,
                D2D_RECT_F*,
                int>)((*lpVtbl)[21])
        )(this, opacityMask, brush, destinationRectangle, sourceRectangle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT FillGeometry(ID2D1Geometry geometry, ID2D1Brush brush, ID2D1Brush opacityBrush)
    {
        return (
            (delegate* unmanaged<ID2D1CommandSink4, ID2D1Geometry, ID2D1Brush, ID2D1Brush, int>)(
                (*lpVtbl)[22]
            )
        )(this, geometry, brush, opacityBrush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT FillRectangle(
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect,
        ID2D1Brush brush
    )
    {
        return (
            (delegate* unmanaged<ID2D1CommandSink4, D2D_RECT_F*, ID2D1Brush, int>)((*lpVtbl)[23])
        )(this, rect, brush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT PushAxisAlignedClip(
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect,
        D2D1_ANTIALIAS_MODE antialiasMode
    )
    {
        return (
            (delegate* unmanaged<ID2D1CommandSink4, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, int>)(
                (*lpVtbl)[24]
            )
        )(this, clipRect, antialiasMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PushLayer(
        [NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters1,
        ID2D1Layer layer
    )
    {
        return (
            (delegate* unmanaged<ID2D1CommandSink4, D2D1_LAYER_PARAMETERS1*, ID2D1Layer, int>)(
                (*lpVtbl)[25]
            )
        )(this, layerParameters1, layer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT PopAxisAlignedClip()
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, int>)((*lpVtbl)[26]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT PopLayer()
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, int>)((*lpVtbl)[27]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetPrimitiveBlend1(D2D1_PRIMITIVE_BLEND primitiveBlend)
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, D2D1_PRIMITIVE_BLEND, int>)((*lpVtbl)[28]))(
            this,
            primitiveBlend
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT DrawInk(ID2D1Ink ink, ID2D1Brush brush, ID2D1InkStyle inkStyle)
    {
        return (
            (delegate* unmanaged<ID2D1CommandSink4, ID2D1Ink, ID2D1Brush, ID2D1InkStyle, int>)(
                (*lpVtbl)[29]
            )
        )(this, ink, brush, inkStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT DrawGradientMesh(ID2D1GradientMesh gradientMesh)
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, ID2D1GradientMesh, int>)((*lpVtbl)[30]))(
            this,
            gradientMesh
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT DrawGdiMetafile(
        ID2D1GdiMetafile gdiMetafile,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle,
        [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1CommandSink4,
                ID2D1GdiMetafile,
                D2D_RECT_F*,
                D2D_RECT_F*,
                int>)((*lpVtbl)[31])
        )(this, gdiMetafile, destinationRectangle, sourceRectangle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT DrawSpriteBatch(
        ID2D1SpriteBatch spriteBatch,
        [NativeTypeName("UINT32")] uint startIndex,
        [NativeTypeName("UINT32")] uint spriteCount,
        ID2D1Bitmap bitmap,
        D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
        D2D1_SPRITE_OPTIONS spriteOptions
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1CommandSink4,
                ID2D1SpriteBatch,
                uint,
                uint,
                ID2D1Bitmap,
                D2D1_BITMAP_INTERPOLATION_MODE,
                D2D1_SPRITE_OPTIONS,
                int>)((*lpVtbl)[32])
        )(this, spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetPrimitiveBlend2(D2D1_PRIMITIVE_BLEND primitiveBlend)
    {
        return ((delegate* unmanaged<ID2D1CommandSink4, D2D1_PRIMITIVE_BLEND, int>)((*lpVtbl)[33]))(
            this,
            primitiveBlend
        );
    }

    public interface Interface : ID2D1CommandSink3.Interface
    {
        [VtblIndex(33)]
        HRESULT SetPrimitiveBlend2(D2D1_PRIMITIVE_BLEND primitiveBlend);
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BeginDraw;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndDraw;

        [NativeTypeName(
            "HRESULT (D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_ANTIALIAS_MODE, int> SetAntialiasMode;

        [NativeTypeName(
            "HRESULT (D2D1_TAG, D2D1_TAG) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong, ulong, int> SetTags;

        [NativeTypeName(
            "HRESULT (D2D1_TEXT_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_TEXT_ANTIALIAS_MODE, int> SetTextAntialiasMode;

        [NativeTypeName(
            "HRESULT (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteRenderingParams, int> SetTextRenderingParams;

        [NativeTypeName(
            "HRESULT (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, int> SetTransform;

        [NativeTypeName(
            "HRESULT (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_PRIMITIVE_BLEND, int> SetPrimitiveBlend;

        [NativeTypeName(
            "HRESULT (D2D1_UNIT_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_UNIT_MODE, int> SetUnitMode;

        [NativeTypeName(
            "HRESULT (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, int> Clear;

        [NativeTypeName(
            "HRESULT (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F,
            DWRITE_GLYPH_RUN*,
            DWRITE_GLYPH_RUN_DESCRIPTION*,
            ID2D1Brush,
            DWRITE_MEASURING_MODE,
            int> DrawGlyphRun;

        [NativeTypeName(
            "HRESULT (D2D1_POINT_2F, D2D1_POINT_2F, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F,
            D2D_POINT_2F,
            ID2D1Brush,
            float,
            ID2D1StrokeStyle,
            int> DrawLine;

        [NativeTypeName(
            "HRESULT (ID2D1Geometry *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Geometry,
            ID2D1Brush,
            float,
            ID2D1StrokeStyle,
            int> DrawGeometry;

        [NativeTypeName(
            "HRESULT (const D2D1_RECT_F *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_RECT_F*,
            ID2D1Brush,
            float,
            ID2D1StrokeStyle,
            int> DrawRectangle;

        [NativeTypeName(
            "HRESULT (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_INTERPOLATION_MODE, const D2D1_RECT_F *, const D2D1_MATRIX_4X4_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Bitmap,
            D2D_RECT_F*,
            float,
            D2D1_INTERPOLATION_MODE,
            D2D_RECT_F*,
            D2D_MATRIX_4X4_F*,
            int> DrawBitmap;

        [NativeTypeName(
            "HRESULT (ID2D1Image *, const D2D1_POINT_2F *, const D2D1_RECT_F *, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Image,
            D2D_POINT_2F*,
            D2D_RECT_F*,
            D2D1_INTERPOLATION_MODE,
            D2D1_COMPOSITE_MODE,
            int> DrawImage;

        [NativeTypeName(
            "HRESULT (ID2D1GdiMetafile *, const D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1GdiMetafile, D2D_POINT_2F*, int> DrawGdiMetafile;

        [NativeTypeName(
            "HRESULT (ID2D1Mesh *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Mesh, ID2D1Brush, int> FillMesh;

        [NativeTypeName(
            "HRESULT (ID2D1Bitmap *, ID2D1Brush *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Bitmap,
            ID2D1Brush,
            D2D_RECT_F*,
            D2D_RECT_F*,
            int> FillOpacityMask;

        [NativeTypeName(
            "HRESULT (ID2D1Geometry *, ID2D1Brush *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Geometry, ID2D1Brush, ID2D1Brush, int> FillGeometry;

        [NativeTypeName(
            "HRESULT (const D2D1_RECT_F *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, ID2D1Brush, int> FillRectangle;

        [NativeTypeName(
            "HRESULT (const D2D1_RECT_F *, D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_RECT_F*,
            D2D1_ANTIALIAS_MODE,
            int> PushAxisAlignedClip;

        [NativeTypeName(
            "HRESULT (const D2D1_LAYER_PARAMETERS1 *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_LAYER_PARAMETERS1*, ID2D1Layer, int> PushLayer;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PopAxisAlignedClip;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PopLayer;

        [NativeTypeName(
            "HRESULT (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_PRIMITIVE_BLEND, int> SetPrimitiveBlend1;

        [NativeTypeName(
            "HRESULT (ID2D1Ink *, ID2D1Brush *, ID2D1InkStyle *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Ink, ID2D1Brush, ID2D1InkStyle, int> DrawInk;

        [NativeTypeName(
            "HRESULT (ID2D1GradientMesh *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1GradientMesh, int> DrawGradientMesh;

        [NativeTypeName(
            "HRESULT (ID2D1GdiMetafile *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1GdiMetafile,
            D2D_RECT_F*,
            D2D_RECT_F*,
            int> DrawGdiMetafile1;

        [NativeTypeName(
            "HRESULT (ID2D1SpriteBatch *, UINT32, UINT32, ID2D1Bitmap *, D2D1_BITMAP_INTERPOLATION_MODE, D2D1_SPRITE_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1SpriteBatch,
            uint,
            uint,
            ID2D1Bitmap,
            D2D1_BITMAP_INTERPOLATION_MODE,
            D2D1_SPRITE_OPTIONS,
            int> DrawSpriteBatch;

        [NativeTypeName(
            "HRESULT (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_PRIMITIVE_BLEND, int> SetPrimitiveBlend2;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1CommandSink4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1CommandSink4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1CommandSink3"/> to <see cref = "ID2D1CommandSink4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1CommandSink3"/> instance to be converted </param>
    public static explicit operator ID2D1CommandSink4(Silk.NET.DirectX.ID2D1CommandSink3 value)
    {
        return new ID2D1CommandSink4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1CommandSink4"/> to <see cref = "Silk.NET.DirectX.ID2D1CommandSink3"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1CommandSink4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1CommandSink3(ID2D1CommandSink4 value)
    {
        return new Silk.NET.DirectX.ID2D1CommandSink3(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1CommandSink2"/> to <see cref = "ID2D1CommandSink4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1CommandSink2"/> instance to be converted </param>
    public static explicit operator ID2D1CommandSink4(Silk.NET.DirectX.ID2D1CommandSink2 value)
    {
        return new ID2D1CommandSink4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1CommandSink4"/> to <see cref = "Silk.NET.DirectX.ID2D1CommandSink2"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1CommandSink4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1CommandSink2(ID2D1CommandSink4 value)
    {
        return new Silk.NET.DirectX.ID2D1CommandSink2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1CommandSink1"/> to <see cref = "ID2D1CommandSink4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1CommandSink1"/> instance to be converted </param>
    public static explicit operator ID2D1CommandSink4(Silk.NET.DirectX.ID2D1CommandSink1 value)
    {
        return new ID2D1CommandSink4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1CommandSink4"/> to <see cref = "Silk.NET.DirectX.ID2D1CommandSink1"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1CommandSink4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1CommandSink1(ID2D1CommandSink4 value)
    {
        return new Silk.NET.DirectX.ID2D1CommandSink1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1CommandSink"/> to <see cref = "ID2D1CommandSink4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1CommandSink"/> instance to be converted </param>
    public static explicit operator ID2D1CommandSink4(Silk.NET.DirectX.ID2D1CommandSink value)
    {
        return new ID2D1CommandSink4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1CommandSink4"/> to <see cref = "Silk.NET.DirectX.ID2D1CommandSink"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1CommandSink4"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1CommandSink(ID2D1CommandSink4 value)
    {
        return new Silk.NET.DirectX.ID2D1CommandSink(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1CommandSink4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1CommandSink4(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1CommandSink4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1CommandSink4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1CommandSink4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1CommandSink4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
