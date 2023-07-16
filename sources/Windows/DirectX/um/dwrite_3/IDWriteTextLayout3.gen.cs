// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteTextLayout3.xml' path='doc/member[@name="IDWriteTextLayout3"]/*'/>
[Guid("07DDCD52-020E-4DE8-AC33-6C953D83F92D")]
[NativeTypeName("struct IDWriteTextLayout3 : IDWriteTextLayout2")]
[NativeInheritance("IDWriteTextLayout2")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDWriteTextLayout3 : IDWriteTextLayout3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextLayout3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint> )(lpVtbl[1]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint> )(lpVtbl[2]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetTextAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_TEXT_ALIGNMENT, int> )(lpVtbl[3]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textAlignment);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetParagraphAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_PARAGRAPH_ALIGNMENT, int> )(lpVtbl[4]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), paragraphAlignment);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetWordWrapping"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_WORD_WRAPPING, int> )(lpVtbl[5]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), wordWrapping);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetReadingDirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_READING_DIRECTION, int> )(lpVtbl[6]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), readingDirection);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetFlowDirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_FLOW_DIRECTION, int> )(lpVtbl[7]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), flowDirection);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetIncrementalTabStop"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetIncrementalTabStop(float incrementalTabStop)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float, int> )(lpVtbl[8]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), incrementalTabStop);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetTrimming"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_TRIMMING*, IDWriteInlineObject*, int> )(lpVtbl[9]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetLineSpacing"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_LINE_SPACING_METHOD, float, float, int> )(lpVtbl[10]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetTextAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_TEXT_ALIGNMENT> )(lpVtbl[11]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetParagraphAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_PARAGRAPH_ALIGNMENT> )(lpVtbl[12]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetWordWrapping"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public DWRITE_WORD_WRAPPING GetWordWrapping()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_WORD_WRAPPING> )(lpVtbl[13]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetReadingDirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public DWRITE_READING_DIRECTION GetReadingDirection()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_READING_DIRECTION> )(lpVtbl[14]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFlowDirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public DWRITE_FLOW_DIRECTION GetFlowDirection()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_FLOW_DIRECTION> )(lpVtbl[15]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetIncrementalTabStop"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public float GetIncrementalTabStop()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float> )(lpVtbl[16]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetTrimming"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_TRIMMING*, IDWriteInlineObject**, int> )(lpVtbl[17]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetLineSpacing"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int> )(lpVtbl[18]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFontCollection(IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, IDWriteFontCollection**, int> )(lpVtbl[19]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontCollection);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontFamilyNameLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFamilyNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint> )(lpVtbl[20]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontFamilyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, ushort*, uint, int> )(lpVtbl[21]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontWeight"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public DWRITE_FONT_WEIGHT GetFontWeight()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_FONT_WEIGHT> )(lpVtbl[22]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontStyle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public DWRITE_FONT_STYLE GetFontStyle()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_FONT_STYLE> )(lpVtbl[23]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontStretch"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public DWRITE_FONT_STRETCH GetFontStretch()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_FONT_STRETCH> )(lpVtbl[24]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public float GetFontSize()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float> )(lpVtbl[25]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetLocaleNameLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("UINT32")]
    public uint GetLocaleNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint> )(lpVtbl[26]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetLocaleName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, ushort*, uint, int> )(lpVtbl[27]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), localeName, nameSize);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetMaxWidth"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetMaxWidth(float maxWidth)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float, int> )(lpVtbl[28]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), maxWidth);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetMaxHeight"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetMaxHeight(float maxHeight)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float, int> )(lpVtbl[29]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), maxHeight);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetFontCollection(IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, IDWriteFontCollection*, DWRITE_TEXT_RANGE, int> )(lpVtbl[30]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontCollection, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetFontFamilyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetFontFamilyName([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, ushort*, DWRITE_TEXT_RANGE, int> )(lpVtbl[31]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFamilyName, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetFontWeight"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE, int> )(lpVtbl[32]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontWeight, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetFontStyle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE, int> )(lpVtbl[33]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontStyle, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetFontStretch"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE, int> )(lpVtbl[34]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontStretch, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetFontSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetFontSize(float fontSize, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float, DWRITE_TEXT_RANGE, int> )(lpVtbl[35]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontSize, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetUnderline"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT SetUnderline(BOOL hasUnderline, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, BOOL, DWRITE_TEXT_RANGE, int> )(lpVtbl[36]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), hasUnderline, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetStrikethrough"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetStrikethrough(BOOL hasStrikethrough, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, BOOL, DWRITE_TEXT_RANGE, int> )(lpVtbl[37]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), hasStrikethrough, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetDrawingEffect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT SetDrawingEffect(IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, IUnknown*, DWRITE_TEXT_RANGE, int> )(lpVtbl[38]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), drawingEffect, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetInlineObject"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetInlineObject(IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, IDWriteInlineObject*, DWRITE_TEXT_RANGE, int> )(lpVtbl[39]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), inlineObject, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetTypography"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT SetTypography(IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, IDWriteTypography*, DWRITE_TEXT_RANGE, int> )(lpVtbl[40]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), typography, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.SetLocaleName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT SetLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, ushort*, DWRITE_TEXT_RANGE, int> )(lpVtbl[41]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), localeName, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetMaxWidth"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public float GetMaxWidth()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float> )(lpVtbl[42]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetMaxHeight"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public float GetMaxHeight()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float> )(lpVtbl[43]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT GetFontCollection([NativeTypeName("UINT32")] uint currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, IDWriteFontCollection**, DWRITE_TEXT_RANGE*, int> )(lpVtbl[44]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontCollection, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetFontFamilyNameLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT GetFontFamilyNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, uint*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[45]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetFontFamilyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT GetFontFamilyName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int> )(lpVtbl[46]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontFamilyName, nameSize, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetFontWeight"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT GetFontWeight([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, DWRITE_FONT_WEIGHT*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[47]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontWeight, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetFontStyle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT GetFontStyle([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, DWRITE_FONT_STYLE*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[48]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontStyle, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetFontStretch"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT GetFontStretch([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, DWRITE_FONT_STRETCH*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[49]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontStretch, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetFontSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT GetFontSize([NativeTypeName("UINT32")] uint currentPosition, float* fontSize, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, float*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[50]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontSize, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetUnderline"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT GetUnderline([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasUnderline, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[51]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, hasUnderline, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetStrikethrough"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasStrikethrough, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[52]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, hasStrikethrough, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetDrawingEffect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, IUnknown**, DWRITE_TEXT_RANGE*, int> )(lpVtbl[53]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, drawingEffect, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetInlineObject"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, IDWriteInlineObject**, DWRITE_TEXT_RANGE*, int> )(lpVtbl[54]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, inlineObject, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetTypography"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT GetTypography([NativeTypeName("UINT32")] uint currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, IDWriteTypography**, DWRITE_TEXT_RANGE*, int> )(lpVtbl[55]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, typography, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetLocaleNameLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT GetLocaleNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, uint*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[56]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetLocaleName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT GetLocaleName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int> )(lpVtbl[57]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, localeName, nameSize, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.Draw"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, void*, IDWriteTextRenderer*, float, float, int> )(lpVtbl[58]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetLineMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT GetLineMetrics(DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_LINE_METRICS*, uint, uint*, int> )(lpVtbl[59]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT GetMetrics(DWRITE_TEXT_METRICS* textMetrics)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_TEXT_METRICS*, int> )(lpVtbl[60]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textMetrics);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetOverhangMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_OVERHANG_METRICS*, int> )(lpVtbl[61]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), overhangs);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.GetClusterMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT GetClusterMetrics(DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_CLUSTER_METRICS*, uint, uint*, int> )(lpVtbl[62]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), clusterMetrics, maxClusterCount, actualClusterCount);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.DetermineMinWidth"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT DetermineMinWidth(float* minWidth)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float*, int> )(lpVtbl[63]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), minWidth);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.HitTestPoint"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT HitTestPoint(float pointX, float pointY, BOOL* isTrailingHit, BOOL* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float, float, BOOL*, BOOL*, DWRITE_HIT_TEST_METRICS*, int> )(lpVtbl[64]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.HitTestTextPosition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, BOOL isTrailingHit, float* pointX, float* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, BOOL, float*, float*, DWRITE_HIT_TEST_METRICS*, int> )(lpVtbl[65]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
    }

    /// <inheritdoc cref = "IDWriteTextLayout.HitTestTextRange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, float originX, float originY, DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, uint, float, float, DWRITE_HIT_TEST_METRICS*, uint, uint*, int> )(lpVtbl[66]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
    }

    /// <inheritdoc cref = "IDWriteTextLayout1.SetPairKerning"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT SetPairKerning(BOOL isPairKerningEnabled, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, BOOL, DWRITE_TEXT_RANGE, int> )(lpVtbl[67]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), isPairKerningEnabled, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout1.GetPairKerning"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT GetPairKerning([NativeTypeName("UINT32")] uint currentPosition, BOOL* isPairKerningEnabled, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[68]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, isPairKerningEnabled, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout1.SetCharacterSpacing"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT SetCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, float, float, float, DWRITE_TEXT_RANGE, int> )(lpVtbl[69]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout1.GetCharacterSpacing"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT GetCharacterSpacing([NativeTypeName("UINT32")] uint currentPosition, float* leadingSpacing, float* trailingSpacing, float* minimumAdvanceWidth, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, uint, float*, float*, float*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[70]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
    }

    /// <inheritdoc cref = "IDWriteTextLayout2.GetMetrics"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT GetMetrics(DWRITE_TEXT_METRICS1* textMetrics)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_TEXT_METRICS1*, int> )(lpVtbl[71]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textMetrics);
    }

    /// <inheritdoc cref = "IDWriteTextLayout2.SetVerticalGlyphOrientation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int> )(lpVtbl[72]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), glyphOrientation);
    }

    /// <inheritdoc cref = "IDWriteTextLayout2.GetVerticalGlyphOrientation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_VERTICAL_GLYPH_ORIENTATION> )(lpVtbl[73]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextLayout2.SetLastLineWrapping"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT SetLastLineWrapping(BOOL isLastLineWrappingEnabled)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, BOOL, int> )(lpVtbl[74]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
    }

    /// <inheritdoc cref = "IDWriteTextLayout2.GetLastLineWrapping"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public BOOL GetLastLineWrapping()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, int> )(lpVtbl[75]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextLayout2.SetOpticalAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_OPTICAL_ALIGNMENT, int> )(lpVtbl[76]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), opticalAlignment);
    }

    /// <inheritdoc cref = "IDWriteTextLayout2.GetOpticalAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_OPTICAL_ALIGNMENT> )(lpVtbl[77]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextLayout2.SetFontFallback"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT SetFontFallback(IDWriteFontFallback* fontFallback)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, IDWriteFontFallback*, int> )(lpVtbl[78]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFallback);
    }

    /// <inheritdoc cref = "IDWriteTextLayout2.GetFontFallback"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT GetFontFallback(IDWriteFontFallback** fontFallback)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, IDWriteFontFallback**, int> )(lpVtbl[79]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFallback);
    }

    /// <include file='IDWriteTextLayout3.xml' path='doc/member[@name="IDWriteTextLayout3.InvalidateLayout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT InvalidateLayout()
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, int> )(lpVtbl[80]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextLayout3.xml' path='doc/member[@name="IDWriteTextLayout3.SetLineSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT SetLineSpacing([NativeTypeName("const DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_LINE_SPACING*, int> )(lpVtbl[81]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
    }

    /// <include file='IDWriteTextLayout3.xml' path='doc/member[@name="IDWriteTextLayout3.GetLineSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT GetLineSpacing(DWRITE_LINE_SPACING* lineSpacingOptions)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_LINE_SPACING*, int> )(lpVtbl[82]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
    }

    /// <include file='IDWriteTextLayout3.xml' path='doc/member[@name="IDWriteTextLayout3.GetLineMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT GetLineMetrics(DWRITE_LINE_METRICS1* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
    {
        return ((delegate* unmanaged<IDWriteTextLayout3*, DWRITE_LINE_METRICS1*, uint, uint*, int> )(lpVtbl[83]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
    }

    public interface Interface : IDWriteTextLayout2.Interface
    {
        [VtblIndex(80)]
        HRESULT InvalidateLayout();
        [VtblIndex(81)]
        HRESULT SetLineSpacing([NativeTypeName("const DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions);
        [VtblIndex(82)]
        HRESULT GetLineSpacing(DWRITE_LINE_SPACING* lineSpacingOptions);
        [VtblIndex(83)]
        HRESULT GetLineMetrics(DWRITE_LINE_METRICS1* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount);
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
        [NativeTypeName("HRESULT (DWRITE_TEXT_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_TEXT_ALIGNMENT, int> SetTextAlignment;
        [NativeTypeName("HRESULT (DWRITE_PARAGRAPH_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_PARAGRAPH_ALIGNMENT, int> SetParagraphAlignment;
        [NativeTypeName("HRESULT (DWRITE_WORD_WRAPPING) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_WORD_WRAPPING, int> SetWordWrapping;
        [NativeTypeName("HRESULT (DWRITE_READING_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_READING_DIRECTION, int> SetReadingDirection;
        [NativeTypeName("HRESULT (DWRITE_FLOW_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FLOW_DIRECTION, int> SetFlowDirection;
        [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetIncrementalTabStop;
        [NativeTypeName("HRESULT (const DWRITE_TRIMMING *, IDWriteInlineObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_TRIMMING*, IDWriteInlineObject*, int> SetTrimming;
        [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD, FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LINE_SPACING_METHOD, float, float, int> SetLineSpacing;
        [NativeTypeName("DWRITE_TEXT_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_TEXT_ALIGNMENT> GetTextAlignment;
        [NativeTypeName("DWRITE_PARAGRAPH_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_PARAGRAPH_ALIGNMENT> GetParagraphAlignment;
        [NativeTypeName("DWRITE_WORD_WRAPPING () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_WORD_WRAPPING> GetWordWrapping;
        [NativeTypeName("DWRITE_READING_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_READING_DIRECTION> GetReadingDirection;
        [NativeTypeName("DWRITE_FLOW_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FLOW_DIRECTION> GetFlowDirection;
        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetIncrementalTabStop;
        [NativeTypeName("HRESULT (DWRITE_TRIMMING *, IDWriteInlineObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_TRIMMING*, IDWriteInlineObject**, int> GetTrimming;
        [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD *, FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int> GetLineSpacing;
        [NativeTypeName("HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection**, int> GetFontCollection;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontFamilyNameLength;
        [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
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
        [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> GetLocaleName;
        [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetMaxWidth;
        [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetMaxHeight;
        [NativeTypeName("HRESULT (IDWriteFontCollection *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection*, DWRITE_TEXT_RANGE, int> SetFontCollection;
        [NativeTypeName("HRESULT (const WCHAR *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, DWRITE_TEXT_RANGE, int> SetFontFamilyName;
        [NativeTypeName("HRESULT (DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE, int> SetFontWeight;
        [NativeTypeName("HRESULT (DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE, int> SetFontStyle;
        [NativeTypeName("HRESULT (DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE, int> SetFontStretch;
        [NativeTypeName("HRESULT (FLOAT, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, DWRITE_TEXT_RANGE, int> SetFontSize;
        [NativeTypeName("HRESULT (BOOL, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, DWRITE_TEXT_RANGE, int> SetUnderline;
        [NativeTypeName("HRESULT (BOOL, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, DWRITE_TEXT_RANGE, int> SetStrikethrough;
        [NativeTypeName("HRESULT (IUnknown *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, DWRITE_TEXT_RANGE, int> SetDrawingEffect;
        [NativeTypeName("HRESULT (IDWriteInlineObject *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteInlineObject*, DWRITE_TEXT_RANGE, int> SetInlineObject;
        [NativeTypeName("HRESULT (IDWriteTypography *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteTypography*, DWRITE_TEXT_RANGE, int> SetTypography;
        [NativeTypeName("HRESULT (const WCHAR *, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, DWRITE_TEXT_RANGE, int> SetLocaleName;
        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetMaxWidth;
        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetMaxHeight;
        [NativeTypeName("HRESULT (UINT32, IDWriteFontCollection **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontCollection**, DWRITE_TEXT_RANGE*, int> GetFontCollection1;
        [NativeTypeName("HRESULT (UINT32, UINT32 *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, DWRITE_TEXT_RANGE*, int> GetFontFamilyNameLength1;
        [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int> GetFontFamilyName1;
        [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_WEIGHT *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_FONT_WEIGHT*, DWRITE_TEXT_RANGE*, int> GetFontWeight1;
        [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_STYLE *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_FONT_STYLE*, DWRITE_TEXT_RANGE*, int> GetFontStyle1;
        [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_STRETCH *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_FONT_STRETCH*, DWRITE_TEXT_RANGE*, int> GetFontStretch1;
        [NativeTypeName("HRESULT (UINT32, FLOAT *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, DWRITE_TEXT_RANGE*, int> GetFontSize1;
        [NativeTypeName("HRESULT (UINT32, BOOL *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> GetUnderline;
        [NativeTypeName("HRESULT (UINT32, BOOL *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> GetStrikethrough;
        [NativeTypeName("HRESULT (UINT32, IUnknown **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown**, DWRITE_TEXT_RANGE*, int> GetDrawingEffect;
        [NativeTypeName("HRESULT (UINT32, IDWriteInlineObject **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteInlineObject**, DWRITE_TEXT_RANGE*, int> GetInlineObject;
        [NativeTypeName("HRESULT (UINT32, IDWriteTypography **, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteTypography**, DWRITE_TEXT_RANGE*, int> GetTypography;
        [NativeTypeName("HRESULT (UINT32, UINT32 *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, DWRITE_TEXT_RANGE*, int> GetLocaleNameLength1;
        [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int> GetLocaleName1;
        [NativeTypeName("HRESULT (void *, IDWriteTextRenderer *, FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, IDWriteTextRenderer*, float, float, int> Draw;
        [NativeTypeName("HRESULT (DWRITE_LINE_METRICS *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LINE_METRICS*, uint, uint*, int> GetLineMetrics;
        [NativeTypeName("HRESULT (DWRITE_TEXT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_TEXT_METRICS*, int> GetMetrics;
        [NativeTypeName("HRESULT (DWRITE_OVERHANG_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_OVERHANG_METRICS*, int> GetOverhangMetrics;
        [NativeTypeName("HRESULT (DWRITE_CLUSTER_METRICS *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_CLUSTER_METRICS*, uint, uint*, int> GetClusterMetrics;
        [NativeTypeName("HRESULT (FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> DetermineMinWidth;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, BOOL *, BOOL *, DWRITE_HIT_TEST_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, BOOL*, BOOL*, DWRITE_HIT_TEST_METRICS*, int> HitTestPoint;
        [NativeTypeName("HRESULT (UINT32, BOOL, FLOAT *, FLOAT *, DWRITE_HIT_TEST_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, float*, float*, DWRITE_HIT_TEST_METRICS*, int> HitTestTextPosition;
        [NativeTypeName("HRESULT (UINT32, UINT32, FLOAT, FLOAT, DWRITE_HIT_TEST_METRICS *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, float, float, DWRITE_HIT_TEST_METRICS*, uint, uint*, int> HitTestTextRange;
        [NativeTypeName("HRESULT (BOOL, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, DWRITE_TEXT_RANGE, int> SetPairKerning;
        [NativeTypeName("HRESULT (UINT32, BOOL *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> GetPairKerning;
        [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, DWRITE_TEXT_RANGE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, DWRITE_TEXT_RANGE, int> SetCharacterSpacing;
        [NativeTypeName("HRESULT (UINT32, FLOAT *, FLOAT *, FLOAT *, DWRITE_TEXT_RANGE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, float*, float*, DWRITE_TEXT_RANGE*, int> GetCharacterSpacing;
        [NativeTypeName("HRESULT (DWRITE_TEXT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_TEXT_METRICS1*, int> GetMetrics1;
        [NativeTypeName("HRESULT (DWRITE_VERTICAL_GLYPH_ORIENTATION) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int> SetVerticalGlyphOrientation;
        [NativeTypeName("DWRITE_VERTICAL_GLYPH_ORIENTATION () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_VERTICAL_GLYPH_ORIENTATION> GetVerticalGlyphOrientation;
        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetLastLineWrapping;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetLastLineWrapping;
        [NativeTypeName("HRESULT (DWRITE_OPTICAL_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_OPTICAL_ALIGNMENT, int> SetOpticalAlignment;
        [NativeTypeName("DWRITE_OPTICAL_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_OPTICAL_ALIGNMENT> GetOpticalAlignment;
        [NativeTypeName("HRESULT (IDWriteFontFallback *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFallback*, int> SetFontFallback;
        [NativeTypeName("HRESULT (IDWriteFontFallback **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFallback**, int> GetFontFallback;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InvalidateLayout;
        [NativeTypeName("HRESULT (const DWRITE_LINE_SPACING *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LINE_SPACING*, int> SetLineSpacing1;
        [NativeTypeName("HRESULT (DWRITE_LINE_SPACING *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LINE_SPACING*, int> GetLineSpacing1;
        [NativeTypeName("HRESULT (DWRITE_LINE_METRICS1 *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LINE_METRICS1*, uint, uint*, int> GetLineMetrics1;
    }
}