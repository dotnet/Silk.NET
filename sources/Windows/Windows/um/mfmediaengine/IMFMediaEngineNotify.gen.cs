// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFMediaEngineNotify.xml' path='doc/member[@name="IMFMediaEngineNotify"]/*' />
[Guid("FEE7C112-E776-42B5-9BBF-0048524E2BD5")]
[NativeTypeName("struct IMFMediaEngineNotify : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaEngineNotify : IMFMediaEngineNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineNotify));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineNotify*, uint>)(lpVtbl[1]))((IMFMediaEngineNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineNotify*, uint>)(lpVtbl[2]))((IMFMediaEngineNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineNotify.xml' path='doc/member[@name="IMFMediaEngineNotify.EventNotify"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EventNotify([NativeTypeName("DWORD")] uint @event, [NativeTypeName("DWORD_PTR")] nuint param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IMFMediaEngineNotify*, uint, nuint, uint, int>)(lpVtbl[3]))((IMFMediaEngineNotify*)Unsafe.AsPointer(ref this), @event, param1, param2);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EventNotify([NativeTypeName("DWORD")] uint @event, [NativeTypeName("DWORD_PTR")] nuint param1, [NativeTypeName("DWORD")] uint param2);
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

        [NativeTypeName("HRESULT (DWORD, DWORD_PTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, nuint, uint, int> EventNotify;
    }
}
