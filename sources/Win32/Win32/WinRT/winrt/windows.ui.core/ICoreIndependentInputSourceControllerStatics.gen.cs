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

[Guid("3EDC4E20-9A8A-5691-8586-FCA4CB57526D")]
[NativeTypeName("struct ICoreIndependentInputSourceControllerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreIndependentInputSourceControllerStatics
    : ICoreIndependentInputSourceControllerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreIndependentInputSourceControllerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceControllerStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceControllerStatics, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceControllerStatics, uint>)((*lpVtbl)[2])
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
            (delegate* unmanaged<ICoreIndependentInputSourceControllerStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceControllerStatics, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICoreIndependentInputSourceControllerStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateForVisual(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual visual,
        [NativeTypeName("ABI::Windows::UI::Core::ICoreIndependentInputSourceController **")]
            ICoreIndependentInputSourceController* result
    )
    {
        return (
            (delegate* unmanaged<
                ICoreIndependentInputSourceControllerStatics,
                IVisual,
                ICoreIndependentInputSourceController*,
                int>)((*lpVtbl)[6])
        )(this, visual, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateForIVisualElement(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisualElement *")]
            IVisualElement visualElement,
        [NativeTypeName("ABI::Windows::UI::Core::ICoreIndependentInputSourceController **")]
            ICoreIndependentInputSourceController* result
    )
    {
        return (
            (delegate* unmanaged<
                ICoreIndependentInputSourceControllerStatics,
                IVisualElement,
                ICoreIndependentInputSourceController*,
                int>)((*lpVtbl)[7])
        )(this, visualElement, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateForVisual(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual visual,
            [NativeTypeName("ABI::Windows::UI::Core::ICoreIndependentInputSourceController **")]
                ICoreIndependentInputSourceController* result
        );

        [VtblIndex(7)]
        HRESULT CreateForIVisualElement(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisualElement *")]
                IVisualElement visualElement,
            [NativeTypeName("ABI::Windows::UI::Core::ICoreIndependentInputSourceController **")]
                ICoreIndependentInputSourceController* result
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
            "HRESULT (ABI::Windows::UI::Composition::IVisual *, ABI::Windows::UI::Core::ICoreIndependentInputSourceController **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVisual,
            ICoreIndependentInputSourceController*,
            int> CreateForVisual;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisualElement *, ABI::Windows::UI::Core::ICoreIndependentInputSourceController **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVisualElement,
            ICoreIndependentInputSourceController*,
            int> CreateForIVisualElement;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreIndependentInputSourceControllerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreIndependentInputSourceControllerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreIndependentInputSourceControllerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreIndependentInputSourceControllerStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICoreIndependentInputSourceControllerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreIndependentInputSourceControllerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreIndependentInputSourceControllerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICoreIndependentInputSourceControllerStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreIndependentInputSourceControllerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreIndependentInputSourceControllerStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICoreIndependentInputSourceControllerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreIndependentInputSourceControllerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreIndependentInputSourceControllerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICoreIndependentInputSourceControllerStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
