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

[Guid("DD37A898-26BF-467A-9CE5-CCF3FB11371E")]
[NativeTypeName("struct IManipulationInertiaStartingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IManipulationInertiaStartingEventArgs
    : IManipulationInertiaStartingEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IManipulationInertiaStartingEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IManipulationInertiaStartingEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IManipulationInertiaStartingEventArgs, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IManipulationInertiaStartingEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IManipulationInertiaStartingEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IManipulationInertiaStartingEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PointerDeviceType(
        [NativeTypeName("ABI::Windows::Devices::Input::PointerDeviceType *")]
            PointerDeviceType* value
    )
    {
        return (
            (delegate* unmanaged<IManipulationInertiaStartingEventArgs, PointerDeviceType*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return (
            (delegate* unmanaged<IManipulationInertiaStartingEventArgs, Point*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Delta(
        [NativeTypeName("ABI::Windows::UI::Input::ManipulationDelta *")] ManipulationDelta* value
    )
    {
        return (
            (delegate* unmanaged<IManipulationInertiaStartingEventArgs, ManipulationDelta*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Cumulative(
        [NativeTypeName("ABI::Windows::UI::Input::ManipulationDelta *")] ManipulationDelta* value
    )
    {
        return (
            (delegate* unmanaged<IManipulationInertiaStartingEventArgs, ManipulationDelta*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Velocities(
        [NativeTypeName("ABI::Windows::UI::Input::ManipulationVelocities *")]
            ManipulationVelocities* value
    )
    {
        return (
            (delegate* unmanaged<
                IManipulationInertiaStartingEventArgs,
                ManipulationVelocities*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PointerDeviceType(
            [NativeTypeName("ABI::Windows::Devices::Input::PointerDeviceType *")]
                PointerDeviceType* value
        );

        [VtblIndex(7)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(8)]
        HRESULT get_Delta(
            [NativeTypeName("ABI::Windows::UI::Input::ManipulationDelta *")]
                ManipulationDelta* value
        );

        [VtblIndex(9)]
        HRESULT get_Cumulative(
            [NativeTypeName("ABI::Windows::UI::Input::ManipulationDelta *")]
                ManipulationDelta* value
        );

        [VtblIndex(10)]
        HRESULT get_Velocities(
            [NativeTypeName("ABI::Windows::UI::Input::ManipulationVelocities *")]
                ManipulationVelocities* value
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
            "HRESULT (ABI::Windows::Devices::Input::PointerDeviceType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PointerDeviceType*, int> get_PointerDeviceType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point*, int> get_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Input::ManipulationDelta *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ManipulationDelta*, int> get_Delta;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Input::ManipulationDelta *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ManipulationDelta*, int> get_Cumulative;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Input::ManipulationVelocities *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ManipulationVelocities*, int> get_Velocities;
    }

    /// <summary>Initializes a new instance of the <see cref = "IManipulationInertiaStartingEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IManipulationInertiaStartingEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IManipulationInertiaStartingEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IManipulationInertiaStartingEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IManipulationInertiaStartingEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IManipulationInertiaStartingEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IManipulationInertiaStartingEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IManipulationInertiaStartingEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IManipulationInertiaStartingEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IManipulationInertiaStartingEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IManipulationInertiaStartingEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IManipulationInertiaStartingEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IManipulationInertiaStartingEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IManipulationInertiaStartingEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
