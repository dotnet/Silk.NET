// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("27354146-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IStreamConcatenate : IStream")]
[NativeInheritance("IStream")]
public unsafe partial struct IStreamConcatenate : IStreamConcatenate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamConcatenate));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamConcatenate, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStreamConcatenate, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamConcatenate, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(
        void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbRead
    )
    {
        return ((delegate* unmanaged<IStreamConcatenate, void*, uint, uint*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IStreamConcatenate, void*, uint, uint*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IStreamConcatenate, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(
                (*lpVtbl)[5]
            )
        )(this, dlibMove, dwOrigin, plibNewPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged<IStreamConcatenate, ULARGE_INTEGER, int>)((*lpVtbl)[6]))(
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
                IStreamConcatenate,
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
        return ((delegate* unmanaged<IStreamConcatenate, uint, int>)((*lpVtbl)[8]))(
            this,
            grfCommitFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<IStreamConcatenate, int>)((*lpVtbl)[9]))(this);
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
            (delegate* unmanaged<IStreamConcatenate, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
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
            (delegate* unmanaged<IStreamConcatenate, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
                (*lpVtbl)[11]
            )
        )(this, libOffset, cb, dwLockType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<IStreamConcatenate, STATSTG*, uint, int>)((*lpVtbl)[12]))(
            this,
            pstatstg,
            grfStatFlag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream* ppstm)
    {
        return ((delegate* unmanaged<IStreamConcatenate, IStream*, int>)((*lpVtbl)[13]))(
            this,
            ppstm
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Initialize(IStream stream1, IStream stream2)
    {
        return ((delegate* unmanaged<IStreamConcatenate, IStream, IStream, int>)((*lpVtbl)[14]))(
            this,
            stream1,
            stream2
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Initialize2(IStream* streams, [NativeTypeName("ULONG")] uint streamCount)
    {
        return ((delegate* unmanaged<IStreamConcatenate, IStream*, uint, int>)((*lpVtbl)[15]))(
            this,
            streams,
            streamCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Append(IStream stream)
    {
        return ((delegate* unmanaged<IStreamConcatenate, IStream, int>)((*lpVtbl)[16]))(
            this,
            stream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Append2(IStream* streams, [NativeTypeName("ULONG")] uint streamCount)
    {
        return ((delegate* unmanaged<IStreamConcatenate, IStream*, uint, int>)((*lpVtbl)[17]))(
            this,
            streams,
            streamCount
        );
    }

    public interface Interface : IStream.Interface
    {
        [VtblIndex(14)]
        HRESULT Initialize(IStream stream1, IStream stream2);

        [VtblIndex(15)]
        HRESULT Initialize2(IStream* streams, [NativeTypeName("ULONG")] uint streamCount);

        [VtblIndex(16)]
        HRESULT Append(IStream stream);

        [VtblIndex(17)]
        HRESULT Append2(IStream* streams, [NativeTypeName("ULONG")] uint streamCount);
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

        [NativeTypeName("HRESULT (IStream *, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, IStream, int> Initialize;

        [NativeTypeName("HRESULT (IStream **, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, uint, int> Initialize2;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> Append;

        [NativeTypeName("HRESULT (IStream **, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, uint, int> Append2;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStreamConcatenate"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStreamConcatenate(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IStream"/> to <see cref = "IStreamConcatenate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IStream"/> instance to be converted </param>
    public static explicit operator IStreamConcatenate(Silk.NET.Windows.IStream value)
    {
        return new IStreamConcatenate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamConcatenate"/> to <see cref = "Silk.NET.Windows.IStream"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamConcatenate"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IStream(IStreamConcatenate value)
    {
        return new Silk.NET.Windows.IStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISequentialStream"/> to <see cref = "IStreamConcatenate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISequentialStream"/> instance to be converted </param>
    public static explicit operator IStreamConcatenate(Silk.NET.Windows.ISequentialStream value)
    {
        return new IStreamConcatenate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamConcatenate"/> to <see cref = "Silk.NET.Windows.ISequentialStream"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamConcatenate"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISequentialStream(IStreamConcatenate value)
    {
        return new Silk.NET.Windows.ISequentialStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStreamConcatenate"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStreamConcatenate(Silk.NET.Windows.IUnknown value)
    {
        return new IStreamConcatenate(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamConcatenate"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamConcatenate"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStreamConcatenate value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
