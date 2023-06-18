// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteTextAnalyzer2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteTextAnalyzer2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextAnalyzer2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ApplyCharacterSpacing(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, uint textLength, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, float* modifiedGlyphAdvances, GlyphOffset* modifiedGlyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, float, float, float, uint, uint, ushort*, float*, GlyphOffset*, ShapingGlyphProperties*, float*, GlyphOffset*, int>)@this->LpVtbl[10])(@this, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textLength, glyphCount, clusterMap, glyphAdvances, glyphOffsets, glyphProperties, modifiedGlyphAdvances, modifiedGlyphOffsets);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeVerticalGlyphOrientation(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource1* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink1* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource1*, uint, uint, IDWriteTextAnalysisSink1*, int>)@this->LpVtbl[12])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphOrientationTransform(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, GlyphOrientationAngle glyphOrientationAngle, Silk.NET.Core.Bool32 isSideways, Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, GlyphOrientationAngle, Silk.NET.Core.Bool32, Matrix*, int>)@this->LpVtbl[13])(@this, glyphOrientationAngle, isSideways, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetScriptProperties(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ScriptAnalysis scriptAnalysis, ScriptProperties* scriptProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, ScriptAnalysis, ScriptProperties*, int>)@this->LpVtbl[14])(@this, scriptAnalysis, scriptProperties);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextComplexity(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, int* isTextSimple, uint* textLengthRead, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, uint, IDWriteFontFace*, int*, uint*, ushort*, int>)@this->LpVtbl[15])(@this, textString, textLength, fontFace, isTextSimple, textLengthRead, glyphIndices);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetJustificationOpportunities(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, JustificationOpportunity* justificationOpportunities)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, float, ScriptAnalysis, uint, uint, char*, ushort*, ShapingGlyphProperties*, JustificationOpportunity*, int>)@this->LpVtbl[16])(@this, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int JustifyGlyphAdvances(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, float lineWidth, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] JustificationOpportunity* justificationOpportunities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, float* justifiedGlyphAdvances, GlyphOffset* justifiedGlyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, float, uint, JustificationOpportunity*, float*, GlyphOffset*, float*, GlyphOffset*, int>)@this->LpVtbl[17])(@this, lineWidth, glyphCount, justificationOpportunities, glyphAdvances, glyphOffsets, justifiedGlyphAdvances, justifiedGlyphOffsets);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetJustifiedGlyphs(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, uint maxGlyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* justifiedGlyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* justifiedGlyphOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, uint* actualGlyphCount, ushort* modifiedClusterMap, ushort* modifiedGlyphIndices, float* modifiedGlyphAdvances, GlyphOffset* modifiedGlyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, float, ScriptAnalysis, uint, uint, uint, ushort*, ushort*, float*, float*, GlyphOffset*, ShapingGlyphProperties*, uint*, ushort*, ushort*, float*, GlyphOffset*, int>)@this->LpVtbl[18])(@this, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, maxGlyphCount, clusterMap, glyphIndices, glyphAdvances, justifiedGlyphAdvances, justifiedGlyphOffsets, glyphProperties, actualGlyphCount, modifiedClusterMap, modifiedGlyphIndices, modifiedGlyphAdvances, modifiedGlyphOffsets);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckTypographicFeature(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, byte* featureApplies)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, FontFeatureTag, uint, ushort*, byte*, int>)@this->LpVtbl[21])(@this, fontFace, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
        return ret;
    }

}
