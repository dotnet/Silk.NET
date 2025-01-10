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

[Guid("7C5F86DA-C7A1-4F05-B8E1-55A179FE5A35")]
[NativeTypeName("struct IDWriteColorGlyphRunEnumerator1 : IDWriteColorGlyphRunEnumerator")]
[NativeInheritance("IDWriteColorGlyphRunEnumerator")]
public unsafe partial struct IDWriteColorGlyphRunEnumerator1
    : IDWriteColorGlyphRunEnumerator1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteColorGlyphRunEnumerator1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDWriteColorGlyphRunEnumerator1, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT MoveNext(BOOL* hasRun)
    {
        return ((delegate* unmanaged<IDWriteColorGlyphRunEnumerator1, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            hasRun
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentRun(
        [NativeTypeName("const DWRITE_COLOR_GLYPH_RUN **")] DWRITE_COLOR_GLYPH_RUN** colorGlyphRun
    )
    {
        return (
            (delegate* unmanaged<IDWriteColorGlyphRunEnumerator1, DWRITE_COLOR_GLYPH_RUN**, int>)(
                (*lpVtbl)[4]
            )
        )(this, colorGlyphRun);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentRun(
        [NativeTypeName("const DWRITE_COLOR_GLYPH_RUN1 **")] DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun
    )
    {
        return (
            (delegate* unmanaged<IDWriteColorGlyphRunEnumerator1, DWRITE_COLOR_GLYPH_RUN1**, int>)(
                (*lpVtbl)[5]
            )
        )(this, colorGlyphRun);
    }

    public interface Interface : IDWriteColorGlyphRunEnumerator.Interface
    {
        [VtblIndex(5)]
        HRESULT GetCurrentRun(
            [NativeTypeName("const DWRITE_COLOR_GLYPH_RUN1 **")]
                DWRITE_COLOR_GLYPH_RUN1** colorGlyphRun
        );
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;

        [NativeTypeName(
            "HRESULT (const DWRITE_COLOR_GLYPH_RUN **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_COLOR_GLYPH_RUN**, int> GetCurrentRun;

        [NativeTypeName(
            "HRESULT (const DWRITE_COLOR_GLYPH_RUN1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_COLOR_GLYPH_RUN1**, int> GetCurrentRun1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteColorGlyphRunEnumerator1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteColorGlyphRunEnumerator1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteColorGlyphRunEnumerator"/> to <see cref = "IDWriteColorGlyphRunEnumerator1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteColorGlyphRunEnumerator"/> instance to be converted </param>
    public static explicit operator IDWriteColorGlyphRunEnumerator1(
        Silk.NET.DirectX.IDWriteColorGlyphRunEnumerator value
    )
    {
        return new IDWriteColorGlyphRunEnumerator1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteColorGlyphRunEnumerator1"/> to <see cref = "Silk.NET.DirectX.IDWriteColorGlyphRunEnumerator"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteColorGlyphRunEnumerator1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteColorGlyphRunEnumerator(
        IDWriteColorGlyphRunEnumerator1 value
    )
    {
        return new Silk.NET.DirectX.IDWriteColorGlyphRunEnumerator(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteColorGlyphRunEnumerator1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteColorGlyphRunEnumerator1(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteColorGlyphRunEnumerator1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteColorGlyphRunEnumerator1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteColorGlyphRunEnumerator1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteColorGlyphRunEnumerator1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
