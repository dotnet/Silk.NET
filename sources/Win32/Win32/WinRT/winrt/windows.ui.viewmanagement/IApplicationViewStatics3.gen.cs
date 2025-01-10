// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A28D7594-8C41-4E13-9719-5164796FE4C7")]
[NativeTypeName("struct IApplicationViewStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationViewStatics3
    : IApplicationViewStatics3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationViewStatics3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationViewStatics3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IApplicationViewStatics3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationViewStatics3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IApplicationViewStatics3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IApplicationViewStatics3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IApplicationViewStatics3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PreferredLaunchWindowingMode(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewWindowingMode *")]
            ApplicationViewWindowingMode* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewStatics3, ApplicationViewWindowingMode*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PreferredLaunchWindowingMode(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewWindowingMode")]
            ApplicationViewWindowingMode value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewStatics3, ApplicationViewWindowingMode, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PreferredLaunchViewSize(
        [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value
    )
    {
        return ((delegate* unmanaged<IApplicationViewStatics3, Size*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_PreferredLaunchViewSize(
        [NativeTypeName("ABI::Windows::Foundation::Size")] Size value
    )
    {
        return ((delegate* unmanaged<IApplicationViewStatics3, Size, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PreferredLaunchWindowingMode(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewWindowingMode *")]
                ApplicationViewWindowingMode* value
        );

        [VtblIndex(7)]
        HRESULT put_PreferredLaunchWindowingMode(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewWindowingMode")]
                ApplicationViewWindowingMode value
        );

        [VtblIndex(8)]
        HRESULT get_PreferredLaunchViewSize(
            [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value
        );

        [VtblIndex(9)]
        HRESULT put_PreferredLaunchViewSize(
            [NativeTypeName("ABI::Windows::Foundation::Size")] Size value
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
            "HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewWindowingMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ApplicationViewWindowingMode*,
            int> get_PreferredLaunchWindowingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewWindowingMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ApplicationViewWindowingMode,
            int> put_PreferredLaunchWindowingMode;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> get_PreferredLaunchViewSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size, int> put_PreferredLaunchViewSize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationViewStatics3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationViewStatics3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IApplicationViewStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IApplicationViewStatics3(Silk.NET.WinRT.IInspectable value)
    {
        return new IApplicationViewStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationViewStatics3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationViewStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IApplicationViewStatics3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationViewStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationViewStatics3(Silk.NET.Windows.IUnknown value)
    {
        return new IApplicationViewStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationViewStatics3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationViewStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IApplicationViewStatics3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
