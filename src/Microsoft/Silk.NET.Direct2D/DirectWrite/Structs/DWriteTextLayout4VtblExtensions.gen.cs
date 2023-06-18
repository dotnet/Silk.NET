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

public unsafe static class DWriteTextLayout4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextLayout4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextAlignment(this ComPtr<IDWriteTextLayout4> thisVtbl, TextAlignment textAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, TextAlignment, int>)@this->LpVtbl[3])(@this, textAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetParagraphAlignment(this ComPtr<IDWriteTextLayout4> thisVtbl, ParagraphAlignment paragraphAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, ParagraphAlignment, int>)@this->LpVtbl[4])(@this, paragraphAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetWordWrapping(this ComPtr<IDWriteTextLayout4> thisVtbl, WordWrapping wordWrapping)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, WordWrapping, int>)@this->LpVtbl[5])(@this, wordWrapping);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetReadingDirection(this ComPtr<IDWriteTextLayout4> thisVtbl, ReadingDirection readingDirection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, ReadingDirection, int>)@this->LpVtbl[6])(@this, readingDirection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFlowDirection(this ComPtr<IDWriteTextLayout4> thisVtbl, FlowDirection flowDirection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, FlowDirection, int>)@this->LpVtbl[7])(@this, flowDirection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetIncrementalTabStop(this ComPtr<IDWriteTextLayout4> thisVtbl, float incrementalTabStop)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float, int>)@this->LpVtbl[8])(@this, incrementalTabStop);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTrimming(this ComPtr<IDWriteTextLayout4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLineSpacing(this ComPtr<IDWriteTextLayout4> thisVtbl, LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, LineSpacingMethod, float, float, int>)@this->LpVtbl[10])(@this, lineSpacingMethod, lineSpacing, baseline);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static TextAlignment GetTextAlignment(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TextAlignment ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, TextAlignment>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ParagraphAlignment GetParagraphAlignment(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ParagraphAlignment ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, ParagraphAlignment>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static WordWrapping GetWordWrapping(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        WordWrapping ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, WordWrapping>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ReadingDirection GetReadingDirection(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ReadingDirection ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, ReadingDirection>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FlowDirection GetFlowDirection(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FlowDirection ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, FlowDirection>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetIncrementalTabStop(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrimming(this ComPtr<IDWriteTextLayout4> thisVtbl, Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout4> thisVtbl, LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baseline);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteTextLayout4> thisVtbl, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontFamilyNameLength(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint>)@this->LpVtbl[20])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamilyName(this ComPtr<IDWriteTextLayout4> thisVtbl, char* fontFamilyName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyName, nameSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontWeight GetFontWeight(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontWeight ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, FontWeight>)@this->LpVtbl[22])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStyle GetFontStyle(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, FontStyle>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStretch GetFontStretch(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStretch ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, FontStretch>)@this->LpVtbl[24])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetFontSize(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float>)@this->LpVtbl[25])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLocaleNameLength(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextLayout4> thisVtbl, char* localeName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, char*, uint, int>)@this->LpVtbl[27])(@this, localeName, nameSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaxWidth(this ComPtr<IDWriteTextLayout4> thisVtbl, float maxWidth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float, int>)@this->LpVtbl[28])(@this, maxWidth);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaxHeight(this ComPtr<IDWriteTextLayout4> thisVtbl, float maxHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float, int>)@this->LpVtbl[29])(@this, maxHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFontCollection(this ComPtr<IDWriteTextLayout4> thisVtbl, IDWriteFontCollection* fontCollection, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, IDWriteFontCollection*, TextRange, int>)@this->LpVtbl[30])(@this, fontCollection, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFontFamilyName(this ComPtr<IDWriteTextLayout4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, char*, TextRange, int>)@this->LpVtbl[31])(@this, fontFamilyName, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontWeight(this ComPtr<IDWriteTextLayout4> thisVtbl, FontWeight fontWeight, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, FontWeight, TextRange, int>)@this->LpVtbl[32])(@this, fontWeight, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontStyle(this ComPtr<IDWriteTextLayout4> thisVtbl, FontStyle fontStyle, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, FontStyle, TextRange, int>)@this->LpVtbl[33])(@this, fontStyle, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontStretch(this ComPtr<IDWriteTextLayout4> thisVtbl, FontStretch fontStretch, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, FontStretch, TextRange, int>)@this->LpVtbl[34])(@this, fontStretch, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontSize(this ComPtr<IDWriteTextLayout4> thisVtbl, float fontSize, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float, TextRange, int>)@this->LpVtbl[35])(@this, fontSize, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetUnderline(this ComPtr<IDWriteTextLayout4> thisVtbl, Silk.NET.Core.Bool32 hasUnderline, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[36])(@this, hasUnderline, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStrikethrough(this ComPtr<IDWriteTextLayout4> thisVtbl, Silk.NET.Core.Bool32 hasStrikethrough, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[37])(@this, hasStrikethrough, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDrawingEffect(this ComPtr<IDWriteTextLayout4> thisVtbl, Silk.NET.Core.Native.IUnknown* drawingEffect, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, Silk.NET.Core.Native.IUnknown*, TextRange, int>)@this->LpVtbl[38])(@this, drawingEffect, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInlineObject(this ComPtr<IDWriteTextLayout4> thisVtbl, IDWriteInlineObject* inlineObject, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, IDWriteInlineObject*, TextRange, int>)@this->LpVtbl[39])(@this, inlineObject, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTypography(this ComPtr<IDWriteTextLayout4> thisVtbl, IDWriteTypography* typography, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, IDWriteTypography*, TextRange, int>)@this->LpVtbl[40])(@this, typography, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetLocaleName(this ComPtr<IDWriteTextLayout4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, char*, TextRange, int>)@this->LpVtbl[41])(@this, localeName, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetMaxWidth(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float>)@this->LpVtbl[42])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetMaxHeight(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float>)@this->LpVtbl[43])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnderline(this ComPtr<IDWriteTextLayout4> thisVtbl, uint currentPosition, int* hasUnderline, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderline, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStrikethrough(this ComPtr<IDWriteTextLayout4> thisVtbl, uint currentPosition, int* hasStrikethrough, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethrough, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDrawingEffect(this ComPtr<IDWriteTextLayout4> thisVtbl, uint currentPosition, Silk.NET.Core.Native.IUnknown** drawingEffect, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffect, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInlineObject(this ComPtr<IDWriteTextLayout4> thisVtbl, uint currentPosition, IDWriteInlineObject** inlineObject, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObject, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypography(this ComPtr<IDWriteTextLayout4> thisVtbl, uint currentPosition, IDWriteTypography** typography, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typography, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteTextLayout4> thisVtbl, void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContext, renderer, originX, originY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineMetrics(this ComPtr<IDWriteTextLayout4> thisVtbl, LineMetrics* lineMetrics, uint maxLineCount, uint* actualLineCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetrics, maxLineCount, actualLineCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetrics(this ComPtr<IDWriteTextLayout4> thisVtbl, TextMetrics* textMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, TextMetrics*, int>)@this->LpVtbl[60])(@this, textMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOverhangMetrics(this ComPtr<IDWriteTextLayout4> thisVtbl, OverhangMetrics* overhangs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, OverhangMetrics*, int>)@this->LpVtbl[61])(@this, overhangs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClusterMetrics(this ComPtr<IDWriteTextLayout4> thisVtbl, ClusterMetrics* clusterMetrics, uint maxClusterCount, uint* actualClusterCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetrics, maxClusterCount, actualClusterCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetermineMinWidth(this ComPtr<IDWriteTextLayout4> thisVtbl, float* minWidth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float*, int>)@this->LpVtbl[63])(@this, minWidth);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout4> thisVtbl, float pointX, float pointY, int* isTrailingHit, int* isInside, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout4> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, float* pointY, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextRange(this ComPtr<IDWriteTextLayout4> thisVtbl, uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPairKerning(this ComPtr<IDWriteTextLayout4> thisVtbl, Silk.NET.Core.Bool32 isPairKerningEnabled, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[67])(@this, isPairKerningEnabled, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPairKerning(this ComPtr<IDWriteTextLayout4> thisVtbl, uint currentPosition, int* isPairKerningEnabled, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, int*, TextRange*, int>)@this->LpVtbl[68])(@this, currentPosition, isPairKerningEnabled, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetCharacterSpacing(this ComPtr<IDWriteTextLayout4> thisVtbl, float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, float, float, float, TextRange, int>)@this->LpVtbl[69])(@this, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCharacterSpacing(this ComPtr<IDWriteTextLayout4> thisVtbl, uint currentPosition, float* leadingSpacing, float* trailingSpacing, float* minimumAdvanceWidth, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVerticalGlyphOrientation(this ComPtr<IDWriteTextLayout4> thisVtbl, VerticalGlyphOrientation glyphOrientation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, VerticalGlyphOrientation, int>)@this->LpVtbl[72])(@this, glyphOrientation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static VerticalGlyphOrientation GetVerticalGlyphOrientation(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        VerticalGlyphOrientation ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, VerticalGlyphOrientation>)@this->LpVtbl[73])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLastLineWrapping(this ComPtr<IDWriteTextLayout4> thisVtbl, Silk.NET.Core.Bool32 isLastLineWrappingEnabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[74])(@this, isLastLineWrappingEnabled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetLastLineWrapping(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, Silk.NET.Core.Bool32>)@this->LpVtbl[75])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOpticalAlignment(this ComPtr<IDWriteTextLayout4> thisVtbl, OpticalAlignment opticalAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, OpticalAlignment, int>)@this->LpVtbl[76])(@this, opticalAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static OpticalAlignment GetOpticalAlignment(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        OpticalAlignment ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, OpticalAlignment>)@this->LpVtbl[77])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFontFallback(this ComPtr<IDWriteTextLayout4> thisVtbl, IDWriteFontFallback* fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, IDWriteFontFallback*, int>)@this->LpVtbl[78])(@this, fontFallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFallback(this ComPtr<IDWriteTextLayout4> thisVtbl, IDWriteFontFallback** fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, IDWriteFontFallback**, int>)@this->LpVtbl[79])(@this, fontFallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InvalidateLayout(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, int>)@this->LpVtbl[80])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFontAxisValues(this ComPtr<IDWriteTextLayout4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, FontAxisValue*, uint, TextRange, int>)@this->LpVtbl[84])(@this, fontAxisValues, fontAxisValueCount, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontAxisValueCount(this ComPtr<IDWriteTextLayout4> thisVtbl, uint currentPosition)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, uint>)@this->LpVtbl[85])(@this, currentPosition);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAxisValues(this ComPtr<IDWriteTextLayout4> thisVtbl, uint currentPosition, FontAxisValue* fontAxisValues, uint fontAxisValueCount, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, uint, FontAxisValue*, uint, TextRange*, int>)@this->LpVtbl[86])(@this, currentPosition, fontAxisValues, fontAxisValueCount, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static AutomaticFontAxes GetAutomaticFontAxes(this ComPtr<IDWriteTextLayout4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        AutomaticFontAxes ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, AutomaticFontAxes>)@this->LpVtbl[87])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAutomaticFontAxes(this ComPtr<IDWriteTextLayout4> thisVtbl, AutomaticFontAxes automaticFontAxes)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout4*, AutomaticFontAxes, int>)@this->LpVtbl[88])(@this, automaticFontAxes);
        return ret;
    }

}
