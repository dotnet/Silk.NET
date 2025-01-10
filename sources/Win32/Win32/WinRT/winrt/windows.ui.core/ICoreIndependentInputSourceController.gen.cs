// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("0963261C-84FE-578A-83CA-6425309CCDE4")]
[NativeTypeName("struct ICoreIndependentInputSourceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreIndependentInputSourceController
    : ICoreIndependentInputSourceController.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreIndependentInputSourceController));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceController, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICoreIndependentInputSourceController, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreIndependentInputSourceController, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceController, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceController, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceController, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsTransparentForUncontrolledInput([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceController, byte*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsTransparentForUncontrolledInput([NativeTypeName("boolean")] byte value)
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceController, byte, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsPalmRejectionEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceController, byte*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsPalmRejectionEnabled([NativeTypeName("boolean")] byte value)
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceController, byte, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Source(
        [NativeTypeName("ABI::Windows::UI::Core::ICoreInputSourceBase **")]
            ICoreInputSourceBase* value
    )
    {
        return (
            (delegate* unmanaged<
                ICoreIndependentInputSourceController,
                ICoreInputSourceBase*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetControlledInput(
        [NativeTypeName("ABI::Windows::UI::Core::CoreInputDeviceTypes")]
            CoreInputDeviceTypes inputTypes
    )
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceController, CoreInputDeviceTypes, int>)(
                (*lpVtbl)[11]
            )
        )(this, inputTypes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetControlledInputWithFilters(
        [NativeTypeName("ABI::Windows::UI::Core::CoreInputDeviceTypes")]
            CoreInputDeviceTypes inputTypes,
        [NativeTypeName("ABI::Windows::UI::Core::CoreIndependentInputFilters")]
            CoreIndependentInputFilters required,
        [NativeTypeName("ABI::Windows::UI::Core::CoreIndependentInputFilters")]
            CoreIndependentInputFilters excluded
    )
    {
        return (
            (delegate* unmanaged<
                ICoreIndependentInputSourceController,
                CoreInputDeviceTypes,
                CoreIndependentInputFilters,
                CoreIndependentInputFilters,
                int>)((*lpVtbl)[12])
        )(this, inputTypes, required, excluded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsTransparentForUncontrolledInput([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsTransparentForUncontrolledInput([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_IsPalmRejectionEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsPalmRejectionEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_Source(
            [NativeTypeName("ABI::Windows::UI::Core::ICoreInputSourceBase **")]
                ICoreInputSourceBase* value
        );

        [VtblIndex(11)]
        HRESULT SetControlledInput(
            [NativeTypeName("ABI::Windows::UI::Core::CoreInputDeviceTypes")]
                CoreInputDeviceTypes inputTypes
        );

        [VtblIndex(12)]
        HRESULT SetControlledInputWithFilters(
            [NativeTypeName("ABI::Windows::UI::Core::CoreInputDeviceTypes")]
                CoreInputDeviceTypes inputTypes,
            [NativeTypeName("ABI::Windows::UI::Core::CoreIndependentInputFilters")]
                CoreIndependentInputFilters required,
            [NativeTypeName("ABI::Windows::UI::Core::CoreIndependentInputFilters")]
                CoreIndependentInputFilters excluded
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsTransparentForUncontrolledInput;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsTransparentForUncontrolledInput;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsPalmRejectionEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsPalmRejectionEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::ICoreInputSourceBase **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICoreInputSourceBase*, int> get_Source;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::CoreInputDeviceTypes) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreInputDeviceTypes, int> SetControlledInput;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::CoreInputDeviceTypes, ABI::Windows::UI::Core::CoreIndependentInputFilters, ABI::Windows::UI::Core::CoreIndependentInputFilters) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CoreInputDeviceTypes,
            CoreIndependentInputFilters,
            CoreIndependentInputFilters,
            int> SetControlledInputWithFilters;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreIndependentInputSourceController"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreIndependentInputSourceController(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreIndependentInputSourceController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreIndependentInputSourceController(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICoreIndependentInputSourceController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreIndependentInputSourceController"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreIndependentInputSourceController"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICoreIndependentInputSourceController value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreIndependentInputSourceController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreIndependentInputSourceController(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICoreIndependentInputSourceController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreIndependentInputSourceController"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreIndependentInputSourceController"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICoreIndependentInputSourceController value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
