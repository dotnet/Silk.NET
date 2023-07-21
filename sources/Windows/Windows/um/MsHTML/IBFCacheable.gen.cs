// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IBFCacheable.xml' path='doc/member[@name="IBFCacheable"]/*' />
[Guid("30510861-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IBFCacheable : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBFCacheable : IBFCacheable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBFCacheable));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBFCacheable*, Guid*, void**, int>)(lpVtbl[0]))((IBFCacheable*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBFCacheable*, uint>)(lpVtbl[1]))((IBFCacheable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBFCacheable*, uint>)(lpVtbl[2]))((IBFCacheable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBFCacheable.xml' path='doc/member[@name="IBFCacheable.EnterBFCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnterBFCache()
    {
        return ((delegate* unmanaged<IBFCacheable*, int>)(lpVtbl[3]))((IBFCacheable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBFCacheable.xml' path='doc/member[@name="IBFCacheable.ExitBFCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ExitBFCache()
    {
        return ((delegate* unmanaged<IBFCacheable*, int>)(lpVtbl[4]))((IBFCacheable*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnterBFCache();

        [VtblIndex(4)]
        HRESULT ExitBFCache();
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
        public delegate* unmanaged<TSelf*, int> EnterBFCache;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ExitBFCache;
    }
}
