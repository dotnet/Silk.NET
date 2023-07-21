// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IUnsecuredApartment.xml' path='doc/member[@name="IUnsecuredApartment"]/*' />
[Guid("1CFABA8C-1523-11D1-AD79-00C04FD8FDFF")]
[NativeTypeName("struct IUnsecuredApartment : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUnsecuredApartment : IUnsecuredApartment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUnsecuredApartment));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUnsecuredApartment*, Guid*, void**, int>)(lpVtbl[0]))((IUnsecuredApartment*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUnsecuredApartment*, uint>)(lpVtbl[1]))((IUnsecuredApartment*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUnsecuredApartment*, uint>)(lpVtbl[2]))((IUnsecuredApartment*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUnsecuredApartment.xml' path='doc/member[@name="IUnsecuredApartment.CreateObjectStub"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateObjectStub(IUnknown* pObject, IUnknown** ppStub)
    {
        return ((delegate* unmanaged<IUnsecuredApartment*, IUnknown*, IUnknown**, int>)(lpVtbl[3]))((IUnsecuredApartment*)Unsafe.AsPointer(ref this), pObject, ppStub);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateObjectStub(IUnknown* pObject, IUnknown** ppStub);
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

        [NativeTypeName("HRESULT (IUnknown *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IUnknown**, int> CreateObjectStub;
    }
}
