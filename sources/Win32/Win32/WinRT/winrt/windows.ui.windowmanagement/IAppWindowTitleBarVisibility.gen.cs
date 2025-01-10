// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A215A4E3-6E7E-5651-8C3B-624819528154")]
[NativeTypeName("struct IAppWindowTitleBarVisibility : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindowTitleBarVisibility
    : IAppWindowTitleBarVisibility.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppWindowTitleBarVisibility));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppWindowTitleBarVisibility, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppWindowTitleBarVisibility, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppWindowTitleBarVisibility, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppWindowTitleBarVisibility, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppWindowTitleBarVisibility, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAppWindowTitleBarVisibility, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPreferredVisibility(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility *")]
            AppWindowTitleBarVisibility* result
    )
    {
        return (
            (delegate* unmanaged<IAppWindowTitleBarVisibility, AppWindowTitleBarVisibility*, int>)(
                (*lpVtbl)[6]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPreferredVisibility(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility")]
            AppWindowTitleBarVisibility visibilityMode
    )
    {
        return (
            (delegate* unmanaged<IAppWindowTitleBarVisibility, AppWindowTitleBarVisibility, int>)(
                (*lpVtbl)[7]
            )
        )(this, visibilityMode);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetPreferredVisibility(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility *")]
                AppWindowTitleBarVisibility* result
        );

        [VtblIndex(7)]
        HRESULT SetPreferredVisibility(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility")]
                AppWindowTitleBarVisibility visibilityMode
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppWindowTitleBarVisibility*,
            int> GetPreferredVisibility;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::AppWindowTitleBarVisibility) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppWindowTitleBarVisibility, int> SetPreferredVisibility;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppWindowTitleBarVisibility"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppWindowTitleBarVisibility(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppWindowTitleBarVisibility"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppWindowTitleBarVisibility(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppWindowTitleBarVisibility(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppWindowTitleBarVisibility"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppWindowTitleBarVisibility"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppWindowTitleBarVisibility value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppWindowTitleBarVisibility"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppWindowTitleBarVisibility(Silk.NET.Windows.IUnknown value)
    {
        return new IAppWindowTitleBarVisibility(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppWindowTitleBarVisibility"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppWindowTitleBarVisibility"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppWindowTitleBarVisibility value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
