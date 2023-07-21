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

/// <include file='IDWriteFont3.xml' path='doc/member[@name="IDWriteFont3"]/*' />
[Guid("29748ED6-8C9C-4A6A-BE0B-D912E8538944")]
[NativeTypeName("struct IDWriteFont3 : IDWriteFont2")]
[NativeInheritance("IDWriteFont2")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDWriteFont3 : IDWriteFont3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFont3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFont3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFont3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFont3*, uint>)(lpVtbl[1]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFont3*, uint>)(lpVtbl[2]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.GetFontFamily" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontFamily(IDWriteFontFamily** fontFamily)
    {
        return ((delegate* unmanaged<IDWriteFont3*, IDWriteFontFamily**, int>)(lpVtbl[3]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFamily);
    }

    /// <inheritdoc cref="IDWriteFont.GetWeight" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public DWRITE_FONT_WEIGHT GetWeight()
    {
        return ((delegate* unmanaged<IDWriteFont3*, DWRITE_FONT_WEIGHT>)(lpVtbl[4]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.GetStretch" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public DWRITE_FONT_STRETCH GetStretch()
    {
        return ((delegate* unmanaged<IDWriteFont3*, DWRITE_FONT_STRETCH>)(lpVtbl[5]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.GetStyle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_FONT_STYLE GetStyle()
    {
        return ((delegate* unmanaged<IDWriteFont3*, DWRITE_FONT_STYLE>)(lpVtbl[6]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.IsSymbolFont" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL IsSymbolFont()
    {
        return ((delegate* unmanaged<IDWriteFont3*, int>)(lpVtbl[7]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.GetFaceNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFaceNames(IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged<IDWriteFont3*, IDWriteLocalizedStrings**, int>)(lpVtbl[8]))((IDWriteFont3*)Unsafe.AsPointer(ref this), names);
    }

    /// <inheritdoc cref="IDWriteFont.GetInformationalStrings" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFont3*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, BOOL*, int>)(lpVtbl[9]))((IDWriteFont3*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
    }

    /// <inheritdoc cref="IDWriteFont.GetSimulations" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return ((delegate* unmanaged<IDWriteFont3*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[10]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont.GetMetrics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void GetMetrics(DWRITE_FONT_METRICS* fontMetrics)
    {
        ((delegate* unmanaged<IDWriteFont3*, DWRITE_FONT_METRICS*, void>)(lpVtbl[11]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontMetrics);
    }

    /// <inheritdoc cref="IDWriteFont.HasCharacter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFont3*, uint, BOOL*, int>)(lpVtbl[12]))((IDWriteFont3*)Unsafe.AsPointer(ref this), unicodeValue, exists);
    }

    /// <inheritdoc cref="IDWriteFont.CreateFontFace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateFontFace(IDWriteFontFace** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFont3*, IDWriteFontFace**, int>)(lpVtbl[13]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFace);
    }

    /// <inheritdoc cref="IDWriteFont1.GetMetrics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void GetMetrics(DWRITE_FONT_METRICS1* fontMetrics)
    {
        ((delegate* unmanaged<IDWriteFont3*, DWRITE_FONT_METRICS1*, void>)(lpVtbl[14]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontMetrics);
    }

    /// <inheritdoc cref="IDWriteFont1.GetPanose" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void GetPanose(DWRITE_PANOSE* panose)
    {
        ((delegate* unmanaged<IDWriteFont3*, DWRITE_PANOSE*, void>)(lpVtbl[15]))((IDWriteFont3*)Unsafe.AsPointer(ref this), panose);
    }

    /// <inheritdoc cref="IDWriteFont1.GetUnicodeRanges" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
    {
        return ((delegate* unmanaged<IDWriteFont3*, uint, DWRITE_UNICODE_RANGE*, uint*, int>)(lpVtbl[16]))((IDWriteFont3*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
    }

    /// <inheritdoc cref="IDWriteFont1.IsMonospacedFont" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public BOOL IsMonospacedFont()
    {
        return ((delegate* unmanaged<IDWriteFont3*, int>)(lpVtbl[17]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteFont2.IsColorFont" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public BOOL IsColorFont()
    {
        return ((delegate* unmanaged<IDWriteFont3*, int>)(lpVtbl[18]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFont3.xml' path='doc/member[@name="IDWriteFont3.CreateFontFace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateFontFace(IDWriteFontFace3** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFont3*, IDWriteFontFace3**, int>)(lpVtbl[19]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFace);
    }

    /// <include file='IDWriteFont3.xml' path='doc/member[@name="IDWriteFont3.Equals"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public BOOL Equals(IDWriteFont* font)
    {
        return ((delegate* unmanaged<IDWriteFont3*, IDWriteFont*, int>)(lpVtbl[20]))((IDWriteFont3*)Unsafe.AsPointer(ref this), font);
    }

    /// <include file='IDWriteFont3.xml' path='doc/member[@name="IDWriteFont3.GetFontFaceReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFontFaceReference(IDWriteFontFaceReference** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFont3*, IDWriteFontFaceReference**, int>)(lpVtbl[21]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFaceReference);
    }

    /// <include file='IDWriteFont3.xml' path='doc/member[@name="IDWriteFont3.HasCharacter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL HasCharacter([NativeTypeName("UINT32")] uint unicodeValue)
    {
        return ((delegate* unmanaged<IDWriteFont3*, uint, int>)(lpVtbl[22]))((IDWriteFont3*)Unsafe.AsPointer(ref this), unicodeValue);
    }

    /// <include file='IDWriteFont3.xml' path='doc/member[@name="IDWriteFont3.GetLocality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public DWRITE_LOCALITY GetLocality()
    {
        return ((delegate* unmanaged<IDWriteFont3*, DWRITE_LOCALITY>)(lpVtbl[23]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDWriteFont2.Interface
    {
        [VtblIndex(19)]
        HRESULT CreateFontFace(IDWriteFontFace3** fontFace);

        [VtblIndex(20)]
        BOOL Equals(IDWriteFont* font);

        [VtblIndex(21)]
        HRESULT GetFontFaceReference(IDWriteFontFaceReference** fontFaceReference);

        [VtblIndex(22)]
        BOOL HasCharacter([NativeTypeName("UINT32")] uint unicodeValue);

        [VtblIndex(23)]
        DWRITE_LOCALITY GetLocality();
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

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsColorFont;

        [NativeTypeName("HRESULT (IDWriteFontFace3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFace3**, int> CreateFontFace1;

        [NativeTypeName("BOOL (IDWriteFont *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, IDWriteFont*, int> Equals;

        [NativeTypeName("HRESULT (IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFaceReference**, int> GetFontFaceReference;

        [NativeTypeName("BOOL (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> HasCharacter1;

        [NativeTypeName("DWRITE_LOCALITY () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LOCALITY> GetLocality;
    }
}
