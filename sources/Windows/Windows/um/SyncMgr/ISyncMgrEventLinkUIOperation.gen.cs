// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISyncMgrEventLinkUIOperation.xml' path='doc/member[@name="ISyncMgrEventLinkUIOperation"]/*' />
[Guid("64522E52-848B-4015-89CE-5A36F00B94FF")]
[NativeTypeName("struct ISyncMgrEventLinkUIOperation : ISyncMgrUIOperation")]
[NativeInheritance("ISyncMgrUIOperation")]
public unsafe partial struct ISyncMgrEventLinkUIOperation : ISyncMgrEventLinkUIOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrEventLinkUIOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, uint>)(lpVtbl[1]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, uint>)(lpVtbl[2]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISyncMgrUIOperation.Run" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Run(HWND hwndOwner)
    {
        return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, HWND, int>)(lpVtbl[3]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this), hwndOwner);
    }

    /// <include file='ISyncMgrEventLinkUIOperation.xml' path='doc/member[@name="ISyncMgrEventLinkUIOperation.Init"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Init([NativeTypeName("const GUID &")] Guid* rguidEventID, ISyncMgrEvent* pEvent)
    {
        return ((delegate* unmanaged<ISyncMgrEventLinkUIOperation*, Guid*, ISyncMgrEvent*, int>)(lpVtbl[4]))((ISyncMgrEventLinkUIOperation*)Unsafe.AsPointer(ref this), rguidEventID, pEvent);
    }

    public interface Interface : ISyncMgrUIOperation.Interface
    {
        [VtblIndex(4)]
        HRESULT Init([NativeTypeName("const GUID &")] Guid* rguidEventID, ISyncMgrEvent* pEvent);
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

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> Run;

        [NativeTypeName("HRESULT (const GUID &, ISyncMgrEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ISyncMgrEvent*, int> Init;
    }
}
