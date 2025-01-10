// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("3ED49E77-A398-4261-B9CF-C126C2131EF3")]
[NativeTypeName("struct IDWriteFontFamily2 : IDWriteFontFamily1")]
[NativeInheritance("IDWriteFontFamily1")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IDWriteFontFamily2 : IDWriteFontFamily2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFamily2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFamily2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontFamily2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFamily2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontCollection(IDWriteFontCollection* fontCollection)
    {
        return (
            (delegate* unmanaged<IDWriteFontFamily2, IDWriteFontCollection*, int>)((*lpVtbl)[3])
        )(this, fontCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged<IDWriteFontFamily2, uint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont* font)
    {
        return ((delegate* unmanaged<IDWriteFontFamily2, uint, IDWriteFont*, int>)((*lpVtbl)[5]))(
            this,
            index,
            font
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFamilyNames(IDWriteLocalizedStrings* names)
    {
        return (
            (delegate* unmanaged<IDWriteFontFamily2, IDWriteLocalizedStrings*, int>)((*lpVtbl)[6])
        )(this, names);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFirstMatchingFont(
        DWRITE_FONT_WEIGHT weight,
        DWRITE_FONT_STRETCH stretch,
        DWRITE_FONT_STYLE style,
        IDWriteFont* matchingFont
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFamily2,
                DWRITE_FONT_WEIGHT,
                DWRITE_FONT_STRETCH,
                DWRITE_FONT_STYLE,
                IDWriteFont*,
                int>)((*lpVtbl)[7])
        )(this, weight, stretch, style, matchingFont);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMatchingFonts(
        DWRITE_FONT_WEIGHT weight,
        DWRITE_FONT_STRETCH stretch,
        DWRITE_FONT_STYLE style,
        IDWriteFontList* matchingFonts
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFamily2,
                DWRITE_FONT_WEIGHT,
                DWRITE_FONT_STRETCH,
                DWRITE_FONT_STYLE,
                IDWriteFontList*,
                int>)((*lpVtbl)[8])
        )(this, weight, stretch, style, matchingFonts);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
    {
        return ((delegate* unmanaged<IDWriteFontFamily2, uint, DWRITE_LOCALITY>)((*lpVtbl)[9]))(
            this,
            listIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint listIndex, IDWriteFont3* font)
    {
        return ((delegate* unmanaged<IDWriteFontFamily2, uint, IDWriteFont3*, int>)((*lpVtbl)[10]))(
            this,
            listIndex,
            font
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFontFaceReference(
        [NativeTypeName("UINT32")] uint listIndex,
        IDWriteFontFaceReference* fontFaceReference
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFamily2, uint, IDWriteFontFaceReference*, int>)(
                (*lpVtbl)[11]
            )
        )(this, listIndex, fontFaceReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMatchingFonts(
        [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues,
        [NativeTypeName("UINT32")] uint fontAxisValueCount,
        IDWriteFontList2* matchingFonts
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFamily2,
                DWRITE_FONT_AXIS_VALUE*,
                uint,
                IDWriteFontList2*,
                int>)((*lpVtbl)[12])
        )(this, fontAxisValues, fontAxisValueCount, matchingFonts);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFontSet(IDWriteFontSet1* fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontFamily2, IDWriteFontSet1*, int>)((*lpVtbl)[13]))(
            this,
            fontSet
        );
    }

    public interface Interface : IDWriteFontFamily1.Interface
    {
        [VtblIndex(12)]
        HRESULT GetMatchingFonts(
            [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")]
                DWRITE_FONT_AXIS_VALUE* fontAxisValues,
            [NativeTypeName("UINT32")] uint fontAxisValueCount,
            IDWriteFontList2* matchingFonts
        );

        [VtblIndex(13)]
        HRESULT GetFontSet(IDWriteFontSet1* fontSet);
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
            "HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontCollection*, int> GetFontCollection;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontCount;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDWriteFont*, int> GetFont;

        [NativeTypeName(
            "HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteLocalizedStrings*, int> GetFamilyNames;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_WEIGHT,
            DWRITE_FONT_STRETCH,
            DWRITE_FONT_STYLE,
            IDWriteFont*,
            int> GetFirstMatchingFont;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontList **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_WEIGHT,
            DWRITE_FONT_STRETCH,
            DWRITE_FONT_STYLE,
            IDWriteFontList*,
            int> GetMatchingFonts;

        [NativeTypeName(
            "DWRITE_LOCALITY (UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, DWRITE_LOCALITY> GetFontLocality;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFont3 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDWriteFont3*, int> GetFont1;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDWriteFontFaceReference*,
            int> GetFontFaceReference;

        [NativeTypeName(
            "HRESULT (const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontList2 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_AXIS_VALUE*,
            uint,
            IDWriteFontList2*,
            int> GetMatchingFonts1;

        [NativeTypeName(
            "HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontSet1*, int> GetFontSet;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontFamily2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontFamily2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFamily1"/> to <see cref = "IDWriteFontFamily2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFamily1"/> instance to be converted </param>
    public static explicit operator IDWriteFontFamily2(Silk.NET.DirectX.IDWriteFontFamily1 value)
    {
        return new IDWriteFontFamily2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFamily2"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFamily1"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFamily2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFamily1(IDWriteFontFamily2 value)
    {
        return new Silk.NET.DirectX.IDWriteFontFamily1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFamily"/> to <see cref = "IDWriteFontFamily2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFamily"/> instance to be converted </param>
    public static explicit operator IDWriteFontFamily2(Silk.NET.DirectX.IDWriteFontFamily value)
    {
        return new IDWriteFontFamily2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFamily2"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFamily"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFamily2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFamily(IDWriteFontFamily2 value)
    {
        return new Silk.NET.DirectX.IDWriteFontFamily(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontList"/> to <see cref = "IDWriteFontFamily2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontList"/> instance to be converted </param>
    public static explicit operator IDWriteFontFamily2(Silk.NET.DirectX.IDWriteFontList value)
    {
        return new IDWriteFontFamily2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFamily2"/> to <see cref = "Silk.NET.DirectX.IDWriteFontList"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFamily2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontList(IDWriteFontFamily2 value)
    {
        return new Silk.NET.DirectX.IDWriteFontList(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontFamily2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontFamily2(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontFamily2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFamily2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFamily2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontFamily2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
