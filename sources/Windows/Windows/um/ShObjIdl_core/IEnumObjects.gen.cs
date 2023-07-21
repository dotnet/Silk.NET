// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IEnumObjects.xml' path='doc/member[@name="IEnumObjects"]/*' />
[Guid("2C1C7E2E-2D0E-4059-831E-1E6F82335C2E")]
[NativeTypeName("struct IEnumObjects : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumObjects : IEnumObjects.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumObjects));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumObjects*, Guid*, void**, int>)(lpVtbl[0]))((IEnumObjects*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumObjects*, uint>)(lpVtbl[1]))((IEnumObjects*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumObjects*, uint>)(lpVtbl[2]))((IEnumObjects*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumObjects.xml' path='doc/member[@name="IEnumObjects.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("const IID &")] Guid* riid, void** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumObjects*, uint, Guid*, void**, uint*, int>)(lpVtbl[3]))((IEnumObjects*)Unsafe.AsPointer(ref this), celt, riid, rgelt, pceltFetched);
    }

    /// <include file='IEnumObjects.xml' path='doc/member[@name="IEnumObjects.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumObjects*, uint, int>)(lpVtbl[4]))((IEnumObjects*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumObjects.xml' path='doc/member[@name="IEnumObjects.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumObjects*, int>)(lpVtbl[5]))((IEnumObjects*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumObjects.xml' path='doc/member[@name="IEnumObjects.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumObjects** ppenum)
    {
        return ((delegate* unmanaged<IEnumObjects*, IEnumObjects**, int>)(lpVtbl[6]))((IEnumObjects*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("const IID &")] Guid* riid, void** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumObjects** ppenum);
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

        [NativeTypeName("HRESULT (ULONG, const IID &, void **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumObjects **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumObjects**, int> Clone;
    }
}
