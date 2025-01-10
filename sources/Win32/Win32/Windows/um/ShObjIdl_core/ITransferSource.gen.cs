// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00ADB003-BDE9-45C6-8E29-D09F9353E108")]
[NativeTypeName("struct ITransferSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITransferSource : ITransferSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITransferSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITransferSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITransferSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITransferSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(ITransferAdviseSink psink, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return (
            (delegate* unmanaged<ITransferSource, ITransferAdviseSink, uint*, int>)((*lpVtbl)[3])
        )(this, psink, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<ITransferSource, uint, int>)((*lpVtbl)[4]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetProperties(IPropertyChangeArray pproparray)
    {
        return ((delegate* unmanaged<ITransferSource, IPropertyChangeArray, int>)((*lpVtbl)[5]))(
            this,
            pproparray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenItem(
        IShellItem psi,
        [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<ITransferSource, IShellItem, uint, Guid*, void**, int>)(
                (*lpVtbl)[6]
            )
        )(this, psi, flags, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT MoveItem(
        IShellItem psi,
        IShellItem psiParentDst,
        [NativeTypeName("LPCWSTR")] ushort* pszNameDst,
        [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
        IShellItem* ppsiNew
    )
    {
        return (
            (delegate* unmanaged<
                ITransferSource,
                IShellItem,
                IShellItem,
                ushort*,
                uint,
                IShellItem*,
                int>)((*lpVtbl)[7])
        )(this, psi, psiParentDst, pszNameDst, flags, ppsiNew);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RecycleItem(
        IShellItem psiSource,
        IShellItem psiParentDest,
        [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
        IShellItem* ppsiNewDest
    )
    {
        return (
            (delegate* unmanaged<ITransferSource, IShellItem, IShellItem, uint, IShellItem*, int>)(
                (*lpVtbl)[8]
            )
        )(this, psiSource, psiParentDest, flags, ppsiNewDest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveItem(
        IShellItem psiSource,
        [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags
    )
    {
        return ((delegate* unmanaged<ITransferSource, IShellItem, uint, int>)((*lpVtbl)[9]))(
            this,
            psiSource,
            flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RenameItem(
        IShellItem psiSource,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName,
        [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
        IShellItem* ppsiNewDest
    )
    {
        return (
            (delegate* unmanaged<ITransferSource, IShellItem, ushort*, uint, IShellItem*, int>)(
                (*lpVtbl)[10]
            )
        )(this, psiSource, pszNewName, flags, ppsiNewDest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT LinkItem(
        IShellItem psiSource,
        IShellItem psiParentDest,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName,
        [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
        IShellItem* ppsiNewDest
    )
    {
        return (
            (delegate* unmanaged<
                ITransferSource,
                IShellItem,
                IShellItem,
                ushort*,
                uint,
                IShellItem*,
                int>)((*lpVtbl)[11])
        )(this, psiSource, psiParentDest, pszNewName, flags, ppsiNewDest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ApplyPropertiesToItem(IShellItem psiSource, IShellItem* ppsiNew)
    {
        return (
            (delegate* unmanaged<ITransferSource, IShellItem, IShellItem*, int>)((*lpVtbl)[12])
        )(this, psiSource, ppsiNew);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDefaultDestinationName(
        IShellItem psiSource,
        IShellItem psiParentDest,
        [NativeTypeName("LPWSTR *")] ushort** ppszDestinationName
    )
    {
        return (
            (delegate* unmanaged<ITransferSource, IShellItem, IShellItem, ushort**, int>)(
                (*lpVtbl)[13]
            )
        )(this, psiSource, psiParentDest, ppszDestinationName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnterFolder(IShellItem psiChildFolderDest)
    {
        return ((delegate* unmanaged<ITransferSource, IShellItem, int>)((*lpVtbl)[14]))(
            this,
            psiChildFolderDest
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT LeaveFolder(IShellItem psiChildFolderDest)
    {
        return ((delegate* unmanaged<ITransferSource, IShellItem, int>)((*lpVtbl)[15]))(
            this,
            psiChildFolderDest
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Advise(ITransferAdviseSink psink, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [VtblIndex(4)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(5)]
        HRESULT SetProperties(IPropertyChangeArray pproparray);

        [VtblIndex(6)]
        HRESULT OpenItem(
            IShellItem psi,
            [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(7)]
        HRESULT MoveItem(
            IShellItem psi,
            IShellItem psiParentDst,
            [NativeTypeName("LPCWSTR")] ushort* pszNameDst,
            [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
            IShellItem* ppsiNew
        );

        [VtblIndex(8)]
        HRESULT RecycleItem(
            IShellItem psiSource,
            IShellItem psiParentDest,
            [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
            IShellItem* ppsiNewDest
        );

        [VtblIndex(9)]
        HRESULT RemoveItem(
            IShellItem psiSource,
            [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags
        );

        [VtblIndex(10)]
        HRESULT RenameItem(
            IShellItem psiSource,
            [NativeTypeName("LPCWSTR")] ushort* pszNewName,
            [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
            IShellItem* ppsiNewDest
        );

        [VtblIndex(11)]
        HRESULT LinkItem(
            IShellItem psiSource,
            IShellItem psiParentDest,
            [NativeTypeName("LPCWSTR")] ushort* pszNewName,
            [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
            IShellItem* ppsiNewDest
        );

        [VtblIndex(12)]
        HRESULT ApplyPropertiesToItem(IShellItem psiSource, IShellItem* ppsiNew);

        [VtblIndex(13)]
        HRESULT GetDefaultDestinationName(
            IShellItem psiSource,
            IShellItem psiParentDest,
            [NativeTypeName("LPWSTR *")] ushort** ppszDestinationName
        );

        [VtblIndex(14)]
        HRESULT EnterFolder(IShellItem psiChildFolderDest);

        [VtblIndex(15)]
        HRESULT LeaveFolder(IShellItem psiChildFolderDest);
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

        [NativeTypeName("HRESULT (ITransferAdviseSink *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITransferAdviseSink, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;

        [NativeTypeName("HRESULT (IPropertyChangeArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyChangeArray, int> SetProperties;

        [NativeTypeName(
            "HRESULT (IShellItem *, TRANSFER_SOURCE_FLAGS, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItem, uint, Guid*, void**, int> OpenItem;

        [NativeTypeName(
            "HRESULT (IShellItem *, IShellItem *, LPCWSTR, TRANSFER_SOURCE_FLAGS, IShellItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItem,
            ushort*,
            uint,
            IShellItem*,
            int> MoveItem;

        [NativeTypeName(
            "HRESULT (IShellItem *, IShellItem *, TRANSFER_SOURCE_FLAGS, IShellItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItem,
            uint,
            IShellItem*,
            int> RecycleItem;

        [NativeTypeName("HRESULT (IShellItem *, TRANSFER_SOURCE_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, uint, int> RemoveItem;

        [NativeTypeName(
            "HRESULT (IShellItem *, LPCWSTR, TRANSFER_SOURCE_FLAGS, IShellItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItem, ushort*, uint, IShellItem*, int> RenameItem;

        [NativeTypeName(
            "HRESULT (IShellItem *, IShellItem *, LPCWSTR, TRANSFER_SOURCE_FLAGS, IShellItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItem,
            ushort*,
            uint,
            IShellItem*,
            int> LinkItem;

        [NativeTypeName("HRESULT (IShellItem *, IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, IShellItem*, int> ApplyPropertiesToItem;

        [NativeTypeName("HRESULT (IShellItem *, IShellItem *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItem,
            ushort**,
            int> GetDefaultDestinationName;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> EnterFolder;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> LeaveFolder;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITransferSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITransferSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITransferSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITransferSource(Silk.NET.Windows.IUnknown value)
    {
        return new ITransferSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITransferSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITransferSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITransferSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
