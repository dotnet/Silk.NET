// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPipeLong.xml' path='doc/member[@name="IPipeLong"]/*' />
[Guid("DB2F3ACC-2F86-11D1-8E04-00C04FB9989A")]
[NativeTypeName("struct IPipeLong : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPipeLong : IPipeLong.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPipeLong));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPipeLong*, Guid*, void**, int>)(lpVtbl[0]))((IPipeLong*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPipeLong*, uint>)(lpVtbl[1]))((IPipeLong*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPipeLong*, uint>)(lpVtbl[2]))((IPipeLong*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPipeLong.xml' path='doc/member[@name="IPipeLong.Pull"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Pull([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned)
    {
        return ((delegate* unmanaged<IPipeLong*, int*, uint, uint*, int>)(lpVtbl[3]))((IPipeLong*)Unsafe.AsPointer(ref this), buf, cRequest, pcReturned);
    }

    /// <include file='IPipeLong.xml' path='doc/member[@name="IPipeLong.Push"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Push([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cSent)
    {
        return ((delegate* unmanaged<IPipeLong*, int*, uint, int>)(lpVtbl[4]))((IPipeLong*)Unsafe.AsPointer(ref this), buf, cSent);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Pull([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned);

        [VtblIndex(4)]
        HRESULT Push([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cSent);
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

        [NativeTypeName("HRESULT (LONG *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, uint, uint*, int> Pull;

        [NativeTypeName("HRESULT (LONG *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, uint, int> Push;
    }
}
