// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISyncMgrHandlerInfo.xml' path='doc/member[@name="ISyncMgrHandlerInfo"]/*' />
[Guid("4FF1D798-ECF7-4524-AA81-1E362A0AEF3A")]
[NativeTypeName("struct ISyncMgrHandlerInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrHandlerInfo : ISyncMgrHandlerInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrHandlerInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrHandlerInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrHandlerInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrHandlerInfo*, uint>)(lpVtbl[1]))((ISyncMgrHandlerInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrHandlerInfo*, uint>)(lpVtbl[2]))((ISyncMgrHandlerInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrHandlerInfo.xml' path='doc/member[@name="ISyncMgrHandlerInfo.GetType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetType(SYNCMGR_HANDLER_TYPE* pnType)
    {
        return ((delegate* unmanaged<ISyncMgrHandlerInfo*, SYNCMGR_HANDLER_TYPE*, int>)(lpVtbl[3]))((ISyncMgrHandlerInfo*)Unsafe.AsPointer(ref this), pnType);
    }

    /// <include file='ISyncMgrHandlerInfo.xml' path='doc/member[@name="ISyncMgrHandlerInfo.GetTypeLabel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeLabel([NativeTypeName("LPWSTR *")] ushort** ppszTypeLabel)
    {
        return ((delegate* unmanaged<ISyncMgrHandlerInfo*, ushort**, int>)(lpVtbl[4]))((ISyncMgrHandlerInfo*)Unsafe.AsPointer(ref this), ppszTypeLabel);
    }

    /// <include file='ISyncMgrHandlerInfo.xml' path='doc/member[@name="ISyncMgrHandlerInfo.GetComment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetComment([NativeTypeName("LPWSTR *")] ushort** ppszComment)
    {
        return ((delegate* unmanaged<ISyncMgrHandlerInfo*, ushort**, int>)(lpVtbl[5]))((ISyncMgrHandlerInfo*)Unsafe.AsPointer(ref this), ppszComment);
    }

    /// <include file='ISyncMgrHandlerInfo.xml' path='doc/member[@name="ISyncMgrHandlerInfo.GetLastSyncTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLastSyncTime(FILETIME* pftLastSync)
    {
        return ((delegate* unmanaged<ISyncMgrHandlerInfo*, FILETIME*, int>)(lpVtbl[6]))((ISyncMgrHandlerInfo*)Unsafe.AsPointer(ref this), pftLastSync);
    }

    /// <include file='ISyncMgrHandlerInfo.xml' path='doc/member[@name="ISyncMgrHandlerInfo.IsActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsActive()
    {
        return ((delegate* unmanaged<ISyncMgrHandlerInfo*, int>)(lpVtbl[7]))((ISyncMgrHandlerInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrHandlerInfo.xml' path='doc/member[@name="ISyncMgrHandlerInfo.IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsEnabled()
    {
        return ((delegate* unmanaged<ISyncMgrHandlerInfo*, int>)(lpVtbl[8]))((ISyncMgrHandlerInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrHandlerInfo.xml' path='doc/member[@name="ISyncMgrHandlerInfo.IsConnected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsConnected()
    {
        return ((delegate* unmanaged<ISyncMgrHandlerInfo*, int>)(lpVtbl[9]))((ISyncMgrHandlerInfo*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetType(SYNCMGR_HANDLER_TYPE* pnType);

        [VtblIndex(4)]
        HRESULT GetTypeLabel([NativeTypeName("LPWSTR *")] ushort** ppszTypeLabel);

        [VtblIndex(5)]
        HRESULT GetComment([NativeTypeName("LPWSTR *")] ushort** ppszComment);

        [VtblIndex(6)]
        HRESULT GetLastSyncTime(FILETIME* pftLastSync);

        [VtblIndex(7)]
        HRESULT IsActive();

        [VtblIndex(8)]
        HRESULT IsEnabled();

        [VtblIndex(9)]
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

        [NativeTypeName("HRESULT (SYNCMGR_HANDLER_TYPE *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, SYNCMGR_HANDLER_TYPE*, int> GetType;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetTypeLabel;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetComment;

        [NativeTypeName("HRESULT (FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILETIME*, int> GetLastSyncTime;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsActive;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsEnabled;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsConnected;
    }
}
