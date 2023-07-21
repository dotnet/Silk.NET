// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFMediaStream.xml' path='doc/member[@name="IMFMediaStream"]/*' />
[Guid("D182108F-4EC6-443F-AA42-A71106EC825F")]
[NativeTypeName("struct IMFMediaStream : IMFMediaEventGenerator")]
[NativeInheritance("IMFMediaEventGenerator")]
public unsafe partial struct IMFMediaStream : IMFMediaStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaStream));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaStream*, uint>)(lpVtbl[1]))((IMFMediaStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaStream*, uint>)(lpVtbl[2]))((IMFMediaStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEventGenerator.GetEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaStream*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaStream*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
    }

    /// <inheritdoc cref="IMFMediaEventGenerator.BeginGetEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFMediaStream*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaStream*)Unsafe.AsPointer(ref this), pCallback, punkState);
    }

    /// <inheritdoc cref="IMFMediaEventGenerator.EndGetEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaStream*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaStream*)Unsafe.AsPointer(ref this), pResult, ppEvent);
    }

    /// <inheritdoc cref="IMFMediaEventGenerator.QueueEvent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
    {
        return ((delegate* unmanaged<IMFMediaStream*, uint, Guid*, HRESULT, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaStream*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
    }

    /// <include file='IMFMediaStream.xml' path='doc/member[@name="IMFMediaStream.GetMediaSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMediaSource(IMFMediaSource** ppMediaSource)
    {
        return ((delegate* unmanaged<IMFMediaStream*, IMFMediaSource**, int>)(lpVtbl[7]))((IMFMediaStream*)Unsafe.AsPointer(ref this), ppMediaSource);
    }

    /// <include file='IMFMediaStream.xml' path='doc/member[@name="IMFMediaStream.GetStreamDescriptor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStreamDescriptor(IMFStreamDescriptor** ppStreamDescriptor)
    {
        return ((delegate* unmanaged<IMFMediaStream*, IMFStreamDescriptor**, int>)(lpVtbl[8]))((IMFMediaStream*)Unsafe.AsPointer(ref this), ppStreamDescriptor);
    }

    /// <include file='IMFMediaStream.xml' path='doc/member[@name="IMFMediaStream.RequestSample"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestSample(IUnknown* pToken)
    {
        return ((delegate* unmanaged<IMFMediaStream*, IUnknown*, int>)(lpVtbl[9]))((IMFMediaStream*)Unsafe.AsPointer(ref this), pToken);
    }

    public interface Interface : IMFMediaEventGenerator.Interface
    {
        [VtblIndex(7)]
        HRESULT GetMediaSource(IMFMediaSource** ppMediaSource);

        [VtblIndex(8)]
        HRESULT GetStreamDescriptor(IMFStreamDescriptor** ppStreamDescriptor);

        [VtblIndex(9)]
        HRESULT RequestSample(IUnknown* pToken);
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

        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaEvent**, int> GetEvent;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback*, IUnknown*, int> BeginGetEvent;

        [NativeTypeName("HRESULT (IMFAsyncResult *, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, IMFMediaEvent**, int> EndGetEvent;

        [NativeTypeName("HRESULT (MediaEventType, const GUID &, HRESULT, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, HRESULT, PROPVARIANT*, int> QueueEvent;

        [NativeTypeName("HRESULT (IMFMediaSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaSource**, int> GetMediaSource;

        [NativeTypeName("HRESULT (IMFStreamDescriptor **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFStreamDescriptor**, int> GetStreamDescriptor;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> RequestSample;
    }
}
