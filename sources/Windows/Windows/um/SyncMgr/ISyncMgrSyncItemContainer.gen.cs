// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISyncMgrSyncItemContainer.xml' path='doc/member[@name="ISyncMgrSyncItemContainer"]/*'/>
[Guid("90701133-BE32-4129-A65C-99E616CAFFF4")]
[NativeTypeName("struct ISyncMgrSyncItemContainer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSyncItemContainer : ISyncMgrSyncItemContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrSyncItemContainer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, uint> )(lpVtbl[1]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, uint> )(lpVtbl[2]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrSyncItemContainer.xml' path='doc/member[@name="ISyncMgrSyncItemContainer.GetSyncItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSyncItem([NativeTypeName("LPCWSTR")] ushort* pszItemID, ISyncMgrSyncItem** ppItem)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, ushort*, ISyncMgrSyncItem**, int> )(lpVtbl[3]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this), pszItemID, ppItem);
    }

    /// <include file='ISyncMgrSyncItemContainer.xml' path='doc/member[@name="ISyncMgrSyncItemContainer.GetSyncItemEnumerator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSyncItemEnumerator(IEnumSyncMgrSyncItems** ppenum)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, IEnumSyncMgrSyncItems**, int> )(lpVtbl[4]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='ISyncMgrSyncItemContainer.xml' path='doc/member[@name="ISyncMgrSyncItemContainer.GetSyncItemCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSyncItemCount([NativeTypeName("ULONG *")] uint* pcItems)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemContainer*, uint*, int> )(lpVtbl[5]))((ISyncMgrSyncItemContainer*)Unsafe.AsPointer(ref this), pcItems);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSyncItem([NativeTypeName("LPCWSTR")] ushort* pszItemID, ISyncMgrSyncItem** ppItem);
        [VtblIndex(4)]
        HRESULT GetSyncItemEnumerator(IEnumSyncMgrSyncItems** ppenum);
        [VtblIndex(5)]
        HRESULT GetSyncItemCount([NativeTypeName("ULONG *")] uint* pcItems);
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
        [NativeTypeName("HRESULT (LPCWSTR, ISyncMgrSyncItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ISyncMgrSyncItem**, int> GetSyncItem;
        [NativeTypeName("HRESULT (IEnumSyncMgrSyncItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSyncMgrSyncItems**, int> GetSyncItemEnumerator;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSyncItemCount;
    }
}