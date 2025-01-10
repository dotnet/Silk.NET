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

[Guid("4DB3757A-2C72-4ED9-B2B6-1ABABE1AFF9C")]
[NativeTypeName("struct IDWriteRemoteFontFileStream : IDWriteFontFileStream")]
[NativeInheritance("IDWriteFontFileStream")]
public unsafe partial struct IDWriteRemoteFontFileStream
    : IDWriteRemoteFontFileStream.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRemoteFontFileStream));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDWriteRemoteFontFileStream, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReadFileFragment(
        [NativeTypeName("const void **")] void** fragmentStart,
        [NativeTypeName("UINT64")] ulong fileOffset,
        [NativeTypeName("UINT64")] ulong fragmentSize,
        void** fragmentContext
    )
    {
        return (
            (delegate* unmanaged<IDWriteRemoteFontFileStream, void**, ulong, ulong, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, fragmentStart, fileOffset, fragmentSize, fragmentContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ReleaseFileFragment(void* fragmentContext)
    {
        ((delegate* unmanaged<IDWriteRemoteFontFileStream, void*, void>)((*lpVtbl)[4]))(
            this,
            fragmentContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFileSize([NativeTypeName("UINT64 *")] ulong* fileSize)
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream, ulong*, int>)((*lpVtbl)[5]))(
            this,
            fileSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLastWriteTime([NativeTypeName("UINT64 *")] ulong* lastWriteTime)
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream, ulong*, int>)((*lpVtbl)[6]))(
            this,
            lastWriteTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetLocalFileSize([NativeTypeName("UINT64 *")] ulong* localFileSize)
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream, ulong*, int>)((*lpVtbl)[7]))(
            this,
            localFileSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFileFragmentLocality(
        [NativeTypeName("UINT64")] ulong fileOffset,
        [NativeTypeName("UINT64")] ulong fragmentSize,
        BOOL* isLocal,
        [NativeTypeName("UINT64 *")] ulong* partialSize
    )
    {
        return (
            (delegate* unmanaged<IDWriteRemoteFontFileStream, ulong, ulong, BOOL*, ulong*, int>)(
                (*lpVtbl)[8]
            )
        )(this, fileOffset, fragmentSize, isLocal, partialSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public DWRITE_LOCALITY GetLocality()
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream, DWRITE_LOCALITY>)((*lpVtbl)[9]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT BeginDownload(
        [NativeTypeName("const UUID *")] Guid* downloadOperationID,
        [NativeTypeName("const DWRITE_FILE_FRAGMENT *")] DWRITE_FILE_FRAGMENT* fileFragments,
        [NativeTypeName("UINT32")] uint fragmentCount,
        IDWriteAsyncResult* asyncResult
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteRemoteFontFileStream,
                Guid*,
                DWRITE_FILE_FRAGMENT*,
                uint,
                IDWriteAsyncResult*,
                int>)((*lpVtbl)[10])
        )(this, downloadOperationID, fileFragments, fragmentCount, asyncResult);
    }

    public interface Interface : IDWriteFontFileStream.Interface
    {
        [VtblIndex(7)]
        HRESULT GetLocalFileSize([NativeTypeName("UINT64 *")] ulong* localFileSize);

        [VtblIndex(8)]
        HRESULT GetFileFragmentLocality(
            [NativeTypeName("UINT64")] ulong fileOffset,
            [NativeTypeName("UINT64")] ulong fragmentSize,
            BOOL* isLocal,
            [NativeTypeName("UINT64 *")] ulong* partialSize
        );

        [VtblIndex(9)]
        DWRITE_LOCALITY GetLocality();

        [VtblIndex(10)]
        HRESULT BeginDownload(
            [NativeTypeName("const UUID *")] Guid* downloadOperationID,
            [NativeTypeName("const DWRITE_FILE_FRAGMENT *")] DWRITE_FILE_FRAGMENT* fileFragments,
            [NativeTypeName("UINT32")] uint fragmentCount,
            IDWriteAsyncResult* asyncResult
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
            "HRESULT (const void **, UINT64, UINT64, void **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void**, ulong, ulong, void**, int> ReadFileFragment;

        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> ReleaseFileFragment;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetFileSize;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetLastWriteTime;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetLocalFileSize;

        [NativeTypeName(
            "HRESULT (UINT64, UINT64, BOOL *, UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            ulong,
            BOOL*,
            ulong*,
            int> GetFileFragmentLocality;

        [NativeTypeName("DWRITE_LOCALITY () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LOCALITY> GetLocality;

        [NativeTypeName(
            "HRESULT (const UUID *, const DWRITE_FILE_FRAGMENT *, UINT32, IDWriteAsyncResult **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            DWRITE_FILE_FRAGMENT*,
            uint,
            IDWriteAsyncResult*,
            int> BeginDownload;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteRemoteFontFileStream"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteRemoteFontFileStream(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFileStream"/> to <see cref = "IDWriteRemoteFontFileStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFileStream"/> instance to be converted </param>
    public static explicit operator IDWriteRemoteFontFileStream(
        Silk.NET.DirectX.IDWriteFontFileStream value
    )
    {
        return new IDWriteRemoteFontFileStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteRemoteFontFileStream"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFileStream"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteRemoteFontFileStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFileStream(
        IDWriteRemoteFontFileStream value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontFileStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteRemoteFontFileStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteRemoteFontFileStream(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteRemoteFontFileStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteRemoteFontFileStream"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteRemoteFontFileStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteRemoteFontFileStream value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
