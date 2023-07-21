// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IEnumConnectionPoints.xml' path='doc/member[@name="IEnumConnectionPoints"]/*' />
[Guid("B196B285-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct IEnumConnectionPoints : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumConnectionPoints : IEnumConnectionPoints.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumConnectionPoints));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumConnectionPoints*, Guid*, void**, int>)(lpVtbl[0]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumConnectionPoints*, uint>)(lpVtbl[1]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumConnectionPoints*, uint>)(lpVtbl[2]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumConnectionPoints.xml' path='doc/member[@name="IEnumConnectionPoints.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint cConnections, [NativeTypeName("LPCONNECTIONPOINT *")] IConnectionPoint** ppCP, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int>)(lpVtbl[3]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), cConnections, ppCP, pcFetched);
    }

    /// <include file='IEnumConnectionPoints.xml' path='doc/member[@name="IEnumConnectionPoints.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cConnections)
    {
        return ((delegate* unmanaged<IEnumConnectionPoints*, uint, int>)(lpVtbl[4]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), cConnections);
    }

    /// <include file='IEnumConnectionPoints.xml' path='doc/member[@name="IEnumConnectionPoints.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumConnectionPoints*, int>)(lpVtbl[5]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumConnectionPoints.xml' path='doc/member[@name="IEnumConnectionPoints.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumConnectionPoints** ppEnum)
    {
        return ((delegate* unmanaged<IEnumConnectionPoints*, IEnumConnectionPoints**, int>)(lpVtbl[6]))((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint cConnections, [NativeTypeName("LPCONNECTIONPOINT *")] IConnectionPoint** ppCP, [NativeTypeName("ULONG *")] uint* pcFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cConnections);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumConnectionPoints** ppEnum);
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

        [NativeTypeName("HRESULT (ULONG, LPCONNECTIONPOINT *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IConnectionPoint**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumConnectionPoints **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumConnectionPoints**, int> Clone;
    }
}
