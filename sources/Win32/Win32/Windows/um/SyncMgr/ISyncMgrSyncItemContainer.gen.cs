// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("90701133-BE32-4129-A65C-99E616CAFFF4")]
[NativeTypeName("struct ISyncMgrSyncItemContainer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSyncItemContainer
    : ISyncMgrSyncItemContainer.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrSyncItemContainer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemContainer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISyncMgrSyncItemContainer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemContainer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSyncItem(
        [NativeTypeName("LPCWSTR")] ushort* pszItemID,
        ISyncMgrSyncItem* ppItem
    )
    {
        return (
            (delegate* unmanaged<ISyncMgrSyncItemContainer, ushort*, ISyncMgrSyncItem*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pszItemID, ppItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSyncItemEnumerator(IEnumSyncMgrSyncItems* ppenum)
    {
        return (
            (delegate* unmanaged<ISyncMgrSyncItemContainer, IEnumSyncMgrSyncItems*, int>)(
                (*lpVtbl)[4]
            )
        )(this, ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSyncItemCount([NativeTypeName("ULONG *")] uint* pcItems)
    {
        return ((delegate* unmanaged<ISyncMgrSyncItemContainer, uint*, int>)((*lpVtbl)[5]))(
            this,
            pcItems
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSyncItem(
            [NativeTypeName("LPCWSTR")] ushort* pszItemID,
            ISyncMgrSyncItem* ppItem
        );

        [VtblIndex(4)]
        HRESULT GetSyncItemEnumerator(IEnumSyncMgrSyncItems* ppenum);

        [VtblIndex(5)]
        HRESULT GetSyncItemCount([NativeTypeName("ULONG *")] uint* pcItems);
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

        [NativeTypeName("HRESULT (LPCWSTR, ISyncMgrSyncItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ISyncMgrSyncItem*, int> GetSyncItem;

        [NativeTypeName("HRESULT (IEnumSyncMgrSyncItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSyncMgrSyncItems*, int> GetSyncItemEnumerator;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSyncItemCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrSyncItemContainer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrSyncItemContainer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrSyncItemContainer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrSyncItemContainer(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrSyncItemContainer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrSyncItemContainer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrSyncItemContainer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrSyncItemContainer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
