// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8506B35D-F640-4412-ABA0-BAD077E5EA8A")]
[NativeTypeName("struct IRadialControllerMenu : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerMenu : IRadialControllerMenu.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialControllerMenu));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRadialControllerMenu, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRadialControllerMenu, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRadialControllerMenu, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRadialControllerMenu, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRadialControllerMenu, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRadialControllerMenu, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Items(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CRadialControllerMenuItem_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IRadialControllerMenu, IVector<IntPtr>**, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IRadialControllerMenu, byte*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IRadialControllerMenu, byte, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSelectedMenuItem(
        [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")]
            IRadialControllerMenuItem* result
    )
    {
        return (
            (delegate* unmanaged<IRadialControllerMenu, IRadialControllerMenuItem*, int>)(
                (*lpVtbl)[9]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SelectMenuItem(
        [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem *")]
            IRadialControllerMenuItem menuItem
    )
    {
        return (
            (delegate* unmanaged<IRadialControllerMenu, IRadialControllerMenuItem, int>)(
                (*lpVtbl)[10]
            )
        )(this, menuItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TrySelectPreviouslySelectedMenuItem([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IRadialControllerMenu, byte*, int>)((*lpVtbl)[11]))(
            this,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Items(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CRadialControllerMenuItem_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT GetSelectedMenuItem(
            [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")]
                IRadialControllerMenuItem* result
        );

        [VtblIndex(10)]
        HRESULT SelectMenuItem(
            [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem *")]
                IRadialControllerMenuItem menuItem
        );

        [VtblIndex(11)]
        HRESULT TrySelectPreviouslySelectedMenuItem([NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CInput__CRadialControllerMenuItem_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_Items;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Input::IRadialControllerMenuItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRadialControllerMenuItem*, int> GetSelectedMenuItem;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Input::IRadialControllerMenuItem *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRadialControllerMenuItem, int> SelectMenuItem;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> TrySelectPreviouslySelectedMenuItem;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRadialControllerMenu"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRadialControllerMenu(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRadialControllerMenu"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRadialControllerMenu(Silk.NET.WinRT.IInspectable value)
    {
        return new IRadialControllerMenu(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRadialControllerMenu"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRadialControllerMenu"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRadialControllerMenu value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRadialControllerMenu"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRadialControllerMenu(Silk.NET.Windows.IUnknown value)
    {
        return new IRadialControllerMenu(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRadialControllerMenu"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRadialControllerMenu"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRadialControllerMenu value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
