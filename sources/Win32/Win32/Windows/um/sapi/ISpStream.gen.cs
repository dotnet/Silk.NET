// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("12E3CCA9-7518-44C5-A5E7-BA5A79CB929E")]
[NativeTypeName("struct ISpStream : ISpStreamFormat")]
[NativeInheritance("ISpStreamFormat")]
public unsafe partial struct ISpStream : ISpStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpStream));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpStream, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpStream, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpStream, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(
        void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbRead
    )
    {
        return ((delegate* unmanaged<ISpStream, void*, uint, uint*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<ISpStream, void*, uint, uint*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<ISpStream, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(
                (*lpVtbl)[5]
            )
        )(this, dlibMove, dwOrigin, plibNewPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged<ISpStream, ULARGE_INTEGER, int>)((*lpVtbl)[6]))(
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
                ISpStream,
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
        return ((delegate* unmanaged<ISpStream, uint, int>)((*lpVtbl)[8]))(this, grfCommitFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<ISpStream, int>)((*lpVtbl)[9]))(this);
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
            (delegate* unmanaged<ISpStream, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
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
            (delegate* unmanaged<ISpStream, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
                (*lpVtbl)[11]
            )
        )(this, libOffset, cb, dwLockType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<ISpStream, STATSTG*, uint, int>)((*lpVtbl)[12]))(
            this,
            pstatstg,
            grfStatFlag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream* ppstm)
    {
        return ((delegate* unmanaged<ISpStream, IStream*, int>)((*lpVtbl)[13]))(this, ppstm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFormat(Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpStream, Guid*, WAVEFORMATEX**, int>)((*lpVtbl)[14]))(
            this,
            pguidFormatId,
            ppCoMemWaveFormatEx
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetBaseStream(
        IStream pStream,
        [NativeTypeName("const GUID &")] Guid* rguidFormat,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx
    )
    {
        return (
            (delegate* unmanaged<ISpStream, IStream, Guid*, WAVEFORMATEX*, int>)((*lpVtbl)[15])
        )(this, pStream, rguidFormat, pWaveFormatEx);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetBaseStream(IStream* ppStream)
    {
        return ((delegate* unmanaged<ISpStream, IStream*, int>)((*lpVtbl)[16]))(this, ppStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT BindToFile(
        [NativeTypeName("LPCWSTR")] ushort* pszFileName,
        SPFILEMODE eMode,
        [NativeTypeName("const GUID *")] Guid* pFormatId,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx,
        [NativeTypeName("ULONGLONG")] ulong ullEventInterest
    )
    {
        return (
            (delegate* unmanaged<ISpStream, ushort*, SPFILEMODE, Guid*, WAVEFORMATEX*, ulong, int>)(
                (*lpVtbl)[17]
            )
        )(this, pszFileName, eMode, pFormatId, pWaveFormatEx, ullEventInterest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ISpStream, int>)((*lpVtbl)[18]))(this);
    }

    public interface Interface : ISpStreamFormat.Interface
    {
        [VtblIndex(15)]
        HRESULT SetBaseStream(
            IStream pStream,
            [NativeTypeName("const GUID &")] Guid* rguidFormat,
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx
        );

        [VtblIndex(16)]
        HRESULT GetBaseStream(IStream* ppStream);

        [VtblIndex(17)]
        HRESULT BindToFile(
            [NativeTypeName("LPCWSTR")] ushort* pszFileName,
            SPFILEMODE eMode,
            [NativeTypeName("const GUID *")] Guid* pFormatId,
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx,
            [NativeTypeName("ULONGLONG")] ulong ullEventInterest
        );

        [VtblIndex(18)]
        HRESULT Close();
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

        [NativeTypeName(
            "HRESULT (IStream *, const GUID &, const WAVEFORMATEX *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStream, Guid*, WAVEFORMATEX*, int> SetBaseStream;

        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> GetBaseStream;

        [NativeTypeName(
            "HRESULT (LPCWSTR, SPFILEMODE, const GUID *, const WAVEFORMATEX *, ULONGLONG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            SPFILEMODE,
            Guid*,
            WAVEFORMATEX*,
            ulong,
            int> BindToFile;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpStream"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpStream(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpStreamFormat"/> to <see cref = "ISpStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpStreamFormat"/> instance to be converted </param>
    public static explicit operator ISpStream(Silk.NET.Windows.ISpStreamFormat value)
    {
        return new ISpStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpStream"/> to <see cref = "Silk.NET.Windows.ISpStreamFormat"/>.</summary>
    /// <param name = "value">The <see cref = "ISpStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpStreamFormat(ISpStream value)
    {
        return new Silk.NET.Windows.ISpStreamFormat(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IStream"/> to <see cref = "ISpStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IStream"/> instance to be converted </param>
    public static explicit operator ISpStream(Silk.NET.Windows.IStream value)
    {
        return new ISpStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpStream"/> to <see cref = "Silk.NET.Windows.IStream"/>.</summary>
    /// <param name = "value">The <see cref = "ISpStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IStream(ISpStream value)
    {
        return new Silk.NET.Windows.IStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISequentialStream"/> to <see cref = "ISpStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISequentialStream"/> instance to be converted </param>
    public static explicit operator ISpStream(Silk.NET.Windows.ISequentialStream value)
    {
        return new ISpStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpStream"/> to <see cref = "Silk.NET.Windows.ISequentialStream"/>.</summary>
    /// <param name = "value">The <see cref = "ISpStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISequentialStream(ISpStream value)
    {
        return new Silk.NET.Windows.ISequentialStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpStream(Silk.NET.Windows.IUnknown value)
    {
        return new ISpStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpStream"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpStream value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
