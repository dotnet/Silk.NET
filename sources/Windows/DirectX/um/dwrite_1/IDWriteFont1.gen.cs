// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDWriteFont1.xml' path='doc/member[@name="IDWriteFont1"]/*' />
[Guid("ACD16696-8C14-4F5D-877E-FE3FC1D32738")]
[NativeTypeName("struct IDWriteFont1 : IDWriteFont")]
[NativeInheritance("IDWriteFont")]
public unsafe partial struct IDWriteFont1 : IDWriteFont1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFont1));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFont1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFont1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFont1*, uint>)(lpVtbl[1]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFont1*, uint>)(lpVtbl[2]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.GetFontFamily" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontFamily(IDWriteFontFamily** fontFamily)
    {
        return ((delegate* unmanaged<IDWriteFont1*, IDWriteFontFamily**, int>)(lpVtbl[3]))((IDWriteFont1*)Unsafe.AsPointer(ref this), fontFamily);
    }

    /// <inheritdoc cref="IDWriteFont.GetWeight" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public DWRITE_FONT_WEIGHT GetWeight()
    {
        return ((delegate* unmanaged<IDWriteFont1*, DWRITE_FONT_WEIGHT>)(lpVtbl[4]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.GetStretch" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public DWRITE_FONT_STRETCH GetStretch()
    {
        return ((delegate* unmanaged<IDWriteFont1*, DWRITE_FONT_STRETCH>)(lpVtbl[5]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.GetStyle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_FONT_STYLE GetStyle()
    {
        return ((delegate* unmanaged<IDWriteFont1*, DWRITE_FONT_STYLE>)(lpVtbl[6]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.IsSymbolFont" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL IsSymbolFont()
    {
        return ((delegate* unmanaged<IDWriteFont1*, int>)(lpVtbl[7]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.GetFaceNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFaceNames(IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged<IDWriteFont1*, IDWriteLocalizedStrings**, int>)(lpVtbl[8]))((IDWriteFont1*)Unsafe.AsPointer(ref this), names);
    }

    /// <inheritdoc cref="IDWriteFont.GetInformationalStrings" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFont1*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, BOOL*, int>)(lpVtbl[9]))((IDWriteFont1*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
    }

    /// <inheritdoc cref="IDWriteFont.GetSimulations" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return ((delegate* unmanaged<IDWriteFont1*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[10]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.GetMetrics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void GetMetrics(DWRITE_FONT_METRICS* fontMetrics)
    {
        ((delegate* unmanaged<IDWriteFont1*, DWRITE_FONT_METRICS*, void>)(lpVtbl[11]))((IDWriteFont1*)Unsafe.AsPointer(ref this), fontMetrics);
    }

    /// <inheritdoc cref="IDWriteFont.HasCharacter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFont1*, uint, BOOL*, int>)(lpVtbl[12]))((IDWriteFont1*)Unsafe.AsPointer(ref this), unicodeValue, exists);
    }

    /// <inheritdoc cref="IDWriteFont.CreateFontFace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateFontFace(IDWriteFontFace** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFont1*, IDWriteFontFace**, int>)(lpVtbl[13]))((IDWriteFont1*)Unsafe.AsPointer(ref this), fontFace);
    }

    /// <include file='IDWriteFont1.xml' path='doc/member[@name="IDWriteFont1.GetMetrics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics)
    {
        ((delegate* unmanaged<IDWriteFont1*, DWRITE_FONT_METRICS1*, void>)(lpVtbl[14]))((IDWriteFont1*)Unsafe.AsPointer(ref this), fontMetrics);
    }

    /// <include file='IDWriteFont1.xml' path='doc/member[@name="IDWriteFont1.GetPanose"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void GetPanose(DWRITE_PANOSE* panose)
    {
        ((delegate* unmanaged<IDWriteFont1*, DWRITE_PANOSE*, void>)(lpVtbl[15]))((IDWriteFont1*)Unsafe.AsPointer(ref this), panose);
    }

    /// <include file='IDWriteFont1.xml' path='doc/member[@name="IDWriteFont1.GetUnicodeRanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
    {
        return ((delegate* unmanaged<IDWriteFont1*, uint, DWRITE_UNICODE_RANGE*, uint*, int>)(lpVtbl[16]))((IDWriteFont1*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
    }

    /// <include file='IDWriteFont1.xml' path='doc/member[@name="IDWriteFont1.IsMonospacedFont"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public BOOL IsMonospacedFont()
    {
        return ((delegate* unmanaged<IDWriteFont1*, int>)(lpVtbl[17]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDWriteFont.Interface
    {
        [VtblIndex(14)]
        void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics);

        [VtblIndex(15)]
        void GetPanose(DWRITE_PANOSE* panose);

        [VtblIndex(16)]
        HRESULT GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount);

        [VtblIndex(17)]
        BOOL IsMonospacedFont();
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

        [NativeTypeName("HRESULT (IDWriteFontFamily **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFamily**, int> GetFontFamily;

        [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_WEIGHT> GetWeight;

        [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STRETCH> GetStretch;

        [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_STYLE> GetStyle;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsSymbolFont;

        [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteLocalizedStrings**, int> GetFaceNames;

        [NativeTypeName("HRESULT (DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, BOOL*, int> GetInformationalStrings;

        [NativeTypeName("DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_SIMULATIONS> GetSimulations;

        [NativeTypeName("void (DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_METRICS*, void> GetMetrics;

        [NativeTypeName("HRESULT (UINT32, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> HasCharacter;

        [NativeTypeName("HRESULT (IDWriteFontFace **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFace**, int> CreateFontFace;

        [NativeTypeName("void (DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_METRICS1*, void> GetMetrics1;

        [NativeTypeName("void (DWRITE_PANOSE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_PANOSE*, void> GetPanose;

        [NativeTypeName("HRESULT (UINT32, DWRITE_UNICODE_RANGE *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_UNICODE_RANGE*, uint*, int> GetUnicodeRanges;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsMonospacedFont;
    }
}
