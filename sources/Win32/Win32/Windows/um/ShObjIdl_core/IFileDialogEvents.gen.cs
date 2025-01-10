// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("973510DB-7D7F-452B-8975-74A85828D354")]
[NativeTypeName("struct IFileDialogEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileDialogEvents : IFileDialogEvents.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileDialogEvents));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileDialogEvents, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileDialogEvents, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileDialogEvents, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnFileOk(IFileDialog pfd)
    {
        return ((delegate* unmanaged<IFileDialogEvents, IFileDialog, int>)((*lpVtbl)[3]))(
            this,
            pfd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnFolderChanging(IFileDialog pfd, IShellItem psiFolder)
    {
        return (
            (delegate* unmanaged<IFileDialogEvents, IFileDialog, IShellItem, int>)((*lpVtbl)[4])
        )(this, pfd, psiFolder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnFolderChange(IFileDialog pfd)
    {
        return ((delegate* unmanaged<IFileDialogEvents, IFileDialog, int>)((*lpVtbl)[5]))(
            this,
            pfd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnSelectionChange(IFileDialog pfd)
    {
        return ((delegate* unmanaged<IFileDialogEvents, IFileDialog, int>)((*lpVtbl)[6]))(
            this,
            pfd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnShareViolation(
        IFileDialog pfd,
        IShellItem psi,
        FDE_SHAREVIOLATION_RESPONSE* pResponse
    )
    {
        return (
            (delegate* unmanaged<
                IFileDialogEvents,
                IFileDialog,
                IShellItem,
                FDE_SHAREVIOLATION_RESPONSE*,
                int>)((*lpVtbl)[7])
        )(this, pfd, psi, pResponse);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnTypeChange(IFileDialog pfd)
    {
        return ((delegate* unmanaged<IFileDialogEvents, IFileDialog, int>)((*lpVtbl)[8]))(
            this,
            pfd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnOverwrite(IFileDialog pfd, IShellItem psi, FDE_OVERWRITE_RESPONSE* pResponse)
    {
        return (
            (delegate* unmanaged<
                IFileDialogEvents,
                IFileDialog,
                IShellItem,
                FDE_OVERWRITE_RESPONSE*,
                int>)((*lpVtbl)[9])
        )(this, pfd, psi, pResponse);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnFileOk(IFileDialog pfd);

        [VtblIndex(4)]
        HRESULT OnFolderChanging(IFileDialog pfd, IShellItem psiFolder);

        [VtblIndex(5)]
        HRESULT OnFolderChange(IFileDialog pfd);

        [VtblIndex(6)]
        HRESULT OnSelectionChange(IFileDialog pfd);

        [VtblIndex(7)]
        HRESULT OnShareViolation(
            IFileDialog pfd,
            IShellItem psi,
            FDE_SHAREVIOLATION_RESPONSE* pResponse
        );

        [VtblIndex(8)]
        HRESULT OnTypeChange(IFileDialog pfd);

        [VtblIndex(9)]
        HRESULT OnOverwrite(IFileDialog pfd, IShellItem psi, FDE_OVERWRITE_RESPONSE* pResponse);
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

        [NativeTypeName("HRESULT (IFileDialog *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileDialog, int> OnFileOk;

        [NativeTypeName("HRESULT (IFileDialog *, IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileDialog, IShellItem, int> OnFolderChanging;

        [NativeTypeName("HRESULT (IFileDialog *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileDialog, int> OnFolderChange;

        [NativeTypeName("HRESULT (IFileDialog *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileDialog, int> OnSelectionChange;

        [NativeTypeName(
            "HRESULT (IFileDialog *, IShellItem *, FDE_SHAREVIOLATION_RESPONSE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IFileDialog,
            IShellItem,
            FDE_SHAREVIOLATION_RESPONSE*,
            int> OnShareViolation;

        [NativeTypeName("HRESULT (IFileDialog *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileDialog, int> OnTypeChange;

        [NativeTypeName(
            "HRESULT (IFileDialog *, IShellItem *, FDE_OVERWRITE_RESPONSE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IFileDialog,
            IShellItem,
            FDE_OVERWRITE_RESPONSE*,
            int> OnOverwrite;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileDialogEvents"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileDialogEvents(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileDialogEvents"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileDialogEvents(Silk.NET.Windows.IUnknown value)
    {
        return new IFileDialogEvents(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileDialogEvents"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileDialogEvents"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileDialogEvents value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
