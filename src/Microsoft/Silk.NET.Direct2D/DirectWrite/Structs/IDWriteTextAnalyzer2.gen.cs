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
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
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
        public readonly unsafe int AnalyzeScript(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeScript(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeScript(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, analysisSinkPtr);
                }
            }
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
        public readonly unsafe int AnalyzeBidi(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeBidi(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeBidi(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSourcePtr, textPosition, textLength, analysisSinkPtr);
                }
            }
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
        public readonly unsafe int AnalyzeNumberSubstitution(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeNumberSubstitution(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeNumberSubstitution(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSourcePtr, textPosition, textLength, analysisSinkPtr);
                }
            }
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
        public readonly unsafe int AnalyzeLineBreakpoints(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeLineBreakpoints(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeLineBreakpoints(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSourcePtr, textPosition, textLength, analysisSinkPtr);
                }
            }
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
        public readonly unsafe int GetGlyphs([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textStringPtr, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
            SilkMarshal.Free((nint)textStringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textStringPtr, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
            SilkMarshal.Free((nint)localeNamePtr);
            SilkMarshal.Free((nint)textStringPtr);
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
        public readonly unsafe int GetGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)textStringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)localeNamePtr);
            SilkMarshal.Free((nint)textStringPtr);
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
        public readonly unsafe int GetGdiCompatibleGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)textStringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
            SilkMarshal.Free((nint)localeNamePtr);
            SilkMarshal.Free((nint)textStringPtr);
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
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* baselineCoordinatePtr = &baselineCoordinate)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinatePtr, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* baselineCoordinatePtr = &baselineCoordinate)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinatePtr, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinate, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinate, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (int* baselineCoordinatePtr = &baselineCoordinate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinatePtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (int* baselineCoordinatePtr = &baselineCoordinate)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinatePtr, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, byte*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinate, exists);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, byte*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinate, existsPtr);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (int* baselineCoordinatePtr = &baselineCoordinate)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, byte*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinatePtr, exists);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (int* baselineCoordinatePtr = &baselineCoordinate)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, byte*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinatePtr, existsPtr);
                }
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (int* baselineCoordinatePtr = &baselineCoordinate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinatePtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (int* baselineCoordinatePtr = &baselineCoordinate)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinatePtr, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinate, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinate, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (int* baselineCoordinatePtr = &baselineCoordinate)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinatePtr, exists);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (int* baselineCoordinatePtr = &baselineCoordinate)
                    {
                        fixed (int* existsPtr = &exists)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinatePtr, existsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, byte*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinate, exists);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, byte*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinate, existsPtr);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, int* exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (int* baselineCoordinatePtr = &baselineCoordinate)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, byte*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinatePtr, exists);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBaseline(ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, ref int exists)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (int* baselineCoordinatePtr = &baselineCoordinate)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, byte*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinatePtr, existsPtr);
                    }
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
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
        public readonly unsafe int AnalyzeVerticalGlyphOrientation(IDWriteTextAnalysisSource1* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink1 analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSink1* analysisSinkPtr = &analysisSink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource1*, uint, uint, IDWriteTextAnalysisSink1*, int>)@this->LpVtbl[12])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AnalyzeVerticalGlyphOrientation(ref IDWriteTextAnalysisSource1 analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink1* analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource1* analysisSourcePtr = &analysisSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource1*, uint, uint, IDWriteTextAnalysisSink1*, int>)@this->LpVtbl[12])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeVerticalGlyphOrientation(ref IDWriteTextAnalysisSource1 analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink1 analysisSink)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource1* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteTextAnalysisSink1* analysisSinkPtr = &analysisSink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource1*, uint, uint, IDWriteTextAnalysisSink1*, int>)@this->LpVtbl[12])(@this, analysisSourcePtr, textPosition, textLength, analysisSinkPtr);
                }
            }
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
        public readonly int GetGlyphOrientationTransform(GlyphOrientationAngle glyphOrientationAngle, Silk.NET.Core.Bool32 isSideways, ref Matrix transform)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, GlyphOrientationAngle, Silk.NET.Core.Bool32, Matrix*, int>)@this->LpVtbl[13])(@this, glyphOrientationAngle, isSideways, transformPtr);
            }
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
        public readonly int GetScriptProperties(ScriptAnalysis scriptAnalysis, ref ScriptProperties scriptProperties)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ScriptProperties* scriptPropertiesPtr = &scriptProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, ScriptAnalysis, ScriptProperties*, int>)@this->LpVtbl[14])(@this, scriptAnalysis, scriptPropertiesPtr);
            }
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
        public readonly unsafe int GetTextComplexity([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, IDWriteFontFace* fontFace, int* isTextSimple, uint* textLengthRead, ushort* glyphIndices)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, uint, IDWriteFontFace*, int*, uint*, ushort*, int>)@this->LpVtbl[15])(@this, textStringPtr, textLength, fontFace, isTextSimple, textLengthRead, glyphIndices);
            SilkMarshal.Free((nint)textStringPtr);
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
        public readonly unsafe int GetJustificationOpportunities(IDWriteFontFace* fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, JustificationOpportunity* justificationOpportunities)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, float, ScriptAnalysis, uint, uint, byte*, ushort*, ShapingGlyphProperties*, JustificationOpportunity*, int>)@this->LpVtbl[16])(@this, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, textStringPtr, clusterMap, glyphProperties, justificationOpportunities);
            SilkMarshal.Free((nint)textStringPtr);
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
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontFeatureTag* tagsPtr = &tags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, tagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* actualTagCountPtr = &actualTagCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCountPtr, tags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* actualTagCountPtr = &actualTagCount)
            {
                fixed (FontFeatureTag* tagsPtr = &tags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCountPtr, tagsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCount, tags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (FontFeatureTag* tagsPtr = &tags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCount, tagsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (uint* actualTagCountPtr = &actualTagCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCountPtr, tags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (uint* actualTagCountPtr = &actualTagCount)
                {
                    fixed (FontFeatureTag* tagsPtr = &tags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCountPtr, tagsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCount, tags);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (FontFeatureTag* tagsPtr = &tags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCount, tagsPtr);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (uint* actualTagCountPtr = &actualTagCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCountPtr, tags);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (uint* actualTagCountPtr = &actualTagCount)
            {
                fixed (FontFeatureTag* tagsPtr = &tags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCountPtr, tagsPtr);
                }
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (FontFeatureTag* tagsPtr = &tags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeName, maxTagCount, actualTagCount, tagsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (uint* actualTagCountPtr = &actualTagCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeName, maxTagCount, actualTagCountPtr, tags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (uint* actualTagCountPtr = &actualTagCount)
                {
                    fixed (FontFeatureTag* tagsPtr = &tags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeName, maxTagCount, actualTagCountPtr, tagsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCount, tags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (FontFeatureTag* tagsPtr = &tags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCount, tagsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (uint* actualTagCountPtr = &actualTagCount)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCountPtr, tags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (uint* actualTagCountPtr = &actualTagCount)
                    {
                        fixed (FontFeatureTag* tagsPtr = &tags)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCountPtr, tagsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCount, tags);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (FontFeatureTag* tagsPtr = &tags)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCount, tagsPtr);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (uint* actualTagCountPtr = &actualTagCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCountPtr, tags);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypographicFeatures(ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (uint* actualTagCountPtr = &actualTagCount)
                {
                    fixed (FontFeatureTag* tagsPtr = &tags)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCountPtr, tagsPtr);
                    }
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
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

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckTypographicFeature(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string featureApplies)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var featureAppliesPtr = (byte*) SilkMarshal.StringToPtr(featureApplies, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, FontFeatureTag, uint, ushort*, byte*, int>)@this->LpVtbl[21])(@this, fontFace, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureAppliesPtr);
            SilkMarshal.Free((nint)featureAppliesPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckTypographicFeature(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, byte* featureApplies)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, FontFeatureTag, uint, ushort*, byte*, int>)@this->LpVtbl[21])(@this, fontFace, scriptAnalysis, localeNamePtr, featureTag, glyphCount, glyphIndices, featureApplies);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckTypographicFeature(IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string featureApplies)
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            var featureAppliesPtr = (byte*) SilkMarshal.StringToPtr(featureApplies, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, FontFeatureTag, uint, ushort*, byte*, int>)@this->LpVtbl[21])(@this, fontFace, scriptAnalysis, localeNamePtr, featureTag, glyphCount, glyphIndices, featureAppliesPtr);
            SilkMarshal.Free((nint)featureAppliesPtr);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeScript<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeScript((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeScript<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeScript((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeScript<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeScript(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeBidi<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeBidi((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeBidi<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeBidi((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeBidi<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeBidi(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeNumberSubstitution<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeNumberSubstitution((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeNumberSubstitution<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeNumberSubstitution((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeNumberSubstitution<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeNumberSubstitution(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeLineBreakpoints<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeLineBreakpoints((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeLineBreakpoints<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeLineBreakpoints((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeLineBreakpoints<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeLineBreakpoints(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphs<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiCompatibleGlyphPlacements<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName, baselineCoordinate, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName, baselineCoordinate, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName, ref baselineCoordinate, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName, ref baselineCoordinate, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate, exists);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBaseline<TI0>(ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate, ref exists);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeVerticalGlyphOrientation<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource1>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink1>, IComVtbl<TI1>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeVerticalGlyphOrientation((IDWriteTextAnalysisSource1*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink1*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeVerticalGlyphOrientation<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink1 analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource1>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeVerticalGlyphOrientation((IDWriteTextAnalysisSource1*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
        }

        /// <summary>To be documented.</summary>
        public readonly int AnalyzeVerticalGlyphOrientation<TI0>(ref IDWriteTextAnalysisSource1 analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink1>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AnalyzeVerticalGlyphOrientation(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink1*) analysisSink.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextComplexity<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, ComPtr<TI0> fontFace, int* isTextSimple, uint* textLengthRead, ushort* glyphIndices) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTextComplexity(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isTextSimple, textLengthRead, glyphIndices);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextComplexity<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, ComPtr<TI0> fontFace, int* isTextSimple, uint* textLengthRead, ushort* glyphIndices) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTextComplexity(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isTextSimple, textLengthRead, glyphIndices);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetJustificationOpportunities<TI0>(ComPtr<TI0> fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, JustificationOpportunity* justificationOpportunities) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetJustificationOpportunities((IDWriteFontFace*) fontFace.Handle, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetJustificationOpportunities<TI0>(ComPtr<TI0> fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, JustificationOpportunity* justificationOpportunities) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetJustificationOpportunities((IDWriteFontFace*) fontFace.Handle, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetJustifiedGlyphs<TI0>(ComPtr<TI0> fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, uint maxGlyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* justifiedGlyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* justifiedGlyphOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, uint* actualGlyphCount, ushort* modifiedClusterMap, ushort* modifiedGlyphIndices, float* modifiedGlyphAdvances, GlyphOffset* modifiedGlyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetJustifiedGlyphs((IDWriteFontFace*) fontFace.Handle, fontEmSize, scriptAnalysis, textLength, glyphCount, maxGlyphCount, clusterMap, glyphIndices, glyphAdvances, justifiedGlyphAdvances, justifiedGlyphOffsets, glyphProperties, actualGlyphCount, modifiedClusterMap, modifiedGlyphIndices, modifiedGlyphAdvances, modifiedGlyphOffsets);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, actualTagCount, ref tags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, ref actualTagCount, tags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, ref actualTagCount, ref tags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, in localeName, maxTagCount, actualTagCount, tags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, in localeName, maxTagCount, actualTagCount, ref tags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, in localeName, maxTagCount, ref actualTagCount, tags);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, in localeName, maxTagCount, ref actualTagCount, ref tags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, actualTagCount, ref tags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, ref actualTagCount, tags);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypographicFeatures<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, ref actualTagCount, ref tags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckTypographicFeature<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, byte* featureApplies) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckTypographicFeature((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckTypographicFeature<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string featureApplies) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckTypographicFeature((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckTypographicFeature<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, byte* featureApplies) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckTypographicFeature((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckTypographicFeature<TI0>(ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string featureApplies) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CheckTypographicFeature((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalyzer2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
