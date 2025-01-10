// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("40A3D052-8BFF-4C4B-A338-D4A395700DE9")]
[NativeTypeName("struct ISyncMgrResolutionHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrResolutionHandler
    : ISyncMgrResolutionHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrResolutionHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrResolutionHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISyncMgrResolutionHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrResolutionHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryAbilities(
        [NativeTypeName("SYNCMGR_RESOLUTION_ABILITIES_FLAGS *")] uint* pdwAbilities
    )
    {
        return ((delegate* unmanaged<ISyncMgrResolutionHandler, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwAbilities
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT KeepOther(IShellItem psiOther, SYNCMGR_RESOLUTION_FEEDBACK* pFeedback)
    {
        return (
            (delegate* unmanaged<
                ISyncMgrResolutionHandler,
                IShellItem,
                SYNCMGR_RESOLUTION_FEEDBACK*,
                int>)((*lpVtbl)[4])
        )(this, psiOther, pFeedback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT KeepRecent(SYNCMGR_RESOLUTION_FEEDBACK* pFeedback)
    {
        return (
            (delegate* unmanaged<ISyncMgrResolutionHandler, SYNCMGR_RESOLUTION_FEEDBACK*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pFeedback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveFromSyncSet(SYNCMGR_RESOLUTION_FEEDBACK* pFeedback)
    {
        return (
            (delegate* unmanaged<ISyncMgrResolutionHandler, SYNCMGR_RESOLUTION_FEEDBACK*, int>)(
                (*lpVtbl)[6]
            )
        )(this, pFeedback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT KeepItems(
        ISyncMgrConflictResolutionItems pArray,
        SYNCMGR_RESOLUTION_FEEDBACK* pFeedback
    )
    {
        return (
            (delegate* unmanaged<
                ISyncMgrResolutionHandler,
                ISyncMgrConflictResolutionItems,
                SYNCMGR_RESOLUTION_FEEDBACK*,
                int>)((*lpVtbl)[7])
        )(this, pArray, pFeedback);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryAbilities(
            [NativeTypeName("SYNCMGR_RESOLUTION_ABILITIES_FLAGS *")] uint* pdwAbilities
        );

        [VtblIndex(4)]
        HRESULT KeepOther(IShellItem psiOther, SYNCMGR_RESOLUTION_FEEDBACK* pFeedback);

        [VtblIndex(5)]
        HRESULT KeepRecent(SYNCMGR_RESOLUTION_FEEDBACK* pFeedback);

        [VtblIndex(6)]
        HRESULT RemoveFromSyncSet(SYNCMGR_RESOLUTION_FEEDBACK* pFeedback);

        [VtblIndex(7)]
        HRESULT KeepItems(
            ISyncMgrConflictResolutionItems pArray,
            SYNCMGR_RESOLUTION_FEEDBACK* pFeedback
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

        [NativeTypeName("HRESULT (SYNCMGR_RESOLUTION_ABILITIES_FLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> QueryAbilities;

        [NativeTypeName(
            "HRESULT (IShellItem *, SYNCMGR_RESOLUTION_FEEDBACK *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItem, SYNCMGR_RESOLUTION_FEEDBACK*, int> KeepOther;

        [NativeTypeName("HRESULT (SYNCMGR_RESOLUTION_FEEDBACK *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_RESOLUTION_FEEDBACK*, int> KeepRecent;

        [NativeTypeName("HRESULT (SYNCMGR_RESOLUTION_FEEDBACK *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_RESOLUTION_FEEDBACK*, int> RemoveFromSyncSet;

        [NativeTypeName(
            "HRESULT (ISyncMgrConflictResolutionItems *, SYNCMGR_RESOLUTION_FEEDBACK *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISyncMgrConflictResolutionItems,
            SYNCMGR_RESOLUTION_FEEDBACK*,
            int> KeepItems;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrResolutionHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrResolutionHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrResolutionHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrResolutionHandler(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrResolutionHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrResolutionHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrResolutionHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrResolutionHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
