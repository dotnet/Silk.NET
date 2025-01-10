// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.input.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3D577EF5-4CEE-11E6-B535-001BDC06AB3B")]
[NativeTypeName("struct IRadialControllerIndependentInputSourceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerIndependentInputSourceStatics
    : IRadialControllerIndependentInputSourceStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IRadialControllerIndependentInputSourceStatics)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IRadialControllerIndependentInputSourceStatics,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IRadialControllerIndependentInputSourceStatics, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IRadialControllerIndependentInputSourceStatics, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                IRadialControllerIndependentInputSourceStatics,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IRadialControllerIndependentInputSourceStatics, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IRadialControllerIndependentInputSourceStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateForView(
        [NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView *")]
            ICoreApplicationView view,
        [NativeTypeName(
            "ABI::Windows::UI::Input::Core::IRadialControllerIndependentInputSource **"
        )]
            IRadialControllerIndependentInputSource* result
    )
    {
        return (
            (delegate* unmanaged<
                IRadialControllerIndependentInputSourceStatics,
                ICoreApplicationView,
                IRadialControllerIndependentInputSource*,
                int>)((*lpVtbl)[6])
        )(this, view, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateForView(
            [NativeTypeName("ABI::Windows::ApplicationModel::Core::ICoreApplicationView *")]
                ICoreApplicationView view,
            [NativeTypeName(
                "ABI::Windows::UI::Input::Core::IRadialControllerIndependentInputSource **"
            )]
                IRadialControllerIndependentInputSource* result
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
            "HRESULT (ABI::Windows::ApplicationModel::Core::ICoreApplicationView *, ABI::Windows::UI::Input::Core::IRadialControllerIndependentInputSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICoreApplicationView,
            IRadialControllerIndependentInputSource*,
            int> CreateForView;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRadialControllerIndependentInputSourceStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRadialControllerIndependentInputSourceStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRadialControllerIndependentInputSourceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRadialControllerIndependentInputSourceStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IRadialControllerIndependentInputSourceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRadialControllerIndependentInputSourceStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRadialControllerIndependentInputSourceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IRadialControllerIndependentInputSourceStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRadialControllerIndependentInputSourceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRadialControllerIndependentInputSourceStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IRadialControllerIndependentInputSourceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRadialControllerIndependentInputSourceStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRadialControllerIndependentInputSourceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IRadialControllerIndependentInputSourceStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
