// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFFinalizableMediaSink.xml' path='doc/member[@name="IMFFinalizableMediaSink"]/*' />
[Guid("EAECB74A-9A50-42CE-9541-6A7F57AA4AD7")]
[NativeTypeName("struct IMFFinalizableMediaSink : IMFMediaSink")]
[NativeInheritance("IMFMediaSink")]
public unsafe partial struct IMFFinalizableMediaSink : IMFFinalizableMediaSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFFinalizableMediaSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint>)(lpVtbl[1]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint>)(lpVtbl[2]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaSink.GetCharacteristics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint*, int>)(lpVtbl[3]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), pdwCharacteristics);
    }

    /// <inheritdoc cref="IMFMediaSink.AddStreamSink" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier, IMFMediaType* pMediaType, IMFStreamSink** ppStreamSink)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint, IMFMediaType*, IMFStreamSink**, int>)(lpVtbl[4]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier, pMediaType, ppStreamSink);
    }

    /// <inheritdoc cref="IMFMediaSink.RemoveStreamSink" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemoveStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint, int>)(lpVtbl[5]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier);
    }

    /// <inheritdoc cref="IMFMediaSink.GetStreamSinkCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStreamSinkCount([NativeTypeName("DWORD *")] uint* pcStreamSinkCount)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint*, int>)(lpVtbl[6]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), pcStreamSinkCount);
    }

    /// <inheritdoc cref="IMFMediaSink.GetStreamSinkByIndex" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetStreamSinkByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFStreamSink** ppStreamSink)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint, IMFStreamSink**, int>)(lpVtbl[7]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), dwIndex, ppStreamSink);
    }

    /// <inheritdoc cref="IMFMediaSink.GetStreamSinkById" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStreamSinkById([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier, IMFStreamSink** ppStreamSink)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint, IMFStreamSink**, int>)(lpVtbl[8]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier, ppStreamSink);
    }

    /// <inheritdoc cref="IMFMediaSink.SetPresentationClock" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetPresentationClock(IMFPresentationClock* pPresentationClock)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, IMFPresentationClock*, int>)(lpVtbl[9]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), pPresentationClock);
    }

    /// <inheritdoc cref="IMFMediaSink.GetPresentationClock" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPresentationClock(IMFPresentationClock** ppPresentationClock)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, IMFPresentationClock**, int>)(lpVtbl[10]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), ppPresentationClock);
    }

    /// <inheritdoc cref="IMFMediaSink.Shutdown" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, int>)(lpVtbl[11]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFFinalizableMediaSink.xml' path='doc/member[@name="IMFFinalizableMediaSink.BeginFinalize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT BeginFinalize(IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[12]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), pCallback, punkState);
    }

    /// <include file='IMFFinalizableMediaSink.xml' path='doc/member[@name="IMFFinalizableMediaSink.EndFinalize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EndFinalize(IMFAsyncResult* pResult)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink*, IMFAsyncResult*, int>)(lpVtbl[13]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), pResult);
    }

    public interface Interface : IMFMediaSink.Interface
    {
        [VtblIndex(12)]
        HRESULT BeginFinalize(IMFAsyncCallback* pCallback, IUnknown* punkState);

        [VtblIndex(13)]
        HRESULT EndFinalize(IMFAsyncResult* pResult);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCharacteristics;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, IMFStreamSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, IMFStreamSink**, int> AddStreamSink;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveStreamSink;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStreamSinkCount;

        [NativeTypeName("HRESULT (DWORD, IMFStreamSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFStreamSink**, int> GetStreamSinkByIndex;

        [NativeTypeName("HRESULT (DWORD, IMFStreamSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFStreamSink**, int> GetStreamSinkById;

        [NativeTypeName("HRESULT (IMFPresentationClock *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationClock*, int> SetPresentationClock;

        [NativeTypeName("HRESULT (IMFPresentationClock **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationClock**, int> GetPresentationClock;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback*, IUnknown*, int> BeginFinalize;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, int> EndFinalize;
    }
}
