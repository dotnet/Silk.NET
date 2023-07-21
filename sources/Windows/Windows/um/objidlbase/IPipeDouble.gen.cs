// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPipeDouble.xml' path='doc/member[@name="IPipeDouble"]/*' />
[Guid("DB2F3ACE-2F86-11D1-8E04-00C04FB9989A")]
[NativeTypeName("struct IPipeDouble : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPipeDouble : IPipeDouble.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPipeDouble));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPipeDouble*, Guid*, void**, int>)(lpVtbl[0]))((IPipeDouble*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPipeDouble*, uint>)(lpVtbl[1]))((IPipeDouble*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPipeDouble*, uint>)(lpVtbl[2]))((IPipeDouble*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPipeDouble.xml' path='doc/member[@name="IPipeDouble.Pull"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Pull(double* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned)
    {
        return ((delegate* unmanaged<IPipeDouble*, double*, uint, uint*, int>)(lpVtbl[3]))((IPipeDouble*)Unsafe.AsPointer(ref this), buf, cRequest, pcReturned);
    }

    /// <include file='IPipeDouble.xml' path='doc/member[@name="IPipeDouble.Push"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Push(double* buf, [NativeTypeName("ULONG")] uint cSent)
    {
        return ((delegate* unmanaged<IPipeDouble*, double*, uint, int>)(lpVtbl[4]))((IPipeDouble*)Unsafe.AsPointer(ref this), buf, cSent);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Pull(double* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned);

        [VtblIndex(4)]
        HRESULT Push(double* buf, [NativeTypeName("ULONG")] uint cSent);
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

        [NativeTypeName("HRESULT (DOUBLE *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, uint, uint*, int> Pull;

        [NativeTypeName("HRESULT (DOUBLE *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, uint, int> Push;
    }
}
