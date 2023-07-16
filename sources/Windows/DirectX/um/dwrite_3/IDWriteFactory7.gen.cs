// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteFactory7.xml' path='doc/member[@name="IDWriteFactory7"]/*'/>
[Guid("35D0E0B3-9076-4D2E-A016-A91B568A06B4")]
[NativeTypeName("struct IDWriteFactory7 : IDWriteFactory6")]
[NativeInheritance("IDWriteFactory6")]
public unsafe partial struct IDWriteFactory7 : IDWriteFactory7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFactory7));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFactory7*, uint> )(lpVtbl[1]))((IDWriteFactory7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFactory7*, uint> )(lpVtbl[2]))((IDWriteFactory7*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFactory.GetSystemFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSystemFontCollection(IDWriteFontCollection** fontCollection, [Optional] BOOL checkForUpdates)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontCollection**, BOOL, int> )(lpVtbl[3]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateCustomFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int> )(lpVtbl[4]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
    }

    /// <inheritdoc cref = "IDWriteFactory.RegisterFontCollectionLoader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontCollectionLoader*, int> )(lpVtbl[5]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontCollectionLoader);
    }

    /// <inheritdoc cref = "IDWriteFactory.UnregisterFontCollectionLoader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontCollectionLoader*, int> )(lpVtbl[6]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontCollectionLoader);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateFontFileReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFontFileReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, IDWriteFontFile** fontFile)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, ushort*, FILETIME*, IDWriteFontFile**, int> )(lpVtbl[7]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateCustomFontFileReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateCustomFontFileReference([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int> )(lpVtbl[8]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateFontFace"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, DWRITE_FONT_FACE_TYPE, uint, IDWriteFontFile**, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFace**, int> )(lpVtbl[9]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateRenderingParams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateRenderingParams(IDWriteRenderingParams** renderingParams)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteRenderingParams**, int> )(lpVtbl[10]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), renderingParams);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateMonitorRenderingParams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateMonitorRenderingParams(HMONITOR monitor, IDWriteRenderingParams** renderingParams)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, HMONITOR, IDWriteRenderingParams**, int> )(lpVtbl[11]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), monitor, renderingParams);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateCustomRenderingParams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams** renderingParams)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams**, int> )(lpVtbl[12]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
    }

    /// <inheritdoc cref = "IDWriteFactory.RegisterFontFileLoader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontFileLoader*, int> )(lpVtbl[13]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFileLoader);
    }

    /// <inheritdoc cref = "IDWriteFactory.UnregisterFontFileLoader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontFileLoader*, int> )(lpVtbl[14]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFileLoader);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateTextFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateTextFormat([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, IDWriteTextFormat** textFormat)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, ushort*, IDWriteFontCollection*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, float, ushort*, IDWriteTextFormat**, int> )(lpVtbl[15]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateTypography"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateTypography(IDWriteTypography** typography)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteTypography**, int> )(lpVtbl[16]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), typography);
    }

    /// <inheritdoc cref = "IDWriteFactory.GetGdiInterop"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetGdiInterop(IDWriteGdiInterop** gdiInterop)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteGdiInterop**, int> )(lpVtbl[17]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), gdiInterop);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateTextLayout"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, ushort*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int> )(lpVtbl[18]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateGdiCompatibleTextLayout"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateGdiCompatibleTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, IDWriteTextLayout** textLayout)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, ushort*, uint, IDWriteTextFormat*, float, float, float, DWRITE_MATRIX*, BOOL, IDWriteTextLayout**, int> )(lpVtbl[19]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateEllipsisTrimmingSign"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteTextFormat*, IDWriteInlineObject**, int> )(lpVtbl[20]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateTextAnalyzer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteTextAnalyzer**, int> )(lpVtbl[21]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), textAnalyzer);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateNumberSubstitution"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] ushort* localeName, BOOL ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, DWRITE_NUMBER_SUBSTITUTION_METHOD, ushort*, BOOL, IDWriteNumberSubstitution**, int> )(lpVtbl[22]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateGlyphRunAnalysis"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, DWRITE_GLYPH_RUN*, float, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, float, float, IDWriteGlyphRunAnalysis**, int> )(lpVtbl[23]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
    }

    /// <inheritdoc cref = "IDWriteFactory1.GetEudcFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetEudcFontCollection(IDWriteFontCollection** fontCollection, [Optional] BOOL checkForUpdates)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontCollection**, BOOL, int> )(lpVtbl[24]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
    }

    /// <inheritdoc cref = "IDWriteFactory1.CreateCustomRenderingParams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams1** renderingParams)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams1**, int> )(lpVtbl[25]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
    }

    /// <inheritdoc cref = "IDWriteFactory2.GetSystemFontFallback"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetSystemFontFallback(IDWriteFontFallback** fontFallback)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontFallback**, int> )(lpVtbl[26]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFallback);
    }

    /// <inheritdoc cref = "IDWriteFactory2.CreateFontFallbackBuilder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateFontFallbackBuilder(IDWriteFontFallbackBuilder** fontFallbackBuilder)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontFallbackBuilder**, int> )(lpVtbl[27]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFallbackBuilder);
    }

    /// <inheritdoc cref = "IDWriteFactory2.TranslateColorGlyphRun"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldToDeviceTransform, [NativeTypeName("UINT32")] uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, float, float, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, DWRITE_MEASURING_MODE, DWRITE_MATRIX*, uint, IDWriteColorGlyphRunEnumerator**, int> )(lpVtbl[28]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
    }

    /// <inheritdoc cref = "IDWriteFactory2.CreateCustomRenderingParams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, IDWriteRenderingParams2** renderingParams)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams2**, int> )(lpVtbl[29]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
    }

    /// <inheritdoc cref = "IDWriteFactory2.CreateGlyphRunAnalysis"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, DWRITE_GLYPH_RUN*, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, float, float, IDWriteGlyphRunAnalysis**, int> )(lpVtbl[30]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
    }

    /// <inheritdoc cref = "IDWriteFactory3.CreateGlyphRunAnalysis"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, DWRITE_GLYPH_RUN*, DWRITE_MATRIX*, DWRITE_RENDERING_MODE1, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, float, float, IDWriteGlyphRunAnalysis**, int> )(lpVtbl[31]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), glyphRun, transform, renderingMode, measuringMode, gridFitMode, antialiasMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
    }

    /// <inheritdoc cref = "IDWriteFactory3.CreateCustomRenderingParams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, IDWriteRenderingParams3** renderingParams)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE1, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams3**, int> )(lpVtbl[32]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, grayscaleEnhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, gridFitMode, renderingParams);
    }

    /// <inheritdoc cref = "IDWriteFactory3.CreateFontFaceReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT CreateFontFaceReference(IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, IDWriteFontFaceReference** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontFile*, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference**, int> )(lpVtbl[33]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontSimulations, fontFaceReference);
    }

    /// <inheritdoc cref = "IDWriteFactory3.CreateFontFaceReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT CreateFontFaceReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, IDWriteFontFaceReference** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, ushort*, FILETIME*, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference**, int> )(lpVtbl[34]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
    }

    /// <inheritdoc cref = "IDWriteFactory3.GetSystemFontSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetSystemFontSet(IDWriteFontSet** fontSet)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontSet**, int> )(lpVtbl[35]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontSet);
    }

    /// <inheritdoc cref = "IDWriteFactory3.CreateFontSetBuilder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CreateFontSetBuilder(IDWriteFontSetBuilder** fontSetBuilder)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontSetBuilder**, int> )(lpVtbl[36]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontSetBuilder);
    }

    /// <inheritdoc cref = "IDWriteFactory3.CreateFontCollectionFromFontSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, IDWriteFontCollection1** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontSet*, IDWriteFontCollection1**, int> )(lpVtbl[37]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontSet, fontCollection);
    }

    /// <inheritdoc cref = "IDWriteFactory3.GetSystemFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT GetSystemFontCollection(BOOL includeDownloadableFonts, IDWriteFontCollection1** fontCollection, [Optional] BOOL checkForUpdates)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, BOOL, IDWriteFontCollection1**, BOOL, int> )(lpVtbl[38]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontCollection, checkForUpdates);
    }

    /// <inheritdoc cref = "IDWriteFactory3.GetFontDownloadQueue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT GetFontDownloadQueue(IDWriteFontDownloadQueue** fontDownloadQueue)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontDownloadQueue**, int> )(lpVtbl[39]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontDownloadQueue);
    }

    /// <inheritdoc cref = "IDWriteFactory4.TranslateColorGlyphRun"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT TranslateColorGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, DWRITE_GLYPH_IMAGE_FORMATS desiredGlyphImageFormats, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldAndDpiTransform, [NativeTypeName("UINT32")] uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator1** colorLayers)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_MEASURING_MODE, DWRITE_MATRIX*, uint, IDWriteColorGlyphRunEnumerator1**, int> )(lpVtbl[40]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, desiredGlyphImageFormats, measuringMode, worldAndDpiTransform, colorPaletteIndex, colorLayers);
    }

    /// <inheritdoc cref = "IDWriteFactory4.ComputeGlyphOrigins"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT ComputeGlyphOrigins([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* glyphOrigins)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, DWRITE_GLYPH_RUN*, D2D_POINT_2F, D2D_POINT_2F*, int> )(lpVtbl[41]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), glyphRun, baselineOrigin, glyphOrigins);
    }

    /// <inheritdoc cref = "IDWriteFactory4.ComputeGlyphOrigins"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT ComputeGlyphOrigins([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* worldAndDpiTransform, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* glyphOrigins)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, DWRITE_GLYPH_RUN*, DWRITE_MEASURING_MODE, D2D_POINT_2F, DWRITE_MATRIX*, D2D_POINT_2F*, int> )(lpVtbl[42]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
    }

    /// <inheritdoc cref = "IDWriteFactory5.CreateFontSetBuilder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT CreateFontSetBuilder(IDWriteFontSetBuilder1** fontSetBuilder)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontSetBuilder1**, int> )(lpVtbl[43]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontSetBuilder);
    }

    /// <inheritdoc cref = "IDWriteFactory5.CreateInMemoryFontFileLoader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT CreateInMemoryFontFileLoader(IDWriteInMemoryFontFileLoader** newLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteInMemoryFontFileLoader**, int> )(lpVtbl[44]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), newLoader);
    }

    /// <inheritdoc cref = "IDWriteFactory5.CreateHttpFontFileLoader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT CreateHttpFontFileLoader([NativeTypeName("const wchar_t *")] ushort* referrerUrl, [NativeTypeName("const wchar_t *")] ushort* extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, ushort*, ushort*, IDWriteRemoteFontFileLoader**, int> )(lpVtbl[45]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), referrerUrl, extraHeaders, newLoader);
    }

    /// <inheritdoc cref = "IDWriteFactory5.AnalyzeContainerType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public DWRITE_CONTAINER_TYPE AnalyzeContainerType([NativeTypeName("const void *")] void* fileData, [NativeTypeName("UINT32")] uint fileDataSize)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, void*, uint, DWRITE_CONTAINER_TYPE> )(lpVtbl[46]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fileData, fileDataSize);
    }

    /// <inheritdoc cref = "IDWriteFactory5.UnpackFontFile"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT UnpackFontFile(DWRITE_CONTAINER_TYPE containerType, [NativeTypeName("const void *")] void* fileData, [NativeTypeName("UINT32")] uint fileDataSize, IDWriteFontFileStream** unpackedFontStream)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, DWRITE_CONTAINER_TYPE, void*, uint, IDWriteFontFileStream**, int> )(lpVtbl[47]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), containerType, fileData, fileDataSize, unpackedFontStream);
    }

    /// <inheritdoc cref = "IDWriteFactory6.CreateFontFaceReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT CreateFontFaceReference(IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontFile*, uint, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFaceReference1**, int> )(lpVtbl[48]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
    }

    /// <inheritdoc cref = "IDWriteFactory6.CreateFontResource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT CreateFontResource(IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint faceIndex, IDWriteFontResource** fontResource)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontFile*, uint, IDWriteFontResource**, int> )(lpVtbl[49]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFile, faceIndex, fontResource);
    }

    /// <inheritdoc cref = "IDWriteFactory6.GetSystemFontSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT GetSystemFontSet(BOOL includeDownloadableFonts, IDWriteFontSet1** fontSet)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, BOOL, IDWriteFontSet1**, int> )(lpVtbl[50]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontSet);
    }

    /// <inheritdoc cref = "IDWriteFactory6.GetSystemFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT GetSystemFontCollection(BOOL includeDownloadableFonts, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteFontCollection2** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, BOOL, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection2**, int> )(lpVtbl[51]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontFamilyModel, fontCollection);
    }

    /// <inheritdoc cref = "IDWriteFactory6.CreateFontCollectionFromFontSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteFontCollection2** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontSet*, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection2**, int> )(lpVtbl[52]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontSet, fontFamilyModel, fontCollection);
    }

    /// <inheritdoc cref = "IDWriteFactory6.CreateFontSetBuilder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT CreateFontSetBuilder(IDWriteFontSetBuilder2** fontSetBuilder)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, IDWriteFontSetBuilder2**, int> )(lpVtbl[53]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontSetBuilder);
    }

    /// <inheritdoc cref = "IDWriteFactory6.CreateTextFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT CreateTextFormat([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, IDWriteFontCollection* fontCollection, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, IDWriteTextFormat3** textFormat)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, ushort*, IDWriteFontCollection*, DWRITE_FONT_AXIS_VALUE*, uint, float, ushort*, IDWriteTextFormat3**, int> )(lpVtbl[54]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontAxisValues, fontAxisValueCount, fontSize, localeName, textFormat);
    }

    /// <include file='IDWriteFactory7.xml' path='doc/member[@name="IDWriteFactory7.GetSystemFontSet"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT GetSystemFontSet(BOOL includeDownloadableFonts, IDWriteFontSet2** fontSet)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, BOOL, IDWriteFontSet2**, int> )(lpVtbl[55]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontSet);
    }

    /// <include file='IDWriteFactory7.xml' path='doc/member[@name="IDWriteFactory7.GetSystemFontCollection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT GetSystemFontCollection(BOOL includeDownloadableFonts, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteFontCollection3** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteFactory7*, BOOL, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection3**, int> )(lpVtbl[56]))((IDWriteFactory7*)Unsafe.AsPointer(ref this), includeDownloadableFonts, fontFamilyModel, fontCollection);
    }

    public interface Interface : IDWriteFactory6.Interface
    {
        [VtblIndex(55)]
        HRESULT GetSystemFontSet(BOOL includeDownloadableFonts, IDWriteFontSet2** fontSet);
        [VtblIndex(56)]
        HRESULT GetSystemFontCollection(BOOL includeDownloadableFonts, DWRITE_FONT_FAMILY_MODEL fontFamilyModel, IDWriteFontCollection3** fontCollection);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (IDWriteFontCollection **, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection**, BOOL, int> GetSystemFontCollection;
        [NativeTypeName("HRESULT (IDWriteFontCollectionLoader *, const void *, UINT32, IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int> CreateCustomFontCollection;
        [NativeTypeName("HRESULT (IDWriteFontCollectionLoader *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontCollectionLoader*, int> RegisterFontCollectionLoader;
        [NativeTypeName("HRESULT (IDWriteFontCollectionLoader *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontCollectionLoader*, int> UnregisterFontCollectionLoader;
        [NativeTypeName("HRESULT (const WCHAR *, const FILETIME *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, FILETIME*, IDWriteFontFile**, int> CreateFontFileReference;
        [NativeTypeName("HRESULT (const void *, UINT32, IDWriteFontFileLoader *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int> CreateCustomFontFileReference;
        [NativeTypeName("HRESULT (DWRITE_FONT_FACE_TYPE, UINT32, IDWriteFontFile *const *, UINT32, DWRITE_FONT_SIMULATIONS, IDWriteFontFace **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_FACE_TYPE, uint, IDWriteFontFile**, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFace**, int> CreateFontFace;
        [NativeTypeName("HRESULT (IDWriteRenderingParams **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteRenderingParams**, int> CreateRenderingParams;
        [NativeTypeName("HRESULT (HMONITOR, IDWriteRenderingParams **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMONITOR, IDWriteRenderingParams**, int> CreateMonitorRenderingParams;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams**, int> CreateCustomRenderingParams;
        [NativeTypeName("HRESULT (IDWriteFontFileLoader *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFileLoader*, int> RegisterFontFileLoader;
        [NativeTypeName("HRESULT (IDWriteFontFileLoader *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFileLoader*, int> UnregisterFontFileLoader;
        [NativeTypeName("HRESULT (const WCHAR *, IDWriteFontCollection *, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, FLOAT, const WCHAR *, IDWriteTextFormat **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDWriteFontCollection*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, float, ushort*, IDWriteTextFormat**, int> CreateTextFormat;
        [NativeTypeName("HRESULT (IDWriteTypography **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteTypography**, int> CreateTypography;
        [NativeTypeName("HRESULT (IDWriteGdiInterop **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteGdiInterop**, int> GetGdiInterop;
        [NativeTypeName("HRESULT (const WCHAR *, UINT32, IDWriteTextFormat *, FLOAT, FLOAT, IDWriteTextLayout **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int> CreateTextLayout;
        [NativeTypeName("HRESULT (const WCHAR *, UINT32, IDWriteTextFormat *, FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, IDWriteTextLayout **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, IDWriteTextFormat*, float, float, float, DWRITE_MATRIX*, BOOL, IDWriteTextLayout**, int> CreateGdiCompatibleTextLayout;
        [NativeTypeName("HRESULT (IDWriteTextFormat *, IDWriteInlineObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteTextFormat*, IDWriteInlineObject**, int> CreateEllipsisTrimmingSign;
        [NativeTypeName("HRESULT (IDWriteTextAnalyzer **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteTextAnalyzer**, int> CreateTextAnalyzer;
        [NativeTypeName("HRESULT (DWRITE_NUMBER_SUBSTITUTION_METHOD, const WCHAR *, BOOL, IDWriteNumberSubstitution **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_NUMBER_SUBSTITUTION_METHOD, ushort*, BOOL, IDWriteNumberSubstitution**, int> CreateNumberSubstitution;
        [NativeTypeName("HRESULT (const DWRITE_GLYPH_RUN *, FLOAT, const DWRITE_MATRIX *, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, FLOAT, FLOAT, IDWriteGlyphRunAnalysis **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_GLYPH_RUN*, float, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, float, float, IDWriteGlyphRunAnalysis**, int> CreateGlyphRunAnalysis;
        [NativeTypeName("HRESULT (IDWriteFontCollection **, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection**, BOOL, int> GetEudcFontCollection;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams1**, int> CreateCustomRenderingParams1;
        [NativeTypeName("HRESULT (IDWriteFontFallback **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFallback**, int> GetSystemFontFallback;
        [NativeTypeName("HRESULT (IDWriteFontFallbackBuilder **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFallbackBuilder**, int> CreateFontFallbackBuilder;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, DWRITE_MEASURING_MODE, const DWRITE_MATRIX *, UINT32, IDWriteColorGlyphRunEnumerator **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, DWRITE_MEASURING_MODE, DWRITE_MATRIX*, uint, IDWriteColorGlyphRunEnumerator**, int> TranslateColorGlyphRun;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams2**, int> CreateCustomRenderingParams2;
        [NativeTypeName("HRESULT (const DWRITE_GLYPH_RUN *, const DWRITE_MATRIX *, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, FLOAT, FLOAT, IDWriteGlyphRunAnalysis **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_GLYPH_RUN*, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, float, float, IDWriteGlyphRunAnalysis**, int> CreateGlyphRunAnalysis1;
        [NativeTypeName("HRESULT (const DWRITE_GLYPH_RUN *, const DWRITE_MATRIX *, DWRITE_RENDERING_MODE1, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, FLOAT, FLOAT, IDWriteGlyphRunAnalysis **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_GLYPH_RUN*, DWRITE_MATRIX*, DWRITE_RENDERING_MODE1, DWRITE_MEASURING_MODE, DWRITE_GRID_FIT_MODE, DWRITE_TEXT_ANTIALIAS_MODE, float, float, IDWriteGlyphRunAnalysis**, int> CreateGlyphRunAnalysis2;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE1, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE1, DWRITE_GRID_FIT_MODE, IDWriteRenderingParams3**, int> CreateCustomRenderingParams3;
        [NativeTypeName("HRESULT (IDWriteFontFile *, UINT32, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFile*, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference**, int> CreateFontFaceReference;
        [NativeTypeName("HRESULT (const WCHAR *, const FILETIME *, UINT32, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, FILETIME*, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFaceReference**, int> CreateFontFaceReference1;
        [NativeTypeName("HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontSet**, int> GetSystemFontSet;
        [NativeTypeName("HRESULT (IDWriteFontSetBuilder **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontSetBuilder**, int> CreateFontSetBuilder;
        [NativeTypeName("HRESULT (IDWriteFontSet *, IDWriteFontCollection1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontSet*, IDWriteFontCollection1**, int> CreateFontCollectionFromFontSet;
        [NativeTypeName("HRESULT (BOOL, IDWriteFontCollection1 **, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, IDWriteFontCollection1**, BOOL, int> GetSystemFontCollection1;
        [NativeTypeName("HRESULT (IDWriteFontDownloadQueue **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontDownloadQueue**, int> GetFontDownloadQueue;
        [NativeTypeName("HRESULT (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_MEASURING_MODE, const DWRITE_MATRIX *, UINT32, IDWriteColorGlyphRunEnumerator1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_MEASURING_MODE, DWRITE_MATRIX*, uint, IDWriteColorGlyphRunEnumerator1**, int> TranslateColorGlyphRun1;
        [NativeTypeName("HRESULT (const DWRITE_GLYPH_RUN *, D2D1_POINT_2F, D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_GLYPH_RUN*, D2D_POINT_2F, D2D_POINT_2F*, int> ComputeGlyphOrigins;
        [NativeTypeName("HRESULT (const DWRITE_GLYPH_RUN *, DWRITE_MEASURING_MODE, D2D1_POINT_2F, const DWRITE_MATRIX *, D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_GLYPH_RUN*, DWRITE_MEASURING_MODE, D2D_POINT_2F, DWRITE_MATRIX*, D2D_POINT_2F*, int> ComputeGlyphOrigins1;
        [NativeTypeName("HRESULT (IDWriteFontSetBuilder1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontSetBuilder1**, int> CreateFontSetBuilder1;
        [NativeTypeName("HRESULT (IDWriteInMemoryFontFileLoader **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteInMemoryFontFileLoader**, int> CreateInMemoryFontFileLoader;
        [NativeTypeName("HRESULT (const wchar_t *, const wchar_t *, IDWriteRemoteFontFileLoader **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IDWriteRemoteFontFileLoader**, int> CreateHttpFontFileLoader;
        [NativeTypeName("DWRITE_CONTAINER_TYPE (const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, DWRITE_CONTAINER_TYPE> AnalyzeContainerType;
        [NativeTypeName("HRESULT (DWRITE_CONTAINER_TYPE, const void *, UINT32, IDWriteFontFileStream **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_CONTAINER_TYPE, void*, uint, IDWriteFontFileStream**, int> UnpackFontFile;
        [NativeTypeName("HRESULT (IDWriteFontFile *, UINT32, DWRITE_FONT_SIMULATIONS, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontFaceReference1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFile*, uint, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFaceReference1**, int> CreateFontFaceReference2;
        [NativeTypeName("HRESULT (IDWriteFontFile *, UINT32, IDWriteFontResource **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFile*, uint, IDWriteFontResource**, int> CreateFontResource;
        [NativeTypeName("HRESULT (BOOL, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, IDWriteFontSet1**, int> GetSystemFontSet1;
        [NativeTypeName("HRESULT (BOOL, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection2**, int> GetSystemFontCollection2;
        [NativeTypeName("HRESULT (IDWriteFontSet *, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontSet*, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection2**, int> CreateFontCollectionFromFontSet1;
        [NativeTypeName("HRESULT (IDWriteFontSetBuilder2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontSetBuilder2**, int> CreateFontSetBuilder2;
        [NativeTypeName("HRESULT (const WCHAR *, IDWriteFontCollection *, const DWRITE_FONT_AXIS_VALUE *, UINT32, FLOAT, const WCHAR *, IDWriteTextFormat3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDWriteFontCollection*, DWRITE_FONT_AXIS_VALUE*, uint, float, ushort*, IDWriteTextFormat3**, int> CreateTextFormat1;
        [NativeTypeName("HRESULT (BOOL, IDWriteFontSet2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, IDWriteFontSet2**, int> GetSystemFontSet2;
        [NativeTypeName("HRESULT (BOOL, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, DWRITE_FONT_FAMILY_MODEL, IDWriteFontCollection3**, int> GetSystemFontCollection3;
    }
}