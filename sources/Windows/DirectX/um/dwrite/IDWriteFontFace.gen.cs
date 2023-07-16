// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace"]/*'/>
[Guid("5F49804D-7024-4D43-BFA9-D25984F53849")]
[NativeTypeName("struct IDWriteFontFace : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontFace : IDWriteFontFace.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFace*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontFace*, uint> )(lpVtbl[1]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFace*, uint> )(lpVtbl[2]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public new DWRITE_FONT_FACE_TYPE GetType()
    {
        return ((delegate* unmanaged<IDWriteFontFace*, DWRITE_FONT_FACE_TYPE> )(lpVtbl[3]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetFiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, IDWriteFontFile** fontFiles)
    {
        return ((delegate* unmanaged<IDWriteFontFace*, uint*, IDWriteFontFile**, int> )(lpVtbl[4]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetIndex()
    {
        return ((delegate* unmanaged<IDWriteFontFace*, uint> )(lpVtbl[5]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetSimulations"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return ((delegate* unmanaged<IDWriteFontFace*, DWRITE_FONT_SIMULATIONS> )(lpVtbl[6]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.IsSymbolFont"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL IsSymbolFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace*, int> )(lpVtbl[7]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetMetrics(DWRITE_FONT_METRICS* fontFaceMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace*, DWRITE_FONT_METRICS*, void> )(lpVtbl[8]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), fontFaceMetrics);
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetGlyphCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT16")]
    public ushort GetGlyphCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace*, ushort> )(lpVtbl[9]))((IDWriteFontFace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetDesignGlyphMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged<IDWriteFontFace*, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int> )(lpVtbl[10]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetGlyphIndices"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
    {
        return ((delegate* unmanaged<IDWriteFontFace*, uint*, uint, ushort*, int> )(lpVtbl[11]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.TryGetFontTable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, void** tableContext, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFontFace*, uint, void**, uint*, void**, BOOL*, int> )(lpVtbl[12]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.ReleaseFontTable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void ReleaseFontTable(void* tableContext)
    {
        ((delegate* unmanaged<IDWriteFontFace*, void*, void> )(lpVtbl[13]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), tableContext);
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetGlyphRunOutline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGlyphRunOutline(float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return ((delegate* unmanaged<IDWriteFontFace*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, BOOL, BOOL, ID2D1SimplifiedGeometrySink*, int> )(lpVtbl[14]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetRecommendedRenderingMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetRecommendedRenderingMode(float emSize, float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode)
    {
        return ((delegate* unmanaged<IDWriteFontFace*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int> )(lpVtbl[15]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetGdiCompatibleMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics)
    {
        return ((delegate* unmanaged<IDWriteFontFace*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int> )(lpVtbl[16]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
    }

    /// <include file='IDWriteFontFace.xml' path='doc/member[@name="IDWriteFontFace.GetGdiCompatibleGlyphMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged<IDWriteFontFace*, float, float, DWRITE_MATRIX*, BOOL, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int> )(lpVtbl[17]))((IDWriteFontFace*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        DWRITE_FONT_FACE_TYPE GetType();
        [VtblIndex(4)]
        HRESULT GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, IDWriteFontFile** fontFiles);
        [VtblIndex(5)]
        [return: NativeTypeName("UINT32")]
        uint GetIndex();
        [VtblIndex(6)]
        DWRITE_FONT_SIMULATIONS GetSimulations();
        [VtblIndex(7)]
        BOOL IsSymbolFont();
        [VtblIndex(8)]
        void GetMetrics(DWRITE_FONT_METRICS* fontFaceMetrics);
        [VtblIndex(9)]
        [return: NativeTypeName("UINT16")]
        ushort GetGlyphCount();
        [VtblIndex(10)]
        HRESULT GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [Optional] BOOL isSideways);
        [VtblIndex(11)]
        HRESULT GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices);
        [VtblIndex(12)]
        HRESULT TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, void** tableContext, BOOL* exists);
        [VtblIndex(13)]
        void ReleaseFontTable(void* tableContext);
        [VtblIndex(14)]
        HRESULT GetGlyphRunOutline(float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink);
        [VtblIndex(15)]
        HRESULT GetRecommendedRenderingMode(float emSize, float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode);
        [VtblIndex(16)]
        HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics);
        [VtblIndex(17)]
        HRESULT GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [Optional] BOOL isSideways);
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
        [NativeTypeName("DWRITE_FONT_FACE_TYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, DWRITE_FONT_FACE_TYPE> GetType;
        [NativeTypeName("HRESULT (UINT32 *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, IDWriteFontFile**, int> GetFiles;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetIndex;
        [NativeTypeName("DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_SIMULATIONS> GetSimulations;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsSymbolFont;
        [NativeTypeName("void (DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_METRICS*, void> GetMetrics;
        [NativeTypeName("UINT16 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort> GetGlyphCount;
        [NativeTypeName("HRESULT (const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int> GetDesignGlyphMetrics;
        [NativeTypeName("HRESULT (const UINT32 *, UINT32, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint, ushort*, int> GetGlyphIndices;
        [NativeTypeName("HRESULT (UINT32, const void **, UINT32 *, void **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void**, uint*, void**, BOOL*, int> TryGetFontTable;
        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> ReleaseFontTable;
        [NativeTypeName("HRESULT (FLOAT, const UINT16 *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, UINT32, BOOL, BOOL, IDWriteGeometrySink *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, BOOL, BOOL, ID2D1SimplifiedGeometrySink*, int> GetGlyphRunOutline;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int> GetRecommendedRenderingMode;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int> GetGdiCompatibleMetrics;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, DWRITE_MATRIX*, BOOL, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int> GetGdiCompatibleGlyphMetrics;
    }
}