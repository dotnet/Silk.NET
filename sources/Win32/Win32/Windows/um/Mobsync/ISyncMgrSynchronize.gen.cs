// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6295DF40-35EE-11D1-8707-00C04FD93327")]
[NativeTypeName("struct ISyncMgrSynchronize : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSynchronize : ISyncMgrSynchronize.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrSynchronize));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrSynchronize, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISyncMgrSynchronize, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrSynchronize, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(
        [NativeTypeName("DWORD")] uint dwReserved,
        [NativeTypeName("DWORD")] uint dwSyncMgrFlags,
        [NativeTypeName("DWORD")] uint cbCookie,
        [NativeTypeName("const BYTE *")] byte* lpCookie
    )
    {
        return (
            (delegate* unmanaged<ISyncMgrSynchronize, uint, uint, uint, byte*, int>)((*lpVtbl)[3])
        )(this, dwReserved, dwSyncMgrFlags, cbCookie, lpCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHandlerInfo(SYNCMGRHANDLERINFO** ppSyncMgrHandlerInfo)
    {
        return (
            (delegate* unmanaged<ISyncMgrSynchronize, SYNCMGRHANDLERINFO**, int>)((*lpVtbl)[4])
        )(this, ppSyncMgrHandlerInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumSyncMgrItems(ISyncMgrEnumItems* ppSyncMgrEnumItems)
    {
        return ((delegate* unmanaged<ISyncMgrSynchronize, ISyncMgrEnumItems*, int>)((*lpVtbl)[5]))(
            this,
            ppSyncMgrEnumItems
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetItemObject(
        [NativeTypeName("const GUID &")] Guid* ItemID,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<ISyncMgrSynchronize, Guid*, Guid*, void**, int>)((*lpVtbl)[6])
        )(this, ItemID, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowProperties(HWND hWndParent, [NativeTypeName("const GUID &")] Guid* ItemID)
    {
        return ((delegate* unmanaged<ISyncMgrSynchronize, HWND, Guid*, int>)((*lpVtbl)[7]))(
            this,
            hWndParent,
            ItemID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetProgressCallback(ISyncMgrSynchronizeCallback lpCallBack)
    {
        return (
            (delegate* unmanaged<ISyncMgrSynchronize, ISyncMgrSynchronizeCallback, int>)(
                (*lpVtbl)[8]
            )
        )(this, lpCallBack);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PrepareForSync(
        [NativeTypeName("ULONG")] uint cbNumItems,
        Guid* pItemIDs,
        HWND hWndParent,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<ISyncMgrSynchronize, uint, Guid*, HWND, uint, int>)((*lpVtbl)[9])
        )(this, cbNumItems, pItemIDs, hWndParent, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Synchronize(HWND hWndParent)
    {
        return ((delegate* unmanaged<ISyncMgrSynchronize, HWND, int>)((*lpVtbl)[10]))(
            this,
            hWndParent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetItemStatus(
        [NativeTypeName("const GUID &")] Guid* pItemID,
        [NativeTypeName("DWORD")] uint dwSyncMgrStatus
    )
    {
        return ((delegate* unmanaged<ISyncMgrSynchronize, Guid*, uint, int>)((*lpVtbl)[11]))(
            this,
            pItemID,
            dwSyncMgrStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ShowError(HWND hWndParent, [NativeTypeName("const GUID &")] Guid* ErrorID)
    {
        return ((delegate* unmanaged<ISyncMgrSynchronize, HWND, Guid*, int>)((*lpVtbl)[12]))(
            this,
            hWndParent,
            ErrorID
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(
            [NativeTypeName("DWORD")] uint dwReserved,
            [NativeTypeName("DWORD")] uint dwSyncMgrFlags,
            [NativeTypeName("DWORD")] uint cbCookie,
            [NativeTypeName("const BYTE *")] byte* lpCookie
        );

        [VtblIndex(4)]
        HRESULT GetHandlerInfo(SYNCMGRHANDLERINFO** ppSyncMgrHandlerInfo);

        [VtblIndex(5)]
        HRESULT EnumSyncMgrItems(ISyncMgrEnumItems* ppSyncMgrEnumItems);

        [VtblIndex(6)]
        HRESULT GetItemObject(
            [NativeTypeName("const GUID &")] Guid* ItemID,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(7)]
        HRESULT ShowProperties(HWND hWndParent, [NativeTypeName("const GUID &")] Guid* ItemID);

        [VtblIndex(8)]
        HRESULT SetProgressCallback(ISyncMgrSynchronizeCallback lpCallBack);

        [VtblIndex(9)]
        HRESULT PrepareForSync(
            [NativeTypeName("ULONG")] uint cbNumItems,
            Guid* pItemIDs,
            HWND hWndParent,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(10)]
        HRESULT Synchronize(HWND hWndParent);

        [VtblIndex(11)]
        HRESULT SetItemStatus(
            [NativeTypeName("const GUID &")] Guid* pItemID,
            [NativeTypeName("DWORD")] uint dwSyncMgrStatus
        );

        [VtblIndex(12)]
        HRESULT ShowError(HWND hWndParent, [NativeTypeName("const GUID &")] Guid* ErrorID);
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

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, byte*, int> Initialize;

        [NativeTypeName("HRESULT (SYNCMGRHANDLERINFO **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGRHANDLERINFO**, int> GetHandlerInfo;

        [NativeTypeName("HRESULT (ISyncMgrEnumItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISyncMgrEnumItems*, int> EnumSyncMgrItems;

        [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> GetItemObject;

        [NativeTypeName("HRESULT (HWND, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, int> ShowProperties;

        [NativeTypeName("HRESULT (ISyncMgrSynchronizeCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISyncMgrSynchronizeCallback, int> SetProgressCallback;

        [NativeTypeName("HRESULT (ULONG, GUID *, HWND, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, HWND, uint, int> PrepareForSync;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> Synchronize;

        [NativeTypeName("HRESULT (const GUID &, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> SetItemStatus;

        [NativeTypeName("HRESULT (HWND, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, int> ShowError;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrSynchronize"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrSynchronize(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrSynchronize"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrSynchronize(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrSynchronize(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrSynchronize"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrSynchronize"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrSynchronize value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
