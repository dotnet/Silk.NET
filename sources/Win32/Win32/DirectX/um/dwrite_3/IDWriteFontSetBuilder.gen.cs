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

[Guid("2F642AFE-9C68-4F40-B8BE-457401AFCB3D")]
[NativeTypeName("struct IDWriteFontSetBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontSetBuilder : IDWriteFontSetBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSetBuilder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontSetBuilder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder, uint>)((*lpVtbl)[2]))(this);
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
                IDWriteFontSetBuilder,
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
            (delegate* unmanaged<IDWriteFontSetBuilder, IDWriteFontFaceReference, int>)(
                (*lpVtbl)[4]
            )
        )(this, fontFaceReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddFontSet(IDWriteFontSet fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder, IDWriteFontSet, int>)((*lpVtbl)[5]))(
            this,
            fontSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFontSet(IDWriteFontSet* fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder, IDWriteFontSet*, int>)((*lpVtbl)[6]))(
            this,
            fontSet
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddFontFaceReference(
            IDWriteFontFaceReference fontFaceReference,
            [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties,
            [NativeTypeName("UINT32")] uint propertyCount
        );

        [VtblIndex(4)]
        HRESULT AddFontFaceReference(IDWriteFontFaceReference fontFaceReference);

        [VtblIndex(5)]
        HRESULT AddFontSet(IDWriteFontSet fontSet);

        [VtblIndex(6)]
        HRESULT CreateFontSet(IDWriteFontSet* fontSet);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontSetBuilder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontSetBuilder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontSetBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontSetBuilder(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontSetBuilder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSetBuilder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSetBuilder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontSetBuilder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
