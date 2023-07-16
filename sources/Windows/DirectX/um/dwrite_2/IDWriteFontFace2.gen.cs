// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteFontFace2.xml' path='doc/member[@name="IDWriteFontFace2"]/*'/>
[Guid("D8B768FF-64BC-4E66-982B-EC8E87F693F7")]
[NativeTypeName("struct IDWriteFontFace2 : IDWriteFontFace1")]
[NativeInheritance("IDWriteFontFace1")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDWriteFontFace2 : IDWriteFontFace2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint> )(lpVtbl[1]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint> )(lpVtbl[2]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public new DWRITE_FONT_FACE_TYPE GetType()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, DWRITE_FONT_FACE_TYPE> )(lpVtbl[3]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetFiles"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, IDWriteFontFile** fontFiles)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint*, IDWriteFontFile**, int> )(lpVtbl[4]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetIndex"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetIndex()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint> )(lpVtbl[5]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetSimulations"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, DWRITE_FONT_SIMULATIONS> )(lpVtbl[6]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.IsSymbolFont"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL IsSymbolFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, int> )(lpVtbl[7]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetMetrics(DWRITE_FONT_METRICS* fontFaceMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace2*, DWRITE_FONT_METRICS*, void> )(lpVtbl[8]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), fontFaceMetrics);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetGlyphCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT16")]
    public ushort GetGlyphCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, ushort> )(lpVtbl[9]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetDesignGlyphMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int> )(lpVtbl[10]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetGlyphIndices"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint*, uint, ushort*, int> )(lpVtbl[11]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
    }

    /// <inheritdoc cref = "IDWriteFontFace.TryGetFontTable"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, void** tableContext, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint, void**, uint*, void**, BOOL*, int> )(lpVtbl[12]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
    }

    /// <inheritdoc cref = "IDWriteFontFace.ReleaseFontTable"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void ReleaseFontTable(void* tableContext)
    {
        ((delegate* unmanaged<IDWriteFontFace2*, void*, void> )(lpVtbl[13]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), tableContext);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetGlyphRunOutline"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGlyphRunOutline(float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, BOOL, BOOL, ID2D1SimplifiedGeometrySink*, int> )(lpVtbl[14]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetRecommendedRenderingMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetRecommendedRenderingMode(float emSize, float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int> )(lpVtbl[15]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetGdiCompatibleMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int> )(lpVtbl[16]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetGdiCompatibleGlyphMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, float, float, DWRITE_MATRIX*, BOOL, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int> )(lpVtbl[17]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace2*, DWRITE_FONT_METRICS1*, void> )(lpVtbl[18]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), fontMetrics);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetGdiCompatibleMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS1* fontMetrics)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS1*, int> )(lpVtbl[19]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetCaretMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void GetCaretMetrics(DWRITE_CARET_METRICS* caretMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace2*, DWRITE_CARET_METRICS*, void> )(lpVtbl[20]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), caretMetrics);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetUnicodeRanges"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint, DWRITE_UNICODE_RANGE*, uint*, int> )(lpVtbl[21]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.IsMonospacedFont"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL IsMonospacedFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, int> )(lpVtbl[22]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetDesignGlyphAdvances"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetDesignGlyphAdvances([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint, ushort*, int*, BOOL, int> )(lpVtbl[23]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetGdiCompatibleGlyphAdvances"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, BOOL isSideways, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, float, float, DWRITE_MATRIX*, BOOL, BOOL, uint, ushort*, int*, int> )(lpVtbl[24]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetKerningPairAdjustments"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetKerningPairAdjustments([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint, ushort*, int*, int> )(lpVtbl[25]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.HasKerningPairs"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public BOOL HasKerningPairs()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, int> )(lpVtbl[26]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetRecommendedRenderingMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, DWRITE_RENDERING_MODE* renderingMode)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE*, int> )(lpVtbl[27]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetVerticalGlyphVariants"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetVerticalGlyphVariants([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices, [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint, ushort*, ushort*, int> )(lpVtbl[28]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.HasVerticalGlyphVariants"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public BOOL HasVerticalGlyphVariants()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, int> )(lpVtbl[29]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace2.xml' path='doc/member[@name="IDWriteFontFace2.IsColorFont"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public BOOL IsColorFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, int> )(lpVtbl[30]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace2.xml' path='doc/member[@name="IDWriteFontFace2.GetColorPaletteCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [return: NativeTypeName("UINT32")]
    public uint GetColorPaletteCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint> )(lpVtbl[31]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace2.xml' path='doc/member[@name="IDWriteFontFace2.GetPaletteEntryCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [return: NativeTypeName("UINT32")]
    public uint GetPaletteEntryCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint> )(lpVtbl[32]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace2.xml' path='doc/member[@name="IDWriteFontFace2.GetPaletteEntries"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetPaletteEntries([NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("UINT32")] uint firstEntryIndex, [NativeTypeName("UINT32")] uint entryCount, [NativeTypeName("DWRITE_COLOR_F *")] DXGI_RGBA* paletteEntries)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, uint, uint, uint, DXGI_RGBA*, int> )(lpVtbl[33]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
    }

    /// <include file='IDWriteFontFace2.xml' path='doc/member[@name="IDWriteFontFace2.GetRecommendedRenderingMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode)
    {
        return ((delegate* unmanaged<IDWriteFontFace2*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, DWRITE_GRID_FIT_MODE*, int> )(lpVtbl[34]))((IDWriteFontFace2*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
    }

    public interface Interface : IDWriteFontFace1.Interface
    {
        [VtblIndex(30)]
        BOOL IsColorFont();
        [VtblIndex(31)]
        [return: NativeTypeName("UINT32")]
        uint GetColorPaletteCount();
        [VtblIndex(32)]
        [return: NativeTypeName("UINT32")]
        uint GetPaletteEntryCount();
        [VtblIndex(33)]
        HRESULT GetPaletteEntries([NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("UINT32")] uint firstEntryIndex, [NativeTypeName("UINT32")] uint entryCount, [NativeTypeName("DWRITE_COLOR_F *")] DXGI_RGBA* paletteEntries);
        [VtblIndex(34)]
        HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode);
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
        [NativeTypeName("void (DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_METRICS1*, void> GetMetrics1;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS1*, int> GetGdiCompatibleMetrics1;
        [NativeTypeName("void (DWRITE_CARET_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_CARET_METRICS*, void> GetCaretMetrics;
        [NativeTypeName("HRESULT (UINT32, DWRITE_UNICODE_RANGE *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_UNICODE_RANGE*, uint*, int> GetUnicodeRanges;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsMonospacedFont;
        [NativeTypeName("HRESULT (UINT32, const UINT16 *, INT32 *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int*, BOOL, int> GetDesignGlyphAdvances;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, BOOL, UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, DWRITE_MATRIX*, BOOL, BOOL, uint, ushort*, int*, int> GetGdiCompatibleGlyphAdvances;
        [NativeTypeName("HRESULT (UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int*, int> GetKerningPairAdjustments;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasKerningPairs;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE*, int> GetRecommendedRenderingMode1;
        [NativeTypeName("HRESULT (UINT32, const UINT16 *, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, ushort*, int> GetVerticalGlyphVariants;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasVerticalGlyphVariants;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsColorFont;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetColorPaletteCount;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetPaletteEntryCount;
        [NativeTypeName("HRESULT (UINT32, UINT32, UINT32, DWRITE_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, DXGI_RGBA*, int> GetPaletteEntries;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE *, DWRITE_GRID_FIT_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, DWRITE_GRID_FIT_MODE*, int> GetRecommendedRenderingMode2;
    }
}