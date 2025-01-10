// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("EFA008F9-F7A1-48BF-B05C-F224713CC0FF")]
[NativeTypeName("struct IDWriteFontFallback : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDWriteFontFallback : IDWriteFontFallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFallback, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontFallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT MapCharacters(
        IDWriteTextAnalysisSource analysisSource,
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        IDWriteFontCollection baseFontCollection,
        [NativeTypeName("const wchar_t *")] ushort* baseFamilyName,
        DWRITE_FONT_WEIGHT baseWeight,
        DWRITE_FONT_STYLE baseStyle,
        DWRITE_FONT_STRETCH baseStretch,
        [NativeTypeName("UINT32 *")] uint* mappedLength,
        IDWriteFont* mappedFont,
        float* scale
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFallback,
                IDWriteTextAnalysisSource,
                uint,
                uint,
                IDWriteFontCollection,
                ushort*,
                DWRITE_FONT_WEIGHT,
                DWRITE_FONT_STYLE,
                DWRITE_FONT_STRETCH,
                uint*,
                IDWriteFont*,
                float*,
                int>)((*lpVtbl)[3])
        )(
            this,
            analysisSource,
            textPosition,
            textLength,
            baseFontCollection,
            baseFamilyName,
            baseWeight,
            baseStyle,
            baseStretch,
            mappedLength,
            mappedFont,
            scale
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT MapCharacters(
            IDWriteTextAnalysisSource analysisSource,
            [NativeTypeName("UINT32")] uint textPosition,
            [NativeTypeName("UINT32")] uint textLength,
            IDWriteFontCollection baseFontCollection,
            [NativeTypeName("const wchar_t *")] ushort* baseFamilyName,
            DWRITE_FONT_WEIGHT baseWeight,
            DWRITE_FONT_STYLE baseStyle,
            DWRITE_FONT_STRETCH baseStretch,
            [NativeTypeName("UINT32 *")] uint* mappedLength,
            IDWriteFont* mappedFont,
            float* scale
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
            "HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteFontCollection *, const wchar_t *, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, UINT32 *, IDWriteFont **, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteTextAnalysisSource,
            uint,
            uint,
            IDWriteFontCollection,
            ushort*,
            DWRITE_FONT_WEIGHT,
            DWRITE_FONT_STYLE,
            DWRITE_FONT_STRETCH,
            uint*,
            IDWriteFont*,
            float*,
            int> MapCharacters;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontFallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontFallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontFallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontFallback(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontFallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontFallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
