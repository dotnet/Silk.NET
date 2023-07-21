// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IEnumRegFilters.xml' path='doc/member[@name="IEnumRegFilters"]/*' />
[Guid("56A868A4-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IEnumRegFilters : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumRegFilters : IEnumRegFilters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumRegFilters));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumRegFilters*, Guid*, void**, int>)(lpVtbl[0]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumRegFilters*, uint>)(lpVtbl[1]))((IEnumRegFilters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumRegFilters*, uint>)(lpVtbl[2]))((IEnumRegFilters*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumRegFilters.xml' path='doc/member[@name="IEnumRegFilters.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint cFilters, REGFILTER** apRegFilter, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumRegFilters*, uint, REGFILTER**, uint*, int>)(lpVtbl[3]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), cFilters, apRegFilter, pcFetched);
    }

    /// <include file='IEnumRegFilters.xml' path='doc/member[@name="IEnumRegFilters.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cFilters)
    {
        return ((delegate* unmanaged<IEnumRegFilters*, uint, int>)(lpVtbl[4]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), cFilters);
    }

    /// <include file='IEnumRegFilters.xml' path='doc/member[@name="IEnumRegFilters.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumRegFilters*, int>)(lpVtbl[5]))((IEnumRegFilters*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumRegFilters.xml' path='doc/member[@name="IEnumRegFilters.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumRegFilters** ppEnum)
    {
        return ((delegate* unmanaged<IEnumRegFilters*, IEnumRegFilters**, int>)(lpVtbl[6]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint cFilters, REGFILTER** apRegFilter, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cFilters);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumRegFilters** ppEnum);
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

        [NativeTypeName("HRESULT (ULONG, REGFILTER **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, REGFILTER**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumRegFilters **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumRegFilters**, int> Clone;
    }
}
