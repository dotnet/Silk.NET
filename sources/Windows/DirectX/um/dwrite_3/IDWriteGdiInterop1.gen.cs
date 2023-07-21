// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDWriteGdiInterop1.xml' path='doc/member[@name="IDWriteGdiInterop1"]/*' />
[Guid("4556BE70-3ABD-4F70-90BE-421780A6F515")]
[NativeTypeName("struct IDWriteGdiInterop1 : IDWriteGdiInterop")]
[NativeInheritance("IDWriteGdiInterop")]
public unsafe partial struct IDWriteGdiInterop1 : IDWriteGdiInterop1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteGdiInterop1));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, uint>)(lpVtbl[1]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, uint>)(lpVtbl[2]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteGdiInterop.CreateFontFromLOGFONT" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, IDWriteFont** font)
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, LOGFONTW*, IDWriteFont**, int>)(lpVtbl[3]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, font);
    }

    /// <inheritdoc cref="IDWriteGdiInterop.ConvertFontToLOGFONT" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ConvertFontToLOGFONT(IDWriteFont* font, LOGFONTW* logFont, BOOL* isSystemFont)
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFont*, LOGFONTW*, BOOL*, int>)(lpVtbl[4]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont, isSystemFont);
    }

    /// <inheritdoc cref="IDWriteGdiInterop.ConvertFontFaceToLOGFONT" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ConvertFontFaceToLOGFONT(IDWriteFontFace* font, LOGFONTW* logFont)
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFontFace*, LOGFONTW*, int>)(lpVtbl[5]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont);
    }

    /// <inheritdoc cref="IDWriteGdiInterop.CreateFontFaceFromHdc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFontFaceFromHdc(HDC hdc, IDWriteFontFace** fontFace)
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, HDC, IDWriteFontFace**, int>)(lpVtbl[6]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, fontFace);
    }

    /// <inheritdoc cref="IDWriteGdiInterop.CreateBitmapRenderTarget" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateBitmapRenderTarget(HDC hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, IDWriteBitmapRenderTarget** renderTarget)
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, HDC, uint, uint, IDWriteBitmapRenderTarget**, int>)(lpVtbl[7]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, width, height, renderTarget);
    }

    /// <include file='IDWriteGdiInterop1.xml' path='doc/member[@name="IDWriteGdiInterop1.CreateFontFromLOGFONT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, IDWriteFontCollection* fontCollection, IDWriteFont** font)
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, LOGFONTW*, IDWriteFontCollection*, IDWriteFont**, int>)(lpVtbl[8]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontCollection, font);
    }

    /// <include file='IDWriteGdiInterop1.xml' path='doc/member[@name="IDWriteGdiInterop1.GetFontSignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFontSignature(IDWriteFontFace* fontFace, FONTSIGNATURE* fontSignature)
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFontFace*, FONTSIGNATURE*, int>)(lpVtbl[9]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), fontFace, fontSignature);
    }

    /// <include file='IDWriteGdiInterop1.xml' path='doc/member[@name="IDWriteGdiInterop1.GetFontSignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFontSignature(IDWriteFont* font, FONTSIGNATURE* fontSignature)
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFont*, FONTSIGNATURE*, int>)(lpVtbl[10]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, fontSignature);
    }

    /// <include file='IDWriteGdiInterop1.xml' path='doc/member[@name="IDWriteGdiInterop1.GetMatchingFontsByLOGFONT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMatchingFontsByLOGFONT([NativeTypeName("const LOGFONT *")] LOGFONTW* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet)
    {
        return ((delegate* unmanaged<IDWriteGdiInterop1*, LOGFONTW*, IDWriteFontSet*, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontSet, filteredSet);
    }

    public interface Interface : IDWriteGdiInterop.Interface
    {
        [VtblIndex(8)]
        HRESULT CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, IDWriteFontCollection* fontCollection, IDWriteFont** font);

        [VtblIndex(9)]
        HRESULT GetFontSignature(IDWriteFontFace* fontFace, FONTSIGNATURE* fontSignature);

        [VtblIndex(10)]
        HRESULT GetFontSignature(IDWriteFont* font, FONTSIGNATURE* fontSignature);

        [VtblIndex(11)]
        HRESULT GetMatchingFontsByLOGFONT([NativeTypeName("const LOGFONT *")] LOGFONTW* logFont, IDWriteFontSet* fontSet, IDWriteFontSet** filteredSet);
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

        [NativeTypeName("HRESULT (const LOGFONTW *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LOGFONTW*, IDWriteFont**, int> CreateFontFromLOGFONT;

        [NativeTypeName("HRESULT (IDWriteFont *, LOGFONTW *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFont*, LOGFONTW*, BOOL*, int> ConvertFontToLOGFONT;

        [NativeTypeName("HRESULT (IDWriteFontFace *, LOGFONTW *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFace*, LOGFONTW*, int> ConvertFontFaceToLOGFONT;

        [NativeTypeName("HRESULT (HDC, IDWriteFontFace **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, IDWriteFontFace**, int> CreateFontFaceFromHdc;

        [NativeTypeName("HRESULT (HDC, UINT32, UINT32, IDWriteBitmapRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, uint, uint, IDWriteBitmapRenderTarget**, int> CreateBitmapRenderTarget;

        [NativeTypeName("HRESULT (const LOGFONTW *, IDWriteFontCollection *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LOGFONTW*, IDWriteFontCollection*, IDWriteFont**, int> CreateFontFromLOGFONT1;

        [NativeTypeName("HRESULT (IDWriteFontFace *, FONTSIGNATURE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFace*, FONTSIGNATURE*, int> GetFontSignature;

        [NativeTypeName("HRESULT (IDWriteFont *, FONTSIGNATURE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFont*, FONTSIGNATURE*, int> GetFontSignature1;

        [NativeTypeName("HRESULT (const LOGFONT *, IDWriteFontSet *, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LOGFONTW*, IDWriteFontSet*, IDWriteFontSet**, int> GetMatchingFontsByLOGFONT;
    }
}
