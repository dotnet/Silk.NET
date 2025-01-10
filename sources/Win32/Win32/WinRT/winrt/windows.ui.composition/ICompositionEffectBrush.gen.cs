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

[Guid("BF7F795E-83CC-44BF-A447-3E3C071789EC")]
[NativeTypeName("struct ICompositionEffectBrush : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionEffectBrush
    : ICompositionEffectBrush.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionEffectBrush));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionEffectBrush, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionEffectBrush, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionEffectBrush, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionEffectBrush, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionEffectBrush, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionEffectBrush, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceParameter(
        HSTRING name,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")]
            ICompositionBrush* result
    )
    {
        return (
            (delegate* unmanaged<ICompositionEffectBrush, HSTRING, ICompositionBrush*, int>)(
                (*lpVtbl)[6]
            )
        )(this, name, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetSourceParameter(
        HSTRING name,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")]
            ICompositionBrush source
    )
    {
        return (
            (delegate* unmanaged<ICompositionEffectBrush, HSTRING, ICompositionBrush, int>)(
                (*lpVtbl)[7]
            )
        )(this, name, source);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetSourceParameter(
            HSTRING name,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush **")]
                ICompositionBrush* result
        );

        [VtblIndex(7)]
        HRESULT SetSourceParameter(
            HSTRING name,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBrush *")]
                ICompositionBrush source
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
            "HRESULT (HSTRING, ABI::Windows::UI::Composition::ICompositionBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, ICompositionBrush*, int> GetSourceParameter;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Composition::ICompositionBrush *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, ICompositionBrush, int> SetSourceParameter;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionEffectBrush"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionEffectBrush(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionEffectBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionEffectBrush(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionEffectBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionEffectBrush"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionEffectBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionEffectBrush value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionEffectBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionEffectBrush(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionEffectBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionEffectBrush"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionEffectBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionEffectBrush value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
