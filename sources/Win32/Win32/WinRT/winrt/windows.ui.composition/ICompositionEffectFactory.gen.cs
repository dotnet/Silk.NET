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

[Guid("BE5624AF-BA7E-4510-9850-41C0B4FF74DF")]
[NativeTypeName("struct ICompositionEffectFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionEffectFactory
    : ICompositionEffectFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionEffectFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionEffectFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionEffectFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionEffectFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionEffectFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionEffectFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionEffectFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectBrush **")]
            ICompositionEffectBrush* result
    )
    {
        return (
            (delegate* unmanaged<ICompositionEffectFactory, ICompositionEffectBrush*, int>)(
                (*lpVtbl)[6]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged<ICompositionEffectFactory, HRESULT*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LoadStatus(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionEffectFactoryLoadStatus *")]
            CompositionEffectFactoryLoadStatus* value
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionEffectFactory,
                CompositionEffectFactoryLoadStatus*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectBrush **")]
                ICompositionEffectBrush* result
        );

        [VtblIndex(7)]
        HRESULT get_ExtendedError(HRESULT* value);

        [VtblIndex(8)]
        HRESULT get_LoadStatus(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionEffectFactoryLoadStatus *")]
                CompositionEffectFactoryLoadStatus* value
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
            "HRESULT (ABI::Windows::UI::Composition::ICompositionEffectBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionEffectBrush*, int> CreateBrush;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, int> get_ExtendedError;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionEffectFactoryLoadStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionEffectFactoryLoadStatus*, int> get_LoadStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionEffectFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionEffectFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionEffectFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionEffectFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionEffectFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionEffectFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionEffectFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionEffectFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionEffectFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionEffectFactory(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionEffectFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionEffectFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionEffectFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionEffectFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
