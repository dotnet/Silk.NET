// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteTextAnalyzer.xml' path='doc/member[@name="IDWriteTextAnalyzer"]/*'/>
[Guid("B7E6163E-7F46-43B4-84B3-E4E6249C365D")]
[NativeTypeName("struct IDWriteTextAnalyzer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteTextAnalyzer : IDWriteTextAnalyzer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextAnalyzer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer*, uint> )(lpVtbl[1]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer*, uint> )(lpVtbl[2]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextAnalyzer.xml' path='doc/member[@name="IDWriteTextAnalyzer.AnalyzeScript"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AnalyzeScript(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> )(lpVtbl[3]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
    }

    /// <include file='IDWriteTextAnalyzer.xml' path='doc/member[@name="IDWriteTextAnalyzer.AnalyzeBidi"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AnalyzeBidi(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> )(lpVtbl[4]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
    }

    /// <include file='IDWriteTextAnalyzer.xml' path='doc/member[@name="IDWriteTextAnalyzer.AnalyzeNumberSubstitution"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AnalyzeNumberSubstitution(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> )(lpVtbl[5]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
    }

    /// <include file='IDWriteTextAnalyzer.xml' path='doc/member[@name="IDWriteTextAnalyzer.AnalyzeLineBreakpoints"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AnalyzeLineBreakpoints(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> )(lpVtbl[6]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
    }

    /// <include file='IDWriteTextAnalyzer.xml' path='doc/member[@name="IDWriteTextAnalyzer.GetGlyphs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetGlyphs([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, IDWriteFontFace* fontFace, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, IDWriteNumberSubstitution* numberSubstitution, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16 *")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16 *")] ushort* glyphIndices, DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32 *")] uint* actualGlyphCount)
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer*, ushort*, uint, IDWriteFontFace*, BOOL, BOOL, DWRITE_SCRIPT_ANALYSIS*, ushort*, IDWriteNumberSubstitution*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, uint, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint*, int> )(lpVtbl[7]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
    }

    /// <include file='IDWriteTextAnalyzer.xml' path='doc/member[@name="IDWriteTextAnalyzer.GetGlyphPlacements"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, float* glyphAdvances, DWRITE_GLYPH_OFFSET* glyphOffsets)
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer*, ushort*, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, uint, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint, IDWriteFontFace*, float, BOOL, BOOL, DWRITE_SCRIPT_ANALYSIS*, ushort*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, float*, DWRITE_GLYPH_OFFSET*, int> )(lpVtbl[8]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <include file='IDWriteTextAnalyzer.xml' path='doc/member[@name="IDWriteTextAnalyzer.GetGdiCompatibleGlyphPlacements"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetGdiCompatibleGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, float* glyphAdvances, DWRITE_GLYPH_OFFSET* glyphOffsets)
    {
        return ((delegate* unmanaged<IDWriteTextAnalyzer*, ushort*, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, uint, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint, IDWriteFontFace*, float, float, DWRITE_MATRIX*, BOOL, BOOL, BOOL, DWRITE_SCRIPT_ANALYSIS*, ushort*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, float*, DWRITE_GLYPH_OFFSET*, int> )(lpVtbl[9]))((IDWriteTextAnalyzer*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AnalyzeScript(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink);
        [VtblIndex(4)]
        HRESULT AnalyzeBidi(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink);
        [VtblIndex(5)]
        HRESULT AnalyzeNumberSubstitution(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink);
        [VtblIndex(6)]
        HRESULT AnalyzeLineBreakpoints(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink);
        [VtblIndex(7)]
        HRESULT GetGlyphs([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, IDWriteFontFace* fontFace, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, IDWriteNumberSubstitution* numberSubstitution, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16 *")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16 *")] ushort* glyphIndices, DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32 *")] uint* actualGlyphCount);
        [VtblIndex(8)]
        HRESULT GetGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, float* glyphAdvances, DWRITE_GLYPH_OFFSET* glyphOffsets);
        [VtblIndex(9)]
        HRESULT GetGdiCompatibleGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, BOOL isSideways, BOOL isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, float* glyphAdvances, DWRITE_GLYPH_OFFSET* glyphOffsets);
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
        [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> AnalyzeScript;
        [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> AnalyzeBidi;
        [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> AnalyzeNumberSubstitution;
        [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteTextAnalysisSink *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int> AnalyzeLineBreakpoints;
        [NativeTypeName("HRESULT (const WCHAR *, UINT32, IDWriteFontFace *, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, IDWriteNumberSubstitution *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, UINT32, UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT16 *, DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, IDWriteFontFace*, BOOL, BOOL, DWRITE_SCRIPT_ANALYSIS*, ushort*, IDWriteNumberSubstitution*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, uint, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint*, int> GetGlyphs;
        [NativeTypeName("HRESULT (const WCHAR *, const UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT32, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32, IDWriteFontFace *, FLOAT, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, uint, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint, IDWriteFontFace*, float, BOOL, BOOL, DWRITE_SCRIPT_ANALYSIS*, ushort*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, float*, DWRITE_GLYPH_OFFSET*, int> GetGlyphPlacements;
        [NativeTypeName("HRESULT (const WCHAR *, const UINT16 *, DWRITE_SHAPING_TEXT_PROPERTIES *, UINT32, const UINT16 *, const DWRITE_SHAPING_GLYPH_PROPERTIES *, UINT32, IDWriteFontFace *, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, BOOL, BOOL, const DWRITE_SCRIPT_ANALYSIS *, const WCHAR *, const DWRITE_TYPOGRAPHIC_FEATURES **, const UINT32 *, UINT32, FLOAT *, DWRITE_GLYPH_OFFSET *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, uint, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint, IDWriteFontFace*, float, float, DWRITE_MATRIX*, BOOL, BOOL, BOOL, DWRITE_SCRIPT_ANALYSIS*, ushort*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, float*, DWRITE_GLYPH_OFFSET*, int> GetGdiCompatibleGlyphPlacements;
    }
}