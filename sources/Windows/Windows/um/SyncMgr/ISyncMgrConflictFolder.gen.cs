// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISyncMgrConflictFolder.xml' path='doc/member[@name="ISyncMgrConflictFolder"]/*'/>
[Guid("59287F5E-BC81-4FCA-A7F1-E5A8ECDB1D69")]
[NativeTypeName("struct ISyncMgrConflictFolder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrConflictFolder : ISyncMgrConflictFolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrConflictFolder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrConflictFolder*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrConflictFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrConflictFolder*, uint> )(lpVtbl[1]))((ISyncMgrConflictFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrConflictFolder*, uint> )(lpVtbl[2]))((ISyncMgrConflictFolder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrConflictFolder.xml' path='doc/member[@name="ISyncMgrConflictFolder.GetConflictIDList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetConflictIDList(ISyncMgrConflict* pConflict, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlConflict)
    {
        return ((delegate* unmanaged<ISyncMgrConflictFolder*, ISyncMgrConflict*, ITEMIDLIST**, int> )(lpVtbl[3]))((ISyncMgrConflictFolder*)Unsafe.AsPointer(ref this), pConflict, ppidlConflict);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetConflictIDList(ISyncMgrConflict* pConflict, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlConflict);
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
        [NativeTypeName("HRESULT (ISyncMgrConflict *, LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISyncMgrConflict*, ITEMIDLIST**, int> GetConflictIDList;
    }
}