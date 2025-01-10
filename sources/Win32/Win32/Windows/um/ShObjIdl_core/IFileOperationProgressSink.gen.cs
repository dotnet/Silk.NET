// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("04B0F1A7-9490-44BC-96E1-4296A31252E2")]
[NativeTypeName("struct IFileOperationProgressSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileOperationProgressSink
    : IFileOperationProgressSink.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileOperationProgressSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IFileOperationProgressSink, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileOperationProgressSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileOperationProgressSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StartOperations()
    {
        return ((delegate* unmanaged<IFileOperationProgressSink, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FinishOperations(HRESULT hrResult)
    {
        return ((delegate* unmanaged<IFileOperationProgressSink, HRESULT, int>)((*lpVtbl)[4]))(
            this,
            hrResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT PreRenameItem(
        [NativeTypeName("DWORD")] uint dwFlags,
        IShellItem psiItem,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName
    )
    {
        return (
            (delegate* unmanaged<IFileOperationProgressSink, uint, IShellItem, ushort*, int>)(
                (*lpVtbl)[5]
            )
        )(this, dwFlags, psiItem, pszNewName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PostRenameItem(
        [NativeTypeName("DWORD")] uint dwFlags,
        IShellItem psiItem,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName,
        HRESULT hrRename,
        IShellItem psiNewlyCreated
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperationProgressSink,
                uint,
                IShellItem,
                ushort*,
                HRESULT,
                IShellItem,
                int>)((*lpVtbl)[6])
        )(this, dwFlags, psiItem, pszNewName, hrRename, psiNewlyCreated);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PreMoveItem(
        [NativeTypeName("DWORD")] uint dwFlags,
        IShellItem psiItem,
        IShellItem psiDestinationFolder,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperationProgressSink,
                uint,
                IShellItem,
                IShellItem,
                ushort*,
                int>)((*lpVtbl)[7])
        )(this, dwFlags, psiItem, psiDestinationFolder, pszNewName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PostMoveItem(
        [NativeTypeName("DWORD")] uint dwFlags,
        IShellItem psiItem,
        IShellItem psiDestinationFolder,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName,
        HRESULT hrMove,
        IShellItem psiNewlyCreated
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperationProgressSink,
                uint,
                IShellItem,
                IShellItem,
                ushort*,
                HRESULT,
                IShellItem,
                int>)((*lpVtbl)[8])
        )(this, dwFlags, psiItem, psiDestinationFolder, pszNewName, hrMove, psiNewlyCreated);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PreCopyItem(
        [NativeTypeName("DWORD")] uint dwFlags,
        IShellItem psiItem,
        IShellItem psiDestinationFolder,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperationProgressSink,
                uint,
                IShellItem,
                IShellItem,
                ushort*,
                int>)((*lpVtbl)[9])
        )(this, dwFlags, psiItem, psiDestinationFolder, pszNewName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT PostCopyItem(
        [NativeTypeName("DWORD")] uint dwFlags,
        IShellItem psiItem,
        IShellItem psiDestinationFolder,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName,
        HRESULT hrCopy,
        IShellItem psiNewlyCreated
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperationProgressSink,
                uint,
                IShellItem,
                IShellItem,
                ushort*,
                HRESULT,
                IShellItem,
                int>)((*lpVtbl)[10])
        )(this, dwFlags, psiItem, psiDestinationFolder, pszNewName, hrCopy, psiNewlyCreated);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT PreDeleteItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem psiItem)
    {
        return (
            (delegate* unmanaged<IFileOperationProgressSink, uint, IShellItem, int>)((*lpVtbl)[11])
        )(this, dwFlags, psiItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PostDeleteItem(
        [NativeTypeName("DWORD")] uint dwFlags,
        IShellItem psiItem,
        HRESULT hrDelete,
        IShellItem psiNewlyCreated
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperationProgressSink,
                uint,
                IShellItem,
                HRESULT,
                IShellItem,
                int>)((*lpVtbl)[12])
        )(this, dwFlags, psiItem, hrDelete, psiNewlyCreated);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT PreNewItem(
        [NativeTypeName("DWORD")] uint dwFlags,
        IShellItem psiDestinationFolder,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName
    )
    {
        return (
            (delegate* unmanaged<IFileOperationProgressSink, uint, IShellItem, ushort*, int>)(
                (*lpVtbl)[13]
            )
        )(this, dwFlags, psiDestinationFolder, pszNewName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT PostNewItem(
        [NativeTypeName("DWORD")] uint dwFlags,
        IShellItem psiDestinationFolder,
        [NativeTypeName("LPCWSTR")] ushort* pszNewName,
        [NativeTypeName("LPCWSTR")] ushort* pszTemplateName,
        [NativeTypeName("DWORD")] uint dwFileAttributes,
        HRESULT hrNew,
        IShellItem psiNewItem
    )
    {
        return (
            (delegate* unmanaged<
                IFileOperationProgressSink,
                uint,
                IShellItem,
                ushort*,
                ushort*,
                uint,
                HRESULT,
                IShellItem,
                int>)((*lpVtbl)[14])
        )(
            this,
            dwFlags,
            psiDestinationFolder,
            pszNewName,
            pszTemplateName,
            dwFileAttributes,
            hrNew,
            psiNewItem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT UpdateProgress(uint iWorkTotal, uint iWorkSoFar)
    {
        return ((delegate* unmanaged<IFileOperationProgressSink, uint, uint, int>)((*lpVtbl)[15]))(
            this,
            iWorkTotal,
            iWorkSoFar
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ResetTimer()
    {
        return ((delegate* unmanaged<IFileOperationProgressSink, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PauseTimer()
    {
        return ((delegate* unmanaged<IFileOperationProgressSink, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ResumeTimer()
    {
        return ((delegate* unmanaged<IFileOperationProgressSink, int>)((*lpVtbl)[18]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT StartOperations();

        [VtblIndex(4)]
        HRESULT FinishOperations(HRESULT hrResult);

        [VtblIndex(5)]
        HRESULT PreRenameItem(
            [NativeTypeName("DWORD")] uint dwFlags,
            IShellItem psiItem,
            [NativeTypeName("LPCWSTR")] ushort* pszNewName
        );

        [VtblIndex(6)]
        HRESULT PostRenameItem(
            [NativeTypeName("DWORD")] uint dwFlags,
            IShellItem psiItem,
            [NativeTypeName("LPCWSTR")] ushort* pszNewName,
            HRESULT hrRename,
            IShellItem psiNewlyCreated
        );

        [VtblIndex(7)]
        HRESULT PreMoveItem(
            [NativeTypeName("DWORD")] uint dwFlags,
            IShellItem psiItem,
            IShellItem psiDestinationFolder,
            [NativeTypeName("LPCWSTR")] ushort* pszNewName
        );

        [VtblIndex(8)]
        HRESULT PostMoveItem(
            [NativeTypeName("DWORD")] uint dwFlags,
            IShellItem psiItem,
            IShellItem psiDestinationFolder,
            [NativeTypeName("LPCWSTR")] ushort* pszNewName,
            HRESULT hrMove,
            IShellItem psiNewlyCreated
        );

        [VtblIndex(9)]
        HRESULT PreCopyItem(
            [NativeTypeName("DWORD")] uint dwFlags,
            IShellItem psiItem,
            IShellItem psiDestinationFolder,
            [NativeTypeName("LPCWSTR")] ushort* pszNewName
        );

        [VtblIndex(10)]
        HRESULT PostCopyItem(
            [NativeTypeName("DWORD")] uint dwFlags,
            IShellItem psiItem,
            IShellItem psiDestinationFolder,
            [NativeTypeName("LPCWSTR")] ushort* pszNewName,
            HRESULT hrCopy,
            IShellItem psiNewlyCreated
        );

        [VtblIndex(11)]
        HRESULT PreDeleteItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem psiItem);

        [VtblIndex(12)]
        HRESULT PostDeleteItem(
            [NativeTypeName("DWORD")] uint dwFlags,
            IShellItem psiItem,
            HRESULT hrDelete,
            IShellItem psiNewlyCreated
        );

        [VtblIndex(13)]
        HRESULT PreNewItem(
            [NativeTypeName("DWORD")] uint dwFlags,
            IShellItem psiDestinationFolder,
            [NativeTypeName("LPCWSTR")] ushort* pszNewName
        );

        [VtblIndex(14)]
        HRESULT PostNewItem(
            [NativeTypeName("DWORD")] uint dwFlags,
            IShellItem psiDestinationFolder,
            [NativeTypeName("LPCWSTR")] ushort* pszNewName,
            [NativeTypeName("LPCWSTR")] ushort* pszTemplateName,
            [NativeTypeName("DWORD")] uint dwFileAttributes,
            HRESULT hrNew,
            IShellItem psiNewItem
        );

        [VtblIndex(15)]
        HRESULT UpdateProgress(uint iWorkTotal, uint iWorkSoFar);

        [VtblIndex(16)]
        HRESULT ResetTimer();

        [VtblIndex(17)]
        HRESULT PauseTimer();

        [VtblIndex(18)]
        HRESULT ResumeTimer();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StartOperations;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> FinishOperations;

        [NativeTypeName("HRESULT (DWORD, IShellItem *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IShellItem, ushort*, int> PreRenameItem;

        [NativeTypeName(
            "HRESULT (DWORD, IShellItem *, LPCWSTR, HRESULT, IShellItem *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IShellItem,
            ushort*,
            HRESULT,
            IShellItem,
            int> PostRenameItem;

        [NativeTypeName(
            "HRESULT (DWORD, IShellItem *, IShellItem *, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IShellItem, IShellItem, ushort*, int> PreMoveItem;

        [NativeTypeName(
            "HRESULT (DWORD, IShellItem *, IShellItem *, LPCWSTR, HRESULT, IShellItem *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IShellItem,
            IShellItem,
            ushort*,
            HRESULT,
            IShellItem,
            int> PostMoveItem;

        [NativeTypeName(
            "HRESULT (DWORD, IShellItem *, IShellItem *, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IShellItem, IShellItem, ushort*, int> PreCopyItem;

        [NativeTypeName(
            "HRESULT (DWORD, IShellItem *, IShellItem *, LPCWSTR, HRESULT, IShellItem *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IShellItem,
            IShellItem,
            ushort*,
            HRESULT,
            IShellItem,
            int> PostCopyItem;

        [NativeTypeName("HRESULT (DWORD, IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IShellItem, int> PreDeleteItem;

        [NativeTypeName(
            "HRESULT (DWORD, IShellItem *, HRESULT, IShellItem *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IShellItem,
            HRESULT,
            IShellItem,
            int> PostDeleteItem;

        [NativeTypeName("HRESULT (DWORD, IShellItem *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IShellItem, ushort*, int> PreNewItem;

        [NativeTypeName(
            "HRESULT (DWORD, IShellItem *, LPCWSTR, LPCWSTR, DWORD, HRESULT, IShellItem *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IShellItem,
            ushort*,
            ushort*,
            uint,
            HRESULT,
            IShellItem,
            int> PostNewItem;

        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> UpdateProgress;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetTimer;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PauseTimer;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResumeTimer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileOperationProgressSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileOperationProgressSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileOperationProgressSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileOperationProgressSink(Silk.NET.Windows.IUnknown value)
    {
        return new IFileOperationProgressSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileOperationProgressSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileOperationProgressSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileOperationProgressSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
