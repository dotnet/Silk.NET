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

[Guid("9064D822-80A7-465C-A986-DF65F78B8FEB")]
[NativeTypeName("struct IDWriteTextLayout1 : IDWriteTextLayout")]
[NativeInheritance("IDWriteTextLayout")]
public unsafe partial struct IDWriteTextLayout1 : IDWriteTextLayout1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextLayout1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteTextLayout1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_TEXT_ALIGNMENT, int>)((*lpVtbl)[3])
        )(this, textAlignment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_PARAGRAPH_ALIGNMENT, int>)((*lpVtbl)[4])
        )(this, paragraphAlignment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, DWRITE_WORD_WRAPPING, int>)((*lpVtbl)[5]))(
            this,
            wordWrapping
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_READING_DIRECTION, int>)((*lpVtbl)[6])
        )(this, readingDirection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_FLOW_DIRECTION, int>)((*lpVtbl)[7])
        )(this, flowDirection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetIncrementalTabStop(float incrementalTabStop)
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, float, int>)((*lpVtbl)[8]))(
            this,
            incrementalTabStop
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTrimming(
        [NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions,
        IDWriteInlineObject trimmingSign
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_TRIMMING*, IDWriteInlineObject, int>)(
                (*lpVtbl)[9]
            )
        )(this, trimmingOptions, trimmingSign);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLineSpacing(
        DWRITE_LINE_SPACING_METHOD lineSpacingMethod,
        float lineSpacing,
        float baseline
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                DWRITE_LINE_SPACING_METHOD,
                float,
                float,
                int>)((*lpVtbl)[10])
        )(this, lineSpacingMethod, lineSpacing, baseline);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, DWRITE_TEXT_ALIGNMENT>)((*lpVtbl)[11]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_PARAGRAPH_ALIGNMENT>)((*lpVtbl)[12])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public DWRITE_WORD_WRAPPING GetWordWrapping()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, DWRITE_WORD_WRAPPING>)((*lpVtbl)[13]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public DWRITE_READING_DIRECTION GetReadingDirection()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, DWRITE_READING_DIRECTION>)((*lpVtbl)[14]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public DWRITE_FLOW_DIRECTION GetFlowDirection()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, DWRITE_FLOW_DIRECTION>)((*lpVtbl)[15]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public float GetIncrementalTabStop()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, float>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(
                (*lpVtbl)[17]
            )
        )(this, trimmingOptions, trimmingSign);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetLineSpacing(
        DWRITE_LINE_SPACING_METHOD* lineSpacingMethod,
        float* lineSpacing,
        float* baseline
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                DWRITE_LINE_SPACING_METHOD*,
                float*,
                float*,
                int>)((*lpVtbl)[18])
        )(this, lineSpacingMethod, lineSpacing, baseline);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFontCollection(IDWriteFontCollection* fontCollection)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, IDWriteFontCollection*, int>)((*lpVtbl)[19])
        )(this, fontCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFamilyNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, uint>)((*lpVtbl)[20]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFontFamilyName(
        [NativeTypeName("WCHAR *")] ushort* fontFamilyName,
        [NativeTypeName("UINT32")] uint nameSize
    )
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, ushort*, uint, int>)((*lpVtbl)[21]))(
            this,
            fontFamilyName,
            nameSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public DWRITE_FONT_WEIGHT GetFontWeight()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, DWRITE_FONT_WEIGHT>)((*lpVtbl)[22]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public DWRITE_FONT_STYLE GetFontStyle()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, DWRITE_FONT_STYLE>)((*lpVtbl)[23]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public DWRITE_FONT_STRETCH GetFontStretch()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, DWRITE_FONT_STRETCH>)((*lpVtbl)[24]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public float GetFontSize()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, float>)((*lpVtbl)[25]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("UINT32")]
    public uint GetLocaleNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, uint>)((*lpVtbl)[26]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetLocaleName(
        [NativeTypeName("WCHAR *")] ushort* localeName,
        [NativeTypeName("UINT32")] uint nameSize
    )
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, ushort*, uint, int>)((*lpVtbl)[27]))(
            this,
            localeName,
            nameSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetMaxWidth(float maxWidth)
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, float, int>)((*lpVtbl)[28]))(
            this,
            maxWidth
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetMaxHeight(float maxHeight)
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, float, int>)((*lpVtbl)[29]))(
            this,
            maxHeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetFontCollection(
        IDWriteFontCollection fontCollection,
        DWRITE_TEXT_RANGE textRange
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                IDWriteFontCollection,
                DWRITE_TEXT_RANGE,
                int>)((*lpVtbl)[30])
        )(this, fontCollection, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetFontFamilyName(
        [NativeTypeName("const WCHAR *")] ushort* fontFamilyName,
        DWRITE_TEXT_RANGE textRange
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, ushort*, DWRITE_TEXT_RANGE, int>)(
                (*lpVtbl)[31]
            )
        )(this, fontFamilyName, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE, int>)(
                (*lpVtbl)[32]
            )
        )(this, fontWeight, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE, int>)(
                (*lpVtbl)[33]
            )
        )(this, fontStyle, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE, int>)(
                (*lpVtbl)[34]
            )
        )(this, fontStretch, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetFontSize(float fontSize, DWRITE_TEXT_RANGE textRange)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, float, DWRITE_TEXT_RANGE, int>)((*lpVtbl)[35])
        )(this, fontSize, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT SetUnderline(BOOL hasUnderline, DWRITE_TEXT_RANGE textRange)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, BOOL, DWRITE_TEXT_RANGE, int>)((*lpVtbl)[36])
        )(this, hasUnderline, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetStrikethrough(BOOL hasStrikethrough, DWRITE_TEXT_RANGE textRange)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, BOOL, DWRITE_TEXT_RANGE, int>)((*lpVtbl)[37])
        )(this, hasStrikethrough, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT SetDrawingEffect(IUnknown drawingEffect, DWRITE_TEXT_RANGE textRange)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, IUnknown, DWRITE_TEXT_RANGE, int>)(
                (*lpVtbl)[38]
            )
        )(this, drawingEffect, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetInlineObject(IDWriteInlineObject inlineObject, DWRITE_TEXT_RANGE textRange)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, IDWriteInlineObject, DWRITE_TEXT_RANGE, int>)(
                (*lpVtbl)[39]
            )
        )(this, inlineObject, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT SetTypography(IDWriteTypography typography, DWRITE_TEXT_RANGE textRange)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, IDWriteTypography, DWRITE_TEXT_RANGE, int>)(
                (*lpVtbl)[40]
            )
        )(this, typography, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT SetLocaleName(
        [NativeTypeName("const WCHAR *")] ushort* localeName,
        DWRITE_TEXT_RANGE textRange
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, ushort*, DWRITE_TEXT_RANGE, int>)(
                (*lpVtbl)[41]
            )
        )(this, localeName, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public float GetMaxWidth()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, float>)((*lpVtbl)[42]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public float GetMaxHeight()
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, float>)((*lpVtbl)[43]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT GetFontCollection(
        [NativeTypeName("UINT32")] uint currentPosition,
        IDWriteFontCollection* fontCollection,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                uint,
                IDWriteFontCollection*,
                DWRITE_TEXT_RANGE*,
                int>)((*lpVtbl)[44])
        )(this, currentPosition, fontCollection, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT GetFontFamilyNameLength(
        [NativeTypeName("UINT32")] uint currentPosition,
        [NativeTypeName("UINT32 *")] uint* nameLength,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, uint, uint*, DWRITE_TEXT_RANGE*, int>)(
                (*lpVtbl)[45]
            )
        )(this, currentPosition, nameLength, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT GetFontFamilyName(
        [NativeTypeName("UINT32")] uint currentPosition,
        [NativeTypeName("WCHAR *")] ushort* fontFamilyName,
        [NativeTypeName("UINT32")] uint nameSize,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(
                (*lpVtbl)[46]
            )
        )(this, currentPosition, fontFamilyName, nameSize, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT GetFontWeight(
        [NativeTypeName("UINT32")] uint currentPosition,
        DWRITE_FONT_WEIGHT* fontWeight,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                uint,
                DWRITE_FONT_WEIGHT*,
                DWRITE_TEXT_RANGE*,
                int>)((*lpVtbl)[47])
        )(this, currentPosition, fontWeight, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT GetFontStyle(
        [NativeTypeName("UINT32")] uint currentPosition,
        DWRITE_FONT_STYLE* fontStyle,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                uint,
                DWRITE_FONT_STYLE*,
                DWRITE_TEXT_RANGE*,
                int>)((*lpVtbl)[48])
        )(this, currentPosition, fontStyle, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT GetFontStretch(
        [NativeTypeName("UINT32")] uint currentPosition,
        DWRITE_FONT_STRETCH* fontStretch,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                uint,
                DWRITE_FONT_STRETCH*,
                DWRITE_TEXT_RANGE*,
                int>)((*lpVtbl)[49])
        )(this, currentPosition, fontStretch, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT GetFontSize(
        [NativeTypeName("UINT32")] uint currentPosition,
        float* fontSize,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, uint, float*, DWRITE_TEXT_RANGE*, int>)(
                (*lpVtbl)[50]
            )
        )(this, currentPosition, fontSize, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT GetUnderline(
        [NativeTypeName("UINT32")] uint currentPosition,
        BOOL* hasUnderline,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, uint, BOOL*, DWRITE_TEXT_RANGE*, int>)(
                (*lpVtbl)[51]
            )
        )(this, currentPosition, hasUnderline, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT GetStrikethrough(
        [NativeTypeName("UINT32")] uint currentPosition,
        BOOL* hasStrikethrough,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, uint, BOOL*, DWRITE_TEXT_RANGE*, int>)(
                (*lpVtbl)[52]
            )
        )(this, currentPosition, hasStrikethrough, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT GetDrawingEffect(
        [NativeTypeName("UINT32")] uint currentPosition,
        IUnknown* drawingEffect,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, uint, IUnknown*, DWRITE_TEXT_RANGE*, int>)(
                (*lpVtbl)[53]
            )
        )(this, currentPosition, drawingEffect, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT GetInlineObject(
        [NativeTypeName("UINT32")] uint currentPosition,
        IDWriteInlineObject* inlineObject,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                uint,
                IDWriteInlineObject*,
                DWRITE_TEXT_RANGE*,
                int>)((*lpVtbl)[54])
        )(this, currentPosition, inlineObject, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT GetTypography(
        [NativeTypeName("UINT32")] uint currentPosition,
        IDWriteTypography* typography,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                uint,
                IDWriteTypography*,
                DWRITE_TEXT_RANGE*,
                int>)((*lpVtbl)[55])
        )(this, currentPosition, typography, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT GetLocaleNameLength(
        [NativeTypeName("UINT32")] uint currentPosition,
        [NativeTypeName("UINT32 *")] uint* nameLength,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, uint, uint*, DWRITE_TEXT_RANGE*, int>)(
                (*lpVtbl)[56]
            )
        )(this, currentPosition, nameLength, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT GetLocaleName(
        [NativeTypeName("UINT32")] uint currentPosition,
        [NativeTypeName("WCHAR *")] ushort* localeName,
        [NativeTypeName("UINT32")] uint nameSize,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(
                (*lpVtbl)[57]
            )
        )(this, currentPosition, localeName, nameSize, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT Draw(
        void* clientDrawingContext,
        IDWriteTextRenderer renderer,
        float originX,
        float originY
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                void*,
                IDWriteTextRenderer,
                float,
                float,
                int>)((*lpVtbl)[58])
        )(this, clientDrawingContext, renderer, originX, originY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT GetLineMetrics(
        DWRITE_LINE_METRICS* lineMetrics,
        [NativeTypeName("UINT32")] uint maxLineCount,
        [NativeTypeName("UINT32 *")] uint* actualLineCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_LINE_METRICS*, uint, uint*, int>)(
                (*lpVtbl)[59]
            )
        )(this, lineMetrics, maxLineCount, actualLineCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT GetMetrics(DWRITE_TEXT_METRICS* textMetrics)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_TEXT_METRICS*, int>)((*lpVtbl)[60])
        )(this, textMetrics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_OVERHANG_METRICS*, int>)((*lpVtbl)[61])
        )(this, overhangs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT GetClusterMetrics(
        DWRITE_CLUSTER_METRICS* clusterMetrics,
        [NativeTypeName("UINT32")] uint maxClusterCount,
        [NativeTypeName("UINT32 *")] uint* actualClusterCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, DWRITE_CLUSTER_METRICS*, uint, uint*, int>)(
                (*lpVtbl)[62]
            )
        )(this, clusterMetrics, maxClusterCount, actualClusterCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT DetermineMinWidth(float* minWidth)
    {
        return ((delegate* unmanaged<IDWriteTextLayout1, float*, int>)((*lpVtbl)[63]))(
            this,
            minWidth
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT HitTestPoint(
        float pointX,
        float pointY,
        BOOL* isTrailingHit,
        BOOL* isInside,
        DWRITE_HIT_TEST_METRICS* hitTestMetrics
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                float,
                float,
                BOOL*,
                BOOL*,
                DWRITE_HIT_TEST_METRICS*,
                int>)((*lpVtbl)[64])
        )(this, pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT HitTestTextPosition(
        [NativeTypeName("UINT32")] uint textPosition,
        BOOL isTrailingHit,
        float* pointX,
        float* pointY,
        DWRITE_HIT_TEST_METRICS* hitTestMetrics
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                uint,
                BOOL,
                float*,
                float*,
                DWRITE_HIT_TEST_METRICS*,
                int>)((*lpVtbl)[65])
        )(this, textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT HitTestTextRange(
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        float originX,
        float originY,
        DWRITE_HIT_TEST_METRICS* hitTestMetrics,
        [NativeTypeName("UINT32")] uint maxHitTestMetricsCount,
        [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                uint,
                uint,
                float,
                float,
                DWRITE_HIT_TEST_METRICS*,
                uint,
                uint*,
                int>)((*lpVtbl)[66])
        )(
            this,
            textPosition,
            textLength,
            originX,
            originY,
            hitTestMetrics,
            maxHitTestMetricsCount,
            actualHitTestMetricsCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT SetPairKerning(BOOL isPairKerningEnabled, DWRITE_TEXT_RANGE textRange)
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, BOOL, DWRITE_TEXT_RANGE, int>)((*lpVtbl)[67])
        )(this, isPairKerningEnabled, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT GetPairKerning(
        [NativeTypeName("UINT32")] uint currentPosition,
        BOOL* isPairKerningEnabled,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, uint, BOOL*, DWRITE_TEXT_RANGE*, int>)(
                (*lpVtbl)[68]
            )
        )(this, currentPosition, isPairKerningEnabled, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT SetCharacterSpacing(
        float leadingSpacing,
        float trailingSpacing,
        float minimumAdvanceWidth,
        DWRITE_TEXT_RANGE textRange
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextLayout1, float, float, float, DWRITE_TEXT_RANGE, int>)(
                (*lpVtbl)[69]
            )
        )(this, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT GetCharacterSpacing(
        [NativeTypeName("UINT32")] uint currentPosition,
        float* leadingSpacing,
        float* trailingSpacing,
        float* minimumAdvanceWidth,
        DWRITE_TEXT_RANGE* textRange = null
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextLayout1,
                uint,
                float*,
                float*,
                float*,
                DWRITE_TEXT_RANGE*,
                int>)((*lpVtbl)[70])
        )(this, currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
    }

    public interface Interface : IDWriteTextLayout.Interface
    {
        [VtblIndex(67)]
        HRESULT SetPairKerning(BOOL isPairKerningEnabled, DWRITE_TEXT_RANGE textRange);

        [VtblIndex(68)]
        HRESULT GetPairKerning(
            [NativeTypeName("UINT32")] uint currentPosition,
            BOOL* isPairKerningEnabled,
            DWRITE_TEXT_RANGE* textRange = null
        );

        [VtblIndex(69)]
        HRESULT SetCharacterSpacing(
            float leadingSpacing,
            float trailingSpacing,
            float minimumAdvanceWidth,
            DWRITE_TEXT_RANGE textRange
        );

        [VtblIndex(70)]
        HRESULT GetCharacterSpacing(
            [NativeTypeName("UINT32")] uint currentPosition,
            float* leadingSpacing,
            float* trailingSpacing,
            float* minimumAdvanceWidth,
            DWRITE_TEXT_RANGE* textRange = null
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
            "HRESULT (DWRITE_TEXT_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_TEXT_ALIGNMENT, int> SetTextAlignment;

        [NativeTypeName(
            "HRESULT (DWRITE_PARAGRAPH_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_PARAGRAPH_ALIGNMENT, int> SetParagraphAlignment;

        [NativeTypeName(
            "HRESULT (DWRITE_WORD_WRAPPING) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_WORD_WRAPPING, int> SetWordWrapping;

        [NativeTypeName(
            "HRESULT (DWRITE_READING_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_READING_DIRECTION, int> SetReadingDirection;

        [NativeTypeName(
            "HRESULT (DWRITE_FLOW_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FLOW_DIRECTION, int> SetFlowDirection;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetIncrementalTabStop;

        [NativeTypeName(
            "HRESULT (const DWRITE_TRIMMING *, IDWriteInlineObject *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_TRIMMING*, IDWriteInlineObject, int> SetTrimming;

        [NativeTypeName(
            "HRESULT (DWRITE_LINE_SPACING_METHOD, FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_LINE_SPACING_METHOD,
            float,
            float,
            int> SetLineSpacing;

        [NativeTypeName(
            "DWRITE_TEXT_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_TEXT_ALIGNMENT> GetTextAlignment;

        [NativeTypeName(
            "DWRITE_PARAGRAPH_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_PARAGRAPH_ALIGNMENT> GetParagraphAlignment;

        [NativeTypeName(
            "DWRITE_WORD_WRAPPING () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_WORD_WRAPPING> GetWordWrapping;

        [NativeTypeName(
            "DWRITE_READING_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_READING_DIRECTION> GetReadingDirection;

        [NativeTypeName(
            "DWRITE_FLOW_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FLOW_DIRECTION> GetFlowDirection;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetIncrementalTabStop;

        [NativeTypeName(
            "HRESULT (DWRITE_TRIMMING *, IDWriteInlineObject **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_TRIMMING*, IDWriteInlineObject*, int> GetTrimming;

        [NativeTypeName(
            "HRESULT (DWRITE_LINE_SPACING_METHOD *, FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_LINE_SPACING_METHOD*,
            float*,
            float*,
            int> GetLineSpacing;

        [NativeTypeName(
            "HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection*, int> GetFontCollection;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontFamilyNameLength;

        [NativeTypeName(
            "HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> GetFontFamilyName;

        [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_WEIGHT> GetFontWeight;

        [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STYLE> GetFontStyle;

        [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STRETCH> GetFontStretch;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetFontSize;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetLocaleNameLength;

        [NativeTypeName(
            "HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> GetLocaleName;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetMaxWidth;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetMaxHeight;

        [NativeTypeName(
            "HRESULT (IDWriteFontCollection *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontCollection,
            DWRITE_TEXT_RANGE,
            int> SetFontCollection;

        [NativeTypeName(
            "HRESULT (const WCHAR *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, DWRITE_TEXT_RANGE, int> SetFontFamilyName;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_WEIGHT,
            DWRITE_TEXT_RANGE,
            int> SetFontWeight;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE, int> SetFontStyle;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_STRETCH,
            DWRITE_TEXT_RANGE,
            int> SetFontStretch;

        [NativeTypeName(
            "HRESULT (FLOAT, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, float, DWRITE_TEXT_RANGE, int> SetFontSize;

        [NativeTypeName(
            "HRESULT (BOOL, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BOOL, DWRITE_TEXT_RANGE, int> SetUnderline;

        [NativeTypeName(
            "HRESULT (BOOL, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BOOL, DWRITE_TEXT_RANGE, int> SetStrikethrough;

        [NativeTypeName(
            "HRESULT (IUnknown *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, DWRITE_TEXT_RANGE, int> SetDrawingEffect;

        [NativeTypeName(
            "HRESULT (IDWriteInlineObject *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteInlineObject,
            DWRITE_TEXT_RANGE,
            int> SetInlineObject;

        [NativeTypeName(
            "HRESULT (IDWriteTypography *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteTypography, DWRITE_TEXT_RANGE, int> SetTypography;

        [NativeTypeName(
            "HRESULT (const WCHAR *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, DWRITE_TEXT_RANGE, int> SetLocaleName;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetMaxWidth;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetMaxHeight;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontCollection **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDWriteFontCollection*,
            DWRITE_TEXT_RANGE*,
            int> GetFontCollection1;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32 *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint*,
            DWRITE_TEXT_RANGE*,
            int> GetFontFamilyNameLength1;

        [NativeTypeName(
            "HRESULT (UINT32, WCHAR *, UINT32, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort*,
            uint,
            DWRITE_TEXT_RANGE*,
            int> GetFontFamilyName1;

        [NativeTypeName(
            "HRESULT (UINT32, DWRITE_FONT_WEIGHT *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DWRITE_FONT_WEIGHT*,
            DWRITE_TEXT_RANGE*,
            int> GetFontWeight1;

        [NativeTypeName(
            "HRESULT (UINT32, DWRITE_FONT_STYLE *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DWRITE_FONT_STYLE*,
            DWRITE_TEXT_RANGE*,
            int> GetFontStyle1;

        [NativeTypeName(
            "HRESULT (UINT32, DWRITE_FONT_STRETCH *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DWRITE_FONT_STRETCH*,
            DWRITE_TEXT_RANGE*,
            int> GetFontStretch1;

        [NativeTypeName(
            "HRESULT (UINT32, FLOAT *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, float*, DWRITE_TEXT_RANGE*, int> GetFontSize1;

        [NativeTypeName(
            "HRESULT (UINT32, BOOL *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> GetUnderline;

        [NativeTypeName(
            "HRESULT (UINT32, BOOL *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> GetStrikethrough;

        [NativeTypeName(
            "HRESULT (UINT32, IUnknown **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IUnknown*,
            DWRITE_TEXT_RANGE*,
            int> GetDrawingEffect;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteInlineObject **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDWriteInlineObject*,
            DWRITE_TEXT_RANGE*,
            int> GetInlineObject;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteTypography **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDWriteTypography*,
            DWRITE_TEXT_RANGE*,
            int> GetTypography;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32 *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint*,
            DWRITE_TEXT_RANGE*,
            int> GetLocaleNameLength1;

        [NativeTypeName(
            "HRESULT (UINT32, WCHAR *, UINT32, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort*,
            uint,
            DWRITE_TEXT_RANGE*,
            int> GetLocaleName1;

        [NativeTypeName(
            "HRESULT (void *, IDWriteTextRenderer *, FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void*, IDWriteTextRenderer, float, float, int> Draw;

        [NativeTypeName(
            "HRESULT (DWRITE_LINE_METRICS *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_LINE_METRICS*, uint, uint*, int> GetLineMetrics;

        [NativeTypeName(
            "HRESULT (DWRITE_TEXT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_TEXT_METRICS*, int> GetMetrics;

        [NativeTypeName(
            "HRESULT (DWRITE_OVERHANG_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_OVERHANG_METRICS*, int> GetOverhangMetrics;

        [NativeTypeName(
            "HRESULT (DWRITE_CLUSTER_METRICS *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_CLUSTER_METRICS*,
            uint,
            uint*,
            int> GetClusterMetrics;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> DetermineMinWidth;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, BOOL *, BOOL *, DWRITE_HIT_TEST_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            BOOL*,
            BOOL*,
            DWRITE_HIT_TEST_METRICS*,
            int> HitTestPoint;

        [NativeTypeName(
            "HRESULT (UINT32, BOOL, FLOAT *, FLOAT *, DWRITE_HIT_TEST_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            BOOL,
            float*,
            float*,
            DWRITE_HIT_TEST_METRICS*,
            int> HitTestTextPosition;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, FLOAT, FLOAT, DWRITE_HIT_TEST_METRICS *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            float,
            float,
            DWRITE_HIT_TEST_METRICS*,
            uint,
            uint*,
            int> HitTestTextRange;

        [NativeTypeName(
            "HRESULT (BOOL, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BOOL, DWRITE_TEXT_RANGE, int> SetPairKerning;

        [NativeTypeName(
            "HRESULT (UINT32, BOOL *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> GetPairKerning;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            DWRITE_TEXT_RANGE,
            int> SetCharacterSpacing;

        [NativeTypeName(
            "HRESULT (UINT32, FLOAT *, FLOAT *, FLOAT *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            float*,
            float*,
            float*,
            DWRITE_TEXT_RANGE*,
            int> GetCharacterSpacing;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteTextLayout1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteTextLayout1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteTextLayout"/> to <see cref = "IDWriteTextLayout1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteTextLayout"/> instance to be converted </param>
    public static explicit operator IDWriteTextLayout1(Silk.NET.DirectX.IDWriteTextLayout value)
    {
        return new IDWriteTextLayout1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteTextLayout1"/> to <see cref = "Silk.NET.DirectX.IDWriteTextLayout"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteTextLayout1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteTextLayout(IDWriteTextLayout1 value)
    {
        return new Silk.NET.DirectX.IDWriteTextLayout(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteTextFormat"/> to <see cref = "IDWriteTextLayout1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteTextFormat"/> instance to be converted </param>
    public static explicit operator IDWriteTextLayout1(Silk.NET.DirectX.IDWriteTextFormat value)
    {
        return new IDWriteTextLayout1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteTextLayout1"/> to <see cref = "Silk.NET.DirectX.IDWriteTextFormat"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteTextLayout1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteTextFormat(IDWriteTextLayout1 value)
    {
        return new Silk.NET.DirectX.IDWriteTextFormat(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteTextLayout1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteTextLayout1(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteTextLayout1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteTextLayout1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteTextLayout1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteTextLayout1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
