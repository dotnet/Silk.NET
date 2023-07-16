// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpStreamFormat.xml' path='doc/member[@name="ISpStreamFormat"]/*'/>
[Guid("BED530BE-2606-4F4D-A1C0-54C5CDA5566F")]
[NativeTypeName("struct ISpStreamFormat : IStream")]
[NativeInheritance("IStream")]
public unsafe partial struct ISpStreamFormat : ISpStreamFormat.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpStreamFormat));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, Guid*, void**, int> )(lpVtbl[0]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpStreamFormat*, uint> )(lpVtbl[1]))((ISpStreamFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpStreamFormat*, uint> )(lpVtbl[2]))((ISpStreamFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISequentialStream.Read"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, void*, uint, uint*, int> )(lpVtbl[3]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <inheritdoc cref = "ISequentialStream.Write"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, void*, uint, uint*, int> )(lpVtbl[4]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    /// <inheritdoc cref = "IStream.Seek"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> )(lpVtbl[5]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
    }

    /// <inheritdoc cref = "IStream.SetSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, ULARGE_INTEGER, int> )(lpVtbl[6]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), libNewSize);
    }

    /// <inheritdoc cref = "IStream.CopyTo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int> )(lpVtbl[7]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
    }

    /// <inheritdoc cref = "IStream.Commit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, uint, int> )(lpVtbl[8]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), grfCommitFlags);
    }

    /// <inheritdoc cref = "IStream.Revert"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<ISpStreamFormat*, int> )(lpVtbl[9]))((ISpStreamFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IStream.LockRegion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> )(lpVtbl[10]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref = "IStream.UnlockRegion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> )(lpVtbl[11]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref = "IStream.Stat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, STATSTG*, uint, int> )(lpVtbl[12]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
    }

    /// <inheritdoc cref = "IStream.Clone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream** ppstm)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, IStream**, int> )(lpVtbl[13]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), ppstm);
    }

    /// <include file='ISpStreamFormat.xml' path='doc/member[@name="ISpStreamFormat.GetFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFormat(Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpStreamFormat*, Guid*, WAVEFORMATEX**, int> )(lpVtbl[14]))((ISpStreamFormat*)Unsafe.AsPointer(ref this), pguidFormatId, ppCoMemWaveFormatEx);
    }

    public interface Interface : IStream.Interface
    {
        [VtblIndex(14)]
        HRESULT GetFormat(Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx);
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
    }
}