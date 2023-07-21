// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDWriteTextRenderer.xml' path='doc/member[@name="IDWriteTextRenderer"]/*' />
[Guid("EF8A8135-5CC6-45FE-8825-C5A0724EB819")]
[NativeTypeName("struct IDWriteTextRenderer : IDWritePixelSnapping")]
[NativeInheritance("IDWritePixelSnapping")]
public unsafe partial struct IDWriteTextRenderer : IDWriteTextRenderer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextRenderer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextRenderer*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteTextRenderer*, uint>)(lpVtbl[1]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextRenderer*, uint>)(lpVtbl[2]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWritePixelSnapping.IsPixelSnappingDisabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsPixelSnappingDisabled(void* clientDrawingContext, BOOL* isDisabled)
    {
        return ((delegate* unmanaged<IDWriteTextRenderer*, void*, BOOL*, int>)(lpVtbl[3]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, isDisabled);
    }

    /// <inheritdoc cref="IDWritePixelSnapping.GetCurrentTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentTransform(void* clientDrawingContext, DWRITE_MATRIX* transform)
    {
        return ((delegate* unmanaged<IDWriteTextRenderer*, void*, DWRITE_MATRIX*, int>)(lpVtbl[4]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, transform);
    }

    /// <inheritdoc cref="IDWritePixelSnapping.GetPixelsPerDip" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPixelsPerDip(void* clientDrawingContext, float* pixelsPerDip)
    {
        return ((delegate* unmanaged<IDWriteTextRenderer*, void*, float*, int>)(lpVtbl[5]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, pixelsPerDip);
    }

    /// <include file='IDWriteTextRenderer.xml' path='doc/member[@name="IDWriteTextRenderer.DrawGlyphRun"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, IUnknown* clientDrawingEffect)
    {
        return ((delegate* unmanaged<IDWriteTextRenderer*, void*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, IUnknown*, int>)(lpVtbl[6]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, measuringMode, glyphRun, glyphRunDescription, clientDrawingEffect);
    }

    /// <include file='IDWriteTextRenderer.xml' path='doc/member[@name="IDWriteTextRenderer.DrawUnderline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [NativeTypeName("const DWRITE_UNDERLINE *")] DWRITE_UNDERLINE* underline, IUnknown* clientDrawingEffect)
    {
        return ((delegate* unmanaged<IDWriteTextRenderer*, void*, float, float, DWRITE_UNDERLINE*, IUnknown*, int>)(lpVtbl[7]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, underline, clientDrawingEffect);
    }

    /// <include file='IDWriteTextRenderer.xml' path='doc/member[@name="IDWriteTextRenderer.DrawStrikethrough"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [NativeTypeName("const DWRITE_STRIKETHROUGH *")] DWRITE_STRIKETHROUGH* strikethrough, IUnknown* clientDrawingEffect)
    {
        return ((delegate* unmanaged<IDWriteTextRenderer*, void*, float, float, DWRITE_STRIKETHROUGH*, IUnknown*, int>)(lpVtbl[8]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, baselineOriginX, baselineOriginY, strikethrough, clientDrawingEffect);
    }

    /// <include file='IDWriteTextRenderer.xml' path='doc/member[@name="IDWriteTextRenderer.DrawInlineObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DrawInlineObject(void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, BOOL isSideways, BOOL isRightToLeft, IUnknown* clientDrawingEffect)
    {
        return ((delegate* unmanaged<IDWriteTextRenderer*, void*, float, float, IDWriteInlineObject*, BOOL, BOOL, IUnknown*, int>)(lpVtbl[9]))((IDWriteTextRenderer*)Unsafe.AsPointer(ref this), clientDrawingContext, originX, originY, inlineObject, isSideways, isRightToLeft, clientDrawingEffect);
    }

    public interface Interface : IDWritePixelSnapping.Interface
    {
        [VtblIndex(6)]
        HRESULT DrawGlyphRun(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, IUnknown* clientDrawingEffect);

        [VtblIndex(7)]
        HRESULT DrawUnderline(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [NativeTypeName("const DWRITE_UNDERLINE *")] DWRITE_UNDERLINE* underline, IUnknown* clientDrawingEffect);

        [VtblIndex(8)]
        HRESULT DrawStrikethrough(void* clientDrawingContext, float baselineOriginX, float baselineOriginY, [NativeTypeName("const DWRITE_STRIKETHROUGH *")] DWRITE_STRIKETHROUGH* strikethrough, IUnknown* clientDrawingEffect);

        [VtblIndex(9)]
        HRESULT DrawInlineObject(void* clientDrawingContext, float originX, float originY, IDWriteInlineObject* inlineObject, BOOL isSideways, BOOL isRightToLeft, IUnknown* clientDrawingEffect);
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

        [NativeTypeName("HRESULT (void *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, BOOL*, int> IsPixelSnappingDisabled;

        [NativeTypeName("HRESULT (void *, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, DWRITE_MATRIX*, int> GetCurrentTransform;

        [NativeTypeName("HRESULT (void *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, float*, int> GetPixelsPerDip;

        [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, DWRITE_MEASURING_MODE, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, IUnknown*, int> DrawGlyphRun;

        [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, const DWRITE_UNDERLINE *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, float, float, DWRITE_UNDERLINE*, IUnknown*, int> DrawUnderline;

        [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, const DWRITE_STRIKETHROUGH *, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, float, float, DWRITE_STRIKETHROUGH*, IUnknown*, int> DrawStrikethrough;

        [NativeTypeName("HRESULT (void *, FLOAT, FLOAT, IDWriteInlineObject *, BOOL, BOOL, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, float, float, IDWriteInlineObject*, BOOL, BOOL, IUnknown*, int> DrawInlineObject;
    }
}
