// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B20B24CE-2593-4F04-BD8B-7AD6C45051CD")]
[NativeTypeName("struct ISyncMgrSyncItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSyncItem : ISyncMgrSyncItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrSyncItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItem, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrSyncItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrSyncItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetItemID([NativeTypeName("LPWSTR *")] ushort** ppszItemID)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItem, ushort**, int>)((*lpVtbl)[3]))(
            this,
            ppszItemID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItem, ushort**, int>)((*lpVtbl)[4]))(
            this,
            ppszName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetItemInfo(ISyncMgrSyncItemInfo* ppItemInfo)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItem, ISyncMgrSyncItemInfo*, int>)((*lpVtbl)[5]))(
            this,
            ppItemInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetObjectW(
        [NativeTypeName("const GUID &")] Guid* rguidObjectID,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return ((delegate* unmanaged<ISyncMgrSyncItem, Guid*, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            rguidObjectID,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCapabilities(SYNCMGR_ITEM_CAPABILITIES* pmCapabilities)
    {
        return (
            (delegate* unmanaged<ISyncMgrSyncItem, SYNCMGR_ITEM_CAPABILITIES*, int>)((*lpVtbl)[7])
        )(this, pmCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPolicies(SYNCMGR_ITEM_POLICIES* pmPolicies)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItem, SYNCMGR_ITEM_POLICIES*, int>)((*lpVtbl)[8]))(
            this,
            pmPolicies
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Enable(BOOL fEnable)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItem, BOOL, int>)((*lpVtbl)[9]))(this, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Delete()
    {
        return ((delegate* unmanaged<ISyncMgrSyncItem, int>)((*lpVtbl)[10]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetItemID([NativeTypeName("LPWSTR *")] ushort** ppszItemID);

        [VtblIndex(4)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppszName);

        [VtblIndex(5)]
        HRESULT GetItemInfo(ISyncMgrSyncItemInfo* ppItemInfo);

        [VtblIndex(6)]
        HRESULT GetObjectW(
            [NativeTypeName("const GUID &")] Guid* rguidObjectID,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(7)]
        HRESULT GetCapabilities(SYNCMGR_ITEM_CAPABILITIES* pmCapabilities);

        [VtblIndex(8)]
        HRESULT GetPolicies(SYNCMGR_ITEM_POLICIES* pmPolicies);

        [VtblIndex(9)]
        HRESULT Enable(BOOL fEnable);

        [VtblIndex(10)]
        HRESULT Delete();
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
        public delegate* unmanaged<TSelf*, ushort**, int> GetItemID;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("HRESULT (ISyncMgrSyncItemInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISyncMgrSyncItemInfo*, int> GetItemInfo;

        [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> GetObjectW;

        [NativeTypeName("HRESULT (SYNCMGR_ITEM_CAPABILITIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_ITEM_CAPABILITIES*, int> GetCapabilities;

        [NativeTypeName("HRESULT (SYNCMGR_ITEM_POLICIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_ITEM_POLICIES*, int> GetPolicies;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Enable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Delete;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrSyncItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrSyncItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrSyncItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrSyncItem(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrSyncItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrSyncItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrSyncItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrSyncItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
