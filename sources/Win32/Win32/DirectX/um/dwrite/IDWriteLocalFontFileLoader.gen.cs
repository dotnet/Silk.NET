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

[Guid("B2D9F3EC-C9FE-4A11-A2EC-D86208F7C0A2")]
[NativeTypeName("struct IDWriteLocalFontFileLoader : IDWriteFontFileLoader")]
[NativeInheritance("IDWriteFontFileLoader")]
public unsafe partial struct IDWriteLocalFontFileLoader
    : IDWriteLocalFontFileLoader.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteLocalFontFileLoader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDWriteLocalFontFileLoader, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteLocalFontFileLoader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteLocalFontFileLoader, uint>)((*lpVtbl)[2]))(this);
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
                IDWriteLocalFontFileLoader,
                void*,
                uint,
                IDWriteFontFileStream*,
                int>)((*lpVtbl)[3])
        )(this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFilePathLengthFromKey(
        [NativeTypeName("const void *")] void* fontFileReferenceKey,
        [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
        [NativeTypeName("UINT32 *")] uint* filePathLength
    )
    {
        return (
            (delegate* unmanaged<IDWriteLocalFontFileLoader, void*, uint, uint*, int>)((*lpVtbl)[4])
        )(this, fontFileReferenceKey, fontFileReferenceKeySize, filePathLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFilePathFromKey(
        [NativeTypeName("const void *")] void* fontFileReferenceKey,
        [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
        [NativeTypeName("WCHAR *")] ushort* filePath,
        [NativeTypeName("UINT32")] uint filePathSize
    )
    {
        return (
            (delegate* unmanaged<IDWriteLocalFontFileLoader, void*, uint, ushort*, uint, int>)(
                (*lpVtbl)[5]
            )
        )(this, fontFileReferenceKey, fontFileReferenceKeySize, filePath, filePathSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLastWriteTimeFromKey(
        [NativeTypeName("const void *")] void* fontFileReferenceKey,
        [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
        FILETIME* lastWriteTime
    )
    {
        return (
            (delegate* unmanaged<IDWriteLocalFontFileLoader, void*, uint, FILETIME*, int>)(
                (*lpVtbl)[6]
            )
        )(this, fontFileReferenceKey, fontFileReferenceKeySize, lastWriteTime);
    }

    public interface Interface : IDWriteFontFileLoader.Interface
    {
        [VtblIndex(4)]
        HRESULT GetFilePathLengthFromKey(
            [NativeTypeName("const void *")] void* fontFileReferenceKey,
            [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [NativeTypeName("UINT32 *")] uint* filePathLength
        );

        [VtblIndex(5)]
        HRESULT GetFilePathFromKey(
            [NativeTypeName("const void *")] void* fontFileReferenceKey,
            [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            [NativeTypeName("WCHAR *")] ushort* filePath,
            [NativeTypeName("UINT32")] uint filePathSize
        );

        [VtblIndex(6)]
        HRESULT GetLastWriteTimeFromKey(
            [NativeTypeName("const void *")] void* fontFileReferenceKey,
            [NativeTypeName("UINT32")] uint fontFileReferenceKeySize,
            FILETIME* lastWriteTime
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
            "HRESULT (const void *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void*, uint, uint*, int> GetFilePathLengthFromKey;

        [NativeTypeName(
            "HRESULT (const void *, UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void*, uint, ushort*, uint, int> GetFilePathFromKey;

        [NativeTypeName(
            "HRESULT (const void *, UINT32, FILETIME *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void*, uint, FILETIME*, int> GetLastWriteTimeFromKey;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteLocalFontFileLoader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteLocalFontFileLoader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFileLoader"/> to <see cref = "IDWriteLocalFontFileLoader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFileLoader"/> instance to be converted </param>
    public static explicit operator IDWriteLocalFontFileLoader(
        Silk.NET.DirectX.IDWriteFontFileLoader value
    )
    {
        return new IDWriteLocalFontFileLoader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteLocalFontFileLoader"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFileLoader"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteLocalFontFileLoader"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFileLoader(
        IDWriteLocalFontFileLoader value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontFileLoader(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteLocalFontFileLoader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteLocalFontFileLoader(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteLocalFontFileLoader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteLocalFontFileLoader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteLocalFontFileLoader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteLocalFontFileLoader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
