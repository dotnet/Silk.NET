// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C405A219-25A2-442E-8743-B845A2CEE93F")]
[NativeTypeName("struct ISyncMgrConflictResolveInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrConflictResolveInfo
    : ISyncMgrConflictResolveInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrConflictResolveInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISyncMgrConflictResolveInfo, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIterationInfo(
        uint* pnCurrentConflict,
        uint* pcConflicts,
        uint* pcRemainingForApplyToAll
    )
    {
        return (
            (delegate* unmanaged<ISyncMgrConflictResolveInfo, uint*, uint*, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pnCurrentConflict, pcConflicts, pcRemainingForApplyToAll);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP* pnPresenterNextStep)
    {
        return (
            (delegate* unmanaged<ISyncMgrConflictResolveInfo, SYNCMGR_PRESENTER_NEXT_STEP*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pnPresenterNextStep);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPresenterChoice(
        SYNCMGR_PRESENTER_CHOICE* pnPresenterChoice,
        BOOL* pfApplyToAll
    )
    {
        return (
            (delegate* unmanaged<
                ISyncMgrConflictResolveInfo,
                SYNCMGR_PRESENTER_CHOICE*,
                BOOL*,
                int>)((*lpVtbl)[5])
        )(this, pnPresenterChoice, pfApplyToAll);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetItemChoiceCount(uint* pcChoices)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo, uint*, int>)((*lpVtbl)[6]))(
            this,
            pcChoices
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetItemChoice(uint iChoice, uint* piChoiceIndex)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo, uint, uint*, int>)((*lpVtbl)[7]))(
            this,
            iChoice,
            piChoiceIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP nPresenterNextStep)
    {
        return (
            (delegate* unmanaged<ISyncMgrConflictResolveInfo, SYNCMGR_PRESENTER_NEXT_STEP, int>)(
                (*lpVtbl)[8]
            )
        )(this, nPresenterNextStep);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetPresenterChoice(SYNCMGR_PRESENTER_CHOICE nPresenterChoice, BOOL fApplyToAll)
    {
        return (
            (delegate* unmanaged<ISyncMgrConflictResolveInfo, SYNCMGR_PRESENTER_CHOICE, BOOL, int>)(
                (*lpVtbl)[9]
            )
        )(this, nPresenterChoice, fApplyToAll);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetItemChoices(uint* prgiConflictItemIndexes, uint cChoices)
    {
        return (
            (delegate* unmanaged<ISyncMgrConflictResolveInfo, uint*, uint, int>)((*lpVtbl)[10])
        )(this, prgiConflictItemIndexes, cChoices);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIterationInfo(
            uint* pnCurrentConflict,
            uint* pcConflicts,
            uint* pcRemainingForApplyToAll
        );

        [VtblIndex(4)]
        HRESULT GetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP* pnPresenterNextStep);

        [VtblIndex(5)]
        HRESULT GetPresenterChoice(SYNCMGR_PRESENTER_CHOICE* pnPresenterChoice, BOOL* pfApplyToAll);

        [VtblIndex(6)]
        HRESULT GetItemChoiceCount(uint* pcChoices);

        [VtblIndex(7)]
        HRESULT GetItemChoice(uint iChoice, uint* piChoiceIndex);

        [VtblIndex(8)]
        HRESULT SetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP nPresenterNextStep);

        [VtblIndex(9)]
        HRESULT SetPresenterChoice(SYNCMGR_PRESENTER_CHOICE nPresenterChoice, BOOL fApplyToAll);

        [VtblIndex(10)]
        HRESULT SetItemChoices(uint* prgiConflictItemIndexes, uint cChoices);
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

        [NativeTypeName("HRESULT (UINT *, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint*, int> GetIterationInfo;

        [NativeTypeName("HRESULT (SYNCMGR_PRESENTER_NEXT_STEP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_PRESENTER_NEXT_STEP*, int> GetPresenterNextStep;

        [NativeTypeName("HRESULT (SYNCMGR_PRESENTER_CHOICE *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            SYNCMGR_PRESENTER_CHOICE*,
            BOOL*,
            int> GetPresenterChoice;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetItemChoiceCount;

        [NativeTypeName("HRESULT (UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetItemChoice;

        [NativeTypeName("HRESULT (SYNCMGR_PRESENTER_NEXT_STEP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_PRESENTER_NEXT_STEP, int> SetPresenterNextStep;

        [NativeTypeName("HRESULT (SYNCMGR_PRESENTER_CHOICE, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_PRESENTER_CHOICE, BOOL, int> SetPresenterChoice;

        [NativeTypeName("HRESULT (UINT *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint, int> SetItemChoices;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrConflictResolveInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrConflictResolveInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrConflictResolveInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrConflictResolveInfo(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrConflictResolveInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrConflictResolveInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrConflictResolveInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrConflictResolveInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
