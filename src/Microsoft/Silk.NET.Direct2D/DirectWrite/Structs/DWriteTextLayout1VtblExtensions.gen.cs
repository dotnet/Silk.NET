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

public unsafe static class DWriteTextLayout1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextLayout1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextAlignment(this ComPtr<IDWriteTextLayout1> thisVtbl, TextAlignment textAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, TextAlignment, int>)@this->LpVtbl[3])(@this, textAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetParagraphAlignment(this ComPtr<IDWriteTextLayout1> thisVtbl, ParagraphAlignment paragraphAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, ParagraphAlignment, int>)@this->LpVtbl[4])(@this, paragraphAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetWordWrapping(this ComPtr<IDWriteTextLayout1> thisVtbl, WordWrapping wordWrapping)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, WordWrapping, int>)@this->LpVtbl[5])(@this, wordWrapping);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetReadingDirection(this ComPtr<IDWriteTextLayout1> thisVtbl, ReadingDirection readingDirection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, ReadingDirection, int>)@this->LpVtbl[6])(@this, readingDirection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFlowDirection(this ComPtr<IDWriteTextLayout1> thisVtbl, FlowDirection flowDirection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FlowDirection, int>)@this->LpVtbl[7])(@this, flowDirection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetIncrementalTabStop(this ComPtr<IDWriteTextLayout1> thisVtbl, float incrementalTabStop)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, int>)@this->LpVtbl[8])(@this, incrementalTabStop);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTrimming(this ComPtr<IDWriteTextLayout1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLineSpacing(this ComPtr<IDWriteTextLayout1> thisVtbl, LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, LineSpacingMethod, float, float, int>)@this->LpVtbl[10])(@this, lineSpacingMethod, lineSpacing, baseline);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static TextAlignment GetTextAlignment(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TextAlignment ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, TextAlignment>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ParagraphAlignment GetParagraphAlignment(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ParagraphAlignment ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, ParagraphAlignment>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static WordWrapping GetWordWrapping(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        WordWrapping ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, WordWrapping>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ReadingDirection GetReadingDirection(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ReadingDirection ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, ReadingDirection>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FlowDirection GetFlowDirection(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FlowDirection ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FlowDirection>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetIncrementalTabStop(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrimming(this ComPtr<IDWriteTextLayout1> thisVtbl, Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout1> thisVtbl, LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baseline);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteTextLayout1> thisVtbl, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontFamilyNameLength(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint>)@this->LpVtbl[20])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamilyName(this ComPtr<IDWriteTextLayout1> thisVtbl, char* fontFamilyName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyName, nameSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontWeight GetFontWeight(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontWeight ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontWeight>)@this->LpVtbl[22])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStyle GetFontStyle(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontStyle>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStretch GetFontStretch(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStretch ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontStretch>)@this->LpVtbl[24])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetFontSize(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float>)@this->LpVtbl[25])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLocaleNameLength(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextLayout1> thisVtbl, char* localeName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, char*, uint, int>)@this->LpVtbl[27])(@this, localeName, nameSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaxWidth(this ComPtr<IDWriteTextLayout1> thisVtbl, float maxWidth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, int>)@this->LpVtbl[28])(@this, maxWidth);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaxHeight(this ComPtr<IDWriteTextLayout1> thisVtbl, float maxHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, int>)@this->LpVtbl[29])(@this, maxHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFontCollection(this ComPtr<IDWriteTextLayout1> thisVtbl, IDWriteFontCollection* fontCollection, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, IDWriteFontCollection*, TextRange, int>)@this->LpVtbl[30])(@this, fontCollection, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFontFamilyName(this ComPtr<IDWriteTextLayout1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, char*, TextRange, int>)@this->LpVtbl[31])(@this, fontFamilyName, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontWeight(this ComPtr<IDWriteTextLayout1> thisVtbl, FontWeight fontWeight, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontWeight, TextRange, int>)@this->LpVtbl[32])(@this, fontWeight, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontStyle(this ComPtr<IDWriteTextLayout1> thisVtbl, FontStyle fontStyle, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontStyle, TextRange, int>)@this->LpVtbl[33])(@this, fontStyle, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontStretch(this ComPtr<IDWriteTextLayout1> thisVtbl, FontStretch fontStretch, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontStretch, TextRange, int>)@this->LpVtbl[34])(@this, fontStretch, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontSize(this ComPtr<IDWriteTextLayout1> thisVtbl, float fontSize, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, TextRange, int>)@this->LpVtbl[35])(@this, fontSize, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetUnderline(this ComPtr<IDWriteTextLayout1> thisVtbl, Silk.NET.Core.Bool32 hasUnderline, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[36])(@this, hasUnderline, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStrikethrough(this ComPtr<IDWriteTextLayout1> thisVtbl, Silk.NET.Core.Bool32 hasStrikethrough, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[37])(@this, hasStrikethrough, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDrawingEffect(this ComPtr<IDWriteTextLayout1> thisVtbl, Silk.NET.Core.Native.IUnknown* drawingEffect, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Silk.NET.Core.Native.IUnknown*, TextRange, int>)@this->LpVtbl[38])(@this, drawingEffect, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInlineObject(this ComPtr<IDWriteTextLayout1> thisVtbl, IDWriteInlineObject* inlineObject, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, IDWriteInlineObject*, TextRange, int>)@this->LpVtbl[39])(@this, inlineObject, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTypography(this ComPtr<IDWriteTextLayout1> thisVtbl, IDWriteTypography* typography, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, IDWriteTypography*, TextRange, int>)@this->LpVtbl[40])(@this, typography, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetLocaleName(this ComPtr<IDWriteTextLayout1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, char*, TextRange, int>)@this->LpVtbl[41])(@this, localeName, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetMaxWidth(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float>)@this->LpVtbl[42])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetMaxHeight(this ComPtr<IDWriteTextLayout1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float>)@this->LpVtbl[43])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnderline(this ComPtr<IDWriteTextLayout1> thisVtbl, uint currentPosition, int* hasUnderline, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderline, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStrikethrough(this ComPtr<IDWriteTextLayout1> thisVtbl, uint currentPosition, int* hasStrikethrough, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethrough, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDrawingEffect(this ComPtr<IDWriteTextLayout1> thisVtbl, uint currentPosition, Silk.NET.Core.Native.IUnknown** drawingEffect, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffect, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInlineObject(this ComPtr<IDWriteTextLayout1> thisVtbl, uint currentPosition, IDWriteInlineObject** inlineObject, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObject, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypography(this ComPtr<IDWriteTextLayout1> thisVtbl, uint currentPosition, IDWriteTypography** typography, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typography, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteTextLayout1> thisVtbl, void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContext, renderer, originX, originY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineMetrics(this ComPtr<IDWriteTextLayout1> thisVtbl, LineMetrics* lineMetrics, uint maxLineCount, uint* actualLineCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetrics, maxLineCount, actualLineCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetrics(this ComPtr<IDWriteTextLayout1> thisVtbl, TextMetrics* textMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, TextMetrics*, int>)@this->LpVtbl[60])(@this, textMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOverhangMetrics(this ComPtr<IDWriteTextLayout1> thisVtbl, OverhangMetrics* overhangs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, OverhangMetrics*, int>)@this->LpVtbl[61])(@this, overhangs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClusterMetrics(this ComPtr<IDWriteTextLayout1> thisVtbl, ClusterMetrics* clusterMetrics, uint maxClusterCount, uint* actualClusterCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetrics, maxClusterCount, actualClusterCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetermineMinWidth(this ComPtr<IDWriteTextLayout1> thisVtbl, float* minWidth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float*, int>)@this->LpVtbl[63])(@this, minWidth);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout1> thisVtbl, float pointX, float pointY, int* isTrailingHit, int* isInside, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout1> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, float* pointY, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextRange(this ComPtr<IDWriteTextLayout1> thisVtbl, uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPairKerning(this ComPtr<IDWriteTextLayout1> thisVtbl, Silk.NET.Core.Bool32 isPairKerningEnabled, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[67])(@this, isPairKerningEnabled, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPairKerning(this ComPtr<IDWriteTextLayout1> thisVtbl, uint currentPosition, int* isPairKerningEnabled, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, int*, TextRange*, int>)@this->LpVtbl[68])(@this, currentPosition, isPairKerningEnabled, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCharacterSpacing(this ComPtr<IDWriteTextLayout1> thisVtbl, float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, float, float, TextRange, int>)@this->LpVtbl[69])(@this, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCharacterSpacing(this ComPtr<IDWriteTextLayout1> thisVtbl, uint currentPosition, float* leadingSpacing, float* trailingSpacing, float* minimumAdvanceWidth, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        return ret;
    }

}
