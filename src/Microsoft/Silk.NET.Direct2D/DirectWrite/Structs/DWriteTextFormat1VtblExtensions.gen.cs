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

public unsafe static class DWriteTextFormat1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextFormat1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextAlignment(this ComPtr<IDWriteTextFormat1> thisVtbl, TextAlignment textAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, TextAlignment, int>)@this->LpVtbl[3])(@this, textAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetParagraphAlignment(this ComPtr<IDWriteTextFormat1> thisVtbl, ParagraphAlignment paragraphAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, ParagraphAlignment, int>)@this->LpVtbl[4])(@this, paragraphAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetWordWrapping(this ComPtr<IDWriteTextFormat1> thisVtbl, WordWrapping wordWrapping)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, WordWrapping, int>)@this->LpVtbl[5])(@this, wordWrapping);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetReadingDirection(this ComPtr<IDWriteTextFormat1> thisVtbl, ReadingDirection readingDirection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, ReadingDirection, int>)@this->LpVtbl[6])(@this, readingDirection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFlowDirection(this ComPtr<IDWriteTextFormat1> thisVtbl, FlowDirection flowDirection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, FlowDirection, int>)@this->LpVtbl[7])(@this, flowDirection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetIncrementalTabStop(this ComPtr<IDWriteTextFormat1> thisVtbl, float incrementalTabStop)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, float, int>)@this->LpVtbl[8])(@this, incrementalTabStop);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTrimming(this ComPtr<IDWriteTextFormat1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLineSpacing(this ComPtr<IDWriteTextFormat1> thisVtbl, LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, LineSpacingMethod, float, float, int>)@this->LpVtbl[10])(@this, lineSpacingMethod, lineSpacing, baseline);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static TextAlignment GetTextAlignment(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TextAlignment ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, TextAlignment>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ParagraphAlignment GetParagraphAlignment(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ParagraphAlignment ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, ParagraphAlignment>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static WordWrapping GetWordWrapping(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        WordWrapping ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, WordWrapping>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ReadingDirection GetReadingDirection(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ReadingDirection ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, ReadingDirection>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FlowDirection GetFlowDirection(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FlowDirection ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, FlowDirection>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetIncrementalTabStop(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, float>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrimming(this ComPtr<IDWriteTextFormat1> thisVtbl, Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextFormat1> thisVtbl, LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baseline);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteTextFormat1> thisVtbl, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontFamilyNameLength(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, uint>)@this->LpVtbl[20])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamilyName(this ComPtr<IDWriteTextFormat1> thisVtbl, char* fontFamilyName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyName, nameSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontWeight GetFontWeight(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontWeight ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, FontWeight>)@this->LpVtbl[22])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStyle GetFontStyle(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, FontStyle>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStretch GetFontStretch(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStretch ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, FontStretch>)@this->LpVtbl[24])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetFontSize(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, float>)@this->LpVtbl[25])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLocaleNameLength(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, uint>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextFormat1> thisVtbl, char* localeName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, char*, uint, int>)@this->LpVtbl[27])(@this, localeName, nameSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetVerticalGlyphOrientation(this ComPtr<IDWriteTextFormat1> thisVtbl, VerticalGlyphOrientation glyphOrientation)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, VerticalGlyphOrientation, int>)@this->LpVtbl[28])(@this, glyphOrientation);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static VerticalGlyphOrientation GetVerticalGlyphOrientation(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        VerticalGlyphOrientation ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, VerticalGlyphOrientation>)@this->LpVtbl[29])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLastLineWrapping(this ComPtr<IDWriteTextFormat1> thisVtbl, Silk.NET.Core.Bool32 isLastLineWrappingEnabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[30])(@this, isLastLineWrappingEnabled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetLastLineWrapping(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, Silk.NET.Core.Bool32>)@this->LpVtbl[31])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetOpticalAlignment(this ComPtr<IDWriteTextFormat1> thisVtbl, OpticalAlignment opticalAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, OpticalAlignment, int>)@this->LpVtbl[32])(@this, opticalAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static OpticalAlignment GetOpticalAlignment(this ComPtr<IDWriteTextFormat1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        OpticalAlignment ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, OpticalAlignment>)@this->LpVtbl[33])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFontFallback(this ComPtr<IDWriteTextFormat1> thisVtbl, IDWriteFontFallback* fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, IDWriteFontFallback*, int>)@this->LpVtbl[34])(@this, fontFallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFallback(this ComPtr<IDWriteTextFormat1> thisVtbl, IDWriteFontFallback** fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat1*, IDWriteFontFallback**, int>)@this->LpVtbl[35])(@this, fontFallback);
        return ret;
    }

}
