// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFMediaEngineNeedKeyNotify.xml' path='doc/member[@name="IMFMediaEngineNeedKeyNotify"]/*' />
[Guid("46A30204-A696-4B18-8804-246B8F031BB1")]
[NativeTypeName("struct IMFMediaEngineNeedKeyNotify : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFMediaEngineNeedKeyNotify : IMFMediaEngineNeedKeyNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineNeedKeyNotify));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineNeedKeyNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineNeedKeyNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineNeedKeyNotify*, uint>)(lpVtbl[1]))((IMFMediaEngineNeedKeyNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineNeedKeyNotify*, uint>)(lpVtbl[2]))((IMFMediaEngineNeedKeyNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineNeedKeyNotify.xml' path='doc/member[@name="IMFMediaEngineNeedKeyNotify.NeedKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void NeedKey([NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint cb)
    {
        ((delegate* unmanaged<IMFMediaEngineNeedKeyNotify*, byte*, uint, void>)(lpVtbl[3]))((IMFMediaEngineNeedKeyNotify*)Unsafe.AsPointer(ref this), initData, cb);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void NeedKey([NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint cb);
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

        [NativeTypeName("void (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, void> NeedKey;
    }
}
