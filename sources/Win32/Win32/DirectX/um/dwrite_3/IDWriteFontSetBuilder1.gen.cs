// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("3FF7715F-3CDC-4DC6-9B72-EC5621DCCAFD")]
[NativeTypeName("struct IDWriteFontSetBuilder1 : IDWriteFontSetBuilder")]
[NativeInheritance("IDWriteFontSetBuilder")]
public unsafe partial struct IDWriteFontSetBuilder1 : IDWriteFontSetBuilder1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSetBuilder1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontSetBuilder1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddFontFaceReference(
        IDWriteFontFaceReference fontFaceReference,
        [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties,
        [NativeTypeName("UINT32")] uint propertyCount
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSetBuilder1,
                IDWriteFontFaceReference,
                DWRITE_FONT_PROPERTY*,
                uint,
                int>)((*lpVtbl)[3])
        )(this, fontFaceReference, properties, propertyCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddFontFaceReference(IDWriteFontFaceReference fontFaceReference)
    {
        return (
            (delegate* unmanaged<IDWriteFontSetBuilder1, IDWriteFontFaceReference, int>)(
                (*lpVtbl)[4]
            )
        )(this, fontFaceReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddFontSet(IDWriteFontSet fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder1, IDWriteFontSet, int>)((*lpVtbl)[5]))(
            this,
            fontSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFontSet(IDWriteFontSet* fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder1, IDWriteFontSet*, int>)((*lpVtbl)[6]))(
            this,
            fontSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddFontFile(IDWriteFontFile fontFile)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder1, IDWriteFontFile, int>)((*lpVtbl)[7]))(
            this,
            fontFile
        );
    }

    public interface Interface : IDWriteFontSetBuilder.Interface
    {
        [VtblIndex(7)]
        HRESULT AddFontFile(IDWriteFontFile fontFile);
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
            "HRESULT (IDWriteFontFaceReference *, const DWRITE_FONT_PROPERTY *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontFaceReference,
            DWRITE_FONT_PROPERTY*,
            uint,
            int> AddFontFaceReference;

        [NativeTypeName(
            "HRESULT (IDWriteFontFaceReference *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFaceReference, int> AddFontFaceReference1;

        [NativeTypeName(
            "HRESULT (IDWriteFontSet *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontSet, int> AddFontSet;

        [NativeTypeName(
            "HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontSet*, int> CreateFontSet;

        [NativeTypeName(
            "HRESULT (IDWriteFontFile *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFile, int> AddFontFile;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontSetBuilder1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontSetBuilder1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontSetBuilder"/> to <see cref = "IDWriteFontSetBuilder1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontSetBuilder"/> instance to be converted </param>
    public static explicit operator IDWriteFontSetBuilder1(
        Silk.NET.DirectX.IDWriteFontSetBuilder value
    )
    {
        return new IDWriteFontSetBuilder1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSetBuilder1"/> to <see cref = "Silk.NET.DirectX.IDWriteFontSetBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSetBuilder1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontSetBuilder(
        IDWriteFontSetBuilder1 value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontSetBuilder(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontSetBuilder1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontSetBuilder1(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontSetBuilder1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSetBuilder1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSetBuilder1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontSetBuilder1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
