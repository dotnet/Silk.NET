// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3"]/*'/>
[Guid("D37D7598-09BE-4222-A236-2081341CC1F2")]
[NativeTypeName("struct IDWriteFontFace3 : IDWriteFontFace2")]
[NativeInheritance("IDWriteFontFace2")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDWriteFontFace3 : IDWriteFontFace3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint> )(lpVtbl[1]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint> )(lpVtbl[2]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public new DWRITE_FONT_FACE_TYPE GetType()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, DWRITE_FONT_FACE_TYPE> )(lpVtbl[3]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetFiles"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, IDWriteFontFile** fontFiles)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint*, IDWriteFontFile**, int> )(lpVtbl[4]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetIndex"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetIndex()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint> )(lpVtbl[5]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetSimulations"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, DWRITE_FONT_SIMULATIONS> )(lpVtbl[6]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.IsSymbolFont"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL IsSymbolFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, int> )(lpVtbl[7]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetMetrics(DWRITE_FONT_METRICS* fontFaceMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace3*, DWRITE_FONT_METRICS*, void> )(lpVtbl[8]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), fontFaceMetrics);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetGlyphCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT16")]
    public ushort GetGlyphCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, ushort> )(lpVtbl[9]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetDesignGlyphMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int> )(lpVtbl[10]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetGlyphIndices"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint*, uint, ushort*, int> )(lpVtbl[11]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
    }

    /// <inheritdoc cref = "IDWriteFontFace.TryGetFontTable"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, void** tableContext, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint, void**, uint*, void**, BOOL*, int> )(lpVtbl[12]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
    }

    /// <inheritdoc cref = "IDWriteFontFace.ReleaseFontTable"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void ReleaseFontTable(void* tableContext)
    {
        ((delegate* unmanaged<IDWriteFontFace3*, void*, void> )(lpVtbl[13]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), tableContext);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetGlyphRunOutline"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGlyphRunOutline(float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, BOOL, BOOL, ID2D1SimplifiedGeometrySink*, int> )(lpVtbl[14]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetRecommendedRenderingMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetRecommendedRenderingMode(float emSize, float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int> )(lpVtbl[15]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetGdiCompatibleMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int> )(lpVtbl[16]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
    }

    /// <inheritdoc cref = "IDWriteFontFace.GetGdiCompatibleGlyphMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, float, float, DWRITE_MATRIX*, BOOL, ushort*, uint, DWRITE_GLYPH_METRICS*, BOOL, int> )(lpVtbl[17]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace3*, DWRITE_FONT_METRICS1*, void> )(lpVtbl[18]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), fontMetrics);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetGdiCompatibleMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS1* fontMetrics)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS1*, int> )(lpVtbl[19]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetCaretMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void GetCaretMetrics(DWRITE_CARET_METRICS* caretMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace3*, DWRITE_CARET_METRICS*, void> )(lpVtbl[20]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), caretMetrics);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetUnicodeRanges"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint, DWRITE_UNICODE_RANGE*, uint*, int> )(lpVtbl[21]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.IsMonospacedFont"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL IsMonospacedFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, int> )(lpVtbl[22]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetDesignGlyphAdvances"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetDesignGlyphAdvances([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances, [Optional] BOOL isSideways)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint, ushort*, int*, BOOL, int> )(lpVtbl[23]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetGdiCompatibleGlyphAdvances"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, BOOL isSideways, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, float, float, DWRITE_MATRIX*, BOOL, BOOL, uint, ushort*, int*, int> )(lpVtbl[24]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetKerningPairAdjustments"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetKerningPairAdjustments([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint, ushort*, int*, int> )(lpVtbl[25]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.HasKerningPairs"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public BOOL HasKerningPairs()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, int> )(lpVtbl[26]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetRecommendedRenderingMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, DWRITE_RENDERING_MODE* renderingMode)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE*, int> )(lpVtbl[27]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.GetVerticalGlyphVariants"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetVerticalGlyphVariants([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices, [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint, ushort*, ushort*, int> )(lpVtbl[28]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
    }

    /// <inheritdoc cref = "IDWriteFontFace1.HasVerticalGlyphVariants"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public BOOL HasVerticalGlyphVariants()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, int> )(lpVtbl[29]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace2.IsColorFont"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public BOOL IsColorFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, int> )(lpVtbl[30]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace2.GetColorPaletteCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [return: NativeTypeName("UINT32")]
    public uint GetColorPaletteCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint> )(lpVtbl[31]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace2.GetPaletteEntryCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [return: NativeTypeName("UINT32")]
    public uint GetPaletteEntryCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint> )(lpVtbl[32]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFace2.GetPaletteEntries"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetPaletteEntries([NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("UINT32")] uint firstEntryIndex, [NativeTypeName("UINT32")] uint entryCount, [NativeTypeName("DWRITE_COLOR_F *")] DXGI_RGBA* paletteEntries)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint, uint, uint, DXGI_RGBA*, int> )(lpVtbl[33]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
    }

    /// <inheritdoc cref = "IDWriteFontFace2.GetRecommendedRenderingMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, DWRITE_GRID_FIT_MODE*, int> )(lpVtbl[34]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.GetFontFaceReference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetFontFaceReference(IDWriteFontFaceReference** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, IDWriteFontFaceReference**, int> )(lpVtbl[35]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), fontFaceReference);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.GetPanose"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void GetPanose(DWRITE_PANOSE* panose)
    {
        ((delegate* unmanaged<IDWriteFontFace3*, DWRITE_PANOSE*, void> )(lpVtbl[36]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), panose);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.GetWeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public DWRITE_FONT_WEIGHT GetWeight()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, DWRITE_FONT_WEIGHT> )(lpVtbl[37]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.GetStretch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public DWRITE_FONT_STRETCH GetStretch()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, DWRITE_FONT_STRETCH> )(lpVtbl[38]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.GetStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public DWRITE_FONT_STYLE GetStyle()
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, DWRITE_FONT_STYLE> )(lpVtbl[39]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.GetFamilyNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetFamilyNames(IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, IDWriteLocalizedStrings**, int> )(lpVtbl[40]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), names);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.GetFaceNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetFaceNames(IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, IDWriteLocalizedStrings**, int> )(lpVtbl[41]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), names);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.GetInformationalStrings"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, BOOL*, int> )(lpVtbl[42]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.HasCharacter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public BOOL HasCharacter([NativeTypeName("UINT32")] uint unicodeValue)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint, int> )(lpVtbl[43]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), unicodeValue);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.GetRecommendedRenderingMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE1* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE1*, DWRITE_GRID_FIT_MODE*, int> )(lpVtbl[44]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.IsCharacterLocal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public BOOL IsCharacterLocal([NativeTypeName("UINT32")] uint unicodeValue)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, uint, int> )(lpVtbl[45]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), unicodeValue);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.IsGlyphLocal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public BOOL IsGlyphLocal([NativeTypeName("UINT16")] ushort glyphId)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, ushort, int> )(lpVtbl[46]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), glyphId);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.AreCharactersLocal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT AreCharactersLocal([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount, BOOL enqueueIfNotLocal, BOOL* isLocal)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, ushort*, uint, BOOL, BOOL*, int> )(lpVtbl[47]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), characters, characterCount, enqueueIfNotLocal, isLocal);
    }

    /// <include file='IDWriteFontFace3.xml' path='doc/member[@name="IDWriteFontFace3.AreGlyphsLocal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT AreGlyphsLocal([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, BOOL enqueueIfNotLocal, BOOL* isLocal)
    {
        return ((delegate* unmanaged<IDWriteFontFace3*, ushort*, uint, BOOL, BOOL*, int> )(lpVtbl[48]))((IDWriteFontFace3*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
    }

    public interface Interface : IDWriteFontFace2.Interface
    {
        [VtblIndex(35)]
        HRESULT GetFontFaceReference(IDWriteFontFaceReference** fontFaceReference);
        [VtblIndex(36)]
        void GetPanose(DWRITE_PANOSE* panose);
        [VtblIndex(37)]
        DWRITE_FONT_WEIGHT GetWeight();
        [VtblIndex(38)]
        DWRITE_FONT_STRETCH GetStretch();
        [VtblIndex(39)]
        DWRITE_FONT_STYLE GetStyle();
        [VtblIndex(40)]
        HRESULT GetFamilyNames(IDWriteLocalizedStrings** names);
        [VtblIndex(41)]
        HRESULT GetFaceNames(IDWriteLocalizedStrings** names);
        [VtblIndex(42)]
        HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists);
        [VtblIndex(43)]
        BOOL HasCharacter([NativeTypeName("UINT32")] uint unicodeValue);
        [VtblIndex(44)]
        HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE1* renderingMode, DWRITE_GRID_FIT_MODE* gridFitMode);
        [VtblIndex(45)]
        BOOL IsCharacterLocal([NativeTypeName("UINT32")] uint unicodeValue);
        [VtblIndex(46)]
        BOOL IsGlyphLocal([NativeTypeName("UINT16")] ushort glyphId);
        [VtblIndex(47)]
        HRESULT AreCharactersLocal([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount, BOOL enqueueIfNotLocal, BOOL* isLocal);
        [VtblIndex(48)]
        HRESULT AreGlyphsLocal([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, BOOL enqueueIfNotLocal, BOOL* isLocal);
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
        [NativeTypeName("HRESULT (IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFaceReference**, int> GetFontFaceReference;
        [NativeTypeName("void (DWRITE_PANOSE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_PANOSE*, void> GetPanose;
        [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_WEIGHT> GetWeight;
        [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STRETCH> GetStretch;
        [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STYLE> GetStyle;
        [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteLocalizedStrings**, int> GetFamilyNames;
        [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteLocalizedStrings**, int> GetFaceNames;
        [NativeTypeName("HRESULT (DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, BOOL*, int> GetInformationalStrings;
        [NativeTypeName("BOOL (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> HasCharacter;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE1 *, DWRITE_GRID_FIT_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, DWRITE_MATRIX*, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE1*, DWRITE_GRID_FIT_MODE*, int> GetRecommendedRenderingMode3;
        [NativeTypeName("BOOL (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> IsCharacterLocal;
        [NativeTypeName("BOOL (UINT16) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> IsGlyphLocal;
        [NativeTypeName("HRESULT (const WCHAR *, UINT32, BOOL, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, BOOL, BOOL*, int> AreCharactersLocal;
        [NativeTypeName("HRESULT (const UINT16 *, UINT32, BOOL, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, BOOL, BOOL*, int> AreGlyphsLocal;
    }
}