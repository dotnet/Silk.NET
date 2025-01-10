// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("135FF860-22B7-4DDF-B0F6-218F4F299A43")]
[NativeTypeName("struct IWICStream : IStream")]
[NativeInheritance("IStream")]
public unsafe partial struct IWICStream : IWICStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICStream));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICStream, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICStream, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICStream, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(
        void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbRead
    )
    {
        return ((delegate* unmanaged<IWICStream, void*, uint, uint*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IWICStream, void*, uint, uint*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IWICStream, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(
                (*lpVtbl)[5]
            )
        )(this, dlibMove, dwOrigin, plibNewPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged<IWICStream, ULARGE_INTEGER, int>)((*lpVtbl)[6]))(
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
                IWICStream,
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
        return ((delegate* unmanaged<IWICStream, uint, int>)((*lpVtbl)[8]))(this, grfCommitFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<IWICStream, int>)((*lpVtbl)[9]))(this);
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
            (delegate* unmanaged<IWICStream, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
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
            (delegate* unmanaged<IWICStream, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
                (*lpVtbl)[11]
            )
        )(this, libOffset, cb, dwLockType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<IWICStream, STATSTG*, uint, int>)((*lpVtbl)[12]))(
            this,
            pstatstg,
            grfStatFlag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream* ppstm)
    {
        return ((delegate* unmanaged<IWICStream, IStream*, int>)((*lpVtbl)[13]))(this, ppstm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT InitializeFromIStream(IStream pIStream)
    {
        return ((delegate* unmanaged<IWICStream, IStream, int>)((*lpVtbl)[14]))(this, pIStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT InitializeFromFilename(
        [NativeTypeName("LPCWSTR")] ushort* wzFileName,
        [NativeTypeName("DWORD")] uint dwDesiredAccess
    )
    {
        return ((delegate* unmanaged<IWICStream, ushort*, uint, int>)((*lpVtbl)[15]))(
            this,
            wzFileName,
            dwDesiredAccess
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT InitializeFromMemory(
        [NativeTypeName("WICInProcPointer")] byte* pbBuffer,
        [NativeTypeName("DWORD")] uint cbBufferSize
    )
    {
        return ((delegate* unmanaged<IWICStream, byte*, uint, int>)((*lpVtbl)[16]))(
            this,
            pbBuffer,
            cbBufferSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT InitializeFromIStreamRegion(
        IStream pIStream,
        ULARGE_INTEGER ulOffset,
        ULARGE_INTEGER ulMaxSize
    )
    {
        return (
            (delegate* unmanaged<IWICStream, IStream, ULARGE_INTEGER, ULARGE_INTEGER, int>)(
                (*lpVtbl)[17]
            )
        )(this, pIStream, ulOffset, ulMaxSize);
    }

    public interface Interface : IStream.Interface
    {
        [VtblIndex(14)]
        HRESULT InitializeFromIStream(IStream pIStream);

        [VtblIndex(15)]
        HRESULT InitializeFromFilename(
            [NativeTypeName("LPCWSTR")] ushort* wzFileName,
            [NativeTypeName("DWORD")] uint dwDesiredAccess
        );

        [VtblIndex(16)]
        HRESULT InitializeFromMemory(
            [NativeTypeName("WICInProcPointer")] byte* pbBuffer,
            [NativeTypeName("DWORD")] uint cbBufferSize
        );

        [VtblIndex(17)]
        HRESULT InitializeFromIStreamRegion(
            IStream pIStream,
            ULARGE_INTEGER ulOffset,
            ULARGE_INTEGER ulMaxSize
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

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> InitializeFromIStream;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> InitializeFromFilename;

        [NativeTypeName("HRESULT (WICInProcPointer, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> InitializeFromMemory;

        [NativeTypeName(
            "HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            ULARGE_INTEGER,
            ULARGE_INTEGER,
            int> InitializeFromIStreamRegion;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICStream"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICStream(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IStream"/> to <see cref = "IWICStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IStream"/> instance to be converted </param>
    public static explicit operator IWICStream(Silk.NET.Windows.IStream value)
    {
        return new IWICStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICStream"/> to <see cref = "Silk.NET.Windows.IStream"/>.</summary>
    /// <param name = "value">The <see cref = "IWICStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IStream(IWICStream value)
    {
        return new Silk.NET.Windows.IStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISequentialStream"/> to <see cref = "IWICStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISequentialStream"/> instance to be converted </param>
    public static explicit operator IWICStream(Silk.NET.Windows.ISequentialStream value)
    {
        return new IWICStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICStream"/> to <see cref = "Silk.NET.Windows.ISequentialStream"/>.</summary>
    /// <param name = "value">The <see cref = "IWICStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISequentialStream(IWICStream value)
    {
        return new Silk.NET.Windows.ISequentialStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICStream(Silk.NET.Windows.IUnknown value)
    {
        return new IWICStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICStream"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICStream value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
