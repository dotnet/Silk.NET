// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("55F1112B-1DC2-4B3C-9541-F46894ED85B6")]
[NativeTypeName("struct IDWriteTypography : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteTypography : IDWriteTypography.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTypography));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTypography, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteTypography, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTypography, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddFontFeature(DWRITE_FONT_FEATURE fontFeature)
    {
        return ((delegate* unmanaged<IDWriteTypography, DWRITE_FONT_FEATURE, int>)((*lpVtbl)[3]))(
            this,
            fontFeature
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFeatureCount()
    {
        return ((delegate* unmanaged<IDWriteTypography, uint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFontFeature(
        [NativeTypeName("UINT32")] uint fontFeatureIndex,
        DWRITE_FONT_FEATURE* fontFeature
    )
    {
        return (
            (delegate* unmanaged<IDWriteTypography, uint, DWRITE_FONT_FEATURE*, int>)((*lpVtbl)[5])
        )(this, fontFeatureIndex, fontFeature);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddFontFeature(DWRITE_FONT_FEATURE fontFeature);

        [VtblIndex(4)]
        [return: NativeTypeName("UINT32")]
        uint GetFontFeatureCount();

        [VtblIndex(5)]
        HRESULT GetFontFeature(
            [NativeTypeName("UINT32")] uint fontFeatureIndex,
            DWRITE_FONT_FEATURE* fontFeature
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

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_FEATURE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_FEATURE, int> AddFontFeature;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontFeatureCount;

        [NativeTypeName(
            "HRESULT (UINT32, DWRITE_FONT_FEATURE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, DWRITE_FONT_FEATURE*, int> GetFontFeature;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteTypography"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteTypography(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteTypography"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteTypography(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteTypography(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteTypography"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteTypography"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteTypography value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
