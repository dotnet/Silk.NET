// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B1D7D426-1E36-5A62-BE56-A16112FDD148")]
[NativeTypeName("struct ICompositionProjectedShadowCaster : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionProjectedShadowCaster
    : ICompositionProjectedShadowCaster.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionProjectedShadowCaster));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadowCaster, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionProjectedShadowCaster, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionProjectedShadowCaster, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadowCaster, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadowCaster, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadowCaster, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Brush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")]
            ICompositionBrush* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadowCaster, ICompositionBrush*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Brush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")]
            ICompositionBrush value
    )
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadowCaster, ICompositionBrush, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CastingVisual(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadowCaster, IVisual*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CastingVisual(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual value
    )
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadowCaster, IVisual, int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Brush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")]
                ICompositionBrush* value
        );

        [VtblIndex(7)]
        HRESULT put_Brush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")]
                ICompositionBrush value
        );

        [VtblIndex(8)]
        HRESULT get_CastingVisual(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual* value
        );

        [VtblIndex(9)]
        HRESULT put_CastingVisual(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual value
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
            "HRESULT (ABI::Windows::UI::Composition::ICompositionBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionBrush*, int> get_Brush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionBrush *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionBrush, int> put_Brush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisual **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVisual*, int> get_CastingVisual;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVisual, int> put_CastingVisual;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionProjectedShadowCaster"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionProjectedShadowCaster(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionProjectedShadowCaster"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionProjectedShadowCaster(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICompositionProjectedShadowCaster(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionProjectedShadowCaster"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionProjectedShadowCaster"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICompositionProjectedShadowCaster value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionProjectedShadowCaster"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionProjectedShadowCaster(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICompositionProjectedShadowCaster(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionProjectedShadowCaster"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionProjectedShadowCaster"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICompositionProjectedShadowCaster value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
