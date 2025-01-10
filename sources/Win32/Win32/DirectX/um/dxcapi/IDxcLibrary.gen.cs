// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("E5204DC7-D18C-4C3C-BDFB-851673980FE7")]
[NativeTypeName("struct IDxcLibrary : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcLibrary : IDxcLibrary.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcLibrary));
    public void*** lpVtbl;

    public HRESULT GetBlobAsUtf16(IDxcBlob pBlob, IDxcBlobEncoding* pBlobEncoding)
    {
        return this.GetBlobAsWide(pBlob, pBlobEncoding);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcLibrary, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcLibrary, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcLibrary, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMalloc(IMalloc pMalloc)
    {
        return ((delegate* unmanaged<IDxcLibrary, IMalloc, int>)((*lpVtbl)[3]))(this, pMalloc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateBlobFromBlob(
        IDxcBlob pBlob,
        [NativeTypeName("UINT32")] uint offset,
        [NativeTypeName("UINT32")] uint length,
        IDxcBlob* ppResult
    )
    {
        return (
            (delegate* unmanaged<IDxcLibrary, IDxcBlob, uint, uint, IDxcBlob*, int>)((*lpVtbl)[4])
        )(this, pBlob, offset, length, ppResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateBlobFromFile(
        [NativeTypeName("LPCWSTR")] ushort* pFileName,
        [NativeTypeName("UINT32 *")] uint* codePage,
        IDxcBlobEncoding* pBlobEncoding
    )
    {
        return (
            (delegate* unmanaged<IDxcLibrary, ushort*, uint*, IDxcBlobEncoding*, int>)((*lpVtbl)[5])
        )(this, pFileName, codePage, pBlobEncoding);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateBlobWithEncodingFromPinned(
        [NativeTypeName("LPCVOID")] void* pText,
        [NativeTypeName("UINT32")] uint size,
        [NativeTypeName("UINT32")] uint codePage,
        IDxcBlobEncoding* pBlobEncoding
    )
    {
        return (
            (delegate* unmanaged<IDxcLibrary, void*, uint, uint, IDxcBlobEncoding*, int>)(
                (*lpVtbl)[6]
            )
        )(this, pText, size, codePage, pBlobEncoding);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateBlobWithEncodingOnHeapCopy(
        [NativeTypeName("LPCVOID")] void* pText,
        [NativeTypeName("UINT32")] uint size,
        [NativeTypeName("UINT32")] uint codePage,
        IDxcBlobEncoding* pBlobEncoding
    )
    {
        return (
            (delegate* unmanaged<IDxcLibrary, void*, uint, uint, IDxcBlobEncoding*, int>)(
                (*lpVtbl)[7]
            )
        )(this, pText, size, codePage, pBlobEncoding);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateBlobWithEncodingOnMalloc(
        [NativeTypeName("LPCVOID")] void* pText,
        IMalloc pIMalloc,
        [NativeTypeName("UINT32")] uint size,
        [NativeTypeName("UINT32")] uint codePage,
        IDxcBlobEncoding* pBlobEncoding
    )
    {
        return (
            (delegate* unmanaged<IDxcLibrary, void*, IMalloc, uint, uint, IDxcBlobEncoding*, int>)(
                (*lpVtbl)[8]
            )
        )(this, pText, pIMalloc, size, codePage, pBlobEncoding);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateIncludeHandler(IDxcIncludeHandler* ppResult)
    {
        return ((delegate* unmanaged<IDxcLibrary, IDxcIncludeHandler*, int>)((*lpVtbl)[9]))(
            this,
            ppResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateStreamFromBlobReadOnly(IDxcBlob pBlob, IStream* ppStream)
    {
        return ((delegate* unmanaged<IDxcLibrary, IDxcBlob, IStream*, int>)((*lpVtbl)[10]))(
            this,
            pBlob,
            ppStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetBlobAsUtf8(IDxcBlob pBlob, IDxcBlobEncoding* pBlobEncoding)
    {
        return (
            (delegate* unmanaged<IDxcLibrary, IDxcBlob, IDxcBlobEncoding*, int>)((*lpVtbl)[11])
        )(this, pBlob, pBlobEncoding);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetBlobAsWide(IDxcBlob pBlob, IDxcBlobEncoding* pBlobEncoding)
    {
        return (
            (delegate* unmanaged<IDxcLibrary, IDxcBlob, IDxcBlobEncoding*, int>)((*lpVtbl)[12])
        )(this, pBlob, pBlobEncoding);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMalloc(IMalloc pMalloc);

        [VtblIndex(4)]
        HRESULT CreateBlobFromBlob(
            IDxcBlob pBlob,
            [NativeTypeName("UINT32")] uint offset,
            [NativeTypeName("UINT32")] uint length,
            IDxcBlob* ppResult
        );

        [VtblIndex(5)]
        HRESULT CreateBlobFromFile(
            [NativeTypeName("LPCWSTR")] ushort* pFileName,
            [NativeTypeName("UINT32 *")] uint* codePage,
            IDxcBlobEncoding* pBlobEncoding
        );

        [VtblIndex(6)]
        HRESULT CreateBlobWithEncodingFromPinned(
            [NativeTypeName("LPCVOID")] void* pText,
            [NativeTypeName("UINT32")] uint size,
            [NativeTypeName("UINT32")] uint codePage,
            IDxcBlobEncoding* pBlobEncoding
        );

        [VtblIndex(7)]
        HRESULT CreateBlobWithEncodingOnHeapCopy(
            [NativeTypeName("LPCVOID")] void* pText,
            [NativeTypeName("UINT32")] uint size,
            [NativeTypeName("UINT32")] uint codePage,
            IDxcBlobEncoding* pBlobEncoding
        );

        [VtblIndex(8)]
        HRESULT CreateBlobWithEncodingOnMalloc(
            [NativeTypeName("LPCVOID")] void* pText,
            IMalloc pIMalloc,
            [NativeTypeName("UINT32")] uint size,
            [NativeTypeName("UINT32")] uint codePage,
            IDxcBlobEncoding* pBlobEncoding
        );

        [VtblIndex(9)]
        HRESULT CreateIncludeHandler(IDxcIncludeHandler* ppResult);

        [VtblIndex(10)]
        HRESULT CreateStreamFromBlobReadOnly(IDxcBlob pBlob, IStream* ppStream);

        [VtblIndex(11)]
        HRESULT GetBlobAsUtf8(IDxcBlob pBlob, IDxcBlobEncoding* pBlobEncoding);

        [VtblIndex(12)]
        HRESULT GetBlobAsWide(IDxcBlob pBlob, IDxcBlobEncoding* pBlobEncoding);
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

        [NativeTypeName("HRESULT (IMalloc *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMalloc, int> SetMalloc;

        [NativeTypeName(
            "HRESULT (IDxcBlob *, UINT32, UINT32, IDxcBlob **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDxcBlob, uint, uint, IDxcBlob*, int> CreateBlobFromBlob;

        [NativeTypeName(
            "HRESULT (LPCWSTR, UINT32 *, IDxcBlobEncoding **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint*,
            IDxcBlobEncoding*,
            int> CreateBlobFromFile;

        [NativeTypeName(
            "HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            uint,
            uint,
            IDxcBlobEncoding*,
            int> CreateBlobWithEncodingFromPinned;

        [NativeTypeName(
            "HRESULT (LPCVOID, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            uint,
            uint,
            IDxcBlobEncoding*,
            int> CreateBlobWithEncodingOnHeapCopy;

        [NativeTypeName(
            "HRESULT (LPCVOID, IMalloc *, UINT32, UINT32, IDxcBlobEncoding **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            IMalloc,
            uint,
            uint,
            IDxcBlobEncoding*,
            int> CreateBlobWithEncodingOnMalloc;

        [NativeTypeName("HRESULT (IDxcIncludeHandler **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcIncludeHandler*, int> CreateIncludeHandler;

        [NativeTypeName("HRESULT (IDxcBlob *, IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob, IStream*, int> CreateStreamFromBlobReadOnly;

        [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob, IDxcBlobEncoding*, int> GetBlobAsUtf8;

        [NativeTypeName("HRESULT (IDxcBlob *, IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob, IDxcBlobEncoding*, int> GetBlobAsWide;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcLibrary"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcLibrary(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcLibrary"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcLibrary(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcLibrary(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcLibrary"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcLibrary"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcLibrary value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
