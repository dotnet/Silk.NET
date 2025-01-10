// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CD8F23C1-8F61-4916-909D-55BDD0918753")]
[NativeTypeName("struct IFileOperation2 : IFileOperation")]
[NativeInheritance("IFileOperation")]
public unsafe partial struct IFileOperation2 : IFileOperation2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileOperation2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileOperation2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileOperation2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileOperation2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(
        IFileOperationProgressSink pfops,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return (
            (delegate* unmanaged<IFileOperation2, IFileOperationProgressSink, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pfops, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IFileOperation2, uint, int>)((*lpVtbl)[4]))(this, dwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOperationFlags([NativeTypeName("DWORD")] uint dwOperationFlags)
    {
        return ((delegate* unmanaged<IFileOperation2, uint, int>)((*lpVtbl)[5]))(
            this,
            dwOperationFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetProgressMessage([NativeTypeName("LPCWSTR")] ushort* pszMessage)
    {
        return ((delegate* unmanaged<IFileOperation2, ushort*, int>)((*lpVtbl)[6]))(
            this,
            pszMessage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetProgressDialog(IOperationsProgressDialog popd)
    {
        return (
            (delegate* unmanaged<IFileOperation2, IOperationsProgressDialog, int>)((*lpVtbl)[7])
        )(this, popd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetProperties(IPropertyChangeArray pproparray)
    {
        return ((delegate* unmanaged<IFileOperation2, IPropertyChangeArray, int>)((*lpVtbl)[8]))(
            this,
            pproparray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetOwnerWindow(HWND hwndOwner)
    {
        return ((delegate* unmanaged<IFileOperation2, HWND, int>)((*lpVtbl)[9]))(this, hwndOwner);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ApplyPropertiesToItem(IShellItem psiItem)
    {
        return ((delegate* unmanaged<IFileOperation2, IShellItem, int>)((*lpVtbl)[10]))(
            this,
            psiItem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ApplyPropertiesToItems(IUnknown punkItems)
    {
        return ((delegate* unmanaged<IFileOperation2, IUnknown, int>)((*lpVtbl)[11]))(
            this,
            punkItems
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RenameItem(
        IShellItem psiItem,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName,
        IFileOperationProgressSink pfopsItem
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperation2,
                IShellItem,
                ushort*,
                IFileOperationProgressSink,
                int>)((*lpVtbl)[12])
        )(this, psiItem, pszNewName, pfopsItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RenameItems(IUnknown pUnkItems, [NativeTypeName("LPCWSTR")] ushort* pszNewName)
    {
        return ((delegate* unmanaged<IFileOperation2, IUnknown, ushort*, int>)((*lpVtbl)[13]))(
            this,
            pUnkItems,
            pszNewName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT MoveItem(
        IShellItem psiItem,
        IShellItem psiDestinationFolder,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName,
        IFileOperationProgressSink pfopsItem
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperation2,
                IShellItem,
                IShellItem,
                ushort*,
                IFileOperationProgressSink,
                int>)((*lpVtbl)[14])
        )(this, psiItem, psiDestinationFolder, pszNewName, pfopsItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT MoveItems(IUnknown punkItems, IShellItem psiDestinationFolder)
    {
        return ((delegate* unmanaged<IFileOperation2, IUnknown, IShellItem, int>)((*lpVtbl)[15]))(
            this,
            punkItems,
            psiDestinationFolder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CopyItem(
        IShellItem psiItem,
        IShellItem psiDestinationFolder,
        [NativeTypeName("LPCWSTR")] ushort* pszCopyName,
        IFileOperationProgressSink pfopsItem
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperation2,
                IShellItem,
                IShellItem,
                ushort*,
                IFileOperationProgressSink,
                int>)((*lpVtbl)[16])
        )(this, psiItem, psiDestinationFolder, pszCopyName, pfopsItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CopyItems(IUnknown punkItems, IShellItem psiDestinationFolder)
    {
        return ((delegate* unmanaged<IFileOperation2, IUnknown, IShellItem, int>)((*lpVtbl)[17]))(
            this,
            punkItems,
            psiDestinationFolder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DeleteItem(IShellItem psiItem, IFileOperationProgressSink pfopsItem)
    {
        return (
            (delegate* unmanaged<IFileOperation2, IShellItem, IFileOperationProgressSink, int>)(
                (*lpVtbl)[18]
            )
        )(this, psiItem, pfopsItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DeleteItems(IUnknown punkItems)
    {
        return ((delegate* unmanaged<IFileOperation2, IUnknown, int>)((*lpVtbl)[19]))(
            this,
            punkItems
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT NewItem(
        IShellItem psiDestinationFolder,
        [NativeTypeName("DWORD")] uint dwFileAttributes,
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        [NativeTypeName("LPCWSTR")] ushort* pszTemplateName,
        IFileOperationProgressSink pfopsItem
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperation2,
                IShellItem,
                uint,
                ushort*,
                ushort*,
                IFileOperationProgressSink,
                int>)((*lpVtbl)[20])
        )(this, psiDestinationFolder, dwFileAttributes, pszName, pszTemplateName, pfopsItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT PerformOperations()
    {
        return ((delegate* unmanaged<IFileOperation2, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetAnyOperationsAborted(BOOL* pfAnyOperationsAborted)
    {
        return ((delegate* unmanaged<IFileOperation2, BOOL*, int>)((*lpVtbl)[22]))(
            this,
            pfAnyOperationsAborted
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetOperationFlags2(FILE_OPERATION_FLAGS2 operationFlags2)
    {
        return ((delegate* unmanaged<IFileOperation2, FILE_OPERATION_FLAGS2, int>)((*lpVtbl)[23]))(
            this,
            operationFlags2
        );
    }

    public interface Interface : IFileOperation.Interface
    {
        [VtblIndex(23)]
        HRESULT SetOperationFlags2(FILE_OPERATION_FLAGS2 operationFlags2);
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

        [NativeTypeName("HRESULT (IFileOperationProgressSink *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileOperationProgressSink, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetOperationFlags;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetProgressMessage;

        [NativeTypeName("HRESULT (IOperationsProgressDialog *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOperationsProgressDialog, int> SetProgressDialog;

        [NativeTypeName("HRESULT (IPropertyChangeArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyChangeArray, int> SetProperties;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> SetOwnerWindow;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> ApplyPropertiesToItem;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> ApplyPropertiesToItems;

        [NativeTypeName(
            "HRESULT (IShellItem *, LPCWSTR, IFileOperationProgressSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            ushort*,
            IFileOperationProgressSink,
            int> RenameItem;

        [NativeTypeName("HRESULT (IUnknown *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, ushort*, int> RenameItems;

        [NativeTypeName(
            "HRESULT (IShellItem *, IShellItem *, LPCWSTR, IFileOperationProgressSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItem,
            ushort*,
            IFileOperationProgressSink,
            int> MoveItem;

        [NativeTypeName("HRESULT (IUnknown *, IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, IShellItem, int> MoveItems;

        [NativeTypeName(
            "HRESULT (IShellItem *, IShellItem *, LPCWSTR, IFileOperationProgressSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            IShellItem,
            ushort*,
            IFileOperationProgressSink,
            int> CopyItem;

        [NativeTypeName("HRESULT (IUnknown *, IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, IShellItem, int> CopyItems;

        [NativeTypeName(
            "HRESULT (IShellItem *, IFileOperationProgressSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItem, IFileOperationProgressSink, int> DeleteItem;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> DeleteItems;

        [NativeTypeName(
            "HRESULT (IShellItem *, DWORD, LPCWSTR, LPCWSTR, IFileOperationProgressSink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            uint,
            ushort*,
            ushort*,
            IFileOperationProgressSink,
            int> NewItem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PerformOperations;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetAnyOperationsAborted;

        [NativeTypeName("HRESULT (FILE_OPERATION_FLAGS2) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILE_OPERATION_FLAGS2, int> SetOperationFlags2;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileOperation2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileOperation2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IFileOperation"/> to <see cref = "IFileOperation2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IFileOperation"/> instance to be converted </param>
    public static explicit operator IFileOperation2(Silk.NET.Windows.IFileOperation value)
    {
        return new IFileOperation2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileOperation2"/> to <see cref = "Silk.NET.Windows.IFileOperation"/>.</summary>
    /// <param name = "value">The <see cref = "IFileOperation2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IFileOperation(IFileOperation2 value)
    {
        return new Silk.NET.Windows.IFileOperation(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileOperation2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileOperation2(Silk.NET.Windows.IUnknown value)
    {
        return new IFileOperation2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileOperation2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileOperation2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileOperation2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
