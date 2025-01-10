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

[Guid("DC102F47-A12D-4B1C-822D-9E117E33043F")]
[NativeTypeName("struct IDWriteInMemoryFontFileLoader : IDWriteFontFileLoader")]
[NativeInheritance("IDWriteFontFileLoader")]
public unsafe partial struct IDWriteInMemoryFontFileLoader
    : IDWriteInMemoryFontFileLoader.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteInMemoryFontFileLoader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDWriteInMemoryFontFileLoader, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateStreamFromKey(
        [NativeTypeName("const void *")] void* fontFileReferenceKey,
        [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
        IDWriteFontFileStream* fontFileStream
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteInMemoryFontFileLoader,
                void*,
                uint,
                IDWriteFontFileStream*,
                int>)((*lpVtbl)[3])
        )(this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateInMemoryFontFileReference(
        IDWriteFactory factory,
        [NativeTypeName("const void *")] void* fontData,
        [NativeTypeName("UINT32")] uint fontDataSize,
        IUnknown ownerObject,
        IDWriteFontFile* fontFile
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteInMemoryFontFileLoader,
                IDWriteFactory,
                void*,
                uint,
                IUnknown,
                IDWriteFontFile*,
                int>)((*lpVtbl)[4])
        )(this, factory, fontData, fontDataSize, ownerObject, fontFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetFileCount()
    {
        return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader, uint>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IDWriteFontFileLoader.Interface
    {
        [VtblIndex(4)]
        HRESULT CreateInMemoryFontFileReference(
            IDWriteFactory factory,
            [NativeTypeName("const void *")] void* fontData,
            [NativeTypeName("UINT32")] uint fontDataSize,
            IUnknown ownerObject,
            IDWriteFontFile* fontFile
        );

        [VtblIndex(5)]
        [return: NativeTypeName("UINT32")]
        uint GetFileCount();
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
            "HRESULT (const void *, UINT32, IDWriteFontFileStream **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            uint,
            IDWriteFontFileStream*,
            int> CreateStreamFromKey;

        [NativeTypeName(
            "HRESULT (IDWriteFactory *, const void *, UINT32, IUnknown *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFactory,
            void*,
            uint,
            IUnknown,
            IDWriteFontFile*,
            int> CreateInMemoryFontFileReference;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFileCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteInMemoryFontFileLoader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteInMemoryFontFileLoader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFileLoader"/> to <see cref = "IDWriteInMemoryFontFileLoader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFileLoader"/> instance to be converted </param>
    public static explicit operator IDWriteInMemoryFontFileLoader(
        Silk.NET.DirectX.IDWriteFontFileLoader value
    )
    {
        return new IDWriteInMemoryFontFileLoader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteInMemoryFontFileLoader"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFileLoader"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteInMemoryFontFileLoader"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFileLoader(
        IDWriteInMemoryFontFileLoader value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontFileLoader(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteInMemoryFontFileLoader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteInMemoryFontFileLoader(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteInMemoryFontFileLoader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteInMemoryFontFileLoader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteInMemoryFontFileLoader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteInMemoryFontFileLoader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
