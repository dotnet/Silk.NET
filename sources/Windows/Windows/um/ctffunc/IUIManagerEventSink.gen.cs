// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IUIManagerEventSink.xml' path='doc/member[@name="IUIManagerEventSink"]/*' />
[Guid("CD91D690-A7E8-4265-9B38-8BB3BBABA7DE")]
[NativeTypeName("struct IUIManagerEventSink : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IUIManagerEventSink : IUIManagerEventSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIManagerEventSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIManagerEventSink*, Guid*, void**, int>)(lpVtbl[0]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIManagerEventSink*, uint>)(lpVtbl[1]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIManagerEventSink*, uint>)(lpVtbl[2]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIManagerEventSink.xml' path='doc/member[@name="IUIManagerEventSink.OnWindowOpening"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnWindowOpening(RECT* prcBounds)
    {
        return ((delegate* unmanaged<IUIManagerEventSink*, RECT*, int>)(lpVtbl[3]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this), prcBounds);
    }

    /// <include file='IUIManagerEventSink.xml' path='doc/member[@name="IUIManagerEventSink.OnWindowOpened"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnWindowOpened(RECT* prcBounds)
    {
        return ((delegate* unmanaged<IUIManagerEventSink*, RECT*, int>)(lpVtbl[4]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this), prcBounds);
    }

    /// <include file='IUIManagerEventSink.xml' path='doc/member[@name="IUIManagerEventSink.OnWindowUpdating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnWindowUpdating(RECT* prcUpdatedBounds)
    {
        return ((delegate* unmanaged<IUIManagerEventSink*, RECT*, int>)(lpVtbl[5]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this), prcUpdatedBounds);
    }

    /// <include file='IUIManagerEventSink.xml' path='doc/member[@name="IUIManagerEventSink.OnWindowUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnWindowUpdated(RECT* prcUpdatedBounds)
    {
        return ((delegate* unmanaged<IUIManagerEventSink*, RECT*, int>)(lpVtbl[6]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this), prcUpdatedBounds);
    }

    /// <include file='IUIManagerEventSink.xml' path='doc/member[@name="IUIManagerEventSink.OnWindowClosing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnWindowClosing()
    {
        return ((delegate* unmanaged<IUIManagerEventSink*, int>)(lpVtbl[7]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIManagerEventSink.xml' path='doc/member[@name="IUIManagerEventSink.OnWindowClosed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnWindowClosed()
    {
        return ((delegate* unmanaged<IUIManagerEventSink*, int>)(lpVtbl[8]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnWindowOpening(RECT* prcBounds);

        [VtblIndex(4)]
        HRESULT OnWindowOpened(RECT* prcBounds);

        [VtblIndex(5)]
        HRESULT OnWindowUpdating(RECT* prcUpdatedBounds);

        [VtblIndex(6)]
        HRESULT OnWindowUpdated(RECT* prcUpdatedBounds);

        [VtblIndex(7)]
        HRESULT OnWindowClosing();

        [VtblIndex(8)]
        HRESULT OnWindowClosed();
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

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> OnWindowOpening;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> OnWindowOpened;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> OnWindowUpdating;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> OnWindowUpdated;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnWindowClosing;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnWindowClosed;
    }
}
