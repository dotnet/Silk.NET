// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ICoCreatedLocally.xml' path='doc/member[@name="ICoCreatedLocally"]/*' />
[Guid("0A53EB6C-1908-4742-8CFF-2CEE2E93F94C")]
[NativeTypeName("struct ICoCreatedLocally : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICoCreatedLocally : ICoCreatedLocally.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoCreatedLocally));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoCreatedLocally*, Guid*, void**, int>)(lpVtbl[0]))((ICoCreatedLocally*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICoCreatedLocally*, uint>)(lpVtbl[1]))((ICoCreatedLocally*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoCreatedLocally*, uint>)(lpVtbl[2]))((ICoCreatedLocally*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoCreatedLocally.xml' path='doc/member[@name="ICoCreatedLocally.LocalInit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LocalInit(IUnknown* punkLocalObject, [NativeTypeName("const IID &")] Guid* riidParam, IUnknown* punkParam, VARIANT varParam)
    {
        return ((delegate* unmanaged<ICoCreatedLocally*, IUnknown*, Guid*, IUnknown*, VARIANT, int>)(lpVtbl[3]))((ICoCreatedLocally*)Unsafe.AsPointer(ref this), punkLocalObject, riidParam, punkParam, varParam);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LocalInit(IUnknown* punkLocalObject, [NativeTypeName("const IID &")] Guid* riidParam, IUnknown* punkParam, VARIANT varParam);
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

        [NativeTypeName("HRESULT (IUnknown *, const IID &, IUnknown *, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, Guid*, IUnknown*, VARIANT, int> LocalInit;
    }
}
