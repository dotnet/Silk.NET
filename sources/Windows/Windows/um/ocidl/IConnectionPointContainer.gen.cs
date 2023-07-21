// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IConnectionPointContainer.xml' path='doc/member[@name="IConnectionPointContainer"]/*' />
[Guid("B196B284-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct IConnectionPointContainer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IConnectionPointContainer : IConnectionPointContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionPointContainer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConnectionPointContainer*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IConnectionPointContainer*, uint>)(lpVtbl[1]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConnectionPointContainer*, uint>)(lpVtbl[2]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IConnectionPointContainer.xml' path='doc/member[@name="IConnectionPointContainer.EnumConnectionPoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumConnectionPoints(IEnumConnectionPoints** ppEnum)
    {
        return ((delegate* unmanaged<IConnectionPointContainer*, IEnumConnectionPoints**, int>)(lpVtbl[3]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IConnectionPointContainer.xml' path='doc/member[@name="IConnectionPointContainer.FindConnectionPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FindConnectionPoint([NativeTypeName("const IID &")] Guid* riid, IConnectionPoint** ppCP)
    {
        return ((delegate* unmanaged<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)(lpVtbl[4]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this), riid, ppCP);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumConnectionPoints(IEnumConnectionPoints** ppEnum);

        [VtblIndex(4)]
        HRESULT FindConnectionPoint([NativeTypeName("const IID &")] Guid* riid, IConnectionPoint** ppCP);
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

        [NativeTypeName("HRESULT (IEnumConnectionPoints **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumConnectionPoints**, int> EnumConnectionPoints;

        [NativeTypeName("HRESULT (const IID &, IConnectionPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IConnectionPoint**, int> FindConnectionPoint;
    }
}
