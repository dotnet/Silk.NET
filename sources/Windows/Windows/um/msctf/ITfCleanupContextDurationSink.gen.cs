// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfCleanupContextDurationSink.xml' path='doc/member[@name="ITfCleanupContextDurationSink"]/*'/>
[Guid("45C35144-154E-4797-BED8-D33AE7BF8794")]
[NativeTypeName("struct ITfCleanupContextDurationSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCleanupContextDurationSink : ITfCleanupContextDurationSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCleanupContextDurationSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCleanupContextDurationSink*, Guid*, void**, int> )(lpVtbl[0]))((ITfCleanupContextDurationSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCleanupContextDurationSink*, uint> )(lpVtbl[1]))((ITfCleanupContextDurationSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCleanupContextDurationSink*, uint> )(lpVtbl[2]))((ITfCleanupContextDurationSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfCleanupContextDurationSink.xml' path='doc/member[@name="ITfCleanupContextDurationSink.OnStartCleanupContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnStartCleanupContext()
    {
        return ((delegate* unmanaged<ITfCleanupContextDurationSink*, int> )(lpVtbl[3]))((ITfCleanupContextDurationSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfCleanupContextDurationSink.xml' path='doc/member[@name="ITfCleanupContextDurationSink.OnEndCleanupContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnEndCleanupContext()
    {
        return ((delegate* unmanaged<ITfCleanupContextDurationSink*, int> )(lpVtbl[4]))((ITfCleanupContextDurationSink*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnStartCleanupContext();
        [VtblIndex(4)]
        HRESULT OnEndCleanupContext();
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnStartCleanupContext;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnEndCleanupContext;
    }
}