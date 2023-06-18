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

public unsafe static class DWriteFontFace4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontFaceType GetType(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontFaceType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontFaceType>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace4> thisVtbl, uint* numberOfFiles, IDWriteFontFile** fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFiles);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetIndex(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontSimulations GetSimulations(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontSimulations ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontSimulations>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSymbolFont(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetrics);
    }

    /// <summary>To be documented.</summary>
    public static ushort GetGlyphCount(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ushort ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetrics, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndices);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, void* tableContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, void*, void>)@this->LpVtbl[13])(@this, tableContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCaretMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, CaretMetrics* caretMetrics)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, CaretMetrics*, void>)@this->LpVtbl[20])(@this, caretMetrics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace4> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRanges, actualRangeCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsMonospacedFont(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[22])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndices, glyphAdvances, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndices, glyphAdvanceAdjustments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasKerningPairs(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, ushort* verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndices, verticalGlyphIndices);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasVerticalGlyphVariants(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[29])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsColorFont(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[30])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetColorPaletteCount(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[31])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPaletteEntryCount(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[32])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPaletteEntries(this ComPtr<IDWriteFontFace4> thisVtbl, uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, Silk.NET.DXGI.D3Dcolorvalue* paletteEntries)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, uint, uint, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[33])(@this, colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFaceReference(this ComPtr<IDWriteFontFace4> thisVtbl, IDWriteFontFaceReference** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteFontFaceReference**, int>)@this->LpVtbl[35])(@this, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPanose(this ComPtr<IDWriteFontFace4> thisVtbl, Panose* panose)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Panose*, void>)@this->LpVtbl[36])(@this, panose);
    }

    /// <summary>To be documented.</summary>
    public static FontWeight GetWeight(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontWeight ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontWeight>)@this->LpVtbl[37])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStretch GetStretch(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStretch ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontStretch>)@this->LpVtbl[38])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStyle GetStyle(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontStyle>)@this->LpVtbl[39])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFamilyNames(this ComPtr<IDWriteFontFace4> thisVtbl, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[40])(@this, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFaceNames(this ComPtr<IDWriteFontFace4> thisVtbl, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[41])(@this, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFontFace4> thisVtbl, InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[42])(@this, informationalStringID, informationalStrings, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasCharacter(this ComPtr<IDWriteFontFace4> thisVtbl, uint unicodeValue)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[43])(@this, unicodeValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsCharacterLocal(this ComPtr<IDWriteFontFace4> thisVtbl, uint unicodeValue)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[45])(@this, unicodeValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsGlyphLocal(this ComPtr<IDWriteFontFace4> thisVtbl, ushort glyphId)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, Silk.NET.Core.Bool32>)@this->LpVtbl[46])(@this, glyphId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, char*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, characters, characterCount, enqueueIfNotLocal, isLocal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreGlyphsLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[48])(@this, glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static GlyphImageFormats GetGlyphImageFormats(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        GlyphImageFormats ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, GlyphImageFormats>)@this->LpVtbl[50])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphImageData(this ComPtr<IDWriteFontFace4> thisVtbl, ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, GlyphImageData* glyphData, void** glyphDataContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)@this->LpVtbl[51])(@this, glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseGlyphImageData(this ComPtr<IDWriteFontFace4> thisVtbl, void* glyphDataContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, void*, void>)@this->LpVtbl[52])(@this, glyphDataContext);
    }

}
