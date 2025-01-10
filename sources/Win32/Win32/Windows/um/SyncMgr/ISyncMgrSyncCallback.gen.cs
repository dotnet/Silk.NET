// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("884CCD87-B139-4937-A4BA-4F8E19513FBE")]
[NativeTypeName("struct ISyncMgrSyncCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSyncCallback : ISyncMgrSyncCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrSyncCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrSyncCallback, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISyncMgrSyncCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrSyncCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportProgress(
        [NativeTypeName("LPCWSTR")] ushort* pszItemID,
        [NativeTypeName("LPCWSTR")] ushort* pszProgressText,
        SYNCMGR_PROGRESS_STATUS nStatus,
        [NativeTypeName("ULONG")] uint uCurrentStep,
        [NativeTypeName("ULONG")] uint uMaxStep,
        SYNCMGR_CANCEL_REQUEST* pnCancelRequest
    )
    {
        return (
            (delegate* unmanaged<
                ISyncMgrSyncCallback,
                ushort*,
                ushort*,
                SYNCMGR_PROGRESS_STATUS,
                uint,
                uint,
                SYNCMGR_CANCEL_REQUEST*,
                int>)((*lpVtbl)[3])
        )(this, pszItemID, pszProgressText, nStatus, uCurrentStep, uMaxStep, pnCancelRequest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetHandlerProgressText(
        [NativeTypeName("LPCWSTR")] ushort* pszProgressText,
        SYNCMGR_CANCEL_REQUEST* pnCancelRequest
    )
    {
        return (
            (delegate* unmanaged<ISyncMgrSyncCallback, ushort*, SYNCMGR_CANCEL_REQUEST*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pszProgressText, pnCancelRequest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReportEventW(
        [NativeTypeName("LPCWSTR")] ushort* pszItemID,
        SYNCMGR_EVENT_LEVEL nLevel,
        SYNCMGR_EVENT_FLAGS nFlags,
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        [NativeTypeName("LPCWSTR")] ushort* pszDescription,
        [NativeTypeName("LPCWSTR")] ushort* pszLinkText,
        [NativeTypeName("LPCWSTR")] ushort* pszLinkReference,
        [NativeTypeName("LPCWSTR")] ushort* pszContext,
        Guid* pguidEventID
    )
    {
        return (
            (delegate* unmanaged<
                ISyncMgrSyncCallback,
                ushort*,
                SYNCMGR_EVENT_LEVEL,
                SYNCMGR_EVENT_FLAGS,
                ushort*,
                ushort*,
                ushort*,
                ushort*,
                ushort*,
                Guid*,
                int>)((*lpVtbl)[5])
        )(
            this,
            pszItemID,
            nLevel,
            nFlags,
            pszName,
            pszDescription,
            pszLinkText,
            pszLinkReference,
            pszContext,
            pguidEventID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CanContinue([NativeTypeName("LPCWSTR")] ushort* pszItemID)
    {
        return ((delegate* unmanaged<ISyncMgrSyncCallback, ushort*, int>)((*lpVtbl)[6]))(
            this,
            pszItemID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT QueryForAdditionalItems(IEnumString* ppenumItemIDs, IEnumUnknown* ppenumPunks)
    {
        return (
            (delegate* unmanaged<ISyncMgrSyncCallback, IEnumString*, IEnumUnknown*, int>)(
                (*lpVtbl)[7]
            )
        )(this, ppenumItemIDs, ppenumPunks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddItemToSession([NativeTypeName("LPCWSTR")] ushort* pszItemID)
    {
        return ((delegate* unmanaged<ISyncMgrSyncCallback, ushort*, int>)((*lpVtbl)[8]))(
            this,
            pszItemID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddIUnknownToSession(IUnknown punk)
    {
        return ((delegate* unmanaged<ISyncMgrSyncCallback, IUnknown, int>)((*lpVtbl)[9]))(
            this,
            punk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ProposeItem(ISyncMgrSyncItem pNewItem)
    {
        return ((delegate* unmanaged<ISyncMgrSyncCallback, ISyncMgrSyncItem, int>)((*lpVtbl)[10]))(
            this,
            pNewItem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CommitItem([NativeTypeName("LPCWSTR")] ushort* pszItemID)
    {
        return ((delegate* unmanaged<ISyncMgrSyncCallback, ushort*, int>)((*lpVtbl)[11]))(
            this,
            pszItemID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReportManualSync()
    {
        return ((delegate* unmanaged<ISyncMgrSyncCallback, int>)((*lpVtbl)[12]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReportProgress(
            [NativeTypeName("LPCWSTR")] ushort* pszItemID,
            [NativeTypeName("LPCWSTR")] ushort* pszProgressText,
            SYNCMGR_PROGRESS_STATUS nStatus,
            [NativeTypeName("ULONG")] uint uCurrentStep,
            [NativeTypeName("ULONG")] uint uMaxStep,
            SYNCMGR_CANCEL_REQUEST* pnCancelRequest
        );

        [VtblIndex(4)]
        HRESULT SetHandlerProgressText(
            [NativeTypeName("LPCWSTR")] ushort* pszProgressText,
            SYNCMGR_CANCEL_REQUEST* pnCancelRequest
        );

        [VtblIndex(5)]
        HRESULT ReportEventW(
            [NativeTypeName("LPCWSTR")] ushort* pszItemID,
            SYNCMGR_EVENT_LEVEL nLevel,
            SYNCMGR_EVENT_FLAGS nFlags,
            [NativeTypeName("LPCWSTR")] ushort* pszName,
            [NativeTypeName("LPCWSTR")] ushort* pszDescription,
            [NativeTypeName("LPCWSTR")] ushort* pszLinkText,
            [NativeTypeName("LPCWSTR")] ushort* pszLinkReference,
            [NativeTypeName("LPCWSTR")] ushort* pszContext,
            Guid* pguidEventID
        );

        [VtblIndex(6)]
        HRESULT CanContinue([NativeTypeName("LPCWSTR")] ushort* pszItemID);

        [VtblIndex(7)]
        HRESULT QueryForAdditionalItems(IEnumString* ppenumItemIDs, IEnumUnknown* ppenumPunks);

        [VtblIndex(8)]
        HRESULT AddItemToSession([NativeTypeName("LPCWSTR")] ushort* pszItemID);

        [VtblIndex(9)]
        HRESULT AddIUnknownToSession(IUnknown punk);

        [VtblIndex(10)]
        HRESULT ProposeItem(ISyncMgrSyncItem pNewItem);

        [VtblIndex(11)]
        HRESULT CommitItem([NativeTypeName("LPCWSTR")] ushort* pszItemID);

        [VtblIndex(12)]
        HRESULT ReportManualSync();
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

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, SYNCMGR_PROGRESS_STATUS, ULONG, ULONG, SYNCMGR_CANCEL_REQUEST *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            SYNCMGR_PROGRESS_STATUS,
            uint,
            uint,
            SYNCMGR_CANCEL_REQUEST*,
            int> ReportProgress;

        [NativeTypeName("HRESULT (LPCWSTR, SYNCMGR_CANCEL_REQUEST *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            SYNCMGR_CANCEL_REQUEST*,
            int> SetHandlerProgressText;

        [NativeTypeName(
            "HRESULT (LPCWSTR, SYNCMGR_EVENT_LEVEL, SYNCMGR_EVENT_FLAGS, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, GUID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            SYNCMGR_EVENT_LEVEL,
            SYNCMGR_EVENT_FLAGS,
            ushort*,
            ushort*,
            ushort*,
            ushort*,
            ushort*,
            Guid*,
            int> ReportEventW;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> CanContinue;

        [NativeTypeName("HRESULT (IEnumString **, IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IEnumString*,
            IEnumUnknown*,
            int> QueryForAdditionalItems;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> AddItemToSession;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> AddIUnknownToSession;

        [NativeTypeName("HRESULT (ISyncMgrSyncItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISyncMgrSyncItem, int> ProposeItem;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> CommitItem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReportManualSync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrSyncCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrSyncCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrSyncCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrSyncCallback(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrSyncCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrSyncCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrSyncCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrSyncCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
