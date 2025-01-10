// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("553A9FF3-5693-4DF7-B52B-74806F7F2EB9")]
[NativeTypeName("struct IDWriteTextAnalyzer2 : IDWriteTextAnalyzer1")]
[NativeInheritance("IDWriteTextAnalyzer1")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDWriteTextAnalyzer2 : IDWriteTextAnalyzer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextAnalyzer2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteTextAnalyzer2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AnalyzeScript(
        IDWriteTextAnalysisSource analysisSource,
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        IDWriteTextAnalysisSink analysisSink
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                IDWriteTextAnalysisSource,
                uint,
                uint,
                IDWriteTextAnalysisSink,
                int>)((*lpVtbl)[3])
        )(this, analysisSource, textPosition, textLength, analysisSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AnalyzeBidi(
        IDWriteTextAnalysisSource analysisSource,
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        IDWriteTextAnalysisSink analysisSink
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                IDWriteTextAnalysisSource,
                uint,
                uint,
                IDWriteTextAnalysisSink,
                int>)((*lpVtbl)[4])
        )(this, analysisSource, textPosition, textLength, analysisSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AnalyzeNumberSubstitution(
        IDWriteTextAnalysisSource analysisSource,
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        IDWriteTextAnalysisSink analysisSink
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                IDWriteTextAnalysisSource,
                uint,
                uint,
                IDWriteTextAnalysisSink,
                int>)((*lpVtbl)[5])
        )(this, analysisSource, textPosition, textLength, analysisSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AnalyzeLineBreakpoints(
        IDWriteTextAnalysisSource analysisSource,
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        IDWriteTextAnalysisSink analysisSink
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                IDWriteTextAnalysisSource,
                uint,
                uint,
                IDWriteTextAnalysisSink,
                int>)((*lpVtbl)[6])
        )(this, analysisSource, textPosition, textLength, analysisSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetGlyphs(
        [NativeTypeName("const WCHAR *")] ushort* textString,
        [NativeTypeName("UINT32")] uint textLength,
        IDWriteFontFace fontFace,
        BOOL isSideways,
        BOOL isRightToLeft,
        [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis,
        [NativeTypeName("const WCHAR *")] ushort* localeName,
        IDWriteNumberSubstitution numberSubstitution,
        [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")]
            DWRITE_TYPOGRAPHIC_FEATURES** features,
        [NativeTypeName("const UINT32 *")] uint* featureRangeLengths,
        [NativeTypeName("UINT32")] uint featureRanges,
        [NativeTypeName("UINT32")] uint maxGlyphCount,
        [NativeTypeName("UINT16 *")] ushort* clusterMap,
        DWRITE_SHAPING_TEXT_PROPERTIES* textProps,
        [NativeTypeName("UINT16 *")] ushort* glyphIndices,
        DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps,
        [NativeTypeName("UINT32 *")] uint* actualGlyphCount
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                ushort*,
                uint,
                IDWriteFontFace,
                BOOL,
                BOOL,
                DWRITE_SCRIPT_ANALYSIS*,
                ushort*,
                IDWriteNumberSubstitution,
                DWRITE_TYPOGRAPHIC_FEATURES**,
                uint*,
                uint,
                uint,
                ushort*,
                DWRITE_SHAPING_TEXT_PROPERTIES*,
                ushort*,
                DWRITE_SHAPING_GLYPH_PROPERTIES*,
                uint*,
                int>)((*lpVtbl)[7])
        )(
            this,
            textString,
            textLength,
            fontFace,
            isSideways,
            isRightToLeft,
            scriptAnalysis,
            localeName,
            numberSubstitution,
            features,
            featureRangeLengths,
            featureRanges,
            maxGlyphCount,
            clusterMap,
            textProps,
            glyphIndices,
            glyphProps,
            actualGlyphCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetGlyphPlacements(
        [NativeTypeName("const WCHAR *")] ushort* textString,
        [NativeTypeName("const UINT16 *")] ushort* clusterMap,
        DWRITE_SHAPING_TEXT_PROPERTIES* textProps,
        [NativeTypeName("UINT32")] uint textLength,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")]
            DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps,
        [NativeTypeName("UINT32")] uint glyphCount,
        IDWriteFontFace fontFace,
        float fontEmSize,
        BOOL isSideways,
        BOOL isRightToLeft,
        [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis,
        [NativeTypeName("const WCHAR *")] ushort* localeName,
        [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")]
            DWRITE_TYPOGRAPHIC_FEATURES** features,
        [NativeTypeName("const UINT32 *")] uint* featureRangeLengths,
        [NativeTypeName("UINT32")] uint featureRanges,
        float* glyphAdvances,
        DWRITE_GLYPH_OFFSET* glyphOffsets
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                ushort*,
                ushort*,
                DWRITE_SHAPING_TEXT_PROPERTIES*,
                uint,
                ushort*,
                DWRITE_SHAPING_GLYPH_PROPERTIES*,
                uint,
                IDWriteFontFace,
                float,
                BOOL,
                BOOL,
                DWRITE_SCRIPT_ANALYSIS*,
                ushort*,
                DWRITE_TYPOGRAPHIC_FEATURES**,
                uint*,
                uint,
                float*,
                DWRITE_GLYPH_OFFSET*,
                int>)((*lpVtbl)[8])
        )(
            this,
            textString,
            clusterMap,
            textProps,
            textLength,
            glyphIndices,
            glyphProps,
            glyphCount,
            fontFace,
            fontEmSize,
            isSideways,
            isRightToLeft,
            scriptAnalysis,
            localeName,
            features,
            featureRangeLengths,
            featureRanges,
            glyphAdvances,
            glyphOffsets
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetGdiCompatibleGlyphPlacements(
        [NativeTypeName("const WCHAR *")] ushort* textString,
        [NativeTypeName("const UINT16 *")] ushort* clusterMap,
        DWRITE_SHAPING_TEXT_PROPERTIES* textProps,
        [NativeTypeName("UINT32")] uint textLength,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")]
            DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps,
        [NativeTypeName("UINT32")] uint glyphCount,
        IDWriteFontFace fontFace,
        float fontEmSize,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        BOOL useGdiNatural,
        BOOL isSideways,
        BOOL isRightToLeft,
        [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis,
        [NativeTypeName("const WCHAR *")] ushort* localeName,
        [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")]
            DWRITE_TYPOGRAPHIC_FEATURES** features,
        [NativeTypeName("const UINT32 *")] uint* featureRangeLengths,
        [NativeTypeName("UINT32")] uint featureRanges,
        float* glyphAdvances,
        DWRITE_GLYPH_OFFSET* glyphOffsets
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                ushort*,
                ushort*,
                DWRITE_SHAPING_TEXT_PROPERTIES*,
                uint,
                ushort*,
                DWRITE_SHAPING_GLYPH_PROPERTIES*,
                uint,
                IDWriteFontFace,
                float,
                float,
                DWRITE_MATRIX*,
                BOOL,
                BOOL,
                BOOL,
                DWRITE_SCRIPT_ANALYSIS*,
                ushort*,
                DWRITE_TYPOGRAPHIC_FEATURES**,
                uint*,
                uint,
                float*,
                DWRITE_GLYPH_OFFSET*,
                int>)((*lpVtbl)[9])
        )(
            this,
            textString,
            clusterMap,
            textProps,
            textLength,
            glyphIndices,
            glyphProps,
            glyphCount,
            fontFace,
            fontEmSize,
            pixelsPerDip,
            transform,
            useGdiNatural,
            isSideways,
            isRightToLeft,
            scriptAnalysis,
            localeName,
            features,
            featureRangeLengths,
            featureRanges,
            glyphAdvances,
            glyphOffsets
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ApplyCharacterSpacing(
        float leadingSpacing,
        float trailingSpacing,
        float minimumAdvanceWidth,
        [NativeTypeName("UINT32")] uint textLength,
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const UINT16 *")] ushort* clusterMap,
        [NativeTypeName("const FLOAT *")] float* glyphAdvances,
        [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets,
        [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")]
            DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties,
        float* modifiedGlyphAdvances,
        DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                float,
                float,
                float,
                uint,
                uint,
                ushort*,
                float*,
                DWRITE_GLYPH_OFFSET*,
                DWRITE_SHAPING_GLYPH_PROPERTIES*,
                float*,
                DWRITE_GLYPH_OFFSET*,
                int>)((*lpVtbl)[10])
        )(
            this,
            leadingSpacing,
            trailingSpacing,
            minimumAdvanceWidth,
            textLength,
            glyphCount,
            clusterMap,
            glyphAdvances,
            glyphOffsets,
            glyphProperties,
            modifiedGlyphAdvances,
            modifiedGlyphOffsets
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetBaseline(
        IDWriteFontFace fontFace,
        DWRITE_BASELINE baseline,
        BOOL isVertical,
        BOOL isSimulationAllowed,
        DWRITE_SCRIPT_ANALYSIS scriptAnalysis,
        [NativeTypeName("const WCHAR *")] ushort* localeName,
        [NativeTypeName("INT32 *")] int* baselineCoordinate,
        BOOL* exists
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                IDWriteFontFace,
                DWRITE_BASELINE,
                BOOL,
                BOOL,
                DWRITE_SCRIPT_ANALYSIS,
                ushort*,
                int*,
                BOOL*,
                int>)((*lpVtbl)[11])
        )(
            this,
            fontFace,
            baseline,
            isVertical,
            isSimulationAllowed,
            scriptAnalysis,
            localeName,
            baselineCoordinate,
            exists
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AnalyzeVerticalGlyphOrientation(
        IDWriteTextAnalysisSource1 analysisSource,
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        IDWriteTextAnalysisSink1 analysisSink
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                IDWriteTextAnalysisSource1,
                uint,
                uint,
                IDWriteTextAnalysisSink1,
                int>)((*lpVtbl)[12])
        )(this, analysisSource, textPosition, textLength, analysisSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGlyphOrientationTransform(
        DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle,
        BOOL isSideways,
        DWRITE_MATRIX* transform
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                DWRITE_GLYPH_ORIENTATION_ANGLE,
                BOOL,
                DWRITE_MATRIX*,
                int>)((*lpVtbl)[13])
        )(this, glyphOrientationAngle, isSideways, transform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetScriptProperties(
        DWRITE_SCRIPT_ANALYSIS scriptAnalysis,
        DWRITE_SCRIPT_PROPERTIES* scriptProperties
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                DWRITE_SCRIPT_ANALYSIS,
                DWRITE_SCRIPT_PROPERTIES*,
                int>)((*lpVtbl)[14])
        )(this, scriptAnalysis, scriptProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTextComplexity(
        [NativeTypeName("const WCHAR *")] ushort* textString,
        [NativeTypeName("UINT32")] uint textLength,
        IDWriteFontFace fontFace,
        BOOL* isTextSimple,
        [NativeTypeName("UINT32 *")] uint* textLengthRead,
        [NativeTypeName("UINT16 *")] ushort* glyphIndices
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                ushort*,
                uint,
                IDWriteFontFace,
                BOOL*,
                uint*,
                ushort*,
                int>)((*lpVtbl)[15])
        )(this, textString, textLength, fontFace, isTextSimple, textLengthRead, glyphIndices);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetJustificationOpportunities(
        IDWriteFontFace fontFace,
        float fontEmSize,
        DWRITE_SCRIPT_ANALYSIS scriptAnalysis,
        [NativeTypeName("UINT32")] uint textLength,
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const WCHAR *")] ushort* textString,
        [NativeTypeName("const UINT16 *")] ushort* clusterMap,
        [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")]
            DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties,
        DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                IDWriteFontFace,
                float,
                DWRITE_SCRIPT_ANALYSIS,
                uint,
                uint,
                ushort*,
                ushort*,
                DWRITE_SHAPING_GLYPH_PROPERTIES*,
                DWRITE_JUSTIFICATION_OPPORTUNITY*,
                int>)((*lpVtbl)[16])
        )(
            this,
            fontFace,
            fontEmSize,
            scriptAnalysis,
            textLength,
            glyphCount,
            textString,
            clusterMap,
            glyphProperties,
            justificationOpportunities
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT JustifyGlyphAdvances(
        float lineWidth,
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const DWRITE_JUSTIFICATION_OPPORTUNITY *")]
            DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities,
        [NativeTypeName("const FLOAT *")] float* glyphAdvances,
        [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets,
        float* justifiedGlyphAdvances,
        DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                float,
                uint,
                DWRITE_JUSTIFICATION_OPPORTUNITY*,
                float*,
                DWRITE_GLYPH_OFFSET*,
                float*,
                DWRITE_GLYPH_OFFSET*,
                int>)((*lpVtbl)[17])
        )(
            this,
            lineWidth,
            glyphCount,
            justificationOpportunities,
            glyphAdvances,
            glyphOffsets,
            justifiedGlyphAdvances,
            justifiedGlyphOffsets
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetJustifiedGlyphs(
        IDWriteFontFace fontFace,
        float fontEmSize,
        DWRITE_SCRIPT_ANALYSIS scriptAnalysis,
        [NativeTypeName("UINT32")] uint textLength,
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("UINT32")] uint maxGlyphCount,
        [NativeTypeName("const UINT16 *")] ushort* clusterMap,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("const FLOAT *")] float* glyphAdvances,
        [NativeTypeName("const FLOAT *")] float* justifiedGlyphAdvances,
        [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets,
        [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")]
            DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties,
        [NativeTypeName("UINT32 *")] uint* actualGlyphCount,
        [NativeTypeName("UINT16 *")] ushort* modifiedClusterMap,
        [NativeTypeName("UINT16 *")] ushort* modifiedGlyphIndices,
        float* modifiedGlyphAdvances,
        DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                IDWriteFontFace,
                float,
                DWRITE_SCRIPT_ANALYSIS,
                uint,
                uint,
                uint,
                ushort*,
                ushort*,
                float*,
                float*,
                DWRITE_GLYPH_OFFSET*,
                DWRITE_SHAPING_GLYPH_PROPERTIES*,
                uint*,
                ushort*,
                ushort*,
                float*,
                DWRITE_GLYPH_OFFSET*,
                int>)((*lpVtbl)[18])
        )(
            this,
            fontFace,
            fontEmSize,
            scriptAnalysis,
            textLength,
            glyphCount,
            maxGlyphCount,
            clusterMap,
            glyphIndices,
            glyphAdvances,
            justifiedGlyphAdvances,
            justifiedGlyphOffsets,
            glyphProperties,
            actualGlyphCount,
            modifiedClusterMap,
            modifiedGlyphIndices,
            modifiedGlyphAdvances,
            modifiedGlyphOffsets
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetGlyphOrientationTransform(
        DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle,
        BOOL isSideways,
        float originX,
        float originY,
        DWRITE_MATRIX* transform
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                DWRITE_GLYPH_ORIENTATION_ANGLE,
                BOOL,
                float,
                float,
                DWRITE_MATRIX*,
                int>)((*lpVtbl)[19])
        )(this, glyphOrientationAngle, isSideways, originX, originY, transform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetTypographicFeatures(
        IDWriteFontFace fontFace,
        DWRITE_SCRIPT_ANALYSIS scriptAnalysis,
        [NativeTypeName("const WCHAR *")] ushort* localeName,
        [NativeTypeName("UINT32")] uint maxTagCount,
        [NativeTypeName("UINT32 *")] uint* actualTagCount,
        DWRITE_FONT_FEATURE_TAG* tags
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                IDWriteFontFace,
                DWRITE_SCRIPT_ANALYSIS,
                ushort*,
                uint,
                uint*,
                DWRITE_FONT_FEATURE_TAG*,
                int>)((*lpVtbl)[20])
        )(this, fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CheckTypographicFeature(
        IDWriteFontFace fontFace,
        DWRITE_SCRIPT_ANALYSIS scriptAnalysis,
        [NativeTypeName("const WCHAR *")] ushort* localeName,
        DWRITE_FONT_FEATURE_TAG featureTag,
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("UINT8 *")] byte* featureApplies
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalyzer2,
                IDWriteFontFace,
                DWRITE_SCRIPT_ANALYSIS,
                ushort*,
                DWRITE_FONT_FEATURE_TAG,
                uint,
                ushort*,
                byte*,
                int>)((*lpVtbl)[21])
        )(
            this,
            fontFace,
            scriptAnalysis,
            localeName,
            featureTag,
            glyphCount,
            glyphIndices,
            featureApplies
        );
    }

    public interface Interface : IDWriteTextAnalyzer1.Interface
    {
        [VtblIndex(19)]
        HRESULT GetGlyphOrientationTransform(
            DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle,
            BOOL isSideways,
            float originX,
            float originY,
            DWRITE_MATRIX* transform
        );

        [VtblIndex(20)]
        HRESULT GetTypographicFeatures(
            IDWriteFontFace fontFace,
            DWRITE_SCRIPT_ANALYSIS scriptAnalysis,
            [NativeTypeName("const WCHAR *")] ushort* localeName,
            [NativeTypeName("UINT32")] uint maxTagCount,
            [NativeTypeName("UINT32 *")] uint* actualTagCount,
            DWRITE_FONT_FEATURE_TAG* tags
        );

        [VtblIndex(21)]
        HRESULT CheckTypographicFeature(
            IDWriteFontFace fontFace,
            DWRITE_SCRIPT_ANALYSIS scriptAnalysis,
            [NativeTypeName("const WCHAR *")] ushort* localeName,
            DWRITE_FONT_FEATURE_TAG featureTag,
            [NativeTypeName("UINT32")] uint glyphCount,
            [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
            [NativeTypeName("UINT8 *")] byte* featureApplies
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
            "HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteTextAnalysisSource,
            uint,
            uint,
            IDWriteTextAnalysisSink,
            int> AnalyzeScript;

        [NativeTypeName(
            "HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteTextAnalysisSource,
            uint,
            uint,
            IDWriteTextAnalysisSink,
            int> AnalyzeBidi;

        [NativeTypeName(
            "HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteTextAnalysisSource,
            uint,
            uint,
            IDWriteTextAnalysisSink,
            int> AnalyzeNumberSubstitution;

        [NativeTypeName(
            "HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteTextAnalysisSource,
            uint,
            uint,
            IDWriteTextAnalysisSink,
            int> AnalyzeLineBreakpoints;

        [NativeTypeName(
            "HRESULT (const WCHAR *, UINT32, IDWriteFontFace *, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, IDWriteNumberSubstitution *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, UINT32, UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT16 *, DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IDWriteFontFace,
            BOOL,
            BOOL,
            DWRITE_SCRIPT_ANALYSIS*,
            ushort*,
            IDWriteNumberSubstitution,
            DWRITE_TYPOGRAPHIC_FEATURES**,
            uint*,
            uint,
            uint,
            ushort*,
            DWRITE_SHAPING_TEXT_PROPERTIES*,
            ushort*,
            DWRITE_SHAPING_GLYPH_PROPERTIES*,
            uint*,
            int> GetGlyphs;

        [NativeTypeName(
            "HRESULT (const WCHAR *, const UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT32, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32, IDWriteFontFace *, FLOAT, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            DWRITE_SHAPING_TEXT_PROPERTIES*,
            uint,
            ushort*,
            DWRITE_SHAPING_GLYPH_PROPERTIES*,
            uint,
            IDWriteFontFace,
            float,
            BOOL,
            BOOL,
            DWRITE_SCRIPT_ANALYSIS*,
            ushort*,
            DWRITE_TYPOGRAPHIC_FEATURES**,
            uint*,
            uint,
            float*,
            DWRITE_GLYPH_OFFSET*,
            int> GetGlyphPlacements;

        [NativeTypeName(
            "HRESULT (const WCHAR *, const UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT32, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32, IDWriteFontFace *, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            DWRITE_SHAPING_TEXT_PROPERTIES*,
            uint,
            ushort*,
            DWRITE_SHAPING_GLYPH_PROPERTIES*,
            uint,
            IDWriteFontFace,
            float,
            float,
            DWRITE_MATRIX*,
            BOOL,
            BOOL,
            BOOL,
            DWRITE_SCRIPT_ANALYSIS*,
            ushort*,
            DWRITE_TYPOGRAPHIC_FEATURES**,
            uint*,
            uint,
            float*,
            DWRITE_GLYPH_OFFSET*,
            int> GetGdiCompatibleGlyphPlacements;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, UINT32, UINT32, const UINT16 *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            uint,
            uint,
            ushort*,
            float*,
            DWRITE_GLYPH_OFFSET*,
            DWRITE_SHAPING_GLYPH_PROPERTIES*,
            float*,
            DWRITE_GLYPH_OFFSET*,
            int> ApplyCharacterSpacing;

        [NativeTypeName(
            "HRESULT (IDWriteFontFace *, DWRITE_BASELINE, BOOL, BOOL, DWRITE_SCRIPT_ANALYSIS, const WCHAR *, INT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontFace,
            DWRITE_BASELINE,
            BOOL,
            BOOL,
            DWRITE_SCRIPT_ANALYSIS,
            ushort*,
            int*,
            BOOL*,
            int> GetBaseline;

        [NativeTypeName(
            "HRESULT (IDWriteTextAnalysisSource1 *, UINT32, UINT32, IDWriteTextAnalysisSink1 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteTextAnalysisSource1,
            uint,
            uint,
            IDWriteTextAnalysisSink1,
            int> AnalyzeVerticalGlyphOrientation;

        [NativeTypeName(
            "HRESULT (DWRITE_GLYPH_ORIENTATION_ANGLE, BOOL, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_GLYPH_ORIENTATION_ANGLE,
            BOOL,
            DWRITE_MATRIX*,
            int> GetGlyphOrientationTransform;

        [NativeTypeName(
            "HRESULT (DWRITE_SCRIPT_ANALYSIS, DWRITE_SCRIPT_PROPERTIES *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_SCRIPT_ANALYSIS,
            DWRITE_SCRIPT_PROPERTIES*,
            int> GetScriptProperties;

        [NativeTypeName(
            "HRESULT (const WCHAR *, UINT32, IDWriteFontFace *, BOOL *, UINT32 *, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IDWriteFontFace,
            BOOL*,
            uint*,
            ushort*,
            int> GetTextComplexity;

        [NativeTypeName(
            "HRESULT (IDWriteFontFace *, FLOAT, DWRITE_SCRIPT_ANALYSIS, UINT32, UINT32, const WCHAR *, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, DWRITE_JUSTIFICATION_OPPORTUNITY *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontFace,
            float,
            DWRITE_SCRIPT_ANALYSIS,
            uint,
            uint,
            ushort*,
            ushort*,
            DWRITE_SHAPING_GLYPH_PROPERTIES*,
            DWRITE_JUSTIFICATION_OPPORTUNITY*,
            int> GetJustificationOpportunities;

        [NativeTypeName(
            "HRESULT (FLOAT, UINT32, const DWRITE_JUSTIFICATION_OPPORTUNITY *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            uint,
            DWRITE_JUSTIFICATION_OPPORTUNITY*,
            float*,
            DWRITE_GLYPH_OFFSET*,
            float*,
            DWRITE_GLYPH_OFFSET*,
            int> JustifyGlyphAdvances;

        [NativeTypeName(
            "HRESULT (IDWriteFontFace *, FLOAT, DWRITE_SCRIPT_ANALYSIS, UINT32, UINT32, UINT32, const UINT16 *, const UINT16 *, const FLOAT *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32 *, UINT16 *, UINT16 *, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontFace,
            float,
            DWRITE_SCRIPT_ANALYSIS,
            uint,
            uint,
            uint,
            ushort*,
            ushort*,
            float*,
            float*,
            DWRITE_GLYPH_OFFSET*,
            DWRITE_SHAPING_GLYPH_PROPERTIES*,
            uint*,
            ushort*,
            ushort*,
            float*,
            DWRITE_GLYPH_OFFSET*,
            int> GetJustifiedGlyphs;

        [NativeTypeName(
            "HRESULT (DWRITE_GLYPH_ORIENTATION_ANGLE, BOOL, FLOAT, FLOAT, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_GLYPH_ORIENTATION_ANGLE,
            BOOL,
            float,
            float,
            DWRITE_MATRIX*,
            int> GetGlyphOrientationTransform1;

        [NativeTypeName(
            "HRESULT (IDWriteFontFace *, DWRITE_SCRIPT_ANALYSIS, const WCHAR *, UINT32, UINT32 *, DWRITE_FONT_FEATURE_TAG *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontFace,
            DWRITE_SCRIPT_ANALYSIS,
            ushort*,
            uint,
            uint*,
            DWRITE_FONT_FEATURE_TAG*,
            int> GetTypographicFeatures;

        [NativeTypeName(
            "HRESULT (IDWriteFontFace *, DWRITE_SCRIPT_ANALYSIS, const WCHAR *, DWRITE_FONT_FEATURE_TAG, UINT32, const UINT16 *, UINT8 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontFace,
            DWRITE_SCRIPT_ANALYSIS,
            ushort*,
            DWRITE_FONT_FEATURE_TAG,
            uint,
            ushort*,
            byte*,
            int> CheckTypographicFeature;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteTextAnalyzer2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteTextAnalyzer2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteTextAnalyzer1"/> to <see cref = "IDWriteTextAnalyzer2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteTextAnalyzer1"/> instance to be converted </param>
    public static explicit operator IDWriteTextAnalyzer2(
        Silk.NET.DirectX.IDWriteTextAnalyzer1 value
    )
    {
        return new IDWriteTextAnalyzer2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteTextAnalyzer2"/> to <see cref = "Silk.NET.DirectX.IDWriteTextAnalyzer1"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteTextAnalyzer2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteTextAnalyzer1(
        IDWriteTextAnalyzer2 value
    )
    {
        return new Silk.NET.DirectX.IDWriteTextAnalyzer1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteTextAnalyzer"/> to <see cref = "IDWriteTextAnalyzer2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteTextAnalyzer"/> instance to be converted </param>
    public static explicit operator IDWriteTextAnalyzer2(Silk.NET.DirectX.IDWriteTextAnalyzer value)
    {
        return new IDWriteTextAnalyzer2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteTextAnalyzer2"/> to <see cref = "Silk.NET.DirectX.IDWriteTextAnalyzer"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteTextAnalyzer2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteTextAnalyzer(IDWriteTextAnalyzer2 value)
    {
        return new Silk.NET.DirectX.IDWriteTextAnalyzer(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteTextAnalyzer2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteTextAnalyzer2(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteTextAnalyzer2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteTextAnalyzer2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteTextAnalyzer2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteTextAnalyzer2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
