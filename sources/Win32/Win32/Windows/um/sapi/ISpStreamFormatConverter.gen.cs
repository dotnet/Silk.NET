// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("678A932C-EA71-4446-9B41-78FDA6280A29")]
[NativeTypeName("struct ISpStreamFormatConverter : ISpStreamFormat")]
[NativeInheritance("ISpStreamFormat")]
public unsafe partial struct ISpStreamFormatConverter
    : ISpStreamFormatConverter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpStreamFormatConverter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpStreamFormatConverter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(
        void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbRead
    )
    {
        return (
            (delegate* unmanaged<ISpStreamFormatConverter, void*, uint, uint*, int>)((*lpVtbl)[3])
        )(this, pv, cb, pcbRead);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write(
        [NativeTypeName("const void *")] void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbWritten
    )
    {
        return (
            (delegate* unmanaged<ISpStreamFormatConverter, void*, uint, uint*, int>)((*lpVtbl)[4])
        )(this, pv, cb, pcbWritten);
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
            (delegate* unmanaged<
                ISpStreamFormatConverter,
                LARGE_INTEGER,
                uint,
                ULARGE_INTEGER*,
                int>)((*lpVtbl)[5])
        )(this, dlibMove, dwOrigin, plibNewPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter, ULARGE_INTEGER, int>)((*lpVtbl)[6]))(
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
                ISpStreamFormatConverter,
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
        return ((delegate* unmanaged<ISpStreamFormatConverter, uint, int>)((*lpVtbl)[8]))(
            this,
            grfCommitFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter, int>)((*lpVtbl)[9]))(this);
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
            (delegate* unmanaged<
                ISpStreamFormatConverter,
                ULARGE_INTEGER,
                ULARGE_INTEGER,
                uint,
                int>)((*lpVtbl)[10])
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
            (delegate* unmanaged<
                ISpStreamFormatConverter,
                ULARGE_INTEGER,
                ULARGE_INTEGER,
                uint,
                int>)((*lpVtbl)[11])
        )(this, libOffset, cb, dwLockType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return (
            (delegate* unmanaged<ISpStreamFormatConverter, STATSTG*, uint, int>)((*lpVtbl)[12])
        )(this, pstatstg, grfStatFlag);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream* ppstm)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter, IStream*, int>)((*lpVtbl)[13]))(
            this,
            ppstm
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFormat(Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
    {
        return (
            (delegate* unmanaged<ISpStreamFormatConverter, Guid*, WAVEFORMATEX**, int>)(
                (*lpVtbl)[14]
            )
        )(this, pguidFormatId, ppCoMemWaveFormatEx);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetBaseStream(
        ISpStreamFormat pStream,
        BOOL fSetFormatToBaseStreamFormat,
        BOOL fWriteToBaseStream
    )
    {
        return (
            (delegate* unmanaged<ISpStreamFormatConverter, ISpStreamFormat, BOOL, BOOL, int>)(
                (*lpVtbl)[15]
            )
        )(this, pStream, fSetFormatToBaseStreamFormat, fWriteToBaseStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetBaseStream(ISpStreamFormat* ppStream)
    {
        return (
            (delegate* unmanaged<ISpStreamFormatConverter, ISpStreamFormat*, int>)((*lpVtbl)[16])
        )(this, ppStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetFormat(
        [NativeTypeName("const GUID &")] Guid* rguidFormatIdOfConvertedStream,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatExOfConvertedStream
    )
    {
        return (
            (delegate* unmanaged<ISpStreamFormatConverter, Guid*, WAVEFORMATEX*, int>)(
                (*lpVtbl)[17]
            )
        )(this, rguidFormatIdOfConvertedStream, pWaveFormatExOfConvertedStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ResetSeekPosition()
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ScaleConvertedToBaseOffset(
        [NativeTypeName("ULONGLONG")] ulong ullOffsetConvertedStream,
        [NativeTypeName("ULONGLONG *")] ulong* pullOffsetBaseStream
    )
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter, ulong, ulong*, int>)((*lpVtbl)[19]))(
            this,
            ullOffsetConvertedStream,
            pullOffsetBaseStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT ScaleBaseToConvertedOffset(
        [NativeTypeName("ULONGLONG")] ulong ullOffsetBaseStream,
        [NativeTypeName("ULONGLONG *")] ulong* pullOffsetConvertedStream
    )
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter, ulong, ulong*, int>)((*lpVtbl)[20]))(
            this,
            ullOffsetBaseStream,
            pullOffsetConvertedStream
        );
    }

    public interface Interface : ISpStreamFormat.Interface
    {
        [VtblIndex(15)]
        HRESULT SetBaseStream(
            ISpStreamFormat pStream,
            BOOL fSetFormatToBaseStreamFormat,
            BOOL fWriteToBaseStream
        );

        [VtblIndex(16)]
        HRESULT GetBaseStream(ISpStreamFormat* ppStream);

        [VtblIndex(17)]
        HRESULT SetFormat(
            [NativeTypeName("const GUID &")] Guid* rguidFormatIdOfConvertedStream,
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatExOfConvertedStream
        );

        [VtblIndex(18)]
        HRESULT ResetSeekPosition();

        [VtblIndex(19)]
        HRESULT ScaleConvertedToBaseOffset(
            [NativeTypeName("ULONGLONG")] ulong ullOffsetConvertedStream,
            [NativeTypeName("ULONGLONG *")] ulong* pullOffsetBaseStream
        );

        [VtblIndex(20)]
        HRESULT ScaleBaseToConvertedOffset(
            [NativeTypeName("ULONGLONG")] ulong ullOffsetBaseStream,
            [NativeTypeName("ULONGLONG *")] ulong* pullOffsetConvertedStream
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

        [NativeTypeName("HRESULT (GUID *, WAVEFORMATEX **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, WAVEFORMATEX**, int> GetFormat;

        [NativeTypeName("HRESULT (ISpStreamFormat *, BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpStreamFormat, BOOL, BOOL, int> SetBaseStream;

        [NativeTypeName("HRESULT (ISpStreamFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpStreamFormat*, int> GetBaseStream;

        [NativeTypeName("HRESULT (const GUID &, const WAVEFORMATEX *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, WAVEFORMATEX*, int> SetFormat;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetSeekPosition;

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong*, int> ScaleConvertedToBaseOffset;

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong*, int> ScaleBaseToConvertedOffset;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpStreamFormatConverter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpStreamFormatConverter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpStreamFormat"/> to <see cref = "ISpStreamFormatConverter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpStreamFormat"/> instance to be converted </param>
    public static explicit operator ISpStreamFormatConverter(Silk.NET.Windows.ISpStreamFormat value)
    {
        return new ISpStreamFormatConverter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpStreamFormatConverter"/> to <see cref = "Silk.NET.Windows.ISpStreamFormat"/>.</summary>
    /// <param name = "value">The <see cref = "ISpStreamFormatConverter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpStreamFormat(ISpStreamFormatConverter value)
    {
        return new Silk.NET.Windows.ISpStreamFormat(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IStream"/> to <see cref = "ISpStreamFormatConverter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IStream"/> instance to be converted </param>
    public static explicit operator ISpStreamFormatConverter(Silk.NET.Windows.IStream value)
    {
        return new ISpStreamFormatConverter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpStreamFormatConverter"/> to <see cref = "Silk.NET.Windows.IStream"/>.</summary>
    /// <param name = "value">The <see cref = "ISpStreamFormatConverter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IStream(ISpStreamFormatConverter value)
    {
        return new Silk.NET.Windows.IStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISequentialStream"/> to <see cref = "ISpStreamFormatConverter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISequentialStream"/> instance to be converted </param>
    public static explicit operator ISpStreamFormatConverter(
        Silk.NET.Windows.ISequentialStream value
    )
    {
        return new ISpStreamFormatConverter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpStreamFormatConverter"/> to <see cref = "Silk.NET.Windows.ISequentialStream"/>.</summary>
    /// <param name = "value">The <see cref = "ISpStreamFormatConverter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISequentialStream(
        ISpStreamFormatConverter value
    )
    {
        return new Silk.NET.Windows.ISequentialStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpStreamFormatConverter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpStreamFormatConverter(Silk.NET.Windows.IUnknown value)
    {
        return new ISpStreamFormatConverter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpStreamFormatConverter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpStreamFormatConverter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpStreamFormatConverter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
