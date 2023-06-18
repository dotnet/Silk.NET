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

namespace Silk.NET.DirectWrite
{
    [Guid("553a9ff3-5693-4df7-b52b-74806f7f2eb9")]
    [NativeName("Name", "IDWriteTextAnalyzer2")]
    public unsafe partial struct IDWriteTextAnalyzer2 : IComVtbl<IDWriteTextAnalyzer2>, IComVtbl<IDWriteTextAnalyzer1>, IComVtbl<IDWriteTextAnalyzer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("553a9ff3-5693-4df7-b52b-74806f7f2eb9");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteTextAnalyzer1(IDWriteTextAnalyzer2 val)
            => Unsafe.As<IDWriteTextAnalyzer2, IDWriteTextAnalyzer1>(ref val);

        public static implicit operator IDWriteTextAnalyzer(IDWriteTextAnalyzer2 val)
            => Unsafe.As<IDWriteTextAnalyzer2, IDWriteTextAnalyzer>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextAnalyzer2 val)
            => Unsafe.As<IDWriteTextAnalyzer2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextAnalyzer2
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeScript(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, analysisSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeBidi(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSource, textPosition, textLength, analysisSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeNumberSubstitution(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSource, textPosition, textLength, analysisSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeLineBreakpoints(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSource, textPosition, textLength, analysisSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ApplyCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, uint textLength, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, float* modifiedGlyphAdvances, GlyphOffset* modifiedGlyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, float, float, float, uint, uint, ushort*, float*, GlyphOffset*, ShapingGlyphProperties*, float*, GlyphOffset*, int>)@this->LpVtbl[10])(@this, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textLength, glyphCount, clusterMap, glyphAdvances, glyphOffsets, glyphProperties, modifiedGlyphAdvances, modifiedGlyphOffsets);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeVerticalGlyphOrientation(IDWriteTextAnalysisSource1* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink1* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource1*, uint, uint, IDWriteTextAnalysisSink1*, int>)@this->LpVtbl[12])(@this, analysisSource, textPosition, textLength, analysisSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphOrientationTransform(GlyphOrientationAngle glyphOrientationAngle, Silk.NET.Core.Bool32 isSideways, Matrix* transform)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, GlyphOrientationAngle, Silk.NET.Core.Bool32, Matrix*, int>)@this->LpVtbl[13])(@this, glyphOrientationAngle, isSideways, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetScriptProperties(ScriptAnalysis scriptAnalysis, ScriptProperties* scriptProperties)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, ScriptAnalysis, ScriptProperties*, int>)@this->LpVtbl[14])(@this, scriptAnalysis, scriptProperties);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextComplexity([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, int* isTextSimple, uint* textLengthRead, ushort* glyphIndices)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, uint, IDWriteFontFace*, int*, uint*, ushort*, int>)@this->LpVtbl[15])(@this, textString, textLength, fontFace, isTextSimple, textLengthRead, glyphIndices);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetJustificationOpportunities(IDWriteFontFace* fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, JustificationOpportunity* justificationOpportunities)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, float, ScriptAnalysis, uint, uint, char*, ushort*, ShapingGlyphProperties*, JustificationOpportunity*, int>)@this->LpVtbl[16])(@this, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int JustifyGlyphAdvances(float lineWidth, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] JustificationOpportunity* justificationOpportunities, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, float* justifiedGlyphAdvances, GlyphOffset* justifiedGlyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, float, uint, JustificationOpportunity*, float*, GlyphOffset*, float*, GlyphOffset*, int>)@this->LpVtbl[17])(@this, lineWidth, glyphCount, justificationOpportunities, glyphAdvances, glyphOffsets, justifiedGlyphAdvances, justifiedGlyphOffsets);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetJustifiedGlyphs(IDWriteFontFace* fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, uint maxGlyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* justifiedGlyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* justifiedGlyphOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, uint* actualGlyphCount, ushort* modifiedClusterMap, ushort* modifiedGlyphIndices, float* modifiedGlyphAdvances, GlyphOffset* modifiedGlyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, float, ScriptAnalysis, uint, uint, uint, ushort*, ushort*, float*, float*, GlyphOffset*, ShapingGlyphProperties*, uint*, ushort*, ushort*, float*, GlyphOffset*, int>)@this->LpVtbl[18])(@this, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, maxGlyphCount, clusterMap, glyphIndices, glyphAdvances, justifiedGlyphAdvances, justifiedGlyphOffsets, glyphProperties, actualGlyphCount, modifiedClusterMap, modifiedGlyphIndices, modifiedGlyphAdvances, modifiedGlyphOffsets);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckTypographicFeature(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, byte* featureApplies)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, FontFeatureTag, uint, ushort*, byte*, int>)@this->LpVtbl[21])(@this, fontFace, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
            return ret;
        }

    }
}
