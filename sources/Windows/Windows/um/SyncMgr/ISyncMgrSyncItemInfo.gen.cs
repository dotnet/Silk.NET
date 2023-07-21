// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISyncMgrSyncItemInfo.xml' path='doc/member[@name="ISyncMgrSyncItemInfo"]/*' />
[Guid("E7FD9502-BE0C-4464-90A1-2B5277031232")]
[NativeTypeName("struct ISyncMgrSyncItemInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSyncItemInfo : ISyncMgrSyncItemInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrSyncItemInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, uint>)(lpVtbl[1]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, uint>)(lpVtbl[2]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrSyncItemInfo.xml' path='doc/member[@name="ISyncMgrSyncItemInfo.GetTypeLabel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeLabel([NativeTypeName("LPWSTR *")] ushort** ppszTypeLabel)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, ushort**, int>)(lpVtbl[3]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this), ppszTypeLabel);
    }

    /// <include file='ISyncMgrSyncItemInfo.xml' path='doc/member[@name="ISyncMgrSyncItemInfo.GetComment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetComment([NativeTypeName("LPWSTR *")] ushort** ppszComment)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, ushort**, int>)(lpVtbl[4]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this), ppszComment);
    }

    /// <include file='ISyncMgrSyncItemInfo.xml' path='doc/member[@name="ISyncMgrSyncItemInfo.GetLastSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLastSyncTime(FILETIME* pftLastSync)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, FILETIME*, int>)(lpVtbl[5]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this), pftLastSync);
    }

    /// <include file='ISyncMgrSyncItemInfo.xml' path='doc/member[@name="ISyncMgrSyncItemInfo.IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsEnabled()
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, int>)(lpVtbl[6]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrSyncItemInfo.xml' path='doc/member[@name="ISyncMgrSyncItemInfo.IsConnected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsConnected()
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemInfo*, int>)(lpVtbl[7]))((ISyncMgrSyncItemInfo*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTypeLabel([NativeTypeName("LPWSTR *")] ushort** ppszTypeLabel);

        [VtblIndex(4)]
        HRESULT GetComment([NativeTypeName("LPWSTR *")] ushort** ppszComment);

        [VtblIndex(5)]
        HRESULT GetLastSyncTime(FILETIME* pftLastSync);

        [VtblIndex(6)]
        HRESULT IsEnabled();

        [VtblIndex(7)]
        HRESULT IsConnected();
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetTypeLabel;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetComment;

        [NativeTypeName("HRESULT (FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILETIME*, int> GetLastSyncTime;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsEnabled;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsConnected;
    }
}
