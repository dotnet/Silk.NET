// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfMouseTrackerACP.xml' path='doc/member[@name="ITfMouseTrackerACP"]/*' />
[Guid("3BDD78E2-C16E-47FD-B883-CE6FACC1A208")]
[NativeTypeName("struct ITfMouseTrackerACP : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfMouseTrackerACP : ITfMouseTrackerACP.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfMouseTrackerACP));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfMouseTrackerACP*, Guid*, void**, int>)(lpVtbl[0]))((ITfMouseTrackerACP*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfMouseTrackerACP*, uint>)(lpVtbl[1]))((ITfMouseTrackerACP*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfMouseTrackerACP*, uint>)(lpVtbl[2]))((ITfMouseTrackerACP*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfMouseTrackerACP.xml' path='doc/member[@name="ITfMouseTrackerACP.AdviseMouseSink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseMouseSink(ITfRangeACP* range, ITfMouseSink* pSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<ITfMouseTrackerACP*, ITfRangeACP*, ITfMouseSink*, uint*, int>)(lpVtbl[3]))((ITfMouseTrackerACP*)Unsafe.AsPointer(ref this), range, pSink, pdwCookie);
    }

    /// <include file='ITfMouseTrackerACP.xml' path='doc/member[@name="ITfMouseTrackerACP.UnadviseMouseSink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnadviseMouseSink([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<ITfMouseTrackerACP*, uint, int>)(lpVtbl[4]))((ITfMouseTrackerACP*)Unsafe.AsPointer(ref this), dwCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AdviseMouseSink(ITfRangeACP* range, ITfMouseSink* pSink, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [VtblIndex(4)]
        HRESULT UnadviseMouseSink([NativeTypeName("DWORD")] uint dwCookie);
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

        [NativeTypeName("HRESULT (ITfRangeACP *, ITfMouseSink *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRangeACP*, ITfMouseSink*, uint*, int> AdviseMouseSink;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnadviseMouseSink;
    }
}
