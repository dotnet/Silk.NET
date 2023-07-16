// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink"]/*'/>
[Guid("54D7898A-A061-40A7-BEC7-E465BCBA2C4F")]
[NativeTypeName("struct ID2D1CommandSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1CommandSink : ID2D1CommandSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1CommandSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, uint> )(lpVtbl[1]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, uint> )(lpVtbl[2]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.BeginDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginDraw()
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, int> )(lpVtbl[3]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.EndDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, int> )(lpVtbl[4]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.SetAntialiasMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D1_ANTIALIAS_MODE, int> )(lpVtbl[5]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), antialiasMode);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.SetTags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, ulong, ulong, int> )(lpVtbl[6]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), tag1, tag2);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.SetTextAntialiasMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D1_TEXT_ANTIALIAS_MODE, int> )(lpVtbl[7]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), textAntialiasMode);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.SetTextRenderingParams"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, IDWriteRenderingParams*, int> )(lpVtbl[8]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), textRenderingParams);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.SetTransform"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D_MATRIX_3X2_F*, int> )(lpVtbl[9]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), transform);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.SetPrimitiveBlend"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D1_PRIMITIVE_BLEND, int> )(lpVtbl[10]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), primitiveBlend);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.SetUnitMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetUnitMode(D2D1_UNIT_MODE unitMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D1_UNIT_MODE, int> )(lpVtbl[11]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), unitMode);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.Clear"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, DXGI_RGBA*, int> )(lpVtbl[12]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), color);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.DrawGlyphRun"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush*, DWRITE_MEASURING_MODE, int> )(lpVtbl[13]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.DrawLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D_POINT_2F, D2D_POINT_2F, ID2D1Brush*, float, ID2D1StrokeStyle*, int> )(lpVtbl[14]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.DrawGeometry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int> )(lpVtbl[15]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.DrawRectangle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D_RECT_F*, ID2D1Brush*, float, ID2D1StrokeStyle*, int> )(lpVtbl[16]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.DrawBitmap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT DrawBitmap(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_INTERPOLATION_MODE, D2D_RECT_F*, D2D_MATRIX_4X4_F*, int> )(lpVtbl[17]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.DrawImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DrawImage(ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, ID2D1Image*, D2D_POINT_2F*, D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE, int> )(lpVtbl[18]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), image, targetOffset, imageRectangle, interpolationMode, compositeMode);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.DrawGdiMetafile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, ID2D1GdiMetafile*, D2D_POINT_2F*, int> )(lpVtbl[19]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), gdiMetafile, targetOffset);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.FillMesh"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, ID2D1Mesh*, ID2D1Brush*, int> )(lpVtbl[20]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), mesh, brush);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.FillOpacityMask"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, ID2D1Bitmap*, ID2D1Brush*, D2D_RECT_F*, D2D_RECT_F*, int> )(lpVtbl[21]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), opacityMask, brush, destinationRectangle, sourceRectangle);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.FillGeometry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int> )(lpVtbl[22]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.FillRectangle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, ID2D1Brush* brush)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D_RECT_F*, ID2D1Brush*, int> )(lpVtbl[23]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), rect, brush);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.PushAxisAlignedClip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, int> )(lpVtbl[24]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.PushLayer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters1, ID2D1Layer* layer)
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, D2D1_LAYER_PARAMETERS1*, ID2D1Layer*, int> )(lpVtbl[25]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this), layerParameters1, layer);
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.PopAxisAlignedClip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT PopAxisAlignedClip()
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, int> )(lpVtbl[26]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1CommandSink.xml' path='doc/member[@name="ID2D1CommandSink.PopLayer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT PopLayer()
    {
        return ((delegate* unmanaged<ID2D1CommandSink*, int> )(lpVtbl[27]))((ID2D1CommandSink*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginDraw();
        [VtblIndex(4)]
        HRESULT EndDraw();
        [VtblIndex(5)]
        HRESULT SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);
        [VtblIndex(6)]
        HRESULT SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2);
        [VtblIndex(7)]
        HRESULT SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);
        [VtblIndex(8)]
        HRESULT SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams);
        [VtblIndex(9)]
        HRESULT SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform);
        [VtblIndex(10)]
        HRESULT SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend);
        [VtblIndex(11)]
        HRESULT SetUnitMode(D2D1_UNIT_MODE unitMode);
        [VtblIndex(12)]
        HRESULT Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color);
        [VtblIndex(13)]
        HRESULT DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
        [VtblIndex(14)]
        HRESULT DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle);
        [VtblIndex(15)]
        HRESULT DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle);
        [VtblIndex(16)]
        HRESULT DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle);
        [VtblIndex(17)]
        HRESULT DrawBitmap(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform);
        [VtblIndex(18)]
        HRESULT DrawImage(ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);
        [VtblIndex(19)]
        HRESULT DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset);
        [VtblIndex(20)]
        HRESULT FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush);
        [VtblIndex(21)]
        HRESULT FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle);
        [VtblIndex(22)]
        HRESULT FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush);
        [VtblIndex(23)]
        HRESULT FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, ID2D1Brush* brush);
        [VtblIndex(24)]
        HRESULT PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
        [VtblIndex(25)]
        HRESULT PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters1, ID2D1Layer* layer);
        [VtblIndex(26)]
        HRESULT PopAxisAlignedClip();
        [VtblIndex(27)]
        HRESULT PopLayer();
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
        [NativeTypeName("HRESULT (D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_ANTIALIAS_MODE, int> SetAntialiasMode;
        [NativeTypeName("HRESULT (D2D1_TAG, D2D1_TAG) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong, int> SetTags;
        [NativeTypeName("HRESULT (D2D1_TEXT_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_TEXT_ANTIALIAS_MODE, int> SetTextAntialiasMode;
        [NativeTypeName("HRESULT (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteRenderingParams*, int> SetTextRenderingParams;
        [NativeTypeName("HRESULT (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_3X2_F*, int> SetTransform;
        [NativeTypeName("HRESULT (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_PRIMITIVE_BLEND, int> SetPrimitiveBlend;
        [NativeTypeName("HRESULT (D2D1_UNIT_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_UNIT_MODE, int> SetUnitMode;
        [NativeTypeName("HRESULT (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_RGBA*, int> Clear;
        [NativeTypeName("HRESULT (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush*, DWRITE_MEASURING_MODE, int> DrawGlyphRun;
        [NativeTypeName("HRESULT (D2D1_POINT_2F, D2D1_POINT_2F, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, D2D_POINT_2F, ID2D1Brush*, float, ID2D1StrokeStyle*, int> DrawLine;
        [NativeTypeName("HRESULT (ID2D1Geometry *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, int> DrawGeometry;
        [NativeTypeName("HRESULT (const D2D1_RECT_F *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, ID2D1Brush*, float, ID2D1StrokeStyle*, int> DrawRectangle;
        [NativeTypeName("HRESULT (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_INTERPOLATION_MODE, const D2D1_RECT_F *, const D2D1_MATRIX_4X4_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_INTERPOLATION_MODE, D2D_RECT_F*, D2D_MATRIX_4X4_F*, int> DrawBitmap;
        [NativeTypeName("HRESULT (ID2D1Image *, const D2D1_POINT_2F *, const D2D1_RECT_F *, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Image*, D2D_POINT_2F*, D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE, int> DrawImage;
        [NativeTypeName("HRESULT (ID2D1GdiMetafile *, const D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1GdiMetafile*, D2D_POINT_2F*, int> DrawGdiMetafile;
        [NativeTypeName("HRESULT (ID2D1Mesh *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Mesh*, ID2D1Brush*, int> FillMesh;
        [NativeTypeName("HRESULT (ID2D1Bitmap *, ID2D1Brush *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Bitmap*, ID2D1Brush*, D2D_RECT_F*, D2D_RECT_F*, int> FillOpacityMask;
        [NativeTypeName("HRESULT (ID2D1Geometry *, ID2D1Brush *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, int> FillGeometry;
        [NativeTypeName("HRESULT (const D2D1_RECT_F *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, ID2D1Brush*, int> FillRectangle;
        [NativeTypeName("HRESULT (const D2D1_RECT_F *, D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, int> PushAxisAlignedClip;
        [NativeTypeName("HRESULT (const D2D1_LAYER_PARAMETERS1 *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_LAYER_PARAMETERS1*, ID2D1Layer*, int> PushLayer;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PopAxisAlignedClip;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PopLayer;
    }
}