// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("36116642-D713-4B97-9B83-7484A9D00433")]
[NativeTypeName("struct IFileDialogControlEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileDialogControlEvents
    : IFileDialogControlEvents.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileDialogControlEvents));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileDialogControlEvents, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileDialogControlEvents, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileDialogControlEvents, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnItemSelected(
        IFileDialogCustomize pfdc,
        [NativeTypeName("DWORD")] uint dwIDCtl,
        [NativeTypeName("DWORD")] uint dwIDItem
    )
    {
        return (
            (delegate* unmanaged<IFileDialogControlEvents, IFileDialogCustomize, uint, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pfdc, dwIDCtl, dwIDItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnButtonClicked(
        IFileDialogCustomize pfdc,
        [NativeTypeName("DWORD")] uint dwIDCtl
    )
    {
        return (
            (delegate* unmanaged<IFileDialogControlEvents, IFileDialogCustomize, uint, int>)(
                (*lpVtbl)[4]
            )
        )(this, pfdc, dwIDCtl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnCheckButtonToggled(
        IFileDialogCustomize pfdc,
        [NativeTypeName("DWORD")] uint dwIDCtl,
        BOOL bChecked
    )
    {
        return (
            (delegate* unmanaged<IFileDialogControlEvents, IFileDialogCustomize, uint, BOOL, int>)(
                (*lpVtbl)[5]
            )
        )(this, pfdc, dwIDCtl, bChecked);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnControlActivating(
        IFileDialogCustomize pfdc,
        [NativeTypeName("DWORD")] uint dwIDCtl
    )
    {
        return (
            (delegate* unmanaged<IFileDialogControlEvents, IFileDialogCustomize, uint, int>)(
                (*lpVtbl)[6]
            )
        )(this, pfdc, dwIDCtl);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnItemSelected(
            IFileDialogCustomize pfdc,
            [NativeTypeName("DWORD")] uint dwIDCtl,
            [NativeTypeName("DWORD")] uint dwIDItem
        );

        [VtblIndex(4)]
        HRESULT OnButtonClicked(IFileDialogCustomize pfdc, [NativeTypeName("DWORD")] uint dwIDCtl);

        [VtblIndex(5)]
        HRESULT OnCheckButtonToggled(
            IFileDialogCustomize pfdc,
            [NativeTypeName("DWORD")] uint dwIDCtl,
            BOOL bChecked
        );

        [VtblIndex(6)]
        HRESULT OnControlActivating(
            IFileDialogCustomize pfdc,
            [NativeTypeName("DWORD")] uint dwIDCtl
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

        [NativeTypeName("HRESULT (IFileDialogCustomize *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileDialogCustomize, uint, uint, int> OnItemSelected;

        [NativeTypeName("HRESULT (IFileDialogCustomize *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileDialogCustomize, uint, int> OnButtonClicked;

        [NativeTypeName("HRESULT (IFileDialogCustomize *, DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IFileDialogCustomize,
            uint,
            BOOL,
            int> OnCheckButtonToggled;

        [NativeTypeName("HRESULT (IFileDialogCustomize *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFileDialogCustomize, uint, int> OnControlActivating;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileDialogControlEvents"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileDialogControlEvents(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileDialogControlEvents"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileDialogControlEvents(Silk.NET.Windows.IUnknown value)
    {
        return new IFileDialogControlEvents(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileDialogControlEvents"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileDialogControlEvents"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileDialogControlEvents value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
