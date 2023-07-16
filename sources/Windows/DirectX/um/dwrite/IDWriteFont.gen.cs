// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont"]/*'/>
[Guid("ACD16696-8C14-4F5D-877E-FE3FC1D32737")]
[NativeTypeName("struct IDWriteFont : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFont : IDWriteFont.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFont));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFont*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFont*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFont*, uint> )(lpVtbl[1]))((IDWriteFont*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFont*, uint> )(lpVtbl[2]))((IDWriteFont*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.GetFontFamily"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontFamily(IDWriteFontFamily** fontFamily)
    {
        return ((delegate* unmanaged<IDWriteFont*, IDWriteFontFamily**, int> )(lpVtbl[3]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontFamily);
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.GetWeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public DWRITE_FONT_WEIGHT GetWeight()
    {
        return ((delegate* unmanaged<IDWriteFont*, DWRITE_FONT_WEIGHT> )(lpVtbl[4]))((IDWriteFont*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.GetStretch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public DWRITE_FONT_STRETCH GetStretch()
    {
        return ((delegate* unmanaged<IDWriteFont*, DWRITE_FONT_STRETCH> )(lpVtbl[5]))((IDWriteFont*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.GetStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_FONT_STYLE GetStyle()
    {
        return ((delegate* unmanaged<IDWriteFont*, DWRITE_FONT_STYLE> )(lpVtbl[6]))((IDWriteFont*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.IsSymbolFont"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public BOOL IsSymbolFont()
    {
        return ((delegate* unmanaged<IDWriteFont*, int> )(lpVtbl[7]))((IDWriteFont*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.GetFaceNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFaceNames(IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged<IDWriteFont*, IDWriteLocalizedStrings**, int> )(lpVtbl[8]))((IDWriteFont*)Unsafe.AsPointer(ref this), names);
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.GetInformationalStrings"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFont*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, BOOL*, int> )(lpVtbl[9]))((IDWriteFont*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.GetSimulations"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return ((delegate* unmanaged<IDWriteFont*, DWRITE_FONT_SIMULATIONS> )(lpVtbl[10]))((IDWriteFont*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.GetMetrics"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void GetMetrics(DWRITE_FONT_METRICS* fontMetrics)
    {
        ((delegate* unmanaged<IDWriteFont*, DWRITE_FONT_METRICS*, void> )(lpVtbl[11]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontMetrics);
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.HasCharacter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFont*, uint, BOOL*, int> )(lpVtbl[12]))((IDWriteFont*)Unsafe.AsPointer(ref this), unicodeValue, exists);
    }

    /// <include file='IDWriteFont.xml' path='doc/member[@name="IDWriteFont.CreateFontFace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateFontFace(IDWriteFontFace** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFont*, IDWriteFontFace**, int> )(lpVtbl[13]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontFace);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFontFamily(IDWriteFontFamily** fontFamily);
        [VtblIndex(4)]
        DWRITE_FONT_WEIGHT GetWeight();
        [VtblIndex(5)]
        DWRITE_FONT_STRETCH GetStretch();
        [VtblIndex(6)]
        DWRITE_FONT_STYLE GetStyle();
        [VtblIndex(7)]
        BOOL IsSymbolFont();
        [VtblIndex(8)]
        HRESULT GetFaceNames(IDWriteLocalizedStrings** names);
        [VtblIndex(9)]
        HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists);
        [VtblIndex(10)]
        DWRITE_FONT_SIMULATIONS GetSimulations();
        [VtblIndex(11)]
        void GetMetrics(DWRITE_FONT_METRICS* fontMetrics);
        [VtblIndex(12)]
        HRESULT HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, BOOL* exists);
        [VtblIndex(13)]
        HRESULT CreateFontFace(IDWriteFontFace** fontFace);
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
    }
}