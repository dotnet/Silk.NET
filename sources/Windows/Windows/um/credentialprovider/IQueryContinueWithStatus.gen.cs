// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IQueryContinueWithStatus.xml' path='doc/member[@name="IQueryContinueWithStatus"]/*' />
[Guid("9090BE5B-502B-41FB-BCCC-0049A6C7254B")]
[NativeTypeName("struct IQueryContinueWithStatus : IQueryContinue")]
[NativeInheritance("IQueryContinue")]
public unsafe partial struct IQueryContinueWithStatus : IQueryContinueWithStatus.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueryContinueWithStatus));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQueryContinueWithStatus*, Guid*, void**, int>)(lpVtbl[0]))((IQueryContinueWithStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IQueryContinueWithStatus*, uint>)(lpVtbl[1]))((IQueryContinueWithStatus*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQueryContinueWithStatus*, uint>)(lpVtbl[2]))((IQueryContinueWithStatus*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IQueryContinue.QueryContinue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryContinue()
    {
        return ((delegate* unmanaged<IQueryContinueWithStatus*, int>)(lpVtbl[3]))((IQueryContinueWithStatus*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IQueryContinueWithStatus.xml' path='doc/member[@name="IQueryContinueWithStatus.SetStatusMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetStatusMessage([NativeTypeName("LPCWSTR")] ushort* psz)
    {
        return ((delegate* unmanaged<IQueryContinueWithStatus*, ushort*, int>)(lpVtbl[4]))((IQueryContinueWithStatus*)Unsafe.AsPointer(ref this), psz);
    }

    public interface Interface : IQueryContinue.Interface
    {
        [VtblIndex(4)]
        HRESULT SetStatusMessage([NativeTypeName("LPCWSTR")] ushort* psz);
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
        public delegate* unmanaged<TSelf*, int> QueryContinue;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetStatusMessage;
    }
}
