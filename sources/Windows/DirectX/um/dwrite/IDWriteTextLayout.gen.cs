// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout"]/*'/>
[Guid("53737037-6D14-410B-9BFE-0B182BB70961")]
[NativeTypeName("struct IDWriteTextLayout : IDWriteTextFormat")]
[NativeInheritance("IDWriteTextFormat")]
public unsafe partial struct IDWriteTextLayout : IDWriteTextLayout.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextLayout));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint> )(lpVtbl[1]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint> )(lpVtbl[2]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetTextAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_TEXT_ALIGNMENT, int> )(lpVtbl[3]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textAlignment);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetParagraphAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_PARAGRAPH_ALIGNMENT, int> )(lpVtbl[4]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), paragraphAlignment);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetWordWrapping"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_WORD_WRAPPING, int> )(lpVtbl[5]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), wordWrapping);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetReadingDirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_READING_DIRECTION, int> )(lpVtbl[6]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), readingDirection);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetFlowDirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_FLOW_DIRECTION, int> )(lpVtbl[7]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), flowDirection);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetIncrementalTabStop"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetIncrementalTabStop(float incrementalTabStop)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, float, int> )(lpVtbl[8]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), incrementalTabStop);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetTrimming"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_TRIMMING*, IDWriteInlineObject*, int> )(lpVtbl[9]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.SetLineSpacing"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_LINE_SPACING_METHOD, float, float, int> )(lpVtbl[10]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetTextAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_TEXT_ALIGNMENT> )(lpVtbl[11]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetParagraphAlignment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_PARAGRAPH_ALIGNMENT> )(lpVtbl[12]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetWordWrapping"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public DWRITE_WORD_WRAPPING GetWordWrapping()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_WORD_WRAPPING> )(lpVtbl[13]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetReadingDirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public DWRITE_READING_DIRECTION GetReadingDirection()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_READING_DIRECTION> )(lpVtbl[14]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFlowDirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public DWRITE_FLOW_DIRECTION GetFlowDirection()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_FLOW_DIRECTION> )(lpVtbl[15]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetIncrementalTabStop"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public float GetIncrementalTabStop()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, float> )(lpVtbl[16]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetTrimming"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_TRIMMING*, IDWriteInlineObject**, int> )(lpVtbl[17]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetLineSpacing"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int> )(lpVtbl[18]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFontCollection(IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, IDWriteFontCollection**, int> )(lpVtbl[19]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontCollection);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontFamilyNameLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFamilyNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint> )(lpVtbl[20]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontFamilyName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, ushort*, uint, int> )(lpVtbl[21]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontWeight"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public DWRITE_FONT_WEIGHT GetFontWeight()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_FONT_WEIGHT> )(lpVtbl[22]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontStyle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public DWRITE_FONT_STYLE GetFontStyle()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_FONT_STYLE> )(lpVtbl[23]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontStretch"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public DWRITE_FONT_STRETCH GetFontStretch()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_FONT_STRETCH> )(lpVtbl[24]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetFontSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public float GetFontSize()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, float> )(lpVtbl[25]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetLocaleNameLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("UINT32")]
    public uint GetLocaleNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint> )(lpVtbl[26]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextFormat.GetLocaleName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, ushort*, uint, int> )(lpVtbl[27]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), localeName, nameSize);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetMaxWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetMaxWidth(float maxWidth)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, float, int> )(lpVtbl[28]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), maxWidth);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetMaxHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetMaxHeight(float maxHeight)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, float, int> )(lpVtbl[29]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), maxHeight);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetFontCollection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetFontCollection(IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, IDWriteFontCollection*, DWRITE_TEXT_RANGE, int> )(lpVtbl[30]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontCollection, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetFontFamilyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetFontFamilyName([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, ushort*, DWRITE_TEXT_RANGE, int> )(lpVtbl[31]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontFamilyName, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetFontWeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE, int> )(lpVtbl[32]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontWeight, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetFontStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE, int> )(lpVtbl[33]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontStyle, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetFontStretch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE, int> )(lpVtbl[34]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontStretch, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetFontSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT SetFontSize(float fontSize, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, float, DWRITE_TEXT_RANGE, int> )(lpVtbl[35]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontSize, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetUnderline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT SetUnderline(BOOL hasUnderline, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, BOOL, DWRITE_TEXT_RANGE, int> )(lpVtbl[36]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), hasUnderline, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetStrikethrough"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetStrikethrough(BOOL hasStrikethrough, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, BOOL, DWRITE_TEXT_RANGE, int> )(lpVtbl[37]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), hasStrikethrough, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetDrawingEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT SetDrawingEffect(IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, IUnknown*, DWRITE_TEXT_RANGE, int> )(lpVtbl[38]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), drawingEffect, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetInlineObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetInlineObject(IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, IDWriteInlineObject*, DWRITE_TEXT_RANGE, int> )(lpVtbl[39]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), inlineObject, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetTypography"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT SetTypography(IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, IDWriteTypography*, DWRITE_TEXT_RANGE, int> )(lpVtbl[40]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), typography, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.SetLocaleName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT SetLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, ushort*, DWRITE_TEXT_RANGE, int> )(lpVtbl[41]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), localeName, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetMaxWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public float GetMaxWidth()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, float> )(lpVtbl[42]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetMaxHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public float GetMaxHeight()
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, float> )(lpVtbl[43]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetFontCollection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT GetFontCollection([NativeTypeName("UINT32")] uint currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, IDWriteFontCollection**, DWRITE_TEXT_RANGE*, int> )(lpVtbl[44]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontCollection, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetFontFamilyNameLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT GetFontFamilyNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, uint*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[45]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetFontFamilyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT GetFontFamilyName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int> )(lpVtbl[46]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontFamilyName, nameSize, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetFontWeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT GetFontWeight([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, DWRITE_FONT_WEIGHT*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[47]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontWeight, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetFontStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT GetFontStyle([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, DWRITE_FONT_STYLE*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[48]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontStyle, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetFontStretch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT GetFontStretch([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, DWRITE_FONT_STRETCH*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[49]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontStretch, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetFontSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT GetFontSize([NativeTypeName("UINT32")] uint currentPosition, float* fontSize, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, float*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[50]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontSize, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetUnderline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT GetUnderline([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasUnderline, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[51]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, hasUnderline, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetStrikethrough"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasStrikethrough, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, BOOL*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[52]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, hasStrikethrough, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetDrawingEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, IUnknown**, DWRITE_TEXT_RANGE*, int> )(lpVtbl[53]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, drawingEffect, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetInlineObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, IDWriteInlineObject**, DWRITE_TEXT_RANGE*, int> )(lpVtbl[54]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, inlineObject, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetTypography"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT GetTypography([NativeTypeName("UINT32")] uint currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, IDWriteTypography**, DWRITE_TEXT_RANGE*, int> )(lpVtbl[55]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, typography, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetLocaleNameLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT GetLocaleNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, uint*, DWRITE_TEXT_RANGE*, int> )(lpVtbl[56]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetLocaleName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT GetLocaleName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int> )(lpVtbl[57]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, localeName, nameSize, textRange);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.Draw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, void*, IDWriteTextRenderer*, float, float, int> )(lpVtbl[58]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetLineMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT GetLineMetrics(DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_LINE_METRICS*, uint, uint*, int> )(lpVtbl[59]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT GetMetrics(DWRITE_TEXT_METRICS* textMetrics)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_TEXT_METRICS*, int> )(lpVtbl[60]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textMetrics);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetOverhangMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_OVERHANG_METRICS*, int> )(lpVtbl[61]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), overhangs);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.GetClusterMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT GetClusterMetrics(DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, DWRITE_CLUSTER_METRICS*, uint, uint*, int> )(lpVtbl[62]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), clusterMetrics, maxClusterCount, actualClusterCount);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.DetermineMinWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT DetermineMinWidth(float* minWidth)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, float*, int> )(lpVtbl[63]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), minWidth);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.HitTestPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT HitTestPoint(float pointX, float pointY, BOOL* isTrailingHit, BOOL* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, float, float, BOOL*, BOOL*, DWRITE_HIT_TEST_METRICS*, int> )(lpVtbl[64]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.HitTestTextPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, BOOL isTrailingHit, float* pointX, float* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, BOOL, float*, float*, DWRITE_HIT_TEST_METRICS*, int> )(lpVtbl[65]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
    }

    /// <include file='IDWriteTextLayout.xml' path='doc/member[@name="IDWriteTextLayout.HitTestTextRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, float originX, float originY, DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount)
    {
        return ((delegate* unmanaged<IDWriteTextLayout*, uint, uint, float, float, DWRITE_HIT_TEST_METRICS*, uint, uint*, int> )(lpVtbl[66]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
    }

    public interface Interface : IDWriteTextFormat.Interface
    {
        [VtblIndex(28)]
        HRESULT SetMaxWidth(float maxWidth);
        [VtblIndex(29)]
        HRESULT SetMaxHeight(float maxHeight);
        [VtblIndex(30)]
        HRESULT SetFontCollection(IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(31)]
        HRESULT SetFontFamilyName([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(32)]
        HRESULT SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(33)]
        HRESULT SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(34)]
        HRESULT SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(35)]
        HRESULT SetFontSize(float fontSize, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(36)]
        HRESULT SetUnderline(BOOL hasUnderline, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(37)]
        HRESULT SetStrikethrough(BOOL hasStrikethrough, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(38)]
        HRESULT SetDrawingEffect(IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(39)]
        HRESULT SetInlineObject(IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(40)]
        HRESULT SetTypography(IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(41)]
        HRESULT SetLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange);
        [VtblIndex(42)]
        float GetMaxWidth();
        [VtblIndex(43)]
        float GetMaxHeight();
        [VtblIndex(44)]
        HRESULT GetFontCollection([NativeTypeName("UINT32")] uint currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(45)]
        HRESULT GetFontFamilyNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(46)]
        HRESULT GetFontFamilyName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(47)]
        HRESULT GetFontWeight([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(48)]
        HRESULT GetFontStyle([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(49)]
        HRESULT GetFontStretch([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(50)]
        HRESULT GetFontSize([NativeTypeName("UINT32")] uint currentPosition, float* fontSize, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(51)]
        HRESULT GetUnderline([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasUnderline, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(52)]
        HRESULT GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasStrikethrough, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(53)]
        HRESULT GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(54)]
        HRESULT GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(55)]
        HRESULT GetTypography([NativeTypeName("UINT32")] uint currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(56)]
        HRESULT GetLocaleNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(57)]
        HRESULT GetLocaleName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null);
        [VtblIndex(58)]
        HRESULT Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY);
        [VtblIndex(59)]
        HRESULT GetLineMetrics(DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount);
        [VtblIndex(60)]
        HRESULT GetMetrics(DWRITE_TEXT_METRICS* textMetrics);
        [VtblIndex(61)]
        HRESULT GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs);
        [VtblIndex(62)]
        HRESULT GetClusterMetrics(DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount);
        [VtblIndex(63)]
        HRESULT DetermineMinWidth(float* minWidth);
        [VtblIndex(64)]
        HRESULT HitTestPoint(float pointX, float pointY, BOOL* isTrailingHit, BOOL* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics);
        [VtblIndex(65)]
        HRESULT HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, BOOL isTrailingHit, float* pointX, float* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics);
        [VtblIndex(66)]
        HRESULT HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, float originX, float originY, DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount);
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
    }
}