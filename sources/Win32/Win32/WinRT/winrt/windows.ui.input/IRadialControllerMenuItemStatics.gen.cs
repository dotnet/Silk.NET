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

[Guid("249E0887-D842-4524-9DF8-E0D647EDC887")]
[NativeTypeName("struct IRadialControllerMenuItemStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerMenuItemStatics
    : IRadialControllerMenuItemStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialControllerMenuItemStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRadialControllerMenuItemStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRadialControllerMenuItemStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRadialControllerMenuItemStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IRadialControllerMenuItemStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IRadialControllerMenuItemStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IRadialControllerMenuItemStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromIcon(
        HSTRING displayText,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference icon,
        [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")]
            IRadialControllerMenuItem* result
    )
    {
        return (
            (delegate* unmanaged<
                IRadialControllerMenuItemStatics,
                HSTRING,
                IRandomAccessStreamReference,
                IRadialControllerMenuItem*,
                int>)((*lpVtbl)[6])
        )(this, displayText, icon, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromKnownIcon(
        HSTRING displayText,
        [NativeTypeName("ABI::Windows::UI::Input::RadialControllerMenuKnownIcon")]
            RadialControllerMenuKnownIcon value,
        [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")]
            IRadialControllerMenuItem* result
    )
    {
        return (
            (delegate* unmanaged<
                IRadialControllerMenuItemStatics,
                HSTRING,
                RadialControllerMenuKnownIcon,
                IRadialControllerMenuItem*,
                int>)((*lpVtbl)[7])
        )(this, displayText, value, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromIcon(
            HSTRING displayText,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference icon,
            [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")]
                IRadialControllerMenuItem* result
        );

        [VtblIndex(7)]
        HRESULT CreateFromKnownIcon(
            HSTRING displayText,
            [NativeTypeName("ABI::Windows::UI::Input::RadialControllerMenuKnownIcon")]
                RadialControllerMenuKnownIcon value,
            [NativeTypeName("ABI::Windows::UI::Input::IRadialControllerMenuItem **")]
                IRadialControllerMenuItem* result
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
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::UI::Input::IRadialControllerMenuItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IRandomAccessStreamReference,
            IRadialControllerMenuItem*,
            int> CreateFromIcon;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Input::RadialControllerMenuKnownIcon, ABI::Windows::UI::Input::IRadialControllerMenuItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            RadialControllerMenuKnownIcon,
            IRadialControllerMenuItem*,
            int> CreateFromKnownIcon;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRadialControllerMenuItemStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRadialControllerMenuItemStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRadialControllerMenuItemStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRadialControllerMenuItemStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IRadialControllerMenuItemStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRadialControllerMenuItemStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRadialControllerMenuItemStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IRadialControllerMenuItemStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRadialControllerMenuItemStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRadialControllerMenuItemStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IRadialControllerMenuItemStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRadialControllerMenuItemStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRadialControllerMenuItemStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IRadialControllerMenuItemStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
