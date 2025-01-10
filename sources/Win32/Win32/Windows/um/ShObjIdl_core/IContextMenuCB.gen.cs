// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3409E930-5A39-11D1-83FA-00A0C90DC849")]
[NativeTypeName("struct IContextMenuCB : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContextMenuCB : IContextMenuCB.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContextMenuCB));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContextMenuCB, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContextMenuCB, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContextMenuCB, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CallBack(
        IShellFolder psf,
        HWND hwndOwner,
        IDataObject pdtobj,
        uint uMsg,
        WPARAM wParam,
        LPARAM lParam
    )
    {
        return (
            (delegate* unmanaged<
                IContextMenuCB,
                IShellFolder,
                HWND,
                IDataObject,
                uint,
                WPARAM,
                LPARAM,
                int>)((*lpVtbl)[3])
        )(this, psf, hwndOwner, pdtobj, uMsg, wParam, lParam);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CallBack(
            IShellFolder psf,
            HWND hwndOwner,
            IDataObject pdtobj,
            uint uMsg,
            WPARAM wParam,
            LPARAM lParam
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
            "HRESULT (IShellFolder *, HWND, IDataObject *, UINT, WPARAM, LPARAM) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellFolder,
            HWND,
            IDataObject,
            uint,
            WPARAM,
            LPARAM,
            int> CallBack;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContextMenuCB"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContextMenuCB(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContextMenuCB"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContextMenuCB(Silk.NET.Windows.IUnknown value)
    {
        return new IContextMenuCB(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContextMenuCB"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContextMenuCB"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContextMenuCB value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
