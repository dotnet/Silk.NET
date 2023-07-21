// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IEnumRegisterWordA.xml' path='doc/member[@name="IEnumRegisterWordA"]/*' />
[Guid("08C03412-F96B-11D0-A475-00AA006BCC59")]
[NativeTypeName("struct IEnumRegisterWordA : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumRegisterWordA : IEnumRegisterWordA.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumRegisterWordA));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumRegisterWordA*, Guid*, void**, int>)(lpVtbl[0]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumRegisterWordA*, uint>)(lpVtbl[1]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumRegisterWordA*, uint>)(lpVtbl[2]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumRegisterWordA.xml' path='doc/member[@name="IEnumRegisterWordA.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumRegisterWordA** ppEnum)
    {
        return ((delegate* unmanaged<IEnumRegisterWordA*, IEnumRegisterWordA**, int>)(lpVtbl[3]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumRegisterWordA.xml' path='doc/member[@name="IEnumRegisterWordA.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, REGISTERWORDA* rgRegisterWord, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumRegisterWordA*, uint, REGISTERWORDA*, uint*, int>)(lpVtbl[4]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this), ulCount, rgRegisterWord, pcFetched);
    }

    /// <include file='IEnumRegisterWordA.xml' path='doc/member[@name="IEnumRegisterWordA.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumRegisterWordA*, int>)(lpVtbl[5]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumRegisterWordA.xml' path='doc/member[@name="IEnumRegisterWordA.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumRegisterWordA*, uint, int>)(lpVtbl[6]))((IEnumRegisterWordA*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumRegisterWordA** ppEnum);

        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, REGISTERWORDA* rgRegisterWord, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
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

        [NativeTypeName("HRESULT (IEnumRegisterWordA **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumRegisterWordA**, int> Clone;

        [NativeTypeName("HRESULT (ULONG, REGISTERWORDA *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, REGISTERWORDA*, uint*, int> Next;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}
