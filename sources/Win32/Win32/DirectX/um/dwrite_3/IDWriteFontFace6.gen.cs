// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("C4B1FE1B-6E84-47D5-B54C-A597981B06AD")]
[NativeTypeName("struct IDWriteFontFace6 : IDWriteFontFace5")]
[NativeInheritance("IDWriteFontFace5")]
public unsafe partial struct IDWriteFontFace6 : IDWriteFontFace6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace6));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFace6, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontFace6, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public new DWRITE_FONT_FACE_TYPE GetType()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, DWRITE_FONT_FACE_TYPE>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFiles(
        [NativeTypeName("UINT32 *")] uint* numberOfFiles,
        IDWriteFontFile* fontFiles
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, uint*, IDWriteFontFile*, int>)((*lpVtbl)[4])
        )(this, numberOfFiles, fontFiles);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetIndex()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, uint>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, DWRITE_FONT_SIMULATIONS>)((*lpVtbl)[6]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL IsSymbolFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetMetrics(DWRITE_FONT_METRICS* fontFaceMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace6, DWRITE_FONT_METRICS*, void>)((*lpVtbl)[8]))(
            this,
            fontFaceMetrics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT16")]
    public ushort GetGlyphCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, ushort>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDesignGlyphMetrics(
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("UINT32")] uint glyphCount,
        DWRITE_GLYPH_METRICS* glyphMetrics,
        [Optional] BOOL isSideways
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                ushort*,
                uint,
                DWRITE_GLYPH_METRICS*,
                BOOL,
                int>)((*lpVtbl)[10])
        )(this, glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGlyphIndices(
        [NativeTypeName("const UINT32 *")] uint* codePoints,
        [NativeTypeName("UINT32")] uint codePointCount,
        [NativeTypeName("UINT16 *")] ushort* glyphIndices
    )
    {
        return ((delegate* unmanaged<IDWriteFontFace6, uint*, uint, ushort*, int>)((*lpVtbl)[11]))(
            this,
            codePoints,
            codePointCount,
            glyphIndices
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT TryGetFontTable(
        [NativeTypeName("UINT32")] uint openTypeTableTag,
        [NativeTypeName("const void **")] void** tableData,
        [NativeTypeName("UINT32 *")] uint* tableSize,
        void** tableContext,
        BOOL* exists
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, uint, void**, uint*, void**, BOOL*, int>)(
                (*lpVtbl)[12]
            )
        )(this, openTypeTableTag, tableData, tableSize, tableContext, exists);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void ReleaseFontTable(void* tableContext)
    {
        ((delegate* unmanaged<IDWriteFontFace6, void*, void>)((*lpVtbl)[13]))(this, tableContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGlyphRunOutline(
        float emSize,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("const FLOAT *")] float* glyphAdvances,
        [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets,
        [NativeTypeName("UINT32")] uint glyphCount,
        BOOL isSideways,
        BOOL isRightToLeft,
        [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink geometrySink
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                float,
                ushort*,
                float*,
                DWRITE_GLYPH_OFFSET*,
                uint,
                BOOL,
                BOOL,
                ID2D1SimplifiedGeometrySink,
                int>)((*lpVtbl)[14])
        )(
            this,
            emSize,
            glyphIndices,
            glyphAdvances,
            glyphOffsets,
            glyphCount,
            isSideways,
            isRightToLeft,
            geometrySink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetRecommendedRenderingMode(
        float emSize,
        float pixelsPerDip,
        DWRITE_MEASURING_MODE measuringMode,
        IDWriteRenderingParams renderingParams,
        DWRITE_RENDERING_MODE* renderingMode
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                float,
                float,
                DWRITE_MEASURING_MODE,
                IDWriteRenderingParams,
                DWRITE_RENDERING_MODE*,
                int>)((*lpVtbl)[15])
        )(this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetGdiCompatibleMetrics(
        float emSize,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        DWRITE_FONT_METRICS* fontFaceMetrics
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                float,
                float,
                DWRITE_MATRIX*,
                DWRITE_FONT_METRICS*,
                int>)((*lpVtbl)[16])
        )(this, emSize, pixelsPerDip, transform, fontFaceMetrics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetGdiCompatibleGlyphMetrics(
        float emSize,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        BOOL useGdiNatural,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("UINT32")] uint glyphCount,
        DWRITE_GLYPH_METRICS* glyphMetrics,
        [Optional] BOOL isSideways
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                float,
                float,
                DWRITE_MATRIX*,
                BOOL,
                ushort*,
                uint,
                DWRITE_GLYPH_METRICS*,
                BOOL,
                int>)((*lpVtbl)[17])
        )(
            this,
            emSize,
            pixelsPerDip,
            transform,
            useGdiNatural,
            glyphIndices,
            glyphCount,
            glyphMetrics,
            isSideways
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace6, DWRITE_FONT_METRICS1*, void>)((*lpVtbl)[18]))(
            this,
            fontMetrics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetGdiCompatibleMetrics(
        float emSize,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        DWRITE_FONT_METRICS1* fontMetrics
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                float,
                float,
                DWRITE_MATRIX*,
                DWRITE_FONT_METRICS1*,
                int>)((*lpVtbl)[19])
        )(this, emSize, pixelsPerDip, transform, fontMetrics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void GetCaretMetrics(DWRITE_CARET_METRICS* caretMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace6, DWRITE_CARET_METRICS*, void>)((*lpVtbl)[20]))(
            this,
            caretMetrics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetUnicodeRanges(
        [NativeTypeName("UINT32")] uint maxRangeCount,
        DWRITE_UNICODE_RANGE* unicodeRanges,
        [NativeTypeName("UINT32 *")] uint* actualRangeCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, uint, DWRITE_UNICODE_RANGE*, uint*, int>)(
                (*lpVtbl)[21]
            )
        )(this, maxRangeCount, unicodeRanges, actualRangeCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL IsMonospacedFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, int>)((*lpVtbl)[22]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetDesignGlyphAdvances(
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("INT32 *")] int* glyphAdvances,
        [Optional] BOOL isSideways
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, uint, ushort*, int*, BOOL, int>)((*lpVtbl)[23])
        )(this, glyphCount, glyphIndices, glyphAdvances, isSideways);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetGdiCompatibleGlyphAdvances(
        float emSize,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        BOOL useGdiNatural,
        BOOL isSideways,
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("INT32 *")] int* glyphAdvances
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                float,
                float,
                DWRITE_MATRIX*,
                BOOL,
                BOOL,
                uint,
                ushort*,
                int*,
                int>)((*lpVtbl)[24])
        )(
            this,
            emSize,
            pixelsPerDip,
            transform,
            useGdiNatural,
            isSideways,
            glyphCount,
            glyphIndices,
            glyphAdvances
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetKerningPairAdjustments(
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments
    )
    {
        return ((delegate* unmanaged<IDWriteFontFace6, uint, ushort*, int*, int>)((*lpVtbl)[25]))(
            this,
            glyphCount,
            glyphIndices,
            glyphAdvanceAdjustments
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public BOOL HasKerningPairs()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, int>)((*lpVtbl)[26]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetRecommendedRenderingMode(
        float fontEmSize,
        float dpiX,
        float dpiY,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        BOOL isSideways,
        DWRITE_OUTLINE_THRESHOLD outlineThreshold,
        DWRITE_MEASURING_MODE measuringMode,
        DWRITE_RENDERING_MODE* renderingMode
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                float,
                float,
                float,
                DWRITE_MATRIX*,
                BOOL,
                DWRITE_OUTLINE_THRESHOLD,
                DWRITE_MEASURING_MODE,
                DWRITE_RENDERING_MODE*,
                int>)((*lpVtbl)[27])
        )(
            this,
            fontEmSize,
            dpiX,
            dpiY,
            transform,
            isSideways,
            outlineThreshold,
            measuringMode,
            renderingMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetVerticalGlyphVariants(
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices,
        [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, uint, ushort*, ushort*, int>)((*lpVtbl)[28])
        )(this, glyphCount, nominalGlyphIndices, verticalGlyphIndices);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public BOOL HasVerticalGlyphVariants()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, int>)((*lpVtbl)[29]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public BOOL IsColorFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, int>)((*lpVtbl)[30]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    [return: NativeTypeName("UINT32")]
    public uint GetColorPaletteCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, uint>)((*lpVtbl)[31]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    [return: NativeTypeName("UINT32")]
    public uint GetPaletteEntryCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, uint>)((*lpVtbl)[32]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetPaletteEntries(
        [NativeTypeName("UINT32")] uint colorPaletteIndex,
        [NativeTypeName("UINT32")] uint firstEntryIndex,
        [NativeTypeName("UINT32")] uint entryCount,
        [NativeTypeName("DWRITE_COLOR_F *")] DXGI_RGBA* paletteEntries
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, uint, uint, uint, DXGI_RGBA*, int>)(
                (*lpVtbl)[33]
            )
        )(this, colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetRecommendedRenderingMode(
        float fontEmSize,
        float dpiX,
        float dpiY,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        BOOL isSideways,
        DWRITE_OUTLINE_THRESHOLD outlineThreshold,
        DWRITE_MEASURING_MODE measuringMode,
        IDWriteRenderingParams renderingParams,
        DWRITE_RENDERING_MODE* renderingMode,
        DWRITE_GRID_FIT_MODE* gridFitMode
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                float,
                float,
                float,
                DWRITE_MATRIX*,
                BOOL,
                DWRITE_OUTLINE_THRESHOLD,
                DWRITE_MEASURING_MODE,
                IDWriteRenderingParams,
                DWRITE_RENDERING_MODE*,
                DWRITE_GRID_FIT_MODE*,
                int>)((*lpVtbl)[34])
        )(
            this,
            fontEmSize,
            dpiX,
            dpiY,
            transform,
            isSideways,
            outlineThreshold,
            measuringMode,
            renderingParams,
            renderingMode,
            gridFitMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetFontFaceReference(IDWriteFontFaceReference* fontFaceReference)
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, IDWriteFontFaceReference*, int>)((*lpVtbl)[35])
        )(this, fontFaceReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void GetPanose(DWRITE_PANOSE* panose)
    {
        ((delegate* unmanaged<IDWriteFontFace6, DWRITE_PANOSE*, void>)((*lpVtbl)[36]))(
            this,
            panose
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public DWRITE_FONT_WEIGHT GetWeight()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, DWRITE_FONT_WEIGHT>)((*lpVtbl)[37]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public DWRITE_FONT_STRETCH GetStretch()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, DWRITE_FONT_STRETCH>)((*lpVtbl)[38]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public DWRITE_FONT_STYLE GetStyle()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, DWRITE_FONT_STYLE>)((*lpVtbl)[39]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetFamilyNames(IDWriteLocalizedStrings* names)
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, IDWriteLocalizedStrings*, int>)((*lpVtbl)[40])
        )(this, names);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetFaceNames(IDWriteLocalizedStrings* names)
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, IDWriteLocalizedStrings*, int>)((*lpVtbl)[41])
        )(this, names);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT GetInformationalStrings(
        DWRITE_INFORMATIONAL_STRING_ID informationalStringID,
        IDWriteLocalizedStrings* informationalStrings,
        BOOL* exists
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                DWRITE_INFORMATIONAL_STRING_ID,
                IDWriteLocalizedStrings*,
                BOOL*,
                int>)((*lpVtbl)[42])
        )(this, informationalStringID, informationalStrings, exists);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public BOOL HasCharacter([NativeTypeName("UINT32")] uint unicodeValue)
    {
        return ((delegate* unmanaged<IDWriteFontFace6, uint, int>)((*lpVtbl)[43]))(
            this,
            unicodeValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT GetRecommendedRenderingMode(
        float fontEmSize,
        float dpiX,
        float dpiY,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        BOOL isSideways,
        DWRITE_OUTLINE_THRESHOLD outlineThreshold,
        DWRITE_MEASURING_MODE measuringMode,
        IDWriteRenderingParams renderingParams,
        DWRITE_RENDERING_MODE1* renderingMode,
        DWRITE_GRID_FIT_MODE* gridFitMode
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                float,
                float,
                float,
                DWRITE_MATRIX*,
                BOOL,
                DWRITE_OUTLINE_THRESHOLD,
                DWRITE_MEASURING_MODE,
                IDWriteRenderingParams,
                DWRITE_RENDERING_MODE1*,
                DWRITE_GRID_FIT_MODE*,
                int>)((*lpVtbl)[44])
        )(
            this,
            fontEmSize,
            dpiX,
            dpiY,
            transform,
            isSideways,
            outlineThreshold,
            measuringMode,
            renderingParams,
            renderingMode,
            gridFitMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public BOOL IsCharacterLocal([NativeTypeName("UINT32")] uint unicodeValue)
    {
        return ((delegate* unmanaged<IDWriteFontFace6, uint, int>)((*lpVtbl)[45]))(
            this,
            unicodeValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public BOOL IsGlyphLocal([NativeTypeName("UINT16")] ushort glyphId)
    {
        return ((delegate* unmanaged<IDWriteFontFace6, ushort, int>)((*lpVtbl)[46]))(this, glyphId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT AreCharactersLocal(
        [NativeTypeName("const WCHAR *")] ushort* characters,
        [NativeTypeName("UINT32")] uint characterCount,
        BOOL enqueueIfNotLocal,
        BOOL* isLocal
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, ushort*, uint, BOOL, BOOL*, int>)((*lpVtbl)[47])
        )(this, characters, characterCount, enqueueIfNotLocal, isLocal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT AreGlyphsLocal(
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("UINT32")] uint glyphCount,
        BOOL enqueueIfNotLocal,
        BOOL* isLocal
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, ushort*, uint, BOOL, BOOL*, int>)((*lpVtbl)[48])
        )(this, glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT GetGlyphImageFormats(
        [NativeTypeName("UINT16")] ushort glyphId,
        [NativeTypeName("UINT32")] uint pixelsPerEmFirst,
        [NativeTypeName("UINT32")] uint pixelsPerEmLast,
        DWRITE_GLYPH_IMAGE_FORMATS* glyphImageFormats
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                ushort,
                uint,
                uint,
                DWRITE_GLYPH_IMAGE_FORMATS*,
                int>)((*lpVtbl)[49])
        )(this, glyphId, pixelsPerEmFirst, pixelsPerEmLast, glyphImageFormats);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public DWRITE_GLYPH_IMAGE_FORMATS GetGlyphImageFormats()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, DWRITE_GLYPH_IMAGE_FORMATS>)((*lpVtbl)[50]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT GetGlyphImageData(
        [NativeTypeName("UINT16")] ushort glyphId,
        [NativeTypeName("UINT32")] uint pixelsPerEm,
        DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat,
        DWRITE_GLYPH_IMAGE_DATA* glyphData,
        void** glyphDataContext
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                ushort,
                uint,
                DWRITE_GLYPH_IMAGE_FORMATS,
                DWRITE_GLYPH_IMAGE_DATA*,
                void**,
                int>)((*lpVtbl)[51])
        )(this, glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public void ReleaseGlyphImageData(void* glyphDataContext)
    {
        ((delegate* unmanaged<IDWriteFontFace6, void*, void>)((*lpVtbl)[52]))(
            this,
            glyphDataContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontAxisValueCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, uint>)((*lpVtbl)[53]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT GetFontAxisValues(
        DWRITE_FONT_AXIS_VALUE* fontAxisValues,
        [NativeTypeName("UINT32")] uint fontAxisValueCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace6, DWRITE_FONT_AXIS_VALUE*, uint, int>)(
                (*lpVtbl)[54]
            )
        )(this, fontAxisValues, fontAxisValueCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public BOOL HasVariations()
    {
        return ((delegate* unmanaged<IDWriteFontFace6, int>)((*lpVtbl)[55]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT GetFontResource(IDWriteFontResource* fontResource)
    {
        return ((delegate* unmanaged<IDWriteFontFace6, IDWriteFontResource*, int>)((*lpVtbl)[56]))(
            this,
            fontResource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public BOOL Equals(IDWriteFontFace fontFace)
    {
        return ((delegate* unmanaged<IDWriteFontFace6, IDWriteFontFace, int>)((*lpVtbl)[57]))(
            this,
            fontFace
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT GetFamilyNames(
        DWRITE_FONT_FAMILY_MODEL fontFamilyModel,
        IDWriteLocalizedStrings* names
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                DWRITE_FONT_FAMILY_MODEL,
                IDWriteLocalizedStrings*,
                int>)((*lpVtbl)[58])
        )(this, fontFamilyModel, names);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT GetFaceNames(
        DWRITE_FONT_FAMILY_MODEL fontFamilyModel,
        IDWriteLocalizedStrings* names
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace6,
                DWRITE_FONT_FAMILY_MODEL,
                IDWriteLocalizedStrings*,
                int>)((*lpVtbl)[59])
        )(this, fontFamilyModel, names);
    }

    public interface Interface : IDWriteFontFace5.Interface
    {
        [VtblIndex(58)]
        HRESULT GetFamilyNames(
            DWRITE_FONT_FAMILY_MODEL fontFamilyModel,
            IDWriteLocalizedStrings* names
        );

        [VtblIndex(59)]
        HRESULT GetFaceNames(
            DWRITE_FONT_FAMILY_MODEL fontFamilyModel,
            IDWriteLocalizedStrings* names
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
            "DWRITE_FONT_FACE_TYPE () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public new delegate* unmanaged<TSelf*, DWRITE_FONT_FACE_TYPE> GetType;

        [NativeTypeName(
            "HRESULT (UINT32 *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, IDWriteFontFile*, int> GetFiles;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetIndex;

        [NativeTypeName(
            "DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_SIMULATIONS> GetSimulations;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsSymbolFont;

        [NativeTypeName(
            "void (DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_METRICS*, void> GetMetrics;

        [NativeTypeName("UINT16 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort> GetGlyphCount;

        [NativeTypeName(
            "HRESULT (const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            DWRITE_GLYPH_METRICS*,
            BOOL,
            int> GetDesignGlyphMetrics;

        [NativeTypeName(
            "HRESULT (const UINT32 *, UINT32, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, uint, ushort*, int> GetGlyphIndices;

        [NativeTypeName(
            "HRESULT (UINT32, const void **, UINT32 *, void **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, void**, uint*, void**, BOOL*, int> TryGetFontTable;

        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> ReleaseFontTable;

        [NativeTypeName(
            "HRESULT (FLOAT, const UINT16 *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, UINT32, BOOL, BOOL, IDWriteGeometrySink *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            ushort*,
            float*,
            DWRITE_GLYPH_OFFSET*,
            uint,
            BOOL,
            BOOL,
            ID2D1SimplifiedGeometrySink,
            int> GetGlyphRunOutline;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            DWRITE_MEASURING_MODE,
            IDWriteRenderingParams,
            DWRITE_RENDERING_MODE*,
            int> GetRecommendedRenderingMode;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            DWRITE_MATRIX*,
            DWRITE_FONT_METRICS*,
            int> GetGdiCompatibleMetrics;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            DWRITE_MATRIX*,
            BOOL,
            ushort*,
            uint,
            DWRITE_GLYPH_METRICS*,
            BOOL,
            int> GetGdiCompatibleGlyphMetrics;

        [NativeTypeName(
            "void (DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_METRICS1*, void> GetMetrics1;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            DWRITE_MATRIX*,
            DWRITE_FONT_METRICS1*,
            int> GetGdiCompatibleMetrics1;

        [NativeTypeName(
            "void (DWRITE_CARET_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_CARET_METRICS*, void> GetCaretMetrics;

        [NativeTypeName(
            "HRESULT (UINT32, DWRITE_UNICODE_RANGE *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DWRITE_UNICODE_RANGE*,
            uint*,
            int> GetUnicodeRanges;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsMonospacedFont;

        [NativeTypeName(
            "HRESULT (UINT32, const UINT16 *, INT32 *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, int*, BOOL, int> GetDesignGlyphAdvances;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, BOOL, UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            DWRITE_MATRIX*,
            BOOL,
            BOOL,
            uint,
            ushort*,
            int*,
            int> GetGdiCompatibleGlyphAdvances;

        [NativeTypeName(
            "HRESULT (UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, int*, int> GetKerningPairAdjustments;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasKerningPairs;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            DWRITE_MATRIX*,
            BOOL,
            DWRITE_OUTLINE_THRESHOLD,
            DWRITE_MEASURING_MODE,
            DWRITE_RENDERING_MODE*,
            int> GetRecommendedRenderingMode1;

        [NativeTypeName(
            "HRESULT (UINT32, const UINT16 *, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, ushort*, int> GetVerticalGlyphVariants;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasVerticalGlyphVariants;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsColorFont;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetColorPaletteCount;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetPaletteEntryCount;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, UINT32, DWRITE_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, uint, DXGI_RGBA*, int> GetPaletteEntries;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE *, DWRITE_GRID_FIT_MODE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            DWRITE_MATRIX*,
            BOOL,
            DWRITE_OUTLINE_THRESHOLD,
            DWRITE_MEASURING_MODE,
            IDWriteRenderingParams,
            DWRITE_RENDERING_MODE*,
            DWRITE_GRID_FIT_MODE*,
            int> GetRecommendedRenderingMode2;

        [NativeTypeName(
            "HRESULT (IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFaceReference*, int> GetFontFaceReference;

        [NativeTypeName("void (DWRITE_PANOSE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_PANOSE*, void> GetPanose;

        [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_WEIGHT> GetWeight;

        [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STRETCH> GetStretch;

        [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STYLE> GetStyle;

        [NativeTypeName(
            "HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteLocalizedStrings*, int> GetFamilyNames;

        [NativeTypeName(
            "HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteLocalizedStrings*, int> GetFaceNames;

        [NativeTypeName(
            "HRESULT (DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_INFORMATIONAL_STRING_ID,
            IDWriteLocalizedStrings*,
            BOOL*,
            int> GetInformationalStrings;

        [NativeTypeName("BOOL (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> HasCharacter;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE1 *, DWRITE_GRID_FIT_MODE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            DWRITE_MATRIX*,
            BOOL,
            DWRITE_OUTLINE_THRESHOLD,
            DWRITE_MEASURING_MODE,
            IDWriteRenderingParams,
            DWRITE_RENDERING_MODE1*,
            DWRITE_GRID_FIT_MODE*,
            int> GetRecommendedRenderingMode3;

        [NativeTypeName("BOOL (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> IsCharacterLocal;

        [NativeTypeName("BOOL (UINT16) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> IsGlyphLocal;

        [NativeTypeName(
            "HRESULT (const WCHAR *, UINT32, BOOL, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, BOOL, BOOL*, int> AreCharactersLocal;

        [NativeTypeName(
            "HRESULT (const UINT16 *, UINT32, BOOL, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, BOOL, BOOL*, int> AreGlyphsLocal;

        [NativeTypeName(
            "HRESULT (UINT16, UINT32, UINT32, DWRITE_GLYPH_IMAGE_FORMATS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort,
            uint,
            uint,
            DWRITE_GLYPH_IMAGE_FORMATS*,
            int> GetGlyphImageFormats;

        [NativeTypeName(
            "DWRITE_GLYPH_IMAGE_FORMATS () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_GLYPH_IMAGE_FORMATS> GetGlyphImageFormats1;

        [NativeTypeName(
            "HRESULT (UINT16, UINT32, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_GLYPH_IMAGE_DATA *, void **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort,
            uint,
            DWRITE_GLYPH_IMAGE_FORMATS,
            DWRITE_GLYPH_IMAGE_DATA*,
            void**,
            int> GetGlyphImageData;

        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> ReleaseGlyphImageData;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontAxisValueCount;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_AXIS_VALUE*, uint, int> GetFontAxisValues;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasVariations;

        [NativeTypeName(
            "HRESULT (IDWriteFontResource **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontResource*, int> GetFontResource;

        [NativeTypeName(
            "BOOL (IDWriteFontFace *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public new delegate* unmanaged<TSelf*, IDWriteFontFace, int> Equals;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_FAMILY_MODEL, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_FAMILY_MODEL,
            IDWriteLocalizedStrings*,
            int> GetFamilyNames1;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_FAMILY_MODEL, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_FAMILY_MODEL,
            IDWriteLocalizedStrings*,
            int> GetFaceNames1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontFace6"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontFace6(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFace5"/> to <see cref = "IDWriteFontFace6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFace5"/> instance to be converted </param>
    public static explicit operator IDWriteFontFace6(Silk.NET.DirectX.IDWriteFontFace5 value)
    {
        return new IDWriteFontFace6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFace6"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFace5"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFace6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFace5(IDWriteFontFace6 value)
    {
        return new Silk.NET.DirectX.IDWriteFontFace5(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFace4"/> to <see cref = "IDWriteFontFace6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFace4"/> instance to be converted </param>
    public static explicit operator IDWriteFontFace6(Silk.NET.DirectX.IDWriteFontFace4 value)
    {
        return new IDWriteFontFace6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFace6"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFace4"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFace6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFace4(IDWriteFontFace6 value)
    {
        return new Silk.NET.DirectX.IDWriteFontFace4(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFace3"/> to <see cref = "IDWriteFontFace6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFace3"/> instance to be converted </param>
    public static explicit operator IDWriteFontFace6(Silk.NET.DirectX.IDWriteFontFace3 value)
    {
        return new IDWriteFontFace6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFace6"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFace3"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFace6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFace3(IDWriteFontFace6 value)
    {
        return new Silk.NET.DirectX.IDWriteFontFace3(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFace2"/> to <see cref = "IDWriteFontFace6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFace2"/> instance to be converted </param>
    public static explicit operator IDWriteFontFace6(Silk.NET.DirectX.IDWriteFontFace2 value)
    {
        return new IDWriteFontFace6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFace6"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFace2"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFace6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFace2(IDWriteFontFace6 value)
    {
        return new Silk.NET.DirectX.IDWriteFontFace2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFace1"/> to <see cref = "IDWriteFontFace6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFace1"/> instance to be converted </param>
    public static explicit operator IDWriteFontFace6(Silk.NET.DirectX.IDWriteFontFace1 value)
    {
        return new IDWriteFontFace6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFace6"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFace1"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFace6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFace1(IDWriteFontFace6 value)
    {
        return new Silk.NET.DirectX.IDWriteFontFace1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFace"/> to <see cref = "IDWriteFontFace6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFace"/> instance to be converted </param>
    public static explicit operator IDWriteFontFace6(Silk.NET.DirectX.IDWriteFontFace value)
    {
        return new IDWriteFontFace6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFace6"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFace"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFace6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFace(IDWriteFontFace6 value)
    {
        return new Silk.NET.DirectX.IDWriteFontFace(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontFace6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontFace6(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontFace6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFace6"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFace6"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontFace6 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
