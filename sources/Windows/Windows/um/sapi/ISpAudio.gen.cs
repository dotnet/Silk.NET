// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio"]/*' />
[Guid("C05C768F-FAE8-4EC2-8E07-338321C12452")]
[NativeTypeName("struct ISpAudio : ISpStreamFormat")]
[NativeInheritance("ISpStreamFormat")]
public unsafe partial struct ISpAudio : ISpAudio.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpAudio));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpAudio*, Guid*, void**, int>)(lpVtbl[0]))((ISpAudio*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpAudio*, uint>)(lpVtbl[1]))((ISpAudio*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpAudio*, uint>)(lpVtbl[2]))((ISpAudio*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISequentialStream.Read" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged<ISpAudio*, void*, uint, uint*, int>)(lpVtbl[3]))((ISpAudio*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <inheritdoc cref="ISequentialStream.Write" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged<ISpAudio*, void*, uint, uint*, int>)(lpVtbl[4]))((ISpAudio*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    /// <inheritdoc cref="IStream.Seek" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
    {
        return ((delegate* unmanaged<ISpAudio*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((ISpAudio*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
    }

    /// <inheritdoc cref="IStream.SetSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged<ISpAudio*, ULARGE_INTEGER, int>)(lpVtbl[6]))((ISpAudio*)Unsafe.AsPointer(ref this), libNewSize);
    }

    /// <inheritdoc cref="IStream.CopyTo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
    {
        return ((delegate* unmanaged<ISpAudio*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((ISpAudio*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
    }

    /// <inheritdoc cref="IStream.Commit" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged<ISpAudio*, uint, int>)(lpVtbl[8]))((ISpAudio*)Unsafe.AsPointer(ref this), grfCommitFlags);
    }

    /// <inheritdoc cref="IStream.Revert" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<ISpAudio*, int>)(lpVtbl[9]))((ISpAudio*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IStream.LockRegion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged<ISpAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((ISpAudio*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref="IStream.UnlockRegion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged<ISpAudio*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((ISpAudio*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref="IStream.Stat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<ISpAudio*, STATSTG*, uint, int>)(lpVtbl[12]))((ISpAudio*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
    }

    /// <inheritdoc cref="IStream.Clone" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream** ppstm)
    {
        return ((delegate* unmanaged<ISpAudio*, IStream**, int>)(lpVtbl[13]))((ISpAudio*)Unsafe.AsPointer(ref this), ppstm);
    }

    /// <inheritdoc cref="ISpStreamFormat.GetFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFormat(Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpAudio*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[14]))((ISpAudio*)Unsafe.AsPointer(ref this), pguidFormatId, ppCoMemWaveFormatEx);
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.SetState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetState(SPAUDIOSTATE NewState, [NativeTypeName("ULONGLONG")] ulong ullReserved)
    {
        return ((delegate* unmanaged<ISpAudio*, SPAUDIOSTATE, ulong, int>)(lpVtbl[15]))((ISpAudio*)Unsafe.AsPointer(ref this), NewState, ullReserved);
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.SetFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetFormat([NativeTypeName("const GUID &")] Guid* rguidFmtId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpAudio*, Guid*, WAVEFORMATEX*, int>)(lpVtbl[16]))((ISpAudio*)Unsafe.AsPointer(ref this), rguidFmtId, pWaveFormatEx);
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.GetStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetStatus(SPAUDIOSTATUS* pStatus)
    {
        return ((delegate* unmanaged<ISpAudio*, SPAUDIOSTATUS*, int>)(lpVtbl[17]))((ISpAudio*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.SetBufferInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetBufferInfo([NativeTypeName("const SPAUDIOBUFFERINFO *")] SPAUDIOBUFFERINFO* pBuffInfo)
    {
        return ((delegate* unmanaged<ISpAudio*, SPAUDIOBUFFERINFO*, int>)(lpVtbl[18]))((ISpAudio*)Unsafe.AsPointer(ref this), pBuffInfo);
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.GetBufferInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetBufferInfo(SPAUDIOBUFFERINFO* pBuffInfo)
    {
        return ((delegate* unmanaged<ISpAudio*, SPAUDIOBUFFERINFO*, int>)(lpVtbl[19]))((ISpAudio*)Unsafe.AsPointer(ref this), pBuffInfo);
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.GetDefaultFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetDefaultFormat(Guid* pFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpAudio*, Guid*, WAVEFORMATEX**, int>)(lpVtbl[20]))((ISpAudio*)Unsafe.AsPointer(ref this), pFormatId, ppCoMemWaveFormatEx);
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.EventHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HANDLE EventHandle()
    {
        return ((HANDLE)(((delegate* unmanaged<ISpAudio*, void*>)(lpVtbl[21]))((ISpAudio*)Unsafe.AsPointer(ref this))));
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.GetVolumeLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetVolumeLevel([NativeTypeName("ULONG *")] uint* pLevel)
    {
        return ((delegate* unmanaged<ISpAudio*, uint*, int>)(lpVtbl[22]))((ISpAudio*)Unsafe.AsPointer(ref this), pLevel);
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.SetVolumeLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetVolumeLevel([NativeTypeName("ULONG")] uint Level)
    {
        return ((delegate* unmanaged<ISpAudio*, uint, int>)(lpVtbl[23]))((ISpAudio*)Unsafe.AsPointer(ref this), Level);
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.GetBufferNotifySize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetBufferNotifySize([NativeTypeName("ULONG *")] uint* pcbSize)
    {
        return ((delegate* unmanaged<ISpAudio*, uint*, int>)(lpVtbl[24]))((ISpAudio*)Unsafe.AsPointer(ref this), pcbSize);
    }

    /// <include file='ISpAudio.xml' path='doc/member[@name="ISpAudio.SetBufferNotifySize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetBufferNotifySize([NativeTypeName("ULONG")] uint cbSize)
    {
        return ((delegate* unmanaged<ISpAudio*, uint, int>)(lpVtbl[25]))((ISpAudio*)Unsafe.AsPointer(ref this), cbSize);
    }

    public interface Interface : ISpStreamFormat.Interface
    {
        [VtblIndex(15)]
        HRESULT SetState(SPAUDIOSTATE NewState, [NativeTypeName("ULONGLONG")] ulong ullReserved);

        [VtblIndex(16)]
        HRESULT SetFormat([NativeTypeName("const GUID &")] Guid* rguidFmtId, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatEx);

        [VtblIndex(17)]
        HRESULT GetStatus(SPAUDIOSTATUS* pStatus);

        [VtblIndex(18)]
        HRESULT SetBufferInfo([NativeTypeName("const SPAUDIOBUFFERINFO *")] SPAUDIOBUFFERINFO* pBuffInfo);

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

        [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> Seek;

        [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, int> SetSize;

        [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER *, ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int> CopyTo;

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
        public delegate* unmanaged<TSelf*, IStream**, int> Clone;

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
}
