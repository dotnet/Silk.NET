// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CF8FC579-C396-4774-85F1-D908A831156E")]
[NativeTypeName("struct ISyncMgrConflictStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrConflictStore : ISyncMgrConflictStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrConflictStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrConflictStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISyncMgrConflictStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrConflictStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumConflicts(
        [NativeTypeName("LPCWSTR")] ushort* pszHandlerID,
        [NativeTypeName("LPCWSTR")] ushort* pszItemID,
        IEnumSyncMgrConflict* ppEnum
    )
    {
        return (
            (delegate* unmanaged<
                ISyncMgrConflictStore,
                ushort*,
                ushort*,
                IEnumSyncMgrConflict*,
                int>)((*lpVtbl)[3])
        )(this, pszHandlerID, pszItemID, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BindToConflict(
        [NativeTypeName("const SYNCMGR_CONFLICT_ID_INFO *")]
            SYNCMGR_CONFLICT_ID_INFO* pConflictIdInfo,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<
                ISyncMgrConflictStore,
                SYNCMGR_CONFLICT_ID_INFO*,
                Guid*,
                void**,
                int>)((*lpVtbl)[4])
        )(this, pConflictIdInfo, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemoveConflicts(
        [NativeTypeName("const SYNCMGR_CONFLICT_ID_INFO *")]
            SYNCMGR_CONFLICT_ID_INFO* rgConflictIdInfo,
        [NativeTypeName("DWORD")] uint cConflicts
    )
    {
        return (
            (delegate* unmanaged<ISyncMgrConflictStore, SYNCMGR_CONFLICT_ID_INFO*, uint, int>)(
                (*lpVtbl)[5]
            )
        )(this, rgConflictIdInfo, cConflicts);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCount(
        [NativeTypeName("LPCWSTR")] ushort* pszHandlerID,
        [NativeTypeName("LPCWSTR")] ushort* pszItemID,
        [NativeTypeName("DWORD *")] uint* pnConflicts
    )
    {
        return (
            (delegate* unmanaged<ISyncMgrConflictStore, ushort*, ushort*, uint*, int>)((*lpVtbl)[6])
        )(this, pszHandlerID, pszItemID, pnConflicts);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumConflicts(
            [NativeTypeName("LPCWSTR")] ushort* pszHandlerID,
            [NativeTypeName("LPCWSTR")] ushort* pszItemID,
            IEnumSyncMgrConflict* ppEnum
        );

        [VtblIndex(4)]
        HRESULT BindToConflict(
            [NativeTypeName("const SYNCMGR_CONFLICT_ID_INFO *")]
                SYNCMGR_CONFLICT_ID_INFO* pConflictIdInfo,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(5)]
        HRESULT RemoveConflicts(
            [NativeTypeName("const SYNCMGR_CONFLICT_ID_INFO *")]
                SYNCMGR_CONFLICT_ID_INFO* rgConflictIdInfo,
            [NativeTypeName("DWORD")] uint cConflicts
        );

        [VtblIndex(6)]
        HRESULT GetCount(
            [NativeTypeName("LPCWSTR")] ushort* pszHandlerID,
            [NativeTypeName("LPCWSTR")] ushort* pszItemID,
            [NativeTypeName("DWORD *")] uint* pnConflicts
        );
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
            "HRESULT (LPCWSTR, LPCWSTR, IEnumSyncMgrConflict **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            IEnumSyncMgrConflict*,
            int> EnumConflicts;

        [NativeTypeName(
            "HRESULT (const SYNCMGR_CONFLICT_ID_INFO *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SYNCMGR_CONFLICT_ID_INFO*,
            Guid*,
            void**,
            int> BindToConflict;

        [NativeTypeName(
            "HRESULT (const SYNCMGR_CONFLICT_ID_INFO *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SYNCMGR_CONFLICT_ID_INFO*, uint, int> RemoveConflicts;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, uint*, int> GetCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrConflictStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrConflictStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrConflictStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrConflictStore(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrConflictStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrConflictStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrConflictStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrConflictStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
