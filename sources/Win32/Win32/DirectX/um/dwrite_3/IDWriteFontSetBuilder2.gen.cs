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

[Guid("EE5BA612-B131-463C-8F4F-3189B9401E45")]
[NativeTypeName("struct IDWriteFontSetBuilder2 : IDWriteFontSetBuilder1")]
[NativeInheritance("IDWriteFontSetBuilder1")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IDWriteFontSetBuilder2 : IDWriteFontSetBuilder2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSetBuilder2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontSetBuilder2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder2, uint>)((*lpVtbl)[2]))(this);
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
                IDWriteFontSetBuilder2,
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
            (delegate* unmanaged<IDWriteFontSetBuilder2, IDWriteFontFaceReference, int>)(
                (*lpVtbl)[4]
            )
        )(this, fontFaceReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddFontSet(IDWriteFontSet fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder2, IDWriteFontSet, int>)((*lpVtbl)[5]))(
            this,
            fontSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFontSet(IDWriteFontSet* fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder2, IDWriteFontSet*, int>)((*lpVtbl)[6]))(
            this,
            fontSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddFontFile(IDWriteFontFile fontFile)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder2, IDWriteFontFile, int>)((*lpVtbl)[7]))(
            this,
            fontFile
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddFont(
        IDWriteFontFile fontFile,
        [NativeTypeName("UINT32")] uint fontFaceIndex,
        DWRITE_FONT_SIMULATIONS fontSimulations,
        [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues,
        [NativeTypeName("UINT32")] uint fontAxisValueCount,
        [NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges,
        [NativeTypeName("UINT32")] uint fontAxisRangeCount,
        [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties,
        [NativeTypeName("UINT32")] uint propertyCount
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSetBuilder2,
                IDWriteFontFile,
                uint,
                DWRITE_FONT_SIMULATIONS,
                DWRITE_FONT_AXIS_VALUE*,
                uint,
                DWRITE_FONT_AXIS_RANGE*,
                uint,
                DWRITE_FONT_PROPERTY*,
                uint,
                int>)((*lpVtbl)[8])
        )(
            this,
            fontFile,
            fontFaceIndex,
            fontSimulations,
            fontAxisValues,
            fontAxisValueCount,
            fontAxisRanges,
            fontAxisRangeCount,
            properties,
            propertyCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddFontFile([NativeTypeName("const WCHAR *")] ushort* filePath)
    {
        return ((delegate* unmanaged<IDWriteFontSetBuilder2, ushort*, int>)((*lpVtbl)[9]))(
            this,
            filePath
        );
    }

    public interface Interface : IDWriteFontSetBuilder1.Interface
    {
        [VtblIndex(8)]
        HRESULT AddFont(
            IDWriteFontFile fontFile,
            [NativeTypeName("UINT32")] uint fontFaceIndex,
            DWRITE_FONT_SIMULATIONS fontSimulations,
            [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")]
                DWRITE_FONT_AXIS_VALUE* fontAxisValues,
            [NativeTypeName("UINT32")] uint fontAxisValueCount,
            [NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")]
                DWRITE_FONT_AXIS_RANGE* fontAxisRanges,
            [NativeTypeName("UINT32")] uint fontAxisRangeCount,
            [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties,
            [NativeTypeName("UINT32")] uint propertyCount
        );

        [VtblIndex(9)]
        HRESULT AddFontFile([NativeTypeName("const WCHAR *")] ushort* filePath);
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

        [NativeTypeName(
            "HRESULT (IDWriteFontFile *, UINT32, DWRITE_FONT_SIMULATIONS, const DWRITE_FONT_AXIS_VALUE *, UINT32, const DWRITE_FONT_AXIS_RANGE *, UINT32, const DWRITE_FONT_PROPERTY *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontFile,
            uint,
            DWRITE_FONT_SIMULATIONS,
            DWRITE_FONT_AXIS_VALUE*,
            uint,
            DWRITE_FONT_AXIS_RANGE*,
            uint,
            DWRITE_FONT_PROPERTY*,
            uint,
            int> AddFont;

        [NativeTypeName(
            "HRESULT (const WCHAR *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, int> AddFontFile1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontSetBuilder2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontSetBuilder2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontSetBuilder1"/> to <see cref = "IDWriteFontSetBuilder2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontSetBuilder1"/> instance to be converted </param>
    public static explicit operator IDWriteFontSetBuilder2(
        Silk.NET.DirectX.IDWriteFontSetBuilder1 value
    )
    {
        return new IDWriteFontSetBuilder2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSetBuilder2"/> to <see cref = "Silk.NET.DirectX.IDWriteFontSetBuilder1"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSetBuilder2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontSetBuilder1(
        IDWriteFontSetBuilder2 value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontSetBuilder1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontSetBuilder"/> to <see cref = "IDWriteFontSetBuilder2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontSetBuilder"/> instance to be converted </param>
    public static explicit operator IDWriteFontSetBuilder2(
        Silk.NET.DirectX.IDWriteFontSetBuilder value
    )
    {
        return new IDWriteFontSetBuilder2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSetBuilder2"/> to <see cref = "Silk.NET.DirectX.IDWriteFontSetBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSetBuilder2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontSetBuilder(
        IDWriteFontSetBuilder2 value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontSetBuilder(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontSetBuilder2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontSetBuilder2(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontSetBuilder2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSetBuilder2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSetBuilder2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontSetBuilder2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
