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
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[4])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[5])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSink* analysisSinkPtr = &analysisSink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)@this->LpVtbl[6])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetGlyphs(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textStringPtr, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        SilkMarshal.Free((nint)textStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, IDWriteFontFace* fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteNumberSubstitution* numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, uint, IDWriteFontFace*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, IDWriteNumberSubstitution*, TypographicFeatures**, uint*, uint, uint, ushort*, ShapingTextProperties*, ushort*, ShapingGlyphProperties*, uint*, int>)@this->LpVtbl[7])(@this, textStringPtr, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        SilkMarshal.Free((nint)localeNamePtr);
        SilkMarshal.Free((nint)textStringPtr);
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
    public static unsafe int GetGlyphPlacements(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)textStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[8])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)localeNamePtr);
        SilkMarshal.Free((nint)textStringPtr);
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
    public static unsafe int GetGdiCompatibleGlyphPlacements(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, char*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, char*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)textStringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, IDWriteFontFace* fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, ushort*, ShapingTextProperties*, uint, ushort*, ShapingGlyphProperties*, uint, IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis*, byte*, TypographicFeatures**, uint*, uint, float*, GlyphOffset*, int>)@this->LpVtbl[9])(@this, textStringPtr, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeNamePtr, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        SilkMarshal.Free((nint)localeNamePtr);
        SilkMarshal.Free((nint)textStringPtr);
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* baselineCoordinatePtr = &baselineCoordinate)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinatePtr, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinate, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, byte*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeNamePtr, baselineCoordinate, exists);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace* fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, Baseline, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, ScriptAnalysis, char*, int*, int*, int>)@this->LpVtbl[11])(@this, fontFacePtr, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
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
    public static int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
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
    public static int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, ref int exists)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int AnalyzeVerticalGlyphOrientation(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource1* analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink1* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource1*, uint, uint, IDWriteTextAnalysisSink1*, int>)@this->LpVtbl[12])(@this, analysisSource, textPosition, textLength, analysisSink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeVerticalGlyphOrientation(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource1* analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink1 analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSink1* analysisSinkPtr = &analysisSink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource1*, uint, uint, IDWriteTextAnalysisSink1*, int>)@this->LpVtbl[12])(@this, analysisSource, textPosition, textLength, analysisSinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeVerticalGlyphOrientation(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource1 analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink1* analysisSink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource1* analysisSourcePtr = &analysisSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource1*, uint, uint, IDWriteTextAnalysisSink1*, int>)@this->LpVtbl[12])(@this, analysisSourcePtr, textPosition, textLength, analysisSink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeVerticalGlyphOrientation(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource1 analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink1 analysisSink)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetGlyphOrientationTransform(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, GlyphOrientationAngle glyphOrientationAngle, Silk.NET.Core.Bool32 isSideways, Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, GlyphOrientationAngle, Silk.NET.Core.Bool32, Matrix*, int>)@this->LpVtbl[13])(@this, glyphOrientationAngle, isSideways, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphOrientationTransform(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, GlyphOrientationAngle glyphOrientationAngle, Silk.NET.Core.Bool32 isSideways, ref Matrix transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, GlyphOrientationAngle, Silk.NET.Core.Bool32, Matrix*, int>)@this->LpVtbl[13])(@this, glyphOrientationAngle, isSideways, transformPtr);
        }
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
    public static int GetScriptProperties(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ScriptAnalysis scriptAnalysis, ref ScriptProperties scriptProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ScriptProperties* scriptPropertiesPtr = &scriptProperties)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, ScriptAnalysis, ScriptProperties*, int>)@this->LpVtbl[14])(@this, scriptAnalysis, scriptPropertiesPtr);
        }
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
    public static unsafe int GetTextComplexity(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, IDWriteFontFace* fontFace, int* isTextSimple, uint* textLengthRead, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, byte*, uint, IDWriteFontFace*, int*, uint*, ushort*, int>)@this->LpVtbl[15])(@this, textStringPtr, textLength, fontFace, isTextSimple, textLengthRead, glyphIndices);
        SilkMarshal.Free((nint)textStringPtr);
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
    public static unsafe int GetJustificationOpportunities(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, JustificationOpportunity* justificationOpportunities)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textStringPtr = (byte*) SilkMarshal.StringToPtr(textString, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, float, ScriptAnalysis, uint, uint, byte*, ushort*, ShapingGlyphProperties*, JustificationOpportunity*, int>)@this->LpVtbl[16])(@this, fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, textStringPtr, clusterMap, glyphProperties, justificationOpportunities);
        SilkMarshal.Free((nint)textStringPtr);
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontFeatureTag* tagsPtr = &tags)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, tagsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* actualTagCountPtr = &actualTagCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCountPtr, tags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCount, tags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFace, scriptAnalysis, localeNamePtr, maxTagCount, actualTagCount, tags);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace* fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, uint, uint*, FontFeatureTag*, int>)@this->LpVtbl[20])(@this, fontFacePtr, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
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
    public static int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
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
    public static int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteFontFace fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags)
    {
        var @this = thisVtbl.Handle;
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
    public static unsafe int CheckTypographicFeature(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, byte* featureApplies)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, FontFeatureTag, uint, ushort*, byte*, int>)@this->LpVtbl[21])(@this, fontFace, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckTypographicFeature(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string featureApplies)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var featureAppliesPtr = (byte*) SilkMarshal.StringToPtr(featureApplies, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, char*, FontFeatureTag, uint, ushort*, byte*, int>)@this->LpVtbl[21])(@this, fontFace, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureAppliesPtr);
        SilkMarshal.Free((nint)featureAppliesPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckTypographicFeature(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, byte* featureApplies)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, FontFeatureTag, uint, ushort*, byte*, int>)@this->LpVtbl[21])(@this, fontFace, scriptAnalysis, localeNamePtr, featureTag, glyphCount, glyphIndices, featureApplies);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckTypographicFeature(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string featureApplies)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        var featureAppliesPtr = (byte*) SilkMarshal.StringToPtr(featureApplies, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalyzer2*, IDWriteFontFace*, ScriptAnalysis, byte*, FontFeatureTag, uint, ushort*, byte*, int>)@this->LpVtbl[21])(@this, fontFace, scriptAnalysis, localeNamePtr, featureTag, glyphCount, glyphIndices, featureAppliesPtr);
        SilkMarshal.Free((nint)featureAppliesPtr);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeScript<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeScript((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeScript(analysisSource, textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeScript<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeScript((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeScript(ref analysisSource.GetPinnableReference(), textPosition, textLength, analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeScript<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeScript(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeScript(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeScript(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeBidi<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeBidi((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeBidi(analysisSource, textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeBidi<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeBidi((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeBidi(ref analysisSource.GetPinnableReference(), textPosition, textLength, analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeBidi<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeBidi(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeBidi(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeBidi(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeNumberSubstitution<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeNumberSubstitution((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeNumberSubstitution(analysisSource, textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeNumberSubstitution<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeNumberSubstitution((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeNumberSubstitution(ref analysisSource.GetPinnableReference(), textPosition, textLength, analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeNumberSubstitution<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeNumberSubstitution(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeNumberSubstitution(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeNumberSubstitution(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeLineBreakpoints<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeLineBreakpoints((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeLineBreakpoints(analysisSource, textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeLineBreakpoints<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeLineBreakpoints((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink* analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeLineBreakpoints(ref analysisSource.GetPinnableReference(), textPosition, textLength, analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeLineBreakpoints<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeLineBreakpoints(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeLineBreakpoints(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeLineBreakpoints(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphs<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, ComPtr<TI0> fontFace, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ComPtr<TI1> numberSubstitution, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, uint maxGlyphCount, ushort* clusterMap, ShapingTextProperties* textProps, ushort* glyphIndices, ShapingGlyphProperties* glyphProps, uint* actualGlyphCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphs(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isSideways, isRightToLeft, scriptAnalysis, localeName, (IDWriteNumberSubstitution*) numberSubstitution.Handle, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphPlacements<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, ShapingTextProperties* textProps, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProps, uint glyphCount, ComPtr<TI0> fontFace, float fontEmSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TypographicFeatures** features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* featureRangeLengths, uint featureRanges, float* glyphAdvances, GlyphOffset* glyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGdiCompatibleGlyphPlacements(textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, (IDWriteFontFace*) fontFace.Handle, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Span<int> baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Span<int> baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref int baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate, ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, int* baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName.GetPinnableReference(), baselineCoordinate, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName, baselineCoordinate, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, int* baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName.GetPinnableReference(), baselineCoordinate, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, int* baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName, baselineCoordinate, ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, Span<int> baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName.GetPinnableReference(), ref baselineCoordinate.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName, ref baselineCoordinate, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, Span<int> baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName.GetPinnableReference(), ref baselineCoordinate.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref int baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName, ref baselineCoordinate, ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Span<int> baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Span<int> baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBaseline<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref int baselineCoordinate, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetBaseline((IDWriteFontFace*) fontFace.Handle, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate, ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, int* baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Span<int> baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Span<int> baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, int* baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName.GetPinnableReference(), baselineCoordinate, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, int* baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName.GetPinnableReference(), baselineCoordinate, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, Span<int> baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName.GetPinnableReference(), ref baselineCoordinate.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, Span<int> baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, in localeName.GetPinnableReference(), ref baselineCoordinate.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, int* baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Span<int> baselineCoordinate, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static int GetBaseline(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, Baseline baseline, Silk.NET.Core.Bool32 isVertical, Silk.NET.Core.Bool32 isSimulationAllowed, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Span<int> baselineCoordinate, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBaseline(ref fontFace.GetPinnableReference(), baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, ref baselineCoordinate.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeVerticalGlyphOrientation<TI0, TI1>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource1>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextAnalysisSink1>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeVerticalGlyphOrientation((IDWriteTextAnalysisSource1*) analysisSource.Handle, textPosition, textLength, (IDWriteTextAnalysisSink1*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeVerticalGlyphOrientation(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteTextAnalysisSource1* analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink1> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeVerticalGlyphOrientation(analysisSource, textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeVerticalGlyphOrientation<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteTextAnalysisSink1 analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeVerticalGlyphOrientation((IDWriteTextAnalysisSource1*) analysisSource.Handle, textPosition, textLength, ref analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AnalyzeVerticalGlyphOrientation(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteTextAnalysisSource1> analysisSource, uint textPosition, uint textLength, IDWriteTextAnalysisSink1* analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeVerticalGlyphOrientation(ref analysisSource.GetPinnableReference(), textPosition, textLength, analysisSink);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeVerticalGlyphOrientation<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ref IDWriteTextAnalysisSource1 analysisSource, uint textPosition, uint textLength, ComPtr<TI0> analysisSink) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSink1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AnalyzeVerticalGlyphOrientation(ref analysisSource, textPosition, textLength, (IDWriteTextAnalysisSink1*) analysisSink.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AnalyzeVerticalGlyphOrientation(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteTextAnalysisSource1> analysisSource, uint textPosition, uint textLength, Span<IDWriteTextAnalysisSink1> analysisSink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AnalyzeVerticalGlyphOrientation(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref analysisSink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphOrientationTransform(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, GlyphOrientationAngle glyphOrientationAngle, Silk.NET.Core.Bool32 isSideways, Span<Matrix> transform)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphOrientationTransform(glyphOrientationAngle, isSideways, ref transform.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetScriptProperties(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ScriptAnalysis scriptAnalysis, Span<ScriptProperties> scriptProperties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetScriptProperties(scriptAnalysis, ref scriptProperties.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextComplexity<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, uint textLength, ComPtr<TI0> fontFace, int* isTextSimple, uint* textLengthRead, ushort* glyphIndices) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTextComplexity(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isTextSimple, textLengthRead, glyphIndices);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextComplexity<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, uint textLength, ComPtr<TI0> fontFace, int* isTextSimple, uint* textLengthRead, ushort* glyphIndices) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTextComplexity(textString, textLength, (IDWriteFontFace*) fontFace.Handle, isTextSimple, textLengthRead, glyphIndices);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetJustificationOpportunities<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, JustificationOpportunity* justificationOpportunities) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetJustificationOpportunities((IDWriteFontFace*) fontFace.Handle, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetJustificationOpportunities<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string textString, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, JustificationOpportunity* justificationOpportunities) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetJustificationOpportunities((IDWriteFontFace*) fontFace.Handle, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetJustifiedGlyphs<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, float fontEmSize, ScriptAnalysis scriptAnalysis, uint textLength, uint glyphCount, uint maxGlyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* clusterMap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* justifiedGlyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* justifiedGlyphOffsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapingGlyphProperties* glyphProperties, uint* actualGlyphCount, ushort* modifiedClusterMap, ushort* modifiedGlyphIndices, float* modifiedGlyphAdvances, GlyphOffset* modifiedGlyphOffsets) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetJustifiedGlyphs((IDWriteFontFace*) fontFace.Handle, fontEmSize, scriptAnalysis, textLength, glyphCount, maxGlyphCount, clusterMap, glyphIndices, glyphAdvances, justifiedGlyphAdvances, justifiedGlyphOffsets, glyphProperties, actualGlyphCount, modifiedClusterMap, modifiedGlyphIndices, modifiedGlyphAdvances, modifiedGlyphOffsets);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, actualTagCount, ref tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, Span<uint> actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(fontFace, scriptAnalysis, localeName, maxTagCount, ref actualTagCount.GetPinnableReference(), tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, ref actualTagCount, tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, Span<uint> actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(fontFace, scriptAnalysis, localeName, maxTagCount, ref actualTagCount.GetPinnableReference(), ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, ref actualTagCount, ref tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(fontFace, scriptAnalysis, in localeName.GetPinnableReference(), maxTagCount, actualTagCount, tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, in localeName, maxTagCount, actualTagCount, tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, uint maxTagCount, uint* actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(fontFace, scriptAnalysis, in localeName.GetPinnableReference(), maxTagCount, actualTagCount, ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, in localeName, maxTagCount, actualTagCount, ref tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, uint maxTagCount, Span<uint> actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(fontFace, scriptAnalysis, in localeName.GetPinnableReference(), maxTagCount, ref actualTagCount.GetPinnableReference(), tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, in localeName, maxTagCount, ref actualTagCount, tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, uint maxTagCount, Span<uint> actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(fontFace, scriptAnalysis, in localeName.GetPinnableReference(), maxTagCount, ref actualTagCount.GetPinnableReference(), ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, in localeName, maxTagCount, ref actualTagCount, ref tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, actualTagCount, ref tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, Span<uint> actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(fontFace, scriptAnalysis, localeName, maxTagCount, ref actualTagCount.GetPinnableReference(), tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, FontFeatureTag* tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, ref actualTagCount, tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, IDWriteFontFace* fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, Span<uint> actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(fontFace, scriptAnalysis, localeName, maxTagCount, ref actualTagCount.GetPinnableReference(), ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTypographicFeatures<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, ref uint actualTagCount, ref FontFeatureTag tags) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypographicFeatures((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, maxTagCount, ref actualTagCount, ref tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, uint* actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, localeName, maxTagCount, actualTagCount, ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, Span<uint> actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, localeName, maxTagCount, ref actualTagCount.GetPinnableReference(), tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, uint maxTagCount, Span<uint> actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, localeName, maxTagCount, ref actualTagCount.GetPinnableReference(), ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, in localeName.GetPinnableReference(), maxTagCount, actualTagCount, tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, uint maxTagCount, uint* actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, in localeName.GetPinnableReference(), maxTagCount, actualTagCount, ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, uint maxTagCount, Span<uint> actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, in localeName.GetPinnableReference(), maxTagCount, ref actualTagCount.GetPinnableReference(), tags);
    }

    /// <summary>To be documented.</summary>
    public static int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, uint maxTagCount, Span<uint> actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, in localeName.GetPinnableReference(), maxTagCount, ref actualTagCount.GetPinnableReference(), ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, uint* actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, localeName, maxTagCount, actualTagCount, ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, Span<uint> actualTagCount, FontFeatureTag* tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, localeName, maxTagCount, ref actualTagCount.GetPinnableReference(), tags);
    }

    /// <summary>To be documented.</summary>
    public static int GetTypographicFeatures(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, Span<IDWriteFontFace> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint maxTagCount, Span<uint> actualTagCount, Span<FontFeatureTag> tags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypographicFeatures(ref fontFace.GetPinnableReference(), scriptAnalysis, localeName, maxTagCount, ref actualTagCount.GetPinnableReference(), ref tags.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckTypographicFeature<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, byte* featureApplies) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CheckTypographicFeature((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckTypographicFeature<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string featureApplies) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CheckTypographicFeature((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckTypographicFeature<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, byte* featureApplies) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CheckTypographicFeature((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CheckTypographicFeature<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl, ComPtr<TI0> fontFace, ScriptAnalysis scriptAnalysis, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, FontFeatureTag featureTag, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string featureApplies) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CheckTypographicFeature((IDWriteFontFace*) fontFace.Handle, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteTextAnalyzer2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
