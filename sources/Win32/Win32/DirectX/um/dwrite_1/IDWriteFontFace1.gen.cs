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

[Guid("A71EFDB4-9FDB-4838-AD90-CFC3BE8C3DAF")]
[NativeTypeName("struct IDWriteFontFace1 : IDWriteFontFace")]
[NativeInheritance("IDWriteFontFace")]
public unsafe partial struct IDWriteFontFace1 : IDWriteFontFace1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFace1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFace1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontFace1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFace1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public new DWRITE_FONT_FACE_TYPE GetType()
    {
        return ((delegate* unmanaged<IDWriteFontFace1, DWRITE_FONT_FACE_TYPE>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFiles(
        [NativeTypeName("UINT32 *")] uint* numberOfFiles,
        IDWriteFontFile* fontFiles
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace1, uint*, IDWriteFontFile*, int>)((*lpVtbl)[4])
        )(this, numberOfFiles, fontFiles);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetIndex()
    {
        return ((delegate* unmanaged<IDWriteFontFace1, uint>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return ((delegate* unmanaged<IDWriteFontFace1, DWRITE_FONT_SIMULATIONS>)((*lpVtbl)[6]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL IsSymbolFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace1, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetMetrics(DWRITE_FONT_METRICS* fontFaceMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace1, DWRITE_FONT_METRICS*, void>)((*lpVtbl)[8]))(
            this,
            fontFaceMetrics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT16")]
    public ushort GetGlyphCount()
    {
        return ((delegate* unmanaged<IDWriteFontFace1, ushort>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDesignGlyphMetrics(
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("UINT32")] uint glyphCount,
        DWRITE_GLYPH_METRICS* glyphMetrics,
        [Optional] BOOL isSideways
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace1,
                ushort*,
                uint,
                DWRITE_GLYPH_METRICS*,
                BOOL,
                int>)((*lpVtbl)[10])
        )(this, glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGlyphIndices(
        [NativeTypeName("const UINT32 *")] uint* codePoints,
        [NativeTypeName("UINT32")] uint codePointCount,
        [NativeTypeName("UINT16 *")] ushort* glyphIndices
    )
    {
        return ((delegate* unmanaged<IDWriteFontFace1, uint*, uint, ushort*, int>)((*lpVtbl)[11]))(
            this,
            codePoints,
            codePointCount,
            glyphIndices
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT TryGetFontTable(
        [NativeTypeName("UINT32")] uint openTypeTableTag,
        [NativeTypeName("const void **")] void** tableData,
        [NativeTypeName("UINT32 *")] uint* tableSize,
        void** tableContext,
        BOOL* exists
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace1, uint, void**, uint*, void**, BOOL*, int>)(
                (*lpVtbl)[12]
            )
        )(this, openTypeTableTag, tableData, tableSize, tableContext, exists);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void ReleaseFontTable(void* tableContext)
    {
        ((delegate* unmanaged<IDWriteFontFace1, void*, void>)((*lpVtbl)[13]))(this, tableContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetGlyphRunOutline(
        float emSize,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("const FLOAT *")] float* glyphAdvances,
        [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets,
        [NativeTypeName("UINT32")] uint glyphCount,
        BOOL isSideways,
        BOOL isRightToLeft,
        [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink geometrySink
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace1,
                float,
                ushort*,
                float*,
                DWRITE_GLYPH_OFFSET*,
                uint,
                BOOL,
                BOOL,
                ID2D1SimplifiedGeometrySink,
                int>)((*lpVtbl)[14])
        )(
            this,
            emSize,
            glyphIndices,
            glyphAdvances,
            glyphOffsets,
            glyphCount,
            isSideways,
            isRightToLeft,
            geometrySink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetRecommendedRenderingMode(
        float emSize,
        float pixelsPerDip,
        DWRITE_MEASURING_MODE measuringMode,
        IDWriteRenderingParams renderingParams,
        DWRITE_RENDERING_MODE* renderingMode
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace1,
                float,
                float,
                DWRITE_MEASURING_MODE,
                IDWriteRenderingParams,
                DWRITE_RENDERING_MODE*,
                int>)((*lpVtbl)[15])
        )(this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetGdiCompatibleMetrics(
        float emSize,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        DWRITE_FONT_METRICS* fontFaceMetrics
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace1,
                float,
                float,
                DWRITE_MATRIX*,
                DWRITE_FONT_METRICS*,
                int>)((*lpVtbl)[16])
        )(this, emSize, pixelsPerDip, transform, fontFaceMetrics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetGdiCompatibleGlyphMetrics(
        float emSize,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        BOOL useGdiNatural,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("UINT32")] uint glyphCount,
        DWRITE_GLYPH_METRICS* glyphMetrics,
        [Optional] BOOL isSideways
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace1,
                float,
                float,
                DWRITE_MATRIX*,
                BOOL,
                ushort*,
                uint,
                DWRITE_GLYPH_METRICS*,
                BOOL,
                int>)((*lpVtbl)[17])
        )(
            this,
            emSize,
            pixelsPerDip,
            transform,
            useGdiNatural,
            glyphIndices,
            glyphCount,
            glyphMetrics,
            isSideways
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace1, DWRITE_FONT_METRICS1*, void>)((*lpVtbl)[18]))(
            this,
            fontMetrics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetGdiCompatibleMetrics(
        float emSize,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        DWRITE_FONT_METRICS1* fontMetrics
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace1,
                float,
                float,
                DWRITE_MATRIX*,
                DWRITE_FONT_METRICS1*,
                int>)((*lpVtbl)[19])
        )(this, emSize, pixelsPerDip, transform, fontMetrics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void GetCaretMetrics(DWRITE_CARET_METRICS* caretMetrics)
    {
        ((delegate* unmanaged<IDWriteFontFace1, DWRITE_CARET_METRICS*, void>)((*lpVtbl)[20]))(
            this,
            caretMetrics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetUnicodeRanges(
        [NativeTypeName("UINT32")] uint maxRangeCount,
        DWRITE_UNICODE_RANGE* unicodeRanges,
        [NativeTypeName("UINT32 *")] uint* actualRangeCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace1, uint, DWRITE_UNICODE_RANGE*, uint*, int>)(
                (*lpVtbl)[21]
            )
        )(this, maxRangeCount, unicodeRanges, actualRangeCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL IsMonospacedFont()
    {
        return ((delegate* unmanaged<IDWriteFontFace1, int>)((*lpVtbl)[22]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetDesignGlyphAdvances(
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("INT32 *")] int* glyphAdvances,
        [Optional] BOOL isSideways
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace1, uint, ushort*, int*, BOOL, int>)((*lpVtbl)[23])
        )(this, glyphCount, glyphIndices, glyphAdvances, isSideways);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetGdiCompatibleGlyphAdvances(
        float emSize,
        float pixelsPerDip,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        BOOL useGdiNatural,
        BOOL isSideways,
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("INT32 *")] int* glyphAdvances
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace1,
                float,
                float,
                DWRITE_MATRIX*,
                BOOL,
                BOOL,
                uint,
                ushort*,
                int*,
                int>)((*lpVtbl)[24])
        )(
            this,
            emSize,
            pixelsPerDip,
            transform,
            useGdiNatural,
            isSideways,
            glyphCount,
            glyphIndices,
            glyphAdvances
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetKerningPairAdjustments(
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments
    )
    {
        return ((delegate* unmanaged<IDWriteFontFace1, uint, ushort*, int*, int>)((*lpVtbl)[25]))(
            this,
            glyphCount,
            glyphIndices,
            glyphAdvanceAdjustments
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public BOOL HasKerningPairs()
    {
        return ((delegate* unmanaged<IDWriteFontFace1, int>)((*lpVtbl)[26]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetRecommendedRenderingMode(
        float fontEmSize,
        float dpiX,
        float dpiY,
        [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
        BOOL isSideways,
        DWRITE_OUTLINE_THRESHOLD outlineThreshold,
        DWRITE_MEASURING_MODE measuringMode,
        DWRITE_RENDERING_MODE* renderingMode
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFace1,
                float,
                float,
                float,
                DWRITE_MATRIX*,
                BOOL,
                DWRITE_OUTLINE_THRESHOLD,
                DWRITE_MEASURING_MODE,
                DWRITE_RENDERING_MODE*,
                int>)((*lpVtbl)[27])
        )(
            this,
            fontEmSize,
            dpiX,
            dpiY,
            transform,
            isSideways,
            outlineThreshold,
            measuringMode,
            renderingMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetVerticalGlyphVariants(
        [NativeTypeName("UINT32")] uint glyphCount,
        [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices,
        [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFace1, uint, ushort*, ushort*, int>)((*lpVtbl)[28])
        )(this, glyphCount, nominalGlyphIndices, verticalGlyphIndices);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public BOOL HasVerticalGlyphVariants()
    {
        return ((delegate* unmanaged<IDWriteFontFace1, int>)((*lpVtbl)[29]))(this);
    }

    public interface Interface : IDWriteFontFace.Interface
    {
        [VtblIndex(18)]
        void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics);

        [VtblIndex(19)]
        HRESULT GetGdiCompatibleMetrics(
            float emSize,
            float pixelsPerDip,
            [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
            DWRITE_FONT_METRICS1* fontMetrics
        );

        [VtblIndex(20)]
        void GetCaretMetrics(DWRITE_CARET_METRICS* caretMetrics);

        [VtblIndex(21)]
        HRESULT GetUnicodeRanges(
            [NativeTypeName("UINT32")] uint maxRangeCount,
            DWRITE_UNICODE_RANGE* unicodeRanges,
            [NativeTypeName("UINT32 *")] uint* actualRangeCount
        );

        [VtblIndex(22)]
        BOOL IsMonospacedFont();

        [VtblIndex(23)]
        HRESULT GetDesignGlyphAdvances(
            [NativeTypeName("UINT32")] uint glyphCount,
            [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
            [NativeTypeName("INT32 *")] int* glyphAdvances,
            [Optional] BOOL isSideways
        );

        [VtblIndex(24)]
        HRESULT GetGdiCompatibleGlyphAdvances(
            float emSize,
            float pixelsPerDip,
            [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
            BOOL useGdiNatural,
            BOOL isSideways,
            [NativeTypeName("UINT32")] uint glyphCount,
            [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
            [NativeTypeName("INT32 *")] int* glyphAdvances
        );

        [VtblIndex(25)]
        HRESULT GetKerningPairAdjustments(
            [NativeTypeName("UINT32")] uint glyphCount,
            [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
            [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments
        );

        [VtblIndex(26)]
        BOOL HasKerningPairs();

        [VtblIndex(27)]
        HRESULT GetRecommendedRenderingMode(
            float fontEmSize,
            float dpiX,
            float dpiY,
            [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform,
            BOOL isSideways,
            DWRITE_OUTLINE_THRESHOLD outlineThreshold,
            DWRITE_MEASURING_MODE measuringMode,
            DWRITE_RENDERING_MODE* renderingMode
        );

        [VtblIndex(28)]
        HRESULT GetVerticalGlyphVariants(
            [NativeTypeName("UINT32")] uint glyphCount,
            [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices,
            [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices
        );

        [VtblIndex(29)]
        BOOL HasVerticalGlyphVariants();
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
            "DWRITE_FONT_FACE_TYPE () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public new delegate* unmanaged<TSelf*, DWRITE_FONT_FACE_TYPE> GetType;

        [NativeTypeName(
            "HRESULT (UINT32 *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, IDWriteFontFile*, int> GetFiles;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetIndex;

        [NativeTypeName(
            "DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_SIMULATIONS> GetSimulations;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsSymbolFont;

        [NativeTypeName(
            "void (DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_METRICS*, void> GetMetrics;

        [NativeTypeName("UINT16 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort> GetGlyphCount;

        [NativeTypeName(
            "HRESULT (const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            DWRITE_GLYPH_METRICS*,
            BOOL,
            int> GetDesignGlyphMetrics;

        [NativeTypeName(
            "HRESULT (const UINT32 *, UINT32, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, uint, ushort*, int> GetGlyphIndices;

        [NativeTypeName(
            "HRESULT (UINT32, const void **, UINT32 *, void **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, void**, uint*, void**, BOOL*, int> TryGetFontTable;

        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> ReleaseFontTable;

        [NativeTypeName(
            "HRESULT (FLOAT, const UINT16 *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, UINT32, BOOL, BOOL, IDWriteGeometrySink *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            ushort*,
            float*,
            DWRITE_GLYPH_OFFSET*,
            uint,
            BOOL,
            BOOL,
            ID2D1SimplifiedGeometrySink,
            int> GetGlyphRunOutline;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            DWRITE_MEASURING_MODE,
            IDWriteRenderingParams,
            DWRITE_RENDERING_MODE*,
            int> GetRecommendedRenderingMode;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            DWRITE_MATRIX*,
            DWRITE_FONT_METRICS*,
            int> GetGdiCompatibleMetrics;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            DWRITE_MATRIX*,
            BOOL,
            ushort*,
            uint,
            DWRITE_GLYPH_METRICS*,
            BOOL,
            int> GetGdiCompatibleGlyphMetrics;

        [NativeTypeName(
            "void (DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_METRICS1*, void> GetMetrics1;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            DWRITE_MATRIX*,
            DWRITE_FONT_METRICS1*,
            int> GetGdiCompatibleMetrics1;

        [NativeTypeName(
            "void (DWRITE_CARET_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_CARET_METRICS*, void> GetCaretMetrics;

        [NativeTypeName(
            "HRESULT (UINT32, DWRITE_UNICODE_RANGE *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DWRITE_UNICODE_RANGE*,
            uint*,
            int> GetUnicodeRanges;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsMonospacedFont;

        [NativeTypeName(
            "HRESULT (UINT32, const UINT16 *, INT32 *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, int*, BOOL, int> GetDesignGlyphAdvances;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, BOOL, UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            DWRITE_MATRIX*,
            BOOL,
            BOOL,
            uint,
            ushort*,
            int*,
            int> GetGdiCompatibleGlyphAdvances;

        [NativeTypeName(
            "HRESULT (UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, int*, int> GetKerningPairAdjustments;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasKerningPairs;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            DWRITE_MATRIX*,
            BOOL,
            DWRITE_OUTLINE_THRESHOLD,
            DWRITE_MEASURING_MODE,
            DWRITE_RENDERING_MODE*,
            int> GetRecommendedRenderingMode1;

        [NativeTypeName(
            "HRESULT (UINT32, const UINT16 *, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, ushort*, int> GetVerticalGlyphVariants;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasVerticalGlyphVariants;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontFace1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontFace1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFace"/> to <see cref = "IDWriteFontFace1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFace"/> instance to be converted </param>
    public static explicit operator IDWriteFontFace1(Silk.NET.DirectX.IDWriteFontFace value)
    {
        return new IDWriteFontFace1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFace1"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFace"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFace1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFace(IDWriteFontFace1 value)
    {
        return new Silk.NET.DirectX.IDWriteFontFace(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontFace1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontFace1(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontFace1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFace1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFace1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontFace1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
