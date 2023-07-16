// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISyncMgrEventStore.xml' path='doc/member[@name="ISyncMgrEventStore"]/*'/>
[Guid("37E412F9-016E-44C2-81FF-DB3ADD774266")]
[NativeTypeName("struct ISyncMgrEventStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrEventStore : ISyncMgrEventStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrEventStore));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrEventStore*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrEventStore*, uint> )(lpVtbl[1]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrEventStore*, uint> )(lpVtbl[2]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrEventStore.xml' path='doc/member[@name="ISyncMgrEventStore.GetEventEnumerator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEventEnumerator(IEnumSyncMgrEvents** ppenum)
    {
        return ((delegate* unmanaged<ISyncMgrEventStore*, IEnumSyncMgrEvents**, int> )(lpVtbl[3]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='ISyncMgrEventStore.xml' path='doc/member[@name="ISyncMgrEventStore.GetEventCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEventCount([NativeTypeName("ULONG *")] uint* pcEvents)
    {
        return ((delegate* unmanaged<ISyncMgrEventStore*, uint*, int> )(lpVtbl[4]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this), pcEvents);
    }

    /// <include file='ISyncMgrEventStore.xml' path='doc/member[@name="ISyncMgrEventStore.GetEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEvent([NativeTypeName("const GUID &")] Guid* rguidEventID, ISyncMgrEvent** ppEvent)
    {
        return ((delegate* unmanaged<ISyncMgrEventStore*, Guid*, ISyncMgrEvent**, int> )(lpVtbl[5]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this), rguidEventID, ppEvent);
    }

    /// <include file='ISyncMgrEventStore.xml' path='doc/member[@name="ISyncMgrEventStore.RemoveEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveEvent(Guid* pguidEventIDs, [NativeTypeName("ULONG")] uint cEvents)
    {
        return ((delegate* unmanaged<ISyncMgrEventStore*, Guid*, uint, int> )(lpVtbl[6]))((ISyncMgrEventStore*)Unsafe.AsPointer(ref this), pguidEventIDs, cEvents);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEventEnumerator(IEnumSyncMgrEvents** ppenum);
        [VtblIndex(4)]
        HRESULT GetEventCount([NativeTypeName("ULONG *")] uint* pcEvents);
        [VtblIndex(5)]
        HRESULT GetEvent([NativeTypeName("const GUID &")] Guid* rguidEventID, ISyncMgrEvent** ppEvent);
        [VtblIndex(6)]
        HRESULT RemoveEvent(Guid* pguidEventIDs, [NativeTypeName("ULONG")] uint cEvents);
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
        [NativeTypeName("HRESULT (IEnumSyncMgrEvents **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSyncMgrEvents**, int> GetEventEnumerator;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetEventCount;
        [NativeTypeName("HRESULT (const GUID &, ISyncMgrEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ISyncMgrEvent**, int> GetEvent;
        [NativeTypeName("HRESULT (GUID *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> RemoveEvent;
    }
}