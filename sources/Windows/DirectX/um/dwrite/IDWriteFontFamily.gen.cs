// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteFontFamily.xml' path='doc/member[@name="IDWriteFontFamily"]/*'/>
[Guid("DA20D8EF-812A-4C43-9802-62EC4ABD7ADD")]
[NativeTypeName("struct IDWriteFontFamily : IDWriteFontList")]
[NativeInheritance("IDWriteFontList")]
public unsafe partial struct IDWriteFontFamily : IDWriteFontFamily.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFamily));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFamily*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontFamily*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontFamily*, uint> )(lpVtbl[1]))((IDWriteFontFamily*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFamily*, uint> )(lpVtbl[2]))((IDWriteFontFamily*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontList.GetFontCollection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontCollection(IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteFontFamily*, IDWriteFontCollection**, int> )(lpVtbl[3]))((IDWriteFontFamily*)Unsafe.AsPointer(ref this), fontCollection);
    }

    /// <inheritdoc cref = "IDWriteFontList.GetFontCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged<IDWriteFontFamily*, uint> )(lpVtbl[4]))((IDWriteFontFamily*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontList.GetFont"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont** font)
    {
        return ((delegate* unmanaged<IDWriteFontFamily*, uint, IDWriteFont**, int> )(lpVtbl[5]))((IDWriteFontFamily*)Unsafe.AsPointer(ref this), index, font);
    }

    /// <include file='IDWriteFontFamily.xml' path='doc/member[@name="IDWriteFontFamily.GetFamilyNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFamilyNames(IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged<IDWriteFontFamily*, IDWriteLocalizedStrings**, int> )(lpVtbl[6]))((IDWriteFontFamily*)Unsafe.AsPointer(ref this), names);
    }

    /// <include file='IDWriteFontFamily.xml' path='doc/member[@name="IDWriteFontFamily.GetFirstMatchingFont"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFirstMatchingFont(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFont** matchingFont)
    {
        return ((delegate* unmanaged<IDWriteFontFamily*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFont**, int> )(lpVtbl[7]))((IDWriteFontFamily*)Unsafe.AsPointer(ref this), weight, stretch, style, matchingFont);
    }

    /// <include file='IDWriteFontFamily.xml' path='doc/member[@name="IDWriteFontFamily.GetMatchingFonts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMatchingFonts(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFontList** matchingFonts)
    {
        return ((delegate* unmanaged<IDWriteFontFamily*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontList**, int> )(lpVtbl[8]))((IDWriteFontFamily*)Unsafe.AsPointer(ref this), weight, stretch, style, matchingFonts);
    }

    public interface Interface : IDWriteFontList.Interface
    {
        [VtblIndex(6)]
        HRESULT GetFamilyNames(IDWriteLocalizedStrings** names);
        [VtblIndex(7)]
        HRESULT GetFirstMatchingFont(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFont** matchingFont);
        [VtblIndex(8)]
        HRESULT GetMatchingFonts(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, IDWriteFontList** matchingFonts);
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
        [NativeTypeName("HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection**, int> GetFontCollection;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontCount;
        [NativeTypeName("HRESULT (UINT32, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFont**, int> GetFont;
        [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteLocalizedStrings**, int> GetFamilyNames;
        [NativeTypeName("HRESULT (DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFont**, int> GetFirstMatchingFont;
        [NativeTypeName("HRESULT (DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontList **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontList**, int> GetMatchingFonts;
    }
}