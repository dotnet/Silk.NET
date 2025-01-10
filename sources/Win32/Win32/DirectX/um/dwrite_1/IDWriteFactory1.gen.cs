// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("30572F99-DAC6-41DB-A16E-0486307E606A")]
[NativeTypeName("struct IDWriteFactory1 : IDWriteFactory")]
[NativeInheritance("IDWriteFactory")]
public unsafe partial struct IDWriteFactory1 : IDWriteFactory1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFactory1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFactory1, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFactory1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFactory1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSystemFontCollection(
        IDWriteFontCollection* fontCollection,
        [Optional] BOOL checkForUpdates
    )
    {
        return (
            (delegate* unmanaged<IDWriteFactory1, IDWriteFontCollection*, BOOL, int>)((*lpVtbl)[3])
        )(this, fontCollection, checkForUpdates);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateCustomFontCollection(
        IDWriteFontCollectionLoader collectionLoader,
        [NativeTypeName("const void *")] void* collectionKey,
        [NativeTypeName("UINT32")] uint collectionKeySize,
        IDWriteFontCollection* fontCollection
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFactory1,
                IDWriteFontCollectionLoader,
                void*,
                uint,
                IDWriteFontCollection*,
                int>)((*lpVtbl)[4])
        )(this, collectionLoader, collectionKey, collectionKeySize, fontCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterFontCollectionLoader(IDWriteFontCollectionLoader fontCollectionLoader)
    {
        return (
            (delegate* unmanaged<IDWriteFactory1, IDWriteFontCollectionLoader, int>)((*lpVtbl)[5])
        )(this, fontCollectionLoader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnregisterFontCollectionLoader(IDWriteFontCollectionLoader fontCollectionLoader)
    {
        return (
            (delegate* unmanaged<IDWriteFactory1, IDWriteFontCollectionLoader, int>)((*lpVtbl)[6])
        )(this, fontCollectionLoader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFontFileReference(
        [NativeTypeName("const WCHAR *")] ushort* filePath,
        [NativeTypeName("const FILETIME *")] FILETIME* lastWriteTime,
        IDWriteFontFile* fontFile
    )
    {
        return (
            (delegate* unmanaged<IDWriteFactory1, ushort*, FILETIME*, IDWriteFontFile*, int>)(
                (*lpVtbl)[7]
            )
        )(this, filePath, lastWriteTime, fontFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateCustomFontFileReference(
        [NativeTypeName("const void *")] void* fontFileReferenceKey,
        [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
        IDWriteFontFileLoader fontFileLoader,
        IDWriteFontFile* fontFile
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFactory1,
                void*,
                uint,
                IDWriteFontFileLoader,
                IDWriteFontFile*,
                int>)((*lpVtbl)[8])
        )(this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFontFace(
        DWRITE_FONT_FACE_TYPE fontFaceType,
        [NativeTypeName("UINT32")] uint numberOfFiles,
        [NativeTypeName("IDWriteFontFile *const *")] IDWriteFontFile* fontFiles,
        [NativeTypeName("UINT32")] uint faceIndex,
        DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags,
        IDWriteFontFace* fontFace
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFactory1,
                DWRITE_FONT_FACE_TYPE,
                uint,
                IDWriteFontFile*,
                uint,
                DWRITE_FONT_SIMULATIONS,
                IDWriteFontFace*,
                int>)((*lpVtbl)[9])
        )(
            this,
            fontFaceType,
            numberOfFiles,
            fontFiles,
            faceIndex,
            fontFaceSimulationFlags,
            fontFace
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateRenderingParams(IDWriteRenderingParams* renderingParams)
    {
        return (
            (delegate* unmanaged<IDWriteFactory1, IDWriteRenderingParams*, int>)((*lpVtbl)[10])
        )(this, renderingParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateMonitorRenderingParams(
        HMONITOR monitor,
        IDWriteRenderingParams* renderingParams
    )
    {
        return (
            (delegate* unmanaged<IDWriteFactory1, HMONITOR, IDWriteRenderingParams*, int>)(
                (*lpVtbl)[11]
            )
        )(this, monitor, renderingParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCustomRenderingParams(
        float gamma,
        float enhancedContrast,
        float clearTypeLevel,
        DWRITE_PIXEL_GEOMETRY pixelGeometry,
        DWRITE_RENDERING_MODE renderingMode,
        IDWriteRenderingParams* renderingParams
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFactory1,
                float,
                float,
                float,
                DWRITE_PIXEL_GEOMETRY,
                DWRITE_RENDERING_MODE,
                IDWriteRenderingParams*,
                int>)((*lpVtbl)[12])
        )(
            this,
            gamma,
            enhancedContrast,
            clearTypeLevel,
            pixelGeometry,
            renderingMode,
            renderingParams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RegisterFontFileLoader(IDWriteFontFileLoader fontFileLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory1, IDWriteFontFileLoader, int>)((*lpVtbl)[13]))(
            this,
            fontFileLoader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT UnregisterFontFileLoader(IDWriteFontFileLoader fontFileLoader)
    {
        return ((delegate* unmanaged<IDWriteFactory1, IDWriteFontFileLoader, int>)((*lpVtbl)[14]))(
            this,
            fontFileLoader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateTextFormat(
        [NativeTypeName("const WCHAR *")] ushort* fontFamilyName,
        IDWriteFontCollection fontCollection,
        DWRITE_FONT_WEIGHT fontWeight,
        DWRITE_FONT_STYLE fontStyle,
        DWRITE_FONT_STRETCH fontStretch,
        float fontSize,
        [NativeTypeName("const WCHAR *")] ushort* localeName,
        IDWriteTextFormat* textFormat
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFactory1,
                ushort*,
                IDWriteFontCollection,
                DWRITE_FONT_WEIGHT,
                DWRITE_FONT_STYLE,
                DWRITE_FONT_STRETCH,
                float,
                ushort*,
                IDWriteTextFormat*,
                int>)((*lpVtbl)[15])
        )(
            this,
            fontFamilyName,
            fontCollection,
            fontWeight,
            fontStyle,
            fontStretch,
            fontSize,
            localeName,
            textFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateTypography(IDWriteTypography* typography)
    {
        return ((delegate* unmanaged<IDWriteFactory1, IDWriteTypography*, int>)((*lpVtbl)[16]))(
            this,
            typography
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetGdiInterop(IDWriteGdiInterop* gdiInterop)
    {
        return ((delegate* unmanaged<IDWriteFactory1, IDWriteGdiInterop*, int>)((*lpVtbl)[17]))(
            this,
            gdiInterop
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateTextLayout(
        [NativeTypeName("const WCHAR *")] ushort* @string,
        [NativeTypeName("UINT32")] uint stringLength,
        IDWriteTextFormat textFormat,
        float maxWidth,
        float maxHeight,
        IDWriteTextLayout* textLayout
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFactory1,
                ushort*,
                uint,
                IDWriteTextFormat,
                float,
                float,
                IDWriteTextLayout*,
                int>)((*lpVtbl)[18])
        )(this, @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateGdiCompatibleTextLayout(
        [NativeTypeName("const WCHAR *")] ushort* @string,
        [NativeTypeName("UINT32")] uint stringLength,
        IDWriteTextFormat textFormat,
        float layoutWidth,
        float layoutHeight,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        BOOL useGdiNatural,
        IDWriteTextLayout* textLayout
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFactory1,
                ushort*,
                uint,
                IDWriteTextFormat,
                float,
                float,
                float,
                DWRITE_MATRIX*,
                BOOL,
                IDWriteTextLayout*,
                int>)((*lpVtbl)[19])
        )(
            this,
            @string,
            stringLength,
            textFormat,
            layoutWidth,
            layoutHeight,
            pixelsPerDip,
            transform,
            useGdiNatural,
            textLayout
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateEllipsisTrimmingSign(
        IDWriteTextFormat textFormat,
        IDWriteInlineObject* trimmingSign
    )
    {
        return (
            (delegate* unmanaged<IDWriteFactory1, IDWriteTextFormat, IDWriteInlineObject*, int>)(
                (*lpVtbl)[20]
            )
        )(this, textFormat, trimmingSign);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateTextAnalyzer(IDWriteTextAnalyzer* textAnalyzer)
    {
        return ((delegate* unmanaged<IDWriteFactory1, IDWriteTextAnalyzer*, int>)((*lpVtbl)[21]))(
            this,
            textAnalyzer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateNumberSubstitution(
        DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod,
        [NativeTypeName("const WCHAR *")] ushort* localeName,
        BOOL ignoreUserOverride,
        IDWriteNumberSubstitution* numberSubstitution
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFactory1,
                DWRITE_NUMBER_SUBSTITUTION_METHOD,
                ushort*,
                BOOL,
                IDWriteNumberSubstitution*,
                int>)((*lpVtbl)[22])
        )(this, substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateGlyphRunAnalysis(
        [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        DWRITE_RENDERING_MODE renderingMode,
        DWRITE_MEASURING_MODE measuringMode,
        float baselineOriginX,
        float baselineOriginY,
        IDWriteGlyphRunAnalysis* glyphRunAnalysis
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFactory1,
                DWRITE_GLYPH_RUN*,
                float,
                DWRITE_MATRIX*,
                DWRITE_RENDERING_MODE,
                DWRITE_MEASURING_MODE,
                float,
                float,
                IDWriteGlyphRunAnalysis*,
                int>)((*lpVtbl)[23])
        )(
            this,
            glyphRun,
            pixelsPerDip,
            transform,
            renderingMode,
            measuringMode,
            baselineOriginX,
            baselineOriginY,
            glyphRunAnalysis
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetEudcFontCollection(
        IDWriteFontCollection* fontCollection,
        [Optional] BOOL checkForUpdates
    )
    {
        return (
            (delegate* unmanaged<IDWriteFactory1, IDWriteFontCollection*, BOOL, int>)((*lpVtbl)[24])
        )(this, fontCollection, checkForUpdates);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateCustomRenderingParams(
        float gamma,
        float enhancedContrast,
        float enhancedContrastGrayscale,
        float clearTypeLevel,
        DWRITE_PIXEL_GEOMETRY pixelGeometry,
        DWRITE_RENDERING_MODE renderingMode,
        IDWriteRenderingParams1* renderingParams
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFactory1,
                float,
                float,
                float,
                float,
                DWRITE_PIXEL_GEOMETRY,
                DWRITE_RENDERING_MODE,
                IDWriteRenderingParams1*,
                int>)((*lpVtbl)[25])
        )(
            this,
            gamma,
            enhancedContrast,
            enhancedContrastGrayscale,
            clearTypeLevel,
            pixelGeometry,
            renderingMode,
            renderingParams
        );
    }

    public interface Interface : IDWriteFactory.Interface
    {
        [VtblIndex(24)]
        HRESULT GetEudcFontCollection(
            IDWriteFontCollection* fontCollection,
            [Optional] BOOL checkForUpdates
        );

        [VtblIndex(25)]
        HRESULT CreateCustomRenderingParams(
            float gamma,
            float enhancedContrast,
            float enhancedContrastGrayscale,
            float clearTypeLevel,
            DWRITE_PIXEL_GEOMETRY pixelGeometry,
            DWRITE_RENDERING_MODE renderingMode,
            IDWriteRenderingParams1* renderingParams
        );
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

        [NativeTypeName(
            "HRESULT (IDWriteFontCollection **, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontCollection*,
            BOOL,
            int> GetSystemFontCollection;

        [NativeTypeName(
            "HRESULT (IDWriteFontCollectionLoader *, const void *, UINT32, IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontCollectionLoader,
            void*,
            uint,
            IDWriteFontCollection*,
            int> CreateCustomFontCollection;

        [NativeTypeName(
            "HRESULT (IDWriteFontCollectionLoader *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontCollectionLoader,
            int> RegisterFontCollectionLoader;

        [NativeTypeName(
            "HRESULT (IDWriteFontCollectionLoader *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontCollectionLoader,
            int> UnregisterFontCollectionLoader;

        [NativeTypeName(
            "HRESULT (const WCHAR *, const FILETIME *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            FILETIME*,
            IDWriteFontFile*,
            int> CreateFontFileReference;

        [NativeTypeName(
            "HRESULT (const void *, UINT32, IDWriteFontFileLoader *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            uint,
            IDWriteFontFileLoader,
            IDWriteFontFile*,
            int> CreateCustomFontFileReference;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_FACE_TYPE, UINT32, IDWriteFontFile *const *, UINT32, DWRITE_FONT_SIMULATIONS, IDWriteFontFace **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_FACE_TYPE,
            uint,
            IDWriteFontFile*,
            uint,
            DWRITE_FONT_SIMULATIONS,
            IDWriteFontFace*,
            int> CreateFontFace;

        [NativeTypeName(
            "HRESULT (IDWriteRenderingParams **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteRenderingParams*, int> CreateRenderingParams;

        [NativeTypeName(
            "HRESULT (HMONITOR, IDWriteRenderingParams **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HMONITOR,
            IDWriteRenderingParams*,
            int> CreateMonitorRenderingParams;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            DWRITE_PIXEL_GEOMETRY,
            DWRITE_RENDERING_MODE,
            IDWriteRenderingParams*,
            int> CreateCustomRenderingParams;

        [NativeTypeName(
            "HRESULT (IDWriteFontFileLoader *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFileLoader, int> RegisterFontFileLoader;

        [NativeTypeName(
            "HRESULT (IDWriteFontFileLoader *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFileLoader, int> UnregisterFontFileLoader;

        [NativeTypeName(
            "HRESULT (const WCHAR *, IDWriteFontCollection *, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, FLOAT, const WCHAR *, IDWriteTextFormat **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IDWriteFontCollection,
            DWRITE_FONT_WEIGHT,
            DWRITE_FONT_STYLE,
            DWRITE_FONT_STRETCH,
            float,
            ushort*,
            IDWriteTextFormat*,
            int> CreateTextFormat;

        [NativeTypeName(
            "HRESULT (IDWriteTypography **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteTypography*, int> CreateTypography;

        [NativeTypeName(
            "HRESULT (IDWriteGdiInterop **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteGdiInterop*, int> GetGdiInterop;

        [NativeTypeName(
            "HRESULT (const WCHAR *, UINT32, IDWriteTextFormat *, FLOAT, FLOAT, IDWriteTextLayout **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IDWriteTextFormat,
            float,
            float,
            IDWriteTextLayout*,
            int> CreateTextLayout;

        [NativeTypeName(
            "HRESULT (const WCHAR *, UINT32, IDWriteTextFormat *, FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, IDWriteTextLayout **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            IDWriteTextFormat,
            float,
            float,
            float,
            DWRITE_MATRIX*,
            BOOL,
            IDWriteTextLayout*,
            int> CreateGdiCompatibleTextLayout;

        [NativeTypeName(
            "HRESULT (IDWriteTextFormat *, IDWriteInlineObject **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteTextFormat,
            IDWriteInlineObject*,
            int> CreateEllipsisTrimmingSign;

        [NativeTypeName(
            "HRESULT (IDWriteTextAnalyzer **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteTextAnalyzer*, int> CreateTextAnalyzer;

        [NativeTypeName(
            "HRESULT (DWRITE_NUMBER_SUBSTITUTION_METHOD, const WCHAR *, BOOL, IDWriteNumberSubstitution **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_NUMBER_SUBSTITUTION_METHOD,
            ushort*,
            BOOL,
            IDWriteNumberSubstitution*,
            int> CreateNumberSubstitution;

        [NativeTypeName(
            "HRESULT (const DWRITE_GLYPH_RUN *, FLOAT, const DWRITE_MATRIX *, DWRITE_RENDERING_MODE, DWRITE_MEASURING_MODE, FLOAT, FLOAT, IDWriteGlyphRunAnalysis **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_GLYPH_RUN*,
            float,
            DWRITE_MATRIX*,
            DWRITE_RENDERING_MODE,
            DWRITE_MEASURING_MODE,
            float,
            float,
            IDWriteGlyphRunAnalysis*,
            int> CreateGlyphRunAnalysis;

        [NativeTypeName(
            "HRESULT (IDWriteFontCollection **, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection*, BOOL, int> GetEudcFontCollection;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, DWRITE_PIXEL_GEOMETRY, DWRITE_RENDERING_MODE, IDWriteRenderingParams1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            DWRITE_PIXEL_GEOMETRY,
            DWRITE_RENDERING_MODE,
            IDWriteRenderingParams1*,
            int> CreateCustomRenderingParams1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFactory1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFactory1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFactory"/> to <see cref = "IDWriteFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFactory"/> instance to be converted </param>
    public static explicit operator IDWriteFactory1(Silk.NET.DirectX.IDWriteFactory value)
    {
        return new IDWriteFactory1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFactory1"/> to <see cref = "Silk.NET.DirectX.IDWriteFactory"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFactory1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFactory(IDWriteFactory1 value)
    {
        return new Silk.NET.DirectX.IDWriteFactory(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFactory1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFactory1(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFactory1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFactory1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFactory1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFactory1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
