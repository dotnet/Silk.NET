// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IEnumSyncMgrConflict.xml' path='doc/member[@name="IEnumSyncMgrConflict"]/*' />
[Guid("82705914-DDA3-4893-BA99-49DE6C8C8036")]
[NativeTypeName("struct IEnumSyncMgrConflict : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumSyncMgrConflict : IEnumSyncMgrConflict.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumSyncMgrConflict));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumSyncMgrConflict*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumSyncMgrConflict*, uint>)(lpVtbl[1]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumSyncMgrConflict*, uint>)(lpVtbl[2]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumSyncMgrConflict.xml' path='doc/member[@name="IEnumSyncMgrConflict.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, ISyncMgrConflict** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumSyncMgrConflict*, uint, ISyncMgrConflict**, uint*, int>)(lpVtbl[3]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IEnumSyncMgrConflict.xml' path='doc/member[@name="IEnumSyncMgrConflict.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumSyncMgrConflict*, uint, int>)(lpVtbl[4]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumSyncMgrConflict.xml' path='doc/member[@name="IEnumSyncMgrConflict.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumSyncMgrConflict*, int>)(lpVtbl[5]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumSyncMgrConflict.xml' path='doc/member[@name="IEnumSyncMgrConflict.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumSyncMgrConflict** ppenum)
    {
        return ((delegate* unmanaged<IEnumSyncMgrConflict*, IEnumSyncMgrConflict**, int>)(lpVtbl[6]))((IEnumSyncMgrConflict*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, ISyncMgrConflict** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumSyncMgrConflict** ppenum);
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

        [NativeTypeName("HRESULT (ULONG, ISyncMgrConflict **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ISyncMgrConflict**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumSyncMgrConflict **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSyncMgrConflict**, int> Clone;
    }
}
