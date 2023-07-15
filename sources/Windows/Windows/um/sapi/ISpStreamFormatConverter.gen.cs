// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpStreamFormatConverter.xml' path='doc/member[@name="ISpStreamFormatConverter"]/*'/>
[Guid("678A932C-EA71-4446-9B41-78FDA6280A29")]
[NativeTypeName("struct ISpStreamFormatConverter : ISpStreamFormat")]
[NativeInheritance("ISpStreamFormat")]
public unsafe partial struct ISpStreamFormatConverter : ISpStreamFormatConverter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpStreamFormatConverter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, Guid*, void**, int> )(lpVtbl[0]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, uint> )(lpVtbl[1]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, uint> )(lpVtbl[2]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISequentialStream.Read"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, void*, uint, uint*, int> )(lpVtbl[3]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <inheritdoc cref = "ISequentialStream.Write"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, void*, uint, uint*, int> )(lpVtbl[4]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    /// <inheritdoc cref = "IStream.Seek"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> )(lpVtbl[5]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
    }

    /// <inheritdoc cref = "IStream.SetSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, ULARGE_INTEGER, int> )(lpVtbl[6]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), libNewSize);
    }

    /// <inheritdoc cref = "IStream.CopyTo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int> )(lpVtbl[7]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
    }

    /// <inheritdoc cref = "IStream.Commit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, uint, int> )(lpVtbl[8]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), grfCommitFlags);
    }

    /// <inheritdoc cref = "IStream.Revert"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, int> )(lpVtbl[9]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IStream.LockRegion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> )(lpVtbl[10]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref = "IStream.UnlockRegion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> )(lpVtbl[11]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref = "IStream.Stat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, STATSTG*, uint, int> )(lpVtbl[12]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
    }

    /// <inheritdoc cref = "IStream.Clone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream** ppstm)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, IStream**, int> )(lpVtbl[13]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ppstm);
    }

    /// <inheritdoc cref = "ISpStreamFormat.GetFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFormat(Guid* pguidFormatId, WAVEFORMATEX** ppCoMemWaveFormatEx)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, Guid*, WAVEFORMATEX**, int> )(lpVtbl[14]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pguidFormatId, ppCoMemWaveFormatEx);
    }

    /// <include file='ISpStreamFormatConverter.xml' path='doc/member[@name="ISpStreamFormatConverter.SetBaseStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetBaseStream(ISpStreamFormat* pStream, BOOL fSetFormatToBaseStreamFormat, BOOL fWriteToBaseStream)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, ISpStreamFormat*, BOOL, BOOL, int> )(lpVtbl[15]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), pStream, fSetFormatToBaseStreamFormat, fWriteToBaseStream);
    }

    /// <include file='ISpStreamFormatConverter.xml' path='doc/member[@name="ISpStreamFormatConverter.GetBaseStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetBaseStream(ISpStreamFormat** ppStream)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, ISpStreamFormat**, int> )(lpVtbl[16]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ppStream);
    }

    /// <include file='ISpStreamFormatConverter.xml' path='doc/member[@name="ISpStreamFormatConverter.SetFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetFormat([NativeTypeName("const GUID &")] Guid* rguidFormatIdOfConvertedStream, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatExOfConvertedStream)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, Guid*, WAVEFORMATEX*, int> )(lpVtbl[17]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), rguidFormatIdOfConvertedStream, pWaveFormatExOfConvertedStream);
    }

    /// <include file='ISpStreamFormatConverter.xml' path='doc/member[@name="ISpStreamFormatConverter.ResetSeekPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ResetSeekPosition()
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, int> )(lpVtbl[18]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpStreamFormatConverter.xml' path='doc/member[@name="ISpStreamFormatConverter.ScaleConvertedToBaseOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ScaleConvertedToBaseOffset([NativeTypeName("ULONGLONG")] ulong ullOffsetConvertedStream, [NativeTypeName("ULONGLONG *")] ulong* pullOffsetBaseStream)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, ulong, ulong*, int> )(lpVtbl[19]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ullOffsetConvertedStream, pullOffsetBaseStream);
    }

    /// <include file='ISpStreamFormatConverter.xml' path='doc/member[@name="ISpStreamFormatConverter.ScaleBaseToConvertedOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT ScaleBaseToConvertedOffset([NativeTypeName("ULONGLONG")] ulong ullOffsetBaseStream, [NativeTypeName("ULONGLONG *")] ulong* pullOffsetConvertedStream)
    {
        return ((delegate* unmanaged<ISpStreamFormatConverter*, ulong, ulong*, int> )(lpVtbl[20]))((ISpStreamFormatConverter*)Unsafe.AsPointer(ref this), ullOffsetBaseStream, pullOffsetConvertedStream);
    }

    public interface Interface : ISpStreamFormat.Interface
    {
        [VtblIndex(15)]
        HRESULT SetBaseStream(ISpStreamFormat* pStream, BOOL fSetFormatToBaseStreamFormat, BOOL fWriteToBaseStream);
        [VtblIndex(16)]
        HRESULT GetBaseStream(ISpStreamFormat** ppStream);
        [VtblIndex(17)]
        HRESULT SetFormat([NativeTypeName("const GUID &")] Guid* rguidFormatIdOfConvertedStream, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormatExOfConvertedStream);
        [VtblIndex(18)]
        HRESULT ResetSeekPosition();
        [VtblIndex(19)]
        HRESULT ScaleConvertedToBaseOffset([NativeTypeName("ULONGLONG")] ulong ullOffsetConvertedStream, [NativeTypeName("ULONGLONG *")] ulong* pullOffsetBaseStream);
        [VtblIndex(20)]
        HRESULT ScaleBaseToConvertedOffset([NativeTypeName("ULONGLONG")] ulong ullOffsetBaseStream, [NativeTypeName("ULONGLONG *")] ulong* pullOffsetConvertedStream);
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
        [NativeTypeName("HRESULT (ISpStreamFormat *, BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpStreamFormat*, BOOL, BOOL, int> SetBaseStream;
        [NativeTypeName("HRESULT (ISpStreamFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpStreamFormat**, int> GetBaseStream;
        [NativeTypeName("HRESULT (const GUID &, const WAVEFORMATEX *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, WAVEFORMATEX*, int> SetFormat;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetSeekPosition;
        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong*, int> ScaleConvertedToBaseOffset;
        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong*, int> ScaleBaseToConvertedOffset;
    }
}