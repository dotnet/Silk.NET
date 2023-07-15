// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISyncMgrConflictResolutionItems.xml' path='doc/member[@name="ISyncMgrConflictResolutionItems"]/*'/>
[Guid("458725B9-129D-4135-A998-9CEAFEC27007")]
[NativeTypeName("struct ISyncMgrConflictResolutionItems : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrConflictResolutionItems : ISyncMgrConflictResolutionItems.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrConflictResolutionItems));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolutionItems*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrConflictResolutionItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolutionItems*, uint> )(lpVtbl[1]))((ISyncMgrConflictResolutionItems*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolutionItems*, uint> )(lpVtbl[2]))((ISyncMgrConflictResolutionItems*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrConflictResolutionItems.xml' path='doc/member[@name="ISyncMgrConflictResolutionItems.GetCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(uint* pCount)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolutionItems*, uint*, int> )(lpVtbl[3]))((ISyncMgrConflictResolutionItems*)Unsafe.AsPointer(ref this), pCount);
    }

    /// <include file='ISyncMgrConflictResolutionItems.xml' path='doc/member[@name="ISyncMgrConflictResolutionItems.GetItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItem(uint iIndex, CONFIRM_CONFLICT_RESULT_INFO* pItemInfo)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolutionItems*, uint, CONFIRM_CONFLICT_RESULT_INFO*, int> )(lpVtbl[4]))((ISyncMgrConflictResolutionItems*)Unsafe.AsPointer(ref this), iIndex, pItemInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount(uint* pCount);
        [VtblIndex(4)]
        HRESULT GetItem(uint iIndex, CONFIRM_CONFLICT_RESULT_INFO* pItemInfo);
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
        [NativeTypeName("HRESULT (UINT, CONFIRM_CONFLICT_RESULT_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, CONFIRM_CONFLICT_RESULT_INFO*, int> GetItem;
    }
}