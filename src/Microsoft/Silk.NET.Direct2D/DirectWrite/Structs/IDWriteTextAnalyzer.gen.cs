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
    [Guid("b7e6163e-7f46-43b4-84b3-e4e6249c365d")]
    [NativeName("Name", "IDWriteTextAnalyzer")]
    public unsafe partial struct IDWriteTextAnalyzer : IComVtbl<IDWriteTextAnalyzer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b7e6163e-7f46-43b4-84b3-e4e6249c365d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextAnalyzer val)
            => Unsafe.As<IDWriteTextAnalyzer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextAnalyzer
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
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeScript(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, analysisSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeBidi(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSource, textPosition, textLength, analysisSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeNumberSubstitution(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSource, textPosition, textLength, analysisSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeLineBreakpoints(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSource, textPosition, textLength, analysisSink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            return ret;
        }

    }
}
