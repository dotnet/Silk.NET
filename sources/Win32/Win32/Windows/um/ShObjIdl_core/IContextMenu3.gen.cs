// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BCFCE0A0-EC17-11D0-8D10-00A0C90F2719")]
[NativeTypeName("struct IContextMenu3 : IContextMenu2")]
[NativeInheritance("IContextMenu2")]
public unsafe partial struct IContextMenu3 : IContextMenu3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContextMenu3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContextMenu3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContextMenu3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContextMenu3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryContextMenu(
        HMENU hmenu,
        uint indexMenu,
        uint idCmdFirst,
        uint idCmdLast,
        uint uFlags
    )
    {
        return (
            (delegate* unmanaged<IContextMenu3, HMENU, uint, uint, uint, uint, int>)((*lpVtbl)[3])
        )(this, hmenu, indexMenu, idCmdFirst, idCmdLast, uFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InvokeCommand(CMINVOKECOMMANDINFO* pici)
    {
        return ((delegate* unmanaged<IContextMenu3, CMINVOKECOMMANDINFO*, int>)((*lpVtbl)[4]))(
            this,
            pici
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCommandString(
        [NativeTypeName("UINT_PTR")] nuint idCmd,
        uint uType,
        uint* pReserved,
        [NativeTypeName("CHAR *")] sbyte* pszName,
        uint cchMax
    )
    {
        return (
            (delegate* unmanaged<IContextMenu3, nuint, uint, uint*, sbyte*, uint, int>)(
                (*lpVtbl)[5]
            )
        )(this, idCmd, uType, pReserved, pszName, cchMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT HandleMenuMsg(uint uMsg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<IContextMenu3, uint, WPARAM, LPARAM, int>)((*lpVtbl)[6]))(
            this,
            uMsg,
            wParam,
            lParam
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT HandleMenuMsg2(uint uMsg, WPARAM wParam, LPARAM lParam, LRESULT* plResult)
    {
        return (
            (delegate* unmanaged<IContextMenu3, uint, WPARAM, LPARAM, LRESULT*, int>)((*lpVtbl)[7])
        )(this, uMsg, wParam, lParam, plResult);
    }

    public interface Interface : IContextMenu2.Interface
    {
        [VtblIndex(7)]
        HRESULT HandleMenuMsg2(uint uMsg, WPARAM wParam, LPARAM lParam, LRESULT* plResult);
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

        [NativeTypeName("HRESULT (HMENU, UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU, uint, uint, uint, uint, int> QueryContextMenu;

        [NativeTypeName("HRESULT (CMINVOKECOMMANDINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CMINVOKECOMMANDINFO*, int> InvokeCommand;

        [NativeTypeName("HRESULT (UINT_PTR, UINT, UINT *, CHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, uint, uint*, sbyte*, uint, int> GetCommandString;

        [NativeTypeName("HRESULT (UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WPARAM, LPARAM, int> HandleMenuMsg;

        [NativeTypeName("HRESULT (UINT, WPARAM, LPARAM, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WPARAM, LPARAM, LRESULT*, int> HandleMenuMsg2;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContextMenu3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContextMenu3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IContextMenu2"/> to <see cref = "IContextMenu3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IContextMenu2"/> instance to be converted </param>
    public static explicit operator IContextMenu3(Silk.NET.Windows.IContextMenu2 value)
    {
        return new IContextMenu3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContextMenu3"/> to <see cref = "Silk.NET.Windows.IContextMenu2"/>.</summary>
    /// <param name = "value">The <see cref = "IContextMenu3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IContextMenu2(IContextMenu3 value)
    {
        return new Silk.NET.Windows.IContextMenu2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IContextMenu"/> to <see cref = "IContextMenu3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IContextMenu"/> instance to be converted </param>
    public static explicit operator IContextMenu3(Silk.NET.Windows.IContextMenu value)
    {
        return new IContextMenu3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContextMenu3"/> to <see cref = "Silk.NET.Windows.IContextMenu"/>.</summary>
    /// <param name = "value">The <see cref = "IContextMenu3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IContextMenu(IContextMenu3 value)
    {
        return new Silk.NET.Windows.IContextMenu(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContextMenu3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContextMenu3(Silk.NET.Windows.IUnknown value)
    {
        return new IContextMenu3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContextMenu3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContextMenu3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContextMenu3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
