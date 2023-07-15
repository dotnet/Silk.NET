// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISyncMgrSyncResult.xml' path='doc/member[@name="ISyncMgrSyncResult"]/*'/>
[Guid("2B90F17E-5A3E-4B33-BB7F-1BC48056B94D")]
[NativeTypeName("struct ISyncMgrSyncResult : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSyncResult : ISyncMgrSyncResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrSyncResult));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrSyncResult*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrSyncResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrSyncResult*, uint> )(lpVtbl[1]))((ISyncMgrSyncResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrSyncResult*, uint> )(lpVtbl[2]))((ISyncMgrSyncResult*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrSyncResult.xml' path='doc/member[@name="ISyncMgrSyncResult.Result"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Result(SYNCMGR_PROGRESS_STATUS nStatus, uint cError, uint cConflicts)
    {
        return ((delegate* unmanaged<ISyncMgrSyncResult*, SYNCMGR_PROGRESS_STATUS, uint, uint, int> )(lpVtbl[3]))((ISyncMgrSyncResult*)Unsafe.AsPointer(ref this), nStatus, cError, cConflicts);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Result(SYNCMGR_PROGRESS_STATUS nStatus, uint cError, uint cConflicts);
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
        [NativeTypeName("HRESULT (SYNCMGR_PROGRESS_STATUS, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_PROGRESS_STATUS, uint, uint, int> Result;
    }
}