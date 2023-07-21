// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWaitMultiple.xml' path='doc/member[@name="IWaitMultiple"]/*' />
[Guid("0000002B-0000-0000-C000-000000000046")]
[NativeTypeName("struct IWaitMultiple : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWaitMultiple : IWaitMultiple.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWaitMultiple));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWaitMultiple*, Guid*, void**, int>)(lpVtbl[0]))((IWaitMultiple*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWaitMultiple*, uint>)(lpVtbl[1]))((IWaitMultiple*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWaitMultiple*, uint>)(lpVtbl[2]))((IWaitMultiple*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWaitMultiple.xml' path='doc/member[@name="IWaitMultiple.WaitMultiple"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT WaitMultiple([NativeTypeName("DWORD")] uint timeout, ISynchronize** pSync)
    {
        return ((delegate* unmanaged<IWaitMultiple*, uint, ISynchronize**, int>)(lpVtbl[3]))((IWaitMultiple*)Unsafe.AsPointer(ref this), timeout, pSync);
    }

    /// <include file='IWaitMultiple.xml' path='doc/member[@name="IWaitMultiple.AddSynchronize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddSynchronize(ISynchronize* pSync)
    {
        return ((delegate* unmanaged<IWaitMultiple*, ISynchronize*, int>)(lpVtbl[4]))((IWaitMultiple*)Unsafe.AsPointer(ref this), pSync);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT WaitMultiple([NativeTypeName("DWORD")] uint timeout, ISynchronize** pSync);

        [VtblIndex(4)]
        HRESULT AddSynchronize(ISynchronize* pSync);
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

        [NativeTypeName("HRESULT (DWORD, ISynchronize **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ISynchronize**, int> WaitMultiple;

        [NativeTypeName("HRESULT (ISynchronize *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISynchronize*, int> AddSynchronize;
    }
}
