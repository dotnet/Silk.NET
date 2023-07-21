// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMediaEventSink.xml' path='doc/member[@name="IMediaEventSink"]/*' />
[Guid("56A868A2-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMediaEventSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMediaEventSink : IMediaEventSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaEventSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaEventSink*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaEventSink*, uint>)(lpVtbl[1]))((IMediaEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaEventSink*, uint>)(lpVtbl[2]))((IMediaEventSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaEventSink.xml' path='doc/member[@name="IMediaEventSink.Notify"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Notify([NativeTypeName("long")] int EventCode, [NativeTypeName("LONG_PTR")] nint EventParam1, [NativeTypeName("LONG_PTR")] nint EventParam2)
    {
        return ((delegate* unmanaged<IMediaEventSink*, int, nint, nint, int>)(lpVtbl[3]))((IMediaEventSink*)Unsafe.AsPointer(ref this), EventCode, EventParam1, EventParam2);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Notify([NativeTypeName("long")] int EventCode, [NativeTypeName("LONG_PTR")] nint EventParam1, [NativeTypeName("LONG_PTR")] nint EventParam2);
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

        [NativeTypeName("HRESULT (long, LONG_PTR, LONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, nint, nint, int> Notify;
    }
}
