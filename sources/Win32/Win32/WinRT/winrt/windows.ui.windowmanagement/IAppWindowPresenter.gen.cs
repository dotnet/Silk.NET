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

[Guid("5AE9ED73-E1FD-5317-AD78-5A3ED271BBDE")]
[NativeTypeName("struct IAppWindowPresenter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindowPresenter : IAppWindowPresenter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppWindowPresenter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppWindowPresenter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppWindowPresenter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppWindowPresenter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppWindowPresenter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppWindowPresenter, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppWindowPresenter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetConfiguration(
        [NativeTypeName(
            "ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration **"
        )]
            IAppWindowPresentationConfiguration* result
    )
    {
        return (
            (delegate* unmanaged<IAppWindowPresenter, IAppWindowPresentationConfiguration*, int>)(
                (*lpVtbl)[6]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsPresentationSupported(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowPresentationKind")]
            AppWindowPresentationKind presentationKind,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IAppWindowPresenter, AppWindowPresentationKind, byte*, int>)(
                (*lpVtbl)[7]
            )
        )(this, presentationKind, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestPresentation(
        [NativeTypeName(
            "ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration *"
        )]
            IAppWindowPresentationConfiguration configuration,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<
                IAppWindowPresenter,
                IAppWindowPresentationConfiguration,
                byte*,
                int>)((*lpVtbl)[8])
        )(this, configuration, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestPresentationByKind(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowPresentationKind")]
            AppWindowPresentationKind presentationKind,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IAppWindowPresenter, AppWindowPresentationKind, byte*, int>)(
                (*lpVtbl)[9]
            )
        )(this, presentationKind, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetConfiguration(
            [NativeTypeName(
                "ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration **"
            )]
                IAppWindowPresentationConfiguration* result
        );

        [VtblIndex(7)]
        HRESULT IsPresentationSupported(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowPresentationKind")]
                AppWindowPresentationKind presentationKind,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(8)]
        HRESULT RequestPresentation(
            [NativeTypeName(
                "ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration *"
            )]
                IAppWindowPresentationConfiguration configuration,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(9)]
        HRESULT RequestPresentationByKind(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::AppWindowPresentationKind")]
                AppWindowPresentationKind presentationKind,
            [NativeTypeName("boolean *")] byte* result
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
            "HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppWindowPresentationConfiguration*,
            int> GetConfiguration;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::AppWindowPresentationKind, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppWindowPresentationKind,
            byte*,
            int> IsPresentationSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowPresentationConfiguration *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppWindowPresentationConfiguration,
            byte*,
            int> RequestPresentation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::AppWindowPresentationKind, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppWindowPresentationKind,
            byte*,
            int> RequestPresentationByKind;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppWindowPresenter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppWindowPresenter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppWindowPresenter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppWindowPresenter(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppWindowPresenter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppWindowPresenter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppWindowPresenter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppWindowPresenter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppWindowPresenter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppWindowPresenter(Silk.NET.Windows.IUnknown value)
    {
        return new IAppWindowPresenter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppWindowPresenter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppWindowPresenter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppWindowPresenter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
