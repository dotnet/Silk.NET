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

[Guid("A4D055A6-F9E3-4E25-93B7-9E309F3AF8E9")]
[NativeTypeName("struct IDWriteFontCollection3 : IDWriteFontCollection2")]
[NativeInheritance("IDWriteFontCollection2")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IDWriteFontCollection3 : IDWriteFontCollection3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontCollection3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontCollection3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontCollection3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontCollection3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFamilyCount()
    {
        return ((delegate* unmanaged<IDWriteFontCollection3, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFontFamily(
        [NativeTypeName("UINT32")] uint index,
        IDWriteFontFamily* fontFamily
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontCollection3, uint, IDWriteFontFamily*, int>)(
                (*lpVtbl)[4]
            )
        )(this, index, fontFamily);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindFamilyName(
        [NativeTypeName("const WCHAR *")] ushort* familyName,
        [NativeTypeName("UINT32 *")] uint* index,
        BOOL* exists
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontCollection3, ushort*, uint*, BOOL*, int>)((*lpVtbl)[5])
        )(this, familyName, index, exists);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFontFromFontFace(IDWriteFontFace fontFace, IDWriteFont* font)
    {
        return (
            (delegate* unmanaged<IDWriteFontCollection3, IDWriteFontFace, IDWriteFont*, int>)(
                (*lpVtbl)[6]
            )
        )(this, fontFace, font);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFontSet(IDWriteFontSet* fontSet)
    {
        return ((delegate* unmanaged<IDWriteFontCollection3, IDWriteFontSet*, int>)((*lpVtbl)[7]))(
            this,
            fontSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFontFamily(
        [NativeTypeName("UINT32")] uint index,
        IDWriteFontFamily1* fontFamily
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontCollection3, uint, IDWriteFontFamily1*, int>)(
                (*lpVtbl)[8]
            )
        )(this, index, fontFamily);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFontFamily(
        [NativeTypeName("UINT32")] uint index,
        IDWriteFontFamily2* fontFamily
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontCollection3, uint, IDWriteFontFamily2*, int>)(
                (*lpVtbl)[9]
            )
        )(this, index, fontFamily);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetMatchingFonts(
        [NativeTypeName("const WCHAR *")] ushort* familyName,
        [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues,
        [NativeTypeName("UINT32")] uint fontAxisValueCount,
        IDWriteFontList2* fontList
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontCollection3,
                ushort*,
                DWRITE_FONT_AXIS_VALUE*,
                uint,
                IDWriteFontList2*,
                int>)((*lpVtbl)[10])
        )(this, familyName, fontAxisValues, fontAxisValueCount, fontList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel()
    {
        return (
            (delegate* unmanaged<IDWriteFontCollection3, DWRITE_FONT_FAMILY_MODEL>)((*lpVtbl)[11])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFontSet(IDWriteFontSet1* fontSet)
    {
        return (
            (delegate* unmanaged<IDWriteFontCollection3, IDWriteFontSet1*, int>)((*lpVtbl)[12])
        )(this, fontSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HANDLE GetExpirationEvent()
    {
        return (
            (HANDLE)(((delegate* unmanaged<IDWriteFontCollection3, void*>)((*lpVtbl)[13]))(this))
        );
    }

    public interface Interface : IDWriteFontCollection2.Interface
    {
        [VtblIndex(13)]
        HANDLE GetExpirationEvent();
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

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontFamilyCount;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontFamily **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFamily*, int> GetFontFamily;

        [NativeTypeName(
            "HRESULT (const WCHAR *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint*, BOOL*, int> FindFamilyName;

        [NativeTypeName(
            "HRESULT (IDWriteFontFace *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFace, IDWriteFont*, int> GetFontFromFontFace;

        [NativeTypeName(
            "HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontSet*, int> GetFontSet;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontFamily1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFamily1*, int> GetFontFamily1;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontFamily2 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFamily2*, int> GetFontFamily2;

        [NativeTypeName(
            "HRESULT (const WCHAR *, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontList2 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            DWRITE_FONT_AXIS_VALUE*,
            uint,
            IDWriteFontList2*,
            int> GetMatchingFonts;

        [NativeTypeName(
            "DWRITE_FONT_FAMILY_MODEL () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_FAMILY_MODEL> GetFontFamilyModel;

        [NativeTypeName(
            "HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontSet1*, int> GetFontSet1;

        [NativeTypeName("HANDLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetExpirationEvent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontCollection3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontCollection3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontCollection2"/> to <see cref = "IDWriteFontCollection3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontCollection2"/> instance to be converted </param>
    public static explicit operator IDWriteFontCollection3(
        Silk.NET.DirectX.IDWriteFontCollection2 value
    )
    {
        return new IDWriteFontCollection3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontCollection3"/> to <see cref = "Silk.NET.DirectX.IDWriteFontCollection2"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontCollection3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontCollection2(
        IDWriteFontCollection3 value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontCollection2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontCollection1"/> to <see cref = "IDWriteFontCollection3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontCollection1"/> instance to be converted </param>
    public static explicit operator IDWriteFontCollection3(
        Silk.NET.DirectX.IDWriteFontCollection1 value
    )
    {
        return new IDWriteFontCollection3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontCollection3"/> to <see cref = "Silk.NET.DirectX.IDWriteFontCollection1"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontCollection3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontCollection1(
        IDWriteFontCollection3 value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontCollection1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontCollection"/> to <see cref = "IDWriteFontCollection3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontCollection"/> instance to be converted </param>
    public static explicit operator IDWriteFontCollection3(
        Silk.NET.DirectX.IDWriteFontCollection value
    )
    {
        return new IDWriteFontCollection3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontCollection3"/> to <see cref = "Silk.NET.DirectX.IDWriteFontCollection"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontCollection3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontCollection(
        IDWriteFontCollection3 value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontCollection(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontCollection3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontCollection3(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontCollection3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontCollection3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontCollection3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontCollection3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
