// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IEnumSyncMgrEvents.xml' path='doc/member[@name="IEnumSyncMgrEvents"]/*'/>
[Guid("C81A1D4E-8CF7-4683-80E0-BCAE88D677B6")]
[NativeTypeName("struct IEnumSyncMgrEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumSyncMgrEvents : IEnumSyncMgrEvents.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumSyncMgrEvents));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumSyncMgrEvents*, Guid*, void**, int> )(lpVtbl[0]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumSyncMgrEvents*, uint> )(lpVtbl[1]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumSyncMgrEvents*, uint> )(lpVtbl[2]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumSyncMgrEvents.xml' path='doc/member[@name="IEnumSyncMgrEvents.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, ISyncMgrEvent** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumSyncMgrEvents*, uint, ISyncMgrEvent**, uint*, int> )(lpVtbl[3]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IEnumSyncMgrEvents.xml' path='doc/member[@name="IEnumSyncMgrEvents.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumSyncMgrEvents*, uint, int> )(lpVtbl[4]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumSyncMgrEvents.xml' path='doc/member[@name="IEnumSyncMgrEvents.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumSyncMgrEvents*, int> )(lpVtbl[5]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumSyncMgrEvents.xml' path='doc/member[@name="IEnumSyncMgrEvents.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumSyncMgrEvents** ppenum)
    {
        return ((delegate* unmanaged<IEnumSyncMgrEvents*, IEnumSyncMgrEvents**, int> )(lpVtbl[6]))((IEnumSyncMgrEvents*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, ISyncMgrEvent** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);
        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Clone(IEnumSyncMgrEvents** ppenum);
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
        [NativeTypeName("HRESULT (ULONG, ISyncMgrEvent **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ISyncMgrEvent**, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (IEnumSyncMgrEvents **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSyncMgrEvents**, int> Clone;
    }
}