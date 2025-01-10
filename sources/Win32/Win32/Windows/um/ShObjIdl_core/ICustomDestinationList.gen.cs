// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6332DEBF-87B5-4670-90C0-5E57B408A49E")]
[NativeTypeName("struct ICustomDestinationList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICustomDestinationList : ICustomDestinationList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICustomDestinationList));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICustomDestinationList, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICustomDestinationList, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICustomDestinationList, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAppID([NativeTypeName("LPCWSTR")] ushort* pszAppID)
    {
        return ((delegate* unmanaged<ICustomDestinationList, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pszAppID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginList(
        uint* pcMinSlots,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<ICustomDestinationList, uint*, Guid*, void**, int>)((*lpVtbl)[4])
        )(this, pcMinSlots, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AppendCategory([NativeTypeName("LPCWSTR")] ushort* pszCategory, IObjectArray poa)
    {
        return (
            (delegate* unmanaged<ICustomDestinationList, ushort*, IObjectArray, int>)((*lpVtbl)[5])
        )(this, pszCategory, poa);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AppendKnownCategory(KNOWNDESTCATEGORY category)
    {
        return (
            (delegate* unmanaged<ICustomDestinationList, KNOWNDESTCATEGORY, int>)((*lpVtbl)[6])
        )(this, category);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddUserTasks(IObjectArray poa)
    {
        return ((delegate* unmanaged<ICustomDestinationList, IObjectArray, int>)((*lpVtbl)[7]))(
            this,
            poa
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CommitList()
    {
        return ((delegate* unmanaged<ICustomDestinationList, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetRemovedDestinations([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ICustomDestinationList, Guid*, void**, int>)((*lpVtbl)[9]))(
            this,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteList([NativeTypeName("LPCWSTR")] ushort* pszAppID)
    {
        return ((delegate* unmanaged<ICustomDestinationList, ushort*, int>)((*lpVtbl)[10]))(
            this,
            pszAppID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AbortList()
    {
        return ((delegate* unmanaged<ICustomDestinationList, int>)((*lpVtbl)[11]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAppID([NativeTypeName("LPCWSTR")] ushort* pszAppID);

        [VtblIndex(4)]
        HRESULT BeginList(uint* pcMinSlots, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(5)]
        HRESULT AppendCategory([NativeTypeName("LPCWSTR")] ushort* pszCategory, IObjectArray poa);

        [VtblIndex(6)]
        HRESULT AppendKnownCategory(KNOWNDESTCATEGORY category);

        [VtblIndex(7)]
        HRESULT AddUserTasks(IObjectArray poa);

        [VtblIndex(8)]
        HRESULT CommitList();

        [VtblIndex(9)]
        HRESULT GetRemovedDestinations([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(10)]
        HRESULT DeleteList([NativeTypeName("LPCWSTR")] ushort* pszAppID);

        [VtblIndex(11)]
        HRESULT AbortList();
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetAppID;

        [NativeTypeName("HRESULT (UINT *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid*, void**, int> BeginList;

        [NativeTypeName("HRESULT (LPCWSTR, IObjectArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IObjectArray, int> AppendCategory;

        [NativeTypeName("HRESULT (KNOWNDESTCATEGORY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, KNOWNDESTCATEGORY, int> AppendKnownCategory;

        [NativeTypeName("HRESULT (IObjectArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IObjectArray, int> AddUserTasks;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CommitList;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetRemovedDestinations;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DeleteList;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> AbortList;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICustomDestinationList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICustomDestinationList(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICustomDestinationList"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICustomDestinationList(Silk.NET.Windows.IUnknown value)
    {
        return new ICustomDestinationList(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICustomDestinationList"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICustomDestinationList"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICustomDestinationList value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
