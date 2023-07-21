// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFMediaEventQueue.xml' path='doc/member[@name="IMFMediaEventQueue"]/*' />
[Guid("36F846FC-2256-48B6-B58E-E2B638316581")]
[NativeTypeName("struct IMFMediaEventQueue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEventQueue : IMFMediaEventQueue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEventQueue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEventQueue*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEventQueue*, uint>)(lpVtbl[1]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEventQueue*, uint>)(lpVtbl[2]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEventQueue.xml' path='doc/member[@name="IMFMediaEventQueue.GetEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaEventQueue*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
    }

    /// <include file='IMFMediaEventQueue.xml' path='doc/member[@name="IMFMediaEventQueue.BeginGetEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFMediaEventQueue*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), pCallback, punkState);
    }

    /// <include file='IMFMediaEventQueue.xml' path='doc/member[@name="IMFMediaEventQueue.EndGetEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaEventQueue*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), pResult, ppEvent);
    }

    /// <include file='IMFMediaEventQueue.xml' path='doc/member[@name="IMFMediaEventQueue.QueueEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueueEvent(IMFMediaEvent* pEvent)
    {
        return ((delegate* unmanaged<IMFMediaEventQueue*, IMFMediaEvent*, int>)(lpVtbl[6]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), pEvent);
    }

    /// <include file='IMFMediaEventQueue.xml' path='doc/member[@name="IMFMediaEventQueue.QueueEventParamVar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT QueueEventParamVar([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
    {
        return ((delegate* unmanaged<IMFMediaEventQueue*, uint, Guid*, HRESULT, PROPVARIANT*, int>)(lpVtbl[7]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
    }

    /// <include file='IMFMediaEventQueue.xml' path='doc/member[@name="IMFMediaEventQueue.QueueEventParamUnk"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT QueueEventParamUnk([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, IUnknown* pUnk)
    {
        return ((delegate* unmanaged<IMFMediaEventQueue*, uint, Guid*, HRESULT, IUnknown*, int>)(lpVtbl[8]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pUnk);
    }

    /// <include file='IMFMediaEventQueue.xml' path='doc/member[@name="IMFMediaEventQueue.Shutdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaEventQueue*, int>)(lpVtbl[9]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent);

        [VtblIndex(4)]
        HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState);

        [VtblIndex(5)]
        HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent);

        [VtblIndex(6)]
        HRESULT QueueEvent(IMFMediaEvent* pEvent);

        [VtblIndex(7)]
        HRESULT QueueEventParamVar([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue);

        [VtblIndex(8)]
        HRESULT QueueEventParamUnk([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, IUnknown* pUnk);

        [VtblIndex(9)]
        HRESULT Shutdown();
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

        [NativeTypeName("HRESULT (IMFMediaEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaEvent*, int> QueueEvent;

        [NativeTypeName("HRESULT (MediaEventType, const GUID &, HRESULT, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, HRESULT, PROPVARIANT*, int> QueueEventParamVar;

        [NativeTypeName("HRESULT (MediaEventType, const GUID &, HRESULT, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, HRESULT, IUnknown*, int> QueueEventParamUnk;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;
    }
}
