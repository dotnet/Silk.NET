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

public unsafe static class DWriteFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFactory> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFactory> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSystemFontCollection(this ComPtr<IDWriteFactory> thisVtbl, IDWriteFontCollection** fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, fontCollection, checkForUpdates);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection(this ComPtr<IDWriteFactory> thisVtbl, IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKey, collectionKeySize, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterFontCollectionLoader(this ComPtr<IDWriteFactory> thisVtbl, IDWriteFontCollectionLoader* fontCollectionLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[5])(@this, fontCollectionLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnregisterFontCollectionLoader(this ComPtr<IDWriteFactory> thisVtbl, IDWriteFontCollectionLoader* fontCollectionLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[6])(@this, fontCollectionLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTime, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference(this ComPtr<IDWriteFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFactory> thisVtbl, FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderingParams(this ComPtr<IDWriteFactory> thisVtbl, IDWriteRenderingParams** renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteRenderingParams**, int>)@this->LpVtbl[10])(@this, renderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMonitorRenderingParams(this ComPtr<IDWriteFactory> thisVtbl, nint monitor, IDWriteRenderingParams** renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, nint, IDWriteRenderingParams**, int>)@this->LpVtbl[11])(@this, monitor, renderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomRenderingParams(this ComPtr<IDWriteFactory> thisVtbl, float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)@this->LpVtbl[12])(@this, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterFontFileLoader(this ComPtr<IDWriteFactory> thisVtbl, IDWriteFontFileLoader* fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontFileLoader*, int>)@this->LpVtbl[13])(@this, fontFileLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnregisterFontFileLoader(this ComPtr<IDWriteFactory> thisVtbl, IDWriteFontFileLoader* fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontFileLoader*, int>)@this->LpVtbl[14])(@this, fontFileLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypography(this ComPtr<IDWriteFactory> thisVtbl, IDWriteTypography** typography)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTypography**, int>)@this->LpVtbl[16])(@this, typography);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiInterop(this ComPtr<IDWriteFactory> thisVtbl, IDWriteGdiInterop** gdiInterop)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteGdiInterop**, int>)@this->LpVtbl[17])(@this, gdiInterop);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipsisTrimmingSign(this ComPtr<IDWriteFactory> thisVtbl, IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormat, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextAnalyzer(this ComPtr<IDWriteFactory> thisVtbl, IDWriteTextAnalyzer** textAnalyzer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTextAnalyzer**, int>)@this->LpVtbl[21])(@this, textAnalyzer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution(this ComPtr<IDWriteFactory> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        return ret;
    }

}
