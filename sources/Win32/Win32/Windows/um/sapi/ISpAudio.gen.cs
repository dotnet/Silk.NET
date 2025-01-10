// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C05C768F-FAE8-4EC2-8E07-338321C12452")]
[NativeTypeName("struct ISpAudio : ISpStreamFormat")]
[NativeInheritance("ISpStreamFormat")]
public unsafe partial struct ISpAudio : ISpAudio.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpAudio));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpAudio, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpAudio, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpAudio, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(
        void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbRead
    )
    {
        return ((delegate* unmanaged<ISpAudio, void*, uint, uint*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<ISpAudio, void*, uint, uint*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<ISpAudio, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)((*lpVtbl)[5])
        )(this, dlibMove, dwOrigin, plibNewPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged<ISpAudio, ULARGE_INTEGER, int>)((*lpVtbl)[6]))(
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
                ISpAudio,
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
        return ((delegate* unmanaged<ISpAudio, uint, int>)((*lpVtbl)[8]))(this, grfCommitFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<ISpAudio, int>)((*lpVtbl)[9]))(this);
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
            (delegate* unmanaged<ISpAudio, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
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
            (delegate* unmanaged<ISpAudio, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(
                (*lpVtbl)[11]
            )
        )(this, libOffset, cb, dwLockType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<ISpAudio, STATSTG*, uint, int>)((*lpVtbl)[12]))(
            this,
            pstatstg,
            grfStatFlag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream* ppstm)
    {
        return ((delegate* unmanaged<ISpAudio, IStream*, int>)((*lpVtbl)[13]))(this, ppstm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFormat(Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpAudio, Guid*, WAVEFORMATEX**, int>)((*lpVtbl)[14]))(
            this,
            pguidFormatId,
            ppCoMemWaveFormatEx
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetState(SPAUDIOSTATE NewState, [NativeTypeName("ULONGLONG")] ulong ullReserved)
    {
        return ((delegate* unmanaged<ISpAudio, SPAUDIOSTATE, ulong, int>)((*lpVtbl)[15]))(
            this,
            NewState,
            ullReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetFormat(
        [NativeTypeName("const GUID &")] Guid* rguidFmtId,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx
    )
    {
        return ((delegate* unmanaged<ISpAudio, Guid*, WAVEFORMATEX*, int>)((*lpVtbl)[16]))(
            this,
            rguidFmtId,
            pWaveFormatEx
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetStatus(SPAUDIOSTATUS* pStatus)
    {
        return ((delegate* unmanaged<ISpAudio, SPAUDIOSTATUS*, int>)((*lpVtbl)[17]))(this, pStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetBufferInfo(
        [NativeTypeName("const SPAUDIOBUFFERINFO *")] SPAUDIOBUFFERINFO* pBuffInfo
    )
    {
        return ((delegate* unmanaged<ISpAudio, SPAUDIOBUFFERINFO*, int>)((*lpVtbl)[18]))(
            this,
            pBuffInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetBufferInfo(SPAUDIOBUFFERINFO* pBuffInfo)
    {
        return ((delegate* unmanaged<ISpAudio, SPAUDIOBUFFERINFO*, int>)((*lpVtbl)[19]))(
            this,
            pBuffInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetDefaultFormat(Guid* pFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpAudio, Guid*, WAVEFORMATEX**, int>)((*lpVtbl)[20]))(
            this,
            pFormatId,
            ppCoMemWaveFormatEx
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HANDLE EventHandle()
    {
        return ((HANDLE)(((delegate* unmanaged<ISpAudio, void*>)((*lpVtbl)[21]))(this)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetVolumeLevel([NativeTypeName("ULONG *")] uint* pLevel)
    {
        return ((delegate* unmanaged<ISpAudio, uint*, int>)((*lpVtbl)[22]))(this, pLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetVolumeLevel([NativeTypeName("ULONG")] uint Level)
    {
        return ((delegate* unmanaged<ISpAudio, uint, int>)((*lpVtbl)[23]))(this, Level);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetBufferNotifySize([NativeTypeName("ULONG *")] uint* pcbSize)
    {
        return ((delegate* unmanaged<ISpAudio, uint*, int>)((*lpVtbl)[24]))(this, pcbSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetBufferNotifySize([NativeTypeName("ULONG")] uint cbSize)
    {
        return ((delegate* unmanaged<ISpAudio, uint, int>)((*lpVtbl)[25]))(this, cbSize);
    }

    public interface Interface : ISpStreamFormat.Interface
    {
        [VtblIndex(15)]
        HRESULT SetState(SPAUDIOSTATE NewState, [NativeTypeName("ULONGLONG")] ulong ullReserved);

        [VtblIndex(16)]
        HRESULT SetFormat(
            [NativeTypeName("const GUID &")] Guid* rguidFmtId,
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx
        );

        [VtblIndex(17)]
        HRESULT GetStatus(SPAUDIOSTATUS* pStatus);

        [VtblIndex(18)]
        HRESULT SetBufferInfo(
            [NativeTypeName("const SPAUDIOBUFFERINFO *")] SPAUDIOBUFFERINFO* pBuffInfo
        );

        [VtblIndex(19)]
        HRESULT GetBufferInfo(SPAUDIOBUFFERINFO* pBuffInfo);

        [VtblIndex(20)]
        HRESULT GetDefaultFormat(Guid* pFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx);

        [VtblIndex(21)]
        HANDLE EventHandle();

        [VtblIndex(22)]
        HRESULT GetVolumeLevel([NativeTypeName("ULONG *")] uint* pLevel);

        [VtblIndex(23)]
        HRESULT SetVolumeLevel([NativeTypeName("ULONG")] uint Level);

        [VtblIndex(24)]
        HRESULT GetBufferNotifySize([NativeTypeName("ULONG *")] uint* pcbSize);

        [VtblIndex(25)]
        HRESULT SetBufferNotifySize([NativeTypeName("ULONG")] uint cbSize);
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

        [NativeTypeName("HRESULT (SPAUDIOSTATE, ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPAUDIOSTATE, ulong, int> SetState;

        [NativeTypeName("HRESULT (const GUID &, const WAVEFORMATEX *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, WAVEFORMATEX*, int> SetFormat;

        [NativeTypeName("HRESULT (SPAUDIOSTATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPAUDIOSTATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (const SPAUDIOBUFFERINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPAUDIOBUFFERINFO*, int> SetBufferInfo;

        [NativeTypeName("HRESULT (SPAUDIOBUFFERINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPAUDIOBUFFERINFO*, int> GetBufferInfo;

        [NativeTypeName("HRESULT (GUID *, WAVEFORMATEX **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, WAVEFORMATEX**, int> GetDefaultFormat;

        [NativeTypeName("HANDLE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> EventHandle;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetVolumeLevel;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetVolumeLevel;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetBufferNotifySize;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetBufferNotifySize;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpAudio"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpAudio(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpStreamFormat"/> to <see cref = "ISpAudio"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpStreamFormat"/> instance to be converted </param>
    public static explicit operator ISpAudio(Silk.NET.Windows.ISpStreamFormat value)
    {
        return new ISpAudio(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpAudio"/> to <see cref = "Silk.NET.Windows.ISpStreamFormat"/>.</summary>
    /// <param name = "value">The <see cref = "ISpAudio"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpStreamFormat(ISpAudio value)
    {
        return new Silk.NET.Windows.ISpStreamFormat(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IStream"/> to <see cref = "ISpAudio"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IStream"/> instance to be converted </param>
    public static explicit operator ISpAudio(Silk.NET.Windows.IStream value)
    {
        return new ISpAudio(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpAudio"/> to <see cref = "Silk.NET.Windows.IStream"/>.</summary>
    /// <param name = "value">The <see cref = "ISpAudio"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IStream(ISpAudio value)
    {
        return new Silk.NET.Windows.IStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISequentialStream"/> to <see cref = "ISpAudio"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISequentialStream"/> instance to be converted </param>
    public static explicit operator ISpAudio(Silk.NET.Windows.ISequentialStream value)
    {
        return new ISpAudio(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpAudio"/> to <see cref = "Silk.NET.Windows.ISequentialStream"/>.</summary>
    /// <param name = "value">The <see cref = "ISpAudio"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISequentialStream(ISpAudio value)
    {
        return new Silk.NET.Windows.ISequentialStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpAudio"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpAudio(Silk.NET.Windows.IUnknown value)
    {
        return new ISpAudio(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpAudio"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpAudio"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpAudio value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
