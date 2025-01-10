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

[Guid("285B8E72-4328-523F-BCF2-5557C52C3B25")]
[NativeTypeName("struct ICompositionProjectedShadow : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionProjectedShadow
    : ICompositionProjectedShadow.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionProjectedShadow));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadow, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionProjectedShadow, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionProjectedShadow, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadow, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionProjectedShadow, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionProjectedShadow, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BlurRadiusMultiplier(float* value)
    {
        return ((delegate* unmanaged<ICompositionProjectedShadow, float*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_BlurRadiusMultiplier(float value)
    {
        return ((delegate* unmanaged<ICompositionProjectedShadow, float, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Casters(
        [NativeTypeName(
            "ABI::Windows::UI::Composition::ICompositionProjectedShadowCasterCollection **"
        )]
            ICompositionProjectedShadowCasterCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionProjectedShadow,
                ICompositionProjectedShadowCasterCollection*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_LightSource(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionLight **")]
            ICompositionLight* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadow, ICompositionLight*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_LightSource(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionLight *")]
            ICompositionLight value
    )
    {
        return (
            (delegate* unmanaged<ICompositionProjectedShadow, ICompositionLight, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MaxBlurRadius(float* value)
    {
        return ((delegate* unmanaged<ICompositionProjectedShadow, float*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_MaxBlurRadius(float value)
    {
        return ((delegate* unmanaged<ICompositionProjectedShadow, float, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MinBlurRadius(float* value)
    {
        return ((delegate* unmanaged<ICompositionProjectedShadow, float*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_MinBlurRadius(float value)
    {
        return ((delegate* unmanaged<ICompositionProjectedShadow, float, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Receivers(
        [NativeTypeName(
            "ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiverUnorderedCollection **"
        )]
            ICompositionProjectedShadowReceiverUnorderedCollection* value
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionProjectedShadow,
                ICompositionProjectedShadowReceiverUnorderedCollection*,
                int>)((*lpVtbl)[15])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BlurRadiusMultiplier(float* value);

        [VtblIndex(7)]
        HRESULT put_BlurRadiusMultiplier(float value);

        [VtblIndex(8)]
        HRESULT get_Casters(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::ICompositionProjectedShadowCasterCollection **"
            )]
                ICompositionProjectedShadowCasterCollection* value
        );

        [VtblIndex(9)]
        HRESULT get_LightSource(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionLight **")]
                ICompositionLight* value
        );

        [VtblIndex(10)]
        HRESULT put_LightSource(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionLight *")]
                ICompositionLight value
        );

        [VtblIndex(11)]
        HRESULT get_MaxBlurRadius(float* value);

        [VtblIndex(12)]
        HRESULT put_MaxBlurRadius(float value);

        [VtblIndex(13)]
        HRESULT get_MinBlurRadius(float* value);

        [VtblIndex(14)]
        HRESULT put_MinBlurRadius(float value);

        [VtblIndex(15)]
        HRESULT get_Receivers(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiverUnorderedCollection **"
            )]
                ICompositionProjectedShadowReceiverUnorderedCollection* value
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_BlurRadiusMultiplier;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_BlurRadiusMultiplier;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowCasterCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionProjectedShadowCasterCollection*,
            int> get_Casters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionLight **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionLight*, int> get_LightSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionLight *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionLight, int> put_LightSource;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_MaxBlurRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_MaxBlurRadius;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_MinBlurRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_MinBlurRadius;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiverUnorderedCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionProjectedShadowReceiverUnorderedCollection*,
            int> get_Receivers;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionProjectedShadow"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionProjectedShadow(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionProjectedShadow"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionProjectedShadow(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionProjectedShadow(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionProjectedShadow"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionProjectedShadow"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionProjectedShadow value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionProjectedShadow"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionProjectedShadow(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionProjectedShadow(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionProjectedShadow"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionProjectedShadow"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionProjectedShadow value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
