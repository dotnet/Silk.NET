// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IStreamConcatenate.xml' path='doc/member[@name="IStreamConcatenate"]/*'/>
[Guid("27354146-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IStreamConcatenate : IStream")]
[NativeInheritance("IStream")]
public unsafe partial struct IStreamConcatenate : IStreamConcatenate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamConcatenate));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, Guid*, void**, int> )(lpVtbl[0]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStreamConcatenate*, uint> )(lpVtbl[1]))((IStreamConcatenate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamConcatenate*, uint> )(lpVtbl[2]))((IStreamConcatenate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISequentialStream.Read"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, void*, uint, uint*, int> )(lpVtbl[3]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <inheritdoc cref = "ISequentialStream.Write"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, void*, uint, uint*, int> )(lpVtbl[4]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    /// <inheritdoc cref = "IStream.Seek"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> )(lpVtbl[5]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
    }

    /// <inheritdoc cref = "IStream.SetSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, ULARGE_INTEGER, int> )(lpVtbl[6]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), libNewSize);
    }

    /// <inheritdoc cref = "IStream.CopyTo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int> )(lpVtbl[7]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
    }

    /// <inheritdoc cref = "IStream.Commit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, uint, int> )(lpVtbl[8]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), grfCommitFlags);
    }

    /// <inheritdoc cref = "IStream.Revert"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<IStreamConcatenate*, int> )(lpVtbl[9]))((IStreamConcatenate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IStream.LockRegion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> )(lpVtbl[10]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref = "IStream.UnlockRegion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> )(lpVtbl[11]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref = "IStream.Stat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, STATSTG*, uint, int> )(lpVtbl[12]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
    }

    /// <inheritdoc cref = "IStream.Clone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream** ppstm)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, IStream**, int> )(lpVtbl[13]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), ppstm);
    }

    /// <include file='IStreamConcatenate.xml' path='doc/member[@name="IStreamConcatenate.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Initialize(IStream* stream1, IStream* stream2)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, IStream*, IStream*, int> )(lpVtbl[14]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), stream1, stream2);
    }

    /// <include file='IStreamConcatenate.xml' path='doc/member[@name="IStreamConcatenate.Initialize2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Initialize2(IStream** streams, [NativeTypeName("ULONG")] uint streamCount)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, IStream**, uint, int> )(lpVtbl[15]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), streams, streamCount);
    }

    /// <include file='IStreamConcatenate.xml' path='doc/member[@name="IStreamConcatenate.Append"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Append(IStream* stream)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, IStream*, int> )(lpVtbl[16]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), stream);
    }

    /// <include file='IStreamConcatenate.xml' path='doc/member[@name="IStreamConcatenate.Append2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Append2(IStream** streams, [NativeTypeName("ULONG")] uint streamCount)
    {
        return ((delegate* unmanaged<IStreamConcatenate*, IStream**, uint, int> )(lpVtbl[17]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), streams, streamCount);
    }

    public interface Interface : IStream.Interface
    {
        [VtblIndex(14)]
        HRESULT Initialize(IStream* stream1, IStream* stream2);
        [VtblIndex(15)]
        HRESULT Initialize2(IStream** streams, [NativeTypeName("ULONG")] uint streamCount);
        [VtblIndex(16)]
        HRESULT Append(IStream* stream);
        [VtblIndex(17)]
        HRESULT Append2(IStream** streams, [NativeTypeName("ULONG")] uint streamCount);
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
        [NativeTypeName("HRESULT (IStream *, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, IStream*, int> Initialize;
        [NativeTypeName("HRESULT (IStream **, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream**, uint, int> Initialize2;
        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> Append;
        [NativeTypeName("HRESULT (IStream **, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream**, uint, int> Append2;
    }
}