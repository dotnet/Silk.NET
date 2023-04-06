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

public unsafe static class DWriteTextAnalyzerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static uint AddRef(this ComPtr<IDWriteTextAnalyzer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextAnalyzer> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetGlyphs(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textStringPtr, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        SilkMarshal.Free((nint)textStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textStringPtr, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        SilkMarshal.Free((nint)localeNamePtr);
        SilkMarshal.Free((nint)textStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)textStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)localeNamePtr);
        SilkMarshal.Free((nint)textStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)textStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)localeNamePtr);
        SilkMarshal.Free((nint)textStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeScript<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeScript((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeScript(analysisSource, textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeScript<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeScript((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeScript(ref analysisSource.GetPinnableReference(), textPosition, textLength, analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeScript<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeScript(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeScript(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeBidi<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeBidi((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeBidi(analysisSource, textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeBidi<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeBidi((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeBidi(ref analysisSource.GetPinnableReference(), textPosition, textLength, analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeBidi<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeBidi(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeBidi(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeNumberSubstitution<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeNumberSubstitution((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeNumberSubstitution(analysisSource, textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeNumberSubstitution<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeNumberSubstitution((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeNumberSubstitution(ref analysisSource.GetPinnableReference(), textPosition, textLength, analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeNumberSubstitution<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeNumberSubstitution(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeNumberSubstitution(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeLineBreakpoints<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeLineBreakpoints((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeLineBreakpoints(analysisSource, textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeLineBreakpoints<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeLineBreakpoints((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeLineBreakpoints(ref analysisSource.GetPinnableReference(), textPosition, textLength, analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeLineBreakpoints<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeLineBreakpoints(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeLineBreakpoints(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteTextAnalyzer> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
