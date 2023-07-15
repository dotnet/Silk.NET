// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteFactory1.xml' path='doc/member[@name="IDWriteFactory1"]/*'/>
[Guid("30572F99-DAC6-41DB-A16E-0486307E606A")]
[NativeTypeName("struct IDWriteFactory1 : IDWriteFactory")]
[NativeInheritance("IDWriteFactory")]
public unsafe partial struct IDWriteFactory1 : IDWriteFactory1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFactory1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFactory1*, uint> )(lpVtbl[1]))((IDWriteFactory1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFactory1*, uint> )(lpVtbl[2]))((IDWriteFactory1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFactory.GetSystemFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSystemFontCollection(IDWriteFontCollection** fontCollection, [Optional] BOOL checkForUpdates)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontCollection**, BOOL, int> )(lpVtbl[3]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateCustomFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int> )(lpVtbl[4]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), collectionLoader, collectionKey, collectionKeySize, fontCollection);
    }

    /// <inheritdoc cref = "IDWriteFactory.RegisterFontCollectionLoader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontCollectionLoader*, int> )(lpVtbl[5]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontCollectionLoader);
    }

    /// <inheritdoc cref = "IDWriteFactory.UnregisterFontCollectionLoader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontCollectionLoader*, int> )(lpVtbl[6]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontCollectionLoader);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateFontFileReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFontFileReference([NativeTypeName("const WCHAR *")] ushort* filePath, [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime, IDWriteFontFile** fontFile)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, ushort*, FILETIME*, IDWriteFontFile**, int> )(lpVtbl[7]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), filePath, lastWriteTime, fontFile);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateCustomFontFileReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateCustomFontFileReference([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int> )(lpVtbl[8]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateFontFace"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, [NativeTypeName("UINT32")] uint numberOfFiles, [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile** fontFiles, [NativeTypeName("UINT32")] uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, DWRITE_FONT_FACE_TYPE, uint, IDWriteFontFile**, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontFace**, int> )(lpVtbl[9]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateRenderingParams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateRenderingParams(IDWriteRenderingParams** renderingParams)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteRenderingParams**, int> )(lpVtbl[10]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), renderingParams);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateMonitorRenderingParams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateMonitorRenderingParams(HMONITOR monitor, IDWriteRenderingParams** renderingParams)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, HMONITOR, IDWriteRenderingParams**, int> )(lpVtbl[11]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), monitor, renderingParams);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateCustomRenderingParams"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams** renderingParams)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams**, int> )(lpVtbl[12]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
    }

    /// <inheritdoc cref = "IDWriteFactory.RegisterFontFileLoader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontFileLoader*, int> )(lpVtbl[13]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontFileLoader);
    }

    /// <inheritdoc cref = "IDWriteFactory.UnregisterFontFileLoader"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontFileLoader*, int> )(lpVtbl[14]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontFileLoader);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateTextFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateTextFormat([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, IDWriteFontCollection* fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, [NativeTypeName("const WCHAR *")] ushort* localeName, IDWriteTextFormat** textFormat)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, ushort*, IDWriteFontCollection*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, float, ushort*, IDWriteTextFormat**, int> )(lpVtbl[15]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateTypography"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateTypography(IDWriteTypography** typography)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteTypography**, int> )(lpVtbl[16]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), typography);
    }

    /// <inheritdoc cref = "IDWriteFactory.GetGdiInterop"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetGdiInterop(IDWriteGdiInterop** gdiInterop)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteGdiInterop**, int> )(lpVtbl[17]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), gdiInterop);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateTextLayout"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, ushort*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int> )(lpVtbl[18]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateGdiCompatibleTextLayout"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateGdiCompatibleTextLayout([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, BOOL useGdiNatural, IDWriteTextLayout** textLayout)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, ushort*, uint, IDWriteTextFormat*, float, float, float, DWRITE_MATRIX*, BOOL, IDWriteTextLayout**, int> )(lpVtbl[19]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateEllipsisTrimmingSign"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteTextFormat*, IDWriteInlineObject**, int> )(lpVtbl[20]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), textFormat, trimmingSign);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateTextAnalyzer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteTextAnalyzer**, int> )(lpVtbl[21]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), textAnalyzer);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateNumberSubstitution"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateNumberSubstitution(DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, [NativeTypeName("const WCHAR *")] ushort* localeName, BOOL ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, DWRITE_NUMBER_SUBSTITUTION_METHOD, ushort*, BOOL, IDWriteNumberSubstitution**, int> )(lpVtbl[22]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
    }

    /// <inheritdoc cref = "IDWriteFactory.CreateGlyphRunAnalysis"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateGlyphRunAnalysis([NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, DWRITE_GLYPH_RUN*, float, DWRITE_MATRIX*, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, float, float, IDWriteGlyphRunAnalysis**, int> )(lpVtbl[23]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
    }

    /// <include file='IDWriteFactory1.xml' path='doc/member[@name="IDWriteFactory1.GetEudcFontCollection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetEudcFontCollection(IDWriteFontCollection** fontCollection, [Optional] BOOL checkForUpdates)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, IDWriteFontCollection**, BOOL, int> )(lpVtbl[24]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), fontCollection, checkForUpdates);
    }

    /// <include file='IDWriteFactory1.xml' path='doc/member[@name="IDWriteFactory1.CreateCustomRenderingParams"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams1** renderingParams)
    {
        return ((delegate* unmanaged<IDWriteFactory1*, float, float, float, float, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams1**, int> )(lpVtbl[25]))((IDWriteFactory1*)Unsafe.AsPointer(ref this), gamma, enhancedContrast, enhancedContrastGrayscale, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
    }

    public interface Interface : IDWriteFactory.Interface
    {
        [VtblIndex(24)]
        HRESULT GetEudcFontCollection(IDWriteFontCollection** fontCollection, [Optional] BOOL checkForUpdates);
        [VtblIndex(25)]
        HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, IDWriteRenderingParams1** renderingParams);
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
    }
}