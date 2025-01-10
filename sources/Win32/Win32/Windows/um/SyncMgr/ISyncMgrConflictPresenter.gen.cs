// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0B4F5353-FD2B-42CD-8763-4779F2D508A3")]
[NativeTypeName("struct ISyncMgrConflictPresenter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrConflictPresenter
    : ISyncMgrConflictPresenter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrConflictPresenter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrConflictPresenter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISyncMgrConflictPresenter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrConflictPresenter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PresentConflict(
        ISyncMgrConflict pConflict,
        ISyncMgrConflictResolveInfo pResolveInfo
    )
    {
        return (
            (delegate* unmanaged<
                ISyncMgrConflictPresenter,
                ISyncMgrConflict,
                ISyncMgrConflictResolveInfo,
                int>)((*lpVtbl)[3])
        )(this, pConflict, pResolveInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PresentConflict(
            ISyncMgrConflict pConflict,
            ISyncMgrConflictResolveInfo pResolveInfo
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
            "HRESULT (ISyncMgrConflict *, ISyncMgrConflictResolveInfo *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISyncMgrConflict,
            ISyncMgrConflictResolveInfo,
            int> PresentConflict;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrConflictPresenter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrConflictPresenter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrConflictPresenter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrConflictPresenter(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrConflictPresenter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrConflictPresenter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrConflictPresenter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrConflictPresenter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
