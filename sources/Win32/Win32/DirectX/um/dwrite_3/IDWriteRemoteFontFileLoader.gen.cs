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

[Guid("68648C83-6EDE-46C0-AB46-20083A887FDE")]
[NativeTypeName("struct IDWriteRemoteFontFileLoader : IDWriteFontFileLoader")]
[NativeInheritance("IDWriteFontFileLoader")]
public unsafe partial struct IDWriteRemoteFontFileLoader
    : IDWriteRemoteFontFileLoader.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRemoteFontFileLoader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDWriteRemoteFontFileLoader, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileLoader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileLoader, uint>)((*lpVtbl)[2]))(this);
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
                IDWriteRemoteFontFileLoader,
                void*,
                uint,
                IDWriteFontFileStream*,
                int>)((*lpVtbl)[3])
        )(this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateRemoteStreamFromKey(
        [NativeTypeName("const void *")] void* fontFileReferenceKey,
        [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
        IDWriteRemoteFontFileStream* fontFileStream
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteRemoteFontFileLoader,
                void*,
                uint,
                IDWriteRemoteFontFileStream*,
                int>)((*lpVtbl)[4])
        )(this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLocalityFromKey(
        [NativeTypeName("const void *")] void* fontFileReferenceKey,
        [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
        DWRITE_LOCALITY* locality
    )
    {
        return (
            (delegate* unmanaged<IDWriteRemoteFontFileLoader, void*, uint, DWRITE_LOCALITY*, int>)(
                (*lpVtbl)[5]
            )
        )(this, fontFileReferenceKey, fontFileReferenceKeySize, locality);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFontFileReferenceFromUrl(
        IDWriteFactory factory,
        [NativeTypeName("const WCHAR *")] ushort* baseUrl,
        [NativeTypeName("const WCHAR *")] ushort* fontFileUrl,
        IDWriteFontFile* fontFile
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteRemoteFontFileLoader,
                IDWriteFactory,
                ushort*,
                ushort*,
                IDWriteFontFile*,
                int>)((*lpVtbl)[6])
        )(this, factory, baseUrl, fontFileUrl, fontFile);
    }

    public interface Interface : IDWriteFontFileLoader.Interface
    {
        [VtblIndex(4)]
        HRESULT CreateRemoteStreamFromKey(
            [NativeTypeName("const void *")] void* fontFileReferenceKey,
            [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            IDWriteRemoteFontFileStream* fontFileStream
        );

        [VtblIndex(5)]
        HRESULT GetLocalityFromKey(
            [NativeTypeName("const void *")] void* fontFileReferenceKey,
            [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            DWRITE_LOCALITY* locality
        );

        [VtblIndex(6)]
        HRESULT CreateFontFileReferenceFromUrl(
            IDWriteFactory factory,
            [NativeTypeName("const WCHAR *")] ushort* baseUrl,
            [NativeTypeName("const WCHAR *")] ushort* fontFileUrl,
            IDWriteFontFile* fontFile
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
            "HRESULT (const void *, UINT32, IDWriteFontFileStream **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            uint,
            IDWriteFontFileStream*,
            int> CreateStreamFromKey;

        [NativeTypeName(
            "HRESULT (const void *, UINT32, IDWriteRemoteFontFileStream **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            uint,
            IDWriteRemoteFontFileStream*,
            int> CreateRemoteStreamFromKey;

        [NativeTypeName(
            "HRESULT (const void *, UINT32, DWRITE_LOCALITY *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void*, uint, DWRITE_LOCALITY*, int> GetLocalityFromKey;

        [NativeTypeName(
            "HRESULT (IDWriteFactory *, const WCHAR *, const WCHAR *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFactory,
            ushort*,
            ushort*,
            IDWriteFontFile*,
            int> CreateFontFileReferenceFromUrl;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteRemoteFontFileLoader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteRemoteFontFileLoader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFileLoader"/> to <see cref = "IDWriteRemoteFontFileLoader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFileLoader"/> instance to be converted </param>
    public static explicit operator IDWriteRemoteFontFileLoader(
        Silk.NET.DirectX.IDWriteFontFileLoader value
    )
    {
        return new IDWriteRemoteFontFileLoader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteRemoteFontFileLoader"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFileLoader"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteRemoteFontFileLoader"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFileLoader(
        IDWriteRemoteFontFileLoader value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontFileLoader(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteRemoteFontFileLoader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteRemoteFontFileLoader(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteRemoteFontFileLoader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteRemoteFontFileLoader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteRemoteFontFileLoader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteRemoteFontFileLoader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
