// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IProcessInitControl.xml' path='doc/member[@name="IProcessInitControl"]/*' />
[Guid("72380D55-8D2B-43A3-8513-2B6EF31434E9")]
[NativeTypeName("struct IProcessInitControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IProcessInitControl : IProcessInitControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProcessInitControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProcessInitControl*, Guid*, void**, int>)(lpVtbl[0]))((IProcessInitControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProcessInitControl*, uint>)(lpVtbl[1]))((IProcessInitControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProcessInitControl*, uint>)(lpVtbl[2]))((IProcessInitControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProcessInitControl.xml' path='doc/member[@name="IProcessInitControl.ResetInitializerTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ResetInitializerTimeout([NativeTypeName("DWORD")] uint dwSecondsRemaining)
    {
        return ((delegate* unmanaged<IProcessInitControl*, uint, int>)(lpVtbl[3]))((IProcessInitControl*)Unsafe.AsPointer(ref this), dwSecondsRemaining);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ResetInitializerTimeout([NativeTypeName("DWORD")] uint dwSecondsRemaining);
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ResetInitializerTimeout;
    }
}
