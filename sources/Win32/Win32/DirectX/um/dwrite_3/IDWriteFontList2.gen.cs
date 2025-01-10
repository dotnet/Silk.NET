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

[Guid("C0763A34-77AF-445A-B735-08C37B0A5BF5")]
[NativeTypeName("struct IDWriteFontList2 : IDWriteFontList1")]
[NativeInheritance("IDWriteFontList1")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IDWriteFontList2 : IDWriteFontList2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontList2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontList2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontList2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontList2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontCollection(IDWriteFontCollection* fontCollection)
    {
        return ((delegate* unmanaged<IDWriteFontList2, IDWriteFontCollection*, int>)((*lpVtbl)[3]))(
            this,
            fontCollection
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged<IDWriteFontList2, uint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint index, IDWriteFont* font)
    {
        return ((delegate* unmanaged<IDWriteFontList2, uint, IDWriteFont*, int>)((*lpVtbl)[5]))(
            this,
            index,
            font
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
    {
        return ((delegate* unmanaged<IDWriteFontList2, uint, DWRITE_LOCALITY>)((*lpVtbl)[6]))(
            this,
            listIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFont([NativeTypeName("UINT32")] uint listIndex, IDWriteFont3* font)
    {
        return ((delegate* unmanaged<IDWriteFontList2, uint, IDWriteFont3*, int>)((*lpVtbl)[7]))(
            this,
            listIndex,
            font
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFontFaceReference(
        [NativeTypeName("UINT32")] uint listIndex,
        IDWriteFontFaceReference* fontFaceReference
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontList2, uint, IDWriteFontFaceReference*, int>)(
                (*lpVtbl)[8]
            )
        )(this, listIndex, fontFaceReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFontSet(IDWriteFontSet1* fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontList2, IDWriteFontSet1*, int>)((*lpVtbl)[9]))(
            this,
            fontSet
        );
    }

    public interface Interface : IDWriteFontList1.Interface
    {
        [VtblIndex(9)]
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
            "HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontSet1*, int> GetFontSet;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontList2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontList2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontList1"/> to <see cref = "IDWriteFontList2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontList1"/> instance to be converted </param>
    public static explicit operator IDWriteFontList2(Silk.NET.DirectX.IDWriteFontList1 value)
    {
        return new IDWriteFontList2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontList2"/> to <see cref = "Silk.NET.DirectX.IDWriteFontList1"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontList2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontList1(IDWriteFontList2 value)
    {
        return new Silk.NET.DirectX.IDWriteFontList1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontList"/> to <see cref = "IDWriteFontList2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontList"/> instance to be converted </param>
    public static explicit operator IDWriteFontList2(Silk.NET.DirectX.IDWriteFontList value)
    {
        return new IDWriteFontList2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontList2"/> to <see cref = "Silk.NET.DirectX.IDWriteFontList"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontList2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontList(IDWriteFontList2 value)
    {
        return new Silk.NET.DirectX.IDWriteFontList(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontList2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontList2(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontList2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontList2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontList2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontList2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
