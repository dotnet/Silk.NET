// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat"]/*' />
[Guid("9C906818-31D7-4FD3-A151-7C5E225DB55A")]
[NativeTypeName("struct IDWriteTextFormat : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteTextFormat : IDWriteTextFormat.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextFormat));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, uint>)(lpVtbl[1]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, uint>)(lpVtbl[2]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.SetTextAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), textAlignment);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.SetParagraphAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), paragraphAlignment);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.SetWordWrapping"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), wordWrapping);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.SetReadingDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), readingDirection);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.SetFlowDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), flowDirection);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.SetIncrementalTabStop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetIncrementalTabStop(float incrementalTabStop)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, float, int>)(lpVtbl[8]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), incrementalTabStop);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.SetTrimming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.SetLineSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetTextAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetParagraphAlignment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetWordWrapping"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public DWRITE_WORD_WRAPPING GetWordWrapping()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetReadingDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public DWRITE_READING_DIRECTION GetReadingDirection()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetFlowDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public DWRITE_FLOW_DIRECTION GetFlowDirection()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetIncrementalTabStop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public float GetIncrementalTabStop()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, float>)(lpVtbl[16]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetTrimming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetLineSpacing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetFontCollection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFontCollection(IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), fontCollection);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetFontFamilyNameLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFamilyNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, uint>)(lpVtbl[20]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetFontFamilyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetFontWeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public DWRITE_FONT_WEIGHT GetFontWeight()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetFontStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public DWRITE_FONT_STYLE GetFontStyle()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetFontStretch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public DWRITE_FONT_STRETCH GetFontStretch()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetFontSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public float GetFontSize()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, float>)(lpVtbl[25]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetLocaleNameLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("UINT32")]
    public uint GetLocaleNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, uint>)(lpVtbl[26]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteTextFormat.xml' path='doc/member[@name="IDWriteTextFormat.GetLocaleName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
    {
        return ((delegate* unmanaged<IDWriteTextFormat*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat*)Unsafe.AsPointer(ref this), localeName, nameSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment);

        [VtblIndex(4)]
        HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);

        [VtblIndex(5)]
        HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping);

        [VtblIndex(6)]
        HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection);

        [VtblIndex(7)]
        HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection);

        [VtblIndex(8)]
        HRESULT SetIncrementalTabStop(float incrementalTabStop);

        [VtblIndex(9)]
        HRESULT SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign);

        [VtblIndex(10)]
        HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline);

        [VtblIndex(11)]
        DWRITE_TEXT_ALIGNMENT GetTextAlignment();

        [VtblIndex(12)]
        DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment();

        [VtblIndex(13)]
        DWRITE_WORD_WRAPPING GetWordWrapping();

        [VtblIndex(14)]
        DWRITE_READING_DIRECTION GetReadingDirection();

        [VtblIndex(15)]
        DWRITE_FLOW_DIRECTION GetFlowDirection();

        [VtblIndex(16)]
        float GetIncrementalTabStop();

        [VtblIndex(17)]
        HRESULT GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign);

        [VtblIndex(18)]
        HRESULT GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, float* lineSpacing, float* baseline);

        [VtblIndex(19)]
        HRESULT GetFontCollection(IDWriteFontCollection** fontCollection);

        [VtblIndex(20)]
        [return: NativeTypeName("UINT32")]
        uint GetFontFamilyNameLength();

        [VtblIndex(21)]
        HRESULT GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize);

        [VtblIndex(22)]
        DWRITE_FONT_WEIGHT GetFontWeight();

        [VtblIndex(23)]
        DWRITE_FONT_STYLE GetFontStyle();

        [VtblIndex(24)]
        DWRITE_FONT_STRETCH GetFontStretch();

        [VtblIndex(25)]
        float GetFontSize();

        [VtblIndex(26)]
        [return: NativeTypeName("UINT32")]
        uint GetLocaleNameLength();

        [VtblIndex(27)]
        HRESULT GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize);
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
    }
}
