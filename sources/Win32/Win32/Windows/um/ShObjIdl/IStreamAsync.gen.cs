// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FE0B6665-E0CA-49B9-A178-2B5CB48D92A5")]
[NativeTypeName("struct IStreamAsync : IStream")]
[NativeInheritance("IStream")]
public unsafe partial struct IStreamAsync : IStreamAsync.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamAsync));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamAsync, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStreamAsync, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamAsync, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(
        void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbRead
    )
    {
        return ((delegate* unmanaged<IStreamAsync, void*, uint, uint*, int>)((*lpVtbl)[3]))(
            this,
            pv,
            cb,
            pcbRead
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write(
        [NativeTypeName("const void *")] void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbWritten
    )
    {
        return ((delegate* unmanaged<IStreamAsync, void*, uint, uint*, int>)((*lpVtbl)[4]))(
            this,
            pv,
            cb,
            pcbWritten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Seek(
        LARGE_INTEGER dlibMove,
        [NativeTypeName("DWORD")] uint dwOrigin,
        ULARGE_INTEGER* plibNewPosition
    )
    {
        return (
            (delegate* unmanaged<IStreamAsync, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(
                (*lpVtbl)[5]
            )
        )(this, dlibMove, dwOrigin, plibNewPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged<IStreamAsync, ULARGE_INTEGER, int>)((*lpVtbl)[6]))(
            this,
            libNewSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyTo(
        IStream pstm,
        ULARGE_INTEGER cb,
        ULARGE_INTEGER* pcbRead,
        ULARGE_INTEGER* pcbWritten
    )
    {
        return (
            (delegate* unmanaged<
                IStreamAsync,
                IStream,
                ULARGE_INTEGER,
                ULARGE_INTEGER*,
                ULARGE_INTEGER*,
                int>)((*lpVtbl)[7])
        )(this, pstm, cb, pcbRead, pcbWritten);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged<IStreamAsync, uint, int>)((*lpVtbl)[8]))(this, grfCommitFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<IStreamAsync, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LockRegion(
        ULARGE_INTEGER libOffset,
        ULARGE_INTEGER cb,
        [NativeTypeName("DWORD")] uint dwLockType
    )
    {
        return (
            (delegate* unmanaged<IStreamAsync, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
                (*lpVtbl)[10]
            )
        )(this, libOffset, cb, dwLockType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnlockRegion(
        ULARGE_INTEGER libOffset,
        ULARGE_INTEGER cb,
        [NativeTypeName("DWORD")] uint dwLockType
    )
    {
        return (
            (delegate* unmanaged<IStreamAsync, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
                (*lpVtbl)[11]
            )
        )(this, libOffset, cb, dwLockType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<IStreamAsync, STATSTG*, uint, int>)((*lpVtbl)[12]))(
            this,
            pstatstg,
            grfStatFlag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream* ppstm)
    {
        return ((delegate* unmanaged<IStreamAsync, IStream*, int>)((*lpVtbl)[13]))(this, ppstm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ReadAsync(
        void* pv,
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("LPDWORD")] uint* pcbRead,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
    )
    {
        return (
            (delegate* unmanaged<IStreamAsync, void*, uint, uint*, OVERLAPPED*, int>)((*lpVtbl)[14])
        )(this, pv, cb, pcbRead, lpOverlapped);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteAsync(
        [NativeTypeName("const void *")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("LPDWORD")] uint* pcbWritten,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
    )
    {
        return (
            (delegate* unmanaged<IStreamAsync, void*, uint, uint*, OVERLAPPED*, int>)((*lpVtbl)[15])
        )(this, lpBuffer, cb, pcbWritten, lpOverlapped);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT OverlappedResult(
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped,
        [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred,
        BOOL bWait
    )
    {
        return ((delegate* unmanaged<IStreamAsync, OVERLAPPED*, uint*, BOOL, int>)((*lpVtbl)[16]))(
            this,
            lpOverlapped,
            lpNumberOfBytesTransferred,
            bWait
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CancelIo()
    {
        return ((delegate* unmanaged<IStreamAsync, int>)((*lpVtbl)[17]))(this);
    }

    public interface Interface : IStream.Interface
    {
        [VtblIndex(14)]
        HRESULT ReadAsync(
            void* pv,
            [NativeTypeName("DWORD")] uint cb,
            [NativeTypeName("LPDWORD")] uint* pcbRead,
            [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
        );

        [VtblIndex(15)]
        HRESULT WriteAsync(
            [NativeTypeName("const void *")] void* lpBuffer,
            [NativeTypeName("DWORD")] uint cb,
            [NativeTypeName("LPDWORD")] uint* pcbWritten,
            [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
        );

        [VtblIndex(16)]
        HRESULT OverlappedResult(
            [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped,
            [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred,
            BOOL bWait
        );

        [VtblIndex(17)]
        HRESULT CancelIo();
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

        [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint*, int> Read;

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint*, int> Write;

        [NativeTypeName(
            "HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> Seek;

        [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, int> SetSize;

        [NativeTypeName(
            "HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER *, ULARGE_INTEGER *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            ULARGE_INTEGER,
            ULARGE_INTEGER*,
            ULARGE_INTEGER*,
            int> CopyTo;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Commit;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Revert;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> LockRegion;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> UnlockRegion;

        [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, STATSTG*, uint, int> Stat;

        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> Clone;

        [NativeTypeName("HRESULT (void *, DWORD, LPDWORD, LPOVERLAPPED) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint*, OVERLAPPED*, int> ReadAsync;

        [NativeTypeName(
            "HRESULT (const void *, DWORD, LPDWORD, LPOVERLAPPED) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void*, uint, uint*, OVERLAPPED*, int> WriteAsync;

        [NativeTypeName("HRESULT (LPOVERLAPPED, LPDWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, OVERLAPPED*, uint*, BOOL, int> OverlappedResult;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CancelIo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStreamAsync"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStreamAsync(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IStream"/> to <see cref = "IStreamAsync"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IStream"/> instance to be converted </param>
    public static explicit operator IStreamAsync(Silk.NET.Windows.IStream value)
    {
        return new IStreamAsync(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamAsync"/> to <see cref = "Silk.NET.Windows.IStream"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamAsync"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IStream(IStreamAsync value)
    {
        return new Silk.NET.Windows.IStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISequentialStream"/> to <see cref = "IStreamAsync"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISequentialStream"/> instance to be converted </param>
    public static explicit operator IStreamAsync(Silk.NET.Windows.ISequentialStream value)
    {
        return new IStreamAsync(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamAsync"/> to <see cref = "Silk.NET.Windows.ISequentialStream"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamAsync"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISequentialStream(IStreamAsync value)
    {
        return new Silk.NET.Windows.ISequentialStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStreamAsync"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStreamAsync(Silk.NET.Windows.IUnknown value)
    {
        return new IStreamAsync(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamAsync"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamAsync"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStreamAsync value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
