// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISyncMgrConflictItems.xml' path='doc/member[@name="ISyncMgrConflictItems"]/*'/>
[Guid("9C7EAD52-8023-4936-A4DB-D2A9A99E436A")]
[NativeTypeName("struct ISyncMgrConflictItems : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrConflictItems : ISyncMgrConflictItems.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrConflictItems));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrConflictItems*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrConflictItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrConflictItems*, uint> )(lpVtbl[1]))((ISyncMgrConflictItems*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrConflictItems*, uint> )(lpVtbl[2]))((ISyncMgrConflictItems*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrConflictItems.xml' path='doc/member[@name="ISyncMgrConflictItems.GetCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(uint* pCount)
    {
        return ((delegate* unmanaged<ISyncMgrConflictItems*, uint*, int> )(lpVtbl[3]))((ISyncMgrConflictItems*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='ISyncMgrConflictItems.xml' path='doc/member[@name="ISyncMgrConflictItems.GetItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItem(uint iIndex, CONFIRM_CONFLICT_ITEM* pItemInfo)
    {
        return ((delegate* unmanaged<ISyncMgrConflictItems*, uint, CONFIRM_CONFLICT_ITEM*, int> )(lpVtbl[4]))((ISyncMgrConflictItems*)Unsafe.AsPointer(ref this), iIndex, pItemInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount(uint* pCount);
        [VtblIndex(4)]
        HRESULT GetItem(uint iIndex, CONFIRM_CONFLICT_ITEM* pItemInfo);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;
        [NativeTypeName("HRESULT (UINT, CONFIRM_CONFLICT_ITEM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, CONFIRM_CONFLICT_ITEM*, int> GetItem;
    }
}