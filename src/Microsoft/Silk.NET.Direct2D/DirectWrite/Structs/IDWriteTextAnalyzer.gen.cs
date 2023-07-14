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
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
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
        public readonly unsafe int AnalyzeScript(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeScript(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeScript(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, analysisSinkPtr);
                }
            }
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
        public readonly unsafe int AnalyzeBidi(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeBidi(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeBidi(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSourcePtr, textPosition, textLength, analysisSinkPtr);
                }
            }
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
        public readonly unsafe int AnalyzeNumberSubstitution(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeNumberSubstitution(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeNumberSubstitution(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSourcePtr, textPosition, textLength, analysisSinkPtr);
                }
            }
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
        public readonly unsafe int AnalyzeLineBreakpoints(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeLineBreakpoints(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeLineBreakpoints(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSourcePtr, textPosition, textLength, analysisSinkPtr);
                }
            }
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
        public readonly unsafe int GetGlyphs([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textStringPtr, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
            SilkMarshal.Free((nint)textStringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textStringPtr, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
            SilkMarshal.Free((nint)localeNamePtr);
            SilkMarshal.Free((nint)textStringPtr);
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
        public readonly unsafe int GetGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)textStringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)localeNamePtr);
            SilkMarshal.Free((nint)textStringPtr);
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

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)textStringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)localeNamePtr);
            SilkMarshal.Free((nint)textStringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeScript<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeScript((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeScript<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeScript((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeScript<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeScript(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeBidi<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeBidi((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeBidi<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeBidi((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeBidi<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeBidi(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeNumberSubstitution<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeNumberSubstitution((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeNumberSubstitution<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeNumberSubstitution((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeNumberSubstitution<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeNumberSubstitution(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeLineBreakpoints<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeLineBreakpoints((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeLineBreakpoints<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeLineBreakpoints((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeLineBreakpoints<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeLineBreakpoints(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
