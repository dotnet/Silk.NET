// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A08CE4D0-FA25-44AB-B57C-C7B1C323E0B9")]
[NativeTypeName("struct IExplorerCommand : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExplorerCommand : IExplorerCommand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExplorerCommand));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExplorerCommand, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IExplorerCommand, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExplorerCommand, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTitle(
        IShellItemArray psiItemArray,
        [NativeTypeName("LPWSTR *")] ushort** ppszName
    )
    {
        return (
            (delegate* unmanaged<IExplorerCommand, IShellItemArray, ushort**, int>)((*lpVtbl)[3])
        )(this, psiItemArray, ppszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIcon(
        IShellItemArray psiItemArray,
        [NativeTypeName("LPWSTR *")] ushort** ppszIcon
    )
    {
        return (
            (delegate* unmanaged<IExplorerCommand, IShellItemArray, ushort**, int>)((*lpVtbl)[4])
        )(this, psiItemArray, ppszIcon);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetToolTip(
        IShellItemArray psiItemArray,
        [NativeTypeName("LPWSTR *")] ushort** ppszInfotip
    )
    {
        return (
            (delegate* unmanaged<IExplorerCommand, IShellItemArray, ushort**, int>)((*lpVtbl)[5])
        )(this, psiItemArray, ppszInfotip);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCanonicalName(Guid* pguidCommandName)
    {
        return ((delegate* unmanaged<IExplorerCommand, Guid*, int>)((*lpVtbl)[6]))(
            this,
            pguidCommandName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetState(
        IShellItemArray psiItemArray,
        BOOL fOkToBeSlow,
        [NativeTypeName("EXPCMDSTATE *")] uint* pCmdState
    )
    {
        return (
            (delegate* unmanaged<IExplorerCommand, IShellItemArray, BOOL, uint*, int>)((*lpVtbl)[7])
        )(this, psiItemArray, fOkToBeSlow, pCmdState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Invoke(IShellItemArray psiItemArray, IBindCtx pbc)
    {
        return (
            (delegate* unmanaged<IExplorerCommand, IShellItemArray, IBindCtx, int>)((*lpVtbl)[8])
        )(this, psiItemArray, pbc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFlags([NativeTypeName("EXPCMDFLAGS *")] uint* pFlags)
    {
        return ((delegate* unmanaged<IExplorerCommand, uint*, int>)((*lpVtbl)[9]))(this, pFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnumSubCommands(IEnumExplorerCommand* ppEnum)
    {
        return ((delegate* unmanaged<IExplorerCommand, IEnumExplorerCommand*, int>)((*lpVtbl)[10]))(
            this,
            ppEnum
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTitle(
            IShellItemArray psiItemArray,
            [NativeTypeName("LPWSTR *")] ushort** ppszName
        );

        [VtblIndex(4)]
        HRESULT GetIcon(
            IShellItemArray psiItemArray,
            [NativeTypeName("LPWSTR *")] ushort** ppszIcon
        );

        [VtblIndex(5)]
        HRESULT GetToolTip(
            IShellItemArray psiItemArray,
            [NativeTypeName("LPWSTR *")] ushort** ppszInfotip
        );

        [VtblIndex(6)]
        HRESULT GetCanonicalName(Guid* pguidCommandName);

        [VtblIndex(7)]
        HRESULT GetState(
            IShellItemArray psiItemArray,
            BOOL fOkToBeSlow,
            [NativeTypeName("EXPCMDSTATE *")] uint* pCmdState
        );

        [VtblIndex(8)]
        HRESULT Invoke(IShellItemArray psiItemArray, IBindCtx pbc);

        [VtblIndex(9)]
        HRESULT GetFlags([NativeTypeName("EXPCMDFLAGS *")] uint* pFlags);

        [VtblIndex(10)]
        HRESULT EnumSubCommands(IEnumExplorerCommand* ppEnum);
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

        [NativeTypeName("HRESULT (IShellItemArray *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray, ushort**, int> GetTitle;

        [NativeTypeName("HRESULT (IShellItemArray *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray, ushort**, int> GetIcon;

        [NativeTypeName("HRESULT (IShellItemArray *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray, ushort**, int> GetToolTip;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetCanonicalName;

        [NativeTypeName(
            "HRESULT (IShellItemArray *, BOOL, EXPCMDSTATE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItemArray, BOOL, uint*, int> GetState;

        [NativeTypeName("HRESULT (IShellItemArray *, IBindCtx *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray, IBindCtx, int> Invoke;

        [NativeTypeName("HRESULT (EXPCMDFLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFlags;

        [NativeTypeName("HRESULT (IEnumExplorerCommand **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumExplorerCommand*, int> EnumSubCommands;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExplorerCommand"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExplorerCommand(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExplorerCommand"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExplorerCommand(Silk.NET.Windows.IUnknown value)
    {
        return new IExplorerCommand(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExplorerCommand"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExplorerCommand"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IExplorerCommand value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
