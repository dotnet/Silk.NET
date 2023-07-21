// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IEnumSyncMgrSyncItems.xml' path='doc/member[@name="IEnumSyncMgrSyncItems"]/*' />
[Guid("54B3ABF3-F085-4181-B546-E29C403C726B")]
[NativeTypeName("struct IEnumSyncMgrSyncItems : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumSyncMgrSyncItems : IEnumSyncMgrSyncItems.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumSyncMgrSyncItems));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, uint>)(lpVtbl[1]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, uint>)(lpVtbl[2]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumSyncMgrSyncItems.xml' path='doc/member[@name="IEnumSyncMgrSyncItems.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, ISyncMgrSyncItem** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, uint, ISyncMgrSyncItem**, uint*, int>)(lpVtbl[3]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IEnumSyncMgrSyncItems.xml' path='doc/member[@name="IEnumSyncMgrSyncItems.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, uint, int>)(lpVtbl[4]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumSyncMgrSyncItems.xml' path='doc/member[@name="IEnumSyncMgrSyncItems.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, int>)(lpVtbl[5]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumSyncMgrSyncItems.xml' path='doc/member[@name="IEnumSyncMgrSyncItems.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumSyncMgrSyncItems** ppenum)
    {
        return ((delegate* unmanaged<IEnumSyncMgrSyncItems*, IEnumSyncMgrSyncItems**, int>)(lpVtbl[6]))((IEnumSyncMgrSyncItems*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, ISyncMgrSyncItem** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumSyncMgrSyncItems** ppenum);
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

        [NativeTypeName("HRESULT (ULONG, ISyncMgrSyncItem **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ISyncMgrSyncItem**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumSyncMgrSyncItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSyncMgrSyncItems**, int> Clone;
    }
}
